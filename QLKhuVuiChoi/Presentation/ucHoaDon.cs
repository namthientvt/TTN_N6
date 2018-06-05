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
    public partial class ucHoaDon : UserControl
    {
        public ucHoaDon()
        {
            InitializeComponent();
        }

        private bool themmoi;

        private void Show_Khu()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaKhu, TenKhu from KhuTroChoi", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboMaKhu.DataSource = dt;
            cboMaKhu.DisplayMember = "TenKhu";
            cboMaKhu.ValueMember = "MaKhu";
        }

        public void Ketnoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                string sql = "select hd.MaHoaDon, MaKH, MaDV, NgayHoaDon, GiaDV, SoLuongDV,ThanhTien from HoaDon hd, ChiTietHoaDon ct where hd.MaHoaDon=ct.MaHoaDon";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataView dv = new DataView(dt);
                dgvHoaDon.DataSource = dv;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void LockControl()
        {
            txtMaHD.Enabled = false;
            txtMaKH.Enabled = false;
            cboDichVu.Enabled = false;
            dtpNgayHD.Enabled = false;
            txtGiaDV.Enabled = false;
            txtSoLuongDV.Enabled = false;
            txtThanhTien.Enabled = false;
        }

        public void UnLockControl()
        {
            txtMaHD.Enabled = true;
            txtMaKH.Enabled = true;
            cboDichVu.Enabled = true;
            dtpNgayHD.Enabled = true;
            txtGiaDV.Enabled = true;
            txtSoLuongDV.Enabled = true;
            txtThanhTien.Enabled = true;
        }

        public void SetNull()
        {
            txtMaKH.Text = "";
            cboDichVu.Text = "";
            txtGiaDV.Text = "";
            txtSoLuongDV.Text = "";
            txtThanhTien.Text = "";
        }


        private void ucHoaDon_Load(object sender, EventArgs e)
        {
            Ketnoi();
            LockControl();
            btnLuu.Enabled = false;
            Show_Khu();
        }


        public string TangMa()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select hd.MaHoaDon, MaKH, MaDV, NgayHoaDon, GiaDV, SoLuongDV,ThanhTien from HoaDon hd, ChiTietHoaDon ct where hd.MaHoaDon=ct.MaHoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "hd01";
            }
            else
            {
                int k = 0;
                ma = "hd";
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

        private void Thanhtien()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_XemHD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", txtMaHD.Text.Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            int sldv = Convert.ToInt32(txtSoLuongDV.Text);
            int giadv = Convert.ToInt32(txtGiaDV.Text);

            int thanhtien = sldv * giadv;
            txtThanhTien.Text = thanhtien.ToString();
        }


        private void Show_DV()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaDV, TenDV from DichVu", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            cboDichVu.DataSource = dt;
            cboDichVu.DisplayMember = "TenDV";
            cboDichVu.ValueMember = "MaDV";
        }


       
        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLockControl();
            btnSua.Enabled = false;
            btnXoa.Enabled = false; ;
            btnTimKiem.Enabled = false;

            themmoi = true;
            SetNull();
            txtMaHD.Text = TangMa(); 
            
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnLockControl();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnTimKiem.Enabled = false;

            themmoi = false;
            
        }

       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(themmoi==true)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_ThemHD1", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim());
                    ////cmd.Parameters.AddWithValue("@Madv", txtMaDV.Text.Trim());//
                    cmd.Parameters.AddWithValue("@Madv", cboDichVu.SelectedValue);
                    cmd.Parameters.AddWithValue("@NgayHD", dtpNgayHD.Value);
                   
                    cmd.Parameters.AddWithValue("@Makh", txtMaKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@Giadv", txtGiaDV.Text.Trim());
                    cmd.Parameters.AddWithValue("@SLDV", txtSoLuongDV.Text.Trim());
                    cmd.Parameters.AddWithValue("@Thanhtien", txtThanhTien.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm mới thành công");
                    
                    Ketnoi();
                    //btnSua.Enabled = true;
                    //btnXoa.Enabled = true;
                    btnRef_Click(null, null);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
                
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_SuaHD1", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim());
                    cmd.Parameters.AddWithValue("@Madv", cboDichVu.SelectedValue);
                    ////cmd.Parameters.AddWithValue("@Madv", txtMaDV.Text.Trim());//
                    cmd.Parameters.AddWithValue("@NgayHD", dtpNgayHD.Value);
                    cmd.Parameters.AddWithValue("@Makh", txtMaKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@Giadv", txtGiaDV.Text.Trim());
                    cmd.Parameters.AddWithValue("@SLDV", txtSoLuongDV.Text.Trim());
                    cmd.Parameters.AddWithValue("@Thanhtien", txtThanhTien.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa thành công");
                    Ketnoi();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có muốn xóa Hóa Đơn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_XoaHD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim());

                    cmd.ExecuteNonQuery();

                    
                    
                }
                MessageBox.Show("Xóa thành công!!");
                Ketnoi();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi "+ex.Message);
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaHD.Text = dgvHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                txtMaKH.Text = dgvHoaDon.CurrentRow.Cells["MaKH"].Value.ToString();
                ///txtMaDV.Text = dgvHoaDon.CurrentRow.Cells["MaDV"].Value.ToString();
                cboDichVu.Text=dgvHoaDon.CurrentRow.Cells["MaDV"].Value.ToString();
                dtpNgayHD.Text = dgvHoaDon.CurrentRow.Cells["NgayHoaDon"].Value.ToString();
                txtGiaDV.Text = dgvHoaDon.CurrentRow.Cells["GiaDV"].Value.ToString();
                txtSoLuongDV.Text = dgvHoaDon.CurrentRow.Cells["SoLuongDV"].Value.ToString();
                txtThanhTien.Text = dgvHoaDon.CurrentRow.Cells["ThanhTien"].Value.ToString();


            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            Ketnoi();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            SetNull();
        }

        string sql = "";
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                if (cboTimKiem.Text == "Mã Hóa Đơn")
                {
                    sql = "select hd.MaHoaDon, MaKH, MaDV, NgayHoaDon, GiaDV, SoLuongDV,ThanhTien from HoaDon hd, ChiTietHoaDon ct where hd.MaHoaDon=ct.MaHoaDon and hd.MaHoaDon = '" + txtTimKiem.Text.Trim() + "'";
                }
                else if(cboTimKiem.Text == "Mã Khách Hàng")
                {
                    sql = "select hd.MaHoaDon, MaKH, MaDV, NgayHoaDon, GiaDV, SoLuongDV,ThanhTien from HoaDon hd, ChiTietHoaDon ct where hd.MaHoaDon=ct.MaHoaDon and MaKH = '" + txtTimKiem.Text.Trim() + "'";
                }
                else if(cboTimKiem.Text == "Mã Dịch Vụ")
                {
                    sql = "select hd.MaHoaDon, MaKH, MaDV, NgayHoaDon, GiaDV, SoLuongDV,ThanhTien from HoaDon hd, ChiTietHoaDon ct where hd.MaHoaDon=ct.MaHoaDon and MaDV = '" + txtTimKiem.Text.Trim() + "'";
                }
                else if(cboTimKiem.Text == "Ngày Hóa Đơn(yyyy-MM-dd)")
                {
                    sql = "select hd.MaHoaDon, MaKH, MaDV, NgayHoaDon, GiaDV, SoLuongDV,ThanhTien from HoaDon hd, ChiTietHoaDon ct where hd.MaHoaDon=ct.MaHoaDon and NgayHoaDon = '" + txtTimKiem.Text.Trim() + "'";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHoaDon.DataSource = dt;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtThanhTien_MouseClick(object sender, MouseEventArgs e)
        {
            Thanhtien();
        }

       

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (textMKH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng!");
                ActiveControl = textMKH;
                return;
            }
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from KhachHang where MaKH= '" + textMKH.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataAccess.XuatHD.MaKH = textMKH.Text.Trim();
                frmXuatHoaDon kc = new frmXuatHoaDon();
                kc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng này trong CSDL!");
            }
        }

        private void cboMaKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaDV, TenDV from DichVu where MaKhu = '" + cboMaKhu.SelectedValue + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboDichVu.DataSource = dt;
            cboDichVu.DisplayMember = "TenDV";
            cboDichVu.ValueMember = "MaDV";
        }

        private void KiemTraVe()
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("KiemTraVe", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());
            cmd.Parameters.AddWithValue("@MaKhu", cboMaKhu.SelectedValue);
            cmd.Parameters.AddWithValue("@NgayBan", dtpNgayHD.Value);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                btnLuu.Enabled = false;
                MessageBox.Show("Khách hàng chưa mua vé vào cửa!");
                ActiveControl = txtMaKH;
                return;
            }
            else
            {
                btnLuu.Enabled = true;
                MessageBox.Show("Vé hợp lệ!");
            }
        }


    
        
    }
}
