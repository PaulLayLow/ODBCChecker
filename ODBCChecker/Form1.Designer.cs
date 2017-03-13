namespace ODBCChecker
{
    partial class f_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_domain = new System.Windows.Forms.TextBox();
            this.lbl_domain = new System.Windows.Forms.Label();
            this.lbl_credentials = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_scan = new System.Windows.Forms.Button();
            this.l_main = new System.Windows.Forms.ListView();
            this.lbl_computerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_connection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_totalcomputer = new System.Windows.Forms.TextBox();
            this.txt_totalodbc = new System.Windows.Forms.TextBox();
            this.lbl_totalcomputers = new System.Windows.Forms.Label();
            this.lbl_totalodbc = new System.Windows.Forms.Label();
            this.txt_noOdbc = new System.Windows.Forms.TextBox();
            this.txt_offline = new System.Windows.Forms.TextBox();
            this.txt_unknown = new System.Windows.Forms.TextBox();
            this.lbl_noOdbc = new System.Windows.Forms.Label();
            this.lbl_unknown = new System.Windows.Forms.Label();
            this.lbl_offline = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_domain
            // 
            this.txt_domain.Location = new System.Drawing.Point(103, 12);
            this.txt_domain.Name = "txt_domain";
            this.txt_domain.Size = new System.Drawing.Size(170, 20);
            this.txt_domain.TabIndex = 4;
            // 
            // lbl_domain
            // 
            this.lbl_domain.AutoSize = true;
            this.lbl_domain.Location = new System.Drawing.Point(12, 15);
            this.lbl_domain.Name = "lbl_domain";
            this.lbl_domain.Size = new System.Drawing.Size(80, 13);
            this.lbl_domain.TabIndex = 5;
            this.lbl_domain.Text = "Current Domain";
            // 
            // lbl_credentials
            // 
            this.lbl_credentials.AutoSize = true;
            this.lbl_credentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_credentials.Location = new System.Drawing.Point(12, 51);
            this.lbl_credentials.Name = "lbl_credentials";
            this.lbl_credentials.Size = new System.Drawing.Size(70, 13);
            this.lbl_credentials.TabIndex = 6;
            this.lbl_credentials.Text = "Credentials";
            this.lbl_credentials.Visible = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(12, 76);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 7;
            this.lbl_username.Text = "Username";
            this.lbl_username.Visible = false;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(12, 102);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Password";
            this.lbl_password.Visible = false;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(103, 73);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(170, 20);
            this.txt_username.TabIndex = 9;
            this.txt_username.Visible = false;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(103, 99);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.Size = new System.Drawing.Size(170, 20);
            this.txt_password.TabIndex = 10;
            this.txt_password.Visible = false;
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(328, 12);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(75, 23);
            this.btn_scan.TabIndex = 11;
            this.btn_scan.Text = "Start Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // l_main
            // 
            this.l_main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lbl_computerName,
            this.lbl_connection});
            this.l_main.GridLines = true;
            this.l_main.Location = new System.Drawing.Point(15, 51);
            this.l_main.Name = "l_main";
            this.l_main.Size = new System.Drawing.Size(388, 329);
            this.l_main.TabIndex = 12;
            this.l_main.UseCompatibleStateImageBehavior = false;
            this.l_main.View = System.Windows.Forms.View.Details;
            // 
            // lbl_computerName
            // 
            this.lbl_computerName.Text = "Computer Name";
            this.lbl_computerName.Width = 195;
            // 
            // lbl_connection
            // 
            this.lbl_connection.Text = "ODBC";
            this.lbl_connection.Width = 231;
            // 
            // txt_totalcomputer
            // 
            this.txt_totalcomputer.Location = new System.Drawing.Point(126, 386);
            this.txt_totalcomputer.Name = "txt_totalcomputer";
            this.txt_totalcomputer.Size = new System.Drawing.Size(52, 20);
            this.txt_totalcomputer.TabIndex = 13;
            // 
            // txt_totalodbc
            // 
            this.txt_totalodbc.Location = new System.Drawing.Point(351, 386);
            this.txt_totalodbc.Name = "txt_totalodbc";
            this.txt_totalodbc.Size = new System.Drawing.Size(52, 20);
            this.txt_totalodbc.TabIndex = 14;
            // 
            // lbl_totalcomputers
            // 
            this.lbl_totalcomputers.AutoSize = true;
            this.lbl_totalcomputers.Location = new System.Drawing.Point(33, 389);
            this.lbl_totalcomputers.Name = "lbl_totalcomputers";
            this.lbl_totalcomputers.Size = new System.Drawing.Size(87, 13);
            this.lbl_totalcomputers.TabIndex = 15;
            this.lbl_totalcomputers.Text = "Total Computers:";
            // 
            // lbl_totalodbc
            // 
            this.lbl_totalodbc.AutoSize = true;
            this.lbl_totalodbc.Location = new System.Drawing.Point(214, 389);
            this.lbl_totalodbc.Name = "lbl_totalodbc";
            this.lbl_totalodbc.Size = new System.Drawing.Size(129, 13);
            this.lbl_totalodbc.TabIndex = 16;
            this.lbl_totalodbc.Text = "Total ODBC Connections:";
            // 
            // txt_noOdbc
            // 
            this.txt_noOdbc.Location = new System.Drawing.Point(351, 412);
            this.txt_noOdbc.Name = "txt_noOdbc";
            this.txt_noOdbc.Size = new System.Drawing.Size(52, 20);
            this.txt_noOdbc.TabIndex = 17;
            // 
            // txt_offline
            // 
            this.txt_offline.Location = new System.Drawing.Point(351, 464);
            this.txt_offline.Name = "txt_offline";
            this.txt_offline.Size = new System.Drawing.Size(52, 20);
            this.txt_offline.TabIndex = 18;
            // 
            // txt_unknown
            // 
            this.txt_unknown.Location = new System.Drawing.Point(351, 438);
            this.txt_unknown.Name = "txt_unknown";
            this.txt_unknown.Size = new System.Drawing.Size(52, 20);
            this.txt_unknown.TabIndex = 19;
            // 
            // lbl_noOdbc
            // 
            this.lbl_noOdbc.AutoSize = true;
            this.lbl_noOdbc.Location = new System.Drawing.Point(214, 415);
            this.lbl_noOdbc.Name = "lbl_noOdbc";
            this.lbl_noOdbc.Size = new System.Drawing.Size(119, 13);
            this.lbl_noOdbc.TabIndex = 20;
            this.lbl_noOdbc.Text = "No ODBC Connections:";
            // 
            // lbl_unknown
            // 
            this.lbl_unknown.AutoSize = true;
            this.lbl_unknown.Location = new System.Drawing.Point(214, 441);
            this.lbl_unknown.Name = "lbl_unknown";
            this.lbl_unknown.Size = new System.Drawing.Size(118, 13);
            this.lbl_unknown.TabIndex = 21;
            this.lbl_unknown.Text = "Unknown Connections:";
            // 
            // lbl_offline
            // 
            this.lbl_offline.AutoSize = true;
            this.lbl_offline.Location = new System.Drawing.Point(214, 467);
            this.lbl_offline.Name = "lbl_offline";
            this.lbl_offline.Size = new System.Drawing.Size(40, 13);
            this.lbl_offline.TabIndex = 22;
            this.lbl_offline.Text = "Offline:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(36, 438);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(142, 39);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "Save Results";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // f_main
            // 
            this.AcceptButton = this.btn_scan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 490);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_offline);
            this.Controls.Add(this.lbl_unknown);
            this.Controls.Add(this.lbl_noOdbc);
            this.Controls.Add(this.txt_unknown);
            this.Controls.Add(this.txt_offline);
            this.Controls.Add(this.txt_noOdbc);
            this.Controls.Add(this.lbl_totalodbc);
            this.Controls.Add(this.lbl_totalcomputers);
            this.Controls.Add(this.txt_totalodbc);
            this.Controls.Add(this.txt_totalcomputer);
            this.Controls.Add(this.l_main);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_credentials);
            this.Controls.Add(this.lbl_domain);
            this.Controls.Add(this.txt_domain);
            this.Name = "f_main";
            this.RightToLeftLayout = true;
            this.Text = "ODBC Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_domain;
        private System.Windows.Forms.Label lbl_domain;
        private System.Windows.Forms.Label lbl_credentials;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.ListView l_main;
        private System.Windows.Forms.ColumnHeader lbl_computerName;
        private System.Windows.Forms.ColumnHeader lbl_connection;
        private System.Windows.Forms.TextBox txt_totalcomputer;
        private System.Windows.Forms.TextBox txt_totalodbc;
        private System.Windows.Forms.Label lbl_totalcomputers;
        private System.Windows.Forms.Label lbl_totalodbc;
        private System.Windows.Forms.TextBox txt_noOdbc;
        private System.Windows.Forms.TextBox txt_offline;
        private System.Windows.Forms.TextBox txt_unknown;
        private System.Windows.Forms.Label lbl_noOdbc;
        private System.Windows.Forms.Label lbl_unknown;
        private System.Windows.Forms.Label lbl_offline;
        private System.Windows.Forms.Button btn_save;
    }
}

