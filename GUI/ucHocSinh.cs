using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public ucHocSinh()
        {
            InitializeComponent();
        }

    }
}
