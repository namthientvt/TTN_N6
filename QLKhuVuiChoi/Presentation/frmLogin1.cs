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
    public partial class frmLogin1 : MetroFramework.Forms.MetroForm
    {
        public frmLogin1()
        {
            InitializeComponent();
        }

        private void KiemTra()
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                string sql = "select *from LOGIN where USERNAME = '" + txtUserName.Text + "' and PASSWORD = '" + txtPassWord.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DataAccess.Quyen.MaQuyen = dt.Rows[0][2].ToString();
                    this.Hide();
                    frmMain m = new frmMain();
                    m.ShowDialog();
                }
                else
                {
                    //MessageBox.Show("Xem lại!");
                    MetroFramework.MetroMessageBox.Show(this, "Sai thông tin tài khoản", "Message",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra lại kết nối tới CSDL\n" + ex.Message);
            }
        }

        private void Login1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            KiemTra();
        }

        private void metroTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    KiemTra();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Kiểm tra lại kết nối tới CSDL\n" + ex.Message);
                    //MessageBox.Show("Kiểm tra lại kết nối tới CSDL\n" + ex.Message);
                }
            }
        }

    }
}
