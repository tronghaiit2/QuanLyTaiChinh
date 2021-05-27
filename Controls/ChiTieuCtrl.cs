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
    public partial class ChiTieuCtrl : UserControl
    {
        // Khởi tạo bảng để lưu giá trị từ database
        DataTable data = new DataTable();
        private void Init_Table()
        {
            data.Columns.Add("STT", typeof(int));
            data.Columns.Add("Ngày", typeof(string));
            data.Columns.Add("Người nhận", typeof(string));
            data.Columns.Add("Nơi nhận", typeof(string));
            data.Columns.Add("Mô tả", typeof(string));
            data.Columns.Add("Mục đích", typeof(string));
            data.Columns.Add("Tài khoản", typeof(string));
            data.Columns.Add("Số tiền", typeof(string));
        }

        public ChiTieuCtrl()
        {
            InitializeComponent();
            Init_Table();
            LoadChiTieu();
        }

        // Hiển thị dữ liệu lên màn hình
        private void LoadChiTieu()
        {
            // Làm mới các box lựa chọn
            boxChonTienChiTieu.Text = "Chọn Tiền";
            boxChonThangChiTieu.Text = "Tháng";
            boxChonNgayChiTieu.Text = "Ngày";

            //Lấy dữ liệu loại tài khoẻn thu nhập
            boxChonTienChiTieu.Items.Clear();

            foreach (var chitieu in DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll())
            {
                if (boxChonTienChiTieu.Items.Contains(chitieu.loai_tai_khoan) == false)
                    boxChonTienChiTieu.Items.Add(chitieu.loai_tai_khoan);
            }

            // Lấy dữ liệu bộ sưu tập chi tiêu
            var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu")
                .Include(x => x.tai_khoan).FindAll();

            // Hiển thị tổng tất cả thu nhập
            textBoxTongChiTieu.Text = "Tổng: " + MainFrame.ChuanHoa(chitieuCollection.Sum(r => r.luong_tien)) + " VND";

            // Làm mới dữ liệu hiển thị
            data.Rows.Clear();
            boxChonThangChiTieu.Items.Clear();
            boxChonNgayChiTieu.Items.Clear();

            // Duyệt tất cả dữ liệu từ bộ sưu tập chi tiêu để hiển thị
            int i = 1;
            foreach (var chitieu in chitieuCollection)
            {
                // Cập nhật năm chi tiêu
                if (boxChonNamChiTieu.Items.Contains(chitieu.date.Year.ToString()) == false)
                    boxChonNamChiTieu.Items.Add(chitieu.date.Year.ToString());

                // Cập nhật tháng chi tiêu
                if (boxChonThangChiTieu.Items.Contains(chitieu.date.Month.ToString()) == false)
                    boxChonThangChiTieu.Items.Add(chitieu.date.Month.ToString());

                // Cập nhật ngày chi tiêu
                if (boxChonNgayChiTieu.Items.Contains(chitieu.date.Day.ToString()) == false)
                    boxChonNgayChiTieu.Items.Add(chitieu.date.Day.ToString());

                // Thêm dữ liệu vào bảng theo từng hàng
                data.Rows.Add(new object[]
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

                // Hiển thị dữ liệu lên màn hình
                dataGridViewChiTieu.DataSource = data;
            }
        }

        // Lựa chọn thêm chi tiêu
        private void buttonThemChiTieu_Click(object sender, EventArgs e)
        {
            // Hiển thị khung nhập thêm chi tiêu
            new PopupEffect.transparentBg(this, new QuanLyTaiChinh.Views.ThemChiTieu());

            // Hiển thị lại thu nhập sau khi tạo mới chi tiêu
            LoadChiTieu();
        }

        // Hiển thị lại thông tin chi tiêu đầy đủ
        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            LoadChiTieu();
        }

        // Hiển thị lại dữ liệu từ một tập hợp các chi tiêu "chitieuCollection"
        private void ReloadData(IEnumerable<ChiTieu> chitieuCollection)
        {
            // Làm mới tìm kiếm
            textTimKiemChiTieu.Text = "Tìm kiếm";

            // Tính lại tổng chi tiêu
            textBoxTongChiTieu.Text = "Tổng: " + MainFrame.ChuanHoa(chitieuCollection.Sum(r => r.luong_tien)) + " VND";

            // Làm mới dữ liệu hiển thị
            data.Rows.Clear();

            // Duyệt tất cả dữ liệu từ bộ sưu tập thu nhập để hiển thị
            int i = 1;
            foreach (var chitieu in chitieuCollection)
            {
                // Thêm dữ liệu vào bảng theo từng hàng
                data.Rows.Add(new object[]
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

                // Hiển thị dữ liệu lên màn hình
                dataGridViewChiTieu.DataSource = data;
            }
        }

        // Thay đổi lụa chọn loại tiền thu nhập
        private void boxChonTienChiTieu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy các giá trị trong các box lựa chọn
            string loaitien = boxChonTienChiTieu.Text.Trim();
            string nam = boxChonNamChiTieu.Text.Trim();
            string thang = boxChonThangChiTieu.Text.Trim();
            string ngay = boxChonNgayChiTieu.Text.Trim();

            // Kiểm tra tính hợp lệ của loại tiền được chọn
            List<string> loaitienList = new List<string>();

            for (int i = 0; i < boxChonTienChiTieu.Items.Count; i++)
            {
                loaitienList.Add(boxChonTienChiTieu.Items[i].ToString());
            }

            if (loaitienList.Contains(loaitien))
            {
                // Kiểm tra năm được chọn
                List<string> namList = new List<string>();

                for (int i = 0; i < boxChonNamChiTieu.Items.Count; i++)
                {
                    namList.Add(boxChonNamChiTieu.Items[i].ToString());
                }
                if (namList.Contains(nam))
                {
                    // Kiểm tra tháng được chọn
                    List<string> thangList = new List<string>();

                    for (int i = 0; i < boxChonThangChiTieu.Items.Count; i++)
                    {
                        thangList.Add(boxChonThangChiTieu.Items[i].ToString());
                    }

                    if (thangList.Contains(thang))
                    {
                        // Kiểm tra ngày được chọn
                        List<string> ngayList = new List<string>();

                        for (int i = 0; i < boxChonNgayChiTieu.Items.Count; i++)
                        {
                            ngayList.Add(boxChonNgayChiTieu.Items[i].ToString());
                        }

                        if (ngayList.Contains(ngay))
                        {
                            /*Nếu lựa chọn đầy đủ sẽ hiển thị kết quả 
                             * thông tin theo tài khoản, theo ngày tháng năm
                             */
                            var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu")
                            .Include(x => x.tai_khoan).FindAll()
                            .Where(x => x.date.Year.ToString() == nam
                            && x.tai_khoan.loai_tai_khoan == loaitien
                            && x.date.Month.ToString() == thang && x.date.Day.ToString() == ngay);
                            ReloadData(chitieuCollection);
                        }
                        else
                        {
                            /*Nếu chưa lựa chọn ngày thì hiển thị
                             * thông tin theo tài khoản, theo tháng năm
                             */
                            var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu")
                            .Include(x => x.tai_khoan).FindAll()
                            .Where(x => x.date.Year.ToString() == nam
                            && x.tai_khoan.loai_tai_khoan == loaitien && x.date.Month.ToString() == thang);
                            ReloadData(chitieuCollection);
                        }
                    }
                    else
                    {
                        /*Nếu chưa lựa chọn ngày tháng thì hiển thị
                         * thông tin theo tài khoản, theo năm
                         */
                        var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu")
                                .Include(x => x.tai_khoan).FindAll()
                                .Where(x => x.date.Year.ToString() == nam
                            && x.tai_khoan.loai_tai_khoan == loaitien);
                        ReloadData(chitieuCollection);
                    }
                }
                else
                {
                    /*Nếu chưa lựa chọn ngày tháng năm thì hiển thị
                     * thông tin theo tài khoản
                     */
                    var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu")
                                .Include(x => x.tai_khoan).FindAll()
                                .Where(x => x.tai_khoan.loai_tai_khoan == loaitien);
                    ReloadData(chitieuCollection);
                }
            }
            else
            {
                // Nếu chưa chọn loại tài khoản thì hiển thị thông báo  
                MessageBox.Show("Hãy chọn đúng loại tiền");
                boxChonTienChiTieu.Focus();
            }
        }

        // Hiển thị lại thông tin theo năm
        private void Reload_Nam(IEnumerable<ChiTieu> chitieuCollection)
        {
            // Làm mới tìm kiếm
            textTimKiemChiTieu.Text = "Tìm kiếm";

            // Tính lại tổng giá trị thu nhập
            textBoxTongChiTieu.Text = "Tổng: " + MainFrame.ChuanHoa(chitieuCollection.Sum(r => r.luong_tien)) + " VND";

            // Làm mới dữ liệu hiển thị
            data.Rows.Clear();
            boxChonThangChiTieu.Items.Clear();
            boxChonNgayChiTieu.Items.Clear();

            // Duyệt tất cả dữ liệu từ bộ sưu tập thu nhập để hiển thị
            int i = 1;
            foreach (var chitieu in chitieuCollection)
            {
                // Cập nhật ngày thu thập
                if (boxChonNgayChiTieu.Items.Contains(chitieu.date.Day.ToString()) == false)
                    boxChonNgayChiTieu.Items.Add(chitieu.date.Day.ToString());

                // Cập nhật tháng thu nhập
                if (boxChonThangChiTieu.Items.Contains(chitieu.date.Month.ToString()) == false)
                    boxChonThangChiTieu.Items.Add(chitieu.date.Month.ToString());

                // Thêm dữ liệu vào bảng theo từng hàng
                data.Rows.Add(new object[]
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

                // Hiển thị thông tin ra màn hình
                dataGridViewChiTieu.DataSource = data;
            }
        }

        // Thay đổi lựa chọn năm chi tiêu
        private void boxChonNamChiTieu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy các giá trị trong các box lựa chọn
            string loaitien = boxChonTienChiTieu.Text.Trim();
            string nam = boxChonNamChiTieu.Text.Trim();

            // Làm mới box chọn ngày tháng
            boxChonThangChiTieu.Text = "Tháng";
            boxChonNgayChiTieu.Text = "Ngày";

            // Kiểm tra hợp lệ của năm chi tiêu
            List<string> namList = new List<string>();

            for (int i = 0; i < boxChonNamChiTieu.Items.Count; i++)
            {
                namList.Add(boxChonNamChiTieu.Items[i].ToString());
            }

            if (namList.Contains(nam))
            {
                // Kiểm tra hợp lệ của loại tiền thu nhập
                List<string> loaitienList = new List<string>();

                for (int i = 0; i < boxChonTienChiTieu.Items.Count; i++)
                {
                    loaitienList.Add(boxChonTienChiTieu.Items[i].ToString());
                }

                if (loaitienList.Contains(loaitien))
                {
                    /*Nếu lựa chọn đủ hiển thị
                     * thông tin theo tài khoản, theo năm
                     */
                    var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu")
                    .Include(x => x.tai_khoan).FindAll()
                    .Where(x => x.date.Year.ToString() == nam && x.tai_khoan.loai_tai_khoan == loaitien);
                    Reload_Nam(chitieuCollection);
                }
                else
                {
                    /*Nếu chưa lựa chọn loại tiền thu nhập
                     * thông tin hiển thị theo năm
                     */
                    var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu")
                    .Include(x => x.tai_khoan).FindAll()
                    .Where(x => x.date.Year.ToString() == nam);
                    Reload_Nam(chitieuCollection);
                }
            }
            else
            {
                // Nếu chưa lựa chọn năm thì hiện thông báo
                MessageBox.Show("Hãy chọn đúng năm");
                boxChonNamChiTieu.Focus();
            }
        }

        // Hiển thị lại thông tin theo tháng
        private void Reload_Thang(IEnumerable<ChiTieu> chitieuCollection)
        {
            // Làm mới tìm kiếm
            textTimKiemChiTieu.Text = "Tìm kiếm";

            // Tính lại tổng giá trị chi tiêu
            textBoxTongChiTieu.Text = "Tổng: " + MainFrame.ChuanHoa(chitieuCollection.Sum(r => r.luong_tien)) + " VND";

            // Làm mới dữ liệu hiển thị
            data.Rows.Clear();
            boxChonNgayChiTieu.Items.Clear();

            // Duyệt tất cả dữ liệu từ bộ sưu tập thu nhập để hiển thị
            int i = 1;
            foreach (var chitieu in chitieuCollection)
            {
                // Cập nhật box chọn ngày chi tiêu
                if (boxChonNgayChiTieu.Items.Contains(chitieu.date.Day.ToString()) == false)
                    boxChonNgayChiTieu.Items.Add(chitieu.date.Day.ToString());

                // Thêm dữ liệu vào bảng theo từng hàng
                data.Rows.Add(new object[]
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

                //Hiển thị thông tin ra màn hình
                dataGridViewChiTieu.DataSource = data;
            }
        }

        // Thay đổi lựa chọn tháng chi tiêu
        private void boxChonThangChiTieu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy các giá trị trong các box lựa chọn
            string loaitien = boxChonTienChiTieu.Text.Trim();
            string nam = boxChonNamChiTieu.Text.Trim();
            string thang = boxChonThangChiTieu.Text.Trim();

            // Kiểm tra hợp lệ của năm chi tiêu
            List<string> namList = new List<string>();

            for (int i = 0; i < boxChonNamChiTieu.Items.Count; i++)
            {
                namList.Add(boxChonNamChiTieu.Items[i].ToString());
            }

            if (namList.Contains(nam))
            {
                // Kiểm tra hợp lệ của tháng chi tiêu
                List<string> thangList = new List<string>();
                boxChonNgayChiTieu.Text = "Ngày";

                for (int i = 0; i < boxChonThangChiTieu.Items.Count; i++)
                {
                    thangList.Add(boxChonThangChiTieu.Items[i].ToString());
                }

                if (thangList.Contains(thang))
                {
                    // Kiểm tra hợp lệ của loại tiền chi tiêu
                    List<string> loaitienList = new List<string>();

                    for (int i = 0; i < boxChonTienChiTieu.Items.Count; i++)
                    {
                        loaitienList.Add(boxChonTienChiTieu.Items[i].ToString());
                    }

                    if (loaitienList.Contains(loaitien))
                    {
                        /*Nếu lựa chọn đầy đủ thì hiển thị
                         * thông tin theo tài khoản, theo tháng năm
                         */
                        var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu")
                        .Include(x => x.tai_khoan).FindAll()
                        .Where(x => x.date.Year.ToString() == boxChonNamChiTieu.Text.Trim()
                            && x.date.Month.ToString() == thang && x.tai_khoan.loai_tai_khoan == loaitien);
                        Reload_Thang(chitieuCollection);
                    }
                    else
                    {
                        /*Nếu chưa lựa chọn loại tiền thì hiển thị
                         * thông tin theo tháng năm
                         */
                        var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu")
                        .Include(x => x.tai_khoan).FindAll()
                        .Where(x => x.date.Year.ToString() == boxChonNamChiTieu.Text.Trim()
                            && x.date.Month.ToString() == thang);
                        Reload_Thang(chitieuCollection);
                    }
                }
                else
                {
                    // Nếu chưa chọn đúng tháng thì hiển thị thông báo
                    MessageBox.Show("Hãy chọn đúng tháng");
                    boxChonThangChiTieu.Focus();
                }
            }
            else
            {
                // Nếu chưa chọn đúng năm thì hiển thị thông báo
                MessageBox.Show("Hãy chọn năm trước");
                boxChonNamChiTieu.Focus();
            }
        }

        // Thay đổi lựa chọn ngày chi tiêu
        private void boxChonNgayChiTieu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy các giá trị trong các box lựa chọn
            string loaitien = boxChonTienChiTieu.Text.Trim();
            string nam = boxChonNamChiTieu.Text.Trim();
            string thang = boxChonThangChiTieu.Text.Trim();
            string ngay = boxChonNgayChiTieu.Text.Trim();

            // Kiểm tra hợp lệ của năm chi tiêu
            List<string> namList = new List<string>();

            for (int i = 0; i < boxChonNamChiTieu.Items.Count; i++)
            {
                namList.Add(boxChonNamChiTieu.Items[i].ToString());
            }
            if (namList.Contains(nam))
            {
                // Kiểm tra hợp lệ của tháng chi tiêu
                List<string> thangList = new List<string>();

                for (int i = 0; i < boxChonThangChiTieu.Items.Count; i++)
                {
                    thangList.Add(boxChonThangChiTieu.Items[i].ToString());
                }

                if (thangList.Contains(thang))
                {
                    // Kiểm tra hợp lệ của ngày chi tiêu
                    List<string> ngayList = new List<string>();

                    for (int i = 0; i < boxChonNgayChiTieu.Items.Count; i++)
                    {
                        ngayList.Add(boxChonNgayChiTieu.Items[i].ToString());
                    }

                    if (ngayList.Contains(ngay))
                    {
                        // Kiểm tra hợp lệ của loại tiền chi tiêu
                        List<string> loaitienList = new List<string>();

                        for (int i = 0; i < boxChonTienChiTieu.Items.Count; i++)
                        {
                            loaitienList.Add(boxChonTienChiTieu.Items[i].ToString());
                        }

                        if (loaitienList.Contains(loaitien))
                        {
                            /*Nếu lựa chọn đầy đủ sẽ hiển thị kết quả 
                             * thông tin theo tài khoản, theo ngày tháng năm
                             */
                            var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu")
                            .Include(x => x.tai_khoan).FindAll()
                            .Where(x => x.date.Year.ToString() == boxChonNamChiTieu.Text.Trim()
                            && x.tai_khoan.loai_tai_khoan == loaitien
                            && x.date.Month.ToString() == thang && x.date.Day.ToString() == ngay);
                            ReloadData(chitieuCollection);
                        }
                        else
                        {
                            /*Nếu chưa lựa chọn loại tiền thì hiển thị kết quả 
                             * thông tin theo ngày tháng năm
                             */
                            var chitieuCollection = DBContext.GetIntance().GetCollection<ChiTieu>("chi_tieu")
                            .Include(x => x.tai_khoan).FindAll()
                            .Where(x => x.date.Year.ToString() == boxChonNamChiTieu.Text.Trim()
                            && x.date.Month.ToString() == thang && x.date.Day.ToString() == ngay);
                            ReloadData(chitieuCollection);
                        }
                    }
                    else
                    {
                        // Nếu chưa chọn đúng ngày thì hiển thị thông báo
                        MessageBox.Show("Hãy chọn đúng ngày");
                        boxChonNgayChiTieu.Focus();
                    }
                }
                else
                {
                    // Nếu chưa chọn đúng tháng thì hiển thị thông báo
                    MessageBox.Show("Hãy chọn tháng trước");
                    boxChonThangChiTieu.Focus();
                }
            }
            else
            {
                // Nếu chưa chọn đúng năm thì hiển thị thông báo
                MessageBox.Show("Hãy chọn năm trước");
                boxChonThangChiTieu.Focus();
            }
        }

        // Tìm kiếm dữ liệu chi tiêu theo dạng text
        private void textTimKiemChiTieu_TextChanged_1(object sender, EventArgs e)
        {
            // Text box tìm kiếm theo dữ liệu text
            if (textTimKiemChiTieu.Text.Trim() != "Tìm kiếm")
                data.DefaultView.RowFilter = string.Format("[Người nhận] LIKE '%{0}%' OR " +
                                                           "[Nơi nhận] LIKE '%{0}%' OR " +
                                                           "[Mô tả] LIKE '%{0}%' OR " +
                                                           "[Mục đích] LIKE '%{0}%' OR " +
                                                           "[Tài khoản] LIKE '%{0}%'", textTimKiemChiTieu.Text);

            // Hiển thị lại tống thu nhập sau khi lọc tìm kiếm
            long sum = 0;
            for (int i = 0; i < dataGridViewChiTieu.Rows.Count; ++i)
            {
                sum += long.Parse(dataGridViewChiTieu.Rows[i].Cells[7].Value.ToString().Replace(" ", string.Empty));
            }
            textBoxTongChiTieu.Text = "Tổng: " + MainFrame.ChuanHoa(sum) + " VND";
        }
    }
}
