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
    public partial class frmBanVe_KhachMoi : Form
    {
        public frmBanVe_KhachMoi()
        {
            InitializeComponent();
        }
        bool temp;

        public string TangMaVe()
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

        void SetNull()
        {
            //txtMaKH.Text = "";
            txtMaVe.Text = "";
            cboMaKhu.Text = "";
            txtSLNguoiLon.Text = "";
            txtSLTreEm.Text = "";
            txtThanhTien.Text = "";

            //txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtTuoiKH.Text = "";
            cboGioiTinh.Text = "";
        }

        public string TangMaKH()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from KhachHang";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "kh01";
            }
            else
            {
                int k = 0;
                ma = "kh";
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

        private void frmBanVe_KhachMoics_Load(object sender, EventArgs e)
        {
            ShowKhu();
            btnInVe.Enabled = false;
            SetNull();
            grbBanVe.Enabled = false;
            grbKhachHang.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dtpNgayBan.Enabled = false;
            
           // cboMaKhu.ValueMember = 'k01';
            DateTime t = DateTime.Now;
            string ngay = t.Year.ToString() + "-" + t.Month.ToString() + "-" + t.Day.ToString();
            DataAccess.BanVe.ngay = ngay; 

        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            SetNull();
            temp = true;
            grbBanVe.Enabled = true;
            grbKhachHang.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaKH.Text = TangMaKH();
            txtMaVe.Text = TangMaVe();
            txtMaKH.ReadOnly = true;
            txtMaVe.ReadOnly = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaKH.ReadOnly = true;
            txtMaVe.ReadOnly = true;
            temp = false;
            grbBanVe.Enabled = true;
            grbKhachHang.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnBanVe.Enabled = false;
            btnXoa.Enabled = false;

            txtTuoiKH.ReadOnly = false;
            txtTenKH.ReadOnly = false;
            cboGioiTinh.Enabled = true;
        }

        private void txtThanhTien_MouseClick(object sender, MouseEventArgs e)
        {
            ThanhTien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetNull();
            grbBanVe.Enabled = false;
            grbKhachHang.Enabled = false;
            btnSua.Enabled = true;
            btnBanVe.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        public void KetNoi()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select *from KhachHang where MaKH = '"+txtMaKH.Text.Trim()+"'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKhachHang.DataSource = dt;

            SqlCommand cmd1 = new SqlCommand("select *from Ve where MaKH = '" + txtMaKH.Text.Trim() + "'", conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvVe.DataSource = dt1;
        }

        bool BanLanDau = true;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (temp == true)
            {
                if (MessageBox.Show("Bạn có muốn bán vé " + txtMaVe.Text.Trim() + " không?", "Bán Vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BanLanDau == true)
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("SP_ThemKhachHang", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Makh", txtMaKH.Text.Trim());
                            cmd.Parameters.AddWithValue("@Tenkh", txtTenKH.Text.Trim());
                            cmd.Parameters.AddWithValue("@Tuoi", txtTuoiKH.Text.Trim());
                            cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text.Trim());
                            int temp2 = cmd.ExecuteNonQuery();

                            SqlCommand cmd1 = new SqlCommand("BanVe", conn);
                            cmd1.CommandType = CommandType.StoredProcedure;

                            cmd1.Parameters.AddWithValue("@Mave", txtMaVe.Text.Trim());
                            cmd1.Parameters.AddWithValue("@Makh", txtMaKH.Text.Trim());
                            cmd1.Parameters.AddWithValue("@Makhu", cboMaKhu.SelectedValue);
                            cmd1.Parameters.AddWithValue("@SLNL", txtSLNguoiLon.Text.Trim());
                            cmd1.Parameters.AddWithValue("@SLTE", txtSLTreEm.Text.Trim());
                            cmd1.Parameters.AddWithValue("@Ngayban", dtpNgayBan.Value);
                            cmd1.Parameters.AddWithValue("@Thanhtien", txtThanhTien.Text.Trim());

                            int temp1 = cmd1.ExecuteNonQuery();

                            if (temp2 != 0 && temp1 != 0)
                            {
                                MessageBox.Show("Đã bán!");
                                btnInVe.Enabled = true;
                                TongTien();
                                DataAccess.BanVe.MaKhachHang = txtMaKH.Text.Trim();
                                if (MessageBox.Show("Bạn có muốn tiếp tục bán vé cho khách hàng " + txtTenKH.Text.Trim() + " không?", "Tiếp Tục?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    KetNoi();

                                    cboMaKhu.Text = "";
                                    txtSLNguoiLon.Text = "";
                                    txtSLTreEm.Text = "";
                                    txtThanhTien.Text = "";

                                    txtMaKH.ReadOnly = true;
                                    txtTenKH.ReadOnly = true;
                                    txtTuoiKH.ReadOnly = true;
                                    cboGioiTinh.Enabled = false;

                                    btnLuu.Enabled = true;
                                    btnHuy.Enabled = true;
                                    btnBanVe.Enabled = false;
                                    btnSua.Enabled = false;
                                    btnXoa.Enabled = false;
                                    txtMaVe.Text = TangMaVe();
                                    BanLanDau = false;
                                }
                                else
                                {
                                    KetNoi();
                                    SetNull();
                                    btnLuu.Enabled = false;
                                    btnHuy.Enabled = false;
                                    btnBanVe.Enabled = false;
                                    btnSua.Enabled = true;
                                    btnXoa.Enabled = true;
                                    grbBanVe.Enabled = false;
                                    grbKhachHang.Enabled = false;
                                    
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không bán được! " + ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                            conn.Open();

                            SqlCommand cmd1 = new SqlCommand("BanVe", conn);
                            cmd1.CommandType = CommandType.StoredProcedure;

                            cmd1.Parameters.AddWithValue("@Mave", txtMaVe.Text.Trim());
                            cmd1.Parameters.AddWithValue("@Makh", txtMaKH.Text.Trim());
                            cmd1.Parameters.AddWithValue("@Makhu", cboMaKhu.SelectedValue);
                            cmd1.Parameters.AddWithValue("@SLNL", txtSLNguoiLon.Text.Trim());
                            cmd1.Parameters.AddWithValue("@SLTE", txtSLTreEm.Text.Trim());
                            cmd1.Parameters.AddWithValue("@Ngayban", dtpNgayBan.Value);
                            cmd1.Parameters.AddWithValue("@Thanhtien", txtThanhTien.Text.Trim());

                            int temp1 = cmd1.ExecuteNonQuery();

                            if (temp1 != 0)
                            {
                                MessageBox.Show("Đã bán!");
                                TongTien();
                                if (MessageBox.Show("Bạn có muốn tiếp tục bán vé cho khách hàng " + txtTenKH.Text.Trim() + " không?", "Tiếp Tục?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    KetNoi();

                                    cboMaKhu.Text = "";
                                    txtSLNguoiLon.Text = "";
                                    txtSLTreEm.Text = "";
                                    txtThanhTien.Text = "";

                                    txtMaKH.ReadOnly = true;
                                    txtTuoiKH.ReadOnly = true;
                                    txtTenKH.ReadOnly = true;
                                    cboGioiTinh.Enabled = false;

                                    btnLuu.Enabled = true;
                                    btnHuy.Enabled = true;
                                    btnBanVe.Enabled = false;
                                    btnSua.Enabled = false;
                                    btnXoa.Enabled = false;
                                    txtMaVe.Text = TangMaVe();
                                    BanLanDau = false;
                                }
                                else
                                {
                                    KetNoi();
                                    SetNull();
                                    btnLuu.Enabled = false;
                                    btnHuy.Enabled = false;
                                    btnBanVe.Enabled = false;
                                    btnSua.Enabled = true;
                                    btnXoa.Enabled = true;
                                    grbBanVe.Enabled = false;
                                    grbKhachHang.Enabled = false;

                                    txtMaKH.ReadOnly = false;
                                    txtTuoiKH.ReadOnly = false;
                                    txtTenKH.ReadOnly = false;
                                    cboGioiTinh.Enabled = true;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không bán được! " + ex.Message);
                        }
                    }
                }
            }
            else
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

                int temp3 = cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("SP_SuaKhachHang", conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@Makh", txtMaKH.Text.Trim());
                cmd1.Parameters.AddWithValue("@Tenkh", txtTenKH.Text.Trim());
                cmd1.Parameters.AddWithValue("@Tuoi", txtTuoiKH.Text.Trim());
                cmd1.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text.Trim());
                int temp4 = cmd1.ExecuteNonQuery();


                if (temp3 != 0 && temp4 != 0)
                {
                    MessageBox.Show("Đã lưu thay đổi!");
                    KetNoi();
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    grbBanVe.Enabled = false;
                    grbKhachHang.Enabled = false;
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaKH.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["MaKH"].Value);
                txtTenKH.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["TenKH"].Value);
                txtTuoiKH.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["TuoiKH"].Value);
                cboGioiTinh.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["GioiTinhKH"].Value);
            }
        }

        private void dgvVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaKH.Text = Convert.ToString(dgvVe.CurrentRow.Cells["MaKH1"].Value);
                txtMaVe.Text = Convert.ToString(dgvVe.CurrentRow.Cells["MaVe"].Value);
                cboMaKhu.Text = Convert.ToString(dgvVe.CurrentRow.Cells["MaKhu"].Value);
                txtSLNguoiLon.Text = Convert.ToString(dgvVe.CurrentRow.Cells["SLNguoiLon"].Value);
                txtSLTreEm.Text = Convert.ToString(dgvVe.CurrentRow.Cells["SLTreEm"].Value);
                dtpNgayBan.Text = Convert.ToString(dgvVe.CurrentRow.Cells["NgayBan"].Value);
                txtThanhTien.Text = Convert.ToString(dgvVe.CurrentRow.Cells["ThanhTien1"].Value);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa " + txtTenKH.Text.Trim() + " khỏi CSDL không?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_Del_KH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Makh", txtMaKH.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa!");
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    KetNoi();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được! " + ex.Message);
            }
        }

        private void btnInVe_Click(object sender, EventArgs e)
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

        public string DinhDangTien(string DauVao)
        {
            int temp = Convert.ToInt32(DauVao);
            string daura = "";

            if (temp >= 100000 && temp < 999999)
            {
                string sodau = DauVao.Substring(0, 3);
                string basosau1 = DauVao.Substring(3, 3);
                daura = sodau + "." + basosau1;
            }

            if (temp >= 1000000 && temp < 9999999)
            {
                string sodau = DauVao.ToString().Substring(0, 1);
                string basosau1 = DauVao.ToString().Substring(1, 3);
                string basosau2 = DauVao.ToString().Substring(4, 3);
                daura = sodau + "." + basosau1 + "." + basosau2;
            }

            if (temp >= 10000000 && temp < 99999999)
            {
                string sodau = DauVao.Substring(0, 2);
                string basosau1 = DauVao.Substring(2, 3);
                string basosau2 = DauVao.Substring(5, 3);
                daura = sodau + "." + basosau1 + "." + basosau2;
            }

            return daura;
        }

        private void TongTien()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TongTienKH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lblTienVe.Text = DinhDangTien(dt.Rows[0][1].ToString()) + " (VND)";
        }

        int temp1=0;
        private void cboMaKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp1 ++;
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
            //MessageBox.Show("tes");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void cboMaKhu_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

    }
}
