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
using System.Drawing.Imaging;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QLKhuVuiChoi.Presentation
{
    public partial class ucThongKe : UserControl
    {
        public ucThongKe()
        {
            InitializeComponent();
        }

        private void Show_Khu()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaKhu, TenKhu from KhuTroChoi", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            cboMaKhu.DataSource = dt;
            cboMaKhu.DisplayMember = "TenKhu";
            cboMaKhu.ValueMember = "MaKhu";
        }

        private void TongKhach_TongVe()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemKhach_DemVe", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", dtpNgayBatDau.Value);
            cmd.Parameters.AddWithValue("@end", dtpNgayKetThuc.Value);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lblTongKhach.Text = dt.Rows[0][0].ToString();
            lblTongVe.Text = dt.Rows[0][1].ToString();
            lblTongDV.Text = dt.Rows[0][2].ToString();
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
            lblTongDoanhThu.Text = DinhDangTien(dt.Rows[0][0].ToString()) + " (VND)" ;
        }

        private void DoanhThuKhu()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TongDoanhThu_TheoKhu", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", dtpNgayBatDau.Value);
            cmd.Parameters.AddWithValue("@end", dtpNgayKetThuc.Value);
            cmd.Parameters.AddWithValue("@MaKhu", cboMaKhu.SelectedValue);
            //cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lblDoanhThuKhu.Text = DinhDangTien(dt.Rows[0][0].ToString()) + " (VND)";
            
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
            if (temp >= 100000000 && temp <= 999999999)
            {
                string sodau = DauVao.Substring(0, 3);
                string basosau1 = DauVao.Substring(3, 3);
                string basosau2 = DauVao.Substring(6, 3);
                daura = sodau + "." + basosau1 + "." + basosau2;
            }
            return daura;
        }

        private void dgvDichVu_Load(object sender, EventArgs e)
        {
            Show_Khu();
            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 20;
            TongKhach_TongVe();
            progressBar1.Value = 30;
            ThongKeDV();
            progressBar1.Value = 50;
            ThongKeVe();
            progressBar1.Value = 70;
            TongDoanhThu();
            progressBar1.Value = 80;
            DoanhThuKhu();
            progressBar1.Value = 100;
        }

        private void ThongKeDV()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DemLuotDV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", dtpNgayBatDau.Value);
            cmd.Parameters.AddWithValue("@end", dtpNgayKetThuc.Value);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDichVu.DataSource = dt;
        }

        private void ThongKeVe()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SoVe_theoKhu", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", dtpNgayBatDau.Value);
            cmd.Parameters.AddWithValue("@end", dtpNgayKetThuc.Value);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvVe.DataSource = dt;
        }

        ImageFormat img;
        Bitmap bt;
        Graphics g;
        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Size s = Screen.PrimaryScreen.Bounds.Size;

                bt = new Bitmap(s.Width, s.Height);

                g = Graphics.FromImage(bt);

                g.CopyFromScreen(0, 0, 0, 0, s);

                switch (saveFileDialog1.FilterIndex)
                {
                    case 0: img = ImageFormat.Png; break;
                    case 1: img = ImageFormat.Jpeg; break;
                }

                bt.Save(saveFileDialog1.FileName, img);

                MessageBox.Show("Đã chụp!");
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            SaveFileDialog fsave = new SaveFileDialog();

            fsave.Filter = "(Tất cả các tệp)|*.*|(các tệp excel)|*.xlsx";
            fsave.ShowDialog();

            if (fsave.FileName != "")
            {
                COMExcel.Application exApp = new COMExcel.Application();
                COMExcel.Workbook exBook;
                COMExcel.Worksheet exSheet;
                COMExcel.Range exRange;
                progressBar1.Value = 20;
                exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
                exSheet = exBook.Worksheets[1];
                // Định dạng chung
                exRange = exSheet.Cells[1, 1];
                exRange.Range["A1:B3"].Font.Size = 10;
                exRange.Range["A1:B3"].Font.Name = "Times new roman";
                exRange.Range["A1:B3"].Font.Bold = true;
                exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
                progressBar1.Value = 40;
                exRange.Range["A1:A1"].ColumnWidth = 7;

                exRange.Range["B1:B1"].ColumnWidth = 15;

                exRange.Range["A1: A100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["D1: D100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["F1: F100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["G1: G100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["H1: H100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

                exRange.Range["A2:B2"].MergeCells = true;
                exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:B2"].Value = "Thống kê dữ liệu";
                progressBar1.Value = 60;
                exRange.Range["A3:B3"].MergeCells = true;
                exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

                exRange.Range["C2:G2"].Font.Size = 16;
                exRange.Range["C2:G2"].Font.Name = "Times new roman";
                exRange.Range["C2:G2"].Font.Bold = true;
                exRange.Range["C2:G2"].Font.ColorIndex = 3; //Màu đỏ
                exRange.Range["C2:G2"].MergeCells = true;
                exRange.Range["C2:G2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C2:G2"].Value = "Thống kê dữ liệu khu vui chơi";

                DateTime d = DateTime.Now;
                exRange.Range["C3:G3"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
                exRange.Range["C3:G3"].MergeCells = true;
                exRange.Range["C3:G3"].Font.Italic = true;
                exRange.Range["C3:G3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                progressBar1.Value = 80;
                exRange.Range["A6"].ColumnWidth = 15;
                exRange.Range["A6"].Value = "Từ Ngày: ";
                exRange.Range["B6"].Value = dtpNgayBatDau.Text;
                exRange.Range["B6"].MergeCells = true;
                exRange.Range["B6"].Font.Italic = true;
                exRange.Range["B6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

                exRange.Range["A7"].ColumnWidth = 15;
                exRange.Range["A7"].Value = "Đến Ngày: ";
                exRange.Range["B7"].Value = dtpNgayKetThuc.Text;
                exRange.Range["B7"].MergeCells = true;
                exRange.Range["B7"].Font.Italic = true;
                exRange.Range["B7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

                exRange.Range["A8"].Value = "Tổng số khách vào chơi: ";
                //exRange.Range["A8:B8"].MergeCells = true;
                exRange.Range["A8"].Font.Italic = true;
                exRange.Range["B8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["B8"].Value = lblTongKhach.Text;

                exRange.Range["A10"].Value = "Tổng vé bán ra: ";
                //exRange.Range["A10:B10"].MergeCells = true;
                exRange.Range["A10"].Font.Italic = true;
                exRange.Range["B10"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["B10"].Value = lblTongVe.Text;

                exRange.Range["A12"].Value = "Lần sử dụng dịch vụ: ";
                //exRange.Range["A12:B12"].MergeCells = true;
                exRange.Range["A12"].Font.Italic = true;
                exRange.Range["B12"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["B12"].Value = lblTongDV.Text;

                exRange.Range["A14"].Value = "Tổng doanh thu: ";
                //exRange.Range["A14:B14"].MergeCells = true;
                exRange.Range["A14"].Font.Italic = true;
                exRange.Range["B14"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["B14"].Value = lblTongDoanhThu.Text;

                exApp.Visible = true;
                exBook.SaveAs(fsave.FileName);
                progressBar1.Value = 100;
            }
            else
            {
                MessageBox.Show("Bạn phải nhập tên!");
            }
        }

        private void lblDoanhThuKhu_Click(object sender, EventArgs e)
        {
            btnThongKe_Click(null, null);
        }

        private void btnBieuDo_Click(object sender, EventArgs e)
        {
            frmBieuDo bd = new frmBieuDo();
            bd.ShowDialog();
        }

        private void ucThongKe_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }

    }
}
