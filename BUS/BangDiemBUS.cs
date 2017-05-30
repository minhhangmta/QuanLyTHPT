using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
