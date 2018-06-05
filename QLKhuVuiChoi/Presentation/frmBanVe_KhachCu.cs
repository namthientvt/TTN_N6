using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKhuVuiChoi.Presentation
{
    public partial class frmBanVe_KhachCu : Form
    {
        public frmBanVe_KhachCu()
        {
            InitializeComponent();
        }
        bool temp = false;
        public string TangMa()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from Ve";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "mv01";
            }
            else
            {
                int k = 0;
                ma = "mv";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }

            return ma;
        }

        private void ThanhTien()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select GiaVeTreEm, GiaVeNguoiLon from KhuTroChoi where MaKhu = '" + cboMaKhu.SelectedValue + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            int sltreem = Convert.ToInt32(txtSLTreEm.Text);
            int slnguoilon = Convert.ToInt32(txtSLNguoiLon.Text);
            int givetrem = Convert.ToInt32(dt.Rows[0][0].ToString());
            int givenguoilon = Convert.ToInt32(dt.Rows[0][1].ToString());

            int thanhtien = sltreem * givetrem + slnguoilon * givenguoilon;

            txtThanhTien.Text = thanhtien.ToString();
        }

        public void KetNoi()
        {
            lblMaKH.Text = DataAccess.BanVe.MaKhachHang;

            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from Ve where MaKH = '"+lblMaKH.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvVe.DataSource = dt;

            string sql1 = "select *from KhuTroChoi";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvKhuTroChoi.DataSource = dt1;

            ShowThongTinKH();
            ShowKhu();
        }

        private void LoadData()
        {
            //txtMaKH.DataBindings.Clear();
            //txtMaKH.DataBindings.Add("Text", dgvVe.DataSource, "MaKH");

            txtMaVe.DataBindings.Clear();
            txtMaVe.DataBindings.Add("Text", dgvVe.DataSource, "MaVe");

            cboMaKhu.DataBindings.Clear();
            cboMaKhu.DataBindings.Add("Text", dgvVe.DataSource, "MaKhu");

            txtSLNguoiLon.DataBindings.Clear();
            txtSLNguoiLon.DataBindings.Add("Text", dgvVe.DataSource, "SoLuongNguoiLon");

            txtSLTreEm.DataBindings.Clear();
            txtSLTreEm.DataBindings.Add("Text", dgvVe.DataSource, "SoLuongTreEm");

            dtpNgayBan.DataBindings.Clear();
            dtpNgayBan.DataBindings.Add("Text", dgvVe.DataSource, "NgayBan");

            txtThanhTien.DataBindings.Clear();
            txtThanhTien.DataBindings.Add("Text", dgvVe.DataSource, "ThanhTien");
        }
        public void ShowKhu()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaKhu, TenKhu from KhuTroChoi", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboMaKhu.DataSource = dt;
            cboMaKhu.DisplayMember = "TenKhu";
            cboMaKhu.ValueMember = "MaKhu";
        }

        public void ShowThongTinKH()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select TenKH,TuoiKH, GioiTinhKH from KhachHang where MaKH = '" + lblMaKH.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lblTenKH.Text = dt.Rows[0][0].ToString();
            lblTuoiKH.Text = dt.Rows[0][1].ToString();
            lblGioiTinh.Text = dt.Rows[0][2].ToString();
        }

        private void frmBanVe_KhachCu_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            grbBanVe.Enabled = false;
            txtMaVe.ReadOnly = true;
            //dtpNgayBan.Enabled = false;
            DateTime t = DateTime.Now;
            string ngay = t.Year.ToString() + "-" + t.Month.ToString() + "-" + t.Day.ToString();
            DataAccess.BanVe.ngay = ngay;
            //btnInVe.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cboMaKhu.Text = "";
            txtSLNguoiLon.Text = "";
            txtSLTreEm.Text = "";
            txtSLTreEm.Text = "";
            grbBanVe.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnBanVe.Enabled = true;
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            dtpNgayBan.Value = t;
            temp = true;
            txtMaVe.Text = TangMa();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            grbBanVe.Enabled = true;
            txtSLNguoiLon.Text = "";
            txtSLTreEm.Text = "";
            txtThanhTien.Text = "";
            cboMaKhu.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn bán vé " + txtMaVe.Text.Trim() + " không?", "Bán Vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("BanVe", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Mave", txtMaVe.Text.Trim());
                    cmd.Parameters.AddWithValue("@Makh", lblMaKH.Text);
                    cmd.Parameters.AddWithValue("@Makhu", cboMaKhu.SelectedValue);
                    cmd.Parameters.AddWithValue("@SLNL", txtSLNguoiLon.Text.Trim());
                    cmd.Parameters.AddWithValue("@SLTE", txtSLTreEm.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ngayban", dtpNgayBan.Value);
                    cmd.Parameters.AddWithValue("@Thanhtien", txtThanhTien.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã Bán!");
                    KetNoi();
                    LoadData();
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    grbBanVe.Enabled = false;
                    //btnInVe.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa mã vé " + txtMaVe.Text.Trim() + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete ve where MaVe = '"+txtMaVe.Text.Trim()+"'", conn);
                    cmd.ExecuteNonQuery();

                    KetNoi();
                    LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                temp = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnBanVe.Enabled = false;
                grbBanVe.Enabled = true;
        }

        private void txtThanhTien_Click(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void frmInVe_Click(object sender, EventArgs e)
        {
            DataAccess.BanVe.MaVe = txtMaVe.Text.Trim();
            this.Hide();
            frmInVe ve = new frmInVe();
            ve.ShowDialog();
            this.Show();
        }

        private void txtSLNguoiLon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSLTreEm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        int temp1 = 0;
        private void cboMaKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp1++;
            if (temp1 > 2)
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("GiaVeVaoKhu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKhu", cboMaKhu.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //dgvKhachHang.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    lblGiaNguoiLon.Text = dt.Rows[0][0].ToString();
                    lblGiaTreEm.Text = dt.Rows[0][1].ToString();
                }
            }
        }
    }
}
