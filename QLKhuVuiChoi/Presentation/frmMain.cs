using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace QLKhuVuiChoi.Presentation
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        static frmMain _instance;
        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMain();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return mPanel; }
            set { mPanel = value; }
        }

        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return mlBack; }
            set { mlBack = value; }
        }

        public frmMain()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            InitializeComponent();
            Thread.Sleep(1500);
            t.Abort();
        }

        void Splash()
        {
            Presentation.flash f = new Presentation.flash();
            f.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(DataAccess.Quyen.MaQuyen);
            _instance = this;
            ucDashboard uc = new ucDashboard();
            uc.Dock = DockStyle.Fill;
            mPanel.Controls.Add(uc);
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            mPanel.Controls["ucDashboard"].BringToFront();
            mlBack.Visible = true;  
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            //this.Close();
        }


    }
}
