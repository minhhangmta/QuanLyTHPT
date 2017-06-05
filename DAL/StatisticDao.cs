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

        public List<BangDiem> getListScoreByYear(string year)
        {
            return  dbContext.BangDiems.Where(m => m.namHoc == year).ToList();
        }

        public HocSinh getStudentByID(int id)
        {
            return dbContext.HocSinhs.Single(m => m.maHS == id);
        }

        public MonHoc getSubjectByID(int id)
        {
            return dbContext.MonHocs.Single(m => m.maMH == id);
        }
    }
}
