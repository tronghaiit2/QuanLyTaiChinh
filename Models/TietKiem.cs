using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace QuanLyTaiChinh.Models
{
    class TietKiem
    {
        public int ID { get; set; }

        [BsonRef("tai_khoan")]
        public TaiKhoan tai_khoan { get; set; }

        public string mo_ta { get; set; }

        public long luong_tien { get; set; }

        public DateTime date { get; set; }
    }
}
