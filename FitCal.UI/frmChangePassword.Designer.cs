namespace FitCal.UI
{
    partial class FrmChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtSecurityKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPasswordRepeat = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnGetUser = new System.Windows.Forms.Button();
            this.txtSecurityQuestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Güvenlik Sorusu Cevabınız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Güvenlik Sorunuz:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(169, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(214, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // txtSecurityKey
            // 
            this.txtSecurityKey.Location = new System.Drawing.Point(169, 90);
            this.txtSecurityKey.Name = "txtSecurityKey";
            this.txtSecurityKey.Size = new System.Drawing.Size(214, 20);
            this.txtSecurityKey.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yeni Parola:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yeni Parola Tekrar:";
            // 
            // txtPasswordRepeat
            // 
            this.txtPasswordRepeat.Location = new System.Drawing.Point(169, 150);
            this.txtPasswordRepeat.Name = "txtPasswordRepeat";
            this.txtPasswordRepeat.Size = new System.Drawing.Size(214, 20);
            this.txtPasswordRepeat.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(169, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(214, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(389, 150);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(100, 23);
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.Text = "Parolamı Güncelle";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnGetUser
            // 
            this.btnGetUser.Location = new System.Drawing.Point(389, 28);
            this.btnGetUser.Name = "btnGetUser";
            this.btnGetUser.Size = new System.Drawing.Size(100, 23);
            this.btnGetUser.TabIndex = 11;
            this.btnGetUser.Text = "Kullanıcıyı Bul";
            this.btnGetUser.UseVisualStyleBackColor = true;
            // 
            // txtSecurityQuestion
            // 
            this.txtSecurityQuestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSecurityQuestion.Location = new System.Drawing.Point(169, 60);
            this.txtSecurityQuestion.Name = "txtSecurityQuestion";
            this.txtSecurityQuestion.ReadOnly = true;
            this.txtSecurityQuestion.Size = new System.Drawing.Size(214, 20);
            this.txtSecurityQuestion.TabIndex = 2;
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 188);
            this.Controls.Add(this.txtSecurityQuestion);
            this.Controls.Add(this.btnGetUser);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPasswordRepeat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSecurityKey);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtSecurityKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPasswordRepeat;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnGetUser;
        private System.Windows.Forms.TextBox txtSecurityQuestion;
    }
}