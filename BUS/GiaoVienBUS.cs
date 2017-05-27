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

        DataClassesDataContext DB = new DataClassesDataContext();

        public List<GiaoVien> GetList()
        {
            List<GiaoVien> lst = new List<GiaoVien>();
            DB.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, DB.GiaoViens.ToList());
            return DB.GiaoViens.ToList();
        }

        public void GetMonHoc(ComboBox cmb)
        {
            cmb.DataSource = DB.MonHocs.ToList();
            cmb.DisplayMember = "tenMH";
            cmb.ValueMember = "maMH";
        }

        public void GetChucVu(ComboBox cmb)
        {
            cmb.DataSource = DB.ChucVus.ToList();
            cmb.DisplayMember = "tenCV";
            cmb.ValueMember = "maCV";
        }
    }
}
