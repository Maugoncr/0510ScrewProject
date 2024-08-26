namespace _0510Project
{
    partial class FrmMain
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
            this.cbDriveType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pNavBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFormSize = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tDateTime = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.listSize = new System.Windows.Forms.ListBox();
            this.txtSearchSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchLength = new System.Windows.Forms.TextBox();
            this.listLength = new System.Windows.Forms.ListBox();
            this.picLengthTorx = new System.Windows.Forms.PictureBox();
            this.picLengthSunk = new System.Windows.Forms.PictureBox();
            this.picLengthSocketHead = new System.Windows.Forms.PictureBox();
            this.picTorx = new System.Windows.Forms.PictureBox();
            this.picSocket = new System.Windows.Forms.PictureBox();
            this.picSunk = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPDF = new FontAwesome.Sharp.IconButton();
            this.btnSTP = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pSizeSelect = new System.Windows.Forms.Panel();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAVGZ5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvLength = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbAbbreviation = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.pNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLengthTorx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLengthSunk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLengthSocketHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTorx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunk)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pSizeSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLength)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDriveType
            // 
            this.cbDriveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDriveType.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDriveType.FormattingEnabled = true;
            this.cbDriveType.Items.AddRange(new object[] {
            "Socket Head Screw",
            "Countersunk Screw",
            "Torx Screw",
            "Vent Socket Head Screw"});
            this.cbDriveType.Location = new System.Drawing.Point(13, 150);
            this.cbDriveType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDriveType.Name = "cbDriveType";
            this.cbDriveType.Size = new System.Drawing.Size(388, 46);
            this.cbDriveType.TabIndex = 2;
            this.cbDriveType.SelectionChangeCommitted += new System.EventHandler(this.cbDriveType_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Screw Type:";
            // 
            // pNavBar
            // 
            this.pNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.pNavBar.Controls.Add(this.label2);
            this.pNavBar.Controls.Add(this.btnFormSize);
            this.pNavBar.Controls.Add(this.pictureBox1);
            this.pNavBar.Controls.Add(this.btnExit);
            this.pNavBar.Controls.Add(this.lbDateTime);
            this.pNavBar.Controls.Add(this.label3);
            this.pNavBar.Controls.Add(this.menuStrip1);
            this.pNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNavBar.Location = new System.Drawing.Point(0, 0);
            this.pNavBar.Name = "pNavBar";
            this.pNavBar.Size = new System.Drawing.Size(1920, 97);
            this.pNavBar.TabIndex = 4;
            this.pNavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pNavBar_MouseDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "0510 Project";
            // 
            // btnFormSize
            // 
            this.btnFormSize.FlatAppearance.BorderSize = 0;
            this.btnFormSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormSize.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
            this.btnFormSize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(254)))), ((int)(((byte)(251)))));
            this.btnFormSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFormSize.IconSize = 30;
            this.btnFormSize.Location = new System.Drawing.Point(1822, 3);
            this.btnFormSize.Name = "btnFormSize";
            this.btnFormSize.Size = new System.Drawing.Size(41, 46);
            this.btnFormSize.TabIndex = 1;
            this.btnFormSize.UseVisualStyleBackColor = true;
            this.btnFormSize.Click += new System.EventHandler(this.btnFormSize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_0510Project.Properties.Resources.SSNE_Just_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(254)))), ((int)(((byte)(251)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 35;
            this.btnExit.Location = new System.Drawing.Point(1869, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 46);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbDateTime
            // 
            this.lbDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lbDateTime.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.ForeColor = System.Drawing.Color.White;
            this.lbDateTime.Location = new System.Drawing.Point(1611, 73);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(299, 13);
            this.lbDateTime.TabIndex = 358;
            this.lbDateTime.Text = "DateTime";
            this.lbDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 53);
            this.label3.TabIndex = 1;
            this.label3.Text = "SSNE GROUP, INC";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 62);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1920, 35);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(115, 31);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // tDateTime
            // 
            this.tDateTime.Enabled = true;
            this.tDateTime.Interval = 1000;
            this.tDateTime.Tick += new System.EventHandler(this.tDateTime_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Thread Size:";
            // 
            // listSize
            // 
            this.listSize.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSize.FormattingEnabled = true;
            this.listSize.ItemHeight = 23;
            this.listSize.Items.AddRange(new object[] {
            "0-80",
            "1-64",
            "1-72",
            "2-56",
            "2-64",
            "3-48",
            "3-56",
            "",
            "",
            "4-40",
            "6-32",
            "8-32",
            "10-32",
            "****",
            "1/4-20",
            "1/4-28",
            "5/16-18",
            "5/16-24",
            "3/8-16",
            "3/8-24"});
            this.listSize.Location = new System.Drawing.Point(10, 75);
            this.listSize.Name = "listSize";
            this.listSize.ScrollAlwaysVisible = true;
            this.listSize.Size = new System.Drawing.Size(226, 142);
            this.listSize.TabIndex = 9;
            // 
            // txtSearchSize
            // 
            this.txtSearchSize.Location = new System.Drawing.Point(10, 53);
            this.txtSearchSize.Name = "txtSearchSize";
            this.txtSearchSize.Size = new System.Drawing.Size(226, 23);
            this.txtSearchSize.TabIndex = 11;
            this.txtSearchSize.Text = "Search";
            this.txtSearchSize.Click += new System.EventHandler(this.txtSearchSize_Click);
            this.txtSearchSize.TextChanged += new System.EventHandler(this.txtSearchSize_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select Length Size:";
            // 
            // txtSearchLength
            // 
            this.txtSearchLength.Location = new System.Drawing.Point(15, 281);
            this.txtSearchLength.Name = "txtSearchLength";
            this.txtSearchLength.Size = new System.Drawing.Size(226, 23);
            this.txtSearchLength.TabIndex = 15;
            this.txtSearchLength.Text = "Search";
            this.txtSearchLength.Click += new System.EventHandler(this.txtSearchLength_Click);
            this.txtSearchLength.TextChanged += new System.EventHandler(this.txtSearchLength_TextChanged);
            // 
            // listLength
            // 
            this.listLength.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLength.FormattingEnabled = true;
            this.listLength.ItemHeight = 23;
            this.listLength.Items.AddRange(new object[] {
            "X\"",
            "1/4\"",
            "3/8\"",
            "1/2\"",
            "5/8\"",
            "3/4\"",
            "7/8\"",
            "1\"",
            "1\" X ",
            "1\" 1/4",
            "1\" 3/8",
            "1\" 1/2",
            "1\" 5/8",
            "1\" 3/4"});
            this.listLength.Location = new System.Drawing.Point(15, 303);
            this.listLength.Name = "listLength";
            this.listLength.ScrollAlwaysVisible = true;
            this.listLength.Size = new System.Drawing.Size(226, 142);
            this.listLength.TabIndex = 14;
            this.listLength.SelectedIndexChanged += new System.EventHandler(this.listLength_SelectedIndexChanged);
            // 
            // picLengthTorx
            // 
            this.picLengthTorx.Image = global::_0510Project.Properties.Resources.LengthTorx;
            this.picLengthTorx.Location = new System.Drawing.Point(267, 281);
            this.picLengthTorx.Name = "picLengthTorx";
            this.picLengthTorx.Size = new System.Drawing.Size(68, 49);
            this.picLengthTorx.TabIndex = 17;
            this.picLengthTorx.TabStop = false;
            // 
            // picLengthSunk
            // 
            this.picLengthSunk.Image = global::_0510Project.Properties.Resources.LengthSunk;
            this.picLengthSunk.Location = new System.Drawing.Point(267, 281);
            this.picLengthSunk.Name = "picLengthSunk";
            this.picLengthSunk.Size = new System.Drawing.Size(68, 49);
            this.picLengthSunk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLengthSunk.TabIndex = 16;
            this.picLengthSunk.TabStop = false;
            // 
            // picLengthSocketHead
            // 
            this.picLengthSocketHead.Image = global::_0510Project.Properties.Resources.LengthSocketHead;
            this.picLengthSocketHead.Location = new System.Drawing.Point(267, 281);
            this.picLengthSocketHead.Name = "picLengthSocketHead";
            this.picLengthSocketHead.Size = new System.Drawing.Size(68, 49);
            this.picLengthSocketHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLengthSocketHead.TabIndex = 12;
            this.picLengthSocketHead.TabStop = false;
            // 
            // picTorx
            // 
            this.picTorx.Image = global::_0510Project.Properties.Resources.TorxScrewISO_TOP;
            this.picTorx.Location = new System.Drawing.Point(1194, 114);
            this.picTorx.Name = "picTorx";
            this.picTorx.Size = new System.Drawing.Size(174, 107);
            this.picTorx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTorx.TabIndex = 7;
            this.picTorx.TabStop = false;
            // 
            // picSocket
            // 
            this.picSocket.Image = global::_0510Project.Properties.Resources.SocketHeadScrew;
            this.picSocket.Location = new System.Drawing.Point(1647, 199);
            this.picSocket.Name = "picSocket";
            this.picSocket.Size = new System.Drawing.Size(129, 88);
            this.picSocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSocket.TabIndex = 6;
            this.picSocket.TabStop = false;
            // 
            // picSunk
            // 
            this.picSunk.Image = global::_0510Project.Properties.Resources.CountersunkScrew;
            this.picSunk.Location = new System.Drawing.Point(1538, 235);
            this.picSunk.Name = "picSunk";
            this.picSunk.Size = new System.Drawing.Size(90, 52);
            this.picSunk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSunk.TabIndex = 5;
            this.picSunk.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(877, 497);
            this.webBrowser1.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(690, 560);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 497);
            this.panel1.TabIndex = 19;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnPDF.IconColor = System.Drawing.Color.White;
            this.btnPDF.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnPDF.IconSize = 25;
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDF.Location = new System.Drawing.Point(141, 473);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(75, 33);
            this.btnPDF.TabIndex = 356;
            this.btnPDF.Text = "PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnSTP
            // 
            this.btnSTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnSTP.FlatAppearance.BorderSize = 0;
            this.btnSTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTP.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTP.ForeColor = System.Drawing.Color.White;
            this.btnSTP.IconChar = FontAwesome.Sharp.IconChar.FileArchive;
            this.btnSTP.IconColor = System.Drawing.Color.White;
            this.btnSTP.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSTP.IconSize = 25;
            this.btnSTP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSTP.Location = new System.Drawing.Point(15, 473);
            this.btnSTP.Name = "btnSTP";
            this.btnSTP.Size = new System.Drawing.Size(75, 33);
            this.btnSTP.TabIndex = 357;
            this.btnSTP.Text = "STP";
            this.btnSTP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSTP.UseVisualStyleBackColor = false;
            this.btnSTP.Click += new System.EventHandler(this.btnSTP_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSTP);
            this.panel2.Controls.Add(this.picLengthSocketHead);
            this.panel2.Controls.Add(this.picLengthSunk);
            this.panel2.Controls.Add(this.listLength);
            this.panel2.Controls.Add(this.btnPDF);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.listSize);
            this.panel2.Controls.Add(this.picLengthTorx);
            this.panel2.Controls.Add(this.txtSearchSize);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSearchLength);
            this.panel2.Location = new System.Drawing.Point(1590, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 525);
            this.panel2.TabIndex = 358;
            // 
            // pSizeSelect
            // 
            this.pSizeSelect.BackColor = System.Drawing.Color.DarkGray;
            this.pSizeSelect.Controls.Add(this.radioButton10);
            this.pSizeSelect.Controls.Add(this.radioButton9);
            this.pSizeSelect.Controls.Add(this.radioButton8);
            this.pSizeSelect.Controls.Add(this.radioButton7);
            this.pSizeSelect.Controls.Add(this.radioButton6);
            this.pSizeSelect.Controls.Add(this.radioButton5);
            this.pSizeSelect.Controls.Add(this.radioButton4);
            this.pSizeSelect.Controls.Add(this.radioButton3);
            this.pSizeSelect.Controls.Add(this.radioButton2);
            this.pSizeSelect.Controls.Add(this.radioButton1);
            this.pSizeSelect.Controls.Add(this.label14);
            this.pSizeSelect.Controls.Add(this.label13);
            this.pSizeSelect.Controls.Add(this.label12);
            this.pSizeSelect.Controls.Add(this.label11);
            this.pSizeSelect.Controls.Add(this.label10);
            this.pSizeSelect.Controls.Add(this.label9);
            this.pSizeSelect.Controls.Add(this.label8);
            this.pSizeSelect.Controls.Add(this.label7);
            this.pSizeSelect.Controls.Add(this.label6);
            this.pSizeSelect.Controls.Add(this.lbAVGZ5);
            this.pSizeSelect.Location = new System.Drawing.Point(13, 260);
            this.pSizeSelect.Name = "pSizeSelect";
            this.pSizeSelect.Size = new System.Drawing.Size(1456, 72);
            this.pSizeSelect.TabIndex = 359;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioButton10.Location = new System.Drawing.Point(1422, 14);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(14, 13);
            this.radioButton10.TabIndex = 365;
            this.radioButton10.TabStop = true;
            this.radioButton10.UseVisualStyleBackColor = false;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioButton9.Location = new System.Drawing.Point(1278, 14);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(14, 13);
            this.radioButton9.TabIndex = 365;
            this.radioButton9.TabStop = true;
            this.radioButton9.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioButton8.Location = new System.Drawing.Point(1134, 14);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(14, 13);
            this.radioButton8.TabIndex = 364;
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioButton7.Location = new System.Drawing.Point(991, 14);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(14, 13);
            this.radioButton7.TabIndex = 362;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioButton6.Location = new System.Drawing.Point(847, 14);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(14, 13);
            this.radioButton6.TabIndex = 363;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioButton5.Location = new System.Drawing.Point(703, 14);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 362;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioButton4.Location = new System.Drawing.Point(559, 14);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 362;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioButton3.Location = new System.Drawing.Point(416, 14);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 361;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioButton2.Location = new System.Drawing.Point(272, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 361;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioButton1.Location = new System.Drawing.Point(128, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 360;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label14.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(1312, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 47);
            this.label14.TabIndex = 359;
            this.label14.Text = "3/8 - 24";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label13.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(1168, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 47);
            this.label13.TabIndex = 358;
            this.label13.Text = "3/8 - 16";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label12.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(1024, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 47);
            this.label12.TabIndex = 357;
            this.label12.Text = "5/16 -24";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label11.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(881, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 47);
            this.label11.TabIndex = 356;
            this.label11.Text = "5/16 - 18";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label10.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(737, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 47);
            this.label10.TabIndex = 355;
            this.label10.Text = "1/4 - 28";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label9.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(593, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 47);
            this.label9.TabIndex = 354;
            this.label9.Text = "1/4 - 20";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label8.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(449, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 47);
            this.label8.TabIndex = 353;
            this.label8.Text = "10 - 32";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label7.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(306, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 47);
            this.label7.TabIndex = 352;
            this.label7.Text = "8 - 32";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label6.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(162, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 47);
            this.label6.TabIndex = 351;
            this.label6.Text = "6 - 32";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAVGZ5
            // 
            this.lbAVGZ5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbAVGZ5.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAVGZ5.ForeColor = System.Drawing.Color.Black;
            this.lbAVGZ5.Location = new System.Drawing.Point(18, 12);
            this.lbAVGZ5.Name = "lbAVGZ5";
            this.lbAVGZ5.Size = new System.Drawing.Size(125, 47);
            this.lbAVGZ5.TabIndex = 349;
            this.lbAVGZ5.Text = "4 - 40";
            this.lbAVGZ5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(190, 27);
            this.label15.TabIndex = 360;
            this.label15.Text = "Select Screw Size:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 348);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(266, 33);
            this.label16.TabIndex = 361;
            this.label16.Text = "Select Screw Length:";
            // 
            // dgvLength
            // 
            this.dgvLength.AllowUserToAddRows = false;
            this.dgvLength.AllowUserToDeleteRows = false;
            this.dgvLength.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLength.Location = new System.Drawing.Point(18, 396);
            this.dgvLength.Name = "dgvLength";
            this.dgvLength.ReadOnly = true;
            this.dgvLength.Size = new System.Drawing.Size(1890, 155);
            this.dgvLength.TabIndex = 362;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(424, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 27);
            this.label17.TabIndex = 363;
            this.label17.Text = "Abbreviation:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(627, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 25);
            this.label18.TabIndex = 364;
            this.label18.Text = "Material:";
            // 
            // lbAbbreviation
            // 
            this.lbAbbreviation.BackColor = System.Drawing.Color.LightGray;
            this.lbAbbreviation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAbbreviation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAbbreviation.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbbreviation.Location = new System.Drawing.Point(429, 150);
            this.lbAbbreviation.Name = "lbAbbreviation";
            this.lbAbbreviation.Size = new System.Drawing.Size(176, 46);
            this.lbAbbreviation.TabIndex = 366;
            this.lbAbbreviation.Text = "SOC HD";
            this.lbAbbreviation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Roboto", 16F);
            this.label21.Location = new System.Drawing.Point(828, 114);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 27);
            this.label21.TabIndex = 367;
            this.label21.Text = "Tool:";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.LightGray;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(633, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(176, 46);
            this.label20.TabIndex = 370;
            this.label20.Text = "SST";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.LightGray;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(833, 149);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(176, 46);
            this.label19.TabIndex = 371;
            this.label19.Text = "N° ---";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Roboto", 16F);
            this.label22.Location = new System.Drawing.Point(1026, 114);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(162, 27);
            this.label22.TabIndex = 372;
            this.label22.Text = "Isometric View:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Roboto", 16F);
            this.label23.Location = new System.Drawing.Point(1388, 114);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 27);
            this.label23.TabIndex = 373;
            this.label23.Text = "Top View:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lbAbbreviation);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgvLength);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pSizeSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picTorx);
            this.Controls.Add(this.picSocket);
            this.Controls.Add(this.picSunk);
            this.Controls.Add(this.pNavBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDriveType);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bu";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLengthTorx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLengthSunk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLengthSocketHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTorx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunk)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pSizeSelect.ResumeLayout(false);
            this.pSizeSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDriveType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pNavBar;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnFormSize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.Timer tDateTime;
        private System.Windows.Forms.PictureBox picSunk;
        private System.Windows.Forms.PictureBox picSocket;
        private System.Windows.Forms.PictureBox picTorx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listSize;
        private System.Windows.Forms.TextBox txtSearchSize;
        private System.Windows.Forms.PictureBox picLengthSocketHead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchLength;
        private System.Windows.Forms.ListBox listLength;
        private System.Windows.Forms.PictureBox picLengthSunk;
        private System.Windows.Forms.PictureBox picLengthTorx;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnPDF;
        private FontAwesome.Sharp.IconButton btnSTP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pSizeSelect;
        private System.Windows.Forms.Label lbAVGZ5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvLength;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbAbbreviation;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}

