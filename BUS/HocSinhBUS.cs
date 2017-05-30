using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class HocSinhBUS
    {
        private static HocSinhBUS instance;

        public static HocSinhBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HocSinhBUS();
                return instance;
            }
        }

        public HocSinhBUS() { }
        
        DataClassesDataContext DB = new DataClassesDataContext();

        public List<HocSinh> GetList()
        {
            List<HocSinh> lst = new List<HocSinh>();
            DB.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, DB.HocSinhs.ToList());
            return DB.HocSinhs.ToList();
        }

        public void GetTenLop(ComboBox cmb)
        {
            cmb.DataSource = DB.Lops.ToList();
            cmb.DisplayMember = "tenLop";
            cmb.ValueMember = "maLop";
        }

        public int DeleteHocSinh(int mahs)
        {
            try
            {
                HocSinh hs = DB.HocSinhs.Where(h => h.maHS == mahs).FirstOrDefault();
                DB.HocSinhs.DeleteOnSubmit(hs);
                DB.SubmitChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }

        public int InsertHocSinh(HocSinh hs)
        {
            try
            {
                DB.HocSinhs.InsertOnSubmit(hs);
                DB.SubmitChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }

        public List<Lop> getListLop()
        {
            return DB.Lops.ToList();
        }

        public int EditHocSinh(HocSinh hs)
        {
            try
            {
                HocSinh hocsinh = DB.HocSinhs.Single(m => m.maHS == hs.maHS);
                hocsinh.hoTenCha = hs.hoTenCha;
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
                DB.SubmitChanges();
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

        public void DisplayCombobox_LopHoc()
        {

        }
    }
}
