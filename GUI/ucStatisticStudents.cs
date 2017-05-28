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
            dgvStatistic.DataSource = statisticBus.getListScore();
        }

    }
}
