
namespace ProyectoFinal
{
    partial class frmMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblClock = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.btnAgregarAct = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.timerDigitalClock = new System.Windows.Forms.Timer(this.components);
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBAct = new FontAwesome.Sharp.IconPictureBox();
            this.ComboBType = new System.Windows.Forms.ComboBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDates = new System.Windows.Forms.Button();
            this.dataGridActivities = new System.Windows.Forms.DataGridView();
            this.activitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actUseridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableTitle.Location = new System.Drawing.Point(261, 215);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(84, 18);
            this.lblTableTitle.TabIndex = 17;
            this.lblTableTitle.Text = "Activities";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(200)))), ((int)(((byte)(190)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(285, 174);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(119, 30);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblClock
            // 
            this.lblClock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(38, 8);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(151, 27);
            this.lblClock.TabIndex = 1;
            this.lblClock.Text = "¡Welcome! :D";
            // 
            // Calendar
            // 
            this.Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendar.BackColor = System.Drawing.Color.Azure;
            this.Calendar.Location = new System.Drawing.Point(6, 44);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 2;
            // 
            // btnAgregarAct
            // 
            this.btnAgregarAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(200)))), ((int)(((byte)(190)))));
            this.btnAgregarAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAct.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAct.Location = new System.Drawing.Point(434, 174);
            this.btnAgregarAct.Name = "btnAgregarAct";
            this.btnAgregarAct.Size = new System.Drawing.Size(119, 30);
            this.btnAgregarAct.TabIndex = 10;
            this.btnAgregarAct.Text = "Add";
            this.btnAgregarAct.UseVisualStyleBackColor = false;
            this.btnAgregarAct.Click += new System.EventHandler(this.btnAgregarAct_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(296, 6);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(193, 36);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Space to\r\nadd or remove activities.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerDigitalClock
            // 
            this.timerDigitalClock.Enabled = true;
            this.timerDigitalClock.Tick += new System.EventHandler(this.timerDigitalClock_Tick);
            // 
            // txtStart
            // 
            this.txtStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStart.BackColor = System.Drawing.Color.PowderBlue;
            this.txtStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.ForeColor = System.Drawing.Color.DimGray;
            this.txtStart.Location = new System.Drawing.Point(256, 132);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(146, 16);
            this.txtStart.TabIndex = 6;
            this.txtStart.Text = "START";
            this.txtStart.Enter += new System.EventHandler(this.txtStart_Enter);
            this.txtStart.Leave += new System.EventHandler(this.txtStart_Leave);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.PowderBlue;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(256, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "ACTIVITY NAME";
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Location = new System.Drawing.Point(253, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "_________________________";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Location = new System.Drawing.Point(253, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "_________________________";
            // 
            // iconPictureBAct
            // 
            this.iconPictureBAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBAct.BackColor = System.Drawing.Color.PowderBlue;
            this.iconPictureBAct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBAct.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iconPictureBAct.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBAct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBAct.IconSize = 36;
            this.iconPictureBAct.Location = new System.Drawing.Point(495, 6);
            this.iconPictureBAct.Name = "iconPictureBAct";
            this.iconPictureBAct.Size = new System.Drawing.Size(36, 36);
            this.iconPictureBAct.TabIndex = 29;
            this.iconPictureBAct.TabStop = false;
            // 
            // ComboBType
            // 
            this.ComboBType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBType.ForeColor = System.Drawing.Color.DimGray;
            this.ComboBType.FormattingEnabled = true;
            this.ComboBType.Items.AddRange(new object[] {
            "---SELECT---",
            "BÁSICA",
            "ESCOLAR",
            "ENTRETENIMIENTO",
            "SOCIAL",
            "FAMILIAR",
            "DEPORTIVA"});
            this.ComboBType.Location = new System.Drawing.Point(430, 50);
            this.ComboBType.Name = "ComboBType";
            this.ComboBType.Size = new System.Drawing.Size(161, 26);
            this.ComboBType.TabIndex = 5;
            // 
            // txtEnd
            // 
            this.txtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnd.BackColor = System.Drawing.Color.PowderBlue;
            this.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.ForeColor = System.Drawing.Color.DimGray;
            this.txtEnd.Location = new System.Drawing.Point(434, 132);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(146, 16);
            this.txtEnd.TabIndex = 30;
            this.txtEnd.Text = "END";
            this.txtEnd.Enter += new System.EventHandler(this.txtEnd_Enter);
            this.txtEnd.Leave += new System.EventHandler(this.txtEnd_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Location = new System.Drawing.Point(432, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "_________________________";
            // 
            // btnDates
            // 
            this.btnDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDates.BackColor = System.Drawing.Color.Silver;
            this.btnDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDates.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDates.Location = new System.Drawing.Point(332, 94);
            this.btnDates.Name = "btnDates";
            this.btnDates.Size = new System.Drawing.Size(157, 30);
            this.btnDates.TabIndex = 32;
            this.btnDates.Text = "Select Dates";
            this.btnDates.UseVisualStyleBackColor = false;
            this.btnDates.Click += new System.EventHandler(this.btnDates_Click);
            // 
            // dataGridActivities
            // 
            this.dataGridActivities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridActivities.AutoGenerateColumns = false;
            this.dataGridActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridActivities.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridActivities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridActivities.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridActivities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridActivities.ColumnHeadersHeight = 20;
            this.dataGridActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actIdDataGridViewTextBoxColumn,
            this.actUseridDataGridViewTextBoxColumn,
            this.actNameDataGridViewTextBoxColumn,
            this.actTypeDataGridViewTextBoxColumn,
            this.actStartDataGridViewTextBoxColumn,
            this.actEndDataGridViewTextBoxColumn});
            this.dataGridActivities.DataSource = this.activitiesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridActivities.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridActivities.EnableHeadersVisualStyles = false;
            this.dataGridActivities.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(200)))), ((int)(((byte)(190)))));
            this.dataGridActivities.Location = new System.Drawing.Point(12, 238);
            this.dataGridActivities.Name = "dataGridActivities";
            this.dataGridActivities.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridActivities.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridActivities.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridActivities.Size = new System.Drawing.Size(591, 169);
            this.dataGridActivities.TabIndex = 11;
            this.dataGridActivities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridActivities_CellClick);
            // 
            // activitiesBindingSource
            // 
            this.activitiesBindingSource.DataSource = typeof(ProyectoFinal.Activities);
            // 
            // actIdDataGridViewTextBoxColumn
            // 
            this.actIdDataGridViewTextBoxColumn.DataPropertyName = "ActId";
            this.actIdDataGridViewTextBoxColumn.HeaderText = "ActId";
            this.actIdDataGridViewTextBoxColumn.Name = "actIdDataGridViewTextBoxColumn";
            this.actIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // actUseridDataGridViewTextBoxColumn
            // 
            this.actUseridDataGridViewTextBoxColumn.DataPropertyName = "ActUserid";
            this.actUseridDataGridViewTextBoxColumn.HeaderText = "ActUserid";
            this.actUseridDataGridViewTextBoxColumn.Name = "actUseridDataGridViewTextBoxColumn";
            this.actUseridDataGridViewTextBoxColumn.Visible = false;
            // 
            // actNameDataGridViewTextBoxColumn
            // 
            this.actNameDataGridViewTextBoxColumn.DataPropertyName = "ActName";
            this.actNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.actNameDataGridViewTextBoxColumn.Name = "actNameDataGridViewTextBoxColumn";
            // 
            // actTypeDataGridViewTextBoxColumn
            // 
            this.actTypeDataGridViewTextBoxColumn.DataPropertyName = "ActType";
            this.actTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.actTypeDataGridViewTextBoxColumn.Name = "actTypeDataGridViewTextBoxColumn";
            // 
            // actStartDataGridViewTextBoxColumn
            // 
            this.actStartDataGridViewTextBoxColumn.DataPropertyName = "ActStart";
            this.actStartDataGridViewTextBoxColumn.HeaderText = "Start";
            this.actStartDataGridViewTextBoxColumn.Name = "actStartDataGridViewTextBoxColumn";
            // 
            // actEndDataGridViewTextBoxColumn
            // 
            this.actEndDataGridViewTextBoxColumn.DataPropertyName = "ActEnd";
            this.actEndDataGridViewTextBoxColumn.HeaderText = "End";
            this.actEndDataGridViewTextBoxColumn.Name = "actEndDataGridViewTextBoxColumn";
            // 
            // frmMenu
            // 
            this.AcceptButton = this.btnAgregarAct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(615, 419);
            this.Controls.Add(this.btnDates);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.ComboBType);
            this.Controls.Add(this.iconPictureBAct);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTableTitle);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.btnAgregarAct);
            this.Controls.Add(this.dataGridActivities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Button btnAgregarAct;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Timer timerDigitalClock;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBAct;
        private System.Windows.Forms.ComboBox ComboBType;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDates;
        internal System.Windows.Forms.DataGridView dataGridActivities;
        private System.Windows.Forms.BindingSource activitiesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn actIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actUseridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actEndDataGridViewTextBoxColumn;
    }
}