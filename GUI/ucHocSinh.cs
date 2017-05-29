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
    public partial class ucHocSinh : UserControl
    {
        private static ucHocSinh _instance;
        public static ucHocSinh Instance
        {

        }

        HocSinhBUS HSBUS = new HocSinhBUS();

        public HocSinh getHocSinh()
        {

        }
        public void LoadDB()
        {

        }

        private string status = "";

        public ucHocSinh()
        {
            InitializeComponent();

        }

        private void ucHocSinh_Load(object sender, EventArgs e)
        {
        }

        public void tool_Enabled()
        {

        }

        public void tool_Disenabled()
        {

        }

        public void clearText()
        {

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

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        public bool isNull(string str)
        {

        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {

        }


    }
}
