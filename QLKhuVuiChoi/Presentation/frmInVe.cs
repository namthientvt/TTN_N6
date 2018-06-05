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
    public partial class frmInVe : Form
    {
        public frmInVe()
        {
            InitializeComponent();
        }

        public void LoadVe()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("XemVe", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaVe", DataAccess.BanVe.MaVe);
            //cmd.Parameters.AddWithValue("@Date", DataAccess.BanVe.ngay);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lblMaKH.Text = dt.Rows[0][0].ToString();
            lblTen.Text = dt.Rows[0][1].ToString();
            lblNgay.Text = dt.Rows[0][6].ToString();
            lblMaVe.Text = dt.Rows[0][2].ToString();
            lblThanhTien.Text = dt.Rows[0][7].ToString();
            dgvVe.DataSource = dt;
        }

        //private void TongTien()
        //{
        //    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
        //    conn.Open();

        //    SqlCommand cmd = new SqlCommand("TienVeTrongNgay", conn);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@MaKh", DataAccess.BanVe.MaKhachHang);
        //    cmd.Parameters.AddWithValue("@Date", DataAccess.BanVe.ngay);

        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //   // MessageBox.Show("" + dt.Rows[0][0].ToString());

        //    lblThanhTien.Text = dt.Rows[0][0].ToString() ;

        //    int temp = Convert.ToInt32(lblThanhTien.Text);
        //    string dinhdang = "";

        //    if (temp >= 10000 && temp < 99999)
        //    {
        //        string sodau = dt.Rows[0][0].ToString().Substring(0, 2);
        //        string basosau1 = dt.Rows[0][0].ToString().Substring(2, 3);
        //        dinhdang = sodau + "." + basosau1;
        //    }

        //    if (temp >= 100000 && temp < 999999)
        //    {
        //        string sodau = dt.Rows[0][0].ToString().Substring(0, 3);
        //        string basosau1 = dt.Rows[0][0].ToString().Substring(3, 3);
        //        dinhdang = sodau + "." + basosau1;
        //    }

        //    if (temp >= 1000000 && temp < 9999999)
        //    {
        //        string sodau = dt.Rows[0][0].ToString().Substring(0, 1);
        //        string basosau1 = dt.Rows[0][0].ToString().Substring(1, 3);
        //        string basosau2 = dt.Rows[0][0].ToString().Substring(4, 3);
        //        dinhdang = sodau + "." + basosau1 +"." + basosau2;
        //    }

        //    if (temp >= 10000000 && temp < 99999999)
        //    {
        //        string sodau = dt.Rows[0][0].ToString().Substring(0, 2);
        //        string basosau1 = dt.Rows[0][0].ToString().Substring(2, 3);
        //        string basosau2 = dt.Rows[0][0].ToString().Substring(5, 3);
        //        dinhdang = sodau + "." + basosau1 + "." + basosau2;
        //    }

        //    lblThanhTien.Text = dinhdang + " VND";

        //}


        private void frmInVe_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("" + DataAccess.BanVe.ngay + "->" + DataAccess.BanVe.MaKhachHang);
            LoadVe();
            //TongTien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Kết Nối Với Máy In Để In Vé", "Kết Nối Máy In", MessageBoxButtons.OK, MessageBoxIcon.Error);//
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("XemVe", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaVe", DataAccess.BanVe.MaVe);
            //cmd.Parameters.AddWithValue("@Date", DataAccess.BanVe.ngay);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            e.Graphics.DrawString("Khách hàng giữ liên này:", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(0, 0));
            Bitmap bmp = Properties.Resources.anhve;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 60, 60, newImage.Width, newImage.Height);
            e.Graphics.DrawString("Mã Vé: "+dt.Rows[0][2].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(140, 300));
            e.Graphics.DrawString("Mã KH: " + dt.Rows[0][0].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(140, 350));
            e.Graphics.DrawString("Họ Tên: "+dt.Rows[0][1].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(140, 400));
            e.Graphics.DrawString("Ngày Bán: " + dt.Rows[0][6].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(140, 450));
            e.Graphics.DrawString("Thành Tiền: " + dt.Rows[0][7].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(140, 500));

            e.Graphics.DrawString("------------------------------------------------------------------------" 
                , new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(140, 600));
            e.Graphics.DrawString("Khu trò chơi giữ lại liên này.", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(0, 650));
            e.Graphics.DrawString("Mã Vé: " + dt.Rows[0][2].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(140, 750));
            e.Graphics.DrawString("Mã KH: " + dt.Rows[0][0].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(140, 800));
            e.Graphics.DrawString("Họ Tên: " + dt.Rows[0][1].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(140, 850));
            e.Graphics.DrawString("Ngày Bán: " + dt.Rows[0][6].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(140, 900));
            e.Graphics.DrawString("Thành Tiền: " + dt.Rows[0][7].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(140, 950));
        }
    }
}
