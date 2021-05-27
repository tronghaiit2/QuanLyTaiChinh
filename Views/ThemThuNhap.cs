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
using System.Globalization;

namespace QuanLyTaiChinh.Views
{
    public partial class ThemThuNhap : Form
    {
        public ThemThuNhap()
        {
            InitializeComponent();

            //Lấy dữ liệu Tài khoản vào box chọn tài khoàn thu nhập
            boxTaiKhoan.Items.Clear();

            foreach (var item in DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll())
            {
                boxTaiKhoan.Items.Add(item.ten_tai_khoan);
            }

        }

        // Load màn hình thu nhập
        private void ThemThuNhap_Load(object sender, EventArgs e)
        {
            boxTaiKhoan.ForeColor = System.Drawing.Color.Gray;
            boxPhanLoai.ForeColor = System.Drawing.Color.Gray;
        }

        // Thay đổi chọn tài khoản sẽ chuyển text về màu đen
        private void boxTaiKhoan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            boxTaiKhoan.ForeColor = Color.Black;
        }

        // Thay đổi chọn phân loại sẽ chuyển text về màu đen
        private void boxPhanLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            boxPhanLoai.ForeColor = Color.Black;
        }

        private void textBoxLuongTien_TextChanged(object sender, EventArgs e)
        {
            String tmp = textBoxLuongTien.Text.Trim().Replace(" ", String.Empty);
            if (tmp == string.Empty || tmp == "Số tiền")
            {

            }
            else if (long.TryParse(tmp, out long m))
            {
                long temp = long.Parse(tmp);
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                nfi.NumberDecimalDigits = 0;
                nfi.NumberGroupSeparator = " ";
                textBoxLuongTien.Text = temp.ToString("N", nfi);
                textBoxLuongTien.SelectionStart = textBoxLuongTien.Text.Length;
            }
            else
            {
                MessageBox.Show("Số tiền là số nguyên dương ít hơn 18 chữ số!");
                textBoxLuongTien.Focus();
                return;
            }
        }

        private void buttonThemThuNhap_Click(object sender, EventArgs e)
        {
            /* If-else để kiểm tra điều kiện từng ô nhập
             * Số tiền thu nhập phải là số nguyên dương
            */
            if (textBoxNguoiGui.Text.Trim() == string.Empty ||
                 textBoxNguoiGui.Text.Trim() == "Người gửi")
            {
                MessageBox.Show("Hãy điền người gửi!");
                textBoxNguoiGui.Focus();
                return;
            }
            else if (textBoxNoiGui.Text.Trim() == string.Empty ||
                     textBoxNoiGui.Text.Trim() == "Nơi gửi")
            {
                MessageBox.Show("Hãy điền nơi gửi!");
                textBoxNoiGui.Focus();
                return;
            }
            else if (textBoxMoTa.Text.Trim() == string.Empty ||
                     textBoxMoTa.Text.Trim() == "Mô tả")
            {
                MessageBox.Show("Hãy Mô tả!");
                textBoxMoTa.Focus();
                return;
            }
            else if (boxTaiKhoan.Text.Trim() == string.Empty ||
                     boxTaiKhoan.Text.Trim() == "Tài khoản")
            {
                MessageBox.Show("Hãy chọn hoặc tạo thêm tài khoản!");
                boxTaiKhoan.Focus();
                return;
            }
            else if (boxPhanLoai.Text.Trim() == string.Empty ||
                     boxPhanLoai.Text.Trim() == "Phân loại")
            {
                MessageBox.Show("Hãy chọn phân loại!");
                boxPhanLoai.Focus();
                return;
            }
            else if (textBoxLuongTien.Text.Trim() == string.Empty ||
                     textBoxLuongTien.Text.Trim() == "Số tiền" )
            {
                MessageBox.Show("Hãy điền số tiền!");
                textBoxLuongTien.Focus();
                return;
            }
            else
            {
                ThemThongTinThuNhap();
                this.Close();
            }
        }

        // Thêm thông tin thu nhập vào Database
        private void ThemThongTinThuNhap()
        {
            // Lấy tài khoản từ bộ sư tập tài khoản trùng với tài khoản được chọn
            var taikhoan = DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll().
                First(x => x.ten_tai_khoan == boxTaiKhoan.Text.Trim());

            // Số tiền thu nhập
            long tien_thunhap = long.Parse(textBoxLuongTien.Text.Trim().Replace(" ", String.Empty));

            // Số tiền nhận được trong tài khoản tăng lên
            taikhoan.tien_nhan += tien_thunhap;

            // Số dư trong tài khoản tăng lên
            taikhoan.so_du += tien_thunhap;

            // Lấy tài khoản đã có trong bộ sưu tập biến động số dư tài khoản
            var taikhoan_sodu = DBContext.GetIntance().GetCollection<TaiSan>("tai_san").FindAll()
                .FirstOrDefault(x => x.tai_khoan == boxTaiKhoan.Text.Trim() && x.date == dateTimePicker1.Value.Date);

            if (taikhoan_sodu == null)
            {
                // Nếu chưa có tài khoản trong bộ sưu tập biến động số dư thì tạo mới tài khoản
                var taisan = new TaiSan
                {
                    date = dateTimePicker1.Value.Date,
                    tai_khoan = boxTaiKhoan.Text.Trim(),
                    thu_nhap = tien_thunhap,
                    chi_tieu = 0,
                    tiet_kiem = 0,
                    so_du = taikhoan.so_du
                };
                
                // Thêm mới tài khoản vào bộ sư tập biến động số dư
                var taisanCollection = DBContext.GetIntance().GetCollection<TaiSan>("tai_san");
                taisanCollection.Insert(taisan);
            }
            else
            {
                // Nếu đã có tài khoản trong bộ sư tập biến động số dư

                // Cập nhật lại số tiền tài khoản nhận được
                taikhoan_sodu.thu_nhap = taikhoan.tien_nhan; 

                // Cập nhật lại số dư tài khoản
                taikhoan_sodu.so_du = taikhoan.so_du;

                // Update thông tin trong bộ sư tập biến động số dư
                DBContext.GetIntance().GetCollection<TaiSan>("tai_san").Update(taikhoan_sodu);
            }
            // Update thông tin trong bộ sư tập tài khoản
            DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").Update(taikhoan);

            // Lấy bộ sưu tập thu nhập từ Database
            var thunhapCollection = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap");

            // Tạo một thunhap mới
            var thunhap = new ThuNhap
            {
                nguoi_gui = textBoxNguoiGui.Text.Trim(),
                noi_gui = textBoxNoiGui.Text.Trim(),
                mo_ta = textBoxMoTa.Text.Trim(),
                phan_loai = boxPhanLoai.Text.Trim(),
                tai_khoan = taikhoan,
                luong_tien = tien_thunhap,
                date = dateTimePicker1.Value.Date,
            };
            thunhapCollection.Insert(thunhap);
            MessageBox.Show("Đã thêm thành công một thu nhập.");
        }
    }
}
