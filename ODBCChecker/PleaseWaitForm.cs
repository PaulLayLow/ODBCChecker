using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODBCChecker
{
    public partial class PleaseWaitForm : Form
    {

        public PleaseWaitForm()
        {
            InitializeComponent();
            progressBarComputers.Maximum = 150;
        }

        public void incrementProgress()
        {
            progressBarComputers.Increment(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
