using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhuVuiChoi.Presentation
{
    public partial class frmBieuDo : Form
    {
        public frmBieuDo()
        {
            InitializeComponent();
        }

        int dt1 = 0;
        int dt2 = 0;
        int dt3 = 0;
        int dt4 = 0;
        int dt5 = 0;
        int dt6 = 0;
        int dt7 = 0;
        int dt8 = 0;
        int dt9 = 0;
        int dt10 = 0;
        int dt11 = 0;
        int dt12 = 0;

        public void DoanhThuT1()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemKhach1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", txtNamTK.Text + "-01-01");
            cmd.Parameters.AddWithValue("@end", txtNamTK.Text + "-01-30");
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() != "")
            {
                dt1 = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                dt1 = 0;
            }
        }

        public void DoanhThuT2()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemKhach1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", txtNamTK.Text + "-02-01");
            cmd.Parameters.AddWithValue("@end", txtNamTK.Text + "-02-28");
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() != "")
            {
                dt2 = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                dt2 = 0;
            }
        }

        public void DoanhThuT3()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemKhach1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", txtNamTK.Text + "-03-01");
            cmd.Parameters.AddWithValue("@end", txtNamTK.Text + "-03-30");
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() != "")
            {
                dt3 = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                dt3 = 0;
            }
        }

        public void DoanhThuT4()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemKhach1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", txtNamTK.Text + "-04-01");
            cmd.Parameters.AddWithValue("@end", txtNamTK.Text + "-04-30");
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() != "")
            {
                dt4 = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                dt4 = 0;
            }
        }

        public void DoanhThuT5()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemKhach1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", txtNamTK.Text + "-05-01");
            cmd.Parameters.AddWithValue("@end", txtNamTK.Text + "-05-30");
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() != "")
            {
                dt5 = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                dt5 = 0;
            }
        }

        public void DoanhThuT6()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemKhach1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", txtNamTK.Text + "-06-01");
            cmd.Parameters.AddWithValue("@end", txtNamTK.Text + "-06-30");
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() != "")
            {
                dt6 = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                dt6 = 0;
            }
        }

        public void DoanhThuT7()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemKhach1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", txtNamTK.Text + "-07-01");
            cmd.Parameters.AddWithValue("@end", txtNamTK.Text + "-07-30");
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() != "")
            {
                dt7 = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                dt7 = 0;
            }
        }

        public void DoanhThuT8()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemKhach1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", txtNamTK.Text + "-08-01");
            cmd.Parameters.AddWithValue("@end", txtNamTK.Text + "-08-30");
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() != "")
            {
                dt8 = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                dt8 = 0;
            }
        }

        public void DoanhThuT9()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemKhach1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", txtNamTK.Text + "-09-01");
            cmd.Parameters.AddWithValue("@end", txtNamTK.Text + "-09-30");
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() != "")
            {
                dt9 = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                dt9 = 0;
            }
        }


        public void DoanhThuT10()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemKhach1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", txtNamTK.Text + "-10-01");
            cmd.Parameters.AddWithValue("@end", txtNamTK.Text + "-10-30");
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() != "")
            {
                dt10 = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                dt10 = 0;
            }
        }

        public void DoanhThuT11()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemKhach1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", txtNamTK.Text + "-11-01");
            cmd.Parameters.AddWithValue("@end", txtNamTK.Text + "-11-30");
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() != "")
            {
                dt11 = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                dt11 = 0;
            }
        }

        public void DoanhThuT12()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemKhach1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", txtNamTK.Text + "-12-01");
            cmd.Parameters.AddWithValue("@end", txtNamTK.Text + "-12-30");
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() != "")
            {
                dt12 = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                dt12 = 0;
            }
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtNamTK.Text == "")
            {
                MessageBox.Show("Bạn phải nhập năm!");
                ActiveControl = txtNamTK;
                return;
            }
            DoanhThuT1();
            DoanhThuT2();
            DoanhThuT3();
            DoanhThuT4();
            DoanhThuT5();
            DoanhThuT6();
            DoanhThuT7();
            DoanhThuT8();
            DoanhThuT9();
            DoanhThuT10();
            DoanhThuT11();
            DoanhThuT12();

            this.chart1.Series["Lượng Khách"].Points.AddXY("Tháng 1", dt1);
            this.chart1.Series["Lượng Khách"].Points.AddXY("Tháng 2", dt2);
            this.chart1.Series["Lượng Khách"].Points.AddXY("Tháng 3", dt3);
            this.chart1.Series["Lượng Khách"].Points.AddXY("Tháng 4", dt4);
            this.chart1.Series["Lượng Khách"].Points.AddXY("Tháng 5", dt5);
            this.chart1.Series["Lượng Khách"].Points.AddXY("Tháng 6", dt6);
            this.chart1.Series["Lượng Khách"].Points.AddXY("Tháng 7", dt7);
            this.chart1.Series["Lượng Khách"].Points.AddXY("Tháng 8", dt8);
            this.chart1.Series["Lượng Khách"].Points.AddXY("Tháng 9", dt9);
            this.chart1.Series["Lượng Khách"].Points.AddXY("Tháng 10", dt10);
            this.chart1.Series["Lượng Khách"].Points.AddXY("Tháng 11", dt11);
            this.chart1.Series["Lượng Khách"].Points.AddXY("Tháng 12", dt12);
        }

        private void txtNamTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
