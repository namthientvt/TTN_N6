using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhuVuiChoi.Presentation
{
    public partial class ucWebBrowser : UserControl
    {
        public ucWebBrowser()
        {
            InitializeComponent();
        }

        private void ucWebBrowser_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://google.com.vn");
            webBrowser1.DocumentCompleted += webBrowser1_DoccumentComplete;
            txtGoogle.Text = "";
        }

        private void WebTab_DoccumentComplete(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webtab.DocumentTitle; 
        }

        WebBrowser webtab = null;

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New tab";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            webtab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webtab.Parent = tab;
            webtab.Dock = DockStyle.Fill;
            webtab.Navigate("http://google.com.vn");
            //txtUrl.Text = ""+ webBrowser1.Url;      
            webtab.DocumentCompleted += WebTab_DoccumentComplete;
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            web.Stop();
        }

        private void txtGoogle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate("https://www.google.com.vn/search?q=" + txtGoogle.Text);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                {
                    web.GoBack();
                }
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                {
                    web.GoForward();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            web.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            web.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                web.Navigate("http://google.com.vn");
            }
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            int t = 0;
            t++;
            if (t > 75) t -= 50;
            progressBar1.Value = 0;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtUrl.Text = "" + webBrowser1.Url;
            int t = 100 - progressBar1.Value;
            progressBar1.Value += t;
            progressBar1.Visible = true;
        }

        private void webBrowser1_DoccumentComplete(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webBrowser1.DocumentTitle;
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate("http://"+txtUrl.Text);
                }
            }
        }


    }
}
