
namespace QuanLyTaiChinh.Controls
{
    partial class ThuNhapCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonThemThuNhap = new System.Windows.Forms.Button();
            this.boxChonTienThuNhap = new System.Windows.Forms.ComboBox();
            this.boxChonNamThuNhap = new System.Windows.Forms.ComboBox();
            this.boxChonThangThuNhap = new System.Windows.Forms.ComboBox();
            this.boxChonNgayThuNhap = new System.Windows.Forms.ComboBox();
            this.textTimKiemThuNhap = new QuanLyTaiChinh.Controls.PHTextBox("Tìm kiếm");
            this.textBoxTongThuNhap = new System.Windows.Forms.TextBox();
            this.dataGridViewThuNhap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapNhat.Location = new System.Drawing.Point(36, 452);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(217, 40);
            this.buttonCapNhat.TabIndex = 39;
            this.buttonCapNhat.Text = "Cập nhật dữ liệu";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // buttonThemThuNhap
            // 
            this.buttonThemThuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThemThuNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemThuNhap.Location = new System.Drawing.Point(1022, 20);
            this.buttonThemThuNhap.Name = "buttonThemThuNhap";
            this.buttonThemThuNhap.Size = new System.Drawing.Size(191, 40);
            this.buttonThemThuNhap.TabIndex = 38;
            this.buttonThemThuNhap.Text = "Thêm thu nhập";
            this.buttonThemThuNhap.UseVisualStyleBackColor = true;
            this.buttonThemThuNhap.Click += new System.EventHandler(this.buttonThemThuNhap_Click);
            // 
            // boxChonTienThuNhap
            // 
            this.boxChonTienThuNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonTienThuNhap.FormattingEnabled = true;
            this.boxChonTienThuNhap.Location = new System.Drawing.Point(289, 26);
            this.boxChonTienThuNhap.Name = "boxChonTienThuNhap";
            this.boxChonTienThuNhap.Size = new System.Drawing.Size(121, 31);
            this.boxChonTienThuNhap.TabIndex = 49;
            this.boxChonTienThuNhap.Text = "Chọn Tiền";
            this.boxChonTienThuNhap.SelectedIndexChanged += new System.EventHandler(this.boxChonTienThuNhap_SelectedIndexChanged_1);
            // 
            // boxChonNamThuNhap
            // 
            this.boxChonNamThuNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonNamThuNhap.FormattingEnabled = true;
            this.boxChonNamThuNhap.Location = new System.Drawing.Point(738, 26);
            this.boxChonNamThuNhap.Name = "boxChonNamThuNhap";
            this.boxChonNamThuNhap.Size = new System.Drawing.Size(121, 31);
            this.boxChonNamThuNhap.Sorted = true;
            this.boxChonNamThuNhap.TabIndex = 50;
            this.boxChonNamThuNhap.Text = "Năm";
            this.boxChonNamThuNhap.SelectedIndexChanged += new System.EventHandler(this.boxChonNamThuNhap_SelectedIndexChanged_1);
            // 
            // boxChonThangThuNhap
            // 
            this.boxChonThangThuNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonThangThuNhap.FormattingEnabled = true;
            this.boxChonThangThuNhap.Location = new System.Drawing.Point(592, 26);
            this.boxChonThangThuNhap.Name = "boxChonThangThuNhap";
            this.boxChonThangThuNhap.Size = new System.Drawing.Size(121, 31);
            this.boxChonThangThuNhap.Sorted = true;
            this.boxChonThangThuNhap.TabIndex = 51;
            this.boxChonThangThuNhap.Text = "Tháng";
            this.boxChonThangThuNhap.SelectedIndexChanged += new System.EventHandler(this.boxChonThangThuNhap_SelectedIndexChanged_1);
            // 
            // boxChonNgayThuNhap
            // 
            this.boxChonNgayThuNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonNgayThuNhap.FormattingEnabled = true;
            this.boxChonNgayThuNhap.Location = new System.Drawing.Point(442, 26);
            this.boxChonNgayThuNhap.Name = "boxChonNgayThuNhap";
            this.boxChonNgayThuNhap.Size = new System.Drawing.Size(121, 31);
            this.boxChonNgayThuNhap.Sorted = true;
            this.boxChonNgayThuNhap.TabIndex = 52;
            this.boxChonNgayThuNhap.Text = "Ngày";
            this.boxChonNgayThuNhap.SelectedIndexChanged += new System.EventHandler(this.boxChonNgayThuNhap_SelectedIndexChanged_1);
            // 
            // textTimKiemThuNhap
            // 
            this.textTimKiemThuNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTimKiemThuNhap.ForeColor = System.Drawing.Color.Gray;
            this.textTimKiemThuNhap.Location = new System.Drawing.Point(39, 27);
            this.textTimKiemThuNhap.Name = "textTimKiemThuNhap";
            this.textTimKiemThuNhap.PlaceHolderText = null;
            this.textTimKiemThuNhap.Size = new System.Drawing.Size(210, 30);
            this.textTimKiemThuNhap.TabIndex = 53;
            this.textTimKiemThuNhap.Text = "Tìm kiếm";
            this.textTimKiemThuNhap.TextChanged += new System.EventHandler(this.textTimKiemThuNhap_TextChanged_1);
            // 
            // textBoxTongThuNhap
            // 
            this.textBoxTongThuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTongThuNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongThuNhap.Location = new System.Drawing.Point(977, 458);
            this.textBoxTongThuNhap.Name = "textBoxTongThuNhap";
            this.textBoxTongThuNhap.ReadOnly = true;
            this.textBoxTongThuNhap.ShortcutsEnabled = false;
            this.textBoxTongThuNhap.Size = new System.Drawing.Size(239, 34);
            this.textBoxTongThuNhap.TabIndex = 54;
            this.textBoxTongThuNhap.Text = "Tổng:";
            // 
            // dataGridViewThuNhap
            // 
            this.dataGridViewThuNhap.AllowUserToAddRows = false;
            this.dataGridViewThuNhap.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewThuNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewThuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewThuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThuNhap.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewThuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewThuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewThuNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewThuNhap.GridColor = System.Drawing.Color.Black;
            this.dataGridViewThuNhap.Location = new System.Drawing.Point(39, 87);
            this.dataGridViewThuNhap.Name = "dataGridViewThuNhap";
            this.dataGridViewThuNhap.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewThuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewThuNhap.RowHeadersVisible = false;
            this.dataGridViewThuNhap.RowHeadersWidth = 51;
            this.dataGridViewThuNhap.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewThuNhap.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewThuNhap.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewThuNhap.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewThuNhap.RowTemplate.Height = 24;
            this.dataGridViewThuNhap.RowTemplate.ReadOnly = true;
            this.dataGridViewThuNhap.Size = new System.Drawing.Size(1177, 341);
            this.dataGridViewThuNhap.TabIndex = 55;
            // 
            // ThuNhapCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewThuNhap);
            this.Controls.Add(this.textBoxTongThuNhap);
            this.Controls.Add(this.textTimKiemThuNhap);
            this.Controls.Add(this.boxChonNgayThuNhap);
            this.Controls.Add(this.boxChonThangThuNhap);
            this.Controls.Add(this.boxChonNamThuNhap);
            this.Controls.Add(this.boxChonTienThuNhap);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.buttonThemThuNhap);
            this.Name = "ThuNhapCtrl";
            this.Size = new System.Drawing.Size(1254, 514);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonThemThuNhap;
        private System.Windows.Forms.ComboBox boxChonTienThuNhap;
        private System.Windows.Forms.ComboBox boxChonNamThuNhap;
        private System.Windows.Forms.ComboBox boxChonThangThuNhap;
        private System.Windows.Forms.ComboBox boxChonNgayThuNhap;
        private PHTextBox textTimKiemThuNhap;
        private System.Windows.Forms.TextBox textBoxTongThuNhap;
        private System.Windows.Forms.DataGridView dataGridViewThuNhap;
    }
}
