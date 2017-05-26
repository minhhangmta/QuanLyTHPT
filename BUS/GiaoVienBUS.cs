using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class GiaoVienBUS
    {
        private static GiaoVienBUS instance;

        public static GiaoVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiaoVienBUS();
                return instance;
            }
        }

        public GiaoVienBUS() { }
        public List<GiaoVien> GetList()
        {
            return DB.GiaoViens.ToList();
        }

        DataClassesDataContext DB = new DataClassesDataContext();

    }
}
