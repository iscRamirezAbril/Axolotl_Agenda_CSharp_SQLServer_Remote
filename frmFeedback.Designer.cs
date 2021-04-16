
namespace ProyectoFinal
{
    partial class frmFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeedback));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconPictureBExcellent = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBGood = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBAverage = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBPoor = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBAWorst = new FontAwesome.Sharp.IconPictureBox();
            this.radiobtnExcellent = new System.Windows.Forms.RadioButton();
            this.radiobtnGood = new System.Windows.Forms.RadioButton();
            this.radiobtnAverage = new System.Windows.Forms.RadioButton();
            this.radiobtnPoor = new System.Windows.Forms.RadioButton();
            this.radiobtnWorst = new System.Windows.Forms.RadioButton();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            this.groupBRate = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEmailPass = new System.Windows.Forms.Label();
            this.txtEmailPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBExcellent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBPoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBAWorst)).BeginInit();
            this.groupBRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(378, 72);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Your opinion is important =)\r\nWe would like you to rate our application for possi" +
    "ble future\r\nimprovements.\r\nFeel free to give feedback as often as you like.";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Your name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(12, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "_______________________________________";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(283, 93);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 16);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last name:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.Location = new System.Drawing.Point(286, 112);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(239, 20);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(284, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "_______________________________________";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(16, 172);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "_______________________________________";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 16);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rate this application:";
            // 
            // iconPictureBExcellent
            // 
            this.iconPictureBExcellent.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBExcellent.ForeColor = System.Drawing.Color.Green;
            this.iconPictureBExcellent.IconChar = FontAwesome.Sharp.IconChar.Laugh;
            this.iconPictureBExcellent.IconColor = System.Drawing.Color.Green;
            this.iconPictureBExcellent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBExcellent.IconSize = 44;
            this.iconPictureBExcellent.Location = new System.Drawing.Point(75, 238);
            this.iconPictureBExcellent.Name = "iconPictureBExcellent";
            this.iconPictureBExcellent.Size = new System.Drawing.Size(52, 44);
            this.iconPictureBExcellent.TabIndex = 11;
            this.iconPictureBExcellent.TabStop = false;
            // 
            // iconPictureBGood
            // 
            this.iconPictureBGood.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBGood.ForeColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBGood.IconChar = FontAwesome.Sharp.IconChar.Grin;
            this.iconPictureBGood.IconColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBGood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBGood.IconSize = 44;
            this.iconPictureBGood.Location = new System.Drawing.Point(160, 238);
            this.iconPictureBGood.Name = "iconPictureBGood";
            this.iconPictureBGood.Size = new System.Drawing.Size(52, 44);
            this.iconPictureBGood.TabIndex = 12;
            this.iconPictureBGood.TabStop = false;
            // 
            // iconPictureBAverage
            // 
            this.iconPictureBAverage.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBAverage.ForeColor = System.Drawing.Color.Yellow;
            this.iconPictureBAverage.IconChar = FontAwesome.Sharp.IconChar.Meh;
            this.iconPictureBAverage.IconColor = System.Drawing.Color.Yellow;
            this.iconPictureBAverage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBAverage.IconSize = 44;
            this.iconPictureBAverage.Location = new System.Drawing.Point(247, 238);
            this.iconPictureBAverage.Name = "iconPictureBAverage";
            this.iconPictureBAverage.Size = new System.Drawing.Size(52, 44);
            this.iconPictureBAverage.TabIndex = 13;
            this.iconPictureBAverage.TabStop = false;
            // 
            // iconPictureBPoor
            // 
            this.iconPictureBPoor.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBPoor.ForeColor = System.Drawing.Color.Orange;
            this.iconPictureBPoor.IconChar = FontAwesome.Sharp.IconChar.SadTear;
            this.iconPictureBPoor.IconColor = System.Drawing.Color.Orange;
            this.iconPictureBPoor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBPoor.IconSize = 44;
            this.iconPictureBPoor.Location = new System.Drawing.Point(332, 238);
            this.iconPictureBPoor.Name = "iconPictureBPoor";
            this.iconPictureBPoor.Size = new System.Drawing.Size(52, 44);
            this.iconPictureBPoor.TabIndex = 14;
            this.iconPictureBPoor.TabStop = false;
            // 
            // iconPictureBAWorst
            // 
            this.iconPictureBAWorst.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBAWorst.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBAWorst.IconChar = FontAwesome.Sharp.IconChar.Angry;
            this.iconPictureBAWorst.IconColor = System.Drawing.Color.Red;
            this.iconPictureBAWorst.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBAWorst.IconSize = 44;
            this.iconPictureBAWorst.Location = new System.Drawing.Point(415, 238);
            this.iconPictureBAWorst.Name = "iconPictureBAWorst";
            this.iconPictureBAWorst.Size = new System.Drawing.Size(52, 44);
            this.iconPictureBAWorst.TabIndex = 15;
            this.iconPictureBAWorst.TabStop = false;
            // 
            // radiobtnExcellent
            // 
            this.radiobtnExcellent.AutoSize = true;
            this.radiobtnExcellent.BackColor = System.Drawing.Color.Transparent;
            this.radiobtnExcellent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnExcellent.Location = new System.Drawing.Point(7, 12);
            this.radiobtnExcellent.Name = "radiobtnExcellent";
            this.radiobtnExcellent.Size = new System.Drawing.Size(76, 17);
            this.radiobtnExcellent.TabIndex = 16;
            this.radiobtnExcellent.TabStop = true;
            this.radiobtnExcellent.Text = "Excellent";
            this.radiobtnExcellent.UseVisualStyleBackColor = false;
            // 
            // radiobtnGood
            // 
            this.radiobtnGood.AutoSize = true;
            this.radiobtnGood.BackColor = System.Drawing.Color.Transparent;
            this.radiobtnGood.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnGood.Location = new System.Drawing.Point(105, 12);
            this.radiobtnGood.Name = "radiobtnGood";
            this.radiobtnGood.Size = new System.Drawing.Size(55, 17);
            this.radiobtnGood.TabIndex = 17;
            this.radiobtnGood.TabStop = true;
            this.radiobtnGood.Text = "Good";
            this.radiobtnGood.UseVisualStyleBackColor = false;
            // 
            // radiobtnAverage
            // 
            this.radiobtnAverage.AutoSize = true;
            this.radiobtnAverage.BackColor = System.Drawing.Color.Transparent;
            this.radiobtnAverage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnAverage.Location = new System.Drawing.Point(185, 12);
            this.radiobtnAverage.Name = "radiobtnAverage";
            this.radiobtnAverage.Size = new System.Drawing.Size(73, 17);
            this.radiobtnAverage.TabIndex = 18;
            this.radiobtnAverage.TabStop = true;
            this.radiobtnAverage.Text = "Average";
            this.radiobtnAverage.UseVisualStyleBackColor = false;
            // 
            // radiobtnPoor
            // 
            this.radiobtnPoor.AutoSize = true;
            this.radiobtnPoor.BackColor = System.Drawing.Color.Transparent;
            this.radiobtnPoor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnPoor.Location = new System.Drawing.Point(275, 12);
            this.radiobtnPoor.Name = "radiobtnPoor";
            this.radiobtnPoor.Size = new System.Drawing.Size(51, 17);
            this.radiobtnPoor.TabIndex = 19;
            this.radiobtnPoor.TabStop = true;
            this.radiobtnPoor.Text = "Poor";
            this.radiobtnPoor.UseVisualStyleBackColor = false;
            // 
            // radiobtnWorst
            // 
            this.radiobtnWorst.AutoSize = true;
            this.radiobtnWorst.BackColor = System.Drawing.Color.Transparent;
            this.radiobtnWorst.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnWorst.Location = new System.Drawing.Point(355, 12);
            this.radiobtnWorst.Name = "radiobtnWorst";
            this.radiobtnWorst.Size = new System.Drawing.Size(57, 17);
            this.radiobtnWorst.TabIndex = 20;
            this.radiobtnWorst.TabStop = true;
            this.radiobtnWorst.Text = "Worst";
            this.radiobtnWorst.UseVisualStyleBackColor = false;
            // 
            // lblComments
            // 
            this.lblComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComments.AutoSize = true;
            this.lblComments.BackColor = System.Drawing.Color.Transparent;
            this.lblComments.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(14, 330);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(69, 16);
            this.lblComments.TabIndex = 21;
            this.lblComments.Text = "Comments:";
            // 
            // txtComments
            // 
            this.txtComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComments.BackColor = System.Drawing.Color.White;
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComments.Location = new System.Drawing.Point(17, 349);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(450, 58);
            this.txtComments.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(457, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "___________________________________________________________________________";
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendFeedback.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSendFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendFeedback.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFeedback.Location = new System.Drawing.Point(494, 367);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(84, 27);
            this.btnSendFeedback.TabIndex = 24;
            this.btnSendFeedback.Text = "Send";
            this.btnSendFeedback.UseVisualStyleBackColor = false;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // groupBRate
            // 
            this.groupBRate.BackColor = System.Drawing.Color.Transparent;
            this.groupBRate.Controls.Add(this.radiobtnExcellent);
            this.groupBRate.Controls.Add(this.radiobtnGood);
            this.groupBRate.Controls.Add(this.radiobtnAverage);
            this.groupBRate.Controls.Add(this.radiobtnPoor);
            this.groupBRate.Controls.Add(this.radiobtnWorst);
            this.groupBRate.ForeColor = System.Drawing.Color.Black;
            this.groupBRate.Location = new System.Drawing.Point(55, 277);
            this.groupBRate.Name = "groupBRate";
            this.groupBRate.Size = new System.Drawing.Size(433, 36);
            this.groupBRate.TabIndex = 25;
            this.groupBRate.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(104, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "(Opcional)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(283, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "_______________________________________";
            // 
            // lblEmailPass
            // 
            this.lblEmailPass.AutoSize = true;
            this.lblEmailPass.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailPass.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPass.Location = new System.Drawing.Point(284, 153);
            this.lblEmailPass.Name = "lblEmailPass";
            this.lblEmailPass.Size = new System.Drawing.Size(107, 16);
            this.lblEmailPass.TabIndex = 27;
            this.lblEmailPass.Text = "E-mail password:";
            // 
            // txtEmailPass
            // 
            this.txtEmailPass.BackColor = System.Drawing.Color.White;
            this.txtEmailPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmailPass.Location = new System.Drawing.Point(287, 172);
            this.txtEmailPass.Name = "txtEmailPass";
            this.txtEmailPass.Size = new System.Drawing.Size(239, 20);
            this.txtEmailPass.TabIndex = 11;
            this.txtEmailPass.TextChanged += new System.EventHandler(this.txtEmailPass_TextChanged);
            // 
            // frmFeedback
            // 
            this.AcceptButton = this.btnSendFeedback;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(615, 419);
            this.Controls.Add(this.txtEmailPass);
            this.Controls.Add(this.lblEmailPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBRate);
            this.Controls.Add(this.btnSendFeedback);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.iconPictureBAWorst);
            this.Controls.Add(this.iconPictureBPoor);
            this.Controls.Add(this.iconPictureBAverage);
            this.Controls.Add(this.iconPictureBGood);
            this.Controls.Add(this.iconPictureBExcellent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFeedback";
            this.Opacity = 0.9D;
            this.Text = "Feedback";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBExcellent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBPoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBAWorst)).EndInit();
            this.groupBRate.ResumeLayout(false);
            this.groupBRate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBExcellent;
        private FontAwesome.Sharp.IconPictureBox iconPictureBGood;
        private FontAwesome.Sharp.IconPictureBox iconPictureBAverage;
        private FontAwesome.Sharp.IconPictureBox iconPictureBPoor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBAWorst;
        private System.Windows.Forms.RadioButton radiobtnExcellent;
        private System.Windows.Forms.RadioButton radiobtnGood;
        private System.Windows.Forms.RadioButton radiobtnAverage;
        private System.Windows.Forms.RadioButton radiobtnPoor;
        private System.Windows.Forms.RadioButton radiobtnWorst;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSendFeedback;
        private System.Windows.Forms.GroupBox groupBRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEmailPass;
        private System.Windows.Forms.TextBox txtEmailPass;
    }
}