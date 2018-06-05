namespace QLKhuVuiChoi.Presentation
{
    partial class frmXuatHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGTKH = new System.Windows.Forms.Label();
            this.lbGT = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.lbTuoi = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbGTKH);
            this.groupBox1.Controls.Add(this.lbGT);
            this.groupBox1.Controls.Add(this.lbTenKH);
            this.groupBox1.Controls.Add(this.lable);
            this.groupBox1.Controls.Add(this.lbTuoi);
            this.groupBox1.Controls.Add(this.lbMaKH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tuổi Khách Hàng:";
            // 
            // lbGTKH
            // 
            this.lbGTKH.AutoSize = true;
            this.lbGTKH.Location = new System.Drawing.Point(369, 63);
            this.lbGTKH.Name = "lbGTKH";
            this.lbGTKH.Size = new System.Drawing.Size(35, 13);
            this.lbGTKH.TabIndex = 0;
            this.lbGTKH.Text = "label1";
            // 
            // lbGT
            // 
            this.lbGT.AutoSize = true;
            this.lbGT.Location = new System.Drawing.Point(259, 63);
            this.lbGT.Name = "lbGT";
            this.lbGT.Size = new System.Drawing.Size(54, 13);
            this.lbGT.TabIndex = 0;
            this.lbGT.Text = "Giới Tính:";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(369, 29);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(35, 13);
            this.lbTenKH.TabIndex = 0;
            this.lbTenKH.Text = "label1";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(259, 29);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(92, 13);
            this.lable.TabIndex = 0;
            this.lable.Text = "Tên Khách Hàng:";
            // 
            // lbTuoi
            // 
            this.lbTuoi.AutoSize = true;
            this.lbTuoi.Location = new System.Drawing.Point(127, 63);
            this.lbTuoi.Name = "lbTuoi";
            this.lbTuoi.Size = new System.Drawing.Size(35, 13);
            this.lbTuoi.TabIndex = 0;
            this.lbTuoi.Text = "label1";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(127, 29);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(35, 13);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng:";
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.MaKH,
            this.MaDV,
            this.NgayHoaDon,
            this.GiaDV,
            this.SoLuongDV,
            this.ThanhTien});
            this.dgvThongTin.Location = new System.Drawing.Point(12, 160);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.Size = new System.Drawing.Size(728, 150);
            this.dgvThongTin.TabIndex = 1;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Width = 90;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 90;
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã Dịch Vụ";
            this.MaDV.Name = "MaDV";
            this.MaDV.Width = 80;
            // 
            // NgayHoaDon
            // 
            this.NgayHoaDon.DataPropertyName = "NgayHoaDon";
            this.NgayHoaDon.HeaderText = "Ngày Hóa Đơn";
            this.NgayHoaDon.Name = "NgayHoaDon";
            this.NgayHoaDon.Width = 120;
            // 
            // GiaDV
            // 
            this.GiaDV.DataPropertyName = "GiaDV";
            this.GiaDV.HeaderText = "Giá Dịch Vụ";
            this.GiaDV.Name = "GiaDV";
            // 
            // SoLuongDV
            // 
            this.SoLuongDV.DataPropertyName = "SoLuongDV";
            this.SoLuongDV.HeaderText = "Số Lượng DV";
            this.SoLuongDV.Name = "SoLuongDV";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // frmXuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(778, 361);
            this.Controls.Add(this.dgvThongTin);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmXuatHoaDon";
            this.Text = "Xuất Hóa Đơn";
            this.Load += new System.EventHandler(this.frmXuatHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGTKH;
        private System.Windows.Forms.Label lbGT;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lbTuoi;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}