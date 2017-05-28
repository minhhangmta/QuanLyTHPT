namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabPage_ThongKe = new System.Windows.Forms.TabPage();
            this.grb_main_TK = new System.Windows.Forms.GroupBox();
            this.panelStatistic = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStatisticStudent = new System.Windows.Forms.Button();
            this.tabPage_QuanLy = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_GiaoVien = new System.Windows.Forms.Button();
            this.btnHanhKiem = new System.Windows.Forms.Button();
            this.btnBangDiem = new System.Windows.Forms.Button();
            this.btn_LopHoc = new System.Windows.Forms.Button();
            this.btn_HocSinh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThong_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMK_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuat_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_ThongKe.SuspendLayout();
            this.grb_main_TK.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage_QuanLy.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_ThongKe
            // 
            this.tabPage_ThongKe.Controls.Add(this.grb_main_TK);
            this.tabPage_ThongKe.Controls.Add(this.panel2);
            this.tabPage_ThongKe.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ThongKe.Name = "tabPage_ThongKe";
            this.tabPage_ThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ThongKe.Size = new System.Drawing.Size(963, 623);
            this.tabPage_ThongKe.TabIndex = 2;
            this.tabPage_ThongKe.Text = "Thống Kê";
            this.tabPage_ThongKe.UseVisualStyleBackColor = true;
            // 
            // grb_main_TK
            // 
            this.grb_main_TK.Controls.Add(this.panelStatistic);
            this.grb_main_TK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_main_TK.Location = new System.Drawing.Point(3, 82);
            this.grb_main_TK.Name = "grb_main_TK";
            this.grb_main_TK.Size = new System.Drawing.Size(957, 538);
            this.grb_main_TK.TabIndex = 5;
            this.grb_main_TK.TabStop = false;
            // 
            // panelStatistic
            // 
            this.panelStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStatistic.Location = new System.Drawing.Point(3, 16);
            this.panelStatistic.Name = "panelStatistic";
            this.panelStatistic.Size = new System.Drawing.Size(951, 519);
            this.panelStatistic.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnStatisticStudent);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 79);
            this.panel2.TabIndex = 4;
            // 
            // btnStatisticStudent
            // 
            this.btnStatisticStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatisticStudent.Image = global::GUI.Properties.Resources.statistics_market_icon;
            this.btnStatisticStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStatisticStudent.Location = new System.Drawing.Point(3, 3);
            this.btnStatisticStudent.Name = "btnStatisticStudent";
            this.btnStatisticStudent.Size = new System.Drawing.Size(80, 73);
            this.btnStatisticStudent.TabIndex = 1;
            this.btnStatisticStudent.Text = "Học Sinh";
            this.btnStatisticStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStatisticStudent.UseVisualStyleBackColor = true;
            this.btnStatisticStudent.Click += new System.EventHandler(this.btnStatisticStudent_Click);
            // 
            // tabPage_QuanLy
            // 
            this.tabPage_QuanLy.Controls.Add(this.panel);
            this.tabPage_QuanLy.Controls.Add(this.panel3);
            this.tabPage_QuanLy.Location = new System.Drawing.Point(4, 22);
            this.tabPage_QuanLy.Name = "tabPage_QuanLy";
            this.tabPage_QuanLy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_QuanLy.Size = new System.Drawing.Size(963, 623);
            this.tabPage_QuanLy.TabIndex = 1;
            this.tabPage_QuanLy.Text = "Quản Lý";
            this.tabPage_QuanLy.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(3, 82);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(957, 538);
            this.panel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btn_GiaoVien);
            this.panel3.Controls.Add(this.btnHanhKiem);
            this.panel3.Controls.Add(this.btnBangDiem);
            this.panel3.Controls.Add(this.btn_LopHoc);
            this.panel3.Controls.Add(this.btn_HocSinh);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(957, 79);
            this.panel3.TabIndex = 2;
            // 
            // btn_GiaoVien
            // 
            this.btn_GiaoVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btn_GiaoVien.Image")));
            this.btn_GiaoVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_GiaoVien.Location = new System.Drawing.Point(91, 3);
            this.btn_GiaoVien.Name = "btn_GiaoVien";
            this.btn_GiaoVien.Size = new System.Drawing.Size(82, 73);
            this.btn_GiaoVien.TabIndex = 1;
            this.btn_GiaoVien.Text = "Giáo Viên";
            this.btn_GiaoVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_GiaoVien.UseVisualStyleBackColor = true;
            this.btn_GiaoVien.Click += new System.EventHandler(this.btn_GiaoVien_Click);
            // 
            // btnHanhKiem
            // 
            this.btnHanhKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHanhKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnHanhKiem.Image")));
            this.btnHanhKiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHanhKiem.Location = new System.Drawing.Point(359, 3);
            this.btnHanhKiem.Name = "btnHanhKiem";
            this.btnHanhKiem.Size = new System.Drawing.Size(84, 73);
            this.btnHanhKiem.TabIndex = 2;
            this.btnHanhKiem.Text = "Hạnh Kiểm";
            this.btnHanhKiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHanhKiem.UseVisualStyleBackColor = true;
            this.btnHanhKiem.Click += new System.EventHandler(this.btnHanhKiem_Click);
            // 
            // btnBangDiem
            // 
            this.btnBangDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBangDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnBangDiem.Image")));
            this.btnBangDiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBangDiem.Location = new System.Drawing.Point(269, 3);
            this.btnBangDiem.Name = "btnBangDiem";
            this.btnBangDiem.Size = new System.Drawing.Size(84, 73);
            this.btnBangDiem.TabIndex = 2;
            this.btnBangDiem.Text = "Bảng điểm";
            this.btnBangDiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBangDiem.UseVisualStyleBackColor = true;
            this.btnBangDiem.Click += new System.EventHandler(this.btnBangDiem_Click);
            // 
            // btn_LopHoc
            // 
            this.btn_LopHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LopHoc.Image = ((System.Drawing.Image)(resources.GetObject("btn_LopHoc.Image")));
            this.btn_LopHoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_LopHoc.Location = new System.Drawing.Point(179, 3);
            this.btn_LopHoc.Name = "btn_LopHoc";
            this.btn_LopHoc.Size = new System.Drawing.Size(84, 73);
            this.btn_LopHoc.TabIndex = 2;
            this.btn_LopHoc.Text = "Lớp học";
            this.btn_LopHoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_LopHoc.UseVisualStyleBackColor = true;
            this.btn_LopHoc.Click += new System.EventHandler(this.btn_LopHoc_Click);
            // 
            // btn_HocSinh
            // 
            this.btn_HocSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HocSinh.Image = ((System.Drawing.Image)(resources.GetObject("btn_HocSinh.Image")));
            this.btn_HocSinh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_HocSinh.Location = new System.Drawing.Point(5, 3);
            this.btn_HocSinh.Name = "btn_HocSinh";
            this.btn_HocSinh.Size = new System.Drawing.Size(80, 73);
            this.btn_HocSinh.TabIndex = 0;
            this.btn_HocSinh.Text = "Học Sinh";
            this.btn_HocSinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_HocSinh.UseVisualStyleBackColor = true;
            this.btn_HocSinh.Click += new System.EventHandler(this.btn_HocSinh_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_QuanLy);
            this.tabControl1.Controls.Add(this.tabPage_ThongKe);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 649);
            this.tabControl1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThong_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThong_ToolStripMenuItem
            // 
            this.heThong_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMK_ToolStripMenuItem,
            this.dangXuat_ToolStripMenuItem,
            this.thoat_ToolStripMenuItem});
            this.heThong_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("heThong_ToolStripMenuItem.Image")));
            this.heThong_ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.heThong_ToolStripMenuItem.Name = "heThong_ToolStripMenuItem";
            this.heThong_ToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.heThong_ToolStripMenuItem.Text = "Hệ Thống";
            this.heThong_ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // doiMK_ToolStripMenuItem
            // 
            this.doiMK_ToolStripMenuItem.Name = "doiMK_ToolStripMenuItem";
            this.doiMK_ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.doiMK_ToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // dangXuat_ToolStripMenuItem
            // 
            this.dangXuat_ToolStripMenuItem.Name = "dangXuat_ToolStripMenuItem";
            this.dangXuat_ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.dangXuat_ToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoat_ToolStripMenuItem
            // 
            this.thoat_ToolStripMenuItem.Name = "thoat_ToolStripMenuItem";
            this.thoat_ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.thoat_ToolStripMenuItem.Text = "Thoát";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(971, 673);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Quản Lý Trường THPT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabPage_ThongKe.ResumeLayout(false);
            this.grb_main_TK.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage_QuanLy.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage_ThongKe;
        private System.Windows.Forms.TabPage tabPage_QuanLy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThong_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMK_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuat_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoat_ToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_GiaoVien;
        private System.Windows.Forms.Button btn_LopHoc;
        private System.Windows.Forms.Button btn_HocSinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grb_main_TK;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnStatisticStudent;
        private System.Windows.Forms.Panel panelStatistic;
        private System.Windows.Forms.Button btnHanhKiem;
        private System.Windows.Forms.Button btnBangDiem;
    }
}

