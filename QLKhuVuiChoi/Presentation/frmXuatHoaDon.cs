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
    public partial class frmXuatHoaDon : Form
    {
        public frmXuatHoaDon()
        {
            InitializeComponent();
        }

        public void Ketnoi()
        {
           lbMaKH.Text = DataAccess.XuatHD.MaKH;
           SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
           conn.Open();
           string sql = "select hd.MaHoaDon, MaKH, MaDV, NgayHoaDon, GiaDV, SoLuongDV,ThanhTien from HoaDon hd, ChiTietHoaDon ct where hd.MaHoaDon=ct.MaHoaDon and MaKH ='"+lbMaKH.Text+"'";
           SqlCommand cmd = new SqlCommand(sql, conn);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
           da.Fill(dt);
           DataView dv = new DataView(dt);
           dgvThongTin.DataSource = dv;

           ShowThongTinKH();
        }
        public void ShowThongTinKH()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select TenKH,TuoiKH, GioiTinhKH from KhachHang where MaKH = '" + lbMaKH.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

           
            lbTenKH.Text = dt.Rows[0][0].ToString();
            lbTuoi.Text = dt.Rows[0][1].ToString();
            lbGTKH.Text = dt.Rows[0][2].ToString();
        }
        private void frmXuatHoaDon_Load(object sender, EventArgs e)
        {
            Ketnoi();
        }
    }
}
