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
            // status = "Xoa";
            DialogResult res = MessageBox.Show("Xóa học sinh : " + txtHoTen.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            {
                if (res == DialogResult.OK)
                {
                    int mahs = int.Parse(dgvHocSinh.CurrentRow.Cells["maHS"].Value.ToString());
                    int result = HocSinhBUS.Instance.DeleteHocSinh(mahs);
                    if (result == 1)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDB();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (status == "Them")
            {
                int result = HocSinhBUS.Instance.InsertHocSinh(getHocSinh());
                if (result == 1)
                {
                    MessageBox.Show("Thêm học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm học sinh không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                HocSinh hs = getHocSinh();
                hs.maHS = int.Parse(dgvHocSinh.CurrentRow.Cells["maHS"].Value.ToString());
                int result = HocSinhBUS.Instance.EditHocSinh(hs);
                if (result == 1)
                {
                    MessageBox.Show("Sửa học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa học sinh không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tool_Disenabled();
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
            LoadDB();
            status = "";

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tool_Disenabled();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = true;
            LoadDB();
        }

        public bool isNull(string str)
        {
            if (dgvHocSinh.CurrentRow.Cells[str].Value == null)
                return true;
            else
                return false;
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (isNull("maHS") == false)
                {
                    //bat buoc nhap tat ca combobox
                    txtHoTen.Text = dgvHocSinh.CurrentRow.Cells["hoTenHS"].Value.ToString();//bat buoc
                    if (isNull("dcTamTru") == false)
                        txtDCtamtru.Text = dgvHocSinh.CurrentRow.Cells["dcTamTru"].Value.ToString();
                    if (isNull("dcThuongTru") == false)
                        txtDCthuongtru.Text = dgvHocSinh.CurrentRow.Cells["dcThuongTru"].Value.ToString();
                    if (isNull("danToc") == false)
                        txtDanToc.Text = dgvHocSinh.CurrentRow.Cells["danToc"].Value.ToString();
                    if (isNull("tonGiao") == false)
                        txtTonGiao.Text = dgvHocSinh.CurrentRow.Cells["tonGiao"].Value.ToString();
                    if (isNull("hoTenCha") == false)
                        txtHoTenCha.Text = dgvHocSinh.CurrentRow.Cells["hoTenCha"].Value.ToString();
                    if (isNull("hoTenMe") == false)
                        txtHoTenMe.Text = dgvHocSinh.CurrentRow.Cells["hoTenMe"].Value.ToString();
                    if (isNull("ngheNghiepCha") == false)
                        txtNgheNghiepCha.Text = dgvHocSinh.CurrentRow.Cells["ngheNghiepCha"].Value.ToString();
                    if (isNull("ngheNghiepMe") == false)
                        txtNgheNghiepMe.Text = dgvHocSinh.CurrentRow.Cells["ngheNghiepMe"].Value.ToString();
                    dtNgaySinh.Value = DateTime.Parse(dgvHocSinh.CurrentRow.Cells["ngaySinh"].Value.ToString());
                    ////Gioi tinh //bat buoc
                    string GT = dgvHocSinh.CurrentRow.Cells["gioiTinh"].Value.ToString();
                    if (GT == "Nam")
                        rdbNam.Checked = true;
                    if (GT == "Nữ")
                        rdbNu.Checked = true;
                    //Chuc Vu
                    string CV = dgvHocSinh.CurrentRow.Cells["chucVu"].Value.ToString();
                    if (CV == "Lớp trưởng")
                        cmbChucVu.SelectedItem = "Lớp trưởng";
                    if (CV == "Lớp phó")
                        cmbChucVu.SelectedItem = "Lớp phó";
                    if (CV == "Bí thư")
                        cmbChucVu.SelectedItem = "Bí thư";
                    if (CV == "Không có")
                        cmbChucVu.SelectedItem = "Không có";

                    //Trang thai
                    int stt = dgvHocSinh.CurrentRow.Cells["trangThai"].Value.GetHashCode();
                    if (stt == 1)
                    {
                        cmbTrangThai.SelectedItem = "Đang học";
                        cmbTrangThai.SelectedValue = 1;
                    }
                    if (stt == 2)
                    {
                        cmbTrangThai.SelectedItem = "Đình chỉ";
                        cmbTrangThai.SelectedValue = 2;
                    }
                    if (stt == 0)
                    {
                        cmbTrangThai.SelectedItem = "Đã nghỉ";
                        cmbTrangThai.SelectedValue = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (isNull("maHS") == false)
                {
                    txtHoTen.Text = dgvHocSinh.CurrentRow.Cells["hoTenHS"].Value.ToString();//bat buoc
                    if (isNull("dcTamTru") == false)
                        txtDCtamtru.Text = dgvHocSinh.CurrentRow.Cells["dcTamTru"].Value.ToString();
                    if (isNull("dcThuongTru") == false)
                        txtDCthuongtru.Text = dgvHocSinh.CurrentRow.Cells["dcThuongTru"].Value.ToString();
                    if (isNull("danToc") == false)
                        txtDanToc.Text = dgvHocSinh.CurrentRow.Cells["danToc"].Value.ToString();
                    if (isNull("tonGiao") == false)
                        txtTonGiao.Text = dgvHocSinh.CurrentRow.Cells["tonGiao"].Value.ToString();
                    if (isNull("hoTenCha") == false)
                        txtHoTenCha.Text = dgvHocSinh.CurrentRow.Cells["hoTenCha"].Value.ToString();
                    if (isNull("hoTenMe") == false)
                        txtHoTenMe.Text = dgvHocSinh.CurrentRow.Cells["hoTenMe"].Value.ToString();
                    if (isNull("ngheNghiepCha") == false)
                        txtNgheNghiepCha.Text = dgvHocSinh.CurrentRow.Cells["ngheNghiepCha"].Value.ToString();
                    if (isNull("ngheNghiepMe") == false)
                        txtNgheNghiepMe.Text = dgvHocSinh.CurrentRow.Cells["ngheNghiepMe"].Value.ToString();
                    dtNgaySinh.Value = DateTime.Parse(dgvHocSinh.CurrentRow.Cells["ngaySinh"].Value.ToString());
                    ////Gioi tinh //bat buoc
                    string GT = dgvHocSinh.CurrentRow.Cells["gioiTinh"].Value.ToString();
                    if (GT == "Nam")
                        rdbNam.Checked = true;
                    if (GT == "Nữ")
                        rdbNu.Checked = true;
                    //Chuc Vu
                    string CV = dgvHocSinh.CurrentRow.Cells["chucVu"].Value.ToString();
                    if (CV == "Lớp trưởng")
                        cmbChucVu.SelectedItem = "Lớp trưởng";
                    if (CV == "Lớp phó")
                        cmbChucVu.SelectedItem = "Lớp phó";
                    if (CV == "Bí thư")
                        cmbChucVu.SelectedItem = "Bí thư";
                    if (CV == "Không có")
                        cmbChucVu.SelectedItem = "Không có";

                    //Trang thai
                    int stt = dgvHocSinh.CurrentRow.Cells["trangThai"].Value.GetHashCode();
                    if (stt == 1)
                    {
                        cmbTrangThai.SelectedItem = "Đang học";
                        cmbTrangThai.SelectedValue = 1;
                    }
                    if (stt == 2)
                    {
                        cmbTrangThai.SelectedItem = "Đình chỉ";
                        cmbTrangThai.SelectedValue = 2;
                    }
                    if (stt == 0)
                    {
                        cmbTrangThai.SelectedItem = "Đã nghỉ";
                        cmbTrangThai.SelectedValue = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
