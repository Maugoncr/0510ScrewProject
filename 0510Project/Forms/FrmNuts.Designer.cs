namespace _0510Project.Forms
{
    partial class FrmNuts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuts));
            this.pNavBar = new System.Windows.Forms.Panel();
            this.btnFormSize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.checkActives = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSizeName = new System.Windows.Forms.TextBox();
            this.txtIDNutsSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearNutsSize = new FontAwesome.Sharp.IconButton();
            this.btnSelectNutsSize = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtIDNutsType = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnClearNutType = new FontAwesome.Sharp.IconButton();
            this.btnSelectNutType = new FontAwesome.Sharp.IconButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCheckUrlSTEP = new FontAwesome.Sharp.IconButton();
            this.txtUrlSTEP = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCheckUrlPDF = new FontAwesome.Sharp.IconButton();
            this.txtUrlPDF = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVendorPartNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSSNEPartNumber = new System.Windows.Forms.TextBox();
            this.txtIDNuts = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvNuts = new System.Windows.Forms.DataGridView();
            this.CIDNuts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSSNEPartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVendorPartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNutsTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNutsSizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClean = new FontAwesome.Sharp.IconButton();
            this.btnDisable = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.pNavBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuts)).BeginInit();
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
            this.pNavBar.TabIndex = 7;
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
            // checkActives
            // 
            this.checkActives.AutoSize = true;
            this.checkActives.Checked = true;
            this.checkActives.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkActives.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkActives.Location = new System.Drawing.Point(1092, 146);
            this.checkActives.Name = "checkActives";
            this.checkActives.Size = new System.Drawing.Size(105, 23);
            this.checkActives.TabIndex = 195;
            this.checkActives.Text = "See Actives";
            this.checkActives.UseVisualStyleBackColor = true;
            this.checkActives.CheckedChanged += new System.EventHandler(this.checkActives_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSizeName);
            this.groupBox1.Controls.Add(this.txtIDNutsSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClearNutsSize);
            this.groupBox1.Controls.Add(this.btnSelectNutsSize);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 680);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 161);
            this.groupBox1.TabIndex = 194;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nut Size";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 163;
            this.label1.Text = "ID Nut Size";
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
            // txtIDNutsSize
            // 
            this.txtIDNutsSize.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNutsSize.Location = new System.Drawing.Point(10, 64);
            this.txtIDNutsSize.Name = "txtIDNutsSize";
            this.txtIDNutsSize.ReadOnly = true;
            this.txtIDNutsSize.Size = new System.Drawing.Size(124, 30);
            this.txtIDNutsSize.TabIndex = 162;
            this.txtIDNutsSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDNutsSize.TextChanged += new System.EventHandler(this.txtIDNutsSize_TextChanged);
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
            // btnClearNutsSize
            // 
            this.btnClearNutsSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnClearNutsSize.FlatAppearance.BorderSize = 0;
            this.btnClearNutsSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearNutsSize.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearNutsSize.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnClearNutsSize.IconColor = System.Drawing.Color.White;
            this.btnClearNutsSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearNutsSize.IconSize = 20;
            this.btnClearNutsSize.Location = new System.Drawing.Point(189, 64);
            this.btnClearNutsSize.Name = "btnClearNutsSize";
            this.btnClearNutsSize.Size = new System.Drawing.Size(36, 30);
            this.btnClearNutsSize.TabIndex = 132;
            this.btnClearNutsSize.UseVisualStyleBackColor = false;
            this.btnClearNutsSize.Click += new System.EventHandler(this.btnClearNutsSize_Click);
            // 
            // btnSelectNutsSize
            // 
            this.btnSelectNutsSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnSelectNutsSize.FlatAppearance.BorderSize = 0;
            this.btnSelectNutsSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectNutsSize.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectNutsSize.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnSelectNutsSize.IconColor = System.Drawing.Color.White;
            this.btnSelectNutsSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectNutsSize.IconSize = 20;
            this.btnSelectNutsSize.Location = new System.Drawing.Point(143, 64);
            this.btnSelectNutsSize.Name = "btnSelectNutsSize";
            this.btnSelectNutsSize.Size = new System.Drawing.Size(36, 30);
            this.btnSelectNutsSize.TabIndex = 150;
            this.btnSelectNutsSize.UseVisualStyleBackColor = false;
            this.btnSelectNutsSize.Click += new System.EventHandler(this.btnSelectNutsSize_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtTypeName);
            this.groupBox2.Controls.Add(this.txtIDNutsType);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnClearNutType);
            this.groupBox2.Controls.Add(this.btnSelectNutType);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 513);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 161);
            this.groupBox2.TabIndex = 193;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nut Type";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 23);
            this.label16.TabIndex = 163;
            this.label16.Text = "ID Nut Type";
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
            // txtIDNutsType
            // 
            this.txtIDNutsType.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNutsType.Location = new System.Drawing.Point(10, 64);
            this.txtIDNutsType.Name = "txtIDNutsType";
            this.txtIDNutsType.ReadOnly = true;
            this.txtIDNutsType.Size = new System.Drawing.Size(124, 30);
            this.txtIDNutsType.TabIndex = 162;
            this.txtIDNutsType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDNutsType.TextChanged += new System.EventHandler(this.txtIDNutsType_TextChanged);
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
            // btnClearNutType
            // 
            this.btnClearNutType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnClearNutType.FlatAppearance.BorderSize = 0;
            this.btnClearNutType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearNutType.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearNutType.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnClearNutType.IconColor = System.Drawing.Color.White;
            this.btnClearNutType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearNutType.IconSize = 20;
            this.btnClearNutType.Location = new System.Drawing.Point(189, 64);
            this.btnClearNutType.Name = "btnClearNutType";
            this.btnClearNutType.Size = new System.Drawing.Size(36, 30);
            this.btnClearNutType.TabIndex = 132;
            this.btnClearNutType.UseVisualStyleBackColor = false;
            this.btnClearNutType.Click += new System.EventHandler(this.btnClearNutType_Click);
            // 
            // btnSelectNutType
            // 
            this.btnSelectNutType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnSelectNutType.FlatAppearance.BorderSize = 0;
            this.btnSelectNutType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectNutType.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectNutType.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnSelectNutType.IconColor = System.Drawing.Color.White;
            this.btnSelectNutType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectNutType.IconSize = 20;
            this.btnSelectNutType.Location = new System.Drawing.Point(143, 64);
            this.btnSelectNutType.Name = "btnSelectNutType";
            this.btnSelectNutType.Size = new System.Drawing.Size(36, 30);
            this.btnSelectNutType.TabIndex = 150;
            this.btnSelectNutType.UseVisualStyleBackColor = false;
            this.btnSelectNutType.Click += new System.EventHandler(this.btnSelectNutType_Click);
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
            this.groupBox7.Controls.Add(this.txtIDNuts);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(289, 518);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(773, 323);
            this.groupBox7.TabIndex = 188;
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
            this.label20.Size = new System.Drawing.Size(61, 33);
            this.label20.TabIndex = 182;
            this.label20.Text = "Nut";
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
            this.label12.Size = new System.Drawing.Size(62, 23);
            this.label12.TabIndex = 163;
            this.label12.Text = "ID Nut";
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
            // txtIDNuts
            // 
            this.txtIDNuts.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNuts.Location = new System.Drawing.Point(11, 52);
            this.txtIDNuts.Name = "txtIDNuts";
            this.txtIDNuts.ReadOnly = true;
            this.txtIDNuts.Size = new System.Drawing.Size(115, 30);
            this.txtIDNuts.TabIndex = 162;
            this.txtIDNuts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // dgvNuts
            // 
            this.dgvNuts.AllowUserToAddRows = false;
            this.dgvNuts.AllowUserToDeleteRows = false;
            this.dgvNuts.AllowUserToResizeColumns = false;
            this.dgvNuts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNuts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDNuts,
            this.CSSNEPartNumber,
            this.CVendorPartNumber,
            this.CNutsTypeName,
            this.CNutsSizeName});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNuts.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNuts.Location = new System.Drawing.Point(25, 175);
            this.dgvNuts.MultiSelect = false;
            this.dgvNuts.Name = "dgvNuts";
            this.dgvNuts.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNuts.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNuts.RowHeadersVisible = false;
            this.dgvNuts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNuts.Size = new System.Drawing.Size(1172, 326);
            this.dgvNuts.TabIndex = 187;
            this.dgvNuts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNuts_CellClick);
            // 
            // CIDNuts
            // 
            this.CIDNuts.DataPropertyName = "IDNuts";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CIDNuts.DefaultCellStyle = dataGridViewCellStyle2;
            this.CIDNuts.HeaderText = "ID Nuts";
            this.CIDNuts.Name = "CIDNuts";
            this.CIDNuts.ReadOnly = true;
            this.CIDNuts.Width = 120;
            // 
            // CSSNEPartNumber
            // 
            this.CSSNEPartNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CSSNEPartNumber.DataPropertyName = "SSNEPartNumber";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CSSNEPartNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.CSSNEPartNumber.HeaderText = "SSNE Part Number";
            this.CSSNEPartNumber.Name = "CSSNEPartNumber";
            this.CSSNEPartNumber.ReadOnly = true;
            this.CSSNEPartNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CVendorPartNumber
            // 
            this.CVendorPartNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CVendorPartNumber.DataPropertyName = "VendorPartNumber";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CVendorPartNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.CVendorPartNumber.HeaderText = "Vendor Part Number";
            this.CVendorPartNumber.Name = "CVendorPartNumber";
            this.CVendorPartNumber.ReadOnly = true;
            this.CVendorPartNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CNutsTypeName
            // 
            this.CNutsTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNutsTypeName.DataPropertyName = "NutsTypeName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CNutsTypeName.DefaultCellStyle = dataGridViewCellStyle5;
            this.CNutsTypeName.HeaderText = "Type";
            this.CNutsTypeName.Name = "CNutsTypeName";
            this.CNutsTypeName.ReadOnly = true;
            this.CNutsTypeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CNutsSizeName
            // 
            this.CNutsSizeName.DataPropertyName = "NutsSizeName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CNutsSizeName.DefaultCellStyle = dataGridViewCellStyle6;
            this.CNutsSizeName.HeaderText = "Size";
            this.CNutsSizeName.Name = "CNutsSizeName";
            this.CNutsSizeName.ReadOnly = true;
            this.CNutsSizeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CNutsSizeName.Width = 150;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(208, 137);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(770, 27);
            this.txtFilter.TabIndex = 186;
            this.txtFilter.Text = "Search...";
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFilter_MouseClick);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto", 40F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1199, 76);
            this.label7.TabIndex = 185;
            this.label7.Text = "Nuts Management";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnClean.Location = new System.Drawing.Point(1076, 762);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(121, 40);
            this.btnClean.TabIndex = 191;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
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
            this.btnDisable.Location = new System.Drawing.Point(1076, 702);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(121, 40);
            this.btnDisable.TabIndex = 192;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
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
            this.btnSave.Location = new System.Drawing.Point(1076, 581);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 40);
            this.btnSave.TabIndex = 189;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(1076, 640);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 40);
            this.btnUpdate.TabIndex = 190;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmNuts
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
            this.Controls.Add(this.dgvNuts);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pNavBar);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmNuts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuts";
            this.Load += new System.EventHandler(this.FrmNuts_Load);
            this.pNavBar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pNavBar;
        private FontAwesome.Sharp.IconButton btnFormSize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox checkActives;
        private FontAwesome.Sharp.IconButton btnClean;
        private FontAwesome.Sharp.IconButton btnDisable;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSizeName;
        private System.Windows.Forms.TextBox txtIDNutsSize;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnClearNutsSize;
        private FontAwesome.Sharp.IconButton btnSelectNutsSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtIDNutsType;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton btnClearNutType;
        private FontAwesome.Sharp.IconButton btnSelectNutType;
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
        private System.Windows.Forms.TextBox txtIDNuts;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvNuts;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDNuts;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSSNEPartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVendorPartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNutsTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNutsSizeName;
    }
}