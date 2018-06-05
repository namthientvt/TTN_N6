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
    public partial class ucCreatAcc : UserControl
    {
        public ucCreatAcc()
        {
            InitializeComponent();
        }

        public void Reset ()
        {
            txtUserName.Text = "";
            txtPassWord.Text = "";
            txtRePassword.Text = "";
            txtQuyen.Text = "";
            cbAccept.Checked= false;
        }

       
        private void bbtReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassWord.Text == "" || txtRePassword.Text == "" || txtQuyen.Text == "" || cbAccept.Checked == false || txtPassWord.Text != txtRePassword.Text )
            {
                Reset();
            }
            else 
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("createAccount", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Uname", txtUserName.Text.Trim());
                cmd.Parameters.AddWithValue("@Pass", txtPassWord.Text.Trim());
                cmd.Parameters.AddWithValue("@MaQuyen", txtQuyen.Text.Trim());
                //cmd.Parameters.AddWithValue("@sdt", txtPhone.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm!");
       
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
