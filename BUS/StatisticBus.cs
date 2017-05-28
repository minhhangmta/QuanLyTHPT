using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class StatisticBus
    {
        private StatisticDAO statisticDao;

        public StatisticBus()
        {
            statisticDao = new StatisticDAO();
        }

        public List<BangDiem> getListScore()
        {
            return statisticDao.listScore();
        }

    }
}
