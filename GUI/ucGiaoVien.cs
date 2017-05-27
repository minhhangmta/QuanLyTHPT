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
    public partial class ucGiaoVien : UserControl
    {
        private static ucGiaoVien _instance;
        public static ucGiaoVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucGiaoVien();
                return _instance;
            }
        }
        public ucGiaoVien()
        {
            InitializeComponent();
        }

        GiaoVienBUS GVBUS = new GiaoVienBUS();
        public void LoadDB()
        {
            dgvGiaoVien.DataSource = GVBUS.GetList();
            GiaoVienBUS.Instance.GetMonHoc(cmbMonHoc);
            GiaoVienBUS.Instance.GetChucVu(cmbChucVu);
        }

        private string status = "";

        public void etool_Enabled()
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
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
            LoadDB();
        }

        private void ucGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvGiaoVien.CurrentRow.Cells["maGV"].Value != null)
                {
                    //txtMaGV.Text = dgvGiaoVien.CurrentRow.Cells["maGV"].Value.ToString();
                    txtHoTen.Text = dgvGiaoVien.CurrentRow.Cells["hoTenGV"].Value.ToString();
                    txtDiaChi.Text = dgvGiaoVien.CurrentRow.Cells["diaChi"].Value.ToString();
                    txtEmail.Text = dgvGiaoVien.CurrentRow.Cells["email"].Value.ToString();
                    txtSDT.Text = dgvGiaoVien.CurrentRow.Cells["sdt"].Value.ToString();
                    txtMaLuong.Text = dgvGiaoVien.CurrentRow.Cells["maLuong"].Value.ToString();
                  //  txtMaMH.Text = dgvGiaoVien.CurrentRow.Cells["maMH"].Value.ToString();
                    txtTrinhDo.Text = dgvGiaoVien.CurrentRow.Cells["trinhDo"].Value.ToString();
                    //txtMaCV.Text = dgvGiaoVien.CurrentRow.Cells["maCV"].Value.ToString();
                    dtNgaySinh.Value = DateTime.Parse(dgvGiaoVien.CurrentRow.Cells["ngaySinh"].Value.ToString());
                    ////Gioi tinh
                    string GT = dgvGiaoVien.CurrentRow.Cells["gioiTinh"].Value.ToString();
                    if (GT == "Nam")
                        rdbNam.Checked = true;
                    if (GT == "Nữ")
                        rdbNu.Checked = true;
                    //Xep loai
                    string xl = dgvGiaoVien.CurrentRow.Cells["xepLoai"].Value.ToString();
                    if (xl == "Xuất sắc")
                        cmbXepLoai.SelectedItem = "Xuất sắc";
                    else if (xl == "Giỏi")
                        cmbXepLoai.SelectedItem = "Giỏi";
                    else if (xl == "Khá")
                        cmbXepLoai.SelectedItem = "Khá";
                    else if (xl == "Trung bình")
                        cmbXepLoai.SelectedItem = "Trung bình";
                    else
                        cmbXepLoai.SelectedItem = "Yếu";
                    //Trang thai
                    int stt = dgvGiaoVien.CurrentRow.Cells["trangThai"].Value.GetHashCode();
                    if (stt == 1)
                        cmbTrangThai.SelectedItem = "Đang làm việc";
                    if (stt == 2)
                        cmbTrangThai.SelectedItem = "Đình chỉ";
                    if (stt == 0)
                        cmbTrangThai.SelectedItem = "Đã nghỉ";
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvGiaoVien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvGiaoVien.CurrentRow.Cells["maGV"].Value != null)
                {
                    txtHoTen.Text = dgvGiaoVien.CurrentRow.Cells["hoTenGV"].Value.ToString();
                    txtDiaChi.Text = dgvGiaoVien.CurrentRow.Cells["diaChi"].Value.ToString();
                    txtEmail.Text = dgvGiaoVien.CurrentRow.Cells["email"].Value.ToString();
                    txtSDT.Text = dgvGiaoVien.CurrentRow.Cells["SDT"].Value.ToString();
                    txtMaLuong.Text = dgvGiaoVien.CurrentRow.Cells["maLuong"].Value.ToString();
                 //   txtMaMH.Text = dgvGiaoVien.CurrentRow.Cells["maMH"].Value.ToString();
                    txtTrinhDo.Text = dgvGiaoVien.CurrentRow.Cells["trinhDo"].Value.ToString();
                   // txtMaCV.Text = dgvGiaoVien.CurrentRow.Cells["maCV"].Value.ToString();
                    dtNgaySinh.Value = DateTime.Parse(dgvGiaoVien.CurrentRow.Cells["ngaySinh"].Value.ToString());
                    ////Gioi tinh
                    string GT = dgvGiaoVien.CurrentRow.Cells["gioiTinh"].Value.ToString();
                    if (GT == "Nam")
                        rdbNam.Checked = true;
                    if (GT == "Nữ")
                        rdbNu.Checked = true;
                    //Xep loai
                    string xl = dgvGiaoVien.CurrentRow.Cells["xepLoai"].Value.ToString();
                    if (xl == "Xuất sắc")
                        cmbXepLoai.SelectedItem = "Xuất sắc";
                    else if (xl == "Giỏi")
                        cmbXepLoai.SelectedItem = "Giỏi";
                    else if (xl == "Khá")
                        cmbXepLoai.SelectedItem = "Khá";
                    else if (xl == "Trung bình")
                        cmbXepLoai.SelectedItem = "Trung bình";
                    else
                        cmbXepLoai.SelectedItem = "Yếu";
                    //Trang thai
                    int stt = dgvGiaoVien.CurrentRow.Cells["trangThai"].Value.GetHashCode();
                    if (stt == 1)
                        cmbTrangThai.SelectedItem = "Đang làm việc";
                    if (stt == 2)
                        cmbTrangThai.SelectedItem = "Đình chỉ";
                    if (stt == 0)
                        cmbTrangThai.SelectedItem = "Đã nghỉ";
                    //Mon hoc

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
