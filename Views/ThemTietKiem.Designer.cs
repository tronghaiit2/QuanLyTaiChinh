
namespace QuanLyTaiChinh.Views
{
    partial class ThemTietKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTietKiem));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.boxChonTien = new System.Windows.Forms.ComboBox();
            this.boxChonTaiKhoan = new System.Windows.Forms.ComboBox();
            this.textBoxMoTa = new QuanLyTaiChinh.Controls.PHTextBox("Mô tả");
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.selectBox = new System.Windows.Forms.ComboBox();
            this.textBoxLuongTien = new QuanLyTaiChinh.Controls.PHTextBox("Số tiền");
            this.buttonThemTietKiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(54, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(198, 27);
            this.textBox2.TabIndex = 44;
            this.textBox2.Text = "Thông tin tiết kiệm";
            // 
            // boxChonTien
            // 
            this.boxChonTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonTien.FormattingEnabled = true;
            this.boxChonTien.Items.AddRange(new object[] {
            "Tiền Mặt",
            "Ví",
            "Thẻ"});
            this.boxChonTien.Location = new System.Drawing.Point(54, 101);
            this.boxChonTien.Name = "boxChonTien";
            this.boxChonTien.Size = new System.Drawing.Size(450, 31);
            this.boxChonTien.TabIndex = 45;
            this.boxChonTien.Text = "Chọn loại tiền";
            this.boxChonTien.SelectedIndexChanged += new System.EventHandler(this.boxChonTien_SelectedIndexChanged_1);
            // 
            // boxChonTaiKhoan
            // 
            this.boxChonTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonTaiKhoan.FormattingEnabled = true;
            this.boxChonTaiKhoan.Location = new System.Drawing.Point(54, 162);
            this.boxChonTaiKhoan.Name = "boxChonTaiKhoan";
            this.boxChonTaiKhoan.Size = new System.Drawing.Size(450, 31);
            this.boxChonTaiKhoan.TabIndex = 46;
            this.boxChonTaiKhoan.Text = "Chọn tài khoản";
            this.boxChonTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.boxChonTaiKhoan_SelectedIndexChanged_1);
            // 
            // textBoxMoTa
            // 
            this.textBoxMoTa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoTa.ForeColor = System.Drawing.Color.Gray;
            this.textBoxMoTa.Location = new System.Drawing.Point(54, 223);
            this.textBoxMoTa.Name = "textBoxMoTa";
            this.textBoxMoTa.PlaceHolderText = null;
            this.textBoxMoTa.Size = new System.Drawing.Size(450, 30);
            this.textBoxMoTa.TabIndex = 47;
            this.textBoxMoTa.Text = "Mô tả";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 30);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // selectBox
            // 
            this.selectBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBox.FormattingEnabled = true;
            this.selectBox.Items.AddRange(new object[] {
            "Thêm",
            "Rút"});
            this.selectBox.Location = new System.Drawing.Point(329, 360);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(75, 31);
            this.selectBox.TabIndex = 50;
            this.selectBox.Text = "Chọn";
            this.selectBox.SelectedIndexChanged += new System.EventHandler(this.selectBox_SelectedIndexChanged);
            // 
            // textBoxLuongTien
            // 
            this.textBoxLuongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLuongTien.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLuongTien.Location = new System.Drawing.Point(328, 289);
            this.textBoxLuongTien.Name = "textBoxLuongTien";
            this.textBoxLuongTien.PlaceHolderText = null;
            this.textBoxLuongTien.Size = new System.Drawing.Size(176, 30);
            this.textBoxLuongTien.TabIndex = 55;
            this.textBoxLuongTien.Text = "Số tiền";
            this.textBoxLuongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLuongTien.TextChanged += new System.EventHandler(this.textBoxLuongTien_TextChanged);
            // 
            // buttonThemTietKiem
            // 
            this.buttonThemTietKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThemTietKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemTietKiem.Location = new System.Drawing.Point(400, 359);
            this.buttonThemTietKiem.Name = "buttonThemTietKiem";
            this.buttonThemTietKiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonThemTietKiem.Size = new System.Drawing.Size(104, 33);
            this.buttonThemTietKiem.TabIndex = 57;
            this.buttonThemTietKiem.Text = "tiết kiệm";
            this.buttonThemTietKiem.UseVisualStyleBackColor = true;
            this.buttonThemTietKiem.Click += new System.EventHandler(this.buttonThemTietKiem_Click);
            // 
            // ThemTietKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.buttonThemTietKiem);
            this.Controls.Add(this.textBoxLuongTien);
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxMoTa);
            this.Controls.Add(this.boxChonTaiKhoan);
            this.Controls.Add(this.boxChonTien);
            this.Controls.Add(this.textBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemTietKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThemTietKiem";
            this.Load += new System.EventHandler(this.ThemTietKiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox boxChonTien;
        private System.Windows.Forms.ComboBox boxChonTaiKhoan;
        private Controls.PHTextBox textBoxMoTa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox selectBox;
        private Controls.PHTextBox textBoxLuongTien;
        private System.Windows.Forms.Button buttonThemTietKiem;
    }
}