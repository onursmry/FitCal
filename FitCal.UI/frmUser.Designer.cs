using FitCal.DATA.Entities;

namespace FitCal.UI
{
    partial class FrmUser
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
            this.mclUser = new System.Windows.Forms.MonthCalendar();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.dgvMeals = new System.Windows.Forms.DataGridView();
            this.gbxMeals = new System.Windows.Forms.GroupBox();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnShowUserInfo = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAddMeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).BeginInit();
            this.gbxMeals.SuspendLayout();
            this.SuspendLayout();
            // 
            // mclUser
            // 
            this.mclUser.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.mclUser.Location = new System.Drawing.Point(437, 18);
            this.mclUser.Name = "mclUser";
            this.mclUser.TabIndex = 0;
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Location = new System.Drawing.Point(12, 12);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(115, 101);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 1;
            this.pbxAvatar.TabStop = false;
            // 
            // dgvMeals
            // 
            this.dgvMeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMeals.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeals.Location = new System.Drawing.Point(3, 16);
            this.dgvMeals.Name = "dgvMeals";
            this.dgvMeals.Size = new System.Drawing.Size(770, 340);
            this.dgvMeals.TabIndex = 2;
            // 
            // gbxMeals
            // 
            this.gbxMeals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxMeals.Controls.Add(this.dgvMeals);
            this.gbxMeals.Location = new System.Drawing.Point(133, 183);
            this.gbxMeals.Name = "gbxMeals";
            this.gbxMeals.Size = new System.Drawing.Size(776, 359);
            this.gbxMeals.TabIndex = 3;
            this.gbxMeals.TabStop = false;
            this.gbxMeals.Text = "Öğünlerim";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblUserInfo.Location = new System.Drawing.Point(133, 12);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(274, 168);
            this.lblUserInfo.TabIndex = 4;
            this.lblUserInfo.Text = "label1";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShowUserInfo
            // 
            this.btnShowUserInfo.Location = new System.Drawing.Point(12, 224);
            this.btnShowUserInfo.Name = "btnShowUserInfo";
            this.btnShowUserInfo.Size = new System.Drawing.Size(115, 101);
            this.btnShowUserInfo.TabIndex = 7;
            this.btnShowUserInfo.Text = "Bilgilerimi Getir";
            this.btnShowUserInfo.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(12, 331);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(115, 101);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Raporlarım";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 438);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(115, 101);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Çıkış";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Location = new System.Drawing.Point(12, 119);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(115, 101);
            this.btnAddMeal.TabIndex = 6;
            this.btnAddMeal.Text = "Öğün Ekle";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnShowUserInfo);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.gbxMeals);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.mclUser);
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).EndInit();
            this.gbxMeals.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mclUser;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.DataGridView dgvMeals;
        private System.Windows.Forms.GroupBox gbxMeals;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnShowUserInfo;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAddMeal;
    }
}