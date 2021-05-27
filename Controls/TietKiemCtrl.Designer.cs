
namespace QuanLyTaiChinh.Controls
{
    partial class TietKiemCtrl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonThemTietKiem = new System.Windows.Forms.Button();
            this.boxChonTienTietKiem = new System.Windows.Forms.ComboBox();
            this.boxChonNamTietKiem = new System.Windows.Forms.ComboBox();
            this.boxChonThangTietKiem = new System.Windows.Forms.ComboBox();
            this.boxChonNgayTietKiem = new System.Windows.Forms.ComboBox();
            this.textTimKiemTietKiem = new QuanLyTaiChinh.Controls.PHTextBox("Tìm kiếm");
            this.textBoxTongTietKiem = new System.Windows.Forms.TextBox();
            this.dataGridViewTietKiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTietKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapNhat.Location = new System.Drawing.Point(36, 454);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(217, 40);
            this.buttonCapNhat.TabIndex = 47;
            this.buttonCapNhat.Text = "Cập nhật dữ liệu";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // buttonThemTietKiem
            // 
            this.buttonThemTietKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThemTietKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemTietKiem.Location = new System.Drawing.Point(1023, 20);
            this.buttonThemTietKiem.Name = "buttonThemTietKiem";
            this.buttonThemTietKiem.Size = new System.Drawing.Size(191, 40);
            this.buttonThemTietKiem.TabIndex = 46;
            this.buttonThemTietKiem.Text = "Thêm tiết kiệm";
            this.buttonThemTietKiem.UseVisualStyleBackColor = true;
            this.buttonThemTietKiem.Click += new System.EventHandler(this.buttonThemTietKiem_Click);
            // 
            // boxChonTienTietKiem
            // 
            this.boxChonTienTietKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonTienTietKiem.FormattingEnabled = true;
            this.boxChonTienTietKiem.Location = new System.Drawing.Point(284, 26);
            this.boxChonTienTietKiem.Name = "boxChonTienTietKiem";
            this.boxChonTienTietKiem.Size = new System.Drawing.Size(121, 31);
            this.boxChonTienTietKiem.TabIndex = 62;
            this.boxChonTienTietKiem.Text = "Chọn Tiền";
            this.boxChonTienTietKiem.SelectedIndexChanged += new System.EventHandler(this.boxChonTienTietKiem_SelectedIndexChanged_1);
            // 
            // boxChonNamTietKiem
            // 
            this.boxChonNamTietKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonNamTietKiem.FormattingEnabled = true;
            this.boxChonNamTietKiem.Location = new System.Drawing.Point(732, 26);
            this.boxChonNamTietKiem.Name = "boxChonNamTietKiem";
            this.boxChonNamTietKiem.Size = new System.Drawing.Size(121, 31);
            this.boxChonNamTietKiem.Sorted = true;
            this.boxChonNamTietKiem.TabIndex = 63;
            this.boxChonNamTietKiem.Text = "Năm";
            this.boxChonNamTietKiem.SelectedIndexChanged += new System.EventHandler(this.boxChonNamTietKiem_SelectedIndexChanged_1);
            // 
            // boxChonThangTietKiem
            // 
            this.boxChonThangTietKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonThangTietKiem.FormattingEnabled = true;
            this.boxChonThangTietKiem.Location = new System.Drawing.Point(585, 26);
            this.boxChonThangTietKiem.Name = "boxChonThangTietKiem";
            this.boxChonThangTietKiem.Size = new System.Drawing.Size(121, 31);
            this.boxChonThangTietKiem.Sorted = true;
            this.boxChonThangTietKiem.TabIndex = 64;
            this.boxChonThangTietKiem.Text = "Tháng";
            this.boxChonThangTietKiem.SelectedIndexChanged += new System.EventHandler(this.boxChonThangTietKiem_SelectedIndexChanged);
            // 
            // boxChonNgayTietKiem
            // 
            this.boxChonNgayTietKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonNgayTietKiem.FormattingEnabled = true;
            this.boxChonNgayTietKiem.Location = new System.Drawing.Point(438, 26);
            this.boxChonNgayTietKiem.Name = "boxChonNgayTietKiem";
            this.boxChonNgayTietKiem.Size = new System.Drawing.Size(121, 31);
            this.boxChonNgayTietKiem.Sorted = true;
            this.boxChonNgayTietKiem.TabIndex = 65;
            this.boxChonNgayTietKiem.Text = "Ngày";
            this.boxChonNgayTietKiem.SelectedIndexChanged += new System.EventHandler(this.boxChonNgayTietKiem_SelectedIndexChanged);
            // 
            // textTimKiemTietKiem
            // 
            this.textTimKiemTietKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTimKiemTietKiem.ForeColor = System.Drawing.Color.Gray;
            this.textTimKiemTietKiem.Location = new System.Drawing.Point(36, 27);
            this.textTimKiemTietKiem.Name = "textTimKiemTietKiem";
            this.textTimKiemTietKiem.PlaceHolderText = null;
            this.textTimKiemTietKiem.Size = new System.Drawing.Size(210, 30);
            this.textTimKiemTietKiem.TabIndex = 66;
            this.textTimKiemTietKiem.Text = "Tìm kiếm";
            this.textTimKiemTietKiem.TextChanged += new System.EventHandler(this.textTimKiemTietKiem_TextChanged_1);
            // 
            // textBoxTongTietKiem
            // 
            this.textBoxTongTietKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTongTietKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongTietKiem.Location = new System.Drawing.Point(977, 460);
            this.textBoxTongTietKiem.Name = "textBoxTongTietKiem";
            this.textBoxTongTietKiem.ReadOnly = true;
            this.textBoxTongTietKiem.ShortcutsEnabled = false;
            this.textBoxTongTietKiem.Size = new System.Drawing.Size(239, 34);
            this.textBoxTongTietKiem.TabIndex = 67;
            this.textBoxTongTietKiem.Text = "Tổng:";
            // 
            // dataGridViewTietKiem
            // 
            this.dataGridViewTietKiem.AllowUserToAddRows = false;
            this.dataGridViewTietKiem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTietKiem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTietKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTietKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTietKiem.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTietKiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTietKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTietKiem.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTietKiem.GridColor = System.Drawing.Color.Black;
            this.dataGridViewTietKiem.Location = new System.Drawing.Point(38, 86);
            this.dataGridViewTietKiem.Name = "dataGridViewTietKiem";
            this.dataGridViewTietKiem.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTietKiem.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTietKiem.RowHeadersVisible = false;
            this.dataGridViewTietKiem.RowHeadersWidth = 51;
            this.dataGridViewTietKiem.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTietKiem.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTietKiem.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewTietKiem.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTietKiem.RowTemplate.Height = 24;
            this.dataGridViewTietKiem.RowTemplate.ReadOnly = true;
            this.dataGridViewTietKiem.Size = new System.Drawing.Size(1178, 343);
            this.dataGridViewTietKiem.TabIndex = 68;
            // 
            // TietKiemCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewTietKiem);
            this.Controls.Add(this.textBoxTongTietKiem);
            this.Controls.Add(this.textTimKiemTietKiem);
            this.Controls.Add(this.boxChonNgayTietKiem);
            this.Controls.Add(this.boxChonThangTietKiem);
            this.Controls.Add(this.boxChonNamTietKiem);
            this.Controls.Add(this.boxChonTienTietKiem);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.buttonThemTietKiem);
            this.Name = "TietKiemCtrl";
            this.Size = new System.Drawing.Size(1254, 514);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTietKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonThemTietKiem;
        private System.Windows.Forms.ComboBox boxChonTienTietKiem;
        private System.Windows.Forms.ComboBox boxChonNamTietKiem;
        private System.Windows.Forms.ComboBox boxChonThangTietKiem;
        private System.Windows.Forms.ComboBox boxChonNgayTietKiem;
        private PHTextBox textTimKiemTietKiem;
        private System.Windows.Forms.TextBox textBoxTongTietKiem;
        private System.Windows.Forms.DataGridView dataGridViewTietKiem;
    }
}
