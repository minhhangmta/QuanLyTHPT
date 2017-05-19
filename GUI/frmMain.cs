using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btn_HocSinh_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ucHocSinh.Instance))
            {
                panel.Controls.Add(ucHocSinh.Instance);
                ucHocSinh.Instance.Dock = DockStyle.Fill;
                ucHocSinh.Instance.BringToFront();
            }
            else
                ucHocSinh.Instance.BringToFront();
        }
    }
}
