
namespace ProyectoFinal
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBLogo = new System.Windows.Forms.PictureBox();
            this.txtLForgotPass = new System.Windows.Forms.TextBox();
            this.iconPicBoxSymbol = new FontAwesome.Sharp.IconPictureBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecover = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.CadetBlue;
            this.panelLogo.Controls.Add(this.btnMinimize);
            this.panelLogo.Controls.Add(this.btnClose);
            this.panelLogo.Controls.Add(this.pictureBLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(472, 136);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(424, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 19);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(450, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(19, 19);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBLogo
            // 
            this.pictureBLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBLogo.Image")));
            this.pictureBLogo.Location = new System.Drawing.Point(148, 0);
            this.pictureBLogo.Name = "pictureBLogo";
            this.pictureBLogo.Size = new System.Drawing.Size(186, 133);
            this.pictureBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBLogo.TabIndex = 0;
            this.pictureBLogo.TabStop = false;
            // 
            // txtLForgotPass
            // 
            this.txtLForgotPass.BackColor = System.Drawing.Color.White;
            this.txtLForgotPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLForgotPass.Enabled = false;
            this.txtLForgotPass.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLForgotPass.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtLForgotPass.Location = new System.Drawing.Point(95, 142);
            this.txtLForgotPass.Name = "txtLForgotPass";
            this.txtLForgotPass.Size = new System.Drawing.Size(239, 30);
            this.txtLForgotPass.TabIndex = 1;
            this.txtLForgotPass.Text = "FORGOT PASSWORD";
            this.txtLForgotPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconPicBoxSymbol
            // 
            this.iconPicBoxSymbol.BackColor = System.Drawing.Color.White;
            this.iconPicBoxSymbol.ForeColor = System.Drawing.Color.Goldenrod;
            this.iconPicBoxSymbol.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPicBoxSymbol.IconColor = System.Drawing.Color.Goldenrod;
            this.iconPicBoxSymbol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxSymbol.IconSize = 33;
            this.iconPicBoxSymbol.Location = new System.Drawing.Point(340, 142);
            this.iconPicBoxSymbol.Name = "iconPicBoxSymbol";
            this.iconPicBoxSymbol.Size = new System.Drawing.Size(41, 33);
            this.iconPicBoxSymbol.TabIndex = 8;
            this.iconPicBoxSymbol.TabStop = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(24, 175);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(420, 80);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Don´t worry!\r\nTo recover your password, just write your E-mail adress,\r\neach Pass" +
    "word to send you information about \r\nyour password. Don\'t forget your username.\r" +
    "\nEverything it\'s gonna be alright =)";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(118, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "EMAIL";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(115, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "_______________________________________";
            // 
            // txtEmailPass
            // 
            this.txtEmailPass.BackColor = System.Drawing.Color.White;
            this.txtEmailPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmailPass.Location = new System.Drawing.Point(118, 309);
            this.txtEmailPass.Name = "txtEmailPass";
            this.txtEmailPass.Size = new System.Drawing.Size(238, 20);
            this.txtEmailPass.TabIndex = 5;
            this.txtEmailPass.Text = "EMAIL PASSWORD";
            this.txtEmailPass.Enter += new System.EventHandler(this.txtEmailPass_Enter);
            this.txtEmailPass.Leave += new System.EventHandler(this.txtEmailPass_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(115, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "_______________________________________";
            // 
            // btnRecover
            // 
            this.btnRecover.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecover.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecover.Location = new System.Drawing.Point(178, 397);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(122, 31);
            this.btnRecover.TabIndex = 9;
            this.btnRecover.Text = "Recover";
            this.btnRecover.UseVisualStyleBackColor = false;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(118, 354);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(238, 20);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Text = "USERNAME";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(115, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "_______________________________________";
            // 
            // ForgotPassword
            // 
            this.AcceptButton = this.btnRecover;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 440);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.txtEmailPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.iconPicBoxSymbol);
            this.Controls.Add(this.txtLForgotPass);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForgotPassword_MouseDown);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxSymbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBLogo;
        private System.Windows.Forms.TextBox txtLForgotPass;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxSymbol;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
    }
}