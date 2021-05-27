using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace QuanLyTaiChinh.Models
{
    //singleton access to database
    public static class DBContext
    {
        static LiteDatabase _instance;

        public static void Init (string fileName)
        {
            _instance = new LiteDatabase(fileName);
        }

        public static LiteDatabase GetIntance()
        {
            return _instance;
        }

    }
}
