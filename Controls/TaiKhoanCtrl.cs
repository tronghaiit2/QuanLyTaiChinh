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
    public partial class TaiKhoanCtrl : UserControl
    {
        public TaiKhoanCtrl()
        {
            InitializeComponent();

            LoadTaiKhoan();
        }

        private void LoadTaiKhoan()
        {
            boxChuTaiKhoan.Items.Clear();
            boxChonTien.Items.Clear();
            boxChonTaiKhoan.Items.Clear();
            foreach (var taikhoan in DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll())
            {
                if (boxChuTaiKhoan.Items.Contains(taikhoan.chu_tai_khoan) == false)
                    boxChuTaiKhoan.Items.Add(taikhoan.chu_tai_khoan);
                if (boxChonTien.Items.Contains(taikhoan.loai_tai_khoan) == false)
                    boxChonTien.Items.Add(taikhoan.loai_tai_khoan);
                if (boxChonTaiKhoan.Items.Contains(taikhoan.ten_tai_khoan) == false)
                    boxChonTaiKhoan.Items.Add(taikhoan.ten_tai_khoan);
            }
        }

        private void buttonThemTaiKhoan_Click(object sender, EventArgs e)
        {
            new PopupEffect.transparentBg(this, new QuanLyTaiChinh.Views.ThemTaiKhoan());

            LoadTaiKhoan();
        }

        private void chart_theo_ngay(IEnumerable<TaiSan> taikhoanCollection)
        {
            long thunhap = 0;
            long chitieu = 0;
            long tietkiem = 0;

            chart1.Series["ThuNhap"].Points.Clear();
            chart1.Series["ChiTieu"].Points.Clear();
            chart1.Series["TietKiem"].Points.Clear();
            chart1.Series["TaiSan"].Points.Clear();

            foreach (var taikhoan in taikhoanCollection)
            {
                thunhap += taikhoan.thu_nhap;
                chitieu += taikhoan.chi_tieu;
                tietkiem += taikhoan.tiet_kiem;

                chart1.Series["ThuNhap"].Points.AddXY(taikhoan.date.Day + "/" + taikhoan.date.Month + "/" + taikhoan.date.Year, taikhoan.thu_nhap/1000);
                chart1.Series["ChiTieu"].Points.AddXY(taikhoan.date.Day + "/" + taikhoan.date.Month + "/" + taikhoan.date.Year, taikhoan.chi_tieu/1000);
                chart1.Series["TietKiem"].Points.AddXY(taikhoan.date.Day + "/" + taikhoan.date.Month + "/" + taikhoan.date.Year, taikhoan.tiet_kiem/1000);
                chart1.Series["TaiSan"].Points.AddXY(taikhoan.date.Day + "/" + taikhoan.date.Month + "/" + taikhoan.date.Year, (taikhoan.thu_nhap - taikhoan.chi_tieu)/1000);
            }
            textBoxThuNhap.Text = MainFrame.ChuanHoa(thunhap) + " VND";
            textBoxChiTieu.Text = MainFrame.ChuanHoa(chitieu) + " VND";
            textBoxTietKiem.Text = MainFrame.ChuanHoa(tietkiem) + " VND";
            textBoxThuChi.Text = MainFrame.ChuanHoa(thunhap - chitieu) + " VND";
        }

        private void chart_theo_thang(IEnumerable<TaiSan> taikhoanCollection)
        {
            long thunhap = 0;
            long chitieu = 0;
            long tietkiem = 0;

            chart1.Series["ThuNhap"].Points.Clear();
            chart1.Series["ChiTieu"].Points.Clear();
            chart1.Series["TietKiem"].Points.Clear();
            chart1.Series["TaiSan"].Points.Clear();
            List<TaiSan> listTaiSan = new List<TaiSan>();
            foreach (var taikhoan in taikhoanCollection)
            {
                int flag = 0;
                foreach (var taikhoan2 in listTaiSan)
                {

                    if (taikhoan2.date.Month == taikhoan.date.Month)
                    {
                        taikhoan2.thu_nhap += taikhoan.thu_nhap;
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0) listTaiSan.Add(taikhoan);
            }

            foreach (var taikhoan in listTaiSan)
            {
                thunhap += taikhoan.thu_nhap;
                chitieu += taikhoan.chi_tieu;
                tietkiem += taikhoan.tiet_kiem;

                chart1.Series["ThuNhap"].Points.AddXY("T" + taikhoan.date.Month + "/"+ taikhoan.date.Year, taikhoan.thu_nhap/1000);
                chart1.Series["ChiTieu"].Points.AddXY("T" + taikhoan.date.Month + "/" + taikhoan.date.Year, taikhoan.chi_tieu/1000);
                chart1.Series["TietKiem"].Points.AddXY("T" + taikhoan.date.Month + "/" + taikhoan.date.Year, taikhoan.tiet_kiem/1000);
                chart1.Series["TaiSan"].Points.AddXY("T" + taikhoan.date.Month + "/" + taikhoan.date.Year, (taikhoan.thu_nhap - taikhoan.chi_tieu)/1000);
            }

            textBoxThuNhap.Text = MainFrame.ChuanHoa(thunhap) + " VND";
            textBoxChiTieu.Text = MainFrame.ChuanHoa(chitieu) + " VND";
            textBoxTietKiem.Text = MainFrame.ChuanHoa(tietkiem) + " VND";
            textBoxThuChi.Text = MainFrame.ChuanHoa(thunhap - chitieu) + " VND";
        }

        private void selectPhanTich_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;
            string taikhoan = boxChonTaiKhoan.Text.Trim();
            string phanloai = selectPhanTich.Text.Trim();

            List<string> taikhoanList = new List<string>();
            for (int i = 0; i < boxChonTaiKhoan.Items.Count; i++)
            {
                taikhoanList.Add(boxChonTaiKhoan.Items[i].ToString());
            }

            if (taikhoanList.Contains(taikhoan))
            {
                List<string> phanloaiList = new List<string>();
                for (int i = 0; i < selectPhanTich.Items.Count; i++)
                {
                    phanloaiList.Add(selectPhanTich.Items[i].ToString());
                }

                if (phanloaiList.Contains(phanloai))
                {
                    var taikhoanCollection = DBContext.GetIntance().GetCollection<TaiSan>("tai_san").FindAll()
                               .Where(x => x.tai_khoan == taikhoan
                                      && x.date >= date1 && x.date <= date2)
                               .OrderBy(x => x.date).ToList();

                    textBoxSoDu.Text = MainFrame.ChuanHoa(DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll()
                               .First(x => x.ten_tai_khoan == taikhoan).so_du) + " VND";


                    if (phanloai == "Phân tích theo tháng") chart_theo_thang(taikhoanCollection);
                    else if (phanloai == "Phân tích theo ngày") chart_theo_ngay(taikhoanCollection);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn tài khoản");
                boxChonTaiKhoan.Focus();
            }
        }

        private void boxChuTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxThuNhap.Text = "0 VND";
            textBoxChiTieu.Text = "0 VND";
            textBoxSoDu.Text = "0 VND";
            textBoxTietKiem.Text = "0 VND";
            string chutaikhoan = boxChuTaiKhoan.Text.Trim();

            List<string> chutaikhoanList = new List<string>();
            for (int i = 0; i < boxChuTaiKhoan.Items.Count; i++)
            {
                chutaikhoanList.Add(boxChuTaiKhoan.Items[i].ToString());
            }

            if (chutaikhoanList.Contains(chutaikhoan))
            {
                boxChonTien.Items.Clear();
                boxChonTaiKhoan.Items.Clear();
                boxChonTien.Text = "Chọn loại tiền";
                boxChonTaiKhoan.Text = "Chọn tài khoản";
                foreach (var taikhoan in DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan")
                                     .FindAll().Where(x => x.chu_tai_khoan == chutaikhoan))
                {
                    if (boxChonTien.Items.Contains(taikhoan.loai_tai_khoan) == false)
                        boxChonTien.Items.Add(taikhoan.loai_tai_khoan);
                    if (boxChonTaiKhoan.Items.Contains(taikhoan.ten_tai_khoan) == false)
                        boxChonTaiKhoan.Items.Add(taikhoan.ten_tai_khoan);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn đúng chủ tài khoản");
                boxChuTaiKhoan.Focus();
            }
        }

        private void boxChonTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxThuNhap.Text = "0 VND";
            textBoxChiTieu.Text = "0 VND";
            textBoxSoDu.Text = "0 VND";
            textBoxTietKiem.Text = "0 VND";
            string chutaikhoan = boxChuTaiKhoan.Text.Trim();

            List<string> chutaikhoanList = new List<string>();
            for (int i = 0; i < boxChuTaiKhoan.Items.Count; i++)
            {
                chutaikhoanList.Add(boxChuTaiKhoan.Items[i].ToString());
            }

            if (chutaikhoanList.Contains(chutaikhoan))
            {
                string loaitien = boxChonTien.Text.Trim();
                List<string> loaitienList = new List<string>();

                for (int i = 0; i < boxChonTien.Items.Count; i++)
                {
                    loaitienList.Add(boxChonTien.Items[i].ToString());
                }

                if (loaitienList.Contains(loaitien))
                {
                    boxChonTaiKhoan.Items.Clear();
                    boxChonTaiKhoan.Text = "Chọn tài khoản";
                    foreach (var taikhoan in DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan")
                                         .FindAll().Where(x => x.chu_tai_khoan == chutaikhoan
                                                    && x.loai_tai_khoan == loaitien))
                    {
                        if (boxChonTaiKhoan.Items.Contains(taikhoan.ten_tai_khoan) == false)
                            boxChonTaiKhoan.Items.Add(taikhoan.ten_tai_khoan);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn đúng loại tiền");
                    boxChonTien.Focus();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn chủ tài khoản trước");
                boxChuTaiKhoan.Focus();
            }
        }

        private void LoadData(String tentaikhoan)
        {
            foreach (var taikhoan in DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan")
                                             .FindAll().Where(x => x.ten_tai_khoan == tentaikhoan))
            {
                boxChuTaiKhoan.Text = taikhoan.chu_tai_khoan;
                boxChonTien.Text = taikhoan.loai_tai_khoan;
            }
            boxChonTaiKhoan.Text = tentaikhoan;
            string phanloai = selectPhanTich.Text.Trim();
            List<string> phanloaiList = new List<string>();

            for (int i = 0; i < selectPhanTich.Items.Count; i++)
            {
                phanloaiList.Add(selectPhanTich.Items[i].ToString());
            }

            if (phanloaiList.Contains(phanloai))
            {
                DateTime date1 = dateTimePicker1.Value.Date;
                DateTime date2 = dateTimePicker2.Value.Date;

                var taikhoanCollection = DBContext.GetIntance().GetCollection<TaiSan>("tai_san")
                           .FindAll()
                           .Where(x => x.tai_khoan == tentaikhoan
                                  && x.date >= date1 && x.date <= date2)
                           .OrderBy(x => x.date).ToList();

                textBoxSoDu.Text = MainFrame.ChuanHoa(DBContext.GetIntance().GetCollection<TaiKhoan>("tai_khoan").FindAll()
                           .First(x => x.ten_tai_khoan == tentaikhoan).so_du) + " VND";

                if (phanloai == "Phân tích theo tháng") chart_theo_thang(taikhoanCollection);
                else if (phanloai == "Phân tích theo ngày") chart_theo_ngay(taikhoanCollection);
            }
            else
            {
                MessageBox.Show("Hãy chọn phân loại phân tích");
                selectPhanTich.Focus();
            }
        }

        private void boxChonTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tentaikhoan = boxChonTaiKhoan.Text.Trim();
            {
                List<string> taikhoanList = new List<string>();

                for (int i = 0; i < boxChonTaiKhoan.Items.Count; i++)
                {
                    taikhoanList.Add(boxChonTaiKhoan.Items[i].ToString());
                }

                if (taikhoanList.Contains(tentaikhoan))
                {
                    LoadData(tentaikhoan);
                }
                else
                {
                    MessageBox.Show("Hãy chọn đúng tài khoản");
                    boxChonTaiKhoan.Focus();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string chutaikhoan = boxChuTaiKhoan.Text.Trim();

            List<string> chutaikhoanList = new List<string>();
            for (int i = 0; i < boxChuTaiKhoan.Items.Count; i++)
            {
                chutaikhoanList.Add(boxChuTaiKhoan.Items[i].ToString());
            }

            if (chutaikhoanList.Contains(chutaikhoan))
            {
                string tentaikhoan = boxChonTaiKhoan.Text.Trim();
                LoadData(tentaikhoan);
            }
            else
            {
                MessageBox.Show("Hãy chọn chủ tài khoản trước");
                boxChuTaiKhoan.Focus();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string chutaikhoan = boxChuTaiKhoan.Text.Trim();

            List<string> chutaikhoanList = new List<string>();
            for (int i = 0; i < boxChuTaiKhoan.Items.Count; i++)
            {
                chutaikhoanList.Add(boxChuTaiKhoan.Items[i].ToString());
            }

            if (chutaikhoanList.Contains(chutaikhoan))
            {
                string tentaikhoan = boxChonTaiKhoan.Text.Trim();
                LoadData(tentaikhoan);
            }
            else
            {
                MessageBox.Show("Hãy chọn chủ tài khoản trước");
                boxChuTaiKhoan.Focus();
            }
        }
    }
}
