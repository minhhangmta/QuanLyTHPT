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
            get
            {
                if (_instance == null)
                    _instance = new ucHocSinh();
                return _instance;
            }
        }

        HocSinhBUS HSBUS = new HocSinhBUS();

        public HocSinh getHocSinh()
        {
            string temp = "";
            if (rdbNam.Checked == true)
                temp = "Nam";
            else
                temp = "Nữ";
            int stt = 0;
            switch (cmbTrangThai.SelectedItem.ToString())
            {
                case "Đang học": stt = 1; break;
                case "Đình chỉ": stt = 2; break;
                default: break;
            }
            HocSinh hocsinh = new HocSinh();
            hocsinh.hoTenHS = HocSinhBUS.Instance.StandardString(txtHoTen.Text);
            hocsinh.ngaySinh = dtNgaySinh.Value;
            hocsinh.dcThuongTru = HocSinhBUS.Instance.StandardString(txtDCthuongtru.Text);
            hocsinh.dcTamTru = HocSinhBUS.Instance.StandardString(txtDCtamtru.Text);
            hocsinh.danToc = HocSinhBUS.Instance.StandardString(txtDanToc.Text);
            hocsinh.hoTenCha = HocSinhBUS.Instance.StandardString(txtHoTenCha.Text);
            hocsinh.tonGiao = HocSinhBUS.Instance.StandardString(txtTonGiao.Text);
            hocsinh.hoTenMe = HocSinhBUS.Instance.StandardString(txtHoTenMe.Text);
            hocsinh.ngheNghiepMe = HocSinhBUS.Instance.StandardWord(txtNgheNghiepMe.Text);
            hocsinh.ngheNghiepCha = HocSinhBUS.Instance.StandardWord(txtNgheNghiepCha.Text);
            hocsinh.chucVu = cmbChucVu.SelectedItem.ToString();
            hocsinh.trangThai = stt;
            hocsinh.gioiTinh = temp;
            hocsinh.maLop = int.Parse(cmbLopHoc.SelectedValue.ToString());
            return hocsinh;
        }
        public void LoadDB()
        {
            dgvHocSinh.DataSource = HSBUS.GetList();
            HocSinhBUS.Instance.GetTenLop(cmbLopHoc);
        }

        private string status = "";

        public ucHocSinh()
        {
            InitializeComponent();

        }

        private void ucHocSinh_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        public void tool_Enabled()
        {
            txtDanToc.Enabled = true;
            txtDCtamtru.Enabled = true;
            txtDCthuongtru.Enabled = true;
            txtHoTen.Enabled = true;
            txtHoTenCha.Enabled = true;
            txtHoTenMe.Enabled = true;
            txtNgheNghiepCha.Enabled = true;
            txtNgheNghiepMe.Enabled = true;
            txtTonGiao.Enabled = true;
            cmbChucVu.Enabled = true;
            cmbLopHoc.Enabled = true;
            cmbTrangThai.Enabled = true;
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
            dtNgaySinh.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        public void tool_Disenabled()
        {
            txtDanToc.Enabled = false;
            txtDCtamtru.Enabled = false;
            txtDCthuongtru.Enabled = false;
            txtHoTen.Enabled = false;
            txtHoTenCha.Enabled = false;
            txtHoTenMe.Enabled = false;
            txtNgheNghiepCha.Enabled = false;
            txtNgheNghiepMe.Enabled = false;
            txtTonGiao.Enabled = false;
            cmbChucVu.Enabled = false;
            cmbLopHoc.Enabled = false;
            cmbTrangThai.Enabled = false;
            rdbNam.Enabled = false;
            rdbNu.Enabled = false;
            dtNgaySinh.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        public void clearText()
        {

            txtDCtamtru.Clear();
            txtDCthuongtru.Clear();
            txtDanToc.Clear();
            txtHoTen.Clear();
            txtHoTenCha.Clear();
            txtHoTenMe.Clear();
            txtNgheNghiepCha.Clear();
            txtNgheNghiepMe.Clear();
            txtTonGiao.Clear();
            cmbChucVu.Text = "";
            cmbTrangThai.Text = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = "Them";
            clearText();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            tool_Enabled();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = "Sua";
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            tool_Enabled();
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
