using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace QuanLyTaiChinh.Models
{
    class TaiKhoan
    {
        public int ID { get; set; }
        public string ten_tai_khoan { get; set; }
        public string chu_tai_khoan { get; set; }
        public string so_tai_khoan { get; set; }

        public string loai_tai_khoan { get; set; }
        public long tien_nhan { get; set; }
        public long tien_chuyen { get; set; }
        public long so_du { get; set; }
        public long tiet_kiem { get; set; }

        public DateTime date { get; set; }
    }
}
