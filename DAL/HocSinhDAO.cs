using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HocSinhDAO
    {
        private static HocSinhDAO instance;

        public static HocSinhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HocSinhDAO();
                return instance;
            }
        }
        private HocSinhDAO() { }
        public List<HocSinh> GetList()
        {
            List<HocSinh> hocsinh = new List<HocSinh>();
            DataClassesDataContext db = new DataClassesDataContext();
            hocsinh = db.HocSinhs.Select(p => p).ToList(); //tra ve 1 thang hs thi phai .tolist cho no
            return hocsinh;
        }
    }
}
