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
    public partial class ucStatisticStudents : UserControl
    {
        private StatisticBus statisticBus;

        public ucStatisticStudents()
        {
            InitializeComponent();
            statisticBus = new StatisticBus();
            LoadData();
        }

        private void LoadData()
        {
            //dgvStatistic.DataSource = statisticBus.getListScoreByYear("2017");
            //dgvStatistic.Columns["HocSinh"].Visible = false;
            //dgvStatistic.Columns["MonHoc"].Visible = false;
            //dgvStatistic.Columns["maHS"].HeaderText = "Học Sinh";
            //dgvStatistic.Columns["maMH"].HeaderText = "Môn học";
            dgvStatistic.DataSource = statisticBus.getDatatableStatistic("2017");
        }

        private void dgvStatistic_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dgvStatistic.Columns[e.ColumnIndex].Name == "maHS")
            {
                if (e.Value != null)
                {
                    int id = (int)e.Value;
                    HocSinh st = statisticBus.getStudentByID(id);
                    e.Value = st.hoTenHS;
                }
            }

            if (dgvStatistic.Columns[e.ColumnIndex].Name == "maMH")
            {
                if (e.Value != null)
                {
                    int id = (int)e.Value;
                    MonHoc subject = statisticBus.getSubjectByID(id);
                    e.Value = subject.tenMH;
                }
            }
        }

        private void btnStatisticByType_Click(object sender, EventArgs e)
        {
            string SCORE = "";
            if (rbtAverageStudent.Checked){
                SCORE = "AvergareStudent"; 
            }else if (rbtExcellentStudent.Checked)
            {
                SCORE = "ExcellentStudent";
            }else if (rbtGoodStudent.Checked)
            {
                SCORE = "GoodStudent";
            }else if(rbtWeakStudent.Checked)
            {
                SCORE = "WeakStudent";
            }
            else if (rbtAllStudent.Checked){
                SCORE = "AllStudent";
            }

            string CONDUCT = "";
            if (rbtAllConduct.Checked)
            {
                CONDUCT = "AllConduct";
            }else if (rbtExcellentConduct.Checked)
            {
                CONDUCT = "ExcellentConduct";
            }else if (rbtGoodConduct.Checked)
            {
                CONDUCT = "GoodConduct";
            }else if (rbtAverageConduct.Checked)
            {
                CONDUCT = "AverageConduct";
            }else if (rbtWeakConduct.Checked)
            {
                CONDUCT = "WeakConduct";
            }

           dgvStatistic.DataSource =  statisticBus.StatisticByType(SCORE,CONDUCT);
        }

        private void btnStatisticByScore_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = statisticBus.StatisticByRangeOfScore(float.Parse(cbb1.Text), float.Parse(cbb2.Text));
                if (dt == null)
                {
                    MessageBox.Show("Nhập sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvStatistic.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Nhập sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            



        }

        private void cbb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvStatistic.DataSource = statisticBus.getDatatableStatistic("2017");
        }

        private void cbbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStatistic.DataSource = statisticBus.getDatatableStatistic(cbbYear.Text);
            }
            catch
            {
                MessageBox.Show("Nhập sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
        }
    }
}
