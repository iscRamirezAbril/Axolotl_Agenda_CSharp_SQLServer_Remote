
namespace ProyectoFinal
{
    partial class frmUsersControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtUsersControl = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblAdmins = new System.Windows.Forms.Label();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.usridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrConPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconbtnSearch = new FontAwesome.Sharp.IconButton();
            this.groupBUsersData = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.iconbtnClean = new FontAwesome.Sharp.IconButton();
            this.iconbtnSave = new FontAwesome.Sharp.IconButton();
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iconbtnDelete = new FontAwesome.Sharp.IconButton();
            this.btnModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.groupBUsersData.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsersControl
            // 
            this.txtUsersControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsersControl.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUsersControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsersControl.Enabled = false;
            this.txtUsersControl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsersControl.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtUsersControl.Location = new System.Drawing.Point(140, 8);
            this.txtUsersControl.Name = "txtUsersControl";
            this.txtUsersControl.Size = new System.Drawing.Size(239, 30);
            this.txtUsersControl.TabIndex = 2;
            this.txtUsersControl.Text = "USERS CONTROL";
            this.txtUsersControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DimGray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DimGray;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 44;
            this.iconPictureBox1.Location = new System.Drawing.Point(362, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(51, 44);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblAdmins
            // 
            this.lblAdmins.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdmins.AutoSize = true;
            this.lblAdmins.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmins.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAdmins.Location = new System.Drawing.Point(65, 45);
            this.lblAdmins.Name = "lblAdmins";
            this.lblAdmins.Size = new System.Drawing.Size(462, 18);
            this.lblAdmins.TabIndex = 4;
            this.lblAdmins.Text = "Only Admin Users have acces to this Configuration *";
            // 
            // dataGridUsers
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridUsers.AutoGenerateColumns = false;
            this.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsers.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridUsers.ColumnHeadersHeight = 25;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usridDataGridViewTextBoxColumn,
            this.usrRolDataGridViewTextBoxColumn,
            this.usrNameDataGridViewTextBoxColumn,
            this.usrLnameDataGridViewTextBoxColumn,
            this.usrUsernameDataGridViewTextBoxColumn,
            this.usrEmailDataGridViewTextBoxColumn,
            this.usrPassDataGridViewTextBoxColumn,
            this.usrConPassDataGridViewTextBoxColumn});
            this.dataGridUsers.DataSource = this.usersBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridUsers.GridColor = System.Drawing.Color.LightSlateGray;
            this.dataGridUsers.Location = new System.Drawing.Point(12, 247);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridUsers.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridUsers.Size = new System.Drawing.Size(591, 126);
            this.dataGridUsers.TabIndex = 5;
            this.dataGridUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellClick);
            // 
            // usridDataGridViewTextBoxColumn
            // 
            this.usridDataGridViewTextBoxColumn.DataPropertyName = "Usrid";
            this.usridDataGridViewTextBoxColumn.FillWeight = 30F;
            this.usridDataGridViewTextBoxColumn.HeaderText = "id";
            this.usridDataGridViewTextBoxColumn.Name = "usridDataGridViewTextBoxColumn";
            // 
            // usrRolDataGridViewTextBoxColumn
            // 
            this.usrRolDataGridViewTextBoxColumn.DataPropertyName = "UsrRol";
            this.usrRolDataGridViewTextBoxColumn.FillWeight = 30F;
            this.usrRolDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.usrRolDataGridViewTextBoxColumn.Name = "usrRolDataGridViewTextBoxColumn";
            // 
            // usrNameDataGridViewTextBoxColumn
            // 
            this.usrNameDataGridViewTextBoxColumn.DataPropertyName = "UsrName";
            this.usrNameDataGridViewTextBoxColumn.FillWeight = 70F;
            this.usrNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.usrNameDataGridViewTextBoxColumn.Name = "usrNameDataGridViewTextBoxColumn";
            // 
            // usrLnameDataGridViewTextBoxColumn
            // 
            this.usrLnameDataGridViewTextBoxColumn.DataPropertyName = "UsrLname";
            this.usrLnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.usrLnameDataGridViewTextBoxColumn.Name = "usrLnameDataGridViewTextBoxColumn";
            // 
            // usrUsernameDataGridViewTextBoxColumn
            // 
            this.usrUsernameDataGridViewTextBoxColumn.DataPropertyName = "UsrUsername";
            this.usrUsernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usrUsernameDataGridViewTextBoxColumn.Name = "usrUsernameDataGridViewTextBoxColumn";
            // 
            // usrEmailDataGridViewTextBoxColumn
            // 
            this.usrEmailDataGridViewTextBoxColumn.DataPropertyName = "UsrEmail";
            this.usrEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.usrEmailDataGridViewTextBoxColumn.Name = "usrEmailDataGridViewTextBoxColumn";
            // 
            // usrPassDataGridViewTextBoxColumn
            // 
            this.usrPassDataGridViewTextBoxColumn.DataPropertyName = "UsrPass";
            this.usrPassDataGridViewTextBoxColumn.HeaderText = "Password";
            this.usrPassDataGridViewTextBoxColumn.Name = "usrPassDataGridViewTextBoxColumn";
            // 
            // usrConPassDataGridViewTextBoxColumn
            // 
            this.usrConPassDataGridViewTextBoxColumn.DataPropertyName = "UsrConPass";
            this.usrConPassDataGridViewTextBoxColumn.HeaderText = "UsrConPass";
            this.usrConPassDataGridViewTextBoxColumn.Name = "usrConPassDataGridViewTextBoxColumn";
            this.usrConPassDataGridViewTextBoxColumn.Visible = false;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(ProyectoFinal.Users);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(14, 386);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Text = "SEARCH";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "_______________________________";
            // 
            // iconbtnSearch
            // 
            this.iconbtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconbtnSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.iconbtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconbtnSearch.IconColor = System.Drawing.Color.Black;
            this.iconbtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnSearch.IconSize = 25;
            this.iconbtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnSearch.Location = new System.Drawing.Point(223, 381);
            this.iconbtnSearch.Name = "iconbtnSearch";
            this.iconbtnSearch.Size = new System.Drawing.Size(102, 30);
            this.iconbtnSearch.TabIndex = 8;
            this.iconbtnSearch.Text = "Search";
            this.iconbtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnSearch.UseVisualStyleBackColor = false;
            this.iconbtnSearch.Click += new System.EventHandler(this.iconbtnSearch_Click);
            // 
            // groupBUsersData
            // 
            this.groupBUsersData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBUsersData.Controls.Add(this.label9);
            this.groupBUsersData.Controls.Add(this.iconbtnClean);
            this.groupBUsersData.Controls.Add(this.iconbtnSave);
            this.groupBUsersData.Controls.Add(this.txtIdRol);
            this.groupBUsersData.Controls.Add(this.txtPass);
            this.groupBUsersData.Controls.Add(this.txtEmail);
            this.groupBUsersData.Controls.Add(this.txtUsername);
            this.groupBUsersData.Controls.Add(this.txtLastName);
            this.groupBUsersData.Controls.Add(this.txtName);
            this.groupBUsersData.Controls.Add(this.txtId);
            this.groupBUsersData.Controls.Add(this.label2);
            this.groupBUsersData.Controls.Add(this.label3);
            this.groupBUsersData.Controls.Add(this.label4);
            this.groupBUsersData.Controls.Add(this.label5);
            this.groupBUsersData.Controls.Add(this.label6);
            this.groupBUsersData.Controls.Add(this.label7);
            this.groupBUsersData.Controls.Add(this.label8);
            this.groupBUsersData.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBUsersData.Location = new System.Drawing.Point(12, 68);
            this.groupBUsersData.Name = "groupBUsersData";
            this.groupBUsersData.Size = new System.Drawing.Size(591, 173);
            this.groupBUsersData.TabIndex = 9;
            this.groupBUsersData.TabStop = false;
            this.groupBUsersData.Text = "Users data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(457, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 57);
            this.label9.TabIndex = 25;
            this.label9.Text = "Users Rols:\r\n1 = Admin\r\n2 = Users";
            // 
            // iconbtnClean
            // 
            this.iconbtnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconbtnClean.BackColor = System.Drawing.Color.Khaki;
            this.iconbtnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnClean.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnClean.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconbtnClean.IconColor = System.Drawing.Color.Black;
            this.iconbtnClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnClean.IconSize = 25;
            this.iconbtnClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnClean.Location = new System.Drawing.Point(295, 132);
            this.iconbtnClean.Name = "iconbtnClean";
            this.iconbtnClean.Size = new System.Drawing.Size(96, 30);
            this.iconbtnClean.TabIndex = 24;
            this.iconbtnClean.Text = "Clean";
            this.iconbtnClean.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnClean.UseVisualStyleBackColor = false;
            this.iconbtnClean.Click += new System.EventHandler(this.iconbtnClean_Click);
            // 
            // iconbtnSave
            // 
            this.iconbtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconbtnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.iconbtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnSave.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconbtnSave.IconColor = System.Drawing.Color.Black;
            this.iconbtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnSave.IconSize = 25;
            this.iconbtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnSave.Location = new System.Drawing.Point(188, 132);
            this.iconbtnSave.Name = "iconbtnSave";
            this.iconbtnSave.Size = new System.Drawing.Size(82, 30);
            this.iconbtnSave.TabIndex = 11;
            this.iconbtnSave.Text = "Save";
            this.iconbtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnSave.UseVisualStyleBackColor = false;
            this.iconbtnSave.Click += new System.EventHandler(this.iconbtnSave_Click);
            // 
            // txtIdRol
            // 
            this.txtIdRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdRol.BackColor = System.Drawing.Color.AliceBlue;
            this.txtIdRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdRol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdRol.Location = new System.Drawing.Point(474, 58);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Size = new System.Drawing.Size(104, 20);
            this.txtIdRol.TabIndex = 16;
            this.txtIdRol.Text = "ID_ROL";
            this.txtIdRol.TextChanged += new System.EventHandler(this.txtIdRol_TextChanged);
            this.txtIdRol.Enter += new System.EventHandler(this.txtIdTipo_Enter);
            this.txtIdRol.Leave += new System.EventHandler(this.txtIdTipo_Leave);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.Location = new System.Drawing.Point(6, 96);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(220, 20);
            this.txtPass.TabIndex = 15;
            this.txtPass.Text = "PASSWORD";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(206, 58);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Text = "EMAIL";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(6, 58);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(159, 20);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.Text = "USERNAME";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.Location = new System.Drawing.Point(365, 22);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(213, 20);
            this.txtLastName.TabIndex = 12;
            this.txtLastName.Text = "LAST NAME";
            this.txtLastName.Enter += new System.EventHandler(this.txtLastName_Enter);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(117, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 11;
            this.txtName.Text = "NAME";
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.BackColor = System.Drawing.Color.AliceBlue;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(6, 22);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(56, 20);
            this.txtId.TabIndex = 10;
            this.txtId.Text = "ID";
            this.txtId.Enter += new System.EventHandler(this.txtId_Enter);
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "_______";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "__________________________";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "__________________________";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "____________________";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "____________________________";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "________";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "____________________________";
            // 
            // iconbtnDelete
            // 
            this.iconbtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.iconbtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnDelete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconbtnDelete.IconColor = System.Drawing.Color.Black;
            this.iconbtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnDelete.IconSize = 25;
            this.iconbtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnDelete.Location = new System.Drawing.Point(501, 381);
            this.iconbtnDelete.Name = "iconbtnDelete";
            this.iconbtnDelete.Size = new System.Drawing.Size(102, 30);
            this.iconbtnDelete.TabIndex = 10;
            this.iconbtnDelete.Text = "Delete";
            this.iconbtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnDelete.UseVisualStyleBackColor = false;
            this.iconbtnDelete.Click += new System.EventHandler(this.iconbtnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.BackColor = System.Drawing.Color.LightGray;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(398, 381);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(97, 30);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // frmUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(615, 419);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.iconbtnDelete);
            this.Controls.Add(this.groupBUsersData);
            this.Controls.Add(this.iconbtnSearch);
            this.Controls.Add(this.dataGridUsers);
            this.Controls.Add(this.lblAdmins);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtUsersControl);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsersControl";
            this.Text = "Users Control";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.groupBUsersData.ResumeLayout(false);
            this.groupBUsersData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsersControl;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblAdmins;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconbtnSearch;
        private System.Windows.Forms.GroupBox groupBUsersData;
        private System.Windows.Forms.TextBox txtIdRol;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton iconbtnDelete;
        private FontAwesome.Sharp.IconButton iconbtnSave;
        private FontAwesome.Sharp.IconButton iconbtnClean;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn usridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrConPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
    }
}