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
    public partial class ucHanhKiem : UserControl
    {
        private static ucHanhKiem _instance;
        public static ucHanhKiem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucHanhKiem();
                return _instance;
            }
        }
        public ucHanhKiem()
        {
            InitializeComponent();
        }
    }
}
