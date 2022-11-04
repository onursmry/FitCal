namespace FitCal.UI
{
    partial class FrmReport
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnList = new System.Windows.Forms.Button();
            this.cbxMealList = new System.Windows.Forms.ComboBox();
            this.cbxFoodList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbDate = new System.Windows.Forms.RadioButton();
            this.rdbMeal = new System.Windows.Forms.RadioButton();
            this.rdbFood = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/mm/yyyy";
            this.dtpStartDate.Location = new System.Drawing.Point(135, 21);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/mm/yyyy";
            this.dtpEndDate.Location = new System.Drawing.Point(135, 51);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş:";
            // 
            // dgvReport
            // 
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(3, 16);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(697, 450);
            this.dgvReport.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvReport);
            this.groupBox1.Location = new System.Drawing.Point(12, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 469);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rapor";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(260, 137);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // cbxMealList
            // 
            this.cbxMealList.FormattingEnabled = true;
            this.cbxMealList.Items.AddRange(new object[] {
            "Lütfen Bir Arama Kriteri Seçiniz!",
            "Öğün Türüne Göre",
            "Kaloriye Göre"});
            this.cbxMealList.Location = new System.Drawing.Point(135, 80);
            this.cbxMealList.Name = "cbxMealList";
            this.cbxMealList.Size = new System.Drawing.Size(200, 21);
            this.cbxMealList.TabIndex = 10;
            // 
            // cbxFoodList
            // 
            this.cbxFoodList.FormattingEnabled = true;
            this.cbxFoodList.Items.AddRange(new object[] {
            "Lütfen Bir Arama Kriteri Seçiniz!",
            "En Çok Tüketilen Besin",
            "Kategorilerine Göre Tüketilen Besinler",
            "Öğünlere Göre En Çok Tüketilen Besin",
            "Kalorisine Göre Besinler"});
            this.cbxFoodList.Location = new System.Drawing.Point(135, 110);
            this.cbxFoodList.Name = "cbxFoodList";
            this.cbxFoodList.Size = new System.Drawing.Size(200, 21);
            this.cbxFoodList.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Öğün Raporlama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Besin Raporlama:";
            // 
            // rdbDate
            // 
            this.rdbDate.AutoSize = true;
            this.rdbDate.Location = new System.Drawing.Point(383, 23);
            this.rdbDate.Name = "rdbDate";
            this.rdbDate.Size = new System.Drawing.Size(81, 17);
            this.rdbDate.TabIndex = 14;
            this.rdbDate.TabStop = true;
            this.rdbDate.Text = "Tarihe Göre";
            this.rdbDate.UseVisualStyleBackColor = true;
            // 
            // rdbMeal
            // 
            this.rdbMeal.AutoSize = true;
            this.rdbMeal.Location = new System.Drawing.Point(383, 51);
            this.rdbMeal.Name = "rdbMeal";
            this.rdbMeal.Size = new System.Drawing.Size(83, 17);
            this.rdbMeal.TabIndex = 15;
            this.rdbMeal.TabStop = true;
            this.rdbMeal.Text = "Öğüne Göre";
            this.rdbMeal.UseVisualStyleBackColor = true;
            // 
            // rdbFood
            // 
            this.rdbFood.AutoSize = true;
            this.rdbFood.Location = new System.Drawing.Point(383, 84);
            this.rdbFood.Name = "rdbFood";
            this.rdbFood.Size = new System.Drawing.Size(83, 17);
            this.rdbFood.TabIndex = 16;
            this.rdbFood.TabStop = true;
            this.rdbFood.Text = "Besine Göre";
            this.rdbFood.UseVisualStyleBackColor = true;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 656);
            this.Controls.Add(this.rdbFood);
            this.Controls.Add(this.rdbMeal);
            this.Controls.Add(this.rdbDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxFoodList);
            this.Controls.Add(this.cbxMealList);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ComboBox cbxMealList;
        private System.Windows.Forms.ComboBox cbxFoodList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbDate;
        private System.Windows.Forms.RadioButton rdbMeal;
        private System.Windows.Forms.RadioButton rdbFood;
    }
}