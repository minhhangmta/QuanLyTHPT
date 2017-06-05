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

        public void GetMaLuong(ComboBox cmbMaLuong)
        {
            cmbMaLuong.DataSource = DB.Luongs.ToList();
            cmbMaLuong.DisplayMember = "maLuong";
            cmbMaLuong.ValueMember = "maLuong";
        }

        public string StandardString(string strInput)
        {
            strInput = strInput.Trim().ToLower();
            while (strInput.Contains("  "))
                strInput = strInput.Replace("  ", " ");
            string strResult = "";
            string[] arrResult = strInput.Split(' ');
            foreach (string item in arrResult)
                strResult += item.Substring(0, 1).ToUpper() + item.Substring(1) + " ";
            return strResult.TrimEnd();
        }

        public string StandardWord(string data)
        {
            if (data.Length > 0)
            {
                while (data.IndexOf("  ") > 0)
                {
                    data = data.Replace("  ", " ");
                    data = data.Trim();
                }
            }
            return data;
        }

        public List<MonHoc> getListMH()
        {
            return DB.MonHocs.ToList();
        }

        public List<ChucVu> getListCV()
        {
            return DB.ChucVus.ToList();
        }

        public List<Luong> getListLuong()
        {
            return DB.Luongs.ToList();
        }
    }
}
