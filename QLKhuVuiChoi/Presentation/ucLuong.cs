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
    public partial class ucLuong : UserControl
    {
        public ucLuong()
        {
            InitializeComponent();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int temp = 0;
            temp = Convert.ToInt32(txtGiaTri.Text);
            temp = temp - 100000;
            txtGiaTri.Text = temp.ToString();

            int tempLuong = 0;
            tempLuong = Convert.ToInt32(txtLuong.Text);
            tempLuong = tempLuong - 100000;
            txtLuong.Text = tempLuong.ToString();

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int temp = 0;
            temp = Convert.ToInt32(txtGiaTri.Text);
            temp = temp + 100000;
            txtGiaTri.Text = temp.ToString();

            int tempLuong = 0;
            tempLuong = Convert.ToInt32(txtLuong.Text);
            tempLuong = tempLuong + 100000;
            txtLuong.Text = tempLuong.ToString();
        }

        public void KetNoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("LuongNV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLuong.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BindingData()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvLuong.DataSource, "MaNV");

            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dgvLuong.DataSource, "TenNV");

            txtLuong.DataBindings.Clear();
            txtLuong.DataBindings.Add("Text", dgvLuong.DataSource, "Luong");
        }

        private void ucLuong_Load(object sender, EventArgs e)
        {
            KetNoi();
            BindingData();
            TongLuongNV();
            txtMaNV.ReadOnly = true;
            txtTenNV.ReadOnly = true;
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật lương cho nhân viên "+ txtTenNV.Text+ " không?", "Cập nhật lương", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes )
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("CapNhatLuong", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@Luong", txtLuong.Text.Trim());

                    int temp = cmd.ExecuteNonQuery();
                    if (temp != 0)
                    {
                        MessageBox.Show("Đã cập nhật!");
                        
                        KetNoi();
                        BindingData();
                    }
                    else
                    {
                        MessageBox.Show("Chưa cập nhật!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvLuong_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvLuong.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                if (cbbKieuTK.Text == "Theo Mã Nhân Viên")
                {
                    sql = "select MaNV, TenNV, NgaySinh, QueQuan, Luong from NhanVien where MaNV = '" + txtTimKiem.Text.Trim() + "'";

                }
                else if (cbbKieuTK.Text == "Theo Tên Nhân Viên")
                {
                    sql = "select MaNV, TenNV, NgaySinh, QueQuan, Luong from NhanVien where TenNV like N'%" + txtTimKiem.Text.Trim() + "%'";
                }
                else if (cbbKieuTK.Text == "Theo Mã Phòng Ban")
                {
                    sql = "select MaNV, TenNV, NgaySinh, QueQuan, Luong from NhanVien where MaPB = '" + txtTimKiem.Text.Trim() + "'";
                }
                else if (cbbKieuTK.Text == "Theo Mã Khu phụ trách ")
                {
                    sql = "select MaNV, TenNV, NgaySinh, QueQuan, Luong from NhanVien where MaKhuPhuTrach = '" + txtTimKiem.Text.Trim() + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                dgvLuong.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            KetNoi();
            BindingData();
            TongLuongNV();
        }

        private void TongLuongNV()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TongLuongNV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lblTongLuong.Text = dt.Rows[0][0].ToString();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtGiaTri.Text = "0";
        }

        private void txtGiaTri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int temp = 0;
                temp = Convert.ToInt32(txtGiaTri.Text);
                //temp = temp + 100000;
                //txtGiaTri.Text = temp.ToString();

                int tempLuong = 0;
                tempLuong = Convert.ToInt32(txtLuong.Text);
                tempLuong = tempLuong + temp;
                txtLuong.Text = tempLuong.ToString();
            }
        }

    }
}
