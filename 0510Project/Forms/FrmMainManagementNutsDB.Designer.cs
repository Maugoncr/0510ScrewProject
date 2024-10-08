﻿namespace _0510Project.Forms
{
    partial class FrmMainManagementNutsDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainManagementNutsDB));
            this.pNavBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNutsType = new System.Windows.Forms.Label();
            this.picNutsType = new System.Windows.Forms.PictureBox();
            this.btnNutsSize = new System.Windows.Forms.Label();
            this.picNutsSize = new System.Windows.Forms.PictureBox();
            this.btnNuts = new System.Windows.Forms.Label();
            this.picNuts = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNutsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNutsSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNuts)).BeginInit();
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
            this.label7.TabIndex = 147;
            this.label7.Text = "NUTS DASHBOARD";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNutsType
            // 
            this.btnNutsType.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNutsType.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutsType.ForeColor = System.Drawing.Color.White;
            this.btnNutsType.Location = new System.Drawing.Point(368, 153);
            this.btnNutsType.Name = "btnNutsType";
            this.btnNutsType.Size = new System.Drawing.Size(350, 135);
            this.btnNutsType.TabIndex = 158;
            this.btnNutsType.Text = "Nuts Type";
            this.btnNutsType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNutsType.Click += new System.EventHandler(this.btnNutsType_Click);
            // 
            // picNutsType
            // 
            this.picNutsType.BackColor = System.Drawing.Color.DarkCyan;
            this.picNutsType.Image = global::_0510Project.Properties.Resources.Types;
            this.picNutsType.Location = new System.Drawing.Point(212, 153);
            this.picNutsType.Name = "picNutsType";
            this.picNutsType.Size = new System.Drawing.Size(156, 135);
            this.picNutsType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNutsType.TabIndex = 157;
            this.picNutsType.TabStop = false;
            this.picNutsType.Click += new System.EventHandler(this.picNutsType_Click);
            // 
            // btnNutsSize
            // 
            this.btnNutsSize.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNutsSize.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutsSize.ForeColor = System.Drawing.Color.White;
            this.btnNutsSize.Location = new System.Drawing.Point(368, 341);
            this.btnNutsSize.Name = "btnNutsSize";
            this.btnNutsSize.Size = new System.Drawing.Size(350, 135);
            this.btnNutsSize.TabIndex = 160;
            this.btnNutsSize.Text = "Nuts Size";
            this.btnNutsSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNutsSize.Click += new System.EventHandler(this.btnNutsSize_Click);
            // 
            // picNutsSize
            // 
            this.picNutsSize.BackColor = System.Drawing.Color.DarkCyan;
            this.picNutsSize.Image = global::_0510Project.Properties.Resources.Size;
            this.picNutsSize.Location = new System.Drawing.Point(212, 341);
            this.picNutsSize.Name = "picNutsSize";
            this.picNutsSize.Size = new System.Drawing.Size(156, 135);
            this.picNutsSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNutsSize.TabIndex = 159;
            this.picNutsSize.TabStop = false;
            this.picNutsSize.Click += new System.EventHandler(this.picNutsSize_Click);
            // 
            // btnNuts
            // 
            this.btnNuts.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNuts.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuts.ForeColor = System.Drawing.Color.White;
            this.btnNuts.Location = new System.Drawing.Point(368, 529);
            this.btnNuts.Name = "btnNuts";
            this.btnNuts.Size = new System.Drawing.Size(350, 135);
            this.btnNuts.TabIndex = 162;
            this.btnNuts.Text = "Nuts";
            this.btnNuts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuts.Click += new System.EventHandler(this.btnNuts_Click);
            // 
            // picNuts
            // 
            this.picNuts.BackColor = System.Drawing.Color.DarkCyan;
            this.picNuts.Image = global::_0510Project.Properties.Resources.Screws;
            this.picNuts.Location = new System.Drawing.Point(212, 529);
            this.picNuts.Name = "picNuts";
            this.picNuts.Size = new System.Drawing.Size(156, 135);
            this.picNuts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNuts.TabIndex = 161;
            this.picNuts.TabStop = false;
            this.picNuts.Click += new System.EventHandler(this.picNuts_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(931, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 654);
            this.panel1.TabIndex = 164;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 654);
            this.panel3.TabIndex = 166;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 700);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 2);
            this.panel2.TabIndex = 167;
            // 
            // FrmMainManagementNutsDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNuts);
            this.Controls.Add(this.picNuts);
            this.Controls.Add(this.btnNutsSize);
            this.Controls.Add(this.picNutsSize);
            this.Controls.Add(this.btnNutsType);
            this.Controls.Add(this.picNutsType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pNavBar);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMainManagementNutsDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Base Management Nuts";
            this.pNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNutsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNutsSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNuts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNavBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label btnNutsType;
        private System.Windows.Forms.PictureBox picNutsType;
        private System.Windows.Forms.Label btnNutsSize;
        private System.Windows.Forms.PictureBox picNutsSize;
        private System.Windows.Forms.Label btnNuts;
        private System.Windows.Forms.PictureBox picNuts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}