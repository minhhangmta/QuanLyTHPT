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
using DAO;

namespace GUI
{
    public partial class ucLopHoc : UserControl
    {
        private static ucLopHoc _instance;
        public static ucLopHoc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucLopHoc();
                return _instance;
            }
        }
        public ucLopHoc()
        {
            InitializeComponent();
        }

        //LopHocBUS LHBUS = new Lop

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

        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLopHoc_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
