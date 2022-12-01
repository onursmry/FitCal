namespace FitCal.UI
{
    partial class FrmMeal
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
            this.gbxAddMeal = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCalories = new System.Windows.Forms.Label();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbMealNotes = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxMealFood = new System.Windows.Forms.ListBox();
            this.lbxAllFood = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMealName = new System.Windows.Forms.ComboBox();
            this.gbxUpdateMeal = new System.Windows.Forms.GroupBox();
            this.btnUpdateBringInfo = new System.Windows.Forms.Button();
            this.nudUpdateMealId = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUpdatedCalories = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateMeal = new System.Windows.Forms.Button();
            this.btnUpdateAdd = new System.Windows.Forms.Button();
            this.btnUpdateRemove = new System.Windows.Forms.Button();
            this.lbxUserMeal = new System.Windows.Forms.ListBox();
            this.lbxUpdateMeal = new System.Windows.Forms.ListBox();
            this.cbxUpdateMealName = new System.Windows.Forms.ComboBox();
            this.rtbUpdateMealNotes = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxDeletMeal = new System.Windows.Forms.GroupBox();
            this.btnShowMeal = new System.Windows.Forms.Button();
            this.btnRemoveMeal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDeleteMealId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMyMeals = new System.Windows.Forms.DataGridView();
            this.gbxMeals = new System.Windows.Forms.GroupBox();
            this.gbxAddMeal.SuspendLayout();
            this.gbxUpdateMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateMealId)).BeginInit();
            this.gbxDeletMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeleteMealId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyMeals)).BeginInit();
            this.gbxMeals.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAddMeal
            // 
            this.gbxAddMeal.Controls.Add(this.btnSearch);
            this.gbxAddMeal.Controls.Add(this.lblCalories);
            this.gbxAddMeal.Controls.Add(this.btnAddMeal);
            this.gbxAddMeal.Controls.Add(this.label8);
            this.gbxAddMeal.Controls.Add(this.rtbMealNotes);
            this.gbxAddMeal.Controls.Add(this.label7);
            this.gbxAddMeal.Controls.Add(this.btnAdd);
            this.gbxAddMeal.Controls.Add(this.btnRemove);
            this.gbxAddMeal.Controls.Add(this.txtSearchFood);
            this.gbxAddMeal.Controls.Add(this.label2);
            this.gbxAddMeal.Controls.Add(this.lbxMealFood);
            this.gbxAddMeal.Controls.Add(this.lbxAllFood);
            this.gbxAddMeal.Controls.Add(this.label1);
            this.gbxAddMeal.Controls.Add(this.cbxMealName);
            this.gbxAddMeal.Location = new System.Drawing.Point(12, 12);
            this.gbxAddMeal.Name = "gbxAddMeal";
            this.gbxAddMeal.Size = new System.Drawing.Size(397, 449);
            this.gbxAddMeal.TabIndex = 2;
            this.gbxAddMeal.TabStop = false;
            this.gbxAddMeal.Text = "Öğün Ekle";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(138, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 20);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblCalories.Location = new System.Drawing.Point(117, 286);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(19, 13);
            this.lblCalories.TabIndex = 20;
            this.lblCalories.Text = "...";
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Location = new System.Drawing.Point(224, 390);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(167, 47);
            this.btnAddMeal.TabIndex = 8;
            this.btnAddMeal.Text = "Öğün Ekle";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Toplam Alınan Kalori:";
            // 
            // rtbMealNotes
            // 
            this.rtbMealNotes.Location = new System.Drawing.Point(9, 325);
            this.rtbMealNotes.Name = "rtbMealNotes";
            this.rtbMealNotes.Size = new System.Drawing.Size(379, 59);
            this.rtbMealNotes.TabIndex = 18;
            this.rtbMealNotes.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Öğününüzle İlgili Açıklama Girebilirsiniz";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "-->";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(181, 170);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(34, 30);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "<--";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Location = new System.Drawing.Point(64, 20);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(72, 20);
            this.txtSearchFood.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Besin Ara:";
            // 
            // lbxMealFood
            // 
            this.lbxMealFood.FormattingEnabled = true;
            this.lbxMealFood.Location = new System.Drawing.Point(221, 49);
            this.lbxMealFood.Name = "lbxMealFood";
            this.lbxMealFood.Size = new System.Drawing.Size(167, 225);
            this.lbxMealFood.TabIndex = 3;
            // 
            // lbxAllFood
            // 
            this.lbxAllFood.FormattingEnabled = true;
            this.lbxAllFood.Location = new System.Drawing.Point(11, 49);
            this.lbxAllFood.Name = "lbxAllFood";
            this.lbxAllFood.Size = new System.Drawing.Size(164, 225);
            this.lbxAllFood.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğün Adı:";
            // 
            // cbxMealName
            // 
            this.cbxMealName.FormattingEnabled = true;
            this.cbxMealName.Items.AddRange(new object[] {
            "Ana Öğün",
            "Ara Öğün"});
            this.cbxMealName.Location = new System.Drawing.Point(286, 21);
            this.cbxMealName.Name = "cbxMealName";
            this.cbxMealName.Size = new System.Drawing.Size(102, 21);
            this.cbxMealName.TabIndex = 0;
            // 
            // gbxUpdateMeal
            // 
            this.gbxUpdateMeal.Controls.Add(this.btnUpdateBringInfo);
            this.gbxUpdateMeal.Controls.Add(this.nudUpdateMealId);
            this.gbxUpdateMeal.Controls.Add(this.label11);
            this.gbxUpdateMeal.Controls.Add(this.label10);
            this.gbxUpdateMeal.Controls.Add(this.lblUpdatedCalories);
            this.gbxUpdateMeal.Controls.Add(this.label9);
            this.gbxUpdateMeal.Controls.Add(this.btnUpdateMeal);
            this.gbxUpdateMeal.Controls.Add(this.btnUpdateAdd);
            this.gbxUpdateMeal.Controls.Add(this.btnUpdateRemove);
            this.gbxUpdateMeal.Controls.Add(this.lbxUserMeal);
            this.gbxUpdateMeal.Controls.Add(this.lbxUpdateMeal);
            this.gbxUpdateMeal.Controls.Add(this.cbxUpdateMealName);
            this.gbxUpdateMeal.Controls.Add(this.rtbUpdateMealNotes);
            this.gbxUpdateMeal.Controls.Add(this.label4);
            this.gbxUpdateMeal.Controls.Add(this.label3);
            this.gbxUpdateMeal.Location = new System.Drawing.Point(424, 12);
            this.gbxUpdateMeal.Name = "gbxUpdateMeal";
            this.gbxUpdateMeal.Size = new System.Drawing.Size(398, 520);
            this.gbxUpdateMeal.TabIndex = 4;
            this.gbxUpdateMeal.TabStop = false;
            this.gbxUpdateMeal.Text = "Öğün Güncelle";
            // 
            // btnUpdateBringInfo
            // 
            this.btnUpdateBringInfo.Location = new System.Drawing.Point(127, 63);
            this.btnUpdateBringInfo.Name = "btnUpdateBringInfo";
            this.btnUpdateBringInfo.Size = new System.Drawing.Size(109, 22);
            this.btnUpdateBringInfo.TabIndex = 34;
            this.btnUpdateBringInfo.Text = "Bilgileri Getir";
            this.btnUpdateBringInfo.UseVisualStyleBackColor = true;
            this.btnUpdateBringInfo.Click += new System.EventHandler(this.btnUpdateBringInfo_Click);
            // 
            // nudUpdateMealId
            // 
            this.nudUpdateMealId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudUpdateMealId.Location = new System.Drawing.Point(80, 63);
            this.nudUpdateMealId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUpdateMealId.Name = "nudUpdateMealId";
            this.nudUpdateMealId.Size = new System.Drawing.Size(35, 20);
            this.nudUpdateMealId.TabIndex = 32;
            this.nudUpdateMealId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Öğün Id:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(349, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Güncellemek İstediğiniz Öğünü Listeden Seçiniz veya Öğün Idsini Giriniz:";
            // 
            // lblUpdatedCalories
            // 
            this.lblUpdatedCalories.AutoSize = true;
            this.lblUpdatedCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblUpdatedCalories.Location = new System.Drawing.Point(124, 466);
            this.lblUpdatedCalories.Name = "lblUpdatedCalories";
            this.lblUpdatedCalories.Size = new System.Drawing.Size(19, 13);
            this.lblUpdatedCalories.TabIndex = 29;
            this.lblUpdatedCalories.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Güncel Alınan Kalori:";
            // 
            // btnUpdateMeal
            // 
            this.btnUpdateMeal.Location = new System.Drawing.Point(225, 455);
            this.btnUpdateMeal.Name = "btnUpdateMeal";
            this.btnUpdateMeal.Size = new System.Drawing.Size(167, 47);
            this.btnUpdateMeal.TabIndex = 26;
            this.btnUpdateMeal.Text = "Öğün Güncelle";
            this.btnUpdateMeal.UseVisualStyleBackColor = true;
            this.btnUpdateMeal.Click += new System.EventHandler(this.btnUpdateMeal_Click);
            // 
            // btnUpdateAdd
            // 
            this.btnUpdateAdd.Location = new System.Drawing.Point(185, 298);
            this.btnUpdateAdd.Name = "btnUpdateAdd";
            this.btnUpdateAdd.Size = new System.Drawing.Size(34, 30);
            this.btnUpdateAdd.TabIndex = 25;
            this.btnUpdateAdd.Text = "-->";
            this.btnUpdateAdd.UseVisualStyleBackColor = true;
            this.btnUpdateAdd.Click += new System.EventHandler(this.btnUpdateAdd_Click);
            // 
            // btnUpdateRemove
            // 
            this.btnUpdateRemove.Location = new System.Drawing.Point(185, 345);
            this.btnUpdateRemove.Name = "btnUpdateRemove";
            this.btnUpdateRemove.Size = new System.Drawing.Size(34, 30);
            this.btnUpdateRemove.TabIndex = 24;
            this.btnUpdateRemove.Text = "<--";
            this.btnUpdateRemove.UseVisualStyleBackColor = true;
            this.btnUpdateRemove.Click += new System.EventHandler(this.btnUpdateRemove_Click);
            // 
            // lbxUserMeal
            // 
            this.lbxUserMeal.FormattingEnabled = true;
            this.lbxUserMeal.Location = new System.Drawing.Point(225, 224);
            this.lbxUserMeal.Name = "lbxUserMeal";
            this.lbxUserMeal.Size = new System.Drawing.Size(167, 225);
            this.lbxUserMeal.TabIndex = 23;
            // 
            // lbxUpdateMeal
            // 
            this.lbxUpdateMeal.FormattingEnabled = true;
            this.lbxUpdateMeal.Location = new System.Drawing.Point(15, 224);
            this.lbxUpdateMeal.Name = "lbxUpdateMeal";
            this.lbxUpdateMeal.Size = new System.Drawing.Size(164, 225);
            this.lbxUpdateMeal.TabIndex = 22;
            // 
            // cbxUpdateMealName
            // 
            this.cbxUpdateMealName.FormattingEnabled = true;
            this.cbxUpdateMealName.Items.AddRange(new object[] {
            "Ana Öğün",
            "Ara Öğün"});
            this.cbxUpdateMealName.Location = new System.Drawing.Point(80, 96);
            this.cbxUpdateMealName.Name = "cbxUpdateMealName";
            this.cbxUpdateMealName.Size = new System.Drawing.Size(121, 21);
            this.cbxUpdateMealName.TabIndex = 21;
            // 
            // rtbUpdateMealNotes
            // 
            this.rtbUpdateMealNotes.Location = new System.Drawing.Point(80, 129);
            this.rtbUpdateMealNotes.Name = "rtbUpdateMealNotes";
            this.rtbUpdateMealNotes.Size = new System.Drawing.Size(312, 59);
            this.rtbUpdateMealNotes.TabIndex = 21;
            this.rtbUpdateMealNotes.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Öğün Notu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğün Adı:";
            // 
            // gbxDeletMeal
            // 
            this.gbxDeletMeal.Controls.Add(this.btnShowMeal);
            this.gbxDeletMeal.Controls.Add(this.btnRemoveMeal);
            this.gbxDeletMeal.Controls.Add(this.label6);
            this.gbxDeletMeal.Controls.Add(this.nudDeleteMealId);
            this.gbxDeletMeal.Controls.Add(this.label5);
            this.gbxDeletMeal.Location = new System.Drawing.Point(424, 538);
            this.gbxDeletMeal.Name = "gbxDeletMeal";
            this.gbxDeletMeal.Size = new System.Drawing.Size(398, 167);
            this.gbxDeletMeal.TabIndex = 5;
            this.gbxDeletMeal.TabStop = false;
            this.gbxDeletMeal.Text = "Öğün Sil";
            // 
            // btnShowMeal
            // 
            this.btnShowMeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowMeal.Location = new System.Drawing.Point(23, 109);
            this.btnShowMeal.Name = "btnShowMeal";
            this.btnShowMeal.Size = new System.Drawing.Size(167, 47);
            this.btnShowMeal.TabIndex = 31;
            this.btnShowMeal.Text = "Öğünü Getir";
            this.btnShowMeal.UseVisualStyleBackColor = true;
            this.btnShowMeal.Click += new System.EventHandler(this.btnShowMeal_Click);
            // 
            // btnRemoveMeal
            // 
            this.btnRemoveMeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveMeal.Location = new System.Drawing.Point(221, 109);
            this.btnRemoveMeal.Name = "btnRemoveMeal";
            this.btnRemoveMeal.Size = new System.Drawing.Size(167, 47);
            this.btnRemoveMeal.TabIndex = 30;
            this.btnRemoveMeal.Text = "Öğün Sil";
            this.btnRemoveMeal.UseVisualStyleBackColor = true;
            this.btnRemoveMeal.Click += new System.EventHandler(this.btnRemoveMeal_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Lütfen Öğün Id Giriniz:";
            // 
            // nudDeleteMealId
            // 
            this.nudDeleteMealId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudDeleteMealId.Location = new System.Drawing.Point(79, 74);
            this.nudDeleteMealId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDeleteMealId.Name = "nudDeleteMealId";
            this.nudDeleteMealId.Size = new System.Drawing.Size(35, 20);
            this.nudDeleteMealId.TabIndex = 2;
            this.nudDeleteMealId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Öğün Id:";
            // 
            // dgvMyMeals
            // 
            this.dgvMyMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyMeals.Location = new System.Drawing.Point(3, 16);
            this.dgvMyMeals.Name = "dgvMyMeals";
            this.dgvMyMeals.Size = new System.Drawing.Size(391, 219);
            this.dgvMyMeals.TabIndex = 6;
            // 
            // gbxMeals
            // 
            this.gbxMeals.Controls.Add(this.dgvMyMeals);
            this.gbxMeals.Location = new System.Drawing.Point(12, 467);
            this.gbxMeals.Name = "gbxMeals";
            this.gbxMeals.Size = new System.Drawing.Size(397, 238);
            this.gbxMeals.TabIndex = 6;
            this.gbxMeals.TabStop = false;
            this.gbxMeals.Text = "Öğünlerim";
            // 
            // FrmMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 709);
            this.Controls.Add(this.gbxMeals);
            this.Controls.Add(this.gbxDeletMeal);
            this.Controls.Add(this.gbxUpdateMeal);
            this.Controls.Add(this.gbxAddMeal);
            this.Name = "FrmMeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMeal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMeal_FormClosed);
            this.Load += new System.EventHandler(this.FrmMeal_Load);
            this.gbxAddMeal.ResumeLayout(false);
            this.gbxAddMeal.PerformLayout();
            this.gbxUpdateMeal.ResumeLayout(false);
            this.gbxUpdateMeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateMealId)).EndInit();
            this.gbxDeletMeal.ResumeLayout(false);
            this.gbxDeletMeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeleteMealId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyMeals)).EndInit();
            this.gbxMeals.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxAddMeal;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxMealFood;
        private System.Windows.Forms.ListBox lbxAllFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMealName;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbMealNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxUpdateMeal;
        private System.Windows.Forms.GroupBox gbxDeletMeal;
        private System.Windows.Forms.DataGridView dgvMyMeals;
        private System.Windows.Forms.GroupBox gbxMeals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUpdateMealName;
        private System.Windows.Forms.RichTextBox rtbUpdateMealNotes;
        private System.Windows.Forms.NumericUpDown nudUpdateMealId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUpdatedCalories;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdateMeal;
        private System.Windows.Forms.Button btnUpdateAdd;
        private System.Windows.Forms.Button btnUpdateRemove;
        private System.Windows.Forms.ListBox lbxUserMeal;
        private System.Windows.Forms.ListBox lbxUpdateMeal;
        private System.Windows.Forms.Button btnShowMeal;
        private System.Windows.Forms.Button btnRemoveMeal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDeleteMealId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateBringInfo;
        private System.Windows.Forms.Button btnSearch;
    }
}