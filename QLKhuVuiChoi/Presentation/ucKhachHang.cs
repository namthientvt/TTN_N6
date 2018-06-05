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
    public partial class ucKhachHang : UserControl
    {
        public ucKhachHang()
        {
            InitializeComponent();
        }

        public string TangMa()
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

        public void KetNoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                string sql = "select *from KhachHang";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataView dv = new DataView(dt);

                dgvKhachHang.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadData()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dgvKhachHang.DataSource, "MaKH");

            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dgvKhachHang.DataSource, "TenKH");

            txtTuoiKH.DataBindings.Clear();
            txtTuoiKH.DataBindings.Add("Text", dgvKhachHang.DataSource, "TuoiKH");

            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", dgvKhachHang.DataSource, "GioiTinhKH");
        }

        private void ucKhachHang_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
            LockControl();
        }

        public void LockControl()
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtTuoiKH.Enabled = false;
            cboGioiTinh.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        public void unLockControl()
        {
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtTuoiKH.Enabled = true;
            cboGioiTinh.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        public void setnull()
        {
            //txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtTuoiKH.Text = "";
            cboGioiTinh.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TangMa();
            unLockControl();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMaKH.Text = TangMa();
            setnull();
            dgvKhachHang.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            unLockControl();
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
            cboGioiTinh.Text = "";
            txtTimKiem.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setnull();
            LockControl();
            dgvKhachHang.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_SuaKhachHang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Makh", txtMaKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tenkh", txtTenKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tuoi", txtTuoiKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã sửa");
                    KetNoi();
                    LoadData();
                    LockControl();
                    btnXoa.Enabled = true;
                    dgvKhachHang.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không sửa được!" + ex.Message);
                }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa khách hàng " + txtTenKH.Text.Trim() + " không?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Delete KhachHang where MaKH = @Makh", conn);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Makh", txtMaKH.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa!");
                    KetNoi();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được! " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "";

            if (cbbKieuTK.Text == "Theo Mã Khách Hàng")
            {
                sql = "select *from KhachHang where MaKH = '" + txtTimKiem.Text.Trim() + "'";
            }
            else if (cbbKieuTK.Text == "Theo Tên Khách Hàng")
            {
                sql = "select *from KhachHang where TenKH like N'%" + txtTimKiem.Text.Trim() + "%'";
            }
            else if (cbbKieuTK.Text == "Theo Giới Tính")
            {
                sql = "select *from KhachHang where GioiTinh = '" + txtTimKiem.Text.Trim() + "'";
            }

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKhachHang.DataSource = dt;
        }

        private void cbbKieuTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnThem_Click(null, null);
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvKhachHang.CurrentRow.Selected = true; 
            }
            catch
            {

            }
        }

        public void LoadDataKH()
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                string sql = "select *from KhachHang where MaKH = '"+txtMaKH.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lblMaKH.Text = dt.Rows[0][0].ToString();
                lblTenKH.Text = dt.Rows[0][1].ToString();
                lblTuoi.Text = dt.Rows[0][2].ToString();
                lblGioiTinh.Text = dt.Rows[0][3].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TongTien()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TongTienKH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
            //cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //int dem = dt.Columns.Count;
            //MessageBox.Show("" + dem);

            if (dt.Rows[0][0].ToString() != "")
            {
                lblTienDV.Text = DinhDangTien(dt.Rows[0][0].ToString()) + " (VND)";
                lblTienVe.Text = DinhDangTien(dt.Rows[0][1].ToString()) + " (VND)";
                lblThanhTien.Text = DinhDangTien(dt.Rows[0][2].ToString()) + " (VND)";
            }
            else
            {
                lblTienDV.Text = "0";
                lblTienVe.Text = DinhDangTien(dt.Rows[0][1].ToString()) + " (VND)";
                lblThanhTien.Text = DinhDangTien(dt.Rows[0][2].ToString()) + " (VND)";
            }

            //int dem = dt.Columns.Count;

        }

        private void MaVe_KH()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("VeKH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string temp_mave = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                temp_mave = temp_mave + dt.Rows[i][0].ToString() + "  ";
            }

            lblMaVe.Text = temp_mave;
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

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            progressBar2.Value = 20;
            TongTien();
            progressBar2.Value = 50;
            MaVe_KH();
            progressBar2.Value = 70;
            LoadDataKH();
            progressBar2.Value = 100;
        }

        private void dgvKhachHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvKhachHang.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }


    }
}
