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
    public partial class ucTroChoi : UserControl
    {
        public ucTroChoi()
        {
            InitializeComponent();
        }
        private bool ThemMoi; //dùng để xác định đang trong trạng thái thêm mới hay k


        public string TangMa()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from TroChoi";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "tc01";
            }
            else
            {
                int k = 0;
                ma = "tc";
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


        public void LockControl()
        {
            txtMaTC.Enabled = false;
            txtTenTC.Enabled = false;
            cbbMaNVPT.Enabled = false;
            txtSoNC.Enabled = false;
            cbbMaKhu.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        public void unLockControl()
        {
            txtMaTC.Enabled = true;
            txtTenTC.Enabled = true;
            cbbMaNVPT.Enabled = true;
            txtSoNC.Enabled = true;
            cbbMaKhu.Enabled = true;
            btnLuu.Enabled = true;
        }

        public void setnull()
        {
            //txtMaPB.Text = "";
            txtTenTC.Text = "";
            txtSoNC.Text = "";
            //ThemMoi = false;
        }

        public void KetNoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                string sql = "select * from TroChoi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataView dv = new DataView(dt);

                dgvTroChoi.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadData()
        {
            txtMaTC.DataBindings.Clear();
            txtMaTC.DataBindings.Add("Text", dgvTroChoi.DataSource, "MaTroChoi");

            txtTenTC.DataBindings.Clear();
            txtTenTC.DataBindings.Add("Text", dgvTroChoi.DataSource, "TenTroChoi");

            cbbMaNVPT.DataBindings.Clear();
            cbbMaNVPT.DataBindings.Add("Text", dgvTroChoi.DataSource, "MaNVPhuTrach");

            txtSoNC.DataBindings.Clear();
            txtSoNC.DataBindings.Add("Text", dgvTroChoi.DataSource, "SoLuongNC_Max");

            cbbMaKhu.DataBindings.Clear();
            cbbMaKhu.DataBindings.Add("Text", dgvTroChoi.DataSource, "MaKhu");

        }

        private void Show_NVPT()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaNV, TenNV from NhanVien", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMaNVPT.DataSource = dt;
            cbbMaNVPT.DisplayMember = "TenNV";
            cbbMaNVPT.ValueMember = "MaNV";
        }

        private void Show_Khu()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaKhu, TenKhu from KhuTroChoi", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMaKhu.DataSource = dt;
            cbbMaKhu.DisplayMember = "TenKhu";
            cbbMaKhu.ValueMember = "MaKhu";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setnull();
            txtMaTC.Text = TangMa();
            ThemMoi = true;
            unLockControl();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            dgvTroChoi.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThemMoi = false;
            unLockControl();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            dgvTroChoi.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa trò chơi " + txtTenTC.Text.Trim() + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Xoa_TroChoi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Matc", txtMaTC.Text.Trim());

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
            txtTimKiem.Text = "";
            cbbKieuTK.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ThemMoi == true)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("ThemTroChoi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Matc", txtMaTC.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tentc", txtTenTC.Text.Trim());
                    cmd.Parameters.AddWithValue("@Manvpt", cbbMaNVPT.SelectedValue);
                    cmd.Parameters.AddWithValue("@SLNC", txtSoNC.Text.Trim());
                    cmd.Parameters.AddWithValue("@Makhu", cbbMaKhu.SelectedValue);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm!");
                    KetNoi();
                    LoadData();
                    LockControl();
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    dgvTroChoi.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (ThemMoi == false)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update_TroChoi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Matc", txtMaTC.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tentc", txtTenTC.Text.Trim());
                    cmd.Parameters.AddWithValue("@Manvpt", cbbMaNVPT.SelectedValue);
                    cmd.Parameters.AddWithValue("@SLNC", txtSoNC.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaKhu", cbbMaKhu.SelectedValue);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã sửa!");
                    KetNoi();
                    LoadData();
                    LockControl();
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    dgvTroChoi.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LockControl();
            setnull();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dgvTroChoi.Enabled = true;
        }

        private void cbbKieuTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(null,null);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(null, null);
        }

        string sql = "";

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                if (cbbKieuTK.Text == "Theo Mã Trò Chơi")
                {
                    //dgvNhanVien.DataSource = dv;/
                    sql = "select * from TroChoi where MaTroChoi = '" + txtTimKiem.Text.Trim() + "'";
                    //dv = new DataView(dt);
                    //dv.RowFilter = "MaNV = nv01";
                    // dt.Rows= DataViewRowState.CurrentRows
                    // dgvNhanVien.DataSource = dv;

                }
                else if (cbbKieuTK.Text == "Theo Tên Trò Chơi")
                {
                    //dv = new DataView(dt);
                    //dv.RowFilter = "TenNV = " + txtTimKiem.Text.Trim();  
                    sql = "select * from TroChoi where TenTroChoi like N'%" + txtTimKiem.Text.Trim() + "%'";
                }
                else if (cbbKieuTK.Text == "Theo Mã NVPT")
                {
                    //dv = new DataView(dt);
                    //dv.RowFilter = "MaPB = " + txtTimKiem.Text.Trim();  
                    sql = "select * from TroChoi where MaNVPhuTrach = '" + txtTimKiem.Text.Trim() + "'";
                }
                else if (cbbKieuTK.Text == "Theo Số Người Chơi")
                {
                    // dv = new DataView(dt);
                    //dv.RowFilter = "MaKhuPhuTrach = " + txtTimKiem.Text.Trim();  
                    sql = "select * from TroChoi where SoLuongNC_Max = '" + txtTimKiem.Text.Trim() + "'";
                }
                else if (cbbKieuTK.Text == "Theo Mã Khu")
                {
                    // dv = new DataView(dt);
                    //dv.RowFilter = "MaKhuPhuTrach = " + txtTimKiem.Text.Trim();  
                    sql = "select * from TroChoi where MaKhu = N'" + txtTimKiem.Text.Trim() + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTroChoi.DataSource = dt;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ucTroChoi_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
            Show_NVPT();
            Show_Khu();
            LockControl();
        }

        private void dgvTroChoi_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvTroChoi.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvTroChoi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvTroChoi.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }
    }
}
