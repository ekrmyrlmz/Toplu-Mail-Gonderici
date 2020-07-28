namespace TopluMailGonderici
{
    partial class Anaform1
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
            this.lstMails = new System.Windows.Forms.ListBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.btnMailSender = new System.Windows.Forms.Button();
            this.btnListImport = new System.Windows.Forms.Button();
            this.lblHTML = new System.Windows.Forms.Label();
            this.tbxSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.lblSSL = new System.Windows.Forms.Label();
            this.lblAuthenticator = new System.Windows.Forms.Label();
            this.checkAuthenticator = new System.Windows.Forms.CheckBox();
            this.checkSSL = new System.Windows.Forms.CheckBox();
            this.rtbxContents = new System.Windows.Forms.RichTextBox();
            this.btnSelectedEmailRemove = new System.Windows.Forms.Button();
            this.btnEmailListClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMails
            // 
            this.lstMails.FormattingEnabled = true;
            this.lstMails.Location = new System.Drawing.Point(14, 83);
            this.lstMails.Name = "lstMails";
            this.lstMails.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstMails.Size = new System.Drawing.Size(221, 355);
            this.lstMails.TabIndex = 0;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.SystemColors.Info;
            this.labelMail.Location = new System.Drawing.Point(16, 62);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(35, 13);
            this.labelMail.TabIndex = 1;
            this.labelMail.Text = "E-mail";
            // 
            // btnMailSender
            // 
            this.btnMailSender.Location = new System.Drawing.Point(160, 57);
            this.btnMailSender.Name = "btnMailSender";
            this.btnMailSender.Size = new System.Drawing.Size(75, 23);
            this.btnMailSender.TabIndex = 2;
            this.btnMailSender.Text = "Gönder";
            this.btnMailSender.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMailSender.UseVisualStyleBackColor = true;
            this.btnMailSender.Click += new System.EventHandler(this.btnMailSender_Click);
            // 
            // btnListImport
            // 
            this.btnListImport.Location = new System.Drawing.Point(106, 57);
            this.btnListImport.Name = "btnListImport";
            this.btnListImport.Size = new System.Drawing.Size(48, 23);
            this.btnListImport.TabIndex = 3;
            this.btnListImport.Text = "Liste txt";
            this.btnListImport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnListImport.UseVisualStyleBackColor = true;
            this.btnListImport.Click += new System.EventHandler(this.btnListImport_Click);
            // 
            // lblHTML
            // 
            this.lblHTML.AutoSize = true;
            this.lblHTML.BackColor = System.Drawing.SystemColors.Info;
            this.lblHTML.Location = new System.Drawing.Point(257, 62);
            this.lblHTML.Name = "lblHTML";
            this.lblHTML.Size = new System.Drawing.Size(93, 13);
            this.lblHTML.TabIndex = 5;
            this.lblHTML.Text = "Mail içerik (HTML)";
            // 
            // tbxSubject
            // 
            this.tbxSubject.Location = new System.Drawing.Point(295, 29);
            this.tbxSubject.Multiline = true;
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.Size = new System.Drawing.Size(194, 20);
            this.tbxSubject.TabIndex = 6;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.SystemColors.Info;
            this.lblSubject.Location = new System.Drawing.Point(257, 33);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(32, 13);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Konu";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.BackColor = System.Drawing.SystemColors.Info;
            this.lblServer.Location = new System.Drawing.Point(557, 33);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(83, 13);
            this.lblServer.TabIndex = 9;
            this.lblServer.Text = "Sunucu IP/Adı :";
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(647, 29);
            this.tbxIP.Multiline = true;
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(129, 20);
            this.tbxIP.TabIndex = 8;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.BackColor = System.Drawing.SystemColors.Info;
            this.lblPort.Location = new System.Drawing.Point(608, 88);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(32, 13);
            this.lblPort.TabIndex = 15;
            this.lblPort.Text = "Port :";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(647, 84);
            this.tbxPort.Multiline = true;
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(129, 20);
            this.tbxPort.TabIndex = 14;
            this.tbxPort.Text = "143";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.Info;
            this.lblPassword.Location = new System.Drawing.Point(606, 149);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(34, 13);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Şifre :";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(647, 145);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(129, 20);
            this.tbxPassword.TabIndex = 18;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.Info;
            this.lblUser.Location = new System.Drawing.Point(588, 115);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 13);
            this.lblUser.TabIndex = 17;
            this.lblUser.Text = "Kullanıcı :";
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(647, 112);
            this.tbxUser.Multiline = true;
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(129, 20);
            this.tbxUser.TabIndex = 16;
            // 
            // lblSSL
            // 
            this.lblSSL.AutoSize = true;
            this.lblSSL.BackColor = System.Drawing.SystemColors.Info;
            this.lblSSL.Location = new System.Drawing.Point(607, 57);
            this.lblSSL.Name = "lblSSL";
            this.lblSSL.Size = new System.Drawing.Size(33, 13);
            this.lblSSL.TabIndex = 21;
            this.lblSSL.Text = "SSL :";
            // 
            // lblAuthenticator
            // 
            this.lblAuthenticator.AutoSize = true;
            this.lblAuthenticator.BackColor = System.Drawing.SystemColors.Info;
            this.lblAuthenticator.Location = new System.Drawing.Point(503, 178);
            this.lblAuthenticator.Name = "lblAuthenticator";
            this.lblAuthenticator.Size = new System.Drawing.Size(137, 13);
            this.lblAuthenticator.TabIndex = 23;
            this.lblAuthenticator.Text = "Kimlik Doğrulaması Gerekli :";
            // 
            // checkAuthenticator
            // 
            this.checkAuthenticator.AutoSize = true;
            this.checkAuthenticator.Location = new System.Drawing.Point(647, 177);
            this.checkAuthenticator.Name = "checkAuthenticator";
            this.checkAuthenticator.Size = new System.Drawing.Size(15, 14);
            this.checkAuthenticator.TabIndex = 24;
            this.checkAuthenticator.UseVisualStyleBackColor = true;
            // 
            // checkSSL
            // 
            this.checkSSL.AutoSize = true;
            this.checkSSL.Location = new System.Drawing.Point(647, 56);
            this.checkSSL.Name = "checkSSL";
            this.checkSSL.Size = new System.Drawing.Size(15, 14);
            this.checkSSL.TabIndex = 25;
            this.checkSSL.UseVisualStyleBackColor = true;
            // 
            // rtbxContents
            // 
            this.rtbxContents.Location = new System.Drawing.Point(260, 84);
            this.rtbxContents.Name = "rtbxContents";
            this.rtbxContents.Size = new System.Drawing.Size(229, 352);
            this.rtbxContents.TabIndex = 26;
            this.rtbxContents.Text = "test test test test test test test test ";
            // 
            // btnSelectedEmailRemove
            // 
            this.btnSelectedEmailRemove.Location = new System.Drawing.Point(19, 12);
            this.btnSelectedEmailRemove.Name = "btnSelectedEmailRemove";
            this.btnSelectedEmailRemove.Size = new System.Drawing.Size(112, 23);
            this.btnSelectedEmailRemove.TabIndex = 27;
            this.btnSelectedEmailRemove.Text = "Seçili Eposta Sil";
            this.btnSelectedEmailRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSelectedEmailRemove.UseVisualStyleBackColor = true;
            this.btnSelectedEmailRemove.Click += new System.EventHandler(this.btnSelectedEmailRemove_Click);
            // 
            // btnEmailListClear
            // 
            this.btnEmailListClear.Location = new System.Drawing.Point(137, 12);
            this.btnEmailListClear.Name = "btnEmailListClear";
            this.btnEmailListClear.Size = new System.Drawing.Size(98, 23);
            this.btnEmailListClear.TabIndex = 28;
            this.btnEmailListClear.Text = "Tümünü Sil";
            this.btnEmailListClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmailListClear.UseVisualStyleBackColor = true;
            this.btnEmailListClear.Click += new System.EventHandler(this.btnEmailListClear_Click);
            // 
            // Anaform1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 466);
            this.Controls.Add(this.btnEmailListClear);
            this.Controls.Add(this.btnSelectedEmailRemove);
            this.Controls.Add(this.rtbxContents);
            this.Controls.Add(this.checkSSL);
            this.Controls.Add(this.checkAuthenticator);
            this.Controls.Add(this.lblAuthenticator);
            this.Controls.Add(this.lblSSL);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.tbxSubject);
            this.Controls.Add(this.lblHTML);
            this.Controls.Add(this.btnListImport);
            this.Controls.Add(this.btnMailSender);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.lstMails);
            this.Name = "Anaform1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplu Mail Gonder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMails;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Button btnMailSender;
        private System.Windows.Forms.Button btnListImport;
        private System.Windows.Forms.Label lblHTML;
        private System.Windows.Forms.TextBox tbxSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.Label lblSSL;
        private System.Windows.Forms.Label lblAuthenticator;
        private System.Windows.Forms.CheckBox checkAuthenticator;
        private System.Windows.Forms.CheckBox checkSSL;
        private System.Windows.Forms.RichTextBox rtbxContents;
        private System.Windows.Forms.Button btnSelectedEmailRemove;
        private System.Windows.Forms.Button btnEmailListClear;
    }
}

