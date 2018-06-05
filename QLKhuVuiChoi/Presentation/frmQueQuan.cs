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
    public partial class frmQueQuan : Form
    {
        public frmQueQuan()
        {
            InitializeComponent();
        }

        private void frmQueQuan_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
        }

        public void KetNoi()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select *from QueQuan", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvQueQuan.DataSource = dt;
        }

        public void LoadData()
        {
            txtMaTinh.DataBindings.Clear();
            txtMaTinh.DataBindings.Add("Text", dgvQueQuan.DataSource, "MaTinh");

            txtTenTinh.DataBindings.Clear();
            txtTenTinh.DataBindings.Add("Text", dgvQueQuan.DataSource, "TenTinh");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into QueQuan values (@MaTinh, @TenTinh)", conn);
                cmd.Parameters.AddWithValue("@MaTinh", txtMaTinh.Text.Trim());
                cmd.Parameters.AddWithValue("@TenTinh", txtTenTinh.Text.Trim());

                int tem = cmd.ExecuteNonQuery();

                if (tem != 0)
                {
                    MessageBox.Show("Đã thêm");
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update QueQuan set MaTinh = @MaTinh, TenTinh = @TenTinh where MaTinh = @MaTinh", conn);
                cmd.Parameters.AddWithValue("@MaTinh", txtMaTinh.Text.Trim());
                cmd.Parameters.Add("@TenTinh", txtTenTinh.Text.Trim());

                int tem = cmd.ExecuteNonQuery();

                if (tem != 0)
                {
                    MessageBox.Show("Đã sửa");
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa mã quê " + txtTenTinh.Text.Trim() + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete QueQuan where MaTinh = @MaTinh", conn);

                    cmd.Parameters.AddWithValue("@MaTinh", txtMaTinh.Text);

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

    }
}
