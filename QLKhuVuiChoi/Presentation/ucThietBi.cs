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
    public partial class ucThietBi : UserControl
    {
        public ucThietBi()
        {
            InitializeComponent();
        }

        private bool ThemMoi; //dùng để xác định đang trong trạng thái thêm mới hay k


        public string TangMa()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from ThietBi";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "tb01";
            }
            else
            {
                int k = 0;
                ma = "tb";
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
            txtMaTB.Enabled = false;
            txtTenTB.Enabled = false;
            cbbMaTC.Enabled = false;
            txtTT.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        public void unLockControl()
        {
            txtMaTB.Enabled = true;
            txtTenTB.Enabled = true;
            cbbMaTC.Enabled = true;
            txtTT.Enabled = true;
            btnLuu.Enabled = true;
        }

        public void setnull()
        {
            //txtMaPB.Text = "";
            txtTenTB.Text = "";
            cbbMaTC.Text = "";
            txtTT.Text = "";
            //ThemMoi = false;
        }

        public void KetNoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                string sql = "select *from ThietBi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataView dv = new DataView(dt);

                dgvThietBi.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadData()
        {
            txtMaTB.DataBindings.Clear();
            txtMaTB.DataBindings.Add("Text", dgvThietBi.DataSource, "MaTB");

            txtTenTB.DataBindings.Clear();
            txtTenTB.DataBindings.Add("Text", dgvThietBi.DataSource, "TenTB");

            cbbMaTC.DataBindings.Clear();
            cbbMaTC.DataBindings.Add("Text", dgvThietBi.DataSource, "MaTroChoi");

            txtTT.DataBindings.Clear();
            txtTT.DataBindings.Add("Text", dgvThietBi.DataSource, "TinhTrang");

        }

        private void Show_TC()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaTroChoi, TenTroChoi from TroChoi", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMaTC.DataSource = dt;
            cbbMaTC.DisplayMember = "TenTroChoi";
            cbbMaTC.ValueMember = "MaTroChoi";
        }


        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (ThemMoi == true)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Them_ThietBi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Matb", txtMaTB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tentb", txtTenTB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Matrochoi", cbbMaTC.SelectedValue);
                    cmd.Parameters.AddWithValue("@Tinhtrang", txtTT.Text.Trim());

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
                    dgvThietBi.Enabled = true;
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
                    SqlCommand cmd = new SqlCommand("Update_TB", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Matb", txtMaTB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tentb", txtTenTB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Matrochoi", cbbMaTC.SelectedValue);
                    cmd.Parameters.AddWithValue("@Tinhtrang", txtTT.Text.Trim());

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
                    dgvThietBi.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setnull();
            txtMaTB.Text = TangMa();
            ThemMoi = true;
            unLockControl();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            dgvThietBi.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThemMoi = false;
            unLockControl();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            dgvThietBi.Enabled = false;
        
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
            dgvThietBi.Enabled = true;
        }

        string sql = "";
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                if (cbbKieuTK.Text == "Theo Mã Thiết Bị")
                {
                    //dgvNhanVien.DataSource = dv;/
                    sql = "select * from ThietBi where MaTB = '" + txtTimKiem.Text.Trim() + "'";
                    //dv = new DataView(dt);
                    //dv.RowFilter = "MaNV = nv01";
                    // dt.Rows= DataViewRowState.CurrentRows
                    // dgvNhanVien.DataSource = dv;

                }
                else if (cbbKieuTK.Text == "Theo Tên Thiết Bị")
                {
                    //dv = new DataView(dt);
                    //dv.RowFilter = "TenNV = " + txtTimKiem.Text.Trim();  
                    sql = "select * from ThietBi where TenTB like N'%" + txtTimKiem.Text.Trim() + "%'";
                }
                else if (cbbKieuTK.Text == "Theo Mã Trò Chơi")
                {
                    //dv = new DataView(dt);
                    //dv.RowFilter = "MaPB = " + txtTimKiem.Text.Trim();  
                    sql = "select * from ThietBi where MaTroChoi = '" + txtTimKiem.Text.Trim() + "'";
                }
                else if (cbbKieuTK.Text == "Theo Tình Trạng")
                {
                    // dv = new DataView(dt);
                    //dv.RowFilter = "MaKhuPhuTrach = " + txtTimKiem.Text.Trim();  
                    sql = "select * from ThietBi where TinhTrang = N'" + txtTimKiem.Text.Trim() + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvThietBi.DataSource = dt;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbKieuTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(null , null );
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(null, null);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa thiết bị " + txtTenTB.Text.Trim() + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Xoa_TB", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Matb", txtMaTB.Text.Trim());

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

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
            txtTimKiem.Text = "";
            cbbKieuTK.Text = "";
        }

        private void ucThietBi_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
            Show_TC();
            LockControl();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTenTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbbMaTC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvThietBi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvThietBi.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }

        private void dgvThietBi_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvThietBi.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
