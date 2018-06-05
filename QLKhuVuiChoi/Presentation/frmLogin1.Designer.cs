namespace QLKhuVuiChoi.Presentation
{
    partial class frmLogin1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.txtPassWord = new MetroFramework.Controls.MetroTextBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(133, 152);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(255, 25);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Checked = true;
            this.metroCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBox1.Location = new System.Drawing.Point(133, 122);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(95, 15);
            this.metroCheckBox1.TabIndex = 3;
            this.metroCheckBox1.Text = "Lưu tài khoản";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(283, 123);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(101, 15);
            this.metroCheckBox2.TabIndex = 4;
            this.metroCheckBox2.Text = "Hiện mật khẩu";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // txtPassWord
            // 
            // 
            // 
            // 
            this.txtPassWord.CustomButton.Image = null;
            this.txtPassWord.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.txtPassWord.CustomButton.Name = "";
            this.txtPassWord.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassWord.CustomButton.TabIndex = 1;
            this.txtPassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassWord.CustomButton.UseSelectable = true;
            this.txtPassWord.CustomButton.Visible = false;
            this.txtPassWord.DisplayIcon = true;
            this.txtPassWord.Icon = global::QLKhuVuiChoi.Properties.Resources.if_icons_password_1564520;
            this.txtPassWord.Lines = new string[] {
        "123"};
            this.txtPassWord.Location = new System.Drawing.Point(133, 92);
            this.txtPassWord.MaxLength = 32767;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '●';
            this.txtPassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.SelectionLength = 0;
            this.txtPassWord.SelectionStart = 0;
            this.txtPassWord.Size = new System.Drawing.Size(255, 23);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.Text = "123";
            this.txtPassWord.UseSelectable = true;
            this.txtPassWord.UseSystemPasswordChar = true;
            this.txtPassWord.WaterMark = "Mật khẩu";
            this.txtPassWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBox2_KeyDown);
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.DisplayIcon = true;
            this.txtUserName.Icon = global::QLKhuVuiChoi.Properties.Resources.if_user_avatar_human_admin_login_22035491;
            this.txtUserName.Lines = new string[] {
        "trunghieu"};
            this.txtUserName.Location = new System.Drawing.Point(133, 63);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.Size = new System.Drawing.Size(255, 23);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "trunghieu";
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMark = "Tên đăng nhập";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKhuVuiChoi.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(24, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 187);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLogin1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroTextBox txtPassWord;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
    }
}