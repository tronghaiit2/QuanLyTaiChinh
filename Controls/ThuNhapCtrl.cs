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

namespace QuanLyTaiChinh.Controls
{
    public partial class ThuNhapCtrl : UserControl
    {
        // Khởi tạo bảng để lưu giá trị từ database
        DataTable data = new DataTable();
        private void Init_Table()
        {
            data.Columns.Add("STT", typeof(int));
            data.Columns.Add("Ngày", typeof(string));
            data.Columns.Add("Người gửi", typeof(string));
            data.Columns.Add("Nơi gửi", typeof(string));
            data.Columns.Add("Mô tả", typeof(string));
            data.Columns.Add("Phân loại", typeof(string));
            data.Columns.Add("Tài khoản", typeof(string));
            data.Columns.Add("Số tiền", typeof(string));
        }

        public ThuNhapCtrl()
        {
            InitializeComponent();
            Init_Table();
            LoadThuNhap();
        }

        // Hiển thị dữ liệu lên màn hình
        private void LoadThuNhap()
        {
            // Làm mới các box lựa chọn
            boxChonTienThuNhap.Text = "Chọn Tiền";
            boxChonThangThuNhap.Text = "Tháng";
            boxChonNgayThuNhap.Text = "Ngày";

            //Lấy dữ liệu loại tài khoẻn thu nhập
            boxChonTienThuNhap.Items.Clear();

            foreach (var taikhoan in DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll())
            {
                if (boxChonTienThuNhap.Items.Contains(taikhoan.loai_tai_khoan) == false)
                    boxChonTienThuNhap.Items.Add(taikhoan.loai_tai_khoan);
            }

            // Lấy dữ liệu bộ sưu tập thu nhập
            var thunhapCollection = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap")
                .Include(x => x.tai_khoan).FindAll();

            // Hiển thị tổng tất cả thu nhập
            textBoxTongThuNhap.Text = "Tổng: " + MainFrame.ChuanHoa(thunhapCollection.Sum(r => r.luong_tien)) + " VND";

            // Làm mới dữ liệu hiển thị
            data.Rows.Clear();
            boxChonThangThuNhap.Items.Clear();
            boxChonNgayThuNhap.Items.Clear();

            // Duyệt tất cả dữ liệu từ bộ sưu tập thu nhập để hiển thị
            int i = 1;
            foreach (var thunhap in thunhapCollection)
            {
                // Cập nhật năm thu nhập
                if (boxChonNamThuNhap.Items.Contains(thunhap.date.Year.ToString()) == false)
                    boxChonNamThuNhap.Items.Add(thunhap.date.Year.ToString());

                // Cập nhật tháng thu nhập
                if (boxChonThangThuNhap.Items.Contains(thunhap.date.Month.ToString()) == false)
                    boxChonThangThuNhap.Items.Add(thunhap.date.Month.ToString());

                // Cập nhật ngày thu nhập
                if (boxChonNgayThuNhap.Items.Contains(thunhap.date.Day.ToString()) == false)
                    boxChonNgayThuNhap.Items.Add(thunhap.date.Day.ToString());

                // Thêm dữ liệu vào bảng theo từng hàng
                data.Rows.Add(new object[]
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

                // Hiển thị dữ liệu lên màn hình
                dataGridViewThuNhap.DataSource = data;
            }
        }

        // Lựa chọn thêm thu nhập
        private void buttonThemThuNhap_Click(object sender, EventArgs e)
        {
            // Hiển thị khung nhập thêm thu nhập
            new PopupEffect.transparentBg(this, new QuanLyTaiChinh.Views.ThemThuNhap());

            // Hiển thị lại thu nhập sau khi tạo mới thu nhập
            LoadThuNhap();
        }

        // Hiển thị lại thông tin thu nhập đầy đủ
        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            LoadThuNhap();
        }

        // Hiển thị lại dữ liệu từ một tập hợp các thu nhập "temp"
        private void ReloadData(IEnumerable<ThuNhap> thunhapCollection)
        {
            // Làm mới tìm kiếm
            textTimKiemThuNhap.Text = "Tìm kiếm";

            // Làm mới tìm kiếm
            textBoxTongThuNhap.Text = "Tổng: " + MainFrame.ChuanHoa(thunhapCollection.Sum(r => r.luong_tien)) + " VND";

            // Làm mới dữ liệu hiển thị
            data.Rows.Clear();

            // Duyệt tất cả dữ liệu từ bộ sưu tập thu nhập để hiển thị
            int i = 1;
            foreach (var thunhap in thunhapCollection)
            {
                // Thêm dữ liệu vào bảng theo từng hàng
                data.Rows.Add(new object[]
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

                // Hiển thị dữ liệu lên màn hình
                dataGridViewThuNhap.DataSource = data;
            }
        }

        // Thay đổi lụa chọn loại tiền thu nhập
        private void boxChonTienThuNhap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy các giá trị trong các box lựa chọn
            string loaitien = boxChonTienThuNhap.Text.Trim();
            string nam = boxChonNamThuNhap.Text.Trim();
            string thang = boxChonThangThuNhap.Text.Trim();
            string ngay = boxChonNgayThuNhap.Text.Trim();

            // Kiểm tra tính hợp lệ của loại tiền được chọn
            List<string> loaitienList = new List<string>();

            for (int i = 0; i < boxChonTienThuNhap.Items.Count; i++)
            {
                loaitienList.Add(boxChonTienThuNhap.Items[i].ToString());
            }

            if (loaitienList.Contains(loaitien))
            {
                // Kiểm tra năm được chọn
                List<string> namList = new List<string>();

                for (int i = 0; i < boxChonNamThuNhap.Items.Count; i++)
                {
                    namList.Add(boxChonNamThuNhap.Items[i].ToString());
                }
                if (namList.Contains(nam))
                {
                    // Kiểm tra tháng được chọn
                    List<string> thangList = new List<string>();

                    for (int i = 0; i < boxChonThangThuNhap.Items.Count; i++)
                    {
                        thangList.Add(boxChonThangThuNhap.Items[i].ToString());
                    }

                    if (thangList.Contains(thang))
                    {
                        // Kiểm tra ngày được chọn
                        List<string> ngayList = new List<string>();

                        for (int i = 0; i < boxChonNgayThuNhap.Items.Count; i++)
                        {
                            ngayList.Add(boxChonNgayThuNhap.Items[i].ToString());
                        }

                        if (ngayList.Contains(ngay))
                        {
                            /*Nếu lựa chọn đầy đủ sẽ hiển thị kết quả 
                             * thông tin theo tài khoản, theo ngày tháng năm
                             */
                            var thunhap = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap")
                            .Include(x => x.tai_khoan).FindAll()
                            .Where(x => x.date.Year.ToString() == nam
                            && x.tai_khoan.loai_tai_khoan == loaitien
                            && x.date.Month.ToString() == thang && x.date.Day.ToString() == ngay);
                            ReloadData(thunhap);
                        }
                        else
                        {
                            /*Nếu chưa lựa chọn ngày thì hiển thị
                             * thông tin theo tài khoản, theo tháng năm
                             */
                            var thunhap = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap")
                            .Include(x => x.tai_khoan).FindAll()
                            .Where(x => x.date.Year.ToString() == nam
                            && x.tai_khoan.loai_tai_khoan == loaitien && x.date.Month.ToString() == thang);
                            ReloadData(thunhap);
                        }
                    }
                    else
                    {
                        /*Nếu chưa lựa chọn ngày tháng thì hiển thị
                         * thông tin theo tài khoản, theo năm
                         */
                        var thunhap = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap")
                                .Include(x => x.tai_khoan).FindAll()
                                .Where(x => x.date.Year.ToString() == nam
                            && x.tai_khoan.loai_tai_khoan == loaitien);
                        ReloadData(thunhap);
                    }
                }
                else
                {
                    /*Nếu chưa lựa chọn ngày tháng năm thì hiển thị
                     * thông tin theo tài khoản
                     */
                    var thunhap = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap")
                                .Include(x => x.tai_khoan).FindAll()
                                .Where(x => x.tai_khoan.loai_tai_khoan == loaitien);
                    ReloadData(thunhap);
                }
            }
            else
            {
                // Nếu chưa chọn loại tài khoản thì hiển thị thông báo  
                MessageBox.Show("Hãy chọn đúng loại tiền");
                boxChonTienThuNhap.Focus();
            }
        }

        // Hiển thị lại thông tin theo năm
        private void Reload_Nam(IEnumerable<ThuNhap> thunhapCollection)
        {
            // Làm mới tìm kiếm
            textTimKiemThuNhap.Text = "Tìm kiếm";

            // Tính lại tổng giá trị thu nhập
            textBoxTongThuNhap.Text = "Tổng: " + MainFrame.ChuanHoa(thunhapCollection.Sum(r => r.luong_tien)) + " VND";

            // Làm mới dữ liệu hiển thị
            data.Rows.Clear();
            boxChonThangThuNhap.Items.Clear();
            boxChonNgayThuNhap.Items.Clear();

            // Duyệt tất cả dữ liệu từ bộ sưu tập thu nhập để hiển thị
            int i = 1;
            foreach (var thunhap in thunhapCollection)
            {
                // Cập nhật ngày thu thập
                if (boxChonNgayThuNhap.Items.Contains(thunhap.date.Day.ToString()) == false)
                    boxChonNgayThuNhap.Items.Add(thunhap.date.Day.ToString());

                // Cập nhật tháng thu nhập
                if (boxChonThangThuNhap.Items.Contains(thunhap.date.Month.ToString()) == false)
                    boxChonThangThuNhap.Items.Add(thunhap.date.Month.ToString());

                // Thêm dữ liệu vào bảng theo từng hàng
                data.Rows.Add(new object[]
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


                // Hiển thị thông tin ra màn hình
                dataGridViewThuNhap.DataSource = data;
            }
        }

        // Thay đổi lựa chọn năm thu nhập
        private void boxChonNamThuNhap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy các giá trị trong các box lựa chọn
            string loaitien = boxChonTienThuNhap.Text.Trim();
            string nam = boxChonNamThuNhap.Text.Trim();

            // Làm mới box chọn ngày tháng
            boxChonThangThuNhap.Text = "Tháng";
            boxChonNgayThuNhap.Text = "Ngày";

            // Kiểm tra hợp lệ của năm thu nhập
            List<string> namList = new List<string>();

            for (int i = 0; i < boxChonNamThuNhap.Items.Count; i++)
            {
                namList.Add(boxChonNamThuNhap.Items[i].ToString());
            }

            if (namList.Contains(nam))
            {
                // Kiểm tra hợp lệ của loại tiền thu nhập
                List<string> loaitienList = new List<string>();

                for (int i = 0; i < boxChonTienThuNhap.Items.Count; i++)
                {
                    loaitienList.Add(boxChonTienThuNhap.Items[i].ToString());
                }

                if (loaitienList.Contains(loaitien))
                {
                    /*Nếu lựa chọn đủ hiển thị
                     * thông tin theo tài khoản, theo năm
                     */
                    var thunhap = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap")
                    .Include(x => x.tai_khoan).FindAll()
                    .Where(x => x.date.Year.ToString() == nam && x.tai_khoan.loai_tai_khoan == loaitien);
                    Reload_Nam(thunhap);
                }
                else
                {
                    /*Nếu chưa lựa chọn loại tiền thu nhập
                     * thông tin hiển thị theo năm
                     */
                    var thunhap = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap")
                    .Include(x => x.tai_khoan).FindAll()
                    .Where(x => x.date.Year.ToString() == nam);
                    Reload_Nam(thunhap);
                }
            }
            else
            {
                // Nếu chưa lựa chọn năm thì hiện thông báo
                MessageBox.Show("Hãy chọn đúng năm");
                boxChonNamThuNhap.Focus();
            }
        }

        // Hiển thị lại thông tin theo tháng
        private void Reload_Thang(IEnumerable<ThuNhap> thunhapCollection)
        {
            // Làm mới tìm kiếm
            textTimKiemThuNhap.Text = "Tìm kiếm";

            // Tính lại tổng giá trị thu nhập
            textBoxTongThuNhap.Text = "Tổng: " + MainFrame.ChuanHoa(thunhapCollection.Sum(r => r.luong_tien)) + " VND";

            // Làm mới dữ liệu hiển thị
            data.Rows.Clear();
            boxChonNgayThuNhap.Items.Clear();

            // Duyệt tất cả dữ liệu từ bộ sưu tập thu nhập để hiển thị
            int i = 1;
            foreach (var thunhap in thunhapCollection)
            {
                // Cập nhật box chọn ngày thu nhập
                if (boxChonNgayThuNhap.Items.Contains(thunhap.date.Day.ToString()) == false)
                    boxChonNgayThuNhap.Items.Add(thunhap.date.Day.ToString());

                // Thêm dữ liệu vào bảng theo từng hàng
                data.Rows.Add(new object[]
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


                //Hiển thị thông tin ra màn hình
                dataGridViewThuNhap.DataSource = data;
            }
        }

        // Thay đổi lựa chọn tháng thu nhập
        private void boxChonThangThuNhap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy các giá trị trong các box lựa chọn
            string loaitien = boxChonTienThuNhap.Text.Trim();
            string nam = boxChonNamThuNhap.Text.Trim();
            string thang = boxChonThangThuNhap.Text.Trim();

            // Kiểm tra hợp lệ của năm thu nhập
            List<string> namList = new List<string>();

            for (int i = 0; i < boxChonNamThuNhap.Items.Count; i++)
            {
                namList.Add(boxChonNamThuNhap.Items[i].ToString());
            }

            if (namList.Contains(nam))
            {
                // Kiểm tra hợp lệ của tháng thu nhập
                List<string> thangList = new List<string>();
                boxChonNgayThuNhap.Text = "Ngày";

                for (int i = 0; i < boxChonThangThuNhap.Items.Count; i++)
                {
                    thangList.Add(boxChonThangThuNhap.Items[i].ToString());
                }

                if (thangList.Contains(thang))
                {
                    // Kiểm tra hợp lệ của loại tiền thu nhập
                    List<string> loaitienList = new List<string>();

                    for (int i = 0; i < boxChonTienThuNhap.Items.Count; i++)
                    {
                        loaitienList.Add(boxChonTienThuNhap.Items[i].ToString());
                    }

                    if (loaitienList.Contains(loaitien))
                    {
                        /*Nếu lựa chọn đầy đủ thì hiển thị
                         * thông tin theo tài khoản, theo tháng năm
                         */
                        var thunhap = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap")
                        .Include(x => x.tai_khoan).FindAll()
                        .Where(x => x.date.Year.ToString() == boxChonNamThuNhap.Text.Trim()
                            && x.date.Month.ToString() == thang && x.tai_khoan.loai_tai_khoan == loaitien);
                        Reload_Thang(thunhap);
                    }
                    else
                    {
                        /*Nếu chưa lựa chọn loại tiền thì hiển thị
                         * thông tin theo tháng năm
                         */
                        var thunhap = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap")
                        .Include(x => x.tai_khoan).FindAll()
                        .Where(x => x.date.Year.ToString() == boxChonNamThuNhap.Text.Trim()
                            && x.date.Month.ToString() == thang);
                        Reload_Thang(thunhap);
                    }
                }
                else
                {
                    // Nếu chưa chọn đúng tháng thì hiển thị thông báo
                    MessageBox.Show("Hãy chọn đúng tháng");
                    boxChonThangThuNhap.Focus();
                }
            }
            else
            {
                // Nếu chưa chọn đúng năm thì hiển thị thông báo
                MessageBox.Show("Hãy chọn năm trước");
                boxChonNamThuNhap.Focus();
            }
        }

        // Thay đổi lựa chọn ngày thu nhập
        private void boxChonNgayThuNhap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy các giá trị trong các box lựa chọn
            string loaitien = boxChonTienThuNhap.Text.Trim();
            string nam = boxChonNamThuNhap.Text.Trim();
            string thang = boxChonThangThuNhap.Text.Trim();
            string ngay = boxChonNgayThuNhap.Text.Trim();

            // Kiểm tra hợp lệ của năm thu nhập
            List<string> namList = new List<string>();

            for (int i = 0; i < boxChonNamThuNhap.Items.Count; i++)
            {
                namList.Add(boxChonNamThuNhap.Items[i].ToString());
            }
            if (namList.Contains(nam))
            {
                // Kiểm tra hợp lệ của tháng thu nhập
                List<string> thangList = new List<string>();

                for (int i = 0; i < boxChonThangThuNhap.Items.Count; i++)
                {
                    thangList.Add(boxChonThangThuNhap.Items[i].ToString());
                }

                if (thangList.Contains(thang))
                {
                    // Kiểm tra hợp lệ của ngày thu nhập
                    List<string> ngayList = new List<string>();

                    for (int i = 0; i < boxChonNgayThuNhap.Items.Count; i++)
                    {
                        ngayList.Add(boxChonNgayThuNhap.Items[i].ToString());
                    }

                    if (ngayList.Contains(ngay))
                    {
                        // Kiểm tra hợp lệ của loại tiền thu nhập
                        List<string> loaitienList = new List<string>();

                        for (int i = 0; i < boxChonTienThuNhap.Items.Count; i++)
                        {
                            loaitienList.Add(boxChonTienThuNhap.Items[i].ToString());
                        }

                        if (loaitienList.Contains(loaitien))
                        {
                            /*Nếu lựa chọn đầy đủ sẽ hiển thị kết quả 
                             * thông tin theo tài khoản, theo ngày tháng năm
                             */
                            var thunhap = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap")
                            .Include(x => x.tai_khoan).FindAll()
                            .Where(x => x.date.Year.ToString() == boxChonNamThuNhap.Text.Trim()
                            && x.tai_khoan.loai_tai_khoan == loaitien
                            && x.date.Month.ToString() == thang && x.date.Day.ToString() == ngay);
                            ReloadData(thunhap);
                        }
                        else
                        {
                            /*Nếu chưa lựa chọn loại tiền thì hiển thị kết quả 
                             * thông tin theo ngày tháng năm
                             */
                            var thunhap = DBContext.GetIntance().GetCollection<ThuNhap>("thu_nhap")
                            .Include(x => x.tai_khoan).FindAll()
                            .Where(x => x.date.Year.ToString() == boxChonNamThuNhap.Text.Trim()
                            && x.date.Month.ToString() == thang && x.date.Day.ToString() == ngay);
                            ReloadData(thunhap);
                        }
                    }
                    else
                    {
                        // Nếu chưa chọn đúng ngày thì hiển thị thông báo
                        MessageBox.Show("Hãy chọn đúng ngày");
                        boxChonNgayThuNhap.Focus();
                    }
                }
                else
                {
                    // Nếu chưa chọn đúng tháng thì hiển thị thông báo
                    MessageBox.Show("Hãy chọn tháng trước");
                    boxChonThangThuNhap.Focus();
                }
            }
            else
            {
                // Nếu chưa chọn đúng năm thì hiển thị thông báo
                MessageBox.Show("Hãy chọn năm trước");
                boxChonThangThuNhap.Focus();
            }
        }

        // Tìm kiếm dữ liệu thu nhập theo dạng text
        private void textTimKiemThuNhap_TextChanged_1(object sender, EventArgs e)
        {
            // Text box tìm kiếm theo dữ liệu text
            if (textTimKiemThuNhap.Text.Trim() != "Tìm kiếm")
                data.DefaultView.RowFilter = string.Format("[Người gửi] LIKE '%{0}%' OR " +
                                                           "[Nơi gửi] LIKE '%{0}%' OR " +
                                                           "[Mô tả] LIKE '%{0}%' OR " +
                                                           "[Phân loại] LIKE '%{0}%' OR " +
                                                           "[Tài khoản] LIKE '%{0}%'", textTimKiemThuNhap.Text);

            // Hiển thị lại tống thu nhập sau khi lọc tìm kiếm
            long sum = 0;
            for (int i = 0; i < dataGridViewThuNhap.Rows.Count; ++i)
            {
                sum += long.Parse(dataGridViewThuNhap.Rows[i].Cells[7].Value.ToString().Replace(" ", string.Empty));
            }
            textBoxTongThuNhap.Text = "Tổng: " + MainFrame.ChuanHoa(sum) + " VND";
        }
    }
}
