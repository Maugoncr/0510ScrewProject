namespace _0510Project.Forms
{
    partial class FrmMainManagementDB
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
            this.btnAbbreviations = new System.Windows.Forms.Label();
            this.btnMaterials = new System.Windows.Forms.Label();
            this.btnNTools = new System.Windows.Forms.Label();
            this.btnAvailableTools = new System.Windows.Forms.Label();
            this.btnScrews = new System.Windows.Forms.Label();
            this.btnLengths = new System.Windows.Forms.Label();
            this.btnSizes = new System.Windows.Forms.Label();
            this.btnTypes = new System.Windows.Forms.Label();
            this.picScrews = new System.Windows.Forms.PictureBox();
            this.picLength = new System.Windows.Forms.PictureBox();
            this.picSize = new System.Windows.Forms.PictureBox();
            this.picNTools = new System.Windows.Forms.PictureBox();
            this.picAvailableTools = new System.Windows.Forms.PictureBox();
            this.picAbbreviations = new System.Windows.Forms.PictureBox();
            this.picTypes = new System.Windows.Forms.PictureBox();
            this.picMaterials = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScrews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailableTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbbreviations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaterials)).BeginInit();
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
            this.pNavBar.Size = new System.Drawing.Size(1465, 48);
            this.pNavBar.TabIndex = 4;
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
            this.btnClose.Location = new System.Drawing.Point(1411, 0);
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
            this.label7.Location = new System.Drawing.Point(0, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1465, 58);
            this.label7.TabIndex = 146;
            this.label7.Text = "SSNE MIDORI DASHBOARD";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAbbreviations
            // 
            this.btnAbbreviations.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAbbreviations.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbreviations.ForeColor = System.Drawing.Color.White;
            this.btnAbbreviations.Location = new System.Drawing.Point(278, 790);
            this.btnAbbreviations.Name = "btnAbbreviations";
            this.btnAbbreviations.Size = new System.Drawing.Size(350, 135);
            this.btnAbbreviations.TabIndex = 155;
            this.btnAbbreviations.Text = "Screw Abbreviation";
            this.btnAbbreviations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAbbreviations.Click += new System.EventHandler(this.btnAbbreviations_Click);
            // 
            // btnMaterials
            // 
            this.btnMaterials.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMaterials.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterials.ForeColor = System.Drawing.Color.White;
            this.btnMaterials.Location = new System.Drawing.Point(278, 201);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Size = new System.Drawing.Size(350, 135);
            this.btnMaterials.TabIndex = 156;
            this.btnMaterials.Text = "Screw Materials";
            this.btnMaterials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // btnNTools
            // 
            this.btnNTools.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNTools.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNTools.ForeColor = System.Drawing.Color.White;
            this.btnNTools.Location = new System.Drawing.Point(278, 594);
            this.btnNTools.Name = "btnNTools";
            this.btnNTools.Size = new System.Drawing.Size(350, 135);
            this.btnNTools.TabIndex = 157;
            this.btnNTools.Text = "Screw Number Tools";
            this.btnNTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNTools.Click += new System.EventHandler(this.btnNTools_Click);
            // 
            // btnAvailableTools
            // 
            this.btnAvailableTools.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAvailableTools.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailableTools.ForeColor = System.Drawing.Color.White;
            this.btnAvailableTools.Location = new System.Drawing.Point(278, 402);
            this.btnAvailableTools.Name = "btnAvailableTools";
            this.btnAvailableTools.Size = new System.Drawing.Size(350, 135);
            this.btnAvailableTools.TabIndex = 158;
            this.btnAvailableTools.Text = "Screw Available Tools";
            this.btnAvailableTools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAvailableTools.Click += new System.EventHandler(this.btnAvailableTools_Click);
            // 
            // btnScrews
            // 
            this.btnScrews.BackColor = System.Drawing.Color.DarkCyan;
            this.btnScrews.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScrews.ForeColor = System.Drawing.Color.White;
            this.btnScrews.Location = new System.Drawing.Point(968, 790);
            this.btnScrews.Name = "btnScrews";
            this.btnScrews.Size = new System.Drawing.Size(350, 135);
            this.btnScrews.TabIndex = 159;
            this.btnScrews.Text = "Screws";
            this.btnScrews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScrews.Click += new System.EventHandler(this.btnScrews_Click);
            // 
            // btnLengths
            // 
            this.btnLengths.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLengths.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLengths.ForeColor = System.Drawing.Color.White;
            this.btnLengths.Location = new System.Drawing.Point(968, 402);
            this.btnLengths.Name = "btnLengths";
            this.btnLengths.Size = new System.Drawing.Size(350, 135);
            this.btnLengths.TabIndex = 160;
            this.btnLengths.Text = "Screw Lengths";
            this.btnLengths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLengths.Click += new System.EventHandler(this.btnLengths_Click);
            // 
            // btnSizes
            // 
            this.btnSizes.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSizes.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSizes.ForeColor = System.Drawing.Color.White;
            this.btnSizes.Location = new System.Drawing.Point(968, 201);
            this.btnSizes.Name = "btnSizes";
            this.btnSizes.Size = new System.Drawing.Size(350, 135);
            this.btnSizes.TabIndex = 161;
            this.btnSizes.Text = "Screw Sizes";
            this.btnSizes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSizes.Click += new System.EventHandler(this.btnSizes_Click);
            // 
            // btnTypes
            // 
            this.btnTypes.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTypes.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypes.ForeColor = System.Drawing.Color.White;
            this.btnTypes.Location = new System.Drawing.Point(968, 594);
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.Size = new System.Drawing.Size(350, 135);
            this.btnTypes.TabIndex = 162;
            this.btnTypes.Text = "Screw Types";
            this.btnTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTypes.Click += new System.EventHandler(this.btnTypes_Click);
            // 
            // picScrews
            // 
            this.picScrews.BackColor = System.Drawing.Color.DarkCyan;
            this.picScrews.Location = new System.Drawing.Point(812, 790);
            this.picScrews.Name = "picScrews";
            this.picScrews.Size = new System.Drawing.Size(156, 135);
            this.picScrews.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picScrews.TabIndex = 154;
            this.picScrews.TabStop = false;
            this.picScrews.Click += new System.EventHandler(this.picScrews_Click);
            // 
            // picLength
            // 
            this.picLength.BackColor = System.Drawing.Color.DarkCyan;
            this.picLength.Location = new System.Drawing.Point(812, 402);
            this.picLength.Name = "picLength";
            this.picLength.Size = new System.Drawing.Size(156, 135);
            this.picLength.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLength.TabIndex = 153;
            this.picLength.TabStop = false;
            this.picLength.Click += new System.EventHandler(this.picLength_Click);
            // 
            // picSize
            // 
            this.picSize.BackColor = System.Drawing.Color.DarkCyan;
            this.picSize.Location = new System.Drawing.Point(812, 201);
            this.picSize.Name = "picSize";
            this.picSize.Size = new System.Drawing.Size(156, 135);
            this.picSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSize.TabIndex = 152;
            this.picSize.TabStop = false;
            this.picSize.Click += new System.EventHandler(this.picSize_Click);
            // 
            // picNTools
            // 
            this.picNTools.BackColor = System.Drawing.Color.DarkCyan;
            this.picNTools.Location = new System.Drawing.Point(123, 594);
            this.picNTools.Name = "picNTools";
            this.picNTools.Size = new System.Drawing.Size(156, 135);
            this.picNTools.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNTools.TabIndex = 151;
            this.picNTools.TabStop = false;
            this.picNTools.Click += new System.EventHandler(this.picNTools_Click);
            // 
            // picAvailableTools
            // 
            this.picAvailableTools.BackColor = System.Drawing.Color.DarkCyan;
            this.picAvailableTools.Location = new System.Drawing.Point(122, 402);
            this.picAvailableTools.Name = "picAvailableTools";
            this.picAvailableTools.Size = new System.Drawing.Size(156, 135);
            this.picAvailableTools.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAvailableTools.TabIndex = 150;
            this.picAvailableTools.TabStop = false;
            this.picAvailableTools.Click += new System.EventHandler(this.picAvailableTools_Click);
            // 
            // picAbbreviations
            // 
            this.picAbbreviations.BackColor = System.Drawing.Color.DarkCyan;
            this.picAbbreviations.Location = new System.Drawing.Point(122, 790);
            this.picAbbreviations.Name = "picAbbreviations";
            this.picAbbreviations.Size = new System.Drawing.Size(156, 135);
            this.picAbbreviations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAbbreviations.TabIndex = 149;
            this.picAbbreviations.TabStop = false;
            this.picAbbreviations.Click += new System.EventHandler(this.picAbbreviations_Click);
            // 
            // picTypes
            // 
            this.picTypes.BackColor = System.Drawing.Color.DarkCyan;
            this.picTypes.Location = new System.Drawing.Point(812, 594);
            this.picTypes.Name = "picTypes";
            this.picTypes.Size = new System.Drawing.Size(156, 135);
            this.picTypes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTypes.TabIndex = 148;
            this.picTypes.TabStop = false;
            this.picTypes.Click += new System.EventHandler(this.picTypes_Click);
            // 
            // picMaterials
            // 
            this.picMaterials.BackColor = System.Drawing.Color.DarkCyan;
            this.picMaterials.Location = new System.Drawing.Point(122, 201);
            this.picMaterials.Name = "picMaterials";
            this.picMaterials.Size = new System.Drawing.Size(156, 135);
            this.picMaterials.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMaterials.TabIndex = 147;
            this.picMaterials.TabStop = false;
            this.picMaterials.Click += new System.EventHandler(this.picMaterials_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1463, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 1013);
            this.panel1.TabIndex = 163;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1059);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1463, 2);
            this.panel2.TabIndex = 164;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 1011);
            this.panel3.TabIndex = 165;
            // 
            // FrmMainManagementDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 1061);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTypes);
            this.Controls.Add(this.btnSizes);
            this.Controls.Add(this.btnLengths);
            this.Controls.Add(this.btnScrews);
            this.Controls.Add(this.btnAvailableTools);
            this.Controls.Add(this.btnNTools);
            this.Controls.Add(this.btnMaterials);
            this.Controls.Add(this.btnAbbreviations);
            this.Controls.Add(this.picScrews);
            this.Controls.Add(this.picLength);
            this.Controls.Add(this.picSize);
            this.Controls.Add(this.picNTools);
            this.Controls.Add(this.picAvailableTools);
            this.Controls.Add(this.picAbbreviations);
            this.Controls.Add(this.picTypes);
            this.Controls.Add(this.picMaterials);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pNavBar);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMainManagementDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0510 DataBase Managament System";
            this.Load += new System.EventHandler(this.FrmMainManagementDB_Load);
            this.pNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picScrews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailableTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbbreviations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaterials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNavBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picMaterials;
        private System.Windows.Forms.PictureBox picTypes;
        private System.Windows.Forms.PictureBox picAbbreviations;
        private System.Windows.Forms.PictureBox picAvailableTools;
        private System.Windows.Forms.PictureBox picNTools;
        private System.Windows.Forms.PictureBox picSize;
        private System.Windows.Forms.PictureBox picLength;
        private System.Windows.Forms.PictureBox picScrews;
        private System.Windows.Forms.Label btnAbbreviations;
        private System.Windows.Forms.Label btnMaterials;
        private System.Windows.Forms.Label btnNTools;
        private System.Windows.Forms.Label btnAvailableTools;
        private System.Windows.Forms.Label btnScrews;
        private System.Windows.Forms.Label btnLengths;
        private System.Windows.Forms.Label btnSizes;
        private System.Windows.Forms.Label btnTypes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}