namespace _0510Project.Forms
{
    partial class FrmInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformation));
            this.pNavBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDownloadFonts = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownloadWebView2 = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDownloadDataBase = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pNavBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNavBar
            // 
            this.pNavBar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pNavBar.Controls.Add(this.btnClose);
            this.pNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNavBar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNavBar.Location = new System.Drawing.Point(0, 0);
            this.pNavBar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pNavBar.Name = "pNavBar";
            this.pNavBar.Size = new System.Drawing.Size(787, 47);
            this.pNavBar.TabIndex = 6;
            this.pNavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pNavBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(730, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 47);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(-56, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(911, 58);
            this.label7.TabIndex = 148;
            this.label7.Text = "Welcome to the software information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(84, 111);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(649, 85);
            this.richTextBox1.TabIndex = 149;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 87);
            this.label1.TabIndex = 172;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDownloadFonts);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(146, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 167);
            this.groupBox1.TabIndex = 173;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option 1";
            // 
            // btnDownloadFonts
            // 
            this.btnDownloadFonts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnDownloadFonts.FlatAppearance.BorderSize = 0;
            this.btnDownloadFonts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadFonts.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadFonts.ForeColor = System.Drawing.Color.White;
            this.btnDownloadFonts.IconChar = FontAwesome.Sharp.IconChar.GoogleDrive;
            this.btnDownloadFonts.IconColor = System.Drawing.Color.White;
            this.btnDownloadFonts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDownloadFonts.IconSize = 25;
            this.btnDownloadFonts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadFonts.Location = new System.Drawing.Point(131, 109);
            this.btnDownloadFonts.Name = "btnDownloadFonts";
            this.btnDownloadFonts.Size = new System.Drawing.Size(225, 37);
            this.btnDownloadFonts.TabIndex = 171;
            this.btnDownloadFonts.Text = "Download Roboto Font";
            this.btnDownloadFonts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadFonts.UseVisualStyleBackColor = false;
            this.btnDownloadFonts.Click += new System.EventHandler(this.btnDownloadFonts_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDownloadWebView2);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(146, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 167);
            this.groupBox2.TabIndex = 174;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option 2";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 87);
            this.label2.TabIndex = 172;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDownloadWebView2
            // 
            this.btnDownloadWebView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnDownloadWebView2.FlatAppearance.BorderSize = 0;
            this.btnDownloadWebView2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadWebView2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadWebView2.ForeColor = System.Drawing.Color.White;
            this.btnDownloadWebView2.IconChar = FontAwesome.Sharp.IconChar.GoogleDrive;
            this.btnDownloadWebView2.IconColor = System.Drawing.Color.White;
            this.btnDownloadWebView2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDownloadWebView2.IconSize = 25;
            this.btnDownloadWebView2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadWebView2.Location = new System.Drawing.Point(114, 109);
            this.btnDownloadWebView2.Name = "btnDownloadWebView2";
            this.btnDownloadWebView2.Size = new System.Drawing.Size(267, 37);
            this.btnDownloadWebView2.TabIndex = 171;
            this.btnDownloadWebView2.Text = "Download WebView2 Engine";
            this.btnDownloadWebView2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadWebView2.UseVisualStyleBackColor = false;
            this.btnDownloadWebView2.Click += new System.EventHandler(this.btnDownloadWebView2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDownloadDataBase);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(146, 558);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 167);
            this.groupBox3.TabIndex = 175;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Option 3";
            // 
            // btnDownloadDataBase
            // 
            this.btnDownloadDataBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnDownloadDataBase.FlatAppearance.BorderSize = 0;
            this.btnDownloadDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadDataBase.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadDataBase.ForeColor = System.Drawing.Color.White;
            this.btnDownloadDataBase.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnDownloadDataBase.IconColor = System.Drawing.Color.White;
            this.btnDownloadDataBase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDownloadDataBase.IconSize = 25;
            this.btnDownloadDataBase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadDataBase.Location = new System.Drawing.Point(144, 100);
            this.btnDownloadDataBase.Name = "btnDownloadDataBase";
            this.btnDownloadDataBase.Size = new System.Drawing.Size(206, 37);
            this.btnDownloadDataBase.TabIndex = 171;
            this.btnDownloadDataBase.Text = "Download Database";
            this.btnDownloadDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadDataBase.UseVisualStyleBackColor = false;
            this.btnDownloadDataBase.Click += new System.EventHandler(this.btnDownloadDataBase_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(14, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(485, 87);
            this.label3.TabIndex = 172;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 694);
            this.panel3.TabIndex = 176;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(785, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 694);
            this.panel1.TabIndex = 177;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 739);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 2);
            this.panel2.TabIndex = 178;
            // 
            // FrmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pNavBar);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInformation";
            this.pNavBar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pNavBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private FontAwesome.Sharp.IconButton btnDownloadFonts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnDownloadWebView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnDownloadDataBase;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}