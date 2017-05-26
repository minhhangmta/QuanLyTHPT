﻿using System;
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
            string temp="";
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
            hocsinh.hoTenHS = txtHoTen.Text;
            hocsinh.ngaySinh = dtNgaySinh.Value;
            hocsinh.dcThuongTru = txtDCthuongtru.Text;
            hocsinh.dcTamTru = txtDCtamtru.Text;
            hocsinh.danToc = txtDanToc.Text;
            hocsinh.hoTenCha = txtHoTenCha.Text;
            hocsinh.tonGiao = txtTonGiao.Text;
            hocsinh.hoTenMe = txtHoTenMe.Text;
            hocsinh.ngheNghiepMe = txtNgheNghiepMe.Text;
            hocsinh.ngheNghiepCha = txtNgheNghiepCha.Text;
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
            status = "Xoa";
            DialogResult res = MessageBox.Show("Xóa học sinh : " + txtHoTen.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            {
                if (res == DialogResult.OK)
                {
                    int mahs= int.Parse(dgvHocSinh.CurrentRow.Cells["maHS"].Value.ToString());
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

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvHocSinh.CurrentRow.Cells["maHS"].Value != null)
                {
                    txtHoTen.Text = dgvHocSinh.CurrentRow.Cells["hoTenHS"].Value.ToString();
                    txtDCtamtru.Text = dgvHocSinh.CurrentRow.Cells["dcTamTru"].Value.ToString();
                    txtDCthuongtru.Text = dgvHocSinh.CurrentRow.Cells["dcThuongTru"].Value.ToString();
                    txtDanToc.Text = dgvHocSinh.CurrentRow.Cells["danToc"].Value.ToString();
                    txtTonGiao.Text = dgvHocSinh.CurrentRow.Cells["tonGiao"].Value.ToString();
                    txtHoTenCha.Text = dgvHocSinh.CurrentRow.Cells["hoTenCha"].Value.ToString();
                    txtHoTenMe.Text = dgvHocSinh.CurrentRow.Cells["hoTenMe"].Value.ToString();
                    txtNgheNghiepCha.Text = dgvHocSinh.CurrentRow.Cells["ngheNghiepCha"].Value.ToString();
                    txtNgheNghiepMe.Text = dgvHocSinh.CurrentRow.Cells["ngheNghiepMe"].Value.ToString();
                    dtNgaySinh.Value = DateTime.Parse(dgvHocSinh.CurrentRow.Cells["ngaySinh"].Value.ToString());
                    ////Gioi tinh
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
                if (dgvHocSinh.CurrentRow.Cells["maHS"].Value != null)
                {
                    txtHoTen.Text = dgvHocSinh.CurrentRow.Cells["hoTenHS"].Value.ToString();
                    txtDCtamtru.Text = dgvHocSinh.CurrentRow.Cells["dcTamTru"].Value.ToString();
                    txtDCthuongtru.Text = dgvHocSinh.CurrentRow.Cells["dcThuongTru"].Value.ToString();
                    txtDanToc.Text = dgvHocSinh.CurrentRow.Cells["danToc"].Value.ToString();
                    txtTonGiao.Text = dgvHocSinh.CurrentRow.Cells["tonGiao"].Value.ToString();
                    txtHoTenCha.Text = dgvHocSinh.CurrentRow.Cells["hoTenCha"].Value.ToString();
                    txtHoTenMe.Text = dgvHocSinh.CurrentRow.Cells["hoTenMe"].Value.ToString();
                    txtNgheNghiepCha.Text = dgvHocSinh.CurrentRow.Cells["ngheNghiepCha"].Value.ToString();
                    txtNgheNghiepMe.Text = dgvHocSinh.CurrentRow.Cells["ngheNghiepMe"].Value.ToString();
                    dtNgaySinh.Value = DateTime.Parse(dgvHocSinh.CurrentRow.Cells["ngaySinh"].Value.ToString());
                    ////Gioi tinh
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
                        cmbTrangThai.SelectedItem = "Đang học";
                    if (stt == 2)
                        cmbTrangThai.SelectedItem = "Đình chỉ";
                    if (stt == 0)
                        cmbTrangThai.SelectedItem = "Đã nghỉ";
                    //Lop hoc

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}