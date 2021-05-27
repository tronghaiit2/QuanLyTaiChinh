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

namespace QuanLyTaiChinh
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
            quyTienCtrl1 = new QuanLyTaiChinh.Controls.QuyTienCtrl();
            quyTienCtrl1.Name = "quyTienCtrl1";
            position_control(quyTienCtrl1);
            tabQuyTien.Controls.Add(quyTienCtrl1);
        }

        void position_control(Control ctrl)
        {
            ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            ctrl.Location = new System.Drawing.Point(3, 3);
            ctrl.Size = new System.Drawing.Size(1248, 508);
            ctrl.TabIndex = 0;
        }

        //move indicator
        void MoveIndicator(Control btn)
        {
            indicator.Left = btn.Left;
            indicator.Width = btn.Width;
        }

        private void buttonQuyTien_Click(object sender, EventArgs e)
        {
            //update indicator
            MoveIndicator((Control)sender);
            tabControl.SelectedTab = tabQuyTien;
            quyTienCtrl1 = new QuanLyTaiChinh.Controls.QuyTienCtrl();
            quyTienCtrl1.Name = "quyTienCtrl1";
            position_control(quyTienCtrl1);
            tabQuyTien.Controls.Add(quyTienCtrl1);
        }

        private void buttonThuNhap_Click(object sender, EventArgs e)
        {
            //update indicator
            MoveIndicator((Control)sender);
            tabControl.SelectedTab = tabThuNhap;
            thuNhapCtrl1 = new QuanLyTaiChinh.Controls.ThuNhapCtrl();
            thuNhapCtrl1.Name = "thuNhapCtrl1";
            position_control(thuNhapCtrl1);
            tabThuNhap.Controls.Add(thuNhapCtrl1);
        }

        private void buttonChiTieu_Click(object sender, EventArgs e)
        {
            //update indicator
            MoveIndicator((Control)sender);
            tabControl.SelectedTab = tabChiTieu;
            chiTieuCtrl1 = new QuanLyTaiChinh.Controls.ChiTieuCtrl();
            chiTieuCtrl1.Name = "chiTieuCtrl1";
            position_control(chiTieuCtrl1);
            tabChiTieu.Controls.Add(chiTieuCtrl1);
        }

        private void buttonTietKiem_Click(object sender, EventArgs e)
        {
            //update indicator
            MoveIndicator((Control)sender);
            tabControl.SelectedTab = tabTietKiem;
            tietKiemCtrl1 = new QuanLyTaiChinh.Controls.TietKiemCtrl();
            tietKiemCtrl1.Name = "tietKiemCtrl1";
            position_control(tietKiemCtrl1);
            tabTietKiem.Controls.Add(tietKiemCtrl1);
        }

        private void buttonTaiKhoan_Click(object sender, EventArgs e)
        {
            //update indicator
            MoveIndicator((Control)sender);
            tabControl.SelectedTab = tabTaiKhoan;
            taiKhoanCtrl1 = new QuanLyTaiChinh.Controls.TaiKhoanCtrl();
            taiKhoanCtrl1.Name = "taiKhoanCtrl1";
            position_control(taiKhoanCtrl1);
            tabTaiKhoan.Controls.Add(taiKhoanCtrl1);
        }

        private void buttonBaoCao_Click(object sender, EventArgs e)
        {
            //update indicator
            MoveIndicator((Control)sender);
            tabControl.SelectedTab = tabBaoCao;
            baoCaoCtrl1 = new QuanLyTaiChinh.Controls.BaoCaoCtrl();
            baoCaoCtrl1.Name = "baoCaoCtrl1";
            position_control(baoCaoCtrl1);
            tabBaoCao.Controls.Add(baoCaoCtrl1);
        }

        // Hàm chuẩn hóa tiền để hiển thị
        public static String ChuanHoa(long sotien)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 0;
            nfi.NumberGroupSeparator = " ";
            sotien.ToString("N", nfi);
            return sotien.ToString("N", nfi);
        }
    }
}
