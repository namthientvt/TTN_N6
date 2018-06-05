namespace QLKhuVuiChoi.Presentation
{
    partial class ucBanVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBanVe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MaKH = new System.Windows.Forms.Label();
            this.txtMaKHCu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBanVe_KhachCu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBanVe_KhachMoi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboKieuTK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaVe_SuaXoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cboMaKhu = new System.Windows.Forms.ComboBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSLTreEm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSLNguoiLon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNguoiLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTreEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MaKH
            // 
            this.MaKH.AutoSize = true;
            this.MaKH.Location = new System.Drawing.Point(24, 32);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(85, 13);
            this.MaKH.TabIndex = 0;
            this.MaKH.Text = "Mã Khách Hàng";
            // 
            // txtMaKHCu
            // 
            this.txtMaKHCu.Location = new System.Drawing.Point(115, 29);
            this.txtMaKHCu.Name = "txtMaKHCu";
            this.txtMaKHCu.Size = new System.Drawing.Size(184, 20);
            this.txtMaKHCu.TabIndex = 1;
            this.txtMaKHCu.TextChanged += new System.EventHandler(this.txtMaKHCu_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKHCu);
            this.groupBox1.Controls.Add(this.MaKH);
            this.groupBox1.Controls.Add(this.btnBanVe_KhachCu);
            this.groupBox1.Location = new System.Drawing.Point(3, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 185);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách Hàng Cũ";
            // 
            // btnBanVe_KhachCu
            // 
            this.btnBanVe_KhachCu.BackColor = System.Drawing.Color.White;
            this.btnBanVe_KhachCu.Image = global::QLKhuVuiChoi.Properties.Resources.if_emblem_people_24702;
            this.btnBanVe_KhachCu.Location = new System.Drawing.Point(162, 61);
            this.btnBanVe_KhachCu.Name = "btnBanVe_KhachCu";
            this.btnBanVe_KhachCu.Size = new System.Drawing.Size(91, 118);
            this.btnBanVe_KhachCu.TabIndex = 2;
            this.btnBanVe_KhachCu.Text = "Khách Cũ";
            this.btnBanVe_KhachCu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBanVe_KhachCu.UseVisualStyleBackColor = false;
            this.btnBanVe_KhachCu.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnBanVe_KhachMoi);
            this.groupBox2.Location = new System.Drawing.Point(454, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 185);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khách Hàng Mới";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Bán vé cho khách hàng lần đầu tới chơi";
            // 
            // btnBanVe_KhachMoi
            // 
            this.btnBanVe_KhachMoi.BackColor = System.Drawing.Color.White;
            this.btnBanVe_KhachMoi.Image = global::QLKhuVuiChoi.Properties.Resources.if_contact_new_23203;
            this.btnBanVe_KhachMoi.Location = new System.Drawing.Point(117, 58);
            this.btnBanVe_KhachMoi.Name = "btnBanVe_KhachMoi";
            this.btnBanVe_KhachMoi.Size = new System.Drawing.Size(91, 121);
            this.btnBanVe_KhachMoi.TabIndex = 3;
            this.btnBanVe_KhachMoi.Text = "Khách Mới";
            this.btnBanVe_KhachMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBanVe_KhachMoi.UseVisualStyleBackColor = false;
            this.btnBanVe_KhachMoi.Click += new System.EventHandler(this.btnBanVe_KhachMoi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Controls.Add(this.cboKieuTK);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(789, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 93);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Công cụ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(209, 45);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 36);
            this.btnTimKiem.TabIndex = 83;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(104, 61);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(102, 20);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cboKieuTK
            // 
            this.cboKieuTK.FormattingEnabled = true;
            this.cboKieuTK.Items.AddRange(new object[] {
            "Theo Mã Vé",
            "Theo Mã Khách Hàng",
            "Theo Mã Khu"});
            this.cboKieuTK.Location = new System.Drawing.Point(104, 19);
            this.cboKieuTK.Name = "cboKieuTK";
            this.cboKieuTK.Size = new System.Drawing.Size(201, 21);
            this.cboKieuTK.TabIndex = 1;
            this.cboKieuTK.SelectedIndexChanged += new System.EventHandler(this.cboKieuTK_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiểu Tìm Kiếm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMaVe_SuaXoa);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Location = new System.Drawing.Point(789, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 92);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // txtMaVe_SuaXoa
            // 
            this.txtMaVe_SuaXoa.Location = new System.Drawing.Point(104, 15);
            this.txtMaVe_SuaXoa.Name = "txtMaVe_SuaXoa";
            this.txtMaVe_SuaXoa.Size = new System.Drawing.Size(195, 20);
            this.txtMaVe_SuaXoa.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Mã Vé";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(193, 44);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 42);
            this.btnRefresh.TabIndex = 86;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(104, 44);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 42);
            this.btnXoa.TabIndex = 85;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cboMaKhu);
            this.grbThongTin.Controls.Add(this.dtpNgayBan);
            this.grbThongTin.Controls.Add(this.txtThanhTien);
            this.grbThongTin.Controls.Add(this.label9);
            this.grbThongTin.Controls.Add(this.label8);
            this.grbThongTin.Controls.Add(this.txtSLTreEm);
            this.grbThongTin.Controls.Add(this.label7);
            this.grbThongTin.Controls.Add(this.txtSLNguoiLon);
            this.grbThongTin.Controls.Add(this.label6);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.txtMaVe);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.txtMaKH);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Location = new System.Drawing.Point(789, 219);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(305, 401);
            this.grbThongTin.TabIndex = 8;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // cboMaKhu
            // 
            this.cboMaKhu.FormattingEnabled = true;
            this.cboMaKhu.Location = new System.Drawing.Point(117, 146);
            this.cboMaKhu.Name = "cboMaKhu";
            this.cboMaKhu.Size = new System.Drawing.Size(182, 21);
            this.cboMaKhu.TabIndex = 17;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.Location = new System.Drawing.Point(117, 312);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(182, 20);
            this.dtpNgayBan.TabIndex = 16;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(117, 362);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(182, 20);
            this.txtThanhTien.TabIndex = 15;
            this.txtThanhTien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtThanhTien_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Thành Tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày Bán";
            // 
            // txtSLTreEm
            // 
            this.txtSLTreEm.Location = new System.Drawing.Point(117, 258);
            this.txtSLTreEm.Name = "txtSLTreEm";
            this.txtSLTreEm.Size = new System.Drawing.Size(182, 20);
            this.txtSLTreEm.TabIndex = 11;
            this.txtSLTreEm.MouseLeave += new System.EventHandler(this.txtSLTreEm_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "SL Trẻ Em";
            // 
            // txtSLNguoiLon
            // 
            this.txtSLNguoiLon.Location = new System.Drawing.Point(117, 202);
            this.txtSLNguoiLon.Name = "txtSLNguoiLon";
            this.txtSLNguoiLon.Size = new System.Drawing.Size(182, 20);
            this.txtSLNguoiLon.TabIndex = 9;
            this.txtSLNguoiLon.MouseLeave += new System.EventHandler(this.txtSLNguoiLon_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "SL Người Lớn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã Khu";
            // 
            // txtMaVe
            // 
            this.txtMaVe.Location = new System.Drawing.Point(117, 35);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(182, 20);
            this.txtMaVe.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Vé";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(117, 91);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(182, 20);
            this.txtMaKH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // dgvVe
            // 
            this.dgvVe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaVe,
            this.MaKH1,
            this.MaKhu,
            this.SLNguoiLon,
            this.SLTreEm,
            this.NgayBan,
            this.ThanhTien1});
            this.dgvVe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvVe.Location = new System.Drawing.Point(3, 219);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.Size = new System.Drawing.Size(766, 401);
            this.dgvVe.TabIndex = 10;
            this.dgvVe.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvVe_RowPrePaint);
            this.dgvVe.SelectionChanged += new System.EventHandler(this.dgvVe_SelectionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 30;
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
            dataGridViewCellStyle1.Format = "0,000";
            dataGridViewCellStyle1.NullValue = "0";
            this.ThanhTien1.DefaultCellStyle = dataGridViewCellStyle1;
            this.ThanhTien1.HeaderText = "Thành Tiền";
            this.ThanhTien1.Name = "ThanhTien1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::QLKhuVuiChoi.Properties.Resources.if_arrow_point_arrow_214665;
            this.pictureBox1.Location = new System.Drawing.Point(381, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 54);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ucBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucBanVe";
            this.Size = new System.Drawing.Size(1097, 631);
            this.Load += new System.EventHandler(this.ucBanVe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBanVe_KhachCu;
        private System.Windows.Forms.TextBox txtMaKHCu;
        private System.Windows.Forms.Label MaKH;
        private System.Windows.Forms.Button btnBanVe_KhachMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboKieuTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMaVe_SuaXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSLTreEm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSLNguoiLon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaKhu;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNguoiLon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTreEm;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien1;
        //      private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}
