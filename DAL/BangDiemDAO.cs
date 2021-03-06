﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class BangDiemDAO
    {
        private static BangDiemDAO instance;

        public static BangDiemDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BangDiemDAO();
                return instance;
            }
        }
        private BangDiemDAO() { }
        public List<BangDiem> GetList()
        {
            List<BangDiem> bangdiem = new List<BangDiem>();
            DataClassesDataContext db = new DataClassesDataContext();
            bangdiem = db.BangDiems.Select(p => p).ToList(); //tra ve 1 thang hs thi phai .tolist cho no
            return bangdiem;
        }
    }
}
