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
            LoadDB();
        }

        LopHocBUS LHBUS = new LopHocBUS();

        private string status = "";

        public Lop getLop()
        {
            Lop lop = new Lop();
            lop.siSo = int.Parse(txtSiSo.Text);
            lop.maGVCN = int.Parse(cmbGVCN.SelectedValue.ToString());
            lop.maKhoi = int.Parse(cmbTenKhoi.SelectedValue.ToString());
            lop.maBan = int.Parse(cmbPhanBan.SelectedValue.ToString());
            lop.tenLop = txtTenLop.Text;
            return lop;
        }

        public void LoadDB()
        {
           dgvLopHoc.DataSource = LHBUS.GetList();
            LopHocBUS.Instance.GetTenBan(cmbPhanBan);
            LopHocBUS.Instance.GetTenKhoi(cmbTenKhoi);
            LopHocBUS.Instance.GetTenGV(cmbGVCN);
        }



        public void tool_Disenabled()
        {
            txtSiSo.Enabled = false;
            txtTenLop.Enabled = false;
            cmbGVCN.Enabled = false;
            cmbPhanBan.Enabled = false;
            cmbTenKhoi.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        public void clearText()
        {
            txtSiSo.Clear();
            txtTenLop.Clear();
            cmbGVCN.Text = "";
            cmbPhanBan.Text = "";
            cmbTenKhoi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = "Them";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            clearText();
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
            DialogResult res = MessageBox.Show("Xóa lớp học " + txtTenLop.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            {
                if (res == DialogResult.OK)
                {
                    int malop = int.Parse(dgvLopHoc.CurrentRow.Cells["maLop"].Value.ToString());
                    int result = LopHocBUS.Instance.DeleteLop(malop);
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

        public bool isNULL(string str)
        {
            if (dgvLopHoc.CurrentRow.Cells[str].Value == null)
                return true;
            else
                return false;
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (isNULL("maLop") == false)
                {
                    txtSiSo.Text = dgvLopHoc.CurrentRow.Cells["siSo"].Value.ToString();
                    txtTenLop.Text = dgvLopHoc.CurrentRow.Cells["tenLop"].Value.ToString();

                    //Khoi Lop
                    cmbTenKhoi.SelectedValue = dgvLopHoc.CurrentRow.Cells["maKhoi"].Value.GetHashCode();

                    //Phan Ban
                    cmbPhanBan.SelectedValue = dgvLopHoc.CurrentRow.Cells["maBan"].Value.GetHashCode();

                    //GVien
                    if (isNULL("maGVCN") == false)
                        cmbGVCN.SelectedValue = dgvLopHoc.CurrentRow.Cells["maGVCN"].Value.GetHashCode();
                    else
                        cmbGVCN.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLopHoc_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (isNULL("maLop") == false)
                {
                    txtSiSo.Text = dgvLopHoc.CurrentRow.Cells["siSo"].Value.ToString();
                    txtTenLop.Text = dgvLopHoc.CurrentRow.Cells["tenLop"].Value.ToString();

                    //Khoi Lop
                    cmbTenKhoi.SelectedValue = dgvLopHoc.CurrentRow.Cells["maKhoi"].Value.GetHashCode();

                    //Phan Ban
                    cmbPhanBan.SelectedValue = dgvLopHoc.CurrentRow.Cells["maBan"].Value.GetHashCode();

                    //GVien
                    if (isNULL("maGVCN") == false)
                        cmbGVCN.SelectedValue = dgvLopHoc.CurrentRow.Cells["maGVCN"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLopHoc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvLopHoc.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (status == "Them")
            {
                int result = LopHocBUS.Instance.InsertLop(getLop());
                if (result == 1)
                {
                    MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm lớp không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Lop lop = getLop();
                lop.maLop = int.Parse(dgvLopHoc.CurrentRow.Cells["maLop"].Value.ToString());
                int result = LopHocBUS.Instance.EditLop(lop);
                if (result == 1)
                {
                    MessageBox.Show("Sửa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa lớp không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
            tool_Disenabled();
            LoadDB();
        }

        private void dgvLopHoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
