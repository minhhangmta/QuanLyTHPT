using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class StatisticDAO
    {
        private DataClassesDataContext dbContext;

        public StatisticDAO()
        {
            this.dbContext = new DataClassesDataContext();
        }

        public List<HocSinh> listStudent()
        {
            return dbContext.HocSinhs.ToList();
        }

        public List<GiaoVien> listTeacher()
        {
            return dbContext.GiaoViens.ToList();
        }

        public List<Lop> listClass()
        {
            return dbContext.Lops.ToList();
        }

        public List<BangDiem> listScore()
        {
            return dbContext.BangDiems.ToList();
        }
        
    }
}
