using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Import Dll
using System.Runtime.InteropServices;

// Read Registry
using System.IO;
using System.Security.Permissions;
using Microsoft.Win32;

// Active Directory
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices;

// Ping Host
using System.Net.NetworkInformation;
using System.Net;

namespace ODBCChecker
{
    public partial class f_main : Form
    {

        // Public Counters
        public int ODBCCount = 0;
        public int computerCount = 0;
        public int unknownCount = 0;
        public int offlineCount = 0;
        public int noODBCCount = 0;

        // Initialize Form
        public f_main()
        {
            InitializeComponent();
            txt_domain.Text = GetSystemDomain();
        }

        // Variables
        public bool authenticated = false;
        public string currentUser;

        // Used for bool to get groups
        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RevertToSelf();

        // Get the domain name
        private string GetSystemDomain()
        {
            try
            {
                return Domain.GetComputerDomain().ToString().ToLower();
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return string.Empty;
            }
        }
        // Search if user/pass combo exists
        private bool GetDirectorySearcher(string usr, string pwd, string dom)
        {
            DirectoryEntry entry = new
                DirectoryEntry("LDAP://" + dom, usr, pwd);
            try
            {
                object obj = entry.NativeObject;
                DirectorySearcher search = new DirectorySearcher(entry);
                search.Filter = "(SAMAccountName=" + usr + ")";
                search.PropertiesToLoad.Add("cn");
            }
            catch (DirectoryServicesCOMException e)
            {
                e.ToString();
                return false;
            }
            return true;
        }

        // Authenticate
        public bool GetUserInformation(string user, string pass)
        {
            if (user.Trim().Length != 0 && pass.Trim().Length != 0)
            {
                string dom = GetSystemDomain();
                if (GetDirectorySearcher(user, pass, dom))
                {
                    authenticated = true;
                    currentUser = user;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // Scan computers, but authenticate first, removed because redundant
        private void btn_scan_Click(object sender, EventArgs e)
        {
            if (true)//(GetUserInformation(txt_username.Text, txt_password.Text)) //Condition commented for now because I don't want to input my password all the time
            {
                //MessageBox.Show("Authenticated");
                scanLan();
            }
            else
            {
                MessageBox.Show("Sorry, Username or Password was wrong. Make sure you are also on the right domain name.");
            }
        }

        // Find names of computers on network
        private void scanLan()
        {
            PleaseWaitForm pleaseWait = new PleaseWaitForm();

            // Show loading screen
            pleaseWait.Show();

            // Keep going even though other dialog is open
            Application.DoEvents();

            // Find computer in domain
            DirectoryEntry root = new DirectoryEntry("WinNT:");
            foreach (DirectoryEntry computers in root.Children) 
            {
                foreach (DirectoryEntry computer in computers.Children)
                {
                    if (computer.Name != "Schema")
                    {
                        if (computer.SchemaClassName == "Computer")
                        {
                            computerCount++;
                            if (PingHost(computer.Name))
                            {
                                ListViewItem listComp = new ListViewItem(computer.Name);
                                listComp.SubItems.Add(getRegName(computer.Name));
                                l_main.Items.Add(listComp);
                                pleaseWait.incrementProgress();
                            }
                            else
                            {
                                offlineCount++;
                                ListViewItem listComp = new ListViewItem(computer.Name);
                                listComp.SubItems.Add("Not Online");
                                l_main.Items.Add(listComp);
                                pleaseWait.incrementProgress();
                            }
                        }
                    }
                }
            }

            // FIll in counter for reports
            computerCount++;
            txt_totalcomputer.Text = computerCount.ToString();
            txt_totalodbc.Text = ODBCCount.ToString();
            txt_noOdbc.Text = noODBCCount.ToString();
            txt_offline.Text = offlineCount.ToString();
            txt_unknown.Text = unknownCount.ToString();

            // Remove dialog once done loading
            pleaseWait.Close();

        }

        // Get the names of the ODBC connections via Registry Keys
        private string getRegName(string computerName)
        {
            
            // For 64-bit Systems
            string ODBC_INI_REG_PATH64 = "Software\\Wow6432Node\\ODBC\\ODBC.INI\\";
            try
            {
                var sourcesKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, computerName).OpenSubKey(ODBC_INI_REG_PATH64 + "ODBC Data Sources");
                if (sourcesKey == null)
                {
                    throw new Exception("ODBC Registry key for sources does not exist");
                }

                string[] allCon = sourcesKey.GetValueNames();
                ODBCCount++;
                if (allCon.Length == 0)
                {
                    noODBCCount++;
                    return "No Connection to ODBC found.";
                }
                else
                {
                    return string.Join(", ", allCon);
                }
                    
            }
            catch
            {

                // Try 32-bit if 64-bit didn't work
                string ODBC_INI_REG_PATH32 = "Software\\ODBC\\ODBC.INI\\";
                try
                {
                    var sourcesKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, computerName).OpenSubKey(ODBC_INI_REG_PATH32 + "ODBC Data Sources");
                    if (sourcesKey == null)
                    {
                        throw new Exception("ODBC Registry key for sources does not exist");
                    }

                    string[] allCon = sourcesKey.GetValueNames();
                    ODBCCount++;
                    if (allCon.Length == 0)
                    {
                        noODBCCount++;
                        return "No Connection to ODBC found.";
                    }
                    else
                    {
                        return string.Join(", ", allCon);
                    }

                }
                catch
                {

                    // If user using this is not an admin on the remote computer, they will not have access to their registry.
                    unknownCount++;
                    return "Login as Sysadmin to view";
                }
            }
        }

        // See if computer is online, added here to improve runtime
        public bool PingHost(string host)
        {
            try
            {
                Ping pingSender = new Ping();
                PingOptions options = new PingOptions();

                options.DontFragment = true;

                // Create a buffer of 32 bytes of data to be transmitted.
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 1;
                PingReply reply = pingSender.Send(host, timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            StringBuilder sb;
            string desktopPath = Environment.GetFolderPath(
                         System.Environment.SpecialFolder.DesktopDirectory);
            var sw = new StreamWriter(desktopPath + "\\ODBC.txt");
            if (l_main.Items.Count > 0)
            {
                // the actual data
                foreach (ListViewItem lvi in l_main.Items)
                {
                    sb = new StringBuilder();

                    sb.Append(lvi.SubItems[0].Text + "    ");
                    sb.Append(lvi.SubItems[1].Text + "\r\n");
                    sw.WriteLine(sb.ToString());
                }
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("File was saved onto desktop");
        }
    }
}
