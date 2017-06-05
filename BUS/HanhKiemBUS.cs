using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HanhKiemBUS
    {
        private static HanhKiemBUS instance;

        public static HanhKiemBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HanhKiemBUS();
                return instance;
            }
        }

        public HanhKiemBUS() { }

        DataClassesDataContext DB = new DataClassesDataContext();

        public List<HanhKiem> GetList()
        {
            List<HanhKiem> lst = new List<HanhKiem>();
        //    DB.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, DB.HanhKiems.ToList());
            return DB.HanhKiems.ToList();
        }
    }
}
