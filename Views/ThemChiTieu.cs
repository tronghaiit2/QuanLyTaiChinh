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
    public partial class ThemChiTieu : Form
    {
        public ThemChiTieu()
        {
            InitializeComponent();

            //Lấy dữ liệu Tài khoản vào box chọn tài khoàn chi tiêu
            boxTaiKhoan.Items.Clear();

            foreach (var item in DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll())
            {
                boxTaiKhoan.Items.Add(item.ten_tai_khoan);
            }
        }

        // Load màn hình chi tiêu
        private void ThemChiTieu_Load(object sender, EventArgs e)
        {
            boxTaiKhoan.ForeColor = System.Drawing.Color.Gray;
            boxMucDich.ForeColor = System.Drawing.Color.Gray;
        }

        // Thay đổi chọn tài khoản sẽ chuyển text về màu đen
        private void boxTaiKhoan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            boxTaiKhoan.ForeColor = System.Drawing.Color.Black;
        }

        // Thay đổi chọn mục đích sẽ chuyển text về màu đen
        private void boxMucDich_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            boxMucDich.ForeColor = System.Drawing.Color.Black;
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

        private void buttonThemChiTieu_Click(object sender, EventArgs e)
        {
            /* If-else để kiểm tra điều kiện từng ô nhập
             * Số tiền chi tiêu phải là số nguyên dương
             * Số tiền chi tiêu phải ít hơn số tiền trong tài khoản (đã từ tiền tiết kiệm)
            */
            if (textBoxNguoiNhan.Text.Trim() == string.Empty ||
                 textBoxNguoiNhan.Text.Trim() == "Người nhận")
            {
                MessageBox.Show("Hãy điền người nhận!");
                textBoxNguoiNhan.Focus();
                return;
            }
            else if (textBoxNoiNhan.Text.Trim() == string.Empty ||
                     textBoxNoiNhan.Text.Trim() == "Nơi nhận")
            {
                MessageBox.Show("Hãy điền nơi nhận!");
                textBoxNoiNhan.Focus();
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
            else if (boxMucDich.Text.Trim() == string.Empty ||
                     boxMucDich.Text.Trim() == "Mục đích")
            {
                MessageBox.Show("Hãy chọn phân loại!");
                boxMucDich.Focus();
                return;
            }
            else if (textBoxLuongTien.Text.Trim() == string.Empty ||
                     textBoxLuongTien.Text.Trim() == "Số tiền")
            {
                MessageBox.Show("Hãy điền số tiền!");
                textBoxLuongTien.Focus();
                return;
            }
            else
            {
                var taikhoan = DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll()
                    .First(x => x.ten_tai_khoan == boxTaiKhoan.Text.Trim());
                long tien_thunhap = long.Parse(textBoxLuongTien.Text.Trim().Replace(" ", string.Empty));
                if (taikhoan.so_du < tien_thunhap)
                {
                    MessageBox.Show("Hãy chọn tài khoản khác vì không đủ tiền!");
                    boxTaiKhoan.Focus();
                    return;
                }
                else if (taikhoan.so_du - taikhoan.tiet_kiem < tien_thunhap)
                {
                    MessageBox.Show("Hãy rút tiền từ tiền tiết kiệm ra trước!");
                    boxTaiKhoan.Focus();
                    return;
                }
                else
                {
                    ThemThongTinChiTieu();
                    this.Close();
                }
            }
        }

        // Thêm thông tin chi tiêu vào Database
        private void ThemThongTinChiTieu()
        {
            // Lấy tài khoản từ bộ sư tập tài khoản trùng với tài khoản được chọn
            var taikhoan = DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll().
                First(x => x.ten_tai_khoan == boxTaiKhoan.Text.Trim());

            // Số tiền chi tiêu
            long tien_chitieu = long.Parse(textBoxLuongTien.Text.Trim().Replace(" ", String.Empty));

            // Số tiền chuyển đi trong tài khoản tăng lên
            taikhoan.tien_chuyen += tien_chitieu;

            // Số dư trong tài khoản giảm xuống
            taikhoan.so_du -= tien_chitieu;

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
                    thu_nhap = 0,
                    chi_tieu = tien_chitieu,
                    tiet_kiem = 0,
                    so_du = taikhoan.so_du,
                };

                // Thêm mới tài khoản vào bộ sư tập biến động số dư
                var taisanCollection = DBContext.GetIntance().GetCollection<TaiSan>("tai_san");
                taisanCollection.Insert(taisan);
            }
            else
            {
                // Nếu đã có tài khoản trong bộ sư tập biến động số dư

                // Cập nhật lại số tiền tài khoản chuyển đi
                taikhoan_sodu.chi_tieu = taikhoan.tien_chuyen;

                // Cập nhật lại số dư tài khoản
                taikhoan_sodu.so_du = taikhoan.so_du;

                // Update thông tin trong bộ sư tập biến động số dư
                DBContext.GetIntance().GetCollection<TaiSan>("tai_san").Update(taikhoan_sodu);
            }
            // Update thông tin trong bộ sư tập tài khoản
            DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").Update(taikhoan);

            // Lấy bộ sưu tập chi tiêu từ Database
            var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu");

            // Tạo một chi tiêu mới
            var chitieu = new ChiTieu
            {
                nguoi_nhan = textBoxNguoiNhan.Text.Trim(),
                noi_nhan = textBoxNoiNhan.Text.Trim(),
                mo_ta = textBoxMoTa.Text.Trim(),
                muc_dich = boxMucDich.Text.Trim(),
                tai_khoan = taikhoan,
                luong_tien = tien_chitieu,
                date = dateTimePicker1.Value.Date,
            };
            chitieuCollection.Insert(chitieu);
            MessageBox.Show("Đã thêm thành công một chi tiêu.");
        }
    }
}
