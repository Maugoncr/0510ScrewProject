namespace _0510Project.Forms
{
    partial class FrmScrewLength
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pNavBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDisable = new FontAwesome.Sharp.IconButton();
            this.checkActives = new System.Windows.Forms.CheckBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnClean = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.dgvScrewLengths = new System.Windows.Forms.DataGridView();
            this.txtLengthInch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDScrewLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLengthDecimal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLengthMetric = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CIDScrewLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLengthInch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLengthDecimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLengthMetric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScrewLengths)).BeginInit();
            this.SuspendLayout();
            // 
            // pNavBar
            // 
            this.pNavBar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pNavBar.Controls.Add(this.btnClose);
            this.pNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNavBar.Location = new System.Drawing.Point(0, 0);
            this.pNavBar.Name = "pNavBar";
            this.pNavBar.Size = new System.Drawing.Size(1100, 42);
            this.pNavBar.TabIndex = 3;
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
            this.btnClose.Location = new System.Drawing.Point(1054, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 42);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDisable.FlatAppearance.BorderSize = 0;
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.ForeColor = System.Drawing.Color.White;
            this.btnDisable.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnDisable.IconColor = System.Drawing.Color.White;
            this.btnDisable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDisable.IconSize = 30;
            this.btnDisable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisable.Location = new System.Drawing.Point(944, 477);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(121, 33);
            this.btnDisable.TabIndex = 156;
            this.btnDisable.Text = "     Disable";
            this.btnDisable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // checkActives
            // 
            this.checkActives.AutoSize = true;
            this.checkActives.Checked = true;
            this.checkActives.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkActives.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkActives.Location = new System.Drawing.Point(960, 416);
            this.checkActives.Name = "checkActives";
            this.checkActives.Size = new System.Drawing.Size(105, 23);
            this.checkActives.TabIndex = 155;
            this.checkActives.Text = "See Actives";
            this.checkActives.UseVisualStyleBackColor = true;
            this.checkActives.CheckedChanged += new System.EventHandler(this.checkActives_CheckedChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(35, 127);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(1030, 27);
            this.txtFilter.TabIndex = 154;
            this.txtFilter.Text = "Search...";
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFilter_MouseClick);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnClean.IconColor = System.Drawing.Color.White;
            this.btnClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClean.IconSize = 25;
            this.btnClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClean.Location = new System.Drawing.Point(951, 558);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(114, 33);
            this.btnClean.TabIndex = 153;
            this.btnClean.Text = "     Clean";
            this.btnClean.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 20;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(821, 477);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 33);
            this.btnUpdate.TabIndex = 152;
            this.btnUpdate.Text = "  Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 25;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(708, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 33);
            this.btnSave.TabIndex = 151;
            this.btnSave.Text = "     Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvScrewLengths
            // 
            this.dgvScrewLengths.AllowUserToAddRows = false;
            this.dgvScrewLengths.AllowUserToDeleteRows = false;
            this.dgvScrewLengths.AllowUserToResizeColumns = false;
            this.dgvScrewLengths.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScrewLengths.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScrewLengths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScrewLengths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDScrewLength,
            this.CLengthInch,
            this.CLengthDecimal,
            this.CLengthMetric});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScrewLengths.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvScrewLengths.Location = new System.Drawing.Point(35, 166);
            this.dgvScrewLengths.MultiSelect = false;
            this.dgvScrewLengths.Name = "dgvScrewLengths";
            this.dgvScrewLengths.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScrewLengths.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvScrewLengths.RowHeadersVisible = false;
            this.dgvScrewLengths.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScrewLengths.Size = new System.Drawing.Size(1030, 244);
            this.dgvScrewLengths.TabIndex = 150;
            this.dgvScrewLengths.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScrewLengths_CellClick);
            // 
            // txtLengthInch
            // 
            this.txtLengthInch.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLengthInch.Location = new System.Drawing.Point(272, 477);
            this.txtLengthInch.Name = "txtLengthInch";
            this.txtLengthInch.Size = new System.Drawing.Size(385, 33);
            this.txtLengthInch.TabIndex = 149;
            this.txtLengthInch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 29);
            this.label2.TabIndex = 148;
            this.label2.Text = "Length Inch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDScrewLength
            // 
            this.txtIDScrewLength.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDScrewLength.Location = new System.Drawing.Point(35, 477);
            this.txtIDScrewLength.Name = "txtIDScrewLength";
            this.txtIDScrewLength.ReadOnly = true;
            this.txtIDScrewLength.Size = new System.Drawing.Size(201, 33);
            this.txtIDScrewLength.TabIndex = 147;
            this.txtIDScrewLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 146;
            this.label1.Text = "ID Screw Length";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(35, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1030, 49);
            this.label7.TabIndex = 145;
            this.label7.Text = "Screw Lengths";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLengthDecimal
            // 
            this.txtLengthDecimal.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLengthDecimal.Location = new System.Drawing.Point(272, 556);
            this.txtLengthDecimal.Name = "txtLengthDecimal";
            this.txtLengthDecimal.Size = new System.Drawing.Size(385, 33);
            this.txtLengthDecimal.TabIndex = 158;
            this.txtLengthDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 29);
            this.label3.TabIndex = 157;
            this.label3.Text = "Length Decimal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLengthMetric
            // 
            this.txtLengthMetric.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLengthMetric.Location = new System.Drawing.Point(272, 635);
            this.txtLengthMetric.Name = "txtLengthMetric";
            this.txtLengthMetric.Size = new System.Drawing.Size(385, 33);
            this.txtLengthMetric.TabIndex = 160;
            this.txtLengthMetric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 29);
            this.label4.TabIndex = 159;
            this.label4.Text = "Length Metric";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CIDScrewLength
            // 
            this.CIDScrewLength.DataPropertyName = "IDScrewLength";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CIDScrewLength.DefaultCellStyle = dataGridViewCellStyle2;
            this.CIDScrewLength.HeaderText = "ID Screw Length";
            this.CIDScrewLength.Name = "CIDScrewLength";
            this.CIDScrewLength.ReadOnly = true;
            this.CIDScrewLength.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CIDScrewLength.Width = 200;
            // 
            // CLengthInch
            // 
            this.CLengthInch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CLengthInch.DataPropertyName = "LengthInch";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CLengthInch.DefaultCellStyle = dataGridViewCellStyle3;
            this.CLengthInch.HeaderText = "Length Inch";
            this.CLengthInch.Name = "CLengthInch";
            this.CLengthInch.ReadOnly = true;
            this.CLengthInch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CLengthDecimal
            // 
            this.CLengthDecimal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CLengthDecimal.DataPropertyName = "LengthDecimal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CLengthDecimal.DefaultCellStyle = dataGridViewCellStyle4;
            this.CLengthDecimal.HeaderText = "Length Decimal";
            this.CLengthDecimal.Name = "CLengthDecimal";
            this.CLengthDecimal.ReadOnly = true;
            this.CLengthDecimal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CLengthMetric
            // 
            this.CLengthMetric.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CLengthMetric.DataPropertyName = "LengthMetric";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CLengthMetric.DefaultCellStyle = dataGridViewCellStyle5;
            this.CLengthMetric.HeaderText = "Length Metric";
            this.CLengthMetric.Name = "CLengthMetric";
            this.CLengthMetric.ReadOnly = true;
            this.CLengthMetric.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmScrewLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 690);
            this.Controls.Add(this.txtLengthMetric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLengthDecimal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.checkActives);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvScrewLengths);
            this.Controls.Add(this.txtLengthInch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDScrewLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pNavBar);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmScrewLength";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screw Length";
            this.Load += new System.EventHandler(this.FrmScrewLength_Load);
            this.pNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScrewLengths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pNavBar;
        private System.Windows.Forms.Button btnClose;
        private FontAwesome.Sharp.IconButton btnDisable;
        private System.Windows.Forms.CheckBox checkActives;
        private System.Windows.Forms.TextBox txtFilter;
        private FontAwesome.Sharp.IconButton btnClean;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.DataGridView dgvScrewLengths;
        private System.Windows.Forms.TextBox txtLengthInch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDScrewLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLengthDecimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLengthMetric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDScrewLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLengthInch;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLengthDecimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLengthMetric;
    }
}