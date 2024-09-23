namespace _0510Project.Forms
{
    partial class FrmMainManagementDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNuts = new System.Windows.Forms.Label();
            this.btnWashers = new System.Windows.Forms.Label();
            this.btnScrews = new System.Windows.Forms.Label();
            this.pNavBar.SuspendLayout();
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
            this.pNavBar.Size = new System.Drawing.Size(1268, 48);
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
            this.btnClose.Location = new System.Drawing.Point(1214, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1266, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 371);
            this.panel1.TabIndex = 164;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 371);
            this.panel3.TabIndex = 166;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 2);
            this.panel2.TabIndex = 167;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(3, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1262, 58);
            this.label7.TabIndex = 168;
            this.label7.Text = "MAIN DASHBOARD";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuts
            // 
            this.btnNuts.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNuts.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuts.ForeColor = System.Drawing.Color.White;
            this.btnNuts.Location = new System.Drawing.Point(47, 183);
            this.btnNuts.Name = "btnNuts";
            this.btnNuts.Size = new System.Drawing.Size(350, 135);
            this.btnNuts.TabIndex = 169;
            this.btnNuts.Text = "Nuts";
            this.btnNuts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuts.Click += new System.EventHandler(this.btnNuts_Click);
            // 
            // btnWashers
            // 
            this.btnWashers.BackColor = System.Drawing.Color.DarkCyan;
            this.btnWashers.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWashers.ForeColor = System.Drawing.Color.White;
            this.btnWashers.Location = new System.Drawing.Point(456, 183);
            this.btnWashers.Name = "btnWashers";
            this.btnWashers.Size = new System.Drawing.Size(350, 135);
            this.btnWashers.TabIndex = 170;
            this.btnWashers.Text = "Washers";
            this.btnWashers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWashers.Click += new System.EventHandler(this.btnWashers_Click);
            // 
            // btnScrews
            // 
            this.btnScrews.BackColor = System.Drawing.Color.DarkCyan;
            this.btnScrews.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScrews.ForeColor = System.Drawing.Color.White;
            this.btnScrews.Location = new System.Drawing.Point(865, 183);
            this.btnScrews.Name = "btnScrews";
            this.btnScrews.Size = new System.Drawing.Size(350, 135);
            this.btnScrews.TabIndex = 171;
            this.btnScrews.Text = "Screws";
            this.btnScrews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScrews.Click += new System.EventHandler(this.btnScrews_Click);
            // 
            // FrmMainManagementDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 419);
            this.Controls.Add(this.btnScrews);
            this.Controls.Add(this.btnWashers);
            this.Controls.Add(this.btnNuts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pNavBar);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMainManagementDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Dashboard";
            this.pNavBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNavBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label btnNuts;
        private System.Windows.Forms.Label btnWashers;
        private System.Windows.Forms.Label btnScrews;
    }
}