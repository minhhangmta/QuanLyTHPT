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

        public GiaoVien getGiaoVien()
        {
            string temp = "";
            if (rdbNam.Checked == true)
                temp = "Nam";
            else
                temp = "Nữ";
            int stt = 0;
            switch (cmbTrangThai.SelectedItem.ToString())
            {
                case "Đang làm việc": stt = 1; break;
                case "Đình chỉ": stt = 2; break;
                default: break;
            }
            GiaoVien giaovien= new GiaoVien();
            
            //hocsinh.chucVu = cmbChucVu.SelectedItem.ToString();
            giaovien.trangThai = stt;
            giaovien.gioiTinh = temp;
            //hocsinh.maLop = int.Parse(cmbLopHoc.SelectedValue.ToString());
            return giaovien;
        }
        public void LoadDB()
        {
            dgvGiaoVien.DataSource = GVBUS.GetList();
            GiaoVienBUS.Instance.GetMonHoc(cmbMonHoc);
            GiaoVienBUS.Instance.GetChucVu(cmbChucVu);
        }

        private string status = "";

        public void tool_Enabled()
        {
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtMaLuong.Enabled = true;
            txtSDT.Enabled = true;
            txtTrinhDo.Enabled = true;
            cmbChucVu.Enabled = true;
            cmbMonHoc.Enabled = true;
            cmbTrangThai.Enabled = true;
            dtNgaySinh.Enabled = true;
            btnHuy.Enabled = true;
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
            btnLuu.Enabled = true;
        }

        public void tool_Disenabled()
        {
            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtMaLuong.Enabled = false;
            txtSDT.Enabled = false;
            txtTrinhDo.Enabled = false;
            cmbChucVu.Enabled = false;
            cmbMonHoc.Enabled = false;
            dtNgaySinh.Enabled = false;
            rdbNu.Enabled = false;
            rdbNam.Enabled = false;
            cmbTrangThai.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        public void clearText()
        {
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtHoTen.Clear();
            txtMaLuong.Clear();
            txtSDT.Clear();
            txtTrinhDo.Clear();
            cmbChucVu.Text = "";
            cmbMonHoc.Text = "";
            cmbTrangThai.Text = "";
        }

        

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
            tool_Disenabled();
            LoadDB();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = "Them";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            tool_Enabled();
            clearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = "Sua";
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            tool_Enabled();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xóa giáo viên " + txtHoTen.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            {
                if (res == DialogResult.OK)
                {
                    int magv = int.Parse(dgvGiaoVien.CurrentRow.Cells["maGV"].Value.ToString());
                    int result = GiaoVienBUS.Instance.DeleteGiaoVien(magv);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (status == "Them")
            {
                int result = GiaoVienBUS.Instance.InsertGiaoVien(getGiaoVien());
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void ucGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        public bool isNULL(string str)
        {
            if (dgvGiaoVien.CurrentRow.Cells["maGV"].Value == null)
                return true;
            else
                return false;
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (isNULL("maGV") == false)
                {
                    txtHoTen.Text = dgvGiaoVien.CurrentRow.Cells["hoTenGV"].Value.ToString();//bat buoc
                    if (isNULL("diaChi") == false)
                        txtDiaChi.Text = dgvGiaoVien.CurrentRow.Cells["diaChi"].Value.ToString();
                    txtEmail.Text = dgvGiaoVien.CurrentRow.Cells["email"].Value.ToString();//bat buoc
                    txtSDT.Text = dgvGiaoVien.CurrentRow.Cells["sdt"].Value.ToString();//bat buoc
                    if (isNULL("maLuong") == false)
                        txtMaLuong.Text = dgvGiaoVien.CurrentRow.Cells["maLuong"].Value.ToString();
                    if (isNULL("trinhDo") == false)
                        txtTrinhDo.Text = dgvGiaoVien.CurrentRow.Cells["trinhDo"].Value.ToString();
                    dtNgaySinh.Value = DateTime.Parse(dgvGiaoVien.CurrentRow.Cells["ngaySinh"].Value.ToString());
                    ////Gioi tinh
                    string GT = dgvGiaoVien.CurrentRow.Cells["gioiTinh"].Value.ToString();
                    if (GT == "Nam")
                        rdbNam.Checked = true;
                    if (GT == "Nữ")
                        rdbNu.Checked = true;
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
                if (isNULL("maGV") == false)
                {
                    //bat buoc nhap tat ca combobox
                    txtHoTen.Text = dgvGiaoVien.CurrentRow.Cells["hoTenGV"].Value.ToString();//bat buoc
                    if (isNULL("diaChi") == false)
                        txtDiaChi.Text = dgvGiaoVien.CurrentRow.Cells["diaChi"].Value.ToString();
                    txtEmail.Text = dgvGiaoVien.CurrentRow.Cells["email"].Value.ToString();//bat buoc
                    txtSDT.Text = dgvGiaoVien.CurrentRow.Cells["sdt"].Value.ToString();//bat buoc
                    if (isNULL("maLuong") == false)
                        txtMaLuong.Text = dgvGiaoVien.CurrentRow.Cells["maLuong"].Value.ToString();
                    if (isNULL("trinhDo") == false)
                        txtTrinhDo.Text = dgvGiaoVien.CurrentRow.Cells["trinhDo"].Value.ToString();
                    dtNgaySinh.Value = DateTime.Parse(dgvGiaoVien.CurrentRow.Cells["ngaySinh"].Value.ToString());
                    ////Gioi tinh
                    string GT = dgvGiaoVien.CurrentRow.Cells["gioiTinh"].Value.ToString();
                    if (GT == "Nam")
                        rdbNam.Checked = true;
                    if (GT == "Nữ")
                        rdbNu.Checked = true;
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


    }
}
