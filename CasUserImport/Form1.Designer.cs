namespace CasUserImport
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.llChooseFile = new System.Windows.Forms.LinkLabel();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.tImportUser = new System.Windows.Forms.TabControl();
            this.tabImportUser = new System.Windows.Forms.TabPage();
            this.ckbRoles = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbApplications = new System.Windows.Forms.CheckedListBox();
            this.lblChooseApp = new System.Windows.Forms.Label();
            this.cbChannel = new System.Windows.Forms.ComboBox();
            this.lblChooseChannel = new System.Windows.Forms.Label();
            this.btnImportUser = new System.Windows.Forms.Button();
            this.tabMongo = new System.Windows.Forms.TabPage();
            this.lblMongoState = new System.Windows.Forms.Label();
            this.txtMongoPwd = new System.Windows.Forms.TextBox();
            this.txtMongoUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMongoPort = new System.Windows.Forms.TextBox();
            this.txtMongoIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMongoTest = new System.Windows.Forms.Button();
            this.tImportUser.SuspendLayout();
            this.tabImportUser.SuspendLayout();
            this.tabMongo.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.xls|*.xlsx";
            // 
            // llChooseFile
            // 
            this.llChooseFile.AutoSize = true;
            this.llChooseFile.Location = new System.Drawing.Point(8, 10);
            this.llChooseFile.Name = "llChooseFile";
            this.llChooseFile.Size = new System.Drawing.Size(107, 12);
            this.llChooseFile.TabIndex = 3;
            this.llChooseFile.TabStop = true;
            this.llChooseFile.Text = "Choose Users File";
            this.llChooseFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llChooseFile_LinkClicked);
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 12;
            this.lbUsers.Location = new System.Drawing.Point(6, 48);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(493, 400);
            this.lbUsers.TabIndex = 4;
            // 
            // tImportUser
            // 
            this.tImportUser.Controls.Add(this.tabImportUser);
            this.tImportUser.Controls.Add(this.tabMongo);
            this.tImportUser.Location = new System.Drawing.Point(-4, 0);
            this.tImportUser.Name = "tImportUser";
            this.tImportUser.SelectedIndex = 0;
            this.tImportUser.Size = new System.Drawing.Size(768, 487);
            this.tImportUser.TabIndex = 5;
            // 
            // tabImportUser
            // 
            this.tabImportUser.Controls.Add(this.ckbRoles);
            this.tabImportUser.Controls.Add(this.label5);
            this.tabImportUser.Controls.Add(this.ckbApplications);
            this.tabImportUser.Controls.Add(this.lblChooseApp);
            this.tabImportUser.Controls.Add(this.cbChannel);
            this.tabImportUser.Controls.Add(this.lblChooseChannel);
            this.tabImportUser.Controls.Add(this.btnImportUser);
            this.tabImportUser.Controls.Add(this.llChooseFile);
            this.tabImportUser.Controls.Add(this.lbUsers);
            this.tabImportUser.Location = new System.Drawing.Point(4, 22);
            this.tabImportUser.Name = "tabImportUser";
            this.tabImportUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabImportUser.Size = new System.Drawing.Size(760, 461);
            this.tabImportUser.TabIndex = 1;
            this.tabImportUser.Text = "User Import";
            this.tabImportUser.UseVisualStyleBackColor = true;
            // 
            // ckbRoles
            // 
            this.ckbRoles.FormattingEnabled = true;
            this.ckbRoles.Location = new System.Drawing.Point(515, 331);
            this.ckbRoles.Name = "ckbRoles";
            this.ckbRoles.Size = new System.Drawing.Size(233, 84);
            this.ckbRoles.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Roles：";
            // 
            // ckbApplications
            // 
            this.ckbApplications.FormattingEnabled = true;
            this.ckbApplications.Location = new System.Drawing.Point(515, 128);
            this.ckbApplications.Name = "ckbApplications";
            this.ckbApplications.Size = new System.Drawing.Size(233, 148);
            this.ckbApplications.TabIndex = 10;
            this.ckbApplications.SelectedIndexChanged += new System.EventHandler(this.ckbApplications_SelectedIndexChanged);
            // 
            // lblChooseApp
            // 
            this.lblChooseApp.AutoSize = true;
            this.lblChooseApp.Location = new System.Drawing.Point(513, 95);
            this.lblChooseApp.Name = "lblChooseApp";
            this.lblChooseApp.Size = new System.Drawing.Size(89, 12);
            this.lblChooseApp.TabIndex = 9;
            this.lblChooseApp.Text = "Applications：";
            // 
            // cbChannel
            // 
            this.cbChannel.FormattingEnabled = true;
            this.cbChannel.Location = new System.Drawing.Point(515, 48);
            this.cbChannel.Name = "cbChannel";
            this.cbChannel.Size = new System.Drawing.Size(233, 20);
            this.cbChannel.TabIndex = 8;
            this.cbChannel.SelectedIndexChanged += new System.EventHandler(this.cbChannel_SelectedIndexChanged);
            // 
            // lblChooseChannel
            // 
            this.lblChooseChannel.AutoSize = true;
            this.lblChooseChannel.Location = new System.Drawing.Point(513, 10);
            this.lblChooseChannel.Name = "lblChooseChannel";
            this.lblChooseChannel.Size = new System.Drawing.Size(59, 12);
            this.lblChooseChannel.TabIndex = 7;
            this.lblChooseChannel.Text = "Channel：";
            // 
            // btnImportUser
            // 
            this.btnImportUser.Location = new System.Drawing.Point(673, 421);
            this.btnImportUser.Name = "btnImportUser";
            this.btnImportUser.Size = new System.Drawing.Size(75, 27);
            this.btnImportUser.TabIndex = 6;
            this.btnImportUser.Text = "Confirm";
            this.btnImportUser.UseVisualStyleBackColor = true;
            this.btnImportUser.Click += new System.EventHandler(this.btnImportUser_Click);
            // 
            // tabMongo
            // 
            this.tabMongo.Controls.Add(this.lblMongoState);
            this.tabMongo.Controls.Add(this.txtMongoPwd);
            this.tabMongo.Controls.Add(this.txtMongoUser);
            this.tabMongo.Controls.Add(this.label4);
            this.tabMongo.Controls.Add(this.label3);
            this.tabMongo.Controls.Add(this.txtMongoPort);
            this.tabMongo.Controls.Add(this.txtMongoIP);
            this.tabMongo.Controls.Add(this.label2);
            this.tabMongo.Controls.Add(this.label1);
            this.tabMongo.Controls.Add(this.btnMongoTest);
            this.tabMongo.Location = new System.Drawing.Point(4, 22);
            this.tabMongo.Name = "tabMongo";
            this.tabMongo.Padding = new System.Windows.Forms.Padding(3);
            this.tabMongo.Size = new System.Drawing.Size(760, 461);
            this.tabMongo.TabIndex = 0;
            this.tabMongo.Text = "Mongo Connection";
            this.tabMongo.UseVisualStyleBackColor = true;
            // 
            // lblMongoState
            // 
            this.lblMongoState.AutoSize = true;
            this.lblMongoState.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMongoState.ForeColor = System.Drawing.Color.Red;
            this.lblMongoState.Location = new System.Drawing.Point(228, 350);
            this.lblMongoState.Name = "lblMongoState";
            this.lblMongoState.Size = new System.Drawing.Size(0, 14);
            this.lblMongoState.TabIndex = 9;
            // 
            // txtMongoPwd
            // 
            this.txtMongoPwd.Location = new System.Drawing.Point(315, 257);
            this.txtMongoPwd.Name = "txtMongoPwd";
            this.txtMongoPwd.PasswordChar = '*';
            this.txtMongoPwd.Size = new System.Drawing.Size(194, 21);
            this.txtMongoPwd.TabIndex = 8;
            // 
            // txtMongoUser
            // 
            this.txtMongoUser.Location = new System.Drawing.Point(315, 193);
            this.txtMongoUser.Name = "txtMongoUser";
            this.txtMongoUser.Size = new System.Drawing.Size(194, 21);
            this.txtMongoUser.TabIndex = 7;
            this.txtMongoUser.Text = "admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "UserName：";
            // 
            // txtMongoPort
            // 
            this.txtMongoPort.Location = new System.Drawing.Point(315, 129);
            this.txtMongoPort.Name = "txtMongoPort";
            this.txtMongoPort.Size = new System.Drawing.Size(194, 21);
            this.txtMongoPort.TabIndex = 4;
            this.txtMongoPort.Text = "30000";
            // 
            // txtMongoIP
            // 
            this.txtMongoIP.Location = new System.Drawing.Point(315, 64);
            this.txtMongoIP.Name = "txtMongoIP";
            this.txtMongoIP.Size = new System.Drawing.Size(194, 21);
            this.txtMongoIP.TabIndex = 3;
            this.txtMongoIP.Text = "192.168.62.146";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "MongoDB Port：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "MongoDB IP：";
            // 
            // btnMongoTest
            // 
            this.btnMongoTest.Location = new System.Drawing.Point(393, 345);
            this.btnMongoTest.Name = "btnMongoTest";
            this.btnMongoTest.Size = new System.Drawing.Size(116, 23);
            this.btnMongoTest.TabIndex = 0;
            this.btnMongoTest.Text = "Connection Test";
            this.btnMongoTest.UseVisualStyleBackColor = true;
            this.btnMongoTest.Click += new System.EventHandler(this.btnMongoTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 483);
            this.Controls.Add(this.tImportUser);
            this.Name = "Form1";
            this.Text = "User Import to Cas";
            this.tImportUser.ResumeLayout(false);
            this.tabImportUser.ResumeLayout(false);
            this.tabImportUser.PerformLayout();
            this.tabMongo.ResumeLayout(false);
            this.tabMongo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel llChooseFile;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.TabControl tImportUser;
        private System.Windows.Forms.TabPage tabImportUser;
        private System.Windows.Forms.TabPage tabMongo;
        private System.Windows.Forms.Button btnImportUser;
        private System.Windows.Forms.Label lblChooseChannel;
        private System.Windows.Forms.ComboBox cbChannel;
        private System.Windows.Forms.Label lblChooseApp;
        private System.Windows.Forms.CheckedListBox ckbApplications;
        private System.Windows.Forms.TextBox txtMongoPwd;
        private System.Windows.Forms.TextBox txtMongoUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMongoPort;
        private System.Windows.Forms.TextBox txtMongoIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMongoTest;
        private System.Windows.Forms.Label lblMongoState;
        private System.Windows.Forms.CheckedListBox ckbRoles;
        private System.Windows.Forms.Label label5;

    }
}

