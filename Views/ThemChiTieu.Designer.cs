
namespace QuanLyTaiChinh.Views
{
    partial class ThemChiTieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemChiTieu));
            this.buttonThemChiTieu = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxNguoiNhan = new QuanLyTaiChinh.Controls.PHTextBox("Người nhận");
            this.textBoxNoiNhan = new QuanLyTaiChinh.Controls.PHTextBox("Nơi nhận");
            this.textBoxMoTa = new QuanLyTaiChinh.Controls.PHTextBox("Mô tả");
            this.boxTaiKhoan = new System.Windows.Forms.ComboBox();
            this.boxMucDich = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxLuongTien = new QuanLyTaiChinh.Controls.PHTextBox("Số tiền");
            this.SuspendLayout();
            // 
            // buttonThemChiTieu
            // 
            this.buttonThemChiTieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThemChiTieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemChiTieu.Location = new System.Drawing.Point(349, 372);
            this.buttonThemChiTieu.Name = "buttonThemChiTieu";
            this.buttonThemChiTieu.Size = new System.Drawing.Size(155, 33);
            this.buttonThemChiTieu.TabIndex = 37;
            this.buttonThemChiTieu.Text = "Thêm chi tiêu";
            this.buttonThemChiTieu.UseVisualStyleBackColor = true;
            this.buttonThemChiTieu.Click += new System.EventHandler(this.buttonThemChiTieu_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(54, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(198, 27);
            this.textBox2.TabIndex = 42;
            this.textBox2.Text = "Thông tin chi tiêu";
            // 
            // textBoxNguoiNhan
            // 
            this.textBoxNguoiNhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNguoiNhan.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNguoiNhan.Location = new System.Drawing.Point(54, 83);
            this.textBoxNguoiNhan.Name = "textBoxNguoiNhan";
            this.textBoxNguoiNhan.PlaceHolderText = null;
            this.textBoxNguoiNhan.Size = new System.Drawing.Size(450, 30);
            this.textBoxNguoiNhan.TabIndex = 43;
            this.textBoxNguoiNhan.Text = "Người nhận";
            // 
            // textBoxNoiNhan
            // 
            this.textBoxNoiNhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoiNhan.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNoiNhan.Location = new System.Drawing.Point(54, 138);
            this.textBoxNoiNhan.Name = "textBoxNoiNhan";
            this.textBoxNoiNhan.PlaceHolderText = null;
            this.textBoxNoiNhan.Size = new System.Drawing.Size(450, 30);
            this.textBoxNoiNhan.TabIndex = 44;
            this.textBoxNoiNhan.Text = "Nơi nhận";
            // 
            // textBoxMoTa
            // 
            this.textBoxMoTa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoTa.ForeColor = System.Drawing.Color.Gray;
            this.textBoxMoTa.Location = new System.Drawing.Point(54, 193);
            this.textBoxMoTa.Name = "textBoxMoTa";
            this.textBoxMoTa.PlaceHolderText = null;
            this.textBoxMoTa.Size = new System.Drawing.Size(450, 30);
            this.textBoxMoTa.TabIndex = 45;
            this.textBoxMoTa.Text = "Mô tả";
            // 
            // boxTaiKhoan
            // 
            this.boxTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTaiKhoan.FormattingEnabled = true;
            this.boxTaiKhoan.Items.AddRange(new object[] {
            "Tiền Mặt",
            "Ví",
            "Thẻ"});
            this.boxTaiKhoan.Location = new System.Drawing.Point(54, 250);
            this.boxTaiKhoan.Name = "boxTaiKhoan";
            this.boxTaiKhoan.Size = new System.Drawing.Size(212, 31);
            this.boxTaiKhoan.TabIndex = 46;
            this.boxTaiKhoan.Text = "Tài Khoản";
            this.boxTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.boxTaiKhoan_SelectedIndexChanged_1);
            // 
            // boxMucDich
            // 
            this.boxMucDich.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMucDich.FormattingEnabled = true;
            this.boxMucDich.Items.AddRange(new object[] {
            "Nhà ở",
            "Mua sắm",
            "Tiêu dùng",
            "Sức khỏe",
            "Công việc",
            "Vui chơi",
            "Giải trí",
            "Tiền cho, tặng",
            "Cho vay",
            "Trả nợ"});
            this.boxMucDich.Location = new System.Drawing.Point(292, 250);
            this.boxMucDich.Name = "boxMucDich";
            this.boxMucDich.Size = new System.Drawing.Size(212, 31);
            this.boxMucDich.TabIndex = 47;
            this.boxMucDich.Text = "Mục đích";
            this.boxMucDich.SelectedIndexChanged += new System.EventHandler(this.boxMucDich_SelectedIndexChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 308);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 30);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // textBoxLuongTien
            // 
            this.textBoxLuongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLuongTien.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLuongTien.Location = new System.Drawing.Point(336, 308);
            this.textBoxLuongTien.Name = "textBoxLuongTien";
            this.textBoxLuongTien.PlaceHolderText = null;
            this.textBoxLuongTien.Size = new System.Drawing.Size(168, 30);
            this.textBoxLuongTien.TabIndex = 49;
            this.textBoxLuongTien.Text = "Số tiền";
            this.textBoxLuongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLuongTien.TextChanged += new System.EventHandler(this.textBoxLuongTien_TextChanged);
            // 
            // ThemChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.textBoxLuongTien);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.boxMucDich);
            this.Controls.Add(this.boxTaiKhoan);
            this.Controls.Add(this.textBoxMoTa);
            this.Controls.Add(this.textBoxNoiNhan);
            this.Controls.Add(this.textBoxNguoiNhan);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonThemChiTieu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemChiTieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThemChiTieu";
            this.Load += new System.EventHandler(this.ThemChiTieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonThemChiTieu;
        private System.Windows.Forms.TextBox textBox2;
        private Controls.PHTextBox textBoxNguoiNhan;
        private Controls.PHTextBox textBoxNoiNhan;
        private Controls.PHTextBox textBoxMoTa;
        private System.Windows.Forms.ComboBox boxTaiKhoan;
        private System.Windows.Forms.ComboBox boxMucDich;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Controls.PHTextBox textBoxLuongTien;
    }
}