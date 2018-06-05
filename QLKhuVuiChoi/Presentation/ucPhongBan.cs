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
    public partial class ucPhongBan : UserControl
    {
        public ucPhongBan()
        {
            InitializeComponent();
        }

        private bool ThemMoi; //dùng để xác định đang trong trạng thái thêm mới hay k
        

        public string TangMa()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from PhongBan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "pb01";
            }
            else
            {
                int k=0;
                ma = "pb";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2,2));
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
            txtMaPB.Enabled = false;
            txtTenPB.Enabled = false;
            txtMaTP.Enabled = false;
            txtDiaDiem.Enabled = false;
            dtpNgayNC.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        public void unLockControl()
        {
            txtMaPB.Enabled = true;
            txtTenPB.Enabled = true;
            txtMaTP.Enabled = true;
            txtDiaDiem.Enabled = true;
            dtpNgayNC.Enabled = true;
            btnLuu.Enabled = true;
        }

        public void setnull()
        {
            //txtMaPB.Text = "";
            txtTenPB.Text = "";
            txtMaTP.Text = "";
            txtDiaDiem.Text = "";
            dtpNgayNC.Text = "";
            //ThemMoi = false;
        }

        public void KetNoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                string sql = "select *from PhongBan";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataView dv = new DataView(dt);
                
                dgvPhongBan.DataSource = dv;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadData()
        {
            txtMaPB.DataBindings.Clear();
            txtMaPB.DataBindings.Add("Text", dgvPhongBan.DataSource, "MaPB");

            txtTenPB.DataBindings.Clear();
            txtTenPB.DataBindings.Add("Text", dgvPhongBan.DataSource, "TenPB");

            txtMaTP.DataBindings.Clear();
            txtMaTP.DataBindings.Add("Text", dgvPhongBan.DataSource, "MaTP");

            dtpNgayNC.DataBindings.Clear();
            dtpNgayNC.DataBindings.Add("Text", dgvPhongBan.DataSource, "NgayNC");

            txtDiaDiem.DataBindings.Clear();
            txtDiaDiem.DataBindings.Add("Text", dgvPhongBan.DataSource, "DiaDiem");
        }

        private void ucPhongBan_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
            LockControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ThemMoi == true) //đang ở chế độ thêm mới
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_ThemPhongBan", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Mapb", txtMaPB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tenpb", txtTenPB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Matp", txtMaTP.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ngaync", dtpNgayNC.Value.ToString("dd/MM/yyyy"));
                    cmd.Parameters.AddWithValue("@diadiem", txtDiaDiem.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm!");
                    KetNoi();
                    LoadData();
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    btnXoa.Enabled = true;
                    dgvPhongBan.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thêm được! "+ex.Message);
                }
            }
            else //đang ở chế độ sửa
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UpdatePB", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Mapb", txtMaPB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tenpb", txtTenPB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Matp", txtMaTP.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ngaync", dtpNgayNC.Value.ToString("dd/MM/yyy"));
                    cmd.Parameters.AddWithValue("@diadiem", txtDiaDiem.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã sửa");
                    KetNoi();
                    LoadData();
                    btnThem.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    btnXoa.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không sửa được!"+ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setnull();
            LockControl();
            dgvPhongBan.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "";

            if (cbbKieuTK.Text == "Theo Mã Phòng Ban")
            {
                sql = "select *from PhongBan where MaPB = '" + txtTimKiem.Text.Trim() + "'";
            }
            else
            {
                sql = "select *from PhongBan where TenPB like N'%" + txtTimKiem.Text.Trim() + "%'";
            }
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPhongBan.DataSource = dt;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            unLockControl();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            ThemMoi = true;
            txtMaPB.Text = TangMa();
            setnull();
            dgvPhongBan.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            unLockControl();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
            ThemMoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa " + txtTenPB.Text.Trim() + " khỏi công ty không?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("XoaPB", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Ma", txtMaPB.Text.Trim());
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
        }

        private void txtTimKiem_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            btnTimKiem_Click(null, null);
        }

        private void cbbKieuTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(null, null);
        }

        private void dgvPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvPhongBan.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }

    }
}
