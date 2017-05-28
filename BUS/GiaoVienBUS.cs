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

        public int DeleteGiaoVien(int magv)
        {
            try
            {
                GiaoVien gv = DB.GiaoViens.Where(h => h.maGV == magv).FirstOrDefault();
                DB.GiaoViens.DeleteOnSubmit(gv);
                DB.SubmitChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }
        public int InsertGiaoVien(GiaoVien gv)
        {
            try
            {
                DB.GiaoViens.InsertOnSubmit(gv);
                DB.SubmitChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }

        public int EditGiaoVien(GiaoVien gv)
        {
            try
            {
                GiaoVien giaovien= DB.GiaoViens.Single(m => m.maGV == gv.maGV);
                giaovien.hoTenGV = gv.hoTenGV;
                giaovien.maCV = gv.maCV;
                giaovien.maLuong = gv.maLuong;
                giaovien.maMH = gv.maMH;
                giaovien.ngaySinh = gv.ngaySinh;
                giaovien.sdt = gv.sdt;
                giaovien.trangThai = gv.trangThai;
                giaovien.trinhDo = gv.trinhDo;
                giaovien.email = gv.email;
                giaovien.gioiTinh = gv.gioiTinh;
                DB.SubmitChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }
    }
}
