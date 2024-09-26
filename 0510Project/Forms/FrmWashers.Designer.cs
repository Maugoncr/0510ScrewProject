namespace _0510Project.Forms
{
    partial class FrmWashers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle137 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle143 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle144 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle138 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle139 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle140 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle141 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle142 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pNavBar = new System.Windows.Forms.Panel();
            this.btnFormSize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgvWashers = new System.Windows.Forms.DataGridView();
            this.CIDWasher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSSNEPartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVendorPartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWasherTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWasherSizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnClean = new FontAwesome.Sharp.IconButton();
            this.btnCheckUrlSTEP = new FontAwesome.Sharp.IconButton();
            this.btnDisable = new FontAwesome.Sharp.IconButton();
            this.txtUrlSTEP = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCheckUrlPDF = new FontAwesome.Sharp.IconButton();
            this.txtUrlPDF = new System.Windows.Forms.TextBox();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVendorPartNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSSNEPartNumber = new System.Windows.Forms.TextBox();
            this.txtIDWasher = new System.Windows.Forms.TextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtIDWasherType = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnClearWasherType = new FontAwesome.Sharp.IconButton();
            this.btnSelectWasherType = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSizeName = new System.Windows.Forms.TextBox();
            this.txtIDWasherSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearWasherSize = new FontAwesome.Sharp.IconButton();
            this.btnSelectWasherSize = new FontAwesome.Sharp.IconButton();
            this.checkActives = new System.Windows.Forms.CheckBox();
            this.pNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWashers)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNavBar
            // 
            this.pNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.pNavBar.Controls.Add(this.btnFormSize);
            this.pNavBar.Controls.Add(this.btnClose);
            this.pNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNavBar.Location = new System.Drawing.Point(0, 0);
            this.pNavBar.Name = "pNavBar";
            this.pNavBar.Size = new System.Drawing.Size(1223, 42);
            this.pNavBar.TabIndex = 6;
            this.pNavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pNavBar_MouseDown);
            // 
            // btnFormSize
            // 
            this.btnFormSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFormSize.FlatAppearance.BorderSize = 0;
            this.btnFormSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormSize.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
            this.btnFormSize.IconColor = System.Drawing.Color.White;
            this.btnFormSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFormSize.IconSize = 30;
            this.btnFormSize.Location = new System.Drawing.Point(1136, 0);
            this.btnFormSize.Name = "btnFormSize";
            this.btnFormSize.Size = new System.Drawing.Size(41, 42);
            this.btnFormSize.TabIndex = 2;
            this.btnFormSize.UseVisualStyleBackColor = true;
            this.btnFormSize.Click += new System.EventHandler(this.btnFormSize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1177, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 42);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto", 40F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1199, 76);
            this.label7.TabIndex = 168;
            this.label7.Text = "Washer Management";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(206, 134);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(770, 27);
            this.txtFilter.TabIndex = 170;
            this.txtFilter.Text = "Search...";
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFilter_MouseClick);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dgvWashers
            // 
            this.dgvWashers.AllowUserToAddRows = false;
            this.dgvWashers.AllowUserToDeleteRows = false;
            this.dgvWashers.AllowUserToResizeColumns = false;
            this.dgvWashers.AllowUserToResizeRows = false;
            dataGridViewCellStyle137.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle137.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle137.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle137.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle137.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle137.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle137.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWashers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle137;
            this.dgvWashers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWashers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDWasher,
            this.CSSNEPartNumber,
            this.CVendorPartNumber,
            this.CWasherTypeName,
            this.CWasherSizeName});
            dataGridViewCellStyle143.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle143.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle143.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle143.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle143.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle143.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle143.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWashers.DefaultCellStyle = dataGridViewCellStyle143;
            this.dgvWashers.Location = new System.Drawing.Point(23, 172);
            this.dgvWashers.MultiSelect = false;
            this.dgvWashers.Name = "dgvWashers";
            this.dgvWashers.ReadOnly = true;
            dataGridViewCellStyle144.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle144.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle144.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle144.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle144.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle144.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle144.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWashers.RowHeadersDefaultCellStyle = dataGridViewCellStyle144;
            this.dgvWashers.RowHeadersVisible = false;
            this.dgvWashers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWashers.Size = new System.Drawing.Size(1172, 326);
            this.dgvWashers.TabIndex = 171;
            this.dgvWashers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWashers_CellClick);
            // 
            // CIDWasher
            // 
            this.CIDWasher.DataPropertyName = "IDWasher";
            dataGridViewCellStyle138.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CIDWasher.DefaultCellStyle = dataGridViewCellStyle138;
            this.CIDWasher.HeaderText = "ID Washer";
            this.CIDWasher.Name = "CIDWasher";
            this.CIDWasher.ReadOnly = true;
            this.CIDWasher.Width = 120;
            // 
            // CSSNEPartNumber
            // 
            this.CSSNEPartNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CSSNEPartNumber.DataPropertyName = "SSNEPartNumber";
            dataGridViewCellStyle139.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CSSNEPartNumber.DefaultCellStyle = dataGridViewCellStyle139;
            this.CSSNEPartNumber.HeaderText = "SSNE Part Number";
            this.CSSNEPartNumber.Name = "CSSNEPartNumber";
            this.CSSNEPartNumber.ReadOnly = true;
            this.CSSNEPartNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CVendorPartNumber
            // 
            this.CVendorPartNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CVendorPartNumber.DataPropertyName = "VendorPartNumber";
            dataGridViewCellStyle140.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CVendorPartNumber.DefaultCellStyle = dataGridViewCellStyle140;
            this.CVendorPartNumber.HeaderText = "Vendor Part Number";
            this.CVendorPartNumber.Name = "CVendorPartNumber";
            this.CVendorPartNumber.ReadOnly = true;
            this.CVendorPartNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CWasherTypeName
            // 
            this.CWasherTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CWasherTypeName.DataPropertyName = "WasherTypeName";
            dataGridViewCellStyle141.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CWasherTypeName.DefaultCellStyle = dataGridViewCellStyle141;
            this.CWasherTypeName.HeaderText = "Type";
            this.CWasherTypeName.Name = "CWasherTypeName";
            this.CWasherTypeName.ReadOnly = true;
            this.CWasherTypeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CWasherSizeName
            // 
            this.CWasherSizeName.DataPropertyName = "WasherSizeName";
            dataGridViewCellStyle142.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CWasherSizeName.DefaultCellStyle = dataGridViewCellStyle142;
            this.CWasherSizeName.HeaderText = "Size";
            this.CWasherSizeName.Name = "CWasherSizeName";
            this.CWasherSizeName.ReadOnly = true;
            this.CWasherSizeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CWasherSizeName.Width = 150;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.btnCheckUrlSTEP);
            this.groupBox7.Controls.Add(this.txtUrlSTEP);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.btnCheckUrlPDF);
            this.groupBox7.Controls.Add(this.txtUrlPDF);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.txtVendorPartNumber);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.txtSSNEPartNumber);
            this.groupBox7.Controls.Add(this.txtIDWasher);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(287, 515);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(773, 323);
            this.groupBox7.TabIndex = 177;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Screw";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Control;
            this.label20.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(9, -7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 33);
            this.label20.TabIndex = 182;
            this.label20.Text = "Washer";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClean.IconColor = System.Drawing.Color.White;
            this.btnClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClean.IconSize = 30;
            this.btnClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClean.Location = new System.Drawing.Point(1074, 759);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(121, 40);
            this.btnClean.TabIndex = 180;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnCheckUrlSTEP
            // 
            this.btnCheckUrlSTEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnCheckUrlSTEP.FlatAppearance.BorderSize = 0;
            this.btnCheckUrlSTEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckUrlSTEP.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckUrlSTEP.ForeColor = System.Drawing.Color.White;
            this.btnCheckUrlSTEP.IconChar = FontAwesome.Sharp.IconChar.GoogleDrive;
            this.btnCheckUrlSTEP.IconColor = System.Drawing.Color.White;
            this.btnCheckUrlSTEP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckUrlSTEP.IconSize = 25;
            this.btnCheckUrlSTEP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckUrlSTEP.Location = new System.Drawing.Point(639, 285);
            this.btnCheckUrlSTEP.Name = "btnCheckUrlSTEP";
            this.btnCheckUrlSTEP.Size = new System.Drawing.Size(120, 30);
            this.btnCheckUrlSTEP.TabIndex = 173;
            this.btnCheckUrlSTEP.Text = "Check URL";
            this.btnCheckUrlSTEP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckUrlSTEP.UseVisualStyleBackColor = false;
            this.btnCheckUrlSTEP.Click += new System.EventHandler(this.btnCheckUrlSTEP_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnDisable.FlatAppearance.BorderSize = 0;
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.ForeColor = System.Drawing.Color.White;
            this.btnDisable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDisable.IconColor = System.Drawing.Color.White;
            this.btnDisable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDisable.IconSize = 30;
            this.btnDisable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisable.Location = new System.Drawing.Point(1074, 699);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(121, 40);
            this.btnDisable.TabIndex = 181;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // txtUrlSTEP
            // 
            this.txtUrlSTEP.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlSTEP.Location = new System.Drawing.Point(11, 284);
            this.txtUrlSTEP.Name = "txtUrlSTEP";
            this.txtUrlSTEP.Size = new System.Drawing.Size(611, 30);
            this.txtUrlSTEP.TabIndex = 171;
            this.txtUrlSTEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUrlSTEP.Leave += new System.EventHandler(this.txtUrlSTEP_Leave);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 258);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(582, 23);
            this.label18.TabIndex = 172;
            this.label18.Text = "URL STEP";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckUrlPDF
            // 
            this.btnCheckUrlPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnCheckUrlPDF.FlatAppearance.BorderSize = 0;
            this.btnCheckUrlPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckUrlPDF.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckUrlPDF.ForeColor = System.Drawing.Color.White;
            this.btnCheckUrlPDF.IconChar = FontAwesome.Sharp.IconChar.GoogleDrive;
            this.btnCheckUrlPDF.IconColor = System.Drawing.Color.White;
            this.btnCheckUrlPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckUrlPDF.IconSize = 25;
            this.btnCheckUrlPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckUrlPDF.Location = new System.Drawing.Point(639, 218);
            this.btnCheckUrlPDF.Name = "btnCheckUrlPDF";
            this.btnCheckUrlPDF.Size = new System.Drawing.Size(120, 30);
            this.btnCheckUrlPDF.TabIndex = 170;
            this.btnCheckUrlPDF.Text = "Check URL";
            this.btnCheckUrlPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckUrlPDF.UseVisualStyleBackColor = false;
            this.btnCheckUrlPDF.Click += new System.EventHandler(this.btnCheckUrlPDF_Click);
            // 
            // txtUrlPDF
            // 
            this.txtUrlPDF.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlPDF.Location = new System.Drawing.Point(11, 217);
            this.txtUrlPDF.Name = "txtUrlPDF";
            this.txtUrlPDF.Size = new System.Drawing.Size(611, 30);
            this.txtUrlPDF.TabIndex = 166;
            this.txtUrlPDF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUrlPDF.Leave += new System.EventHandler(this.txtUrlPDF_Leave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 30;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(1074, 637);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 40);
            this.btnUpdate.TabIndex = 179;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(582, 23);
            this.label15.TabIndex = 167;
            this.label15.Text = "URL PDF";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVendorPartNumber
            // 
            this.txtVendorPartNumber.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorPartNumber.Location = new System.Drawing.Point(11, 153);
            this.txtVendorPartNumber.Name = "txtVendorPartNumber";
            this.txtVendorPartNumber.Size = new System.Drawing.Size(611, 30);
            this.txtVendorPartNumber.TabIndex = 164;
            this.txtVendorPartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVendorPartNumber.Leave += new System.EventHandler(this.txtVendorPartNumber_Leave);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(609, 23);
            this.label14.TabIndex = 165;
            this.label14.Text = "Vendor Part Number";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 23);
            this.label12.TabIndex = 163;
            this.label12.Text = "ID Washer";
            // 
            // txtSSNEPartNumber
            // 
            this.txtSSNEPartNumber.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSNEPartNumber.Location = new System.Drawing.Point(11, 89);
            this.txtSSNEPartNumber.Name = "txtSSNEPartNumber";
            this.txtSSNEPartNumber.Size = new System.Drawing.Size(611, 30);
            this.txtSSNEPartNumber.TabIndex = 162;
            this.txtSSNEPartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSSNEPartNumber.Leave += new System.EventHandler(this.txtSSNEPartNumber_Leave);
            // 
            // txtIDWasher
            // 
            this.txtIDWasher.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDWasher.Location = new System.Drawing.Point(11, 52);
            this.txtIDWasher.Name = "txtIDWasher";
            this.txtIDWasher.ReadOnly = true;
            this.txtIDWasher.Size = new System.Drawing.Size(115, 30);
            this.txtIDWasher.TabIndex = 162;
            this.txtIDWasher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1074, 578);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 40);
            this.btnSave.TabIndex = 178;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(611, 23);
            this.label13.TabIndex = 163;
            this.label13.Text = "SSNE Part Number";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtTypeName);
            this.groupBox2.Controls.Add(this.txtIDWasherType);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnClearWasherType);
            this.groupBox2.Controls.Add(this.btnSelectWasherType);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 510);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 161);
            this.groupBox2.TabIndex = 182;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Washer Type";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 23);
            this.label16.TabIndex = 163;
            this.label16.Text = "ID Washer Type";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(10, 123);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.ReadOnly = true;
            this.txtTypeName.Size = new System.Drawing.Size(215, 30);
            this.txtTypeName.TabIndex = 162;
            this.txtTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDWasherType
            // 
            this.txtIDWasherType.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDWasherType.Location = new System.Drawing.Point(10, 64);
            this.txtIDWasherType.Name = "txtIDWasherType";
            this.txtIDWasherType.ReadOnly = true;
            this.txtIDWasherType.Size = new System.Drawing.Size(124, 30);
            this.txtIDWasherType.TabIndex = 162;
            this.txtIDWasherType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDWasherType.TextChanged += new System.EventHandler(this.txtIDWasherType_TextChanged);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(215, 23);
            this.label17.TabIndex = 163;
            this.label17.Text = "Type Name";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearWasherType
            // 
            this.btnClearWasherType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnClearWasherType.FlatAppearance.BorderSize = 0;
            this.btnClearWasherType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearWasherType.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearWasherType.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnClearWasherType.IconColor = System.Drawing.Color.White;
            this.btnClearWasherType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearWasherType.IconSize = 20;
            this.btnClearWasherType.Location = new System.Drawing.Point(189, 64);
            this.btnClearWasherType.Name = "btnClearWasherType";
            this.btnClearWasherType.Size = new System.Drawing.Size(36, 30);
            this.btnClearWasherType.TabIndex = 132;
            this.btnClearWasherType.UseVisualStyleBackColor = false;
            this.btnClearWasherType.Click += new System.EventHandler(this.btnClearWasherType_Click);
            // 
            // btnSelectWasherType
            // 
            this.btnSelectWasherType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnSelectWasherType.FlatAppearance.BorderSize = 0;
            this.btnSelectWasherType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectWasherType.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectWasherType.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnSelectWasherType.IconColor = System.Drawing.Color.White;
            this.btnSelectWasherType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectWasherType.IconSize = 20;
            this.btnSelectWasherType.Location = new System.Drawing.Point(143, 64);
            this.btnSelectWasherType.Name = "btnSelectWasherType";
            this.btnSelectWasherType.Size = new System.Drawing.Size(36, 30);
            this.btnSelectWasherType.TabIndex = 150;
            this.btnSelectWasherType.UseVisualStyleBackColor = false;
            this.btnSelectWasherType.Click += new System.EventHandler(this.btnSelectWasherType_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSizeName);
            this.groupBox1.Controls.Add(this.txtIDWasherSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClearWasherSize);
            this.groupBox1.Controls.Add(this.btnSelectWasherSize);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 677);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 161);
            this.groupBox1.TabIndex = 183;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Washer Size";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 163;
            this.label1.Text = "ID Washer Size";
            // 
            // txtSizeName
            // 
            this.txtSizeName.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSizeName.Location = new System.Drawing.Point(10, 123);
            this.txtSizeName.Name = "txtSizeName";
            this.txtSizeName.ReadOnly = true;
            this.txtSizeName.Size = new System.Drawing.Size(215, 30);
            this.txtSizeName.TabIndex = 162;
            this.txtSizeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDWasherSize
            // 
            this.txtIDWasherSize.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDWasherSize.Location = new System.Drawing.Point(10, 64);
            this.txtIDWasherSize.Name = "txtIDWasherSize";
            this.txtIDWasherSize.ReadOnly = true;
            this.txtIDWasherSize.Size = new System.Drawing.Size(124, 30);
            this.txtIDWasherSize.TabIndex = 162;
            this.txtIDWasherSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDWasherSize.TextChanged += new System.EventHandler(this.txtIDWasherSize_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 23);
            this.label2.TabIndex = 163;
            this.label2.Text = "Size Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearWasherSize
            // 
            this.btnClearWasherSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnClearWasherSize.FlatAppearance.BorderSize = 0;
            this.btnClearWasherSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearWasherSize.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearWasherSize.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnClearWasherSize.IconColor = System.Drawing.Color.White;
            this.btnClearWasherSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearWasherSize.IconSize = 20;
            this.btnClearWasherSize.Location = new System.Drawing.Point(189, 64);
            this.btnClearWasherSize.Name = "btnClearWasherSize";
            this.btnClearWasherSize.Size = new System.Drawing.Size(36, 30);
            this.btnClearWasherSize.TabIndex = 132;
            this.btnClearWasherSize.UseVisualStyleBackColor = false;
            this.btnClearWasherSize.Click += new System.EventHandler(this.btnClearWasherSize_Click);
            // 
            // btnSelectWasherSize
            // 
            this.btnSelectWasherSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnSelectWasherSize.FlatAppearance.BorderSize = 0;
            this.btnSelectWasherSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectWasherSize.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectWasherSize.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnSelectWasherSize.IconColor = System.Drawing.Color.White;
            this.btnSelectWasherSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectWasherSize.IconSize = 20;
            this.btnSelectWasherSize.Location = new System.Drawing.Point(143, 64);
            this.btnSelectWasherSize.Name = "btnSelectWasherSize";
            this.btnSelectWasherSize.Size = new System.Drawing.Size(36, 30);
            this.btnSelectWasherSize.TabIndex = 150;
            this.btnSelectWasherSize.UseVisualStyleBackColor = false;
            this.btnSelectWasherSize.Click += new System.EventHandler(this.btnSelectWasherSize_Click);
            // 
            // checkActives
            // 
            this.checkActives.AutoSize = true;
            this.checkActives.Checked = true;
            this.checkActives.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkActives.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkActives.Location = new System.Drawing.Point(1090, 143);
            this.checkActives.Name = "checkActives";
            this.checkActives.Size = new System.Drawing.Size(105, 23);
            this.checkActives.TabIndex = 184;
            this.checkActives.Text = "See Actives";
            this.checkActives.UseVisualStyleBackColor = true;
            this.checkActives.CheckedChanged += new System.EventHandler(this.checkActives_CheckedChanged);
            // 
            // FrmWashers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 848);
            this.Controls.Add(this.checkActives);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.dgvWashers);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pNavBar);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmWashers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWashers";
            this.Load += new System.EventHandler(this.FrmWashers_Load);
            this.pNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWashers)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pNavBar;
        private FontAwesome.Sharp.IconButton btnFormSize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView dgvWashers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDWasher;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSSNEPartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVendorPartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWasherTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWasherSizeName;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label20;
        private FontAwesome.Sharp.IconButton btnCheckUrlSTEP;
        private System.Windows.Forms.TextBox txtUrlSTEP;
        private System.Windows.Forms.Label label18;
        private FontAwesome.Sharp.IconButton btnCheckUrlPDF;
        private System.Windows.Forms.TextBox txtUrlPDF;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtVendorPartNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSSNEPartNumber;
        private System.Windows.Forms.TextBox txtIDWasher;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btnClean;
        private FontAwesome.Sharp.IconButton btnDisable;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtIDWasherType;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton btnClearWasherType;
        private FontAwesome.Sharp.IconButton btnSelectWasherType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSizeName;
        private System.Windows.Forms.TextBox txtIDWasherSize;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnClearWasherSize;
        private FontAwesome.Sharp.IconButton btnSelectWasherSize;
        private System.Windows.Forms.CheckBox checkActives;
    }
}