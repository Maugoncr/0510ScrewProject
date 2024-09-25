namespace _0510Project.Forms
{
    partial class FrmMainManagementWashersDB
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
            this.pNavBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnWasherSize = new System.Windows.Forms.Label();
            this.picWasherSize = new System.Windows.Forms.PictureBox();
            this.btnWasherType = new System.Windows.Forms.Label();
            this.picWasherType = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWasherSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWasherType)).BeginInit();
            this.SuspendLayout();
            // 
            // pNavBar
            // 
            this.pNavBar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pNavBar.Controls.Add(this.btnClose);
            this.pNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNavBar.Location = new System.Drawing.Point(0, 0);
            this.pNavBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pNavBar.Name = "pNavBar";
            this.pNavBar.Size = new System.Drawing.Size(933, 48);
            this.pNavBar.TabIndex = 5;
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
            this.btnClose.Location = new System.Drawing.Point(879, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(10, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(911, 58);
            this.label7.TabIndex = 148;
            this.label7.Text = "WASHERS DASHBOARD";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(367, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 135);
            this.label2.TabIndex = 168;
            this.label2.Text = "Washers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox2.Image = global::_0510Project.Properties.Resources.Screws;
            this.pictureBox2.Location = new System.Drawing.Point(211, 530);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 167;
            this.pictureBox2.TabStop = false;
            // 
            // btnWasherSize
            // 
            this.btnWasherSize.BackColor = System.Drawing.Color.DarkCyan;
            this.btnWasherSize.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWasherSize.ForeColor = System.Drawing.Color.White;
            this.btnWasherSize.Location = new System.Drawing.Point(367, 342);
            this.btnWasherSize.Name = "btnWasherSize";
            this.btnWasherSize.Size = new System.Drawing.Size(350, 135);
            this.btnWasherSize.TabIndex = 166;
            this.btnWasherSize.Text = "Washers Size";
            this.btnWasherSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWasherSize.Click += new System.EventHandler(this.btnWasherSize_Click);
            // 
            // picWasherSize
            // 
            this.picWasherSize.BackColor = System.Drawing.Color.DarkCyan;
            this.picWasherSize.Image = global::_0510Project.Properties.Resources.Size;
            this.picWasherSize.Location = new System.Drawing.Point(211, 342);
            this.picWasherSize.Name = "picWasherSize";
            this.picWasherSize.Size = new System.Drawing.Size(156, 135);
            this.picWasherSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWasherSize.TabIndex = 165;
            this.picWasherSize.TabStop = false;
            this.picWasherSize.Click += new System.EventHandler(this.picWasherSize_Click);
            // 
            // btnWasherType
            // 
            this.btnWasherType.BackColor = System.Drawing.Color.DarkCyan;
            this.btnWasherType.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWasherType.ForeColor = System.Drawing.Color.White;
            this.btnWasherType.Location = new System.Drawing.Point(367, 154);
            this.btnWasherType.Name = "btnWasherType";
            this.btnWasherType.Size = new System.Drawing.Size(350, 135);
            this.btnWasherType.TabIndex = 164;
            this.btnWasherType.Text = "Washers Type";
            this.btnWasherType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWasherType.Click += new System.EventHandler(this.btnWasherType_Click);
            // 
            // picWasherType
            // 
            this.picWasherType.BackColor = System.Drawing.Color.DarkCyan;
            this.picWasherType.Image = global::_0510Project.Properties.Resources.Types;
            this.picWasherType.Location = new System.Drawing.Point(211, 154);
            this.picWasherType.Name = "picWasherType";
            this.picWasherType.Size = new System.Drawing.Size(156, 135);
            this.picWasherType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWasherType.TabIndex = 163;
            this.picWasherType.TabStop = false;
            this.picWasherType.Click += new System.EventHandler(this.picWasherType_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(931, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 654);
            this.panel1.TabIndex = 169;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 654);
            this.panel3.TabIndex = 170;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 700);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 2);
            this.panel2.TabIndex = 171;
            // 
            // FrmMainManagementWashersDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnWasherSize);
            this.Controls.Add(this.picWasherSize);
            this.Controls.Add(this.btnWasherType);
            this.Controls.Add(this.picWasherType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pNavBar);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMainManagementWashersDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Base Management Washers";
            this.pNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWasherSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWasherType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNavBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label btnWasherSize;
        private System.Windows.Forms.PictureBox picWasherSize;
        private System.Windows.Forms.Label btnWasherType;
        private System.Windows.Forms.PictureBox picWasherType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}