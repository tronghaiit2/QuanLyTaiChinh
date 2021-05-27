using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using QuanLyTaiChinh.Models;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyTaiChinh.Views;

namespace QuanLyTaiChinh.Controls
{
    public partial class QuyTienCtrl : UserControl
    {
        long hieuso_thuchi = 0;
        public QuyTienCtrl()
        {
            InitializeComponent();
        }

        // Vẽ biểu đồ hình tròn với các tham số truyền vào là mảng key, value
        private void Draw_Chart(Chart chart, string[] key, int[] value)
        {
            int n = key.Length;
            for (int i = 0; i < n; i++)
            {
                if(value[i] > 0)
                {
                    chart.Series["Series1"].Points.AddXY(key[i], value[i]);
                }
            }
        }

        // Tải dữ liệu nguồn thu nhập lên biểu đồ
        private void Load_NguonThuNhap()
        {
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;

            var thunhapCollection = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap").FindAll()
                               .Where(x => x.date >= date1 && x.date <= date2);

            string[] key = new string[]{
                    "Lương", "Thưởng", "Làm thêm", "Được cho, tặng", "Đi vay", "Nợ được trả"
                };

            int[] value = new int[]
            {
                0,0,0,0,0,0
            };

            foreach (var thunhap in thunhapCollection)
            {
                if (thunhap.phan_loai == "Lương")
                {
                    value[0] += (int)(thunhap.luong_tien/1000);
                }
                else if (thunhap.phan_loai == "Thưởng")
                {
                    value[1] += (int)(thunhap.luong_tien/1000);
                }
                else if (thunhap.phan_loai == "Làm thêm")
                {
                    value[2] += (int)(thunhap.luong_tien/1000);
                }
                else if (thunhap.phan_loai == "Được cho, tặng")
                {
                    value[3] += (int)(thunhap.luong_tien/1000);
                }
                else if (thunhap.phan_loai == "Đi vay")
                {
                    value[4] += (int)(thunhap.luong_tien/1000);
                }
                else if (thunhap.phan_loai == "Nợ được trả")
                {
                    value[5] += (int)(thunhap.luong_tien/1000);
                }
            }

            long tongthunhap = 0;
            for (long i = 0; i < 6; i++)
            {
                tongthunhap += value[i];
            }
            hieuso_thuchi = tongthunhap;
            textBoxThuNhap.Text = MainFrame.ChuanHoa(tongthunhap*1000) + " VND";
            textBoxNguonThuNhap.Text = "Tổng: " + MainFrame.ChuanHoa(tongthunhap) + " nghìn VND";
            textBoxTaiKhoanThuNhap.Text = textBoxNguonThuNhap.Text.Trim();
            Draw_Chart(chart1, key, value);
        }

        // Tải dữ liệu tài khoán thu nhập lên biểu đồ
        private void Load_TaiKhoanThuNhap()
        {
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;

            var thunhapCollection = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap")
                                .Include(x => x.tai_khoan).FindAll()
                                .Where(x => x.date >= date1 && x.date <= date2)
                                .OrderBy(x => x.tai_khoan.ten_tai_khoan);

            List<string> taikhoanList = new List<string>();
            foreach (var thunhap in thunhapCollection)
            {
                if (!taikhoanList.Contains(thunhap.tai_khoan.ten_tai_khoan))
                    taikhoanList.Add(thunhap.tai_khoan.ten_tai_khoan);
            }
            int i = 0, n = taikhoanList.Count;

            string[] key = new string[n];
            int[] value = new int[n];
            foreach (var item in taikhoanList)
            {
                key[i] = item;
                value[i] = 0;
                i++;
            }

            foreach (var thunhap in thunhapCollection)
            {
                for (i = 0; i < n; i++)
                {
                    if (key[i] == thunhap.tai_khoan.ten_tai_khoan)
                    {
                        value[i] += (int)(thunhap.luong_tien/1000);
                        break;
                    }
                }
            }
            Draw_Chart(chart2, key, value);
        }

        // Tải dữ liệu loại chi tiêu lên biểu đồ
        private void Load_LoaiChiTieu()
        {
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;

            var temp = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu").FindAll()
                               .Where(x => x.date >= date1 && x.date <= date2);

            string[] key = new string[]{
                    "Nhà ở", "Mua sắm","Tiêu dùng","Sức khỏe","Công việc",
                    "Vui chơi","Giải trí","Tiền cho, tặng","Cho vay","Trả nợ"
                };

            int[] value = new int[]
            {
                0,0,0,0,0,0,0,0,0,0
            };

            foreach (var item in temp)
            {
                if (item.muc_dich == "Nhà ở")
                {
                    value[0] += (int)(item.luong_tien/1000);
                }
                else if (item.muc_dich == "Mua sắm")
                {
                    value[1] += (int)(item.luong_tien/1000);
                }
                else if (item.muc_dich == "Tiêu dùng")
                {
                    value[2] += (int)(item.luong_tien/1000);
                }
                else if (item.muc_dich == "Sức khỏe")
                {
                    value[3] += (int)(item.luong_tien/1000);
                }
                else if (item.muc_dich == "Công việc")
                {
                    value[4] += (int)(item.luong_tien/1000);
                }
                else if (item.muc_dich == "Vui chơi")
                {
                    value[5] += (int)(item.luong_tien/1000);
                }
                else if (item.muc_dich == "Giải trí")
                {
                    value[6] += (int)(item.luong_tien/1000);
                }
                else if (item.muc_dich == "Tiền cho, tặng")
                {
                    value[7] += (int)(item.luong_tien/1000);
                }
                else if (item.muc_dich == "Cho vay")
                {
                    value[8] += (int)(item.luong_tien/1000);
                }
                else if (item.muc_dich == "Trả nợ")
                {
                    value[9] += (int)(item.luong_tien/1000);
                }
            }
            long tongchitieu = 0;
            for(int i = 0; i < 10; i++)
            {
                tongchitieu += value[i];
            }
            hieuso_thuchi -= tongchitieu;
            textBoxChiTieu.Text = MainFrame.ChuanHoa(tongchitieu*1000) + " VND";
            textBoxLoaiChiTieu.Text = "Tổng: " + MainFrame.ChuanHoa(tongchitieu) + " nghìn VND";
            textBoxTaiKhoanChiTieu.Text = textBoxLoaiChiTieu.Text.Trim();
            Draw_Chart(chart3, key, value);
        }

        // Tải dữ liệu tài khoản chi tiêu lên biểu đồ
        private void Load_TaiKhoanChiTieu()
        {
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;

            var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu")
                                .Include(x => x.tai_khoan).FindAll()
                                .Where(x => x.date >= date1 && x.date <= date2)
                                .OrderBy(x => x.tai_khoan.ten_tai_khoan);

            List<string> taikhoanList = new List<string>();
            foreach (var chitieu in chitieuCollection)
            {
                if (!taikhoanList.Contains(chitieu.tai_khoan.ten_tai_khoan))
                    taikhoanList.Add(chitieu.tai_khoan.ten_tai_khoan);
            }
            int i = 0, n = taikhoanList.Count;

            string[] key = new string[n];
            int[] value = new int[n];
            foreach (var item in taikhoanList)
            {
                key[i] = item;
                value[i] = 0;
                i++;
            }

            foreach (var chitieu in chitieuCollection)
            {
                for (i = 0; i < n; i++)
                {
                    if (key[i] == chitieu.tai_khoan.ten_tai_khoan)
                    {
                        value[i] += (int)(chitieu.luong_tien/1000);
                        break;
                    }
                }
            }
            Draw_Chart(chart4, key, value);
        }

        // Tải dữ liệu tài khoản lên biểu đồ
        private void Load_TaiKhoan()
        {
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;

            var temp = DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll()
                               .OrderBy(x => x.ten_tai_khoan);

            List<KeyValuePair<string, long>> taikhoanList = new List<KeyValuePair<string, long>>();
            foreach (var item in temp)
            {
                taikhoanList.Add(new KeyValuePair<string, long>(item.ten_tai_khoan, item.so_du));
            }
            int i = 0, n = taikhoanList.Count;
            string[] key = new string[n];
            int[] value = new int[n];
            foreach(var taikhoan in taikhoanList)
            {
                key[i] = taikhoan.Key;
                value[i] = (int)(taikhoan.Value/1000);
                i++;
            }
            long tongtaisan = 0;
            for (i = 0; i < n; i++)
            {
                tongtaisan += value[i];
            }
            textBoxSoDuTaiKhoan.Text = MainFrame.ChuanHoa(tongtaisan) + " nghìn VND";
            textBoxTaiSan.Text = MainFrame.ChuanHoa(hieuso_thuchi*1000) + " VND";
            Draw_Chart(chart5, key, value);
        }

        // Tải dữ liệu nguồn tiết kiệm lên biểu đồ
        private void Load_TietKiem()
        {
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;

            var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem")
                                .Include(x => x.tai_khoan).FindAll()
                                .Where(x => x.date >= date1 && x.date <= date2)
                                .OrderBy(x => x.tai_khoan.ten_tai_khoan);

            List<string> taikhoanList = new List<string>();
            foreach (var tietkiem in tietkiemCollection)
            {
                if (!taikhoanList.Contains(tietkiem.tai_khoan.ten_tai_khoan))
                    taikhoanList.Add(tietkiem.tai_khoan.ten_tai_khoan);
            }
            int i = 0, n = taikhoanList.Count;

            string[] key = new string[n];
            int[] value = new int[n];
            foreach (var taikhoan in taikhoanList)
            {
                key[i] = taikhoan;
                value[i] = 0;
                i++;
            }

            foreach (var tietkiem in tietkiemCollection)
            {
                for(i = 0; i < n; i++)
                {
                    if(key[i] == tietkiem.tai_khoan.ten_tai_khoan)
                    {
                        value[i] += (int)(tietkiem.luong_tien/1000);
                        break;
                    }
                }
            }
            long tongtietkiem = 0;
            for (i = 0; i < n; i++)
            {
                tongtietkiem += value[i];
            }
            textBoxTietKiem.Text = MainFrame.ChuanHoa(tongtietkiem*1000) + " VND";
            textBoxTaiKhoanTietKiem.Text = "Tổng: " + MainFrame.ChuanHoa(tongtietkiem) + " nghìn VND";
            Draw_Chart(chart6, key, value);
        }

        // Làm mới dữ liệu và vẽ lại biểu đồ
        private void ReDraw_Chart()
        {
            chart1.Series["Series1"].Points.Clear();
            Load_NguonThuNhap();

            chart2.Series["Series1"].Points.Clear();
            Load_TaiKhoanThuNhap();

            chart3.Series["Series1"].Points.Clear();
            Load_LoaiChiTieu();

            chart4.Series["Series1"].Points.Clear();
            Load_TaiKhoanChiTieu();

            chart5.Series["Series1"].Points.Clear();
            Load_TaiKhoan();

            chart6.Series["Series1"].Points.Clear();
            Load_TietKiem();
        }

        // Lựa chọn loại phân tích
        private void selectPhanTich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectPhanTich.Text.Trim() == "Tất cả")
            {
                int temp = DBContext.GetIntance().GetCollection<TaiSan>("tai_san").Count();
                if (temp != 0)
                {
                    dateTimePicker1.Value = DBContext.GetIntance().GetCollection<TaiSan>("tai_san")
                                    .Min(x => x.date);
                    dateTimePicker2.Value = DBContext.GetIntance().GetCollection<TaiSan>("tai_san")
                                    .Max(x => x.date);
                }
                ReDraw_Chart();
            }
        }

        // Lựa chọn ngày bắt đầu
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(selectPhanTich.Text.Trim() == "Tùy chọn")
            {
                ReDraw_Chart();
            }
            else
            {
                MessageBox.Show("Hãy chọn Tùy chọn trước khi chọn ngày, tháng!");
                selectPhanTich.Focus();
            }
        }

        // Lựa chọn ngày kết thúc
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(selectPhanTich.Text.Trim() == "Tùy chọn")
            {
                ReDraw_Chart();
            }
            else
            {
                MessageBox.Show("Hãy chọn Tùy chọn trước khi chọn ngày, tháng!");
                selectPhanTich.Focus();
            }
        }
    }
}
