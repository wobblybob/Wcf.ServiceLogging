namespace Wcf.ServiceLogging
{
    partial class MainForm
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
            this.lstServices = new System.Windows.Forms.ListView();
            this.prcid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.svcname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.malformedmsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.svcmessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transportmsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tracelevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPublish = new System.Windows.Forms.Button();
            this.cmbMalformed = new System.Windows.Forms.ComboBox();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.cmbTransport = new System.Windows.Forms.ComboBox();
            this.cmbTrace = new System.Windows.Forms.ComboBox();
            this.lblMalformed = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblTransport = new System.Windows.Forms.Label();
            this.lblTrace = new System.Windows.Forms.Label();
            this.chkActivity = new System.Windows.Forms.CheckBox();
            this.rdoRemote = new System.Windows.Forms.RadioButton();
            this.rdoLocal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAuth = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblSvrName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtSvrName = new System.Windows.Forms.TextBox();
            this.grpLogOptions = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grpLogOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstServices
            // 
            this.lstServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prcid,
            this.svcname,
            this.malformedmsg,
            this.svcmessage,
            this.transportmsg,
            this.tracelevel});
            this.lstServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstServices.FullRowSelect = true;
            this.lstServices.GridLines = true;
            this.lstServices.HideSelection = false;
            this.lstServices.Location = new System.Drawing.Point(0, 0);
            this.lstServices.MultiSelect = false;
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(833, 142);
            this.lstServices.TabIndex = 0;
            this.lstServices.UseCompatibleStateImageBehavior = false;
            this.lstServices.View = System.Windows.Forms.View.Details;
            this.lstServices.SelectedIndexChanged += new System.EventHandler(this.ListviewItemChanged);
            // 
            // prcid
            // 
            this.prcid.Text = "Process ID";
            this.prcid.Width = 70;
            // 
            // svcname
            // 
            this.svcname.Text = "Service Name";
            this.svcname.Width = 225;
            // 
            // malformedmsg
            // 
            this.malformedmsg.Text = "Log Malformed Messages";
            this.malformedmsg.Width = 133;
            // 
            // svcmessage
            // 
            this.svcmessage.Text = "Log Service Messages";
            this.svcmessage.Width = 120;
            // 
            // transportmsg
            // 
            this.transportmsg.Text = "Log Transport Messages";
            this.transportmsg.Width = 131;
            // 
            // tracelevel
            // 
            this.tracelevel.Text = "Trace Level";
            this.tracelevel.Width = 146;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(199, 150);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 9;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.ButtonPublishClick);
            // 
            // cmbMalformed
            // 
            this.cmbMalformed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMalformed.FormattingEnabled = true;
            this.cmbMalformed.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbMalformed.Location = new System.Drawing.Point(153, 39);
            this.cmbMalformed.Name = "cmbMalformed";
            this.cmbMalformed.Size = new System.Drawing.Size(121, 21);
            this.cmbMalformed.TabIndex = 1;
            // 
            // cmbService
            // 
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbService.Location = new System.Drawing.Point(153, 66);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(121, 21);
            this.cmbService.TabIndex = 3;
            // 
            // cmbTransport
            // 
            this.cmbTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransport.FormattingEnabled = true;
            this.cmbTransport.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbTransport.Location = new System.Drawing.Point(153, 93);
            this.cmbTransport.Name = "cmbTransport";
            this.cmbTransport.Size = new System.Drawing.Size(121, 21);
            this.cmbTransport.TabIndex = 5;
            // 
            // cmbTrace
            // 
            this.cmbTrace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrace.FormattingEnabled = true;
            this.cmbTrace.Items.AddRange(new object[] {
            "Off",
            "Critical",
            "Error",
            "Warning",
            "Information",
            "Verbose"});
            this.cmbTrace.Location = new System.Drawing.Point(153, 120);
            this.cmbTrace.Name = "cmbTrace";
            this.cmbTrace.Size = new System.Drawing.Size(121, 21);
            this.cmbTrace.TabIndex = 7;
            this.cmbTrace.SelectedIndexChanged += new System.EventHandler(this.TraceLevelChanged);
            // 
            // lblMalformed
            // 
            this.lblMalformed.AutoSize = true;
            this.lblMalformed.Location = new System.Drawing.Point(16, 42);
            this.lblMalformed.Name = "lblMalformed";
            this.lblMalformed.Size = new System.Drawing.Size(131, 13);
            this.lblMalformed.TabIndex = 0;
            this.lblMalformed.Text = "Log Malformed Messages:";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(29, 69);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(118, 13);
            this.lblService.TabIndex = 2;
            this.lblService.Text = "Log Service Messages:";
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(20, 96);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(127, 13);
            this.lblTransport.TabIndex = 4;
            this.lblTransport.Text = "Log Transport Messages:";
            // 
            // lblTrace
            // 
            this.lblTrace.AutoSize = true;
            this.lblTrace.Location = new System.Drawing.Point(80, 123);
            this.lblTrace.Name = "lblTrace";
            this.lblTrace.Size = new System.Drawing.Size(67, 13);
            this.lblTrace.TabIndex = 6;
            this.lblTrace.Text = "Trace Level:";
            // 
            // chkActivity
            // 
            this.chkActivity.AutoSize = true;
            this.chkActivity.Enabled = false;
            this.chkActivity.Location = new System.Drawing.Point(289, 122);
            this.chkActivity.Name = "chkActivity";
            this.chkActivity.Size = new System.Drawing.Size(137, 17);
            this.chkActivity.TabIndex = 8;
            this.chkActivity.Text = "Include Activity Tracing";
            this.chkActivity.UseVisualStyleBackColor = true;
            // 
            // rdoRemote
            // 
            this.rdoRemote.AutoSize = true;
            this.rdoRemote.Location = new System.Drawing.Point(74, 22);
            this.rdoRemote.Name = "rdoRemote";
            this.rdoRemote.Size = new System.Drawing.Size(62, 17);
            this.rdoRemote.TabIndex = 1;
            this.rdoRemote.Text = "Remote";
            this.rdoRemote.UseVisualStyleBackColor = true;
            // 
            // rdoLocal
            // 
            this.rdoLocal.AutoSize = true;
            this.rdoLocal.Checked = true;
            this.rdoLocal.Location = new System.Drawing.Point(17, 22);
            this.rdoLocal.Name = "rdoLocal";
            this.rdoLocal.Size = new System.Drawing.Size(51, 17);
            this.rdoLocal.TabIndex = 0;
            this.rdoLocal.TabStop = true;
            this.rdoLocal.Text = "Local";
            this.rdoLocal.UseVisualStyleBackColor = true;
            this.rdoLocal.CheckedChanged += new System.EventHandler(this.Local_CheckChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAuth);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.lblDomain);
            this.groupBox1.Controls.Add(this.lblSvrName);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtDomain);
            this.groupBox1.Controls.Add(this.txtSvrName);
            this.groupBox1.Controls.Add(this.rdoRemote);
            this.groupBox1.Controls.Add(this.rdoLocal);
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication Type";
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(245, 150);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(75, 23);
            this.btnAuth.TabIndex = 10;
            this.btnAuth.Text = "Authenticate";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.ButtonAuthenticateClick);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(35, 127);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(28, 101);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(63, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User Name:";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(14, 75);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(77, 13);
            this.lblDomain.TabIndex = 4;
            this.lblDomain.Text = "Domain Name:";
            // 
            // lblSvrName
            // 
            this.lblSvrName.AutoSize = true;
            this.lblSvrName.Location = new System.Drawing.Point(19, 49);
            this.lblSvrName.Name = "lblSvrName";
            this.lblSvrName.Size = new System.Drawing.Size(72, 13);
            this.lblSvrName.TabIndex = 2;
            this.lblSvrName.Text = "Server Name:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(97, 124);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(223, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(97, 98);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(223, 20);
            this.txtUserName.TabIndex = 7;
            // 
            // txtDomain
            // 
            this.txtDomain.Enabled = false;
            this.txtDomain.Location = new System.Drawing.Point(97, 72);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(223, 20);
            this.txtDomain.TabIndex = 5;
            // 
            // txtSvrName
            // 
            this.txtSvrName.Enabled = false;
            this.txtSvrName.Location = new System.Drawing.Point(97, 46);
            this.txtSvrName.Name = "txtSvrName";
            this.txtSvrName.Size = new System.Drawing.Size(223, 20);
            this.txtSvrName.TabIndex = 3;
            // 
            // grpLogOptions
            // 
            this.grpLogOptions.Controls.Add(this.cmbMalformed);
            this.grpLogOptions.Controls.Add(this.btnPublish);
            this.grpLogOptions.Controls.Add(this.cmbService);
            this.grpLogOptions.Controls.Add(this.chkActivity);
            this.grpLogOptions.Controls.Add(this.cmbTransport);
            this.grpLogOptions.Controls.Add(this.lblTrace);
            this.grpLogOptions.Controls.Add(this.cmbTrace);
            this.grpLogOptions.Controls.Add(this.lblTransport);
            this.grpLogOptions.Controls.Add(this.lblMalformed);
            this.grpLogOptions.Controls.Add(this.lblService);
            this.grpLogOptions.Location = new System.Drawing.Point(358, 150);
            this.grpLogOptions.Name = "grpLogOptions";
            this.grpLogOptions.Size = new System.Drawing.Size(463, 185);
            this.grpLogOptions.TabIndex = 2;
            this.grpLogOptions.TabStop = false;
            this.grpLogOptions.Text = "Logging Options";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 345);
            this.Controls.Add(this.grpLogOptions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstServices);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WCF Service Logging";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpLogOptions.ResumeLayout(false);
            this.grpLogOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstServices;
        private System.Windows.Forms.ColumnHeader svcname;
        private System.Windows.Forms.ColumnHeader malformedmsg;
        private System.Windows.Forms.ColumnHeader svcmessage;
        private System.Windows.Forms.ColumnHeader transportmsg;
        private System.Windows.Forms.ColumnHeader tracelevel;
        private System.Windows.Forms.ColumnHeader prcid;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.ComboBox cmbMalformed;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.ComboBox cmbTransport;
        private System.Windows.Forms.ComboBox cmbTrace;
        private System.Windows.Forms.Label lblMalformed;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.Label lblTrace;
        private System.Windows.Forms.CheckBox chkActivity;
        private System.Windows.Forms.RadioButton rdoRemote;
        private System.Windows.Forms.RadioButton rdoLocal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtSvrName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblSvrName;
        private System.Windows.Forms.GroupBox grpLogOptions;
    }
}

