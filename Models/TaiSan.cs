using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace QuanLyTaiChinh.Models
{
    class TaiSan
    {
        public int ID { get; set; }
        public DateTime date { get; set; }
        public string tai_khoan { get; set; }
        
        public long so_du { get; set; }
        public long thu_nhap { get; set; }
        public long chi_tieu { get; set; }
        public long tiet_kiem { get; set; }
    }
}
