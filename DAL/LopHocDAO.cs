using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class LopHocDAO
    {
        private static LopHocDAO instance;

        public static LopHocDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LopHocDAO();
                return instance;
            }
        }
        private LopHocDAO() { }
        public List<Lop> GetList()
        {
            List<Lop> lop = new List<Lop>();
            //O day dung using de no tu don dep khi dung xong, vi cai datacontext nam ben DTO nen sd using ntn tot hon
            DataClassesDataContext db = new DataClassesDataContext();
            lop = db.Lops.Select(p => p).ToList(); //tra ve 1 thang hs thi phai .tolist cho no
            return lop;
        }
    }
}
