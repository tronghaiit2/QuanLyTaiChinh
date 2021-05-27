using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace QuanLyTaiChinh.Models
{
    class ThuNhap
    {
        public int ID { get; set; }

        public string nguoi_gui { get; set; }
        public string noi_gui { get; set; }
        public string mo_ta { get; set; }
        public string phan_loai { get; set; }

        [BsonRef("tai_khoan")]
        public TaiKhoan tai_khoan { get; set; }

        public long luong_tien { get; set; }

        public DateTime date { get; set; }

    }
}
