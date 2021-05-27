
namespace QuanLyTaiChinh.Controls
{
    partial class ChiTieuCtrl
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
            this.buttonThemChiTieu = new System.Windows.Forms.Button();
            this.boxChonTienChiTieu = new System.Windows.Forms.ComboBox();
            this.boxChonNamChiTieu = new System.Windows.Forms.ComboBox();
            this.boxChonThangChiTieu = new System.Windows.Forms.ComboBox();
            this.boxChonNgayChiTieu = new System.Windows.Forms.ComboBox();
            this.textTimKiemChiTieu = new QuanLyTaiChinh.Controls.PHTextBox("Tìm kiếm");
            this.textBoxTongChiTieu = new System.Windows.Forms.TextBox();
            this.dataGridViewChiTieu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTieu)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapNhat.Location = new System.Drawing.Point(36, 453);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(217, 40);
            this.buttonCapNhat.TabIndex = 47;
            this.buttonCapNhat.Text = "Cập nhật dữ liệu";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // buttonThemChiTieu
            // 
            this.buttonThemChiTieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThemChiTieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemChiTieu.Location = new System.Drawing.Point(1022, 20);
            this.buttonThemChiTieu.Name = "buttonThemChiTieu";
            this.buttonThemChiTieu.Size = new System.Drawing.Size(191, 40);
            this.buttonThemChiTieu.TabIndex = 46;
            this.buttonThemChiTieu.Text = "Thêm chi tiêu";
            this.buttonThemChiTieu.UseVisualStyleBackColor = true;
            this.buttonThemChiTieu.Click += new System.EventHandler(this.buttonThemChiTieu_Click);
            // 
            // boxChonTienChiTieu
            // 
            this.boxChonTienChiTieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonTienChiTieu.FormattingEnabled = true;
            this.boxChonTienChiTieu.Location = new System.Drawing.Point(284, 26);
            this.boxChonTienChiTieu.Name = "boxChonTienChiTieu";
            this.boxChonTienChiTieu.Size = new System.Drawing.Size(121, 31);
            this.boxChonTienChiTieu.TabIndex = 53;
            this.boxChonTienChiTieu.Text = "Chọn Tiền";
            this.boxChonTienChiTieu.SelectedIndexChanged += new System.EventHandler(this.boxChonTienChiTieu_SelectedIndexChanged_1);
            // 
            // boxChonNamChiTieu
            // 
            this.boxChonNamChiTieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonNamChiTieu.FormattingEnabled = true;
            this.boxChonNamChiTieu.Location = new System.Drawing.Point(736, 25);
            this.boxChonNamChiTieu.Name = "boxChonNamChiTieu";
            this.boxChonNamChiTieu.Size = new System.Drawing.Size(121, 31);
            this.boxChonNamChiTieu.Sorted = true;
            this.boxChonNamChiTieu.TabIndex = 54;
            this.boxChonNamChiTieu.Text = "Năm";
            this.boxChonNamChiTieu.SelectedIndexChanged += new System.EventHandler(this.boxChonNamChiTieu_SelectedIndexChanged_1);
            // 
            // boxChonThangChiTieu
            // 
            this.boxChonThangChiTieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonThangChiTieu.FormattingEnabled = true;
            this.boxChonThangChiTieu.Location = new System.Drawing.Point(587, 25);
            this.boxChonThangChiTieu.Name = "boxChonThangChiTieu";
            this.boxChonThangChiTieu.Size = new System.Drawing.Size(121, 31);
            this.boxChonThangChiTieu.Sorted = true;
            this.boxChonThangChiTieu.TabIndex = 55;
            this.boxChonThangChiTieu.Text = "Tháng";
            this.boxChonThangChiTieu.SelectedIndexChanged += new System.EventHandler(this.boxChonThangChiTieu_SelectedIndexChanged_1);
            // 
            // boxChonNgayChiTieu
            // 
            this.boxChonNgayChiTieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChonNgayChiTieu.FormattingEnabled = true;
            this.boxChonNgayChiTieu.Location = new System.Drawing.Point(439, 26);
            this.boxChonNgayChiTieu.Name = "boxChonNgayChiTieu";
            this.boxChonNgayChiTieu.Size = new System.Drawing.Size(121, 31);
            this.boxChonNgayChiTieu.Sorted = true;
            this.boxChonNgayChiTieu.TabIndex = 56;
            this.boxChonNgayChiTieu.Text = "Ngày";
            this.boxChonNgayChiTieu.SelectedIndexChanged += new System.EventHandler(this.boxChonNgayChiTieu_SelectedIndexChanged_1);
            // 
            // textTimKiemChiTieu
            // 
            this.textTimKiemChiTieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTimKiemChiTieu.ForeColor = System.Drawing.Color.Gray;
            this.textTimKiemChiTieu.Location = new System.Drawing.Point(39, 27);
            this.textTimKiemChiTieu.Name = "textTimKiemChiTieu";
            this.textTimKiemChiTieu.PlaceHolderText = null;
            this.textTimKiemChiTieu.Size = new System.Drawing.Size(210, 30);
            this.textTimKiemChiTieu.TabIndex = 57;
            this.textTimKiemChiTieu.Text = "Tìm kiếm";
            this.textTimKiemChiTieu.TextChanged += new System.EventHandler(this.textTimKiemChiTieu_TextChanged_1);
            // 
            // textBoxTongChiTieu
            // 
            this.textBoxTongChiTieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTongChiTieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongChiTieu.Location = new System.Drawing.Point(977, 459);
            this.textBoxTongChiTieu.Name = "textBoxTongChiTieu";
            this.textBoxTongChiTieu.ReadOnly = true;
            this.textBoxTongChiTieu.ShortcutsEnabled = false;
            this.textBoxTongChiTieu.Size = new System.Drawing.Size(239, 34);
            this.textBoxTongChiTieu.TabIndex = 58;
            this.textBoxTongChiTieu.Text = "Tổng:";
            // 
            // dataGridViewChiTieu
            // 
            this.dataGridViewChiTieu.AllowUserToAddRows = false;
            this.dataGridViewChiTieu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewChiTieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewChiTieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewChiTieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTieu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChiTieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewChiTieu.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewChiTieu.GridColor = System.Drawing.Color.Black;
            this.dataGridViewChiTieu.Location = new System.Drawing.Point(39, 86);
            this.dataGridViewChiTieu.Name = "dataGridViewChiTieu";
            this.dataGridViewChiTieu.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChiTieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewChiTieu.RowHeadersVisible = false;
            this.dataGridViewChiTieu.RowHeadersWidth = 51;
            this.dataGridViewChiTieu.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewChiTieu.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewChiTieu.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewChiTieu.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewChiTieu.RowTemplate.Height = 24;
            this.dataGridViewChiTieu.RowTemplate.ReadOnly = true;
            this.dataGridViewChiTieu.Size = new System.Drawing.Size(1177, 342);
            this.dataGridViewChiTieu.TabIndex = 59;
            // 
            // ChiTieuCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewChiTieu);
            this.Controls.Add(this.textBoxTongChiTieu);
            this.Controls.Add(this.textTimKiemChiTieu);
            this.Controls.Add(this.boxChonNgayChiTieu);
            this.Controls.Add(this.boxChonThangChiTieu);
            this.Controls.Add(this.boxChonNamChiTieu);
            this.Controls.Add(this.boxChonTienChiTieu);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.buttonThemChiTieu);
            this.Name = "ChiTieuCtrl";
            this.Size = new System.Drawing.Size(1254, 514);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonThemChiTieu;
        private System.Windows.Forms.ComboBox boxChonTienChiTieu;
        private System.Windows.Forms.ComboBox boxChonNamChiTieu;
        private System.Windows.Forms.ComboBox boxChonThangChiTieu;
        private System.Windows.Forms.ComboBox boxChonNgayChiTieu;
        private PHTextBox textTimKiemChiTieu;
        private System.Windows.Forms.TextBox textBoxTongChiTieu;
        private System.Windows.Forms.DataGridView dataGridViewChiTieu;
    }
}
