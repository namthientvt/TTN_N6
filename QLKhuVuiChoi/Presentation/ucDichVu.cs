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
    public partial class ucDichVu : UserControl
    {
        public ucDichVu()
        {
            InitializeComponent();
        }
        bool them = false;
        public string TangMa()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from DichVu";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "dv01";
            }
            else
            {
                int k = 0;
                ma = "dv";
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
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from DichVu";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDichVu.DataSource = dt;
        }
        public void LoadData()
        {
            txtMaDV.DataBindings.Clear();
            txtMaDV.DataBindings.Add("Text", dgvDichVu.DataSource, "MaDV");

            txtTenDV.DataBindings.Clear();
            txtTenDV.DataBindings.Add("Text", dgvDichVu.DataSource, "TenDV");

            cbbMaKhu.DataBindings.Clear();
            cbbMaKhu.DataBindings.Add("Text", dgvDichVu.DataSource, "MaKhu");

            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvDichVu.DataSource, "Gia");
        }
        public void lockControl()
        {
            txtTenDV.Enabled = false;
            txtMaDV.Enabled = false;
            cbbMaKhu.Enabled = false;
            txtGia.Enabled = false;

        }

        public void unlockControl()
        {
            txtTenDV.Enabled = true;
            txtMaDV.Enabled = true;
            txtGia.Enabled = true;
            cbbMaKhu.Enabled = true;

        }

        public void setNull()
        {
            txtTenDV.Text = "";
            txtGia.Text = "";
            cbbMaKhu.Text = "";
            txtMaDV.Text = "";
        }
        private void Show_Khu()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select  MaKhu,TenKhu from KhuTroChoi", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMaKhu.DataSource = dt;
            cbbMaKhu.DisplayMember = "TenKhu";
            cbbMaKhu.ValueMember = "MaKhu";
        }

        private void ucDichVu_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
            Show_Khu();
            lockControl();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setNull();
            txtMaDV.Text = TangMa();
            them = true;
            unlockControl();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            dgvDichVu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            unlockControl();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            dgvDichVu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa dịch vụ " + txtTenDV.Text.Trim() + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("xoa_DichVu", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@maDV", txtMaDV.Text.Trim());

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
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("them_DichVu", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@maDV", txtMaDV.Text.Trim());
                    cmd.Parameters.AddWithValue("@tenDV", txtTenDV.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gia", txtGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@maKhu", cbbMaKhu.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm!");
                    KetNoi();
                    LoadData();
                    lockControl();
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    dgvDichVu.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (them == false)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sua_DichVu", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@maDV", txtMaDV.Text.Trim());
                    cmd.Parameters.AddWithValue("@tenDV", txtTenDV.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gia", txtGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@maKhu", cbbMaKhu.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã sửa!");
                    KetNoi();
                    LoadData();
                    lockControl();
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    dgvDichVu.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lockControl();
            setNull();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dgvDichVu.Enabled = true;
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTK_Click(null, null);
        }

        private void timkiem_TextChanged(object sender, EventArgs e)
        {
            btnTK_Click(null, null);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                if (cbbTimKiem.Text == "Theo Mã Dịch Vụ")
                {
                    sql = "select * from DichVu where MaDV = '" + txtTimKiem.Text.Trim() + "'";
                }
                else if (cbbTimKiem.Text == "Theo Tên Dịch Vụ")
                {
                    sql = "select * from DichVu where TenDV like N'%" + txtTimKiem.Text.Trim() + "%'";
                }
                else if (cbbTimKiem.Text == "Theo Mã Khu")
                {
                    sql = "select * from DichVu where MaKhu = '" + txtTimKiem.Text.Trim() + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDichVu.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDichVu_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDichVu.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }

        private void dgvDichVu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDichVu.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
