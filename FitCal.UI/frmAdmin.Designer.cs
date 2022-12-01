namespace FitCal.UI
{
    partial class FrmAdmin
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
            this.btnAddFood = new System.Windows.Forms.Button();
            this.txtFoodCalories = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxFoodCategory = new System.Windows.Forms.ComboBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxAddFood = new System.Windows.Forms.GroupBox();
            this.lblFoodPhotoPath = new System.Windows.Forms.Label();
            this.btnListFood = new System.Windows.Forms.Button();
            this.txtPortion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFoodPhoto = new System.Windows.Forms.Button();
            this.pbxFoodPhoto = new System.Windows.Forms.PictureBox();
            this.gbxAdminPanel = new System.Windows.Forms.GroupBox();
            this.gbxUserPanel = new System.Windows.Forms.GroupBox();
            this.btnListUsers = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.btnActivateUser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxUserList = new System.Windows.Forms.GroupBox();
            this.dgvAdminPanel = new System.Windows.Forms.DataGridView();
            this.gbxAddFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoodPhoto)).BeginInit();
            this.gbxAdminPanel.SuspendLayout();
            this.gbxUserPanel.SuspendLayout();
            this.gbxUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(224, 317);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(95, 74);
            this.btnAddFood.TabIndex = 23;
            this.btnAddFood.Text = "Besin Ekle";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // txtFoodCalories
            // 
            this.txtFoodCalories.Location = new System.Drawing.Point(97, 73);
            this.txtFoodCalories.Name = "txtFoodCalories";
            this.txtFoodCalories.Size = new System.Drawing.Size(222, 20);
            this.txtFoodCalories.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Kalori Değeri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Besin Kategorisi:";
            // 
            // cbxFoodCategory
            // 
            this.cbxFoodCategory.FormattingEnabled = true;
            this.cbxFoodCategory.Location = new System.Drawing.Point(97, 46);
            this.cbxFoodCategory.Name = "cbxFoodCategory";
            this.cbxFoodCategory.Size = new System.Drawing.Size(222, 21);
            this.cbxFoodCategory.TabIndex = 19;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(97, 20);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(222, 20);
            this.txtFoodName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Besin Adı:";
            // 
            // gbxAddFood
            // 
            this.gbxAddFood.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gbxAddFood.Controls.Add(this.lblFoodPhotoPath);
            this.gbxAddFood.Controls.Add(this.btnListFood);
            this.gbxAddFood.Controls.Add(this.txtPortion);
            this.gbxAddFood.Controls.Add(this.label13);
            this.gbxAddFood.Controls.Add(this.btnFoodPhoto);
            this.gbxAddFood.Controls.Add(this.pbxFoodPhoto);
            this.gbxAddFood.Controls.Add(this.label4);
            this.gbxAddFood.Controls.Add(this.btnAddFood);
            this.gbxAddFood.Controls.Add(this.txtFoodName);
            this.gbxAddFood.Controls.Add(this.txtFoodCalories);
            this.gbxAddFood.Controls.Add(this.cbxFoodCategory);
            this.gbxAddFood.Controls.Add(this.label6);
            this.gbxAddFood.Controls.Add(this.label5);
            this.gbxAddFood.Location = new System.Drawing.Point(902, 12);
            this.gbxAddFood.Name = "gbxAddFood";
            this.gbxAddFood.Size = new System.Drawing.Size(329, 397);
            this.gbxAddFood.TabIndex = 24;
            this.gbxAddFood.TabStop = false;
            this.gbxAddFood.Text = "Besin Ekleme Ekranı";
            // 
            // lblFoodPhotoPath
            // 
            this.lblFoodPhotoPath.AutoSize = true;
            this.lblFoodPhotoPath.Location = new System.Drawing.Point(6, 284);
            this.lblFoodPhotoPath.Name = "lblFoodPhotoPath";
            this.lblFoodPhotoPath.Size = new System.Drawing.Size(61, 13);
            this.lblFoodPhotoPath.TabIndex = 29;
            this.lblFoodPhotoPath.Text = "Dosya Yolu";
            // 
            // btnListFood
            // 
            this.btnListFood.Location = new System.Drawing.Point(30, 317);
            this.btnListFood.Name = "btnListFood";
            this.btnListFood.Size = new System.Drawing.Size(91, 74);
            this.btnListFood.TabIndex = 28;
            this.btnListFood.Text = "Besinleri Listele";
            this.btnListFood.UseVisualStyleBackColor = true;
            this.btnListFood.Click += new System.EventHandler(this.btnListFood_Click);
            // 
            // txtPortion
            // 
            this.txtPortion.Location = new System.Drawing.Point(97, 101);
            this.txtPortion.Name = "txtPortion";
            this.txtPortion.Size = new System.Drawing.Size(222, 20);
            this.txtPortion.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Porsiyon Bilgisi:";
            // 
            // btnFoodPhoto
            // 
            this.btnFoodPhoto.Location = new System.Drawing.Point(127, 317);
            this.btnFoodPhoto.Name = "btnFoodPhoto";
            this.btnFoodPhoto.Size = new System.Drawing.Size(91, 74);
            this.btnFoodPhoto.TabIndex = 25;
            this.btnFoodPhoto.Text = "Fotoğraf Ekle";
            this.btnFoodPhoto.UseVisualStyleBackColor = true;
            this.btnFoodPhoto.Click += new System.EventHandler(this.btnFoodPhoto_Click);
            // 
            // pbxFoodPhoto
            // 
            this.pbxFoodPhoto.Location = new System.Drawing.Point(9, 127);
            this.pbxFoodPhoto.Name = "pbxFoodPhoto";
            this.pbxFoodPhoto.Size = new System.Drawing.Size(310, 147);
            this.pbxFoodPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoodPhoto.TabIndex = 24;
            this.pbxFoodPhoto.TabStop = false;
            // 
            // gbxAdminPanel
            // 
            this.gbxAdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAdminPanel.Controls.Add(this.gbxUserPanel);
            this.gbxAdminPanel.Controls.Add(this.gbxUserList);
            this.gbxAdminPanel.Location = new System.Drawing.Point(12, 12);
            this.gbxAdminPanel.Name = "gbxAdminPanel";
            this.gbxAdminPanel.Size = new System.Drawing.Size(869, 397);
            this.gbxAdminPanel.TabIndex = 25;
            this.gbxAdminPanel.TabStop = false;
            this.gbxAdminPanel.Text = "Yönetici Paneli";
            // 
            // gbxUserPanel
            // 
            this.gbxUserPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gbxUserPanel.Controls.Add(this.btnListUsers);
            this.gbxUserPanel.Controls.Add(this.label12);
            this.gbxUserPanel.Controls.Add(this.txtEmail);
            this.gbxUserPanel.Controls.Add(this.btnUpdate);
            this.gbxUserPanel.Controls.Add(this.label9);
            this.gbxUserPanel.Controls.Add(this.btnDelete);
            this.gbxUserPanel.Controls.Add(this.txtGender);
            this.gbxUserPanel.Controls.Add(this.btnActivateUser);
            this.gbxUserPanel.Controls.Add(this.label8);
            this.gbxUserPanel.Controls.Add(this.btnRefresh);
            this.gbxUserPanel.Controls.Add(this.dtpBirthDate);
            this.gbxUserPanel.Controls.Add(this.txtFirstName);
            this.gbxUserPanel.Controls.Add(this.txtBMI);
            this.gbxUserPanel.Controls.Add(this.txtAge);
            this.gbxUserPanel.Controls.Add(this.label7);
            this.gbxUserPanel.Controls.Add(this.txtHeight);
            this.gbxUserPanel.Controls.Add(this.label1);
            this.gbxUserPanel.Controls.Add(this.txtLastName);
            this.gbxUserPanel.Controls.Add(this.label2);
            this.gbxUserPanel.Controls.Add(this.txtWeight);
            this.gbxUserPanel.Controls.Add(this.label3);
            this.gbxUserPanel.Controls.Add(this.label11);
            this.gbxUserPanel.Controls.Add(this.label10);
            this.gbxUserPanel.Location = new System.Drawing.Point(583, 15);
            this.gbxUserPanel.Name = "gbxUserPanel";
            this.gbxUserPanel.Size = new System.Drawing.Size(280, 376);
            this.gbxUserPanel.TabIndex = 41;
            this.gbxUserPanel.TabStop = false;
            this.gbxUserPanel.Text = "Kullanıcı Yönetimi Paneli";
            // 
            // btnListUsers
            // 
            this.btnListUsers.Location = new System.Drawing.Point(34, 288);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(106, 52);
            this.btnListUsers.TabIndex = 41;
            this.btnListUsers.Text = "Kullanıcıları Listele";
            this.btnListUsers.UseVisualStyleBackColor = true;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ad:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 233);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 40;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "E-Mail:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(177, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(93, 207);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(159, 20);
            this.txtGender.TabIndex = 38;
            // 
            // btnActivateUser
            // 
            this.btnActivateUser.Location = new System.Drawing.Point(146, 288);
            this.btnActivateUser.Name = "btnActivateUser";
            this.btnActivateUser.Size = new System.Drawing.Size(106, 23);
            this.btnActivateUser.TabIndex = 4;
            this.btnActivateUser.Text = "Hesabı Aktif Et";
            this.btnActivateUser.UseVisualStyleBackColor = true;
            this.btnActivateUser.Click += new System.EventHandler(this.btnActivateUser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Cinsiyet:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(146, 317);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Listeyi Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "dd/MM/YYYY";
            this.dtpBirthDate.Location = new System.Drawing.Point(93, 74);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpBirthDate.Size = new System.Drawing.Size(159, 20);
            this.dtpBirthDate.TabIndex = 36;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(93, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(159, 20);
            this.txtFirstName.TabIndex = 23;
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(93, 179);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(159, 20);
            this.txtBMI.TabIndex = 35;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(93, 100);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(159, 20);
            this.txtAge.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "VKE:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(93, 129);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(159, 20);
            this.txtHeight.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Kilo:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(93, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(159, 20);
            this.txtLastName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Boy:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(93, 154);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(159, 20);
            this.txtWeight.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Yaş:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Soyad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Doğum Tarihi:";
            // 
            // gbxUserList
            // 
            this.gbxUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxUserList.Controls.Add(this.dgvAdminPanel);
            this.gbxUserList.Location = new System.Drawing.Point(0, 15);
            this.gbxUserList.Name = "gbxUserList";
            this.gbxUserList.Size = new System.Drawing.Size(577, 376);
            this.gbxUserList.TabIndex = 1;
            this.gbxUserList.TabStop = false;
            // 
            // dgvAdminPanel
            // 
            this.dgvAdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdminPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminPanel.Location = new System.Drawing.Point(3, 16);
            this.dgvAdminPanel.Name = "dgvAdminPanel";
            this.dgvAdminPanel.Size = new System.Drawing.Size(571, 357);
            this.dgvAdminPanel.TabIndex = 0;
            this.dgvAdminPanel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 418);
            this.Controls.Add(this.gbxAdminPanel);
            this.Controls.Add(this.gbxAddFood);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.gbxAddFood.ResumeLayout(false);
            this.gbxAddFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoodPhoto)).EndInit();
            this.gbxAdminPanel.ResumeLayout(false);
            this.gbxUserPanel.ResumeLayout(false);
            this.gbxUserPanel.PerformLayout();
            this.gbxUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.TextBox txtFoodCalories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxFoodCategory;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxAddFood;
        private System.Windows.Forms.GroupBox gbxAdminPanel;
        private System.Windows.Forms.DataGridView dgvAdminPanel;
        private System.Windows.Forms.GroupBox gbxUserList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnActivateUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnFoodPhoto;
        private System.Windows.Forms.PictureBox pbxFoodPhoto;
        private System.Windows.Forms.TextBox txtPortion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnListFood;
        private System.Windows.Forms.GroupBox gbxUserPanel;
        private System.Windows.Forms.Label lblFoodPhotoPath;
        private System.Windows.Forms.Button btnListUsers;
    }
}