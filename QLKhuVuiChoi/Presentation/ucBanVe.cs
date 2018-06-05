using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKhuVuiChoi.Presentation
{
    public partial class ucBanVe : UserControl
    {
        public ucBanVe()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (txtMaKHCu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng!");
                ActiveControl = txtMaKHCu;
                return;
            }

            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from KhachHang where MaKH= '"+txtMaKHCu.Text.Trim()+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataAccess.BanVe.MaKhachHang = txtMaKHCu.Text.Trim();
                frmBanVe_KhachCu kc = new frmBanVe_KhachCu();
                kc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng này trong CSDL!");
            }

        }

        private void ucBanVe_Load(object sender, EventArgs e)
        {
            ShowKhu();
            grbThongTin.Enabled = false;
            KetNoi();
            LoadData();
        }

        private void ThanhTien()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("XemGia", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Mave", txtMaVe.Text.Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            int sltreem = Convert.ToInt32(txtSLTreEm.Text);
            int slnguoilon = Convert.ToInt32(txtSLNguoiLon.Text);
            int givetrem = Convert.ToInt32(dt.Rows[0][0].ToString());
            int givenguoilon = Convert.ToInt32(dt.Rows[0][1].ToString());

            int thanhtien = sltreem*givetrem + slnguoilon*givenguoilon ;

            txtThanhTien.Text = thanhtien.ToString();
        }

        public void KetNoi()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from Ve";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvVe.DataSource = dt;
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

        private void LoadData()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dgvVe.DataSource, "MaKH");

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

        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    grbThongTin.Enabled = true;
        //    btnLuu.Enabled = true;
        //    btnHuy.Enabled = true;
        //    btnXoa.Enabled = false;
        //}

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaVe_SuaXoa.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã vé cần xóa!");
                ActiveControl = txtMaVe_SuaXoa;
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa mã vé " + txtMaVe_SuaXoa.Text.Trim() + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Delete Ve where MaVe = @Mave", conn);
                    //cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Mave", txtMaVe_SuaXoa.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa!");
                    KetNoi();
                    LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            KetNoi();
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
            grbThongTin.Enabled = false;
            
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Sua_Ve", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Mave", txtMaVe.Text.Trim());
            cmd.Parameters.Add("@Makh", txtMaKH.Text.Trim());
            cmd.Parameters.Add("@Makhu", cboMaKhu.SelectedValue);
            cmd.Parameters.Add("@SLTreEm", txtSLTreEm.Text.Trim());
            cmd.Parameters.Add("@SLNguoiLon", txtSLNguoiLon.Text.Trim());
            cmd.Parameters.Add("@NgayBan", dtpNgayBan.Value);
            cmd.Parameters.Add("@Thanhtien", txtThanhTien.Text.Trim());

            int temp = cmd.ExecuteNonQuery();

            if (temp != 0)
            {
                MessageBox.Show("Đã lưu thay đổi!");
                KetNoi();
                LoadData();
                
                btnXoa.Enabled = true;
               
                grbThongTin.Enabled = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                if (cboKieuTK.Text == "Theo Mã Vé")
                {
                    sql = "select *from Ve where MaVe = '" + txtTimKiem.Text.Trim() + "'";

                }
                else if (cboKieuTK.Text == "Theo Mã Khách Hàng")
                {
                    sql = "select *from Ve where MaKH = '" + txtTimKiem.Text.Trim() + "'";
                }
                else if (cboKieuTK.Text == "Theo Mã Khu")
                {
                    sql = "select *from Ve where MaKhu = '" + txtTimKiem.Text.Trim() + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboKieuTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(null, null);
        }

        private void txtThanhTien_MouseClick(object sender, MouseEventArgs e)
        {
            ThanhTien();
        }

        private void txtSLNguoiLon_MouseLeave(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void txtSLTreEm_MouseLeave(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void txtMaKHCu_TextChanged(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                sql = "select *from Ve where MaKH = '" + txtMaKHCu.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBanVe_KhachMoi_Click(object sender, EventArgs e)
        {
            frmBanVe_KhachMoi km = new frmBanVe_KhachMoi();
            km.ShowDialog();
        }

        private void dgvVe_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvVe.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }

        private void dgvVe_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvVe.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }




    }
}
