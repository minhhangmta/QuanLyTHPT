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
            var checkedRadioCapacity = new[] { grbCapacity }
                   .SelectMany(g => g.Controls.OfType<RadioButton>()
                                            .Where(r => r.Checked));
            Console.Write(checkedRadioCapacity.ToString());

            var checkedRadioConduct = new[] { grbConduct }
                  .SelectMany(g => g.Controls.OfType<RadioButton>()
                                           .Where(r => r.Checked));
        }
    }
}
