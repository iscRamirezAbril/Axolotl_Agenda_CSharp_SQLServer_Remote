
namespace ProyectoFinal
{
    partial class RegistrerUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrerUsers));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.txtSignUp = new System.Windows.Forms.TextBox();
            this.txtSignName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSignLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSignUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSignEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSignPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.iconPicBoxSymbol = new FontAwesome.Sharp.IconPictureBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.CadetBlue;
            this.panelLogo.Controls.Add(this.picBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 358);
            this.panelLogo.TabIndex = 0;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(-59, 110);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(293, 137);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 4;
            this.picBoxLogo.TabStop = false;
            // 
            // txtSignUp
            // 
            this.txtSignUp.BackColor = System.Drawing.Color.White;
            this.txtSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSignUp.Enabled = false;
            this.txtSignUp.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUp.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtSignUp.Location = new System.Drawing.Point(270, 30);
            this.txtSignUp.Name = "txtSignUp";
            this.txtSignUp.Size = new System.Drawing.Size(159, 30);
            this.txtSignUp.TabIndex = 7;
            this.txtSignUp.Text = "SIGN UP";
            this.txtSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSignName
            // 
            this.txtSignName.BackColor = System.Drawing.Color.White;
            this.txtSignName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSignName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSignName.Location = new System.Drawing.Point(265, 80);
            this.txtSignName.Name = "txtSignName";
            this.txtSignName.Size = new System.Drawing.Size(238, 20);
            this.txtSignName.TabIndex = 8;
            this.txtSignName.Text = "NAME";
            this.txtSignName.Enter += new System.EventHandler(this.txtSignName_Enter);
            this.txtSignName.Leave += new System.EventHandler(this.txtSignName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(262, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "_______________________________________";
            // 
            // txtSignLastName
            // 
            this.txtSignLastName.BackColor = System.Drawing.Color.White;
            this.txtSignLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSignLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSignLastName.Location = new System.Drawing.Point(265, 117);
            this.txtSignLastName.Name = "txtSignLastName";
            this.txtSignLastName.Size = new System.Drawing.Size(238, 20);
            this.txtSignLastName.TabIndex = 10;
            this.txtSignLastName.Text = "LAST NAME";
            this.txtSignLastName.Enter += new System.EventHandler(this.txtSignLastName_Enter);
            this.txtSignLastName.Leave += new System.EventHandler(this.txtSignLastName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(262, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "_______________________________________";
            // 
            // txtSignUsername
            // 
            this.txtSignUsername.BackColor = System.Drawing.Color.White;
            this.txtSignUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSignUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSignUsername.Location = new System.Drawing.Point(265, 155);
            this.txtSignUsername.Name = "txtSignUsername";
            this.txtSignUsername.Size = new System.Drawing.Size(238, 20);
            this.txtSignUsername.TabIndex = 12;
            this.txtSignUsername.Text = "USERNAME";
            this.txtSignUsername.Enter += new System.EventHandler(this.txtSignUsername_Enter);
            this.txtSignUsername.Leave += new System.EventHandler(this.txtSignUsername_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(262, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "_______________________________________";
            // 
            // txtSignEmail
            // 
            this.txtSignEmail.BackColor = System.Drawing.Color.White;
            this.txtSignEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSignEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSignEmail.Location = new System.Drawing.Point(265, 193);
            this.txtSignEmail.Name = "txtSignEmail";
            this.txtSignEmail.Size = new System.Drawing.Size(238, 20);
            this.txtSignEmail.TabIndex = 14;
            this.txtSignEmail.Text = "EMAIL ADDRESS";
            this.txtSignEmail.Enter += new System.EventHandler(this.txtSignEmail_Enter);
            this.txtSignEmail.Leave += new System.EventHandler(this.txtSignEmail_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(262, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "_______________________________________";
            // 
            // txtSignPassword
            // 
            this.txtSignPassword.BackColor = System.Drawing.Color.White;
            this.txtSignPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSignPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSignPassword.Location = new System.Drawing.Point(265, 230);
            this.txtSignPassword.Name = "txtSignPassword";
            this.txtSignPassword.Size = new System.Drawing.Size(238, 20);
            this.txtSignPassword.TabIndex = 16;
            this.txtSignPassword.Text = "PASSWORD";
            this.txtSignPassword.Enter += new System.EventHandler(this.txtSignPassword_Enter);
            this.txtSignPassword.Leave += new System.EventHandler(this.txtSignPassword_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(262, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "_______________________________________";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.White;
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPass.Location = new System.Drawing.Point(265, 269);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(238, 20);
            this.txtConfirmPass.TabIndex = 18;
            this.txtConfirmPass.Text = "CONFIRM PASSWORD";
            this.txtConfirmPass.Enter += new System.EventHandler(this.txtConfirmPass_Enter);
            this.txtConfirmPass.Leave += new System.EventHandler(this.txtConfirmPass_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(262, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "_______________________________________";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PowderBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(240, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 28);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(411, 307);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(115, 28);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(545, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 22;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(519, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 22);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 23;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // iconPicBoxSymbol
            // 
            this.iconPicBoxSymbol.BackColor = System.Drawing.Color.White;
            this.iconPicBoxSymbol.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.iconPicBoxSymbol.IconChar = FontAwesome.Sharp.IconChar.LaughBeam;
            this.iconPicBoxSymbol.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconPicBoxSymbol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxSymbol.IconSize = 44;
            this.iconPicBoxSymbol.Location = new System.Drawing.Point(411, 27);
            this.iconPicBoxSymbol.Name = "iconPicBoxSymbol";
            this.iconPicBoxSymbol.Size = new System.Drawing.Size(52, 44);
            this.iconPicBoxSymbol.TabIndex = 24;
            this.iconPicBoxSymbol.TabStop = false;
            // 
            // RegistrerUsers
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 358);
            this.Controls.Add(this.iconPicBoxSymbol);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSignPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSignEmail);
            this.Controls.Add(this.txtSignUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSignLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSignName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSignUp);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrerUsers";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrerUsers";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxSymbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.TextBox txtSignUp;
        private System.Windows.Forms.TextBox txtSignName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSignLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSignUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSignEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSignPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxSymbol;
    }
}