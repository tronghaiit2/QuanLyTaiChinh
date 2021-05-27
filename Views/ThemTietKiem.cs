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
    public partial class ThemTietKiem : Form
    {
        public ThemTietKiem()
        {
            InitializeComponent();

            //Lấy dữ liệu Tài khoản vào box chọn tài khoàn tiết kiệm
            boxChonTien.Items.Clear();

            foreach (var item in DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll())
            {
                if (boxChonTien.Items.Contains(item.loai_tai_khoan) == false)
                    boxChonTien.Items.Add(item.loai_tai_khoan);
            }
        }

        // Load màn hình tiết kiệm
        private void ThemTietKiem_Load(object sender, EventArgs e)
        {
            boxChonTaiKhoan.ForeColor = Color.Gray;
            boxChonTien.ForeColor = Color.Gray;
        }

        // Thay đổi chọn loại tiền sẽ chuyển text về màu đen
        private void boxChonTaiKhoan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            boxChonTaiKhoan.ForeColor = Color.Black;
        }

        // Thay đổi chọn tài khoản sẽ chuyển text về màu đen
        private void boxChonTien_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            boxChonTien.ForeColor = Color.Black;
            // Kiếm tra hợp lệ của box chọn loại tiền tài khoản như tiền mặt, ví, thẻ, ...
            string loaitien = boxChonTien.Text.Trim();
            List<string> loaitienList = new List<string>();

            for (int i = 0; i < boxChonTien.Items.Count; i++)
            {
                loaitienList.Add(boxChonTien.Items[i].ToString());
            }
            if (loaitienList.Contains(loaitien))
            {
                // Nếu loại tiền được chọn hợp kệ thì tìm kiếm tài khoản hợp lệ để cho vào box chọn tài khoản
                boxChonTaiKhoan.Items.Clear();

                foreach (var item in DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll()
                        .Where(x => x.loai_tai_khoan == loaitien))
                {
                    boxChonTaiKhoan.Items.Add(item.ten_tai_khoan);
                }
            }
            else
            {
                // Nếu không hợp lệ thì hiển thị thông báo
                MessageBox.Show("Hãy chọn loại tiền!");
                boxChonTien.Focus();
                return;
            }
        }

        private void selectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectBox.ForeColor = Color.Black;
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

        private void buttonThemTietKiem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin tài khoản từ box chọn tài khoản để kiểm tra hợp lệ
            string taikhoan = boxChonTaiKhoan.Text.Trim();
            List<string> taikhoanList = new List<string>();

            for (int i = 0; i < boxChonTaiKhoan.Items.Count; i++)
            {
                taikhoanList.Add(boxChonTaiKhoan.Items[i].ToString());
            }

            /* If-else để kiểm tra điều kiện từng ô nhập
             * Số tiền tiết kiệm dương là gửi vào thỏa mãn ít hơn số dư trong tài khoản
             * Số tiền tiết kiệm âm là rút ra thỏa mãn ít hơn tiền đang được tiết kiệm
            */
            if (!taikhoanList.Contains(taikhoan))
            {
                MessageBox.Show("Hãy chọn hoặc tạo thêm tài khoản!");
                boxChonTaiKhoan.Focus();
                return;
            }
            else if (textBoxMoTa.Text.Trim() == string.Empty ||
                     textBoxMoTa.Text.Trim() == "Mô tả")
            {
                MessageBox.Show("Hãy Mô tả!");
                textBoxMoTa.Focus();
                return;
            }
            else if (selectBox.Text.Trim() == string.Empty ||
                     selectBox.Text.Trim() == "Chọn")
            {
                MessageBox.Show("Hãy chọn thêm hoặc rút tiết kiệm!");
                selectBox.Focus();
                return;
            }
            else
            {
                var taikhoan_sodu = DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll()
                    .First(x => x.ten_tai_khoan == boxChonTaiKhoan.Text.Trim());
                long tien_tietkiem = long.Parse(textBoxLuongTien.Text.Trim().Replace(" ", String.Empty));
                if (selectBox.Text.Trim() == "Rút" &&
                    taikhoan_sodu.tiet_kiem - tien_tietkiem < 0)
                {
                    MessageBox.Show("Tài khoản không đủ để rút tiết kiệm!");
                    boxChonTaiKhoan.Focus();
                    return;
                }
                else if (selectBox.Text.Trim() == "Thêm" && taikhoan_sodu.so_du - tien_tietkiem < 0)
                {
                    MessageBox.Show("Tài khoản không đủ để tiết kiệm!");
                    boxChonTaiKhoan.Focus();
                    return;
                }
                else
                {
                    ThemThongTinTietKiem();
                    this.Close();
                }
            }
        }

        // Thêm thông tin tiết kiệm vào Database
        private void ThemThongTinTietKiem()
        {
            // Lấy tài khoản từ bộ sư tập tài khoản trùng với tài khoản được chọn
            var taikhoan = DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll().
                First(x => x.ten_tai_khoan == boxChonTaiKhoan.Text.Trim());

            // Số tiền tiết kiệm
            long tien_tietkiem = long.Parse(textBoxLuongTien.Text.Trim().Replace(" ", String.Empty));

            // Số tiền tiết kiệm trong tài khoản tăng lên
            taikhoan.tiet_kiem += tien_tietkiem;

            // Lấy tài khoản đã có trong bộ sưu tập biến động số dư tài khoản
            var taikhoan_sodu = DBContext.GetIntance().GetCollection<TaiSan>("tai_san").FindAll()
                .FirstOrDefault(x => x.tai_khoan == boxChonTaiKhoan.Text.Trim() && x.date == dateTimePicker1.Value.Date);
            if (taikhoan_sodu == null)
            {
                // Nếu chưa có tài khoản trong bộ sưu tập biến động số dư thì tạo mới tài khoản
                var taisan = new TaiSan
                {
                    date = dateTimePicker1.Value.Date,
                    tai_khoan = boxChonTaiKhoan.Text.Trim(),
                    thu_nhap = 0,
                    chi_tieu = 0,
                    tiet_kiem = (selectBox.Text.Trim() == "Thêm") ? tien_tietkiem : 0 - tien_tietkiem,
                    so_du = taikhoan.so_du,
                };

                // Thêm mới tài khoản vào bộ sư tập biến động số dư
                var taisanCollection = DBContext.GetIntance().GetCollection<TaiSan>("tai_san");
                taisanCollection.Insert(taisan);
            }
            else
            {
                // Nếu đã có tài khoản trong bộ sư tập biến động số dư

                // Cập nhật lại số tiền tài khoản tiết kiệm
                taikhoan_sodu.tiet_kiem += tien_tietkiem;

                // Update thông tin trong bộ sư tập biến động số dư
                DBContext.GetIntance().GetCollection<TaiSan>("tai_san").Update(taikhoan_sodu);
            }
            // Update thông tin trong bộ sư tập tài khoản
            DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").Update(taikhoan);

            // Lấy bộ sưu tập tiết kiệm từ Database
            var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem");

            // Tạo một tiết kiệm mới
            var tietkiem = new TietKiem
            {
                tai_khoan = taikhoan,
                mo_ta = textBoxMoTa.Text.Trim(),
                luong_tien = (selectBox.Text.Trim() == "Thêm") ? tien_tietkiem : 0 - tien_tietkiem,
                date = dateTimePicker1.Value.Date,
            };
            tietkiemCollection.Insert(tietkiem);
            if(selectBox.Text.Trim() == "Thêm")
                MessageBox.Show("Đã thêm thành công một tiết kiệm.");
            else if (selectBox.Text.Trim() == "Rút")
                MessageBox.Show("Đã rút thành công một tiết kiệm.");
        }
    }
}
