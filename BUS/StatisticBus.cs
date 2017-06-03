using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class StatisticBus
    {
        private StatisticDAO statisticDao;
        private DataClassesDataContext dbContext;
        public StatisticBus()
        {
            statisticDao = new StatisticDAO();
            dbContext = new DataClassesDataContext();
        }

        public List<BangDiem> getListScore()
        {
            return statisticDao.listScore();
        }

        public List<BangDiem> getListScoreByYear(string year)
        {
            return statisticDao.getListScoreByYear(year);
        }

        public HocSinh getStudentByID(int id)
        {
            return statisticDao.getStudentByID(id);
        }

        public MonHoc getSubjectByID(int id)
        {
            return statisticDao.getSubjectByID(id);
        }

        public List<BangDiem> getListScoreByStudent(int id, string year)
        {
            return dbContext.BangDiems.Where(m => m.maHS == id && m.namHoc == year).ToList();
        }

        public BangDiem learningOutComes(List<BangDiem> list)
        {
            BangDiem score = new BangDiem();
            score.tbHocKy1 = 0;
            score.tbHocKy2 = 0;
            score.tbNamHoc = 0;

            foreach (BangDiem obj in list )
            {
                score.tbHocKy1 += obj.tbHocKy1;
                score.tbHocKy2 += obj.tbHocKy2;
                score.tbNamHoc += obj.tbNamHoc;
            }
            score.tbHocKy1 = score.tbHocKy1 / list.Count;
            score.tbHocKy2 = score.tbHocKy2 / list.Count;
            score.tbNamHoc = score.tbNamHoc / list.Count;
            return score;
        }



        public HanhKiem getConductStudent(int id, string year)
        {
            return dbContext.HanhKiems.Single(m => m.maHS == id && m.namHoc == year);
        }

        public DataTable getDatatableStatistic(string year)
        {
            DataTable dt = new DataTable();
            initDataTableStatistic(dt);
            foreach (HocSinh student in dbContext.HocSinhs.ToList())
            {
                try
                {
                    BangDiem score = learningOutComes(getListScoreByStudent(student.maHS, year));
                    HanhKiem conduct = getConductStudent(student.maHS, year);
                    DataRow row = dt.NewRow();
                    row["Học sinh"] = student.hoTenHS;
                    row["Lớp"] = dbContext.Lops.Single(m => m.maLop == student.maLop).tenLop;
                    row["Năm học"] = year;
                    row["TB học kỳ 1"] = ConverScore(score.tbHocKy1.ToString());
                    row["HK học kì 1"] = conduct.hocKy1;
                    row["TB học kỳ 2"] = ConverScore(score.tbHocKy2.ToString()); 
                    row["HK Học kỳ 2"] = conduct.hocKy2;
                    row["TB cả năm"] = ConverScore(score.tbNamHoc.ToString());
                    row["HK cả năm"] = conduct.caNam;
                    dt.Rows.Add(row);
                }
                catch(Exception e)
                {
                  
                }
                 
            }

            return dt;
        }

        private string ConverScore(string str)
        {
            return str.Substring(0,4);
        }


        private void initDataTableStatistic(DataTable dt)
        { 

            DataColumn dc = new DataColumn("Học sinh", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("Lớp", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("Năm học", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("TB học kỳ 1", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("HK học kì 1", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("TB học kỳ 2", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("HK Học kỳ 2", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("TB cả năm", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("HK cả năm", typeof(String));
            dt.Columns.Add(dc);

            //dc = new DataColumn("Tổng kết", typeof(String));
            //dt.Columns.Add(dc);

        }

        public DataTable StatisticByType(string score, string conduct)
        {

            DataTable dataTale = getDatatableStatistic("2017");
            switch (score)
            {
                case "ExcellentStudent":
                    {
                        for (int i = dataTale.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = dataTale.Rows[i];
                            if (float.Parse(dr["TB cả năm"].ToString()) < 8)
                                dr.Delete();
                        }
                        break;
                    }
                case "GoodStudent":
                    {
                        for (int i = dataTale.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = dataTale.Rows[i];
                            if (float.Parse(dr["TB cả năm"].ToString()) < 6.5 || float.Parse(dr["TB cả năm"].ToString()) >= 8)
                                dr.Delete();
                        }
                        break;
                    }
                case "AvergareStudent":
                    {
                        for (int i = dataTale.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = dataTale.Rows[i];
                            if (float.Parse(dr["TB cả năm"].ToString()) < 8 || float.Parse(dr["TB cả năm"].ToString()) >= 6.4)
                                dr.Delete();
                        }
                        break;
                    }
                case "WeakStudent":
                    {
                        for (int i = dataTale.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = dataTale.Rows[i];
                            if (float.Parse(dr["TB cả năm"].ToString()) >= 5)
                                dr.Delete();
                        }
                        break;
                    }
            }

            switch (conduct)
            {
                case "ExcellentConduct":
                    {
                        for (int i = dataTale.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = dataTale.Rows[i];
                            if (dr["HK cả năm"].ToString() != "Tốt")
                                dr.Delete();
                        }
                        break;
                    }
                case "GoodConduct":
                    {
                        for (int i = dataTale.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = dataTale.Rows[i];
                            if (dr["HK cả năm"].ToString() != "Khá")
                                dr.Delete();
                        }
                        break;
                    }
                case "AverageConduct":
                    {
                        for (int i = dataTale.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = dataTale.Rows[i];
                            if (dr["HK cả năm"].ToString() != "Trung bình")
                                dr.Delete();
                        }
                        break;
                    }
                case "WeakConduct":
                    {
                        for (int i = dataTale.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = dataTale.Rows[i];
                            if (dr["HK cả năm"].ToString() != "Yếu")
                                dr.Delete();
                        }
                        break;
                    }
            }

            return dataTale;
        }

        public DataTable StatisticByRangeOfScore(float score1,float score2)
        {
            if (score1 > score2)
            {
                return null;
            }
            DataTable dataTale = getDatatableStatistic("2017");
            for (int i = dataTale.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = dataTale.Rows[i];
                float score = float.Parse(dr["TB cả năm"].ToString());
                if (score < score1 || score > score2)
                    dr.Delete();
            }

            return dataTale;
        }

    }
}
