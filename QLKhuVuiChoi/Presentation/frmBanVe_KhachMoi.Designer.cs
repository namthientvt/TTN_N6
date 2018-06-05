namespace QLKhuVuiChoi.Presentation
{
    partial class frmBanVe_KhachMoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanVe_KhachMoi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbKhachHang = new System.Windows.Forms.GroupBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtTuoiKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbBanVe = new System.Windows.Forms.GroupBox();
            this.cboMaKhu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSLNguoiLon = new System.Windows.Forms.TextBox();
            this.txtSLTreEm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnBanVe = new System.Windows.Forms.Button();
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.MaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNguoiLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTreEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuoiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnInVe = new System.Windows.Forms.Button();
            this.lblTienVe = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblGiaNguoiLon = new System.Windows.Forms.Label();
            this.lblGiaTreEm = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.grbKhachHang.SuspendLayout();
            this.grbBanVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.Controls.Add(this.cboGioiTinh);
            this.grbKhachHang.Controls.Add(this.txtTuoiKH);
            this.grbKhachHang.Controls.Add(this.txtTenKH);
            this.grbKhachHang.Controls.Add(this.txtMaKH);
            this.grbKhachHang.Controls.Add(this.label6);
            this.grbKhachHang.Controls.Add(this.label4);
            this.grbKhachHang.Controls.Add(this.label3);
            this.grbKhachHang.Controls.Add(this.label2);
            this.grbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKhachHang.Location = new System.Drawing.Point(12, 14);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Size = new System.Drawing.Size(295, 257);
            this.grbKhachHang.TabIndex = 91;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "Khách Hàng";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ",
            "Khác"});
            this.cboGioiTinh.Location = new System.Drawing.Point(109, 213);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(175, 24);
            this.cboGioiTinh.TabIndex = 11;
            // 
            // txtTuoiKH
            // 
            this.txtTuoiKH.Location = new System.Drawing.Point(109, 160);
            this.txtTuoiKH.Name = "txtTuoiKH";
            this.txtTuoiKH.Size = new System.Drawing.Size(175, 22);
            this.txtTuoiKH.TabIndex = 10;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(109, 101);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(175, 22);
            this.txtTenKH.TabIndex = 9;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(109, 36);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(175, 22);
            this.txtMaKH.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tuổi KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã KH";
            // 
            // grbBanVe
            // 
            this.grbBanVe.Controls.Add(this.label14);
            this.grbBanVe.Controls.Add(this.label15);
            this.grbBanVe.Controls.Add(this.lblGiaTreEm);
            this.grbBanVe.Controls.Add(this.lblGiaNguoiLon);
            this.grbBanVe.Controls.Add(this.cboMaKhu);
            this.grbBanVe.Controls.Add(this.label1);
            this.grbBanVe.Controls.Add(this.dtpNgayBan);
            this.grbBanVe.Controls.Add(this.txtMaVe);
            this.grbBanVe.Controls.Add(this.txtThanhTien);
            this.grbBanVe.Controls.Add(this.label5);
            this.grbBanVe.Controls.Add(this.label9);
            this.grbBanVe.Controls.Add(this.label7);
            this.grbBanVe.Controls.Add(this.label8);
            this.grbBanVe.Controls.Add(this.txtSLNguoiLon);
            this.grbBanVe.Controls.Add(this.txtSLTreEm);
            this.grbBanVe.Controls.Add(this.label10);
            this.grbBanVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBanVe.Location = new System.Drawing.Point(12, 277);
            this.grbBanVe.Name = "grbBanVe";
            this.grbBanVe.Size = new System.Drawing.Size(295, 389);
            this.grbBanVe.TabIndex = 102;
            this.grbBanVe.TabStop = false;
            this.grbBanVe.Text = "Thông Tin Vé";
            // 
            // cboMaKhu
            // 
            this.cboMaKhu.FormattingEnabled = true;
            this.cboMaKhu.Location = new System.Drawing.Point(111, 81);
            this.cboMaKhu.Name = "cboMaKhu";
            this.cboMaKhu.Size = new System.Drawing.Size(175, 24);
            this.cboMaKhu.TabIndex = 113;
            this.cboMaKhu.SelectedIndexChanged += new System.EventHandler(this.cboMaKhu_SelectedIndexChanged);
            this.cboMaKhu.SelectedValueChanged += new System.EventHandler(this.cboMaKhu_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Mã Vé";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.Location = new System.Drawing.Point(111, 301);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(175, 22);
            this.dtpNgayBan.TabIndex = 112;
            // 
            // txtMaVe
            // 
            this.txtMaVe.Location = new System.Drawing.Point(111, 25);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(175, 22);
            this.txtMaVe.TabIndex = 103;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(111, 356);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(175, 22);
            this.txtThanhTien.TabIndex = 111;
            this.txtThanhTien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtThanhTien_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 104;
            this.label5.Text = "Mã Khu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = "Thành Tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "SL Người Lớn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 109;
            this.label8.Text = "Ngày Bán";
            // 
            // txtSLNguoiLon
            // 
            this.txtSLNguoiLon.Location = new System.Drawing.Point(111, 172);
            this.txtSLNguoiLon.Name = "txtSLNguoiLon";
            this.txtSLNguoiLon.Size = new System.Drawing.Size(175, 22);
            this.txtSLNguoiLon.TabIndex = 106;
            this.txtSLNguoiLon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLNguoiLon_KeyPress);
            // 
            // txtSLTreEm
            // 
            this.txtSLTreEm.Location = new System.Drawing.Point(111, 249);
            this.txtSLTreEm.Name = "txtSLTreEm";
            this.txtSLTreEm.Size = new System.Drawing.Size(175, 22);
            this.txtSLTreEm.TabIndex = 108;
            this.txtSLTreEm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLTreEm_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 107;
            this.label10.Text = "SL Trẻ Em";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(493, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 60);
            this.btnXoa.TabIndex = 118;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(592, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 60);
            this.btnLuu.TabIndex = 117;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(408, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 62);
            this.btnSua.TabIndex = 116;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(682, 19);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(72, 61);
            this.btnHuy.TabIndex = 115;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnBanVe
            // 
            this.btnBanVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBanVe.Image = ((System.Drawing.Image)(resources.GetObject("btnBanVe.Image")));
            this.btnBanVe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBanVe.Location = new System.Drawing.Point(320, 19);
            this.btnBanVe.Name = "btnBanVe";
            this.btnBanVe.Size = new System.Drawing.Size(76, 61);
            this.btnBanVe.TabIndex = 114;
            this.btnBanVe.Text = "Bán Vé";
            this.btnBanVe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBanVe.UseVisualStyleBackColor = false;
            this.btnBanVe.Click += new System.EventHandler(this.btnBanVe_Click);
            // 
            // dgvVe
            // 
            this.dgvVe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVe,
            this.MaKH1,
            this.MaKhu,
            this.SLNguoiLon,
            this.SLTreEm,
            this.NgayBan,
            this.ThanhTien1});
            this.dgvVe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvVe.Location = new System.Drawing.Point(320, 375);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.Size = new System.Drawing.Size(781, 182);
            this.dgvVe.TabIndex = 119;
            this.dgvVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVe_CellClick);
            // 
            // MaVe
            // 
            this.MaVe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaVe.DataPropertyName = "MaVe";
            this.MaVe.HeaderText = "Mã Vé";
            this.MaVe.Name = "MaVe";
            // 
            // MaKH1
            // 
            this.MaKH1.DataPropertyName = "MaKH";
            this.MaKH1.HeaderText = "Mã Khách Hàng";
            this.MaKH1.Name = "MaKH1";
            this.MaKH1.Width = 123;
            // 
            // MaKhu
            // 
            this.MaKhu.DataPropertyName = "MaKhu";
            this.MaKhu.HeaderText = "Mã Khu";
            this.MaKhu.Name = "MaKhu";
            // 
            // SLNguoiLon
            // 
            this.SLNguoiLon.DataPropertyName = "SoLuongNguoiLon";
            this.SLNguoiLon.HeaderText = "SL Người Lớn";
            this.SLNguoiLon.Name = "SLNguoiLon";
            // 
            // SLTreEm
            // 
            this.SLTreEm.DataPropertyName = "SoLuongTreEm";
            this.SLTreEm.HeaderText = "SL Trẻ Em";
            this.SLTreEm.Name = "SLTreEm";
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày Bán";
            this.NgayBan.Name = "NgayBan";
            // 
            // ThanhTien1
            // 
            this.ThanhTien1.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Format = "0,000";
            this.ThanhTien1.DefaultCellStyle = dataGridViewCellStyle6;
            this.ThanhTien1.HeaderText = "Thành Tiền";
            this.ThanhTien1.Name = "ThanhTien1";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.TuoiKH,
            this.GioiTinhKH});
            this.dgvKhachHang.Location = new System.Drawing.Point(320, 115);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(781, 226);
            this.dgvKhachHang.TabIndex = 120;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            // 
            // TuoiKH
            // 
            this.TuoiKH.DataPropertyName = "TuoiKH";
            this.TuoiKH.HeaderText = "Tuổi Khách Hàng";
            this.TuoiKH.Name = "TuoiKH";
            this.TuoiKH.Width = 200;
            // 
            // GioiTinhKH
            // 
            this.GioiTinhKH.DataPropertyName = "GioiTinhKH";
            this.GioiTinhKH.HeaderText = "Giới Tính";
            this.GioiTinhKH.Name = "GioiTinhKH";
            this.GioiTinhKH.Width = 150;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(653, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 114;
            this.label11.Text = "Thông Tin Vé";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(653, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 16);
            this.label12.TabIndex = 121;
            this.label12.Text = "Thông Tin Khách Hàng";
            // 
            // btnInVe
            // 
            this.btnInVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInVe.Image = global::QLKhuVuiChoi.Properties.Resources.if_document_print_preview_118912;
            this.btnInVe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInVe.Location = new System.Drawing.Point(1025, 19);
            this.btnInVe.Name = "btnInVe";
            this.btnInVe.Size = new System.Drawing.Size(76, 61);
            this.btnInVe.TabIndex = 122;
            this.btnInVe.Text = "In Vé";
            this.btnInVe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInVe.UseVisualStyleBackColor = false;
            this.btnInVe.Click += new System.EventHandler(this.btnInVe_Click);
            // 
            // lblTienVe
            // 
            this.lblTienVe.AutoSize = true;
            this.lblTienVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienVe.ForeColor = System.Drawing.Color.Red;
            this.lblTienVe.Location = new System.Drawing.Point(1004, 573);
            this.lblTienVe.Name = "lblTienVe";
            this.lblTienVe.Size = new System.Drawing.Size(15, 16);
            this.lblTienVe.TabIndex = 124;
            this.lblTienVe.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(892, 571);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 16);
            this.label13.TabIndex = 123;
            this.label13.Text = "Tổng Tiền Vé:";
            // 
            // lblGiaNguoiLon
            // 
            this.lblGiaNguoiLon.AutoSize = true;
            this.lblGiaNguoiLon.Location = new System.Drawing.Point(111, 146);
            this.lblGiaNguoiLon.Name = "lblGiaNguoiLon";
            this.lblGiaNguoiLon.Size = new System.Drawing.Size(49, 16);
            this.lblGiaNguoiLon.TabIndex = 114;
            this.lblGiaNguoiLon.Text = "Giá NL";
            // 
            // lblGiaTreEm
            // 
            this.lblGiaTreEm.AutoSize = true;
            this.lblGiaTreEm.Location = new System.Drawing.Point(109, 225);
            this.lblGiaTreEm.Name = "lblGiaTreEm";
            this.lblGiaTreEm.Size = new System.Drawing.Size(76, 16);
            this.lblGiaTreEm.TabIndex = 115;
            this.lblGiaTreEm.Text = "Giá Trẻ Em";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 117;
            this.label14.Text = "Giá Vé NL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 118;
            this.label15.Text = "Giá Vé TE";
            // 
            // frmBanVe_KhachMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 669);
            this.Controls.Add(this.lblTienVe);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnInVe);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grbBanVe);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.grbKhachHang);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnBanVe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBanVe_KhachMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán vé cho khách hàng tới chơi lần đầu";
            this.Load += new System.EventHandler(this.frmBanVe_KhachMoics_Load);
            this.grbKhachHang.ResumeLayout(false);
            this.grbKhachHang.PerformLayout();
            this.grbBanVe.ResumeLayout(false);
            this.grbBanVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtTuoiKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbBanVe;
        private System.Windows.Forms.ComboBox cboMaKhu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSLNguoiLon;
        private System.Windows.Forms.TextBox txtSLTreEm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnBanVe;
        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNguoiLon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTreEm;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien1;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuoiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhKH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnInVe;
        private System.Windows.Forms.Label lblTienVe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblGiaTreEm;
        private System.Windows.Forms.Label lblGiaNguoiLon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}