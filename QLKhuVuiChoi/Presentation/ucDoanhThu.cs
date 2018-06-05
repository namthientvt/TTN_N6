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
    public partial class ucDoanhThu : UserControl
    {
        public ucDoanhThu()
        {
            InitializeComponent();
        }

        public string DinhDangTien(string DauVao)
        {
            int temp = Convert.ToInt32(DauVao);
            string daura = "";

            if (temp >= 100000 && temp <= 999999)
            {
                string sodau = DauVao.Substring(0, 3);
                string basosau1 = DauVao.Substring(3, 3);
                daura = sodau + "." + basosau1;
            }

            if (temp >= 1000000 && temp <= 9999999)
            {
                string sodau = DauVao.ToString().Substring(0, 1);
                string basosau1 = DauVao.ToString().Substring(1, 3);
                string basosau2 = DauVao.ToString().Substring(4, 3);
                daura = sodau + "." + basosau1 + "." + basosau2;
            }

            if (temp >= 10000000 && temp <= 99999999)
            {
                string sodau = DauVao.Substring(0, 2);
                string basosau1 = DauVao.Substring(2, 3);
                string basosau2 = DauVao.Substring(5, 3);
                daura = sodau + "." + basosau1 + "." + basosau2;
            }
            if (temp >= 100000000 && temp <= 999999999)
            {
                string sodau = DauVao.Substring(0, 3);
                string basosau1 = DauVao.Substring(3, 3);
                string basosau2 = DauVao.Substring(6, 3);
                daura = sodau + "." + basosau1 + "." + basosau2;
            }
            return daura;
        }

        private void TongDoanhThu()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TongDoanhThu", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", dtpNgayBatDau.Value);
            cmd.Parameters.AddWithValue("@end", dtpNgayKetThuc.Value);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lblTongDoanhThu.Text = DinhDangTien(dt.Rows[0][0].ToString()) + " (VND)";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            TongDoanhThu();
            progressBar1.Value = 20;
            TongTienVe();
            progressBar1.Value = 50;
            TongTienDV();
            progressBar1.Value = 100;
        }

        private void TongTienVe()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TienVe_CacKhu", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", dtpNgayBatDau.Value);
            cmd.Parameters.AddWithValue("@end", dtpNgayKetThuc.Value);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvVe.DataSource = dt;
        }

        private void TongTienDV()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TienDV_CacKhu", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", dtpNgayBatDau.Value);
            cmd.Parameters.AddWithValue("@end", dtpNgayKetThuc.Value);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDichVu.DataSource = dt;
        }

    }
}
