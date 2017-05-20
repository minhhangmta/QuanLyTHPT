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

        private string status = "";

        public void LoadDB()
        {
            dgvBangDiem.DataSource = BDBUS.GetList();
            BangDiemBUS.Instance.GetHoTen(cmbHoTen);
            BangDiemBUS.Instance.GetMonHoc(cmbMonHoc);
            BangDiemBUS.Instance.GetTenLop(cmbLopHoc);
        }
        public ucBangDiem()
        {
            InitializeComponent();
            LoadDB();
        }

        

        public void tool_Enabled()
        {
            cmbHoTen.Enabled = true;
            cmbLopHoc.Enabled = true;
            cmbMonHoc.Enabled = true;
            cmbNamHoc.Enabled = true;
            txtCaNam.Enabled = true;
            txtHK1.Enabled = true;
            txtHK2.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        public void tool_Disenabled()
        {
            cmbHoTen.Enabled = false;
            cmbLopHoc.Enabled = false;
            cmbMonHoc.Enabled = false;
            cmbNamHoc.Enabled = false;
            txtCaNam.Enabled = false;
            txtHK1.Enabled = false;
            txtHK2.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        public void clearText()
        {
            cmbHoTen.Text = "";
            cmbLopHoc.Text = "";
            cmbMonHoc.Text = "";
            cmbNamHoc.Text = "2017";
            txtCaNam.Clear();
            txtHK1.Clear();
            txtHK2.Clear();
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
            DialogResult res = MessageBox.Show("Bạn có muốn xóa bảng điểm này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            {
                if (res == DialogResult.OK)
                {
                    int mahs = int.Parse(dgvBangDiem.CurrentRow.Cells["maHS"].Value.ToString());
                    int mamh = int.Parse(dgvBangDiem.CurrentRow.Cells["maMH"].Value.ToString());
                    int result = BangDiemBUS.Instance.DeleteBangDiem(mahs, mamh);
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
                int result = BangDiemBUS.Instance.InsertBangDiem(getBangDiem());
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
                BangDiem bd = getBangDiem();
                bd.maHS = int.Parse(dgvBangDiem.CurrentRow.Cells["maHS"].Value.ToString());
                bd.maMH = int.Parse(dgvBangDiem.CurrentRow.Cells["maMH"].Value.ToString());
                int result = BangDiemBUS.Instance.EditBangDiem(bd);
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

        private void dgvBangDiem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvBangDiem.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        public bool isNull(string str)
        {
            if (dgvBangDiem.CurrentRow.Cells[str].Value == null)
                return true;
            else
                return false;
        }

        private void dgvBangDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (isNull("maHS") == false && isNull("maMH") == false)
                {
                    txtCaNam.Text = dgvBangDiem.CurrentRow.Cells["tbNamHoc"].Value.ToString();
                    txtHK1.Text = dgvBangDiem.CurrentRow.Cells["tbHocKy1"].Value.ToString();
                    txtHK2.Text = dgvBangDiem.CurrentRow.Cells["tbHocKy2"].Value.ToString();
                    cmbNamHoc.SelectedItem = dgvBangDiem.CurrentRow.Cells["namHoc"].Value.ToString();
                    cmbHoTen.SelectedItem = BangDiemBUS.Instance.getHocSinhById(int.Parse(dgvBangDiem.CurrentRow.Cells["maHS"].Value.ToString()));
                    cmbMonHoc.SelectedItem = BangDiemBUS.Instance.getMonHocByID(int.Parse(dgvBangDiem.CurrentRow.Cells["maMH"].Value.ToString()));
                    cmbLopHoc.SelectedItem = BangDiemBUS.Instance.getLopByID(int.Parse(dgvBangDiem.CurrentRow.Cells["maHS"].Value.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBangDiem_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (isNull("maHS") == false && isNull("maMH") == false)
                {
                    txtCaNam.Text = dgvBangDiem.CurrentRow.Cells["tbNamHoc"].Value.ToString();
                    txtHK1.Text = dgvBangDiem.CurrentRow.Cells["tbHocKy1"].Value.ToString();
                    txtHK2.Text = dgvBangDiem.CurrentRow.Cells["tbHocKy2"].Value.ToString();
                    cmbNamHoc.SelectedItem = dgvBangDiem.CurrentRow.Cells["namHoc"].Value.ToString();
                    cmbHoTen.SelectedItem = BangDiemBUS.Instance.getHocSinhById(int.Parse(dgvBangDiem.CurrentRow.Cells["maHS"].Value.ToString()));
                    cmbMonHoc.SelectedItem = BangDiemBUS.Instance.getMonHocByID(int.Parse(dgvBangDiem.CurrentRow.Cells["maMH"].Value.ToString()));
                    cmbLopHoc.SelectedItem = BangDiemBUS.Instance.getLopByID(int.Parse(dgvBangDiem.CurrentRow.Cells["maHS"].Value.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBangDiem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            List<HocSinh> listHS = BangDiemBUS.Instance.getListHS();
            List<MonHoc> listMH = BangDiemBUS.Instance.getListMH();

            if (this.dgvBangDiem.Columns[e.ColumnIndex].Name == "maHS")
            {
                if (e.Value != null)
                {
                    foreach (HocSinh hs in listHS)
                    {
                        if (int.Parse(e.Value.ToString()) == hs.maHS)
                        {
                            e.Value = hs.hoTenHS;
                            return;
                        }
                    }
                }
            }

            if (this.dgvBangDiem.Columns[e.ColumnIndex].Name == "maMH")
            {
                if (e.Value != null)
                {
                    foreach (MonHoc mon in listMH)
                    {
                        if (int.Parse(e.Value.ToString()) == mon.maMH)
                        {
                            e.Value = mon.tenMH;
                            return;
                        }
                    }
                }
            }
        }
    }
}
