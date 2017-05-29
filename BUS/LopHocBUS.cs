using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    class LopHocBUS
    {
        private static LopHocBUS instance;

        public static LopHocBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LopHocBUS();
                return instance;
            }
        }

        public LopHocBUS() { }

        DataClassesDataContext DB = new DataClassesDataContext();

        public List<Lop> GetList()
        {
            List<Lop> lst = new List<Lop>();
            DB.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, DB.Lops.ToList());
            return DB.Lops.ToList();
        }

    /*    public void GetTenLop(ComboBox cmb)
        {
            cmb.DataSource = DB.Lops.ToList();
            cmb.DisplayMember = "tenLop";
            cmb.ValueMember = "maLop";
        }*/

        public int DeleteLop(int malop)
        {
            try
            {
                Lop lop= DB.Lops.Where(h => h.maLop == malop).FirstOrDefault();
                DB.Lops.DeleteOnSubmit(lop);
                DB.SubmitChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }

        public int InsertLop(Lop lop)
        {
            try
            {
                DB.Lops.InsertOnSubmit(lop);
                DB.SubmitChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }

        public int EditLop(Lop lop)
        {
            try
            {
                Lop lp = DB.Lops.Single(m => m.maLop == lop.maLop);
                /*hocsinh.hoTenCha = hs.hoTenCha;
                hocsinh.hoTenHS = hs.hoTenHS;
                hocsinh.hoTenMe = hs.hoTenMe;
                hocsinh.maLop = hs.maLop;
                hocsinh.ngaySinh = hs.ngaySinh;
                hocsinh.ngheNghiepCha = hs.ngheNghiepCha;
                hocsinh.ngheNghiepMe = hs.ngheNghiepMe;
                hocsinh.tonGiao = hs.tonGiao;
                hocsinh.trangThai = hs.trangThai;
                hocsinh.chucVu = hs.chucVu;
                hocsinh.danToc = hs.danToc;
                hocsinh.gioiTinh = hs.gioiTinh;
                hocsinh.dcTamTru = hs.dcTamTru;
                hocsinh.dcThuongTru = hs.dcThuongTru;
                */DB.SubmitChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
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
    }
}
