using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        public static GiaoVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiaoVienDAO();
                return instance;
            }
        }
        private GiaoVienDAO() { }
        public List<GiaoVien> GetListGiaoVien()
        {
            List<GiaoVien> giaovien = new List<GiaoVien>();
            DataClassesDataContext db = new DataClassesDataContext();
            giaovien = db.GiaoViens.Select(p => p).ToList(); 
            return giaovien;
        }
    }
}
