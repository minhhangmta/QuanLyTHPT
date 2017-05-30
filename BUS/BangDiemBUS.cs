using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BangDiemBUS
    {
        private static BangDiemBUS instance;

        public static BangDiemBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BangDiemBUS();
                return instance;
            }
        }

        public BangDiemBUS() { }

        DataClassesDataContext DB = new DataClassesDataContext();

        public List<BangDiem> GetList()
        {
            List<BangDiem> lst = new List<BangDiem>();
            DB.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, DB.BangDiems.ToList());
            return DB.BangDiems.ToList();
        }

        public void GetTenLop(ComboBox cmb)
        {
            cmb.DataSource = DB.Lops.ToList();
            cmb.DisplayMember = "tenLop";
            cmb.ValueMember = "maLop";
        }

        public void GetMonHoc(ComboBox cmb)
        {
            cmb.DataSource = DB.MonHocs.ToList();
            cmb.DisplayMember = "tenMH";
            cmb.ValueMember = "maMH";
        }

        public void GetHoTen(ComboBox cmb)
        {
            cmb.DataSource = DB.HocSinhs.ToList();
            cmb.DisplayMember = "hoTenHS";
            cmb.ValueMember = "maHS";
        }

        public List<HocSinh> getListHS()
        {
            return DB.HocSinhs.ToList();
        }


        public List<MonHoc> getListMH()
        {
            return DB.MonHocs.ToList();
        }



        public int DeleteBangDiem(int mahs, int mamh)
        {
            try
            {
                BangDiem bd = DB.BangDiems.Where(h => h.maMH == mamh && h.maHS == mahs).FirstOrDefault();
                DB.BangDiems.DeleteOnSubmit(bd);
                DB.SubmitChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }

        public int InsertBangDiem(BangDiem bd)
        {
            try
            {
                DB.BangDiems.InsertOnSubmit(bd);
                DB.SubmitChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }

        public int EditBangDiem(BangDiem bd)
        {
            try
            {
                BangDiem bangdiem = DB.BangDiems.FirstOrDefault(m => m.maHS == bd.maHS && m.maMH == bd.maMH);
                //bangdiem.maHS = bd.maHS;
                //bangdiem.maMH = bd.maMH;
                bangdiem.namHoc = bd.namHoc;
                bangdiem.tbHocKy1 = bd.tbHocKy1;
                bangdiem.tbHocKy2 = bd.tbHocKy2;
                bangdiem.tbNamHoc = bd.tbNamHoc;
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
    }
}
