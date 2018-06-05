using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLKhuVuiChoi.Presentation
{
    public partial class ucDashboard : MetroFramework.Controls.MetroUserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        private void mttPhongBan_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucPhongBan"))
            {
                ucPhongBan uc = new ucPhongBan();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucPhongBan"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mttNhanVien_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucNhanVien"))
            {
                ucNhanVien uc = new ucNhanVien();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucNhanVien"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (DataAccess.Quyen.MaQuyen == "1")
            {    
                lblTenQuyen.Text = "Đăng nhập với quyền: Admin";
            }
            if (DataAccess.Quyen.MaQuyen == "2")
            {
                lblTenQuyen.Text = "Đăng nhập với quyền: Nhân Viên";
                mttPhongBan.Enabled = false;
                mttDangKyTaiKhoan.Enabled = false;
            }
        }

        private void mttDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất k?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                frmLogin l = new frmLogin();
                l.ShowDialog();
            }
        }

        private void mttNguoiChoi_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucKhachHang"))
            {
                ucKhachHang uc = new ucKhachHang();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucKhachHang"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mttBanVe_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucBanVe"))
            {
                ucBanVe uc = new ucBanVe();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucBanVe"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void mttTroChoi_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucTroChoi"))
            {
                ucTroChoi uc = new ucTroChoi();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucTroChoi"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mttThietBi_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucThietBi"))
            {
                ucThietBi uc = new ucThietBi();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucThietBi"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mttKhuTroChoi_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucKhuTroChoi"))
            {
                ucKhuTroChoi uc = new ucKhuTroChoi();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucKhuTroChoi"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mttDichVu_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucDichVu"))
            {
                ucDichVu uc = new ucDichVu();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucDichVu"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mttThongKe_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucThongKe"))
            {
                ucThongKe uc = new ucThongKe();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucThongKe"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mttGioiThieu_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucGioiThieu"))
            {
                ucGioiThieu uc = new ucGioiThieu();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucGioiThieu"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void frmDoanhThu_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucDoanhThu"))
            {
                ucDoanhThu uc = new ucDoanhThu();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucDoanhThu"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void cboMauChuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMauChuDe.Text == "SlateGray")
            {
                cboMauChuDe.BackColor =  Color.SlateGray;
                mttPhongBan.BackColor = Color.SlateGray;
                mttNhanVien.BackColor = Color.SlateGray;
                mttLuong.BackColor = Color.SlateGray;
                mttDangKyTaiKhoan.BackColor = Color.SlateGray;
                mttDangXuat.BackColor = Color.SlateGray;
                mttKhachHang.BackColor = Color.SlateGray;
                mttKhuTroChoi.BackColor = Color.SlateGray;
                mttTroChoi.BackColor = Color.SlateGray;
                mttDichVu.BackColor = Color.SlateGray;
                mttThietBi.BackColor = Color.SlateGray;
                mttBanVe.BackColor = Color.SlateGray;
                mttDoanhThu.BackColor = Color.SlateGray;
                mttHoaDon.BackColor = Color.SlateGray;
                mttThongKe.BackColor = Color.SlateGray;
                mttGioiThieu.BackColor = Color.SlateGray;
                mttWebBrowser.BackColor = Color.SlateGray;
                mttPhatNhac.BackColor = Color.SlateGray;
            }
            if(cboMauChuDe.Text == "Blue")
            {
                cboMauChuDe.BackColor = Color.Blue;
                mttPhongBan.BackColor = Color.Blue;
                mttNhanVien.BackColor = Color.Blue;
                mttLuong.BackColor = Color.Blue;
                mttDangKyTaiKhoan.BackColor = Color.Blue;
                mttDangXuat.BackColor = Color.Blue;
                mttKhachHang.BackColor = Color.Blue;
                mttKhuTroChoi.BackColor = Color.Blue;
                mttTroChoi.BackColor = Color.Blue;
                mttDichVu.BackColor = Color.Blue;
                mttThietBi.BackColor = Color.Blue;
                mttBanVe.BackColor = Color.Blue;
                mttDoanhThu.BackColor = Color.Blue;
                mttHoaDon.BackColor = Color.Blue;
                mttThongKe.BackColor = Color.Blue;
                mttGioiThieu.BackColor = Color.Blue;
                mttWebBrowser.BackColor = Color.Blue;
                mttPhatNhac.BackColor = Color.Blue;
            }

            if (cboMauChuDe.Text == "RoyalBlue")
            {
                cboMauChuDe.BackColor = Color.RoyalBlue;
                mttPhongBan.BackColor = Color.RoyalBlue;
                mttNhanVien.BackColor = Color.RoyalBlue;
                mttLuong.BackColor = Color.RoyalBlue;
                mttDangKyTaiKhoan.BackColor = Color.RoyalBlue;
                mttDangXuat.BackColor = Color.RoyalBlue;
                mttKhachHang.BackColor = Color.RoyalBlue;
                mttKhuTroChoi.BackColor = Color.RoyalBlue;
                mttTroChoi.BackColor = Color.RoyalBlue;
                mttDichVu.BackColor = Color.RoyalBlue;
                mttThietBi.BackColor = Color.RoyalBlue;
                mttBanVe.BackColor = Color.RoyalBlue;
                mttDoanhThu.BackColor = Color.RoyalBlue;
                mttHoaDon.BackColor = Color.RoyalBlue;
                mttThongKe.BackColor = Color.RoyalBlue;
                mttGioiThieu.BackColor = Color.RoyalBlue;
                mttWebBrowser.BackColor = Color.RoyalBlue;
                mttPhatNhac.BackColor = Color.RoyalBlue;
            }

            if (cboMauChuDe.Text == "Green")
            {
                cboMauChuDe.BackColor = Color.Green;
                mttPhongBan.BackColor = Color.Green;
                mttNhanVien.BackColor = Color.Green;
                mttLuong.BackColor = Color.Green;
                mttDangKyTaiKhoan.BackColor = Color.Green;
                mttDangXuat.BackColor = Color.Green;
                mttKhachHang.BackColor = Color.Green;
                mttKhuTroChoi.BackColor = Color.Green;
                mttTroChoi.BackColor = Color.Green;
                mttDichVu.BackColor = Color.Green;
                mttThietBi.BackColor = Color.Green;
                mttBanVe.BackColor = Color.Green;
                mttDoanhThu.BackColor = Color.Green;
                mttHoaDon.BackColor = Color.Green;
                mttThongKe.BackColor = Color.Green;
                mttGioiThieu.BackColor = Color.Green;
                mttWebBrowser.BackColor = Color.Green;
                mttPhatNhac.BackColor = Color.Green;
            }

        }

        private void mttLuong_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucLuong"))
            {
                ucLuong uc = new ucLuong();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucLuong"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mttWebBrowser_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucWebBrowser"))
            {
                ucWebBrowser uc = new ucWebBrowser();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucWebBrowser"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mttPhatNhac_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucMedia"))
            {
                ucMedia uc = new ucMedia();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucMedia"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mttHoaDon_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucHoaDon"))
            {
                ucHoaDon uc = new ucHoaDon();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucHoaDon"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mttDangKyTaiKhoan_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucCreatAcc"))
            {
                ucCreatAcc uc = new ucCreatAcc();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }

            frmMain.Instance.MetroContainer.Controls["ucCreatAcc"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }
    }
}
