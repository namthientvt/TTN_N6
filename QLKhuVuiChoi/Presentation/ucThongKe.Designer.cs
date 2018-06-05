namespace QLKhuVuiChoi.Presentation
{
    partial class ucThongKe
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
            this.label10 = new System.Windows.Forms.Label();
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.MaKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLanSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDoanhThuKhu = new System.Windows.Forms.Label();
            this.cboMaKhu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongDV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongVe = new System.Windows.Forms.Label();
            this.lblTongKhach = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.adasd = new System.Windows.Forms.GroupBox();
            this.btnBieuDo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnScreenShot = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.adasd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(36, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 37);
            this.label10.TabIndex = 62;
            this.label10.Text = "Thống Kê Dữ Liệu";
            // 
            // dgvVe
            // 
            this.dgvVe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhu,
            this.TenKhu,
            this.SLVe});
            this.dgvVe.Location = new System.Drawing.Point(43, 324);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.Size = new System.Drawing.Size(506, 286);
            this.dgvVe.TabIndex = 67;
            // 
            // MaKhu
            // 
            this.MaKhu.DataPropertyName = "MaKhu";
            this.MaKhu.HeaderText = "Mã Khu";
            this.MaKhu.Name = "MaKhu";
            // 
            // TenKhu
            // 
            this.TenKhu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhu.DataPropertyName = "TenKhu";
            this.TenKhu.HeaderText = "TenKhu";
            this.TenKhu.Name = "TenKhu";
            // 
            // SLVe
            // 
            this.SLVe.DataPropertyName = "SLVe";
            this.SLVe.HeaderText = "Số Vé Bán Ra";
            this.SLVe.Name = "SLVe";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.SoLanSD});
            this.dgvDichVu.Location = new System.Drawing.Point(570, 324);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.Size = new System.Drawing.Size(498, 286);
            this.dgvDichVu.TabIndex = 68;
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã Dịch Vụ";
            this.MaDV.Name = "MaDV";
            // 
            // TenDV
            // 
            this.TenDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên Dịch Vụ";
            this.TenDV.Name = "TenDV";
            // 
            // SoLanSD
            // 
            this.SoLanSD.DataPropertyName = "SoLanSD";
            this.SoLanSD.HeaderText = "Số Lần Sử Dụng";
            this.SoLanSD.Name = "SoLanSD";
            this.SoLanSD.Width = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Thống kê số lượng vé bán ra theo từng khu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(567, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "Thống kê số lượng sử dụng dịch vụ theo từng khu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDoanhThuKhu);
            this.groupBox1.Controls.Add(this.cboMaKhu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblTongDoanhThu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTongDV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTongVe);
            this.groupBox1.Controls.Add(this.lblTongKhach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(555, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 192);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng Số";
            // 
            // lblDoanhThuKhu
            // 
            this.lblDoanhThuKhu.AutoSize = true;
            this.lblDoanhThuKhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuKhu.ForeColor = System.Drawing.Color.Red;
            this.lblDoanhThuKhu.Location = new System.Drawing.Point(244, 67);
            this.lblDoanhThuKhu.Name = "lblDoanhThuKhu";
            this.lblDoanhThuKhu.Size = new System.Drawing.Size(17, 18);
            this.lblDoanhThuKhu.TabIndex = 84;
            this.lblDoanhThuKhu.Text = "0";
            this.lblDoanhThuKhu.Click += new System.EventHandler(this.lblDoanhThuKhu_Click);
            // 
            // cboMaKhu
            // 
            this.cboMaKhu.FormattingEnabled = true;
            this.cboMaKhu.Location = new System.Drawing.Point(342, 30);
            this.cboMaKhu.Name = "cboMaKhu";
            this.cboMaKhu.Size = new System.Drawing.Size(158, 24);
            this.cboMaKhu.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(244, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 82;
            this.label6.Text = "Doanh thu khu";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(225, 7);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(10, 209);
            this.progressBar2.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(241, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 16);
            this.label7.TabIndex = 79;
            this.label7.Text = "Tổng Doanh Thu Khu Vui Choi";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(244, 127);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(17, 18);
            this.lblTongDoanhThu.TabIndex = 80;
            this.lblTongDoanhThu.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 77;
            this.label5.Text = "Lần SD Dịch Vụ";
            // 
            // lblTongDV
            // 
            this.lblTongDV.AutoSize = true;
            this.lblTongDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDV.Location = new System.Drawing.Point(178, 160);
            this.lblTongDV.Name = "lblTongDV";
            this.lblTongDV.Size = new System.Drawing.Size(16, 16);
            this.lblTongDV.TabIndex = 78;
            this.lblTongDV.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Tổng Khách Vào Chơi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tổng Vé Bán Ra";
            // 
            // lblTongVe
            // 
            this.lblTongVe.AutoSize = true;
            this.lblTongVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongVe.Location = new System.Drawing.Point(178, 97);
            this.lblTongVe.Name = "lblTongVe";
            this.lblTongVe.Size = new System.Drawing.Size(16, 16);
            this.lblTongVe.TabIndex = 76;
            this.lblTongVe.Text = "0";
            // 
            // lblTongKhach
            // 
            this.lblTongKhach.AutoSize = true;
            this.lblTongKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongKhach.Location = new System.Drawing.Point(178, 34);
            this.lblTongKhach.Name = "lblTongKhach";
            this.lblTongKhach.Size = new System.Drawing.Size(16, 16);
            this.lblTongKhach.TabIndex = 75;
            this.lblTongKhach.Text = "0";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(282, 38);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayKetThuc.TabIndex = 78;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(8, 38);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayBatDau.TabIndex = 77;
            // 
            // adasd
            // 
            this.adasd.Controls.Add(this.btnBieuDo);
            this.adasd.Controls.Add(this.pictureBox1);
            this.adasd.Controls.Add(this.dtpNgayBatDau);
            this.adasd.Controls.Add(this.btnScreenShot);
            this.adasd.Controls.Add(this.btnThongKe);
            this.adasd.Controls.Add(this.btnXuatFile);
            this.adasd.Controls.Add(this.dtpNgayKetThuc);
            this.adasd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adasd.Location = new System.Drawing.Point(43, 77);
            this.adasd.Name = "adasd";
            this.adasd.Size = new System.Drawing.Size(498, 192);
            this.adasd.TabIndex = 80;
            this.adasd.TabStop = false;
            this.adasd.Text = "Khoảng thời gian";
            // 
            // btnBieuDo
            // 
            this.btnBieuDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBieuDo.Image = global::QLKhuVuiChoi.Properties.Resources.if_piechart_1055011;
            this.btnBieuDo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBieuDo.Location = new System.Drawing.Point(114, 102);
            this.btnBieuDo.Name = "btnBieuDo";
            this.btnBieuDo.Size = new System.Drawing.Size(95, 43);
            this.btnBieuDo.TabIndex = 82;
            this.btnBieuDo.Text = "Biểu Đồ";
            this.btnBieuDo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBieuDo.UseVisualStyleBackColor = false;
            this.btnBieuDo.Click += new System.EventHandler(this.btnBieuDo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKhuVuiChoi.Properties.Resources.if_arrow_right_173148;
            this.pictureBox1.Location = new System.Drawing.Point(227, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 32);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnScreenShot.Image = global::QLKhuVuiChoi.Properties.Resources.if_7_Image_capture_34338;
            this.btnScreenShot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScreenShot.Location = new System.Drawing.Point(358, 102);
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(134, 43);
            this.btnScreenShot.TabIndex = 82;
            this.btnScreenShot.Text = "Chụp Màn Hình";
            this.btnScreenShot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScreenShot.UseVisualStyleBackColor = false;
            this.btnScreenShot.Click += new System.EventHandler(this.btnScreenShot_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThongKe.Image = global::QLKhuVuiChoi.Properties.Resources.if_Analytics_206464;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(8, 102);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(100, 43);
            this.btnThongKe.TabIndex = 79;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXuatFile.Image = global::QLKhuVuiChoi.Properties.Resources.if_excel_272697;
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(227, 102);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(125, 43);
            this.btnXuatFile.TabIndex = 81;
            this.btnXuatFile.Text = "Xuất Báo Cáo";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "image";
            this.saveFileDialog1.Filter = "PNG|*.png|JPEG|*.jpeg";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(43, 259);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(498, 10);
            this.progressBar1.TabIndex = 81;
            // 
            // ucThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.adasd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.label10);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(1103, 635);
            this.Load += new System.EventHandler(this.dgvDichVu_Load);
            this.Click += new System.EventHandler(this.ucThongKe_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.adasd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongVe;
        private System.Windows.Forms.Label lblTongKhach;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox adasd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLanSD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongDV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnScreenShot;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblDoanhThuKhu;
        private System.Windows.Forms.ComboBox cboMaKhu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button btnBieuDo;
    }
}
