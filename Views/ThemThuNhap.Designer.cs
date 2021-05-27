
namespace QuanLyTaiChinh.Views
{
    partial class ThemThuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemThuNhap));
            this.buttonThemThuNhap = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.boxTaiKhoan = new System.Windows.Forms.ComboBox();
            this.boxPhanLoai = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxLuongTien = new QuanLyTaiChinh.Controls.PHTextBox("Số tiền");
            this.textBoxMoTa = new QuanLyTaiChinh.Controls.PHTextBox("Mô tả");
            this.textBoxNoiGui = new QuanLyTaiChinh.Controls.PHTextBox("Nơi gửi");
            this.textBoxNguoiGui = new QuanLyTaiChinh.Controls.PHTextBox("Người gửi");
            this.SuspendLayout();
            // 
            // buttonThemThuNhap
            // 
            this.buttonThemThuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThemThuNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemThuNhap.Location = new System.Drawing.Point(350, 383);
            this.buttonThemThuNhap.Name = "buttonThemThuNhap";
            this.buttonThemThuNhap.Size = new System.Drawing.Size(155, 33);
            this.buttonThemThuNhap.TabIndex = 17;
            this.buttonThemThuNhap.Text = "Thêm thu nhập";
            this.buttonThemThuNhap.UseVisualStyleBackColor = true;
            this.buttonThemThuNhap.Click += new System.EventHandler(this.buttonThemThuNhap_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(55, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(198, 27);
            this.textBox2.TabIndex = 43;
            this.textBox2.Text = "Thông tin thu nhập";
            // 
            // boxTaiKhoan
            // 
            this.boxTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTaiKhoan.FormattingEnabled = true;
            this.boxTaiKhoan.Items.AddRange(new object[] {
            "Tiền Mặt",
            "Ví",
            "Thẻ"});
            this.boxTaiKhoan.Location = new System.Drawing.Point(55, 255);
            this.boxTaiKhoan.Name = "boxTaiKhoan";
            this.boxTaiKhoan.Size = new System.Drawing.Size(212, 31);
            this.boxTaiKhoan.TabIndex = 47;
            this.boxTaiKhoan.Text = "Tài khoản";
            this.boxTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.boxTaiKhoan_SelectedIndexChanged_1);
            // 
            // boxPhanLoai
            // 
            this.boxPhanLoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPhanLoai.FormattingEnabled = true;
            this.boxPhanLoai.Items.AddRange(new object[] {
            "Lương",
            "Thưởng",
            "Làm thêm",
            "Được cho, tặng",
            "Đi vay",
            "Nợ được trả"});
            this.boxPhanLoai.Location = new System.Drawing.Point(293, 255);
            this.boxPhanLoai.Name = "boxPhanLoai";
            this.boxPhanLoai.Size = new System.Drawing.Size(212, 31);
            this.boxPhanLoai.TabIndex = 48;
            this.boxPhanLoai.Text = "Phân loại";
            this.boxPhanLoai.SelectedIndexChanged += new System.EventHandler(this.boxPhanLoai_SelectedIndexChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 30);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // textBoxLuongTien
            // 
            this.textBoxLuongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLuongTien.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLuongTien.Location = new System.Drawing.Point(337, 317);
            this.textBoxLuongTien.Name = "textBoxLuongTien";
            this.textBoxLuongTien.PlaceHolderText = null;
            this.textBoxLuongTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxLuongTien.Size = new System.Drawing.Size(168, 30);
            this.textBoxLuongTien.TabIndex = 50;
            this.textBoxLuongTien.Text = "Số tiền";
            this.textBoxLuongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLuongTien.TextChanged += new System.EventHandler(this.textBoxLuongTien_TextChanged);
            // 
            // textBoxMoTa
            // 
            this.textBoxMoTa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoTa.ForeColor = System.Drawing.Color.Gray;
            this.textBoxMoTa.Location = new System.Drawing.Point(55, 197);
            this.textBoxMoTa.Name = "textBoxMoTa";
            this.textBoxMoTa.PlaceHolderText = null;
            this.textBoxMoTa.Size = new System.Drawing.Size(450, 30);
            this.textBoxMoTa.TabIndex = 46;
            this.textBoxMoTa.Text = "Mô tả";
            // 
            // textBoxNoiGui
            // 
            this.textBoxNoiGui.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoiGui.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNoiGui.Location = new System.Drawing.Point(55, 139);
            this.textBoxNoiGui.Name = "textBoxNoiGui";
            this.textBoxNoiGui.PlaceHolderText = null;
            this.textBoxNoiGui.Size = new System.Drawing.Size(450, 30);
            this.textBoxNoiGui.TabIndex = 45;
            this.textBoxNoiGui.Text = "Nơi gửi";
            // 
            // textBoxNguoiGui
            // 
            this.textBoxNguoiGui.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNguoiGui.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNguoiGui.Location = new System.Drawing.Point(55, 85);
            this.textBoxNguoiGui.Name = "textBoxNguoiGui";
            this.textBoxNguoiGui.PlaceHolderText = null;
            this.textBoxNguoiGui.Size = new System.Drawing.Size(450, 30);
            this.textBoxNguoiGui.TabIndex = 44;
            this.textBoxNguoiGui.Text = "Người gửi";
            // 
            // ThemThuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.textBoxLuongTien);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.boxPhanLoai);
            this.Controls.Add(this.boxTaiKhoan);
            this.Controls.Add(this.textBoxMoTa);
            this.Controls.Add(this.textBoxNoiGui);
            this.Controls.Add(this.textBoxNguoiGui);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonThemThuNhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ThemThuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThemThuNhap";
            this.Load += new System.EventHandler(this.ThemThuNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonThemThuNhap;
        private System.Windows.Forms.TextBox textBox2;
        private Controls.PHTextBox textBoxNguoiGui;
        private Controls.PHTextBox textBoxNoiGui;
        private Controls.PHTextBox textBoxMoTa;
        private System.Windows.Forms.ComboBox boxTaiKhoan;
        private System.Windows.Forms.ComboBox boxPhanLoai;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Controls.PHTextBox textBoxLuongTien;
    }
}