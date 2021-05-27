using QuanLyTaiChinh.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyTaiChinh.Controls
{
    public partial class TietKiemCtrl : UserControl
    {
        // Khởi tạo bảng để lưu giá trị từ database
        DataTable data = new DataTable();
        private void Init_Table()
        {
            data.Columns.Add("STT", typeof(int));
            data.Columns.Add("Ngày", typeof(string));
            data.Columns.Add("Phân loại", typeof(string));
            data.Columns.Add("Tài khoản", typeof(string));
            data.Columns.Add("Mô tả", typeof(string));
            data.Columns.Add("Số tiền", typeof(string));
        }
        public TietKiemCtrl()
        {
            InitializeComponent();
            Init_Table();
            LoadTietKiem();
        }

        // Hiển thị dữ liệu lên màn hình
        private void LoadTietKiem()
        {
            // Làm mới các box lựa chọn
            boxChonTienTietKiem.Text = "Chọn Tiền";
            boxChonThangTietKiem.Text = "Tháng";
            boxChonNgayTietKiem.Text = "Ngày";

            //Lấy dữ liệu loại tài khoẻn tiết kiệm
            boxChonTienTietKiem.Items.Clear();

            foreach (var tietkiem in DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll())
            {
                if (boxChonTienTietKiem.Items.Contains(tietkiem.loai_tai_khoan) == false)
                    boxChonTienTietKiem.Items.Add(tietkiem.loai_tai_khoan);
            }

            // Lấy dữ liệu bộ sưu tập tiết kiệm
            var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem")
                .Include(x => x.tai_khoan).FindAll();

            // Hiển thị tổng tất cả tiết kiệm
            textBoxTongTietKiem.Text = "Tổng: " + MainFrame.ChuanHoa(tietkiemCollection.Sum(r => r.luong_tien)) + " VND";

            // Làm mới dữ liệu hiển thị
            data.Rows.Clear();
            boxChonThangTietKiem.Items.Clear();
            boxChonNgayTietKiem.Items.Clear();

            // Duyệt tất cả dữ liệu từ bộ sưu tập tiết kiệm để hiển thị
            int i = 1;
            foreach (var tietkiem in tietkiemCollection)
            {
                // Cập nhật năm tiết kiệm
                if (boxChonNamTietKiem.Items.Contains(tietkiem.date.Year.ToString()) == false)
                    boxChonNamTietKiem.Items.Add(tietkiem.date.Year.ToString());

                // Cập nhật tháng tiết kiệm
                if (boxChonThangTietKiem.Items.Contains(tietkiem.date.Month.ToString()) == false)
                    boxChonThangTietKiem.Items.Add(tietkiem.date.Month.ToString());

                // Cập nhật ngày tiết kiệm
                if (boxChonNgayTietKiem.Items.Contains(tietkiem.date.Day.ToString()) == false)
                    boxChonNgayTietKiem.Items.Add(tietkiem.date.Day.ToString());

                // Thêm dữ liệu vào bảng theo từng hàng
                data.Rows.Add(new object[]
                {
                    i++,
                    tietkiem.date.Day.ToString() + "/" + tietkiem.date.Month.ToString() + "/" + tietkiem.date.Year.ToString(),
                    tietkiem.tai_khoan.loai_tai_khoan.ToString(),
                    tietkiem.tai_khoan.ten_tai_khoan.ToString(),
                    tietkiem.mo_ta.ToString(),
                    MainFrame.ChuanHoa(tietkiem.luong_tien)
                });

                // Hiển thị dữ liệu lên màn hình
                dataGridViewTietKiem.DataSource = data;
            }
        }

        // Lựa chọn thêm tiết kiệm
        private void buttonThemTietKiem_Click(object sender, EventArgs e)
        {
            // Hiển thị khung nhập thêm tiết kiệm
            new PopupEffect.transparentBg(this, new QuanLyTaiChinh.Views.ThemTietKiem());

            // Hiển thị lại tiết kiệm sau khi tạo mới tiết kiệm
            LoadTietKiem();
        }

        // Hiển thị lại thông tin tiết kiệm đầy đủ
        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            LoadTietKiem();
        }

        // Hiển thị lại dữ liệu từ một tập hợp các tiết kiệm "tietkiemCollection"
        private void ReloadData(IEnumerable<TietKiem> tietkiemCollection)
        {
            // Làm mới tìm kiếm
            textTimKiemTietKiem.Text = "Tìm kiếm";

            // Làm mới tìm kiếm
            textBoxTongTietKiem.Text = "Tổng: " + MainFrame.ChuanHoa(tietkiemCollection.Sum(r => r.luong_tien)) + " VND";

            // Làm mới dữ liệu hiển thị
            data.Rows.Clear();

            // Duyệt tất cả dữ liệu từ bộ sưu tập tiết kiệm để hiển thị
            int i = 1;
            foreach (var tietkiem in tietkiemCollection)
            {
                // Thêm dữ liệu vào bảng theo từng hàng
                data.Rows.Add(new object[]
                {
                    i++,
                    tietkiem.date.Day.ToString() + "/" + tietkiem.date.Month.ToString() + "/" + tietkiem.date.Year.ToString(),
                    tietkiem.tai_khoan.loai_tai_khoan.ToString(),
                    tietkiem.tai_khoan.ten_tai_khoan.ToString(),
                    tietkiem.mo_ta.ToString(),
                    MainFrame.ChuanHoa(tietkiem.luong_tien)
                });

                // Hiển thị dữ liệu lên màn hình
                dataGridViewTietKiem.DataSource = data;
            }
        }

        // Thay đổi lụa chọn loại tiền tiết kiệm
        private void boxChonTienTietKiem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy các giá trị trong các box lựa chọn
            string loaitien = boxChonTienTietKiem.Text.Trim();
            string nam = boxChonNamTietKiem.Text.Trim();
            string thang = boxChonThangTietKiem.Text.Trim();
            string ngay = boxChonNgayTietKiem.Text.Trim();

            // Kiểm tra tính hợp lệ của loại tiền được chọn
            List<string> loaitienList = new List<string>();

            for (int i = 0; i < boxChonTienTietKiem.Items.Count; i++)
            {
                loaitienList.Add(boxChonTienTietKiem.Items[i].ToString());
            }

            if (loaitienList.Contains(loaitien))
            {
                // Kiểm tra năm được chọn
                List<string> namList = new List<string>();

                for (int i = 0; i < boxChonNamTietKiem.Items.Count; i++)
                {
                    namList.Add(boxChonNamTietKiem.Items[i].ToString());
                }
                if (namList.Contains(nam))
                {
                    // Kiểm tra tháng được chọn
                    List<string> thangList = new List<string>();

                    for (int i = 0; i < boxChonThangTietKiem.Items.Count; i++)
                    {
                        thangList.Add(boxChonThangTietKiem.Items[i].ToString());
                    }

                    if (thangList.Contains(thang))
                    {
                        // Kiểm tra ngày được chọn
                        List<string> ngayList = new List<string>();

                        for (int i = 0; i < boxChonNgayTietKiem.Items.Count; i++)
                        {
                            ngayList.Add(boxChonNgayTietKiem.Items[i].ToString());
                        }

                        if (ngayList.Contains(ngay))
                        {
                            /*Nếu lựa chọn đầy đủ sẽ hiển thị kết quả 
                             * thông tin theo tài khoản, theo ngày tháng năm
                             */
                            var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem")
                            .Include(x => x.tai_khoan).FindAll()
                            .Where(x => x.date.Year.ToString() == nam
                            && x.tai_khoan.loai_tai_khoan == loaitien
                            && x.date.Month.ToString() == thang && x.date.Day.ToString() == ngay);
                            ReloadData(tietkiemCollection);
                        }
                        else
                        {
                            /*Nếu chưa lựa chọn ngày thì hiển thị
                             * thông tin theo tài khoản, theo tháng năm
                             */
                            var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem")
                            .Include(x => x.tai_khoan).FindAll()
                            .Where(x => x.date.Year.ToString() == nam
                            && x.tai_khoan.loai_tai_khoan == loaitien && x.date.Month.ToString() == thang);
                            ReloadData(tietkiemCollection);
                        }
                    }
                    else
                    {
                        /*Nếu chưa lựa chọn ngày tháng thì hiển thị
                         * thông tin theo tài khoản, theo năm
                         */
                        var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem")
                                .Include(x => x.tai_khoan).FindAll()
                                .Where(x => x.date.Year.ToString() == nam
                            && x.tai_khoan.loai_tai_khoan == loaitien);
                        ReloadData(tietkiemCollection);
                    }
                }
                else
                {
                    /*Nếu chưa lựa chọn ngày tháng năm thì hiển thị
                     * thông tin theo tài khoản
                     */
                    var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem")
                                .Include(x => x.tai_khoan).FindAll()
                                .Where(x => x.tai_khoan.loai_tai_khoan == loaitien);
                    ReloadData(tietkiemCollection);
                }
            }
            else
            {
                // Nếu chưa chọn loại tài khoản thì hiển thị thông báo  
                MessageBox.Show("Hãy chọn đúng loại tiền");
                boxChonTienTietKiem.Focus();
            }
        }

        // Hiển thị lại thông tin theo năm
        private void Reload_Nam(IEnumerable<TietKiem> tietkiemCollection)
        {
            // Làm mới tìm kiếm
            textTimKiemTietKiem.Text = "Tìm kiếm";

            // Tính lại tổng giá trị tiết kiệm
            textBoxTongTietKiem.Text = "Tổng: " + MainFrame.ChuanHoa(tietkiemCollection.Sum(r => r.luong_tien)) + " VND";

            // Làm mới dữ liệu hiển thị
            data.Rows.Clear();
            boxChonThangTietKiem.Items.Clear();
            boxChonNgayTietKiem.Items.Clear();

            // Duyệt tất cả dữ liệu từ bộ sưu tập tiết kiệm để hiển thị
            int i = 1;
            foreach (var tietkiem in tietkiemCollection)
            {
                // Cập nhật ngày thu thập
                if (boxChonNgayTietKiem.Items.Contains(tietkiem.date.Day.ToString()) == false)
                    boxChonNgayTietKiem.Items.Add(tietkiem.date.Day.ToString());

                // Cập nhật tháng tiết kiệm
                if (boxChonThangTietKiem.Items.Contains(tietkiem.date.Month.ToString()) == false)
                    boxChonThangTietKiem.Items.Add(tietkiem.date.Month.ToString());

                // Thêm dữ liệu vào bảng theo từng hàng
                data.Rows.Add(new object[]
                {
                    i++,
                    tietkiem.date.Day.ToString() + "/" + tietkiem.date.Month.ToString() + "/" + tietkiem.date.Year.ToString(),
                    tietkiem.tai_khoan.loai_tai_khoan.ToString(),
                    tietkiem.tai_khoan.ten_tai_khoan.ToString(),
                    tietkiem.mo_ta.ToString(),
                    MainFrame.ChuanHoa(tietkiem.luong_tien)
                });

                // Hiển thị thông tin ra màn hình
                dataGridViewTietKiem.DataSource = data;
            }
        }

        // Thay đổi lựa chọn năm tiết kiệm
        private void boxChonNamTietKiem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy các giá trị trong các box lựa chọn
            string loaitien = boxChonTienTietKiem.Text.Trim();
            string nam = boxChonNamTietKiem.Text.Trim();

            // Làm mới box chọn ngày tháng
            boxChonThangTietKiem.Text = "Tháng";
            boxChonNgayTietKiem.Text = "Ngày";

            // Kiểm tra hợp lệ của năm tiết kiệm
            List<string> namList = new List<string>();

            for (int i = 0; i < boxChonNamTietKiem.Items.Count; i++)
            {
                namList.Add(boxChonNamTietKiem.Items[i].ToString());
            }

            if (namList.Contains(nam))
            {
                // Kiểm tra hợp lệ của loại tiền tiết kiệm
                List<string> loaitienList = new List<string>();

                for (int i = 0; i < boxChonTienTietKiem.Items.Count; i++)
                {
                    loaitienList.Add(boxChonTienTietKiem.Items[i].ToString());
                }

                if (loaitienList.Contains(loaitien))
                {
                    /*Nếu lựa chọn đủ hiển thị
                     * thông tin theo tài khoản, theo năm
                     */
                    var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem")
                    .Include(x => x.tai_khoan).FindAll()
                    .Where(x => x.date.Year.ToString() == nam && x.tai_khoan.loai_tai_khoan == loaitien);
                    Reload_Nam(tietkiemCollection);
                }
                else
                {
                    /*Nếu chưa lựa chọn loại tiền tiết kiệm
                     * thông tin hiển thị theo năm
                     */
                    var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem")
                    .Include(x => x.tai_khoan).FindAll()
                    .Where(x => x.date.Year.ToString() == nam);
                    Reload_Nam(tietkiemCollection);
                }
            }
            else
            {
                // Nếu chưa lựa chọn năm thì hiện thông báo
                MessageBox.Show("Hãy chọn đúng năm");
                boxChonNamTietKiem.Focus();
            }
        }

        // Hiển thị lại thông tin theo tháng
        private void Reload_Thang(IEnumerable<TietKiem> tietkiemCollection)
        {
            // Làm mới tìm kiếm
            textTimKiemTietKiem.Text = "Tìm kiếm";

            // Tính lại tổng giá trị tiết kiệm
            textBoxTongTietKiem.Text = "Tổng: " + MainFrame.ChuanHoa(tietkiemCollection.Sum(r => r.luong_tien)) + " VND";

            // Làm mới dữ liệu hiển thị
            data.Rows.Clear();
            boxChonNgayTietKiem.Items.Clear();

            // Duyệt tất cả dữ liệu từ bộ sưu tập tiết kiệm để hiển thị
            int i = 1;
            foreach (var tietkiem in tietkiemCollection)
            {
                // Cập nhật box chọn ngày tiết kiệm
                if (boxChonNgayTietKiem.Items.Contains(tietkiem.date.Day.ToString()) == false)
                    boxChonNgayTietKiem.Items.Add(tietkiem.date.Day.ToString());

                // Thêm dữ liệu vào bảng theo từng hàng
                data.Rows.Add(new object[]
                {
                    i++,
                    tietkiem.date.Day.ToString() + "/" + tietkiem.date.Month.ToString() + "/" + tietkiem.date.Year.ToString(),
                    tietkiem.tai_khoan.loai_tai_khoan.ToString(),
                    tietkiem.tai_khoan.ten_tai_khoan.ToString(),
                    tietkiem.mo_ta.ToString(),
                    MainFrame.ChuanHoa(tietkiem.luong_tien)
                });

                //Hiển thị thông tin ra màn hình
                dataGridViewTietKiem.DataSource = data;
            }
        }

        // Thay đổi lựa chọn tháng tiết kiệm
        private void boxChonThangTietKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy các giá trị trong các box lựa chọn
            string loaitien = boxChonTienTietKiem.Text.Trim();
            string nam = boxChonNamTietKiem.Text.Trim();
            string thang = boxChonThangTietKiem.Text.Trim();

            // Kiểm tra hợp lệ của năm tiết kiệm
            List<string> namList = new List<string>();

            for (int i = 0; i < boxChonNamTietKiem.Items.Count; i++)
            {
                namList.Add(boxChonNamTietKiem.Items[i].ToString());
            }

            if (namList.Contains(nam))
            {
                // Kiểm tra hợp lệ của tháng tiết kiệm
                List<string> thangList = new List<string>();
                boxChonNgayTietKiem.Text = "Ngày";

                for (int i = 0; i < boxChonThangTietKiem.Items.Count; i++)
                {
                    thangList.Add(boxChonThangTietKiem.Items[i].ToString());
                }

                if (thangList.Contains(thang))
                {
                    // Kiểm tra hợp lệ của loại tiền tiết kiệm
                    List<string> loaitienList = new List<string>();

                    for (int i = 0; i < boxChonTienTietKiem.Items.Count; i++)
                    {
                        loaitienList.Add(boxChonTienTietKiem.Items[i].ToString());
                    }

                    if (loaitienList.Contains(loaitien))
                    {
                        /*Nếu lựa chọn đầy đủ thì hiển thị
                         * thông tin theo tài khoản, theo tháng năm
                         */
                        var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem")
                        .Include(x => x.tai_khoan).FindAll()
                        .Where(x => x.date.Year.ToString() == boxChonNamTietKiem.Text.Trim()
                            && x.date.Month.ToString() == thang && x.tai_khoan.loai_tai_khoan == loaitien);
                        Reload_Thang(tietkiemCollection);
                    }
                    else
                    {
                        /*Nếu chưa lựa chọn loại tiền thì hiển thị
                         * thông tin theo tháng năm
                         */
                        var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem")
                        .Include(x => x.tai_khoan).FindAll()
                        .Where(x => x.date.Year.ToString() == boxChonNamTietKiem.Text.Trim()
                            && x.date.Month.ToString() == thang);
                        Reload_Thang(tietkiemCollection);
                    }
                }
                else
                {
                    // Nếu chưa chọn đúng tháng thì hiển thị thông báo
                    MessageBox.Show("Hãy chọn đúng tháng");
                    boxChonThangTietKiem.Focus();
                }
            }
            else
            {
                // Nếu chưa chọn đúng năm thì hiển thị thông báo
                MessageBox.Show("Hãy chọn năm trước");
                boxChonNamTietKiem.Focus();
            }
        }

        // Thay đổi lựa chọn ngày tiết kiệm
        private void boxChonNgayTietKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy các giá trị trong các box lựa chọn
            string loaitien = boxChonTienTietKiem.Text.Trim();
            string nam = boxChonNamTietKiem.Text.Trim();
            string thang = boxChonThangTietKiem.Text.Trim();
            string ngay = boxChonNgayTietKiem.Text.Trim();

            // Kiểm tra hợp lệ của năm tiết kiệm
            List<string> namList = new List<string>();

            for (int i = 0; i < boxChonNamTietKiem.Items.Count; i++)
            {
                namList.Add(boxChonNamTietKiem.Items[i].ToString());
            }
            if (namList.Contains(nam))
            {
                // Kiểm tra hợp lệ của tháng tiết kiệm
                List<string> thangList = new List<string>();

                for (int i = 0; i < boxChonThangTietKiem.Items.Count; i++)
                {
                    thangList.Add(boxChonThangTietKiem.Items[i].ToString());
                }

                if (thangList.Contains(thang))
                {
                    // Kiểm tra hợp lệ của ngày tiết kiệm
                    List<string> ngayList = new List<string>();

                    for (int i = 0; i < boxChonNgayTietKiem.Items.Count; i++)
                    {
                        ngayList.Add(boxChonNgayTietKiem.Items[i].ToString());
                    }

                    if (ngayList.Contains(ngay))
                    {
                        // Kiểm tra hợp lệ của loại tiền tiết kiệm
                        List<string> loaitienList = new List<string>();

                        for (int i = 0; i < boxChonTienTietKiem.Items.Count; i++)
                        {
                            loaitienList.Add(boxChonTienTietKiem.Items[i].ToString());
                        }

                        if (loaitienList.Contains(loaitien))
                        {
                            /*Nếu lựa chọn đầy đủ sẽ hiển thị kết quả 
                             * thông tin theo tài khoản, theo ngày tháng năm
                             */
                            var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem")
                            .Include(x => x.tai_khoan).FindAll()
                            .Where(x => x.date.Year.ToString() == boxChonNamTietKiem.Text.Trim()
                            && x.tai_khoan.loai_tai_khoan == loaitien
                            && x.date.Month.ToString() == thang && x.date.Day.ToString() == ngay);
                            ReloadData(tietkiemCollection);
                        }
                        else
                        {
                            /*Nếu chưa lựa chọn loại tiền thì hiển thị kết quả 
                             * thông tin theo ngày tháng năm
                             */
                            var tietkiemCollection = DBContext.GetIntance().GetCollection<TietKiem>("tiet_kiem")
                            .Include(x => x.tai_khoan).FindAll()
                            .Where(x => x.date.Year.ToString() == boxChonNamTietKiem.Text.Trim()
                            && x.date.Month.ToString() == thang && x.date.Day.ToString() == ngay);
                            ReloadData(tietkiemCollection);
                        }
                    }
                    else
                    {
                        // Nếu chưa chọn đúng ngày thì hiển thị thông báo
                        MessageBox.Show("Hãy chọn đúng ngày");
                        boxChonNgayTietKiem.Focus();
                    }
                }
                else
                {
                    // Nếu chưa chọn đúng tháng thì hiển thị thông báo
                    MessageBox.Show("Hãy chọn tháng trước");
                    boxChonThangTietKiem.Focus();
                }
            }
            else
            {
                // Nếu chưa chọn đúng năm thì hiển thị thông báo
                MessageBox.Show("Hãy chọn năm trước");
                boxChonThangTietKiem.Focus();
            }
        }

        // Tìm kiếm dữ liệu tiết kiệm theo dạng text
        private void textTimKiemTietKiem_TextChanged_1(object sender, EventArgs e)
        {
            // Text box tìm kiếm theo dữ liệu text
            if (textTimKiemTietKiem.Text.Trim() != "Tìm kiếm")
                data.DefaultView.RowFilter = string.Format("[Phân loại] LIKE '%{0}%' OR " +
                                                           "[Tài khoản] LIKE '%{0}%' OR " +
                                                           "[Mô tả] LIKE '%{0}%'", textTimKiemTietKiem.Text);

            // Hiển thị lại tống tiết kiệm sau khi lọc tìm kiếm
            long sum = 0;
            for (int i = 0; i < dataGridViewTietKiem.Rows.Count; ++i)
            {
                sum += long.Parse(dataGridViewTietKiem.Rows[i].Cells[5].Value.ToString().Replace(" ", string.Empty));
            }
            textBoxTongTietKiem.Text = "Tổng: " + MainFrame.ChuanHoa(sum) + " VND";
        }

    }
}
