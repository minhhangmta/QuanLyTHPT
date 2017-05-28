using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btn_HocSinh_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ucHocSinh.Instance))
            {
                panel.Controls.Add(ucHocSinh.Instance);
                ucHocSinh.Instance.Dock = DockStyle.Fill;
                ucHocSinh.Instance.BringToFront();
            }
            else
                ucHocSinh.Instance.BringToFront();
        }

        private void btn_GiaoVien_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ucGiaoVien.Instance))
            {
                panel.Controls.Add(ucGiaoVien.Instance);
                ucGiaoVien.Instance.Dock = DockStyle.Fill;
                ucGiaoVien.Instance.BringToFront();
            }
            else
                ucGiaoVien.Instance.BringToFront();
        }

        private void btn_LopHoc_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ucLopHoc.Instance))
            {
                panel.Controls.Add(ucLopHoc.Instance);
                ucLopHoc.Instance.Dock = DockStyle.Fill;
                ucLopHoc.Instance.BringToFront();
            }
            else
                ucLopHoc.Instance.BringToFront();

        }

        private void btnStatisticStudent_Click(object sender, EventArgs e)
        {
            ucStatisticStudents ucStatistic = new ucStatisticStudents();
            if (!panel.Controls.Contains(ucStatistic))
            {
                panelStatistic.Controls.Add(ucStatistic);
                ucStatistic.Dock = DockStyle.Fill;
                ucStatistic.BringToFront();
            }
            else
                ucStatistic.BringToFront();
        }

        private void btnBangDiem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ucBangDiem.Instance))
            {
                panel.Controls.Add(ucBangDiem.Instance);
                ucBangDiem.Instance.Dock = DockStyle.Fill;
                ucBangDiem.Instance.BringToFront();
            }
            else
                ucBangDiem.Instance.BringToFront();
        }

        private void btnHanhKiem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ucHanhKiem.Instance))
            {
                panel.Controls.Add(ucHanhKiem.Instance);
                ucHanhKiem.Instance.Dock = DockStyle.Fill;
                ucHanhKiem.Instance.BringToFront();
            }
            else
                ucHanhKiem.Instance.BringToFront();
        }
    }    
}
