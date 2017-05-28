namespace GUI
{
    partial class ucStatisticStudents
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStatisticByScore = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbConduct = new System.Windows.Forms.GroupBox();
            this.rbtAllConduct = new System.Windows.Forms.RadioButton();
            this.rbtGoodConduct = new System.Windows.Forms.RadioButton();
            this.rbtWeakConduct = new System.Windows.Forms.RadioButton();
            this.rbtAverageConduct = new System.Windows.Forms.RadioButton();
            this.rbtExcellentConduct = new System.Windows.Forms.RadioButton();
            this.grbCapacity = new System.Windows.Forms.GroupBox();
            this.rbtBellowAverageStudent = new System.Windows.Forms.RadioButton();
            this.rbtAllStudent = new System.Windows.Forms.RadioButton();
            this.rbtGoodStudent = new System.Windows.Forms.RadioButton();
            this.rbtWeakStudent = new System.Windows.Forms.RadioButton();
            this.rbtAverageStudent = new System.Windows.Forms.RadioButton();
            this.rbtExcellentStudent = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStatisticByType = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbConduct.SuspendLayout();
            this.grbCapacity.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grbConduct);
            this.panel1.Controls.Add(this.grbCapacity);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 526);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStatisticByScore);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo điểm";
            // 
            // btnStatisticByScore
            // 
            this.btnStatisticByScore.Location = new System.Drawing.Point(80, 74);
            this.btnStatisticByScore.Name = "btnStatisticByScore";
            this.btnStatisticByScore.Size = new System.Drawing.Size(75, 23);
            this.btnStatisticByScore.TabIndex = 4;
            this.btnStatisticByScore.Text = "Thống kê";
            this.btnStatisticByScore.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(193, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(40, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(40, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trong khoảng từ :";
            // 
            // grbConduct
            // 
            this.grbConduct.Controls.Add(this.rbtAllConduct);
            this.grbConduct.Controls.Add(this.rbtGoodConduct);
            this.grbConduct.Controls.Add(this.rbtWeakConduct);
            this.grbConduct.Controls.Add(this.rbtAverageConduct);
            this.grbConduct.Controls.Add(this.rbtExcellentConduct);
            this.grbConduct.Location = new System.Drawing.Point(27, 173);
            this.grbConduct.Name = "grbConduct";
            this.grbConduct.Size = new System.Drawing.Size(243, 84);
            this.grbConduct.TabIndex = 2;
            this.grbConduct.TabStop = false;
            this.grbConduct.Text = "Hạnh kiểm";
            // 
            // rbtAllConduct
            // 
            this.rbtAllConduct.AutoSize = true;
            this.rbtAllConduct.Location = new System.Drawing.Point(178, 51);
            this.rbtAllConduct.Name = "rbtAllConduct";
            this.rbtAllConduct.Size = new System.Drawing.Size(56, 17);
            this.rbtAllConduct.TabIndex = 3;
            this.rbtAllConduct.TabStop = true;
            this.rbtAllConduct.Text = "Tất cả";
            this.rbtAllConduct.UseVisualStyleBackColor = true;
            // 
            // rbtGoodConduct
            // 
            this.rbtGoodConduct.AutoSize = true;
            this.rbtGoodConduct.Location = new System.Drawing.Point(6, 51);
            this.rbtGoodConduct.Name = "rbtGoodConduct";
            this.rbtGoodConduct.Size = new System.Drawing.Size(44, 17);
            this.rbtGoodConduct.TabIndex = 0;
            this.rbtGoodConduct.TabStop = true;
            this.rbtGoodConduct.Text = "Khá";
            this.rbtGoodConduct.UseVisualStyleBackColor = true;
            // 
            // rbtWeakConduct
            // 
            this.rbtWeakConduct.AutoSize = true;
            this.rbtWeakConduct.Location = new System.Drawing.Point(69, 51);
            this.rbtWeakConduct.Name = "rbtWeakConduct";
            this.rbtWeakConduct.Size = new System.Drawing.Size(44, 17);
            this.rbtWeakConduct.TabIndex = 0;
            this.rbtWeakConduct.TabStop = true;
            this.rbtWeakConduct.Text = "Yếu";
            this.rbtWeakConduct.UseVisualStyleBackColor = true;
            // 
            // rbtAverageConduct
            // 
            this.rbtAverageConduct.AutoSize = true;
            this.rbtAverageConduct.Location = new System.Drawing.Point(69, 23);
            this.rbtAverageConduct.Name = "rbtAverageConduct";
            this.rbtAverageConduct.Size = new System.Drawing.Size(76, 17);
            this.rbtAverageConduct.TabIndex = 0;
            this.rbtAverageConduct.TabStop = true;
            this.rbtAverageConduct.Text = "Trung bình";
            this.rbtAverageConduct.UseVisualStyleBackColor = true;
            // 
            // rbtExcellentConduct
            // 
            this.rbtExcellentConduct.AutoSize = true;
            this.rbtExcellentConduct.Location = new System.Drawing.Point(7, 23);
            this.rbtExcellentConduct.Name = "rbtExcellentConduct";
            this.rbtExcellentConduct.Size = new System.Drawing.Size(41, 17);
            this.rbtExcellentConduct.TabIndex = 0;
            this.rbtExcellentConduct.TabStop = true;
            this.rbtExcellentConduct.Text = "Tốt";
            this.rbtExcellentConduct.UseVisualStyleBackColor = true;
            // 
            // grbCapacity
            // 
            this.grbCapacity.Controls.Add(this.rbtBellowAverageStudent);
            this.grbCapacity.Controls.Add(this.rbtAllStudent);
            this.grbCapacity.Controls.Add(this.rbtGoodStudent);
            this.grbCapacity.Controls.Add(this.rbtWeakStudent);
            this.grbCapacity.Controls.Add(this.rbtAverageStudent);
            this.grbCapacity.Controls.Add(this.rbtExcellentStudent);
            this.grbCapacity.Location = new System.Drawing.Point(27, 74);
            this.grbCapacity.Name = "grbCapacity";
            this.grbCapacity.Size = new System.Drawing.Size(245, 83);
            this.grbCapacity.TabIndex = 1;
            this.grbCapacity.TabStop = false;
            this.grbCapacity.Text = "Học lực";
            // 
            // rbtBellowAverageStudent
            // 
            this.rbtBellowAverageStudent.AutoSize = true;
            this.rbtBellowAverageStudent.Location = new System.Drawing.Point(69, 49);
            this.rbtBellowAverageStudent.Name = "rbtBellowAverageStudent";
            this.rbtBellowAverageStudent.Size = new System.Drawing.Size(96, 17);
            this.rbtBellowAverageStudent.TabIndex = 5;
            this.rbtBellowAverageStudent.TabStop = true;
            this.rbtBellowAverageStudent.Text = "Trung bình yếu";
            this.rbtBellowAverageStudent.UseVisualStyleBackColor = true;
            // 
            // rbtAllStudent
            // 
            this.rbtAllStudent.AutoSize = true;
            this.rbtAllStudent.Location = new System.Drawing.Point(178, 49);
            this.rbtAllStudent.Name = "rbtAllStudent";
            this.rbtAllStudent.Size = new System.Drawing.Size(56, 17);
            this.rbtAllStudent.TabIndex = 4;
            this.rbtAllStudent.TabStop = true;
            this.rbtAllStudent.Text = "Tất cả";
            this.rbtAllStudent.UseVisualStyleBackColor = true;
            // 
            // rbtGoodStudent
            // 
            this.rbtGoodStudent.AutoSize = true;
            this.rbtGoodStudent.Location = new System.Drawing.Point(6, 49);
            this.rbtGoodStudent.Name = "rbtGoodStudent";
            this.rbtGoodStudent.Size = new System.Drawing.Size(44, 17);
            this.rbtGoodStudent.TabIndex = 0;
            this.rbtGoodStudent.TabStop = true;
            this.rbtGoodStudent.Text = "Khá";
            this.rbtGoodStudent.UseVisualStyleBackColor = true;
            // 
            // rbtWeakStudent
            // 
            this.rbtWeakStudent.AutoSize = true;
            this.rbtWeakStudent.Location = new System.Drawing.Point(178, 19);
            this.rbtWeakStudent.Name = "rbtWeakStudent";
            this.rbtWeakStudent.Size = new System.Drawing.Size(44, 17);
            this.rbtWeakStudent.TabIndex = 0;
            this.rbtWeakStudent.TabStop = true;
            this.rbtWeakStudent.Text = "Yếu";
            this.rbtWeakStudent.UseVisualStyleBackColor = true;
            // 
            // rbtAverageStudent
            // 
            this.rbtAverageStudent.AutoSize = true;
            this.rbtAverageStudent.Location = new System.Drawing.Point(69, 19);
            this.rbtAverageStudent.Name = "rbtAverageStudent";
            this.rbtAverageStudent.Size = new System.Drawing.Size(76, 17);
            this.rbtAverageStudent.TabIndex = 0;
            this.rbtAverageStudent.TabStop = true;
            this.rbtAverageStudent.Text = "Trung bình";
            this.rbtAverageStudent.UseVisualStyleBackColor = true;
            // 
            // rbtExcellentStudent
            // 
            this.rbtExcellentStudent.AutoSize = true;
            this.rbtExcellentStudent.Location = new System.Drawing.Point(7, 19);
            this.rbtExcellentStudent.Name = "rbtExcellentStudent";
            this.rbtExcellentStudent.Size = new System.Drawing.Size(43, 17);
            this.rbtExcellentStudent.TabIndex = 0;
            this.rbtExcellentStudent.TabStop = true;
            this.rbtExcellentStudent.Text = "Giỏi";
            this.rbtExcellentStudent.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStatisticByType);
            this.groupBox2.Location = new System.Drawing.Point(17, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 274);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê theo loại học sinh";
            // 
            // btnStatisticByType
            // 
            this.btnStatisticByType.Location = new System.Drawing.Point(80, 236);
            this.btnStatisticByType.Name = "btnStatisticByType";
            this.btnStatisticByType.Size = new System.Drawing.Size(75, 23);
            this.btnStatisticByType.TabIndex = 0;
            this.btnStatisticByType.Text = "Thống kê";
            this.btnStatisticByType.UseVisualStyleBackColor = true;
            this.btnStatisticByType.Click += new System.EventHandler(this.btnStatisticByType_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnYear);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbbYear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(299, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 71);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(299, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 46);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(995, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(39, 409);
            this.panel4.TabIndex = 3;
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistic.Location = new System.Drawing.Point(299, 71);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.ReadOnly = true;
            this.dgvStatistic.RowHeadersVisible = false;
            this.dgvStatistic.Size = new System.Drawing.Size(696, 409);
            this.dgvStatistic.TabIndex = 4;
            this.dgvStatistic.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStatistic_CellFormatting);
            // 
            // cbbYear
            // 
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(77, 44);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(60, 21);
            this.cbbYear.TabIndex = 0;
            this.cbbYear.Text = "2017";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Năm học :";
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(143, 42);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(44, 23);
            this.btnYear.TabIndex = 2;
            this.btnYear.Text = "Chọn";
            this.btnYear.UseVisualStyleBackColor = true;
            // 
            // ucStatisticStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvStatistic);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucStatisticStudents";
            this.Size = new System.Drawing.Size(1034, 526);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbConduct.ResumeLayout(false);
            this.grbConduct.PerformLayout();
            this.grbCapacity.ResumeLayout(false);
            this.grbCapacity.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbCapacity;
        private System.Windows.Forms.RadioButton rbtGoodStudent;
        private System.Windows.Forms.RadioButton rbtWeakStudent;
        private System.Windows.Forms.RadioButton rbtAverageStudent;
        private System.Windows.Forms.RadioButton rbtExcellentStudent;
        private System.Windows.Forms.GroupBox grbConduct;
        private System.Windows.Forms.RadioButton rbtGoodConduct;
        private System.Windows.Forms.RadioButton rbtWeakConduct;
        private System.Windows.Forms.RadioButton rbtAverageConduct;
        private System.Windows.Forms.RadioButton rbtExcellentConduct;
        private System.Windows.Forms.RadioButton rbtAllConduct;
        private System.Windows.Forms.RadioButton rbtAllStudent;
        private System.Windows.Forms.RadioButton rbtBellowAverageStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStatisticByScore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStatisticByType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.Button btnYear;
    }
}
