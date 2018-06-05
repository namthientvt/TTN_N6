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
    public partial class ucKhuTroChoi : UserControl
    {
        public ucKhuTroChoi()
        {
            InitializeComponent();
        }
        bool them = false;
        public string TangMa()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = " select * from KhuTroChoi";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "k01";
            }
            else
            {
                int k = 0;
                ma = "k";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(1,2));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "0";
                }else
                ma = ma + k.ToString();
            }

            return ma;
        }
        public void KetNoi()
        {
            

            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from KhuTroChoi";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvKhuTroChoi.DataSource = dt;
        }
        public void LoadData()
        {
            txtMaKhu.DataBindings.Clear();
            txtMaKhu.DataBindings.Add("Text", dgvKhuTroChoi.DataSource, "MaKhu");

            txtTenKhu.DataBindings.Clear();
            txtTenKhu.DataBindings.Add("Text", dgvKhuTroChoi.DataSource, "TenKhu");

            txtMaNVQL.DataBindings.Clear();
            txtMaNVQL.DataBindings.Add("Text", dgvKhuTroChoi.DataSource, "MaNVQL");

            txtGiaVeTE.DataBindings.Clear();
            txtGiaVeTE.DataBindings.Add("Text", dgvKhuTroChoi.DataSource, "GiaVeTreEm");

            txtGiaVeNL.DataBindings.Clear();
            txtGiaVeNL.DataBindings.Add("Text", dgvKhuTroChoi.DataSource, "GiaVeNguoiLon");
        }
        public void lockControl()
        {
            txtMaKhu.Enabled = false;
            txtMaNVQL.Enabled = false;
            txtTenKhu.Enabled = false;
            txtGiaVeTE.Enabled = false;
            txtGiaVeNL.Enabled = false;
        }

        public void unlockControl()
        {
            txtMaKhu.Enabled = true;
            txtMaNVQL.Enabled = true;
            txtTenKhu.Enabled = true;
            txtGiaVeTE.Enabled = true;
            txtGiaVeNL.Enabled = true;

        }

        public void setNull()
        {
            txtMaKhu.Text = "";
            txtMaNVQL.Text = "";
            txtTenKhu.Text = "";
            txtGiaVeTE.Text = "";
            txtGiaVeNL.Text = "";
        }
        //private void Show_Khu()
        //{
        //    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("select  MaKhu,TenKhu from KhuTroChoi", conn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    cbbTenKhu.DataSource = dt;
        //    cbbTenKhu.DisplayMember = "TenKhu";
        //    cbbTenKhu.ValueMember = "MaKhu";
        //}


        private void ucKhuTroChoi_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
           // Show_Khu();
            lockControl();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setNull();
            txtMaKhu.Text = TangMa();       
            them = true;
            unlockControl();
            txtMaKhu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            dgvKhuTroChoi.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            unlockControl();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            dgvKhuTroChoi.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa khu trò chơi " + txtTenKhu.Text.Trim() + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("xoa_KhuTroChoi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@maKhu", txtMaKhu.Text.Trim());

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

                    SqlCommand cmd = new SqlCommand("them_KhuTroChoi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@maKhu", txtMaKhu.Text.Trim());
                    cmd.Parameters.AddWithValue("@tenKhu", txtTenKhu.Text.Trim());
                    cmd.Parameters.AddWithValue("@maNVQL", txtMaNVQL.Text.Trim());
                    cmd.Parameters.AddWithValue("@GiaVeTreEm", txtGiaVeTE.Text.Trim());
                    cmd.Parameters.AddWithValue("@GiaVeNguoiLon", txtGiaVeNL.Text.Trim());

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
                    dgvKhuTroChoi.Enabled = true;
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
                    SqlCommand cmd = new SqlCommand("sua_KhuTroChoi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@maKhu", txtMaKhu.Text.Trim());
                    cmd.Parameters.AddWithValue("@tenKhu", txtTenKhu.Text.Trim());
                    cmd.Parameters.AddWithValue("@maNVQL", txtMaNVQL.Text.Trim());
                    cmd.Parameters.AddWithValue("@GiaVeTreEm", txtGiaVeTE.Text.Trim());
                    cmd.Parameters.AddWithValue("@GiaVeNguoiLon", txtGiaVeNL.Text.Trim());

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
                    dgvKhuTroChoi.Enabled = true;
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
            dgvKhuTroChoi.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                if (cbbTimKiem.Text == "Theo Mã Khu")
                {
                    sql = "select * from KhuTroChoi where MaKhu = '" + txtTimKiem.Text.Trim() + "'";
                }
                else if (cbbTimKiem.Text == "Theo Tên Khu")
                {
                    sql = "select * from KhuTroChoi where TenKhu like N'%" + txtTimKiem.Text.Trim() + "%'";
                }
               
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKhuTroChoi.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(null, null);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(null, null);
        }

        private void dgvKhuTroChoi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvKhuTroChoi.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }
    }
}
