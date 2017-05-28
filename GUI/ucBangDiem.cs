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

        //HocSinhBUS HSBUS = new HocSinhBUS();
        public ucBangDiem()
        {
            InitializeComponent();
        }
    }
}
