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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage_QuanLy = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_GiaoVien = new System.Windows.Forms.Button();
            this.btn_LopHoc = new System.Windows.Forms.Button();
            this.btn_HocSinh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đôiMâtKhâuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuâtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.tabPage_ThongKe.SuspendLayout();
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
            this.grb_main_TK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_main_TK.Location = new System.Drawing.Point(3, 82);
            this.grb_main_TK.Name = "grb_main_TK";
            this.grb_main_TK.Size = new System.Drawing.Size(957, 538);
            this.grb_main_TK.TabIndex = 5;
            this.grb_main_TK.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 79);
            this.panel2.TabIndex = 4;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btn_GiaoVien);
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
            this.btn_GiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btn_GiaoVien.Image")));
            this.btn_GiaoVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_GiaoVien.Location = new System.Drawing.Point(91, 3);
            this.btn_GiaoVien.Name = "btn_GiaoVien";
            this.btn_GiaoVien.Size = new System.Drawing.Size(82, 73);
            this.btn_GiaoVien.TabIndex = 1;
            this.btn_GiaoVien.Text = "Giáo Viên";
            this.btn_GiaoVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_GiaoVien.UseVisualStyleBackColor = true;
            // 
            // btn_LopHoc
            // 
            this.btn_LopHoc.Image = ((System.Drawing.Image)(resources.GetObject("btn_LopHoc.Image")));
            this.btn_LopHoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_LopHoc.Location = new System.Drawing.Point(179, 3);
            this.btn_LopHoc.Name = "btn_LopHoc";
            this.btn_LopHoc.Size = new System.Drawing.Size(84, 73);
            this.btn_LopHoc.TabIndex = 2;
            this.btn_LopHoc.Text = "Lớp học";
            this.btn_LopHoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_LopHoc.UseVisualStyleBackColor = true;
            // 
            // btn_HocSinh
            // 
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
            this.hêThôngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hêThôngToolStripMenuItem
            // 
            this.hêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đôiMâtKhâuToolStripMenuItem,
            this.đăngXuâtToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.hêThôngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hêThôngToolStripMenuItem.Image")));
            this.hêThôngToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hêThôngToolStripMenuItem.Name = "hêThôngToolStripMenuItem";
            this.hêThôngToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.hêThôngToolStripMenuItem.Text = "Hệ Thống";
            this.hêThôngToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // đôiMâtKhâuToolStripMenuItem
            // 
            this.đôiMâtKhâuToolStripMenuItem.Name = "đôiMâtKhâuToolStripMenuItem";
            this.đôiMâtKhâuToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.đôiMâtKhâuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuâtToolStripMenuItem
            // 
            this.đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            this.đăngXuâtToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.đăngXuâtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(3, 82);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(957, 538);
            this.panel.TabIndex = 0;
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
        private System.Windows.Forms.ToolStripMenuItem hêThôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đôiMâtKhâuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_GiaoVien;
        private System.Windows.Forms.Button btn_LopHoc;
        private System.Windows.Forms.Button btn_HocSinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grb_main_TK;
        private System.Windows.Forms.Panel panel;
    }
}

