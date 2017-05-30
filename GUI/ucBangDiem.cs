using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class ucBangDiem : UserControl
    {

        private static ucBangDiem _instance;
        public static ucBangDiem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucBangDiem();
                return _instance;
            }
        }

        BangDiemBUS BDBUS = new BangDiemBUS();

        public void LoadDB()
        {
            dgvBangDiem.DataSource = BDBUS.GetList();
        }
        public ucBangDiem()
        {
            InitializeComponent();
            LoadDB();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void dgvBangDiem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvBangDiem.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
