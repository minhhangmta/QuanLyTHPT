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
    public partial class ucHanhKiem : UserControl
    {
        private static ucHanhKiem _instance;
        public static ucHanhKiem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucHanhKiem();
                return _instance;
            }
        }
        
        HanhKiemBUS HKBUS = new HanhKiemBUS();

        public void LoadDB()
        {
            dgvHanhKiem.DataSource = HKBUS.GetList();
        }


        public ucHanhKiem()
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

        private void dgvHanhKiem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHanhKiem.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvHanhKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHanhKiem_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
