
namespace MailFinder
{
    partial class Form1
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
            this.lblNotification = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.lblUrlAdress = new System.Windows.Forms.Label();
            this.lbxUrlAdresses = new System.Windows.Forms.ListBox();
            this.lbxMails = new System.Windows.Forms.ListBox();
            this.lblUrlAdresses = new System.Windows.Forms.Label();
            this.lblMails = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Location = new System.Drawing.Point(61, 72);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(0, 21);
            this.lblNotification.TabIndex = 4;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFind.Location = new System.Drawing.Point(649, 41);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(93, 29);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbxUrl
            // 
            this.tbxUrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxUrl.Location = new System.Drawing.Point(152, 42);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(491, 29);
            this.tbxUrl.TabIndex = 6;
            // 
            // lblUrlAdress
            // 
            this.lblUrlAdress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUrlAdress.AutoSize = true;
            this.lblUrlAdress.Location = new System.Drawing.Point(61, 45);
            this.lblUrlAdress.Name = "lblUrlAdress";
            this.lblUrlAdress.Size = new System.Drawing.Size(85, 21);
            this.lblUrlAdress.TabIndex = 3;
            this.lblUrlAdress.Text = "Url Adress:";
            // 
            // lbxUrlAdresses
            // 
            this.lbxUrlAdresses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbxUrlAdresses.FormattingEnabled = true;
            this.lbxUrlAdresses.ItemHeight = 21;
            this.lbxUrlAdresses.Location = new System.Drawing.Point(65, 139);
            this.lbxUrlAdresses.Name = "lbxUrlAdresses";
            this.lbxUrlAdresses.Size = new System.Drawing.Size(308, 235);
            this.lbxUrlAdresses.TabIndex = 2;
            // 
            // lbxMails
            // 
            this.lbxMails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbxMails.FormattingEnabled = true;
            this.lbxMails.ItemHeight = 21;
            this.lbxMails.Location = new System.Drawing.Point(434, 139);
            this.lbxMails.Name = "lbxMails";
            this.lbxMails.Size = new System.Drawing.Size(308, 235);
            this.lbxMails.TabIndex = 2;
            // 
            // lblUrlAdresses
            // 
            this.lblUrlAdresses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUrlAdresses.AutoSize = true;
            this.lblUrlAdresses.Location = new System.Drawing.Point(61, 115);
            this.lblUrlAdresses.Name = "lblUrlAdresses";
            this.lblUrlAdresses.Size = new System.Drawing.Size(97, 21);
            this.lblUrlAdresses.TabIndex = 3;
            this.lblUrlAdresses.Text = "Url Adresses";
            // 
            // lblMails
            // 
            this.lblMails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMails.AutoSize = true;
            this.lblMails.Location = new System.Drawing.Point(430, 115);
            this.lblMails.Name = "lblMails";
            this.lblMails.Size = new System.Drawing.Size(47, 21);
            this.lblMails.TabIndex = 3;
            this.lblMails.Text = "Mails";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(649, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 426);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbxUrl);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.lblMails);
            this.Controls.Add(this.lblUrlAdress);
            this.Controls.Add(this.lblUrlAdresses);
            this.Controls.Add(this.lbxMails);
            this.Controls.Add(this.lbxUrlAdresses);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(820, 465);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Label lblUrlAdress;
        private System.Windows.Forms.ListBox lbxUrlAdresses;
        private System.Windows.Forms.ListBox lbxMails;
        private System.Windows.Forms.Label lblUrlAdresses;
        private System.Windows.Forms.Label lblMails;
        private System.Windows.Forms.Button btnSave;
    }
}

