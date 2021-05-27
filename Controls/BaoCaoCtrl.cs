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
using KimToo;

namespace QuanLyTaiChinh.Controls
{
    public partial class BaoCaoCtrl : UserControl
    {
        public BaoCaoCtrl()
        {
            InitializeComponent();
        }

        // Load tổng quan thu nhập, chi tiêu, tiết kiệm
        long LoadData()
        {
            // Khởi tạo và lấy giá trị các biến
            long tong_thu_nhap = 0;
            long tong_chi_tieu = 0;
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;

            // Lấy dữ liệu từ bộ sưu tập Tài sản
            var taisanCollection = DBContext.GetIntance().GetCollection<TaiSan>("tai_san")
                .Include(x => x.tai_khoan).FindAll().Where(x => x.date >= date1 && x.date <= date2)
                .OrderBy(x => x.date);

            // Duyệt từng phần tử từ dữ liệu
            dataGridViewTongQuan.Rows.Clear();
            int i = 1;
            foreach (var taisan in taisanCollection)
            {
                // Tính toán tổng tiền
                tong_thu_nhap += taisan.thu_nhap;
                tong_chi_tieu += taisan.chi_tieu;
                // Thêm dữ liệu vào bảng theo từng hàng
                dataGridViewTongQuan.Rows.Add(new object[]
                {
                    i++,
                    taisan.date.Day.ToString() + "/" + taisan.date.Month.ToString() + "/" + taisan.date.Year.ToString(),
                    taisan.tai_khoan,
                    MainFrame.ChuanHoa(taisan.so_du),
                    MainFrame.ChuanHoa(taisan.thu_nhap),
                    MainFrame.ChuanHoa(taisan.chi_tieu),
                    MainFrame.ChuanHoa(taisan.tiet_kiem)
                });
            }

            // Trả lại hiệu số chi tiêu
            return tong_thu_nhap - tong_chi_tieu;
        }

        // Load toàn bộ thu nhập
        long LoadThuNhap()
        {
            // Khởi tạo và lấy giá trị các biến
            long tong_thu_nhap = 0;
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;

            // Lấy dữ liệu từ bộ sưu tập Thu nhập
            var thunhapCollection = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap")
                .Include(x => x.tai_khoan).FindAll().Where(x => x.date >= date1 && x.date <= date2)
                .OrderBy(x => x.date);

            // Duyệt từng phần tử từ dữ liệu
            dataGridViewThuNhap.Rows.Clear();
            int i = 1;
            foreach (var thunhap in thunhapCollection)
            {
                // Tính toán tổng tiền
                tong_thu_nhap += thunhap.luong_tien;
                // Thêm dữ liệu vào bảng theo từng hàng
                dataGridViewThuNhap.Rows.Add(new object[]
                {
                    i++,
                    thunhap.date.Day.ToString() + "/" + thunhap.date.Month.ToString() + "/" + thunhap.date.Year.ToString(),
                    thunhap.nguoi_gui.ToString(),
                    thunhap.noi_gui.ToString(),
                    thunhap.mo_ta.ToString(),
                    thunhap.phan_loai.ToString(),
                    thunhap.tai_khoan.ten_tai_khoan.ToString(),
                    MainFrame.ChuanHoa(thunhap.luong_tien)
                });
            }

            // Trả lại tổng tiền thu nhập
            return tong_thu_nhap;
        }

        // Load toàn bộ chi tiêu
        long LoadChiTieu()
        {
            // Khởi tạo và lấy giá trị các biến
            long tong_chi_tieu = 0;
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;

            // Lấy dữ liệu từ bộ sưu tập Chi tiêu
            var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu")
                .Include(x => x.tai_khoan).FindAll().Where(x => x.date >= date1 && x.date <= date2)
                .OrderBy(x => x.date);

            // Duyệt từng phần tử từ dữ liệu
            dataGridViewChiTieu.Rows.Clear();
            int i = 1;
            foreach (var chitieu in chitieuCollection)
            {
                // Tính toán tổng tiền
                tong_chi_tieu += chitieu.luong_tien;
                // Thêm dữ liệu vào bảng theo từng hàng
                dataGridViewChiTieu.Rows.Add(new object[]
                {
                    i++,
                    chitieu.date.Day.ToString() + "/" + chitieu.date.Month.ToString() + "/" + chitieu.date.Year.ToString(),
                    chitieu.nguoi_nhan.ToString(),
                    chitieu.noi_nhan.ToString(),
                    chitieu.mo_ta.ToString(),
                    chitieu.muc_dich.ToString(),
                    chitieu.tai_khoan.ten_tai_khoan.ToString(),
                    MainFrame.ChuanHoa(chitieu.luong_tien)
                });
            }

            // Trả lại tổng tiền chi tiêu
            return tong_chi_tieu;
        }

        // Load toàn bộ tiết kiệm
        long LoadTietKiem()
        {
            // Khởi tạo và lấy giá trị các biến
            long tong_tiet_kiem = 0;
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;

            // Lấy dữ liệu từ bộ sưu tập Tiết kiệm
            var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem")
                .Include(x => x.tai_khoan).FindAll().Where(x => x.date >= date1 && x.date <= date2)
                .OrderBy(x => x.date);

            // Duyệt từng phần tử từ dữ liệu
            dataGridViewTietKiem.Rows.Clear();
            int i = 1;
            foreach (var tietkiem in tietkiemCollection)
            {
                // Tính toán tổng tiền
                tong_tiet_kiem += tietkiem.luong_tien;
                // Thêm dữ liệu vào bảng theo từng hàng
                dataGridViewTietKiem.Rows.Add(new object[]
                {
                    i++,
                    tietkiem.date.Day.ToString() + "/" + tietkiem.date.Month.ToString() + "/" + tietkiem.date.Year.ToString(),
                    tietkiem.tai_khoan.loai_tai_khoan.ToString(),
                    tietkiem.tai_khoan.ten_tai_khoan.ToString(),
                    tietkiem.mo_ta.ToString(),
                    MainFrame.ChuanHoa(tietkiem.luong_tien)
                });
            }

            // Trả lại tổng tiền tiết kiệm
            return tong_tiet_kiem;
        }

        // Tạo bản xem trước báo cáo trước khi in
        private void buttonPreview_Click(object sender, EventArgs e)
        {
            // Khởi tạo và lấy giá trị các biến
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;
            long tong_thu_nhap = LoadThuNhap();
            long tong_chi_tieu = LoadChiTieu();
            long tong_tiet_kiem = LoadTietKiem();
            long thunhap_chitieu = LoadData();

            // Trình bày thông tin báo cáo
            easyHTMLReports1.Clear();
            easyHTMLReports1.AddString("<h1>Báo cáo tài chính</h1>");
            easyHTMLReports1.AddString("<h3>Từ ngày "+date1.Day.ToString()+"/"+date1.Month.ToString()+"/"+date1.Year.ToString()+
                    " đến ngày "+ date2.Day.ToString() + "/" + date2.Month.ToString() + "/" + date2.Year.ToString() + " </h3>");
            easyHTMLReports1.AddHorizontalRule();
            easyHTMLReports1.AddLineBreak();

            // Trình bày thông tin tổng quan
            easyHTMLReports1.AddString("<h2 style = \"text-align: center;\">Tổng quan</h2>");
            easyHTMLReports1.AddDatagridView(dataGridViewTongQuan);
            easyHTMLReports1.AddString("<h4 style = \"text-align: right;\">Hiệu số thu - chi: " + MainFrame.ChuanHoa(thunhap_chitieu) + " VND</h4>");
            easyHTMLReports1.AddHorizontalRule();
            easyHTMLReports1.AddLineBreak();

            // Trình bày thông tin thu nhập
            easyHTMLReports1.AddString("<h2 style = \"text-align: center;\">Thu nhập</h2>");
            easyHTMLReports1.AddDatagridView(dataGridViewThuNhap);
            easyHTMLReports1.AddString("<h4 style = \"text-align: right;\">Tổng thu nhập: " + MainFrame.ChuanHoa(tong_thu_nhap) + " VND</h4>");
            easyHTMLReports1.AddHorizontalRule();
            easyHTMLReports1.AddLineBreak();

            // Trình bày thông tin chi tiêu
            easyHTMLReports1.AddString("<h2 style = \"text-align: center;\">Chi tiêu</h2>");
            easyHTMLReports1.AddDatagridView(dataGridViewChiTieu);
            easyHTMLReports1.AddString("<h4 style = \"text-align: right;\">Tổng chi tiêu: " + MainFrame.ChuanHoa(tong_chi_tieu) + " VND</h4>");
            easyHTMLReports1.AddHorizontalRule();
            easyHTMLReports1.AddLineBreak();

            // Trình bày thông tin tiết kiệm
            easyHTMLReports1.AddString("<h2 style = \"text-align: center;\">Tiết kiệm</h2>");
            easyHTMLReports1.AddDatagridView(dataGridViewTietKiem);
            easyHTMLReports1.AddString("<h4 style = \"text-align: right;\">Tổng tiết kiệm: " + MainFrame.ChuanHoa(tong_tiet_kiem) + " VND</h4>");
            easyHTMLReports1.AddHorizontalRule();
            easyHTMLReports1.AddLineBreak();

            // Hiển thị thông tin báo cáo
            easyHTMLReports1.ShowPrintPreviewDialog();
        }
    }
}
