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
    public partial class ThemTaiKhoan : Form
    {
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            boxPhanLoai.ForeColor = Color.Gray;
        }


        private void boxPhanLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            boxPhanLoai.ForeColor = Color.Black;
        }

        private void textBoxSoDu_TextChanged(object sender, EventArgs e)
        {
            String tmp = textBoxSoDu.Text.Trim().Replace(" ", String.Empty);
            if (tmp == string.Empty || tmp == "Số tiền")
            {

            }
            else if (long.TryParse(tmp, out long m))
            {
                long temp = long.Parse(tmp);
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                nfi.NumberDecimalDigits = 0;
                nfi.NumberGroupSeparator = " ";
                textBoxSoDu.Text = temp.ToString("N", nfi);
                textBoxSoDu.SelectionStart = textBoxSoDu.Text.Length;
            }
            else
            {
                MessageBox.Show("Số tiền là số nguyên dương ít hơn 18 chữ số!");
                textBoxSoDu.Focus();
                return;
            }
        }

        private void buttonThemTaiKhoan_Click(object sender, EventArgs e)
        {
            // Lấy thông tin tài khoản từ Database
            var taikhoan = DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll();

            // Lấy danh sách tài khoản để lúc sau kiểm tra đã có tài khoản chưa 
            List<string> tentaikhoanList = new List<string>();
            foreach (var item in taikhoan)
            {
                tentaikhoanList.Add(item.ten_tai_khoan);
            }

            /* If-else để kiểm tra điều kiện từng ô nhập
             * Tên tài khoản phải là duy nhất
            */ 
            if (textBoxTenTaiKhoan.Text.Trim() == string.Empty ||
                textBoxTenTaiKhoan.Text.Trim() == "Tên tài khoản")
            {
                MessageBox.Show("Hãy điền tên tài khoản!");
                textBoxTenTaiKhoan.Focus();
                return;
            }
            else if (tentaikhoanList.Contains(textBoxTenTaiKhoan.Text.Trim()))
            {
                MessageBox.Show("Đã có tên tài khoản này!");
                textBoxTenTaiKhoan.Focus();
                return;
            }
            else if (textBoxChuTaiKhoan.Text.Trim() == string.Empty ||
                textBoxChuTaiKhoan.Text.Trim() == "Chủ tài khoản")
            {
                MessageBox.Show("Hãy điền chủ tài khoản!");
                textBoxChuTaiKhoan.Focus();
                return;
            }
            else if (textBoxSoTaiKhoan.Text.Trim() == string.Empty ||
                textBoxSoTaiKhoan.Text.Trim() == "Số tài khoản")
            {
                MessageBox.Show("Hãy điền số tài khoản!");
                textBoxSoTaiKhoan.Focus();
                return;
            }
            else if (boxPhanLoai.Text.Trim() == "Phân loại")
            {
                MessageBox.Show("Hãy chọn loại tài khoản!");
                boxPhanLoai.Focus();
                return;
            }
            else if (textBoxSoDu.Text.Trim() == string.Empty ||
                    textBoxSoDu.Text.Trim() == "Số dư")
            {
                MessageBox.Show("Hãy điền số tiền!");
                textBoxSoDu.Focus();
                return;
            }
            else
            {
                ThemThongTinTaiKhoan();
                this.Close();
            }
        }

        // Thêm thông tin tài khoản vài Database
        private void ThemThongTinTaiKhoan()
        {
            // Lấy bộ sưu tập tài khoản từ Database
            var taikhoanCollection = DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan");

            // Tạo một tài khoản mới
            var taikhoan = new TaiKhoan
            {
                ten_tai_khoan = textBoxTenTaiKhoan.Text.Trim(),
                chu_tai_khoan = textBoxChuTaiKhoan.Text.Trim(),
                so_tai_khoan = textBoxSoTaiKhoan.Text.Trim(),
                loai_tai_khoan = boxPhanLoai.Text.Trim(),
                tien_nhan = 0,
                tien_chuyen = 0,
                tiet_kiem = 0,
                so_du = long.Parse(textBoxSoDu.Text.Trim().Replace(" ", String.Empty)),
                date = dateTimePicker1.Value.Date,
            };
            taikhoanCollection.Insert(taikhoan);
            MessageBox.Show("Đã thêm thành công tài khoản " + textBoxTenTaiKhoan.Text.Trim() + ".");
        }
    }
}
