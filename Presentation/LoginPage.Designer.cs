namespace BookingSystem
{
    partial class LoginPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblLoginCopyright = new System.Windows.Forms.Label();
            this.gBLogin = new System.Windows.Forms.GroupBox();
            this.lblForgot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbVisible = new System.Windows.Forms.PictureBox();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.LoginPanelCyan = new System.Windows.Forms.Panel();
            this.LoginPanelWood = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbLoginLogo = new System.Windows.Forms.PictureBox();
            this.gBLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.LoginPanelCyan.SuspendLayout();
            this.LoginPanelWood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginCopyright
            // 
            this.lblLoginCopyright.AutoSize = true;
            this.lblLoginCopyright.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginCopyright.Location = new System.Drawing.Point(12, 49);
            this.lblLoginCopyright.Name = "lblLoginCopyright";
            this.lblLoginCopyright.Size = new System.Drawing.Size(432, 23);
            this.lblLoginCopyright.TabIndex = 0;
            this.lblLoginCopyright.Text = "Copyright © 2024 Hotel Mangement Project";
            this.lblLoginCopyright.Click += new System.EventHandler(this.label1_Click);
            // 
            // gBLogin
            // 
            this.gBLogin.BackColor = System.Drawing.Color.Transparent;
            this.gBLogin.Controls.Add(this.lblForgot);
            this.gBLogin.Controls.Add(this.label3);
            this.gBLogin.Controls.Add(this.txtPassword);
            this.gBLogin.Controls.Add(this.btnLogin);
            this.gBLogin.Controls.Add(this.txtUsername);
            this.gBLogin.Controls.Add(this.label2);
            this.gBLogin.Controls.Add(this.pbVisible);
            this.gBLogin.Controls.Add(this.pictureBoxShow);
            this.gBLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBLogin.Location = new System.Drawing.Point(122, 154);
            this.gBLogin.Name = "gBLogin";
            this.gBLogin.Size = new System.Drawing.Size(457, 371);
            this.gBLogin.TabIndex = 0;
            this.gBLogin.TabStop = false;
            this.gBLogin.Text = "Login ";
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgot.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblForgot.Location = new System.Drawing.Point(118, 214);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(214, 28);
            this.lblForgot.TabIndex = 5;
            this.lblForgot.Text = "Forgot Password?";
            this.lblForgot.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(53, 153);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(289, 37);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(53, 255);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(327, 44);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseHover += new System.EventHandler(this.btnLogin_MouseHover);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(53, 77);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(328, 37);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // pbVisible
            // 
            this.pbVisible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVisible.Image = ((System.Drawing.Image)(resources.GetObject("pbVisible.Image")));
            this.pbVisible.Location = new System.Drawing.Point(348, 153);
            this.pbVisible.Name = "pbVisible";
            this.pbVisible.Size = new System.Drawing.Size(33, 37);
            this.pbVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVisible.TabIndex = 6;
            this.pbVisible.TabStop = false;
            this.pbVisible.Click += new System.EventHandler(this.pictureBoxHide_Click);
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShow.Image")));
            this.pictureBoxShow.Location = new System.Drawing.Point(348, 153);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(33, 27);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShow.TabIndex = 4;
            this.pictureBoxShow.TabStop = false;
            this.pictureBoxShow.Click += new System.EventHandler(this.pictureBoxShow_Click);
            // 
            // LoginPanelCyan
            // 
            this.LoginPanelCyan.BackColor = System.Drawing.Color.DarkCyan;
            this.LoginPanelCyan.Controls.Add(this.lblLoginCopyright);
            this.LoginPanelCyan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanelCyan.ForeColor = System.Drawing.Color.Black;
            this.LoginPanelCyan.Location = new System.Drawing.Point(0, 604);
            this.LoginPanelCyan.Name = "LoginPanelCyan";
            this.LoginPanelCyan.Size = new System.Drawing.Size(782, 75);
            this.LoginPanelCyan.TabIndex = 3;
            this.LoginPanelCyan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LoginPanelWood
            // 
            this.LoginPanelWood.BackColor = System.Drawing.Color.BurlyWood;
            this.LoginPanelWood.Controls.Add(this.panel3);
            this.LoginPanelWood.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginPanelWood.Location = new System.Drawing.Point(0, 594);
            this.LoginPanelWood.Name = "LoginPanelWood";
            this.LoginPanelWood.Size = new System.Drawing.Size(782, 10);
            this.LoginPanelWood.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(0, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1366, 10);
            this.panel3.TabIndex = 5;
            // 
            // pbLoginLogo
            // 
            this.pbLoginLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLoginLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLoginLogo.Image")));
            this.pbLoginLogo.Location = new System.Drawing.Point(105, -12);
            this.pbLoginLogo.Name = "pbLoginLogo";
            this.pbLoginLogo.Size = new System.Drawing.Size(479, 160);
            this.pbLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoginLogo.TabIndex = 5;
            this.pbLoginLogo.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 679);
            this.Controls.Add(this.pbLoginLogo);
            this.Controls.Add(this.LoginPanelWood);
            this.Controls.Add(this.LoginPanelCyan);
            this.Controls.Add(this.gBLogin);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.gBLogin.ResumeLayout(false);
            this.gBLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.LoginPanelCyan.ResumeLayout(false);
            this.LoginPanelCyan.PerformLayout();
            this.LoginPanelWood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblLoginCopyright;
        private System.Windows.Forms.GroupBox gBLogin;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbVisible;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Panel LoginPanelCyan;
        private System.Windows.Forms.Panel LoginPanelWood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbLoginLogo;
    }
}