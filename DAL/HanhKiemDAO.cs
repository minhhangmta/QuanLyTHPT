using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class HanhKiemDAO
    {
        private static HanhKiemDAO instance;

        public static HanhKiemDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HanhKiemDAO();
                return instance;
            }
        }
        private HanhKiemDAO() { }
        public List<HanhKiem> GetList()
        {
            List<HanhKiem> hanhkiem = new List<HanhKiem>();
            DataClassesDataContext db = new DataClassesDataContext();
            hanhkiem = db.HanhKiems.Select(p => p).ToList(); //tra ve 1 thang hs thi phai .tolist cho no
            return hanhkiem;
        }
    }
}
