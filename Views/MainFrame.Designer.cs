
namespace QuanLyTaiChinh
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.PictureBox();
            this.buttonBaoCao = new System.Windows.Forms.Button();
            this.buttonTaiKhoan = new System.Windows.Forms.Button();
            this.buttonTietKiem = new System.Windows.Forms.Button();
            this.buttonChiTieu = new System.Windows.Forms.Button();
            this.buttonThuNhap = new System.Windows.Forms.Button();
            this.buttonQuyTien = new System.Windows.Forms.Button();
            this.panelPadding = new System.Windows.Forms.Panel();
            this.panelQLTC = new System.Windows.Forms.Panel();
            this.textQuanLyTaiChinh = new System.Windows.Forms.TextBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabQuyTien = new System.Windows.Forms.TabPage();
            this.tabThuNhap = new System.Windows.Forms.TabPage();
            this.tabChiTieu = new System.Windows.Forms.TabPage();
            this.tabTietKiem = new System.Windows.Forms.TabPage();
            this.tabTaiKhoan = new System.Windows.Forms.TabPage();
            this.tabBaoCao = new System.Windows.Forms.TabPage();
            this.quyTienCtrl1 = new QuanLyTaiChinh.Controls.QuyTienCtrl();
            this.baoCaoCtrl1 = new QuanLyTaiChinh.Controls.BaoCaoCtrl();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).BeginInit();
            this.panelQLTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.indicator);
            this.panelHeader.Controls.Add(this.buttonBaoCao);
            this.panelHeader.Controls.Add(this.buttonTaiKhoan);
            this.panelHeader.Controls.Add(this.buttonTietKiem);
            this.panelHeader.Controls.Add(this.buttonChiTieu);
            this.panelHeader.Controls.Add(this.buttonThuNhap);
            this.panelHeader.Controls.Add(this.buttonQuyTien);
            this.panelHeader.Controls.Add(this.panelPadding);
            this.panelHeader.Controls.Add(this.panelQLTC);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1262, 129);
            this.panelHeader.TabIndex = 0;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.ForestGreen;
            this.indicator.Location = new System.Drawing.Point(80, 124);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(150, 4);
            this.indicator.TabIndex = 2;
            this.indicator.TabStop = false;
            // 
            // buttonBaoCao
            // 
            this.buttonBaoCao.BackColor = System.Drawing.Color.White;
            this.buttonBaoCao.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBaoCao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaoCao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("buttonBaoCao.Image")));
            this.buttonBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBaoCao.Location = new System.Drawing.Point(830, 67);
            this.buttonBaoCao.Name = "buttonBaoCao";
            this.buttonBaoCao.Size = new System.Drawing.Size(150, 62);
            this.buttonBaoCao.TabIndex = 7;
            this.buttonBaoCao.Text = "Báo Cáo";
            this.buttonBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBaoCao.UseVisualStyleBackColor = false;
            this.buttonBaoCao.Click += new System.EventHandler(this.buttonBaoCao_Click);
            // 
            // buttonTaiKhoan
            // 
            this.buttonTaiKhoan.BackColor = System.Drawing.Color.White;
            this.buttonTaiKhoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("buttonTaiKhoan.Image")));
            this.buttonTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTaiKhoan.Location = new System.Drawing.Point(680, 67);
            this.buttonTaiKhoan.Name = "buttonTaiKhoan";
            this.buttonTaiKhoan.Size = new System.Drawing.Size(150, 62);
            this.buttonTaiKhoan.TabIndex = 6;
            this.buttonTaiKhoan.Text = "Tài Khoản";
            this.buttonTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTaiKhoan.UseVisualStyleBackColor = false;
            this.buttonTaiKhoan.Click += new System.EventHandler(this.buttonTaiKhoan_Click);
            // 
            // buttonTietKiem
            // 
            this.buttonTietKiem.BackColor = System.Drawing.Color.White;
            this.buttonTietKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTietKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTietKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTietKiem.Image = ((System.Drawing.Image)(resources.GetObject("buttonTietKiem.Image")));
            this.buttonTietKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTietKiem.Location = new System.Drawing.Point(530, 67);
            this.buttonTietKiem.Name = "buttonTietKiem";
            this.buttonTietKiem.Size = new System.Drawing.Size(150, 62);
            this.buttonTietKiem.TabIndex = 5;
            this.buttonTietKiem.Text = "Tiết Kiệm";
            this.buttonTietKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTietKiem.UseVisualStyleBackColor = false;
            this.buttonTietKiem.Click += new System.EventHandler(this.buttonTietKiem_Click);
            // 
            // buttonChiTieu
            // 
            this.buttonChiTieu.BackColor = System.Drawing.Color.White;
            this.buttonChiTieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonChiTieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChiTieu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonChiTieu.Image = ((System.Drawing.Image)(resources.GetObject("buttonChiTieu.Image")));
            this.buttonChiTieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChiTieu.Location = new System.Drawing.Point(380, 67);
            this.buttonChiTieu.Name = "buttonChiTieu";
            this.buttonChiTieu.Size = new System.Drawing.Size(150, 62);
            this.buttonChiTieu.TabIndex = 4;
            this.buttonChiTieu.Text = "Chi Tiêu";
            this.buttonChiTieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChiTieu.UseVisualStyleBackColor = false;
            this.buttonChiTieu.Click += new System.EventHandler(this.buttonChiTieu_Click);
            // 
            // buttonThuNhap
            // 
            this.buttonThuNhap.BackColor = System.Drawing.Color.White;
            this.buttonThuNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonThuNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThuNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonThuNhap.Image = ((System.Drawing.Image)(resources.GetObject("buttonThuNhap.Image")));
            this.buttonThuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThuNhap.Location = new System.Drawing.Point(230, 67);
            this.buttonThuNhap.Name = "buttonThuNhap";
            this.buttonThuNhap.Size = new System.Drawing.Size(150, 62);
            this.buttonThuNhap.TabIndex = 3;
            this.buttonThuNhap.Text = "Thu Nhập";
            this.buttonThuNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThuNhap.UseVisualStyleBackColor = false;
            this.buttonThuNhap.Click += new System.EventHandler(this.buttonThuNhap_Click);
            // 
            // buttonQuyTien
            // 
            this.buttonQuyTien.BackColor = System.Drawing.Color.White;
            this.buttonQuyTien.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonQuyTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuyTien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonQuyTien.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuyTien.Image")));
            this.buttonQuyTien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQuyTien.Location = new System.Drawing.Point(80, 67);
            this.buttonQuyTien.Name = "buttonQuyTien";
            this.buttonQuyTien.Size = new System.Drawing.Size(150, 62);
            this.buttonQuyTien.TabIndex = 2;
            this.buttonQuyTien.Text = "Quỹ Tiền";
            this.buttonQuyTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonQuyTien.UseVisualStyleBackColor = false;
            this.buttonQuyTien.Click += new System.EventHandler(this.buttonQuyTien_Click);
            // 
            // panelPadding
            // 
            this.panelPadding.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPadding.Location = new System.Drawing.Point(0, 67);
            this.panelPadding.Name = "panelPadding";
            this.panelPadding.Size = new System.Drawing.Size(80, 62);
            this.panelPadding.TabIndex = 1;
            // 
            // panelQLTC
            // 
            this.panelQLTC.BackColor = System.Drawing.Color.ForestGreen;
            this.panelQLTC.Controls.Add(this.textQuanLyTaiChinh);
            this.panelQLTC.Controls.Add(this.pictureLogo);
            this.panelQLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQLTC.Location = new System.Drawing.Point(0, 0);
            this.panelQLTC.Name = "panelQLTC";
            this.panelQLTC.Size = new System.Drawing.Size(1262, 67);
            this.panelQLTC.TabIndex = 0;
            // 
            // textQuanLyTaiChinh
            // 
            this.textQuanLyTaiChinh.BackColor = System.Drawing.Color.ForestGreen;
            this.textQuanLyTaiChinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textQuanLyTaiChinh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuanLyTaiChinh.ForeColor = System.Drawing.Color.White;
            this.textQuanLyTaiChinh.Location = new System.Drawing.Point(59, 17);
            this.textQuanLyTaiChinh.Name = "textQuanLyTaiChinh";
            this.textQuanLyTaiChinh.ReadOnly = true;
            this.textQuanLyTaiChinh.Size = new System.Drawing.Size(201, 31);
            this.textQuanLyTaiChinh.TabIndex = 1;
            this.textQuanLyTaiChinh.Text = "Quản Lý Tài Chính";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(8, 8);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabQuyTien);
            this.tabControl.Controls.Add(this.tabThuNhap);
            this.tabControl.Controls.Add(this.tabChiTieu);
            this.tabControl.Controls.Add(this.tabTietKiem);
            this.tabControl.Controls.Add(this.tabTaiKhoan);
            this.tabControl.Controls.Add(this.tabBaoCao);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 129);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1262, 544);
            this.tabControl.TabIndex = 9;
            // 
            // tabQuyTien
            // 
            this.tabQuyTien.Location = new System.Drawing.Point(4, 4);
            this.tabQuyTien.Name = "tabQuyTien";
            this.tabQuyTien.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuyTien.Size = new System.Drawing.Size(1254, 514);
            this.tabQuyTien.TabIndex = 0;
            this.tabQuyTien.Text = "Quỹ Tiền";
            this.tabQuyTien.UseVisualStyleBackColor = true;
            // 
            // tabThuNhap
            // 
            this.tabThuNhap.Location = new System.Drawing.Point(4, 4);
            this.tabThuNhap.Name = "tabThuNhap";
            this.tabThuNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabThuNhap.Size = new System.Drawing.Size(1254, 514);
            this.tabThuNhap.TabIndex = 1;
            this.tabThuNhap.Text = "Thu Nhập";
            this.tabThuNhap.UseVisualStyleBackColor = true;
            // 
            // tabChiTieu
            // 
            this.tabChiTieu.Location = new System.Drawing.Point(4, 4);
            this.tabChiTieu.Name = "tabChiTieu";
            this.tabChiTieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiTieu.Size = new System.Drawing.Size(1254, 514);
            this.tabChiTieu.TabIndex = 2;
            this.tabChiTieu.Text = "Chi Tiêu";
            this.tabChiTieu.UseVisualStyleBackColor = true;
            // 
            // tabTietKiem
            // 
            this.tabTietKiem.Location = new System.Drawing.Point(4, 4);
            this.tabTietKiem.Name = "tabTietKiem";
            this.tabTietKiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabTietKiem.Size = new System.Drawing.Size(1254, 514);
            this.tabTietKiem.TabIndex = 3;
            this.tabTietKiem.Text = "Tiết Kiệm";
            this.tabTietKiem.UseVisualStyleBackColor = true;
            // 
            // tabTaiKhoan
            // 
            this.tabTaiKhoan.Location = new System.Drawing.Point(4, 4);
            this.tabTaiKhoan.Name = "tabTaiKhoan";
            this.tabTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabTaiKhoan.Size = new System.Drawing.Size(1254, 514);
            this.tabTaiKhoan.TabIndex = 4;
            this.tabTaiKhoan.Text = "Tài Khoản";
            this.tabTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Location = new System.Drawing.Point(4, 4);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaoCao.Size = new System.Drawing.Size(1254, 514);
            this.tabBaoCao.TabIndex = 5;
            this.tabBaoCao.Text = "Báo Cáo";
            this.tabBaoCao.UseVisualStyleBackColor = true;
            // 
            // quyTienCtrl1
            // 
            this.quyTienCtrl1.AutoScroll = true;
            this.quyTienCtrl1.Location = new System.Drawing.Point(0, 0);
            this.quyTienCtrl1.Name = "quyTienCtrl1";
            this.quyTienCtrl1.Size = new System.Drawing.Size(1254, 514);
            this.quyTienCtrl1.TabIndex = 0;
            // 
            // baoCaoCtrl1
            // 
            this.baoCaoCtrl1.AutoScroll = true;
            this.baoCaoCtrl1.Location = new System.Drawing.Point(0, 0);
            this.baoCaoCtrl1.Name = "baoCaoCtrl1";
            this.baoCaoCtrl1.Size = new System.Drawing.Size(1254, 514);
            this.baoCaoCtrl1.TabIndex = 0;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyTaiChinh";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).EndInit();
            this.panelQLTC.ResumeLayout(false);
            this.panelQLTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelQLTC;
        private System.Windows.Forms.Button buttonBaoCao;
        private System.Windows.Forms.Button buttonTaiKhoan;
        private System.Windows.Forms.Button buttonTietKiem;
        private System.Windows.Forms.Button buttonChiTieu;
        private System.Windows.Forms.Button buttonThuNhap;
        private System.Windows.Forms.Button buttonQuyTien;
        private System.Windows.Forms.Panel panelPadding;
        private System.Windows.Forms.TextBox textQuanLyTaiChinh;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.PictureBox indicator;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabThuNhap;
        private System.Windows.Forms.TabPage tabChiTieu;
        private System.Windows.Forms.TabPage tabTietKiem;
        private System.Windows.Forms.TabPage tabTaiKhoan;
        private System.Windows.Forms.TabPage tabBaoCao;
        private Controls.QuyTienCtrl quyTienCtrl1;
        private Controls.ThuNhapCtrl thuNhapCtrl1;
        private Controls.ChiTieuCtrl chiTieuCtrl1;
        private Controls.TietKiemCtrl tietKiemCtrl1;
        private Controls.TaiKhoanCtrl taiKhoanCtrl1;
        private Controls.BaoCaoCtrl baoCaoCtrl1;
        private System.Windows.Forms.TabPage tabQuyTien;
    }
}

