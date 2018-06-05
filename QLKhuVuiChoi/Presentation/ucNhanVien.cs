using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLKhuVuiChoi.Presentation
{
    public partial class ucNhanVien : UserControl
    {
        bool them = false;
        public ucNhanVien()
        {
            InitializeComponent();
        }
        public string TangMa()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "nv01";
            }
            else
            {
                int k = 0;
                ma = "nv";
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

        public void KetNoi()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dgvNhanVien.DataSource = dt;
        }

        public void LoadData()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaNV");

            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "TenNV");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "NgaySinh");

            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "GioiTinh");

            txtVTPT.DataBindings.Clear();
            txtVTPT.DataBindings.Add("Text", dgvNhanVien.DataSource, "ViTriPhuTrach");

            cboMaPB.DataBindings.Clear();
            cboMaPB.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaPB");

            cboMaKhuPT.DataBindings.Clear();
            cboMaKhuPT.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaKhuPhuTrach");

            txtLuong.DataBindings.Clear();
            txtLuong.DataBindings.Add("Text", dgvNhanVien.DataSource, "Luong");

            cboQueQuan.DataBindings.Clear();
            cboQueQuan.DataBindings.Add("Text", dgvNhanVien.DataSource, "QueQuan", true, DataSourceUpdateMode.Never);
        }

        public void lockControl()
        {
            txtTenNV.Enabled = false;
            txtMaNV.Enabled = false;
            txtLuong.Enabled = false;
            cboMaKhuPT.Enabled = false;
            cboQueQuan.Enabled = false;
            txtVTPT.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cboMaPB.Enabled = false;
            cboGioiTinh.Enabled = false;
        }

        public void unlockControl()
        {
            txtTenNV.Enabled = true;
            txtMaNV.Enabled = true;
            txtLuong.Enabled = true;
            cboMaKhuPT.Enabled = true;
            cboQueQuan.Enabled = true;
            txtVTPT.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cboMaPB.Enabled = true;
            cboGioiTinh.Enabled = true;
        }

        public void setNull()
        {
            txtTenNV.Text = "";
            //txtMaNV.Text = "";
            txtLuong.Text = "";
            cboMaKhuPT.Text = "";
            cboQueQuan.Text = "";
            cboGioiTinh.Text = "";
            txtVTPT.Text = "";
            //dtpNgaySinh.Text = "";
            cboMaPB.Text = "";
        }

        private void Show_NV()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaPB, TenPB from PhongBan", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            cboMaPB.DataSource = dt;
            cboMaPB.DisplayMember = "TenPB";
            cboMaPB.ValueMember = "MaPB";
        }

        private void Show_Khu()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaKhu, TenKhu from KhuTroChoi", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            cboMaKhuPT.DataSource = dt;
            cboMaKhuPT.DisplayMember = "TenKhu";
            cboMaKhuPT.ValueMember = "MaKhu";
        }

        private void Show_Que()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaTinh, TenTinh from QueQuan", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            cboQueQuan.DataSource = dt;
            cboQueQuan.DisplayMember = "TenTinh";
            cboQueQuan.ValueMember = "MaTinh";
        }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            ptbLoad.Visible = false;
            if (Convert.ToInt32(DataAccess.Quyen.MaQuyen) >= 2)
            {
                btnThem.Visible = false;
                btnImport_Ex.Visible = false;
                btnXuatFileExcel.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                btnRefresh.Visible = false;
                //LoadData();
                Show_NV();
                Show_Khu();
                Show_Que();
                lockControl();
                btnLuu.Visible = false;
                btnHuy.Visible = false;
                ptbLoad.Visible = false;
            }
            else
            {
                KetNoi();
                LoadData();
                Show_NV();
                Show_Khu();
                Show_Que();
                lockControl();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                txtMaNV.ReadOnly = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setNull();
            txtMaNV.Text = TangMa();
            them = true;
            unlockControl();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            //btnLuu.Visible = true;
            btnHuy.Enabled = true;
            dgvNhanVien.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            unlockControl();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            dgvNhanVien.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên " + txtTenNV.Text.Trim() + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Xoa_NhanVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Manv", txtMaNV.Text.Trim());

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

        string sql = "";

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                if (cbbKieuTK.Text == "Theo Mã Nhân Viên")
                {
                    sql = "select *from NhanVien where MaNV = '" + txtTimKiem.Text.Trim() + "'";
                    
                }
                else if (cbbKieuTK.Text == "Theo Tên Nhân Viên")
                { 
                    sql = "select *from NhanVien where TenNV like N'%" + txtTimKiem.Text.Trim() + "%'";
                }
                else if (cbbKieuTK.Text == "Theo Mã Phòng Ban")
                {
                    sql = "select *from NhanVien where MaPB = '" + txtTimKiem.Text.Trim() + "'";
                }
                else if (cbbKieuTK.Text == "Theo Mã Khu phụ trách ")
                {
                    sql = "select *from NhanVien where MaKhuPhuTrach = '" + txtTimKiem.Text.Trim() + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                dgvNhanVien.DataSource = dt;
            }
            catch(Exception ex)
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

        private void cbbKieuTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(null, null);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Them_NhanVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Manv", txtMaNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tennv", txtTenNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ngaysinh", dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text.Trim());
                    cmd.Parameters.AddWithValue("@Vitriphutrach", txtVTPT.Text.Trim());
                    cmd.Parameters.AddWithValue("@Makhupt", cboMaKhuPT.SelectedValue);
                    cmd.Parameters.AddWithValue("@Mapb", cboMaPB.SelectedValue);
                    cmd.Parameters.AddWithValue("@Luong", txtLuong.Text.Trim());
                    cmd.Parameters.AddWithValue("@Quequan", cboQueQuan.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm!");

                    string sql = "select *from NhanVien where MaNV = '"+txtMaNV.Text.Trim()+"'";
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvNhanVien.DataSource = dt;
                    //KetNoi();
                    //int tmp = dgvNhanVien.RowCount;
                    ////MessageBox.Show("" + dgvNhanVien.Rows[1].Cells[0].Value.ToString().Trim()+"1 ");
                    ////dgvNhanVien.Rows[2].Selected = true;
                    //for (int i = 0; i < tmp-1; i++)
                    //{
                    //    if (dgvNhanVien.Rows[i].Cells[0].Value.ToString().Trim() == txtMaNV.Text.Trim())
                    //    {
                    //        //MessageBox.Show("" + dgvNhanVien.Rows[i].Cells[0].Value.ToString());
                    //        dgvNhanVien.Rows[i].Selected = true;
                    //    }
                    //}

                    //LoadData();
                    
                    lockControl();
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    dgvNhanVien.Enabled = true;
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
                    SqlCommand cmd = new SqlCommand("Update_NhanVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Manv", txtMaNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tennv", txtTenNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ngaysinh", dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text.Trim());
                    cmd.Parameters.AddWithValue("@Vitriphutrach", txtVTPT.Text.Trim());
                    cmd.Parameters.AddWithValue("@Makhupt", cboMaKhuPT.SelectedValue);
                    cmd.Parameters.AddWithValue("@Mapb", cboMaPB.SelectedValue);
                    cmd.Parameters.AddWithValue("@Luong", txtLuong.Text.Trim());
                    cmd.Parameters.AddWithValue("@Quequan", cboQueQuan.SelectedValue);

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
                    dgvNhanVien.Enabled = true; 
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
            dgvNhanVien.Enabled = true;
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvNhanVien.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            ptbLoad.Visible = true;
            SaveFileDialog fsave = new SaveFileDialog();

            fsave.Filter = "(Tất cả các tệp)|*.*|(các tệp excel)|*.xlsx";
            fsave.ShowDialog();

            if (fsave.FileName != "")
            {
                COMExcel.Application exApp = new COMExcel.Application();
                COMExcel.Workbook exBook;
                COMExcel.Worksheet exSheet;
                COMExcel.Range exRange;

                exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
                exSheet = exBook.Worksheets[1];
                // Định dạng chung
                exRange = exSheet.Cells[1, 1];
                exRange.Range["A1:B3"].Font.Size = 10;
                exRange.Range["A1:B3"].Font.Name = "Times new roman";
                exRange.Range["A1:B3"].Font.Bold = true;
                exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời

                exRange.Range["A1:A1"].ColumnWidth = 7;

                exRange.Range["B1:B1"].ColumnWidth = 15;

                exRange.Range["A1:B1"].MergeCells = true;
                exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:B1"].Value = "Quản lý khu vui chơi";

                exRange.Range["A1: A100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["D1: D100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["F1: F100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["G1: G100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["H1: H100"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

                exRange.Range["A2:B2"].MergeCells = true;
                exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:B2"].Value = "Nhân Viên";

                exRange.Range["A3:B3"].MergeCells = true;
                exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

                exRange.Range["C2:E2"].Font.Size = 16;
                exRange.Range["C2:E2"].Font.Name = "Times new roman";
                exRange.Range["C2:E2"].Font.Bold = true;
                exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
                exRange.Range["C2:E2"].MergeCells = true;
                exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C2:E2"].Value = "Danh Sách Nhân Viên";

                exRange.Range["A5"].ColumnWidth = 15;
                exRange.Range["B5"].ColumnWidth = 25;
                exRange.Range["C5"].ColumnWidth = 15;
                exRange.Range["D5"].ColumnWidth = 15;
                exRange.Range["E5"].ColumnWidth = 30;
                exRange.Range["F5"].ColumnWidth = 15;
                exRange.Range["G5"].ColumnWidth = 15;
                exRange.Range["H5"].ColumnWidth = 15;


                exRange.Range["A5:I5"].Font.Size = 12;
                exRange.Range["A5:I5"].Font.Bold = true;
                exRange.Range["A5:I5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

                //Lấy tên cột dữ liệu
                for (int i = 0; i < dgvNhanVien.ColumnCount ; i++)
                {
                    exSheet.Cells[5, i + 1] = dgvNhanVien.Columns[i].HeaderText;
                }
                //Đổ dữ liệu vào sheet
                for (int i = 0; i < dgvNhanVien.RowCount ; i++)
                {
                    for (int j = 0; j < dgvNhanVien.ColumnCount ; j++)
                    {
                        exSheet.Cells[i + 6, j + 1] = dgvNhanVien.Rows[i].Cells[j].Value;
                    }
                }

                DateTime d = DateTime.Now;
                exRange.Range["C3:E3"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
                exRange.Range["C3:E3"].MergeCells = true;
                exRange.Range["C3:E3"].Font.Italic = true;
                exRange.Range["C3:E3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

               
                exApp.Visible = true;

                exBook.SaveAs(fsave.FileName);
                ptbLoad.Visible = false;
            }
            else
            {
                MessageBox.Show("Bạn phải nhập tên!");
                ptbLoad.Visible = false;
            }  

        }

        private void btnImport_Ex_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "(Tất cả các tệp)|*.*|(các tệp excel)|*.xls";

            if (opd.ShowDialog() == DialogResult.OK)
            { 
                try
                {
                    var conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + opd.FileName + " ; Extended Properties= \"Excel 8.0;HDR = Yes; IMEX= 1\"");
                    var table = new System.Data.DataTable();
                    var dap = new OleDbDataAdapter("select *from [Sheet1$]", conn);
                    dap.Fill(table);
                    //dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2));
                    //dgvNhanVien.DataSource = table;
                    //MessageBox.Show("Thành công"); 
                    int dem = 0;

                    foreach (DataRow r in table.Rows )
                    {
                       // MessageBox.Show(Convert.ToString(r[0].ToString().Substring(0,2)));
                        if (r[1].ToString() != string.Empty && Convert.ToString(r[1].ToString().Substring(0,2)) == "nv")
                        {
                            SqlConnection connect = new SqlConnection(DataAccess.ConnectionString.connectionString);
                            connect.Open();
                            SqlCommand cmd = new SqlCommand("XemNhanVien", connect);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@Manv", r[1].ToString());
                            cmd.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                SqlCommand cmd1 = new SqlCommand("Them_NhanVien", connect);
                                cmd1.CommandType = CommandType.StoredProcedure;

                                cmd1.Parameters.Add("@Manv", r[1].ToString());
                                cmd1.Parameters.Add("@Tennv", r[2].ToString());
                                cmd1.Parameters.Add("@Ngaysinh", Convert.ToDateTime(r[3]));
                                cmd1.Parameters.Add("@Gioitinh", r[4].ToString());
                                cmd1.Parameters.Add("@Vitriphutrach", r[5].ToString());
                                cmd1.Parameters.Add("@Makhupt", r[6].ToString());
                                cmd1.Parameters.Add("@Mapb", r[7].ToString());
                                cmd1.Parameters.Add("@Luong", r[8].ToString());
                                cmd1.Parameters.Add("@Quequan", r[9].ToString());

                                cmd1.ExecuteNonQuery();
                                dem++;
                            }
                        }
                        
                    }

                    if (dem == 0)
                    {
                        MessageBox.Show("Không có bản ghi được thêm mới!");
                    }
                    else
                    {
                        MessageBox.Show("" + dem + " bản ghi được thêm mới!");
                    }
                    btnRefresh_Click(null, null);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại!" + ex.Message);
                }
            }

            
        }

        private void btnThemQue_Click(object sender, EventArgs e)
        {
            frmQueQuan q = new frmQueQuan();
            q.ShowDialog();
        }

        private void dgvNhanVien_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }  

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            if (txtTenNV.Text.Length == 0)
            {
                err.SetError(txtTenNV, "Không được để tên trống");
            }
            if (!Regex.IsMatch(txtTenNV.Text, "[a-zA-A]+$"))
            {
                err.SetError(txtTenNV, "Tên không đúng!");
            }
            else
            {
                err.Clear();
            }
        }

        private void cboGioiTinh_TextChanged(object sender, EventArgs e)
        {
            if (cboGioiTinh.Text.Length == 0)
            {
                err2.SetError(cboGioiTinh, "Không được để tên trống");
            }
            else
            {
                err2.Clear();
            }
        }

        private void cboMaPB_TextChanged(object sender, EventArgs e)
        {
            if (cboMaPB.Text.Length == 0)
            {
                err3.SetError(cboMaPB, "Không được để tên trống");
            }
            else
            {
                err3.Clear();
            }
        }

        private void txtVTPT_TextChanged(object sender, EventArgs e)
        {
            if (txtVTPT.Text.Length == 0)
            {
                err4.SetError(txtVTPT, "Không được để tên trống");
            }
            else
            {
                err4.Clear();
            }
        }

        private void cboMaKhuPT_TextChanged(object sender, EventArgs e)
        {
            if (cboMaKhuPT.Text.Length == 0)
            {
                err5.SetError(cboMaKhuPT, "Không được để tên trống");
            }
            else
            {
                err5.Clear();
            }
        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtLuong.Text.Length == 0)
            {
                err1.SetError(txtLuong, "Không được để tên trống");
            }
            if (Regex.IsMatch(txtLuong.Text, "[a-zA-A]+$"))
            {
                err1.SetError(txtLuong, "Lương không nhập chữ hoặc ký tự!");
            }
            else
            {
                err1.Clear();
            }
        }

        
    }
}
