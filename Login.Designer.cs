
namespace ProyectoFinal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLogIn = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.linkLabelForgotPass = new System.Windows.Forms.LinkLabel();
            this.iconPicBoxSymbol = new FontAwesome.Sharp.IconPictureBox();
            this.errorPUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.CadetBlue;
            this.panelLogo.Controls.Add(this.btnClose);
            this.panelLogo.Controls.Add(this.btnMinimize);
            this.panelLogo.Controls.Add(this.picBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(333, 124);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(311, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(19, 19);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(290, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 19);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(17, -16);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(293, 137);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 3;
            this.picBoxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(38, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "_______________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(38, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "_______________________________________";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUser.Location = new System.Drawing.Point(41, 191);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(238, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "USERNAME";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            this.txtUser.Validated += new System.EventHandler(this.txtUser_Validated);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.Location = new System.Drawing.Point(41, 249);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(238, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "PASSWORD";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            this.txtPass.Validated += new System.EventHandler(this.txtPass_Validated);
            // 
            // txtLogIn
            // 
            this.txtLogIn.BackColor = System.Drawing.Color.White;
            this.txtLogIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogIn.Enabled = false;
            this.txtLogIn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogIn.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtLogIn.Location = new System.Drawing.Point(62, 136);
            this.txtLogIn.Name = "txtLogIn";
            this.txtLogIn.Size = new System.Drawing.Size(159, 30);
            this.txtLogIn.TabIndex = 6;
            this.txtLogIn.Text = "LOG IN";
            this.txtLogIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(41, 305);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(238, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkLabelSignUp
            // 
            this.linkLabelSignUp.ActiveLinkColor = System.Drawing.Color.CadetBlue;
            this.linkLabelSignUp.AutoSize = true;
            this.linkLabelSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabelSignUp.Location = new System.Drawing.Point(62, 369);
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.Size = new System.Drawing.Size(186, 13);
            this.linkLabelSignUp.TabIndex = 5;
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.Text = "You don\'t have an account? Sign Up!";
            this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUp_LinkClicked);
            // 
            // linkLabelForgotPass
            // 
            this.linkLabelForgotPass.ActiveLinkColor = System.Drawing.Color.CadetBlue;
            this.linkLabelForgotPass.AutoSize = true;
            this.linkLabelForgotPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabelForgotPass.Location = new System.Drawing.Point(108, 345);
            this.linkLabelForgotPass.Name = "linkLabelForgotPass";
            this.linkLabelForgotPass.Size = new System.Drawing.Size(92, 13);
            this.linkLabelForgotPass.TabIndex = 4;
            this.linkLabelForgotPass.TabStop = true;
            this.linkLabelForgotPass.Text = "Forgot Password?";
            this.linkLabelForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForgotPass_LinkClicked);
            // 
            // iconPicBoxSymbol
            // 
            this.iconPicBoxSymbol.BackColor = System.Drawing.Color.White;
            this.iconPicBoxSymbol.ForeColor = System.Drawing.Color.Goldenrod;
            this.iconPicBoxSymbol.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPicBoxSymbol.IconColor = System.Drawing.Color.Goldenrod;
            this.iconPicBoxSymbol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxSymbol.IconSize = 33;
            this.iconPicBoxSymbol.Location = new System.Drawing.Point(191, 136);
            this.iconPicBoxSymbol.Name = "iconPicBoxSymbol";
            this.iconPicBoxSymbol.Size = new System.Drawing.Size(41, 33);
            this.iconPicBoxSymbol.TabIndex = 7;
            this.iconPicBoxSymbol.TabStop = false;
            // 
            // errorPUsername
            // 
            this.errorPUsername.ContainerControl = this;
            this.errorPUsername.Icon = ((System.Drawing.Icon)(resources.GetObject("errorPUsername.Icon")));
            // 
            // errorPPassword
            // 
            this.errorPPassword.ContainerControl = this;
            this.errorPPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("errorPPassword.Icon")));
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(333, 400);
            this.Controls.Add(this.iconPicBoxSymbol);
            this.Controls.Add(this.linkLabelForgotPass);
            this.Controls.Add(this.linkLabelSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLogIn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLogIn;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.LinkLabel linkLabelForgotPass;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxSymbol;
        private System.Windows.Forms.ErrorProvider errorPUsername;
        private System.Windows.Forms.ErrorProvider errorPPassword;
    }
}