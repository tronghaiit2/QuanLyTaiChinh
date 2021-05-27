
namespace QuanLyTaiChinh.Views
{
    partial class ThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTaiKhoan));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxTenTaiKhoan = new QuanLyTaiChinh.Controls.PHTextBox("Tên tài khoản");
            this.textBoxChuTaiKhoan = new QuanLyTaiChinh.Controls.PHTextBox("Chủ tài khoản");
            this.textBoxSoTaiKhoan = new QuanLyTaiChinh.Controls.PHTextBox("Số tài khoản");
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.boxPhanLoai = new System.Windows.Forms.ComboBox();
            this.textBoxSoDu = new QuanLyTaiChinh.Controls.PHTextBox("Số dư");
            this.buttonThemTaiKhoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(50, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(198, 27);
            this.textBox2.TabIndex = 61;
            this.textBox2.Text = "Thông tin tài khoản";
            // 
            // textBoxTenTaiKhoan
            // 
            this.textBoxTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenTaiKhoan.ForeColor = System.Drawing.Color.Gray;
            this.textBoxTenTaiKhoan.Location = new System.Drawing.Point(50, 82);
            this.textBoxTenTaiKhoan.Name = "textBoxTenTaiKhoan";
            this.textBoxTenTaiKhoan.PlaceHolderText = null;
            this.textBoxTenTaiKhoan.Size = new System.Drawing.Size(450, 30);
            this.textBoxTenTaiKhoan.TabIndex = 62;
            this.textBoxTenTaiKhoan.Text = "Tên tài khoản";
            // 
            // textBoxChuTaiKhoan
            // 
            this.textBoxChuTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChuTaiKhoan.ForeColor = System.Drawing.Color.Gray;
            this.textBoxChuTaiKhoan.Location = new System.Drawing.Point(50, 138);
            this.textBoxChuTaiKhoan.Name = "textBoxChuTaiKhoan";
            this.textBoxChuTaiKhoan.PlaceHolderText = null;
            this.textBoxChuTaiKhoan.Size = new System.Drawing.Size(450, 30);
            this.textBoxChuTaiKhoan.TabIndex = 63;
            this.textBoxChuTaiKhoan.Text = "Chủ tài khoản";
            // 
            // textBoxSoTaiKhoan
            // 
            this.textBoxSoTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoTaiKhoan.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSoTaiKhoan.Location = new System.Drawing.Point(50, 193);
            this.textBoxSoTaiKhoan.Name = "textBoxSoTaiKhoan";
            this.textBoxSoTaiKhoan.PlaceHolderText = null;
            this.textBoxSoTaiKhoan.Size = new System.Drawing.Size(450, 30);
            this.textBoxSoTaiKhoan.TabIndex = 64;
            this.textBoxSoTaiKhoan.Text = "Số tài khoản";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(50, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(146, 27);
            this.textBox1.TabIndex = 65;
            this.textBox1.Text = "Ngày mở thẻ:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(214, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 30);
            this.dateTimePicker1.TabIndex = 66;
            // 
            // boxPhanLoai
            // 
            this.boxPhanLoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPhanLoai.FormattingEnabled = true;
            this.boxPhanLoai.Items.AddRange(new object[] {
            "Tiền mặt",
            "Ví",
            "Thẻ"});
            this.boxPhanLoai.Location = new System.Drawing.Point(50, 303);
            this.boxPhanLoai.Name = "boxPhanLoai";
            this.boxPhanLoai.Size = new System.Drawing.Size(212, 31);
            this.boxPhanLoai.TabIndex = 67;
            this.boxPhanLoai.Text = "Phân loại";
            this.boxPhanLoai.SelectedIndexChanged += new System.EventHandler(this.boxPhanLoai_SelectedIndexChanged_1);
            // 
            // textBoxSoDu
            // 
            this.textBoxSoDu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoDu.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSoDu.Location = new System.Drawing.Point(295, 303);
            this.textBoxSoDu.Name = "textBoxSoDu";
            this.textBoxSoDu.PlaceHolderText = null;
            this.textBoxSoDu.Size = new System.Drawing.Size(205, 30);
            this.textBoxSoDu.TabIndex = 68;
            this.textBoxSoDu.Text = "Số dư";
            this.textBoxSoDu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSoDu.TextChanged += new System.EventHandler(this.textBoxSoDu_TextChanged);
            // 
            // buttonThemTaiKhoan
            // 
            this.buttonThemTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemTaiKhoan.Location = new System.Drawing.Point(345, 369);
            this.buttonThemTaiKhoan.Name = "buttonThemTaiKhoan";
            this.buttonThemTaiKhoan.Size = new System.Drawing.Size(155, 33);
            this.buttonThemTaiKhoan.TabIndex = 56;
            this.buttonThemTaiKhoan.Text = "Thêm tài khoản";
            this.buttonThemTaiKhoan.UseVisualStyleBackColor = true;
            this.buttonThemTaiKhoan.Click += new System.EventHandler(this.buttonThemTaiKhoan_Click);
            // 
            // ThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.textBoxSoDu);
            this.Controls.Add(this.boxPhanLoai);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxSoTaiKhoan);
            this.Controls.Add(this.textBoxChuTaiKhoan);
            this.Controls.Add(this.textBoxTenTaiKhoan);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonThemTaiKhoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThemTaiKhoan";
            this.Load += new System.EventHandler(this.ThemTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private Controls.PHTextBox textBoxTenTaiKhoan;
        private Controls.PHTextBox textBoxChuTaiKhoan;
        private Controls.PHTextBox textBoxSoTaiKhoan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox boxPhanLoai;
        private Controls.PHTextBox textBoxSoDu;
        private System.Windows.Forms.Button buttonThemTaiKhoan;
    }
}