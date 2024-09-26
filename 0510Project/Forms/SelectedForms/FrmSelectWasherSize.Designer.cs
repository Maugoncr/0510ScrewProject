namespace _0510Project.Forms.SelectedForms
{
    partial class FrmSelectWasherSize
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pNavBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWasherSizes = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.txtSizeName = new System.Windows.Forms.TextBox();
            this.txtIDWasherSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnSelect = new FontAwesome.Sharp.IconButton();
            this.CIDWasherSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWasherSizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWasherSizes)).BeginInit();
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
            this.pNavBar.Size = new System.Drawing.Size(933, 48);
            this.pNavBar.TabIndex = 2;
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
            this.btnClose.Location = new System.Drawing.Point(870, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 469);
            this.panel3.TabIndex = 190;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 2);
            this.panel2.TabIndex = 192;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(931, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 467);
            this.panel1.TabIndex = 193;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 29);
            this.label2.TabIndex = 202;
            this.label2.Text = "Size Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 201;
            this.label1.Text = "ID Washer Size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvWasherSizes
            // 
            this.dgvWasherSizes.AllowUserToAddRows = false;
            this.dgvWasherSizes.AllowUserToDeleteRows = false;
            this.dgvWasherSizes.AllowUserToResizeColumns = false;
            this.dgvWasherSizes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWasherSizes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWasherSizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWasherSizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDWasherSize,
            this.CWasherSizeName});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWasherSizes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWasherSizes.Location = new System.Drawing.Point(24, 161);
            this.dgvWasherSizes.MultiSelect = false;
            this.dgvWasherSizes.Name = "dgvWasherSizes";
            this.dgvWasherSizes.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWasherSizes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWasherSizes.RowHeadersVisible = false;
            this.dgvWasherSizes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWasherSizes.Size = new System.Drawing.Size(881, 244);
            this.dgvWasherSizes.TabIndex = 199;
            this.dgvWasherSizes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWasherSizes_CellClick);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(24, 120);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(881, 27);
            this.txtFilter.TabIndex = 200;
            this.txtFilter.Text = "Search...";
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFilter_MouseClick);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // txtSizeName
            // 
            this.txtSizeName.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSizeName.Location = new System.Drawing.Point(261, 463);
            this.txtSizeName.Name = "txtSizeName";
            this.txtSizeName.ReadOnly = true;
            this.txtSizeName.Size = new System.Drawing.Size(385, 33);
            this.txtSizeName.TabIndex = 198;
            this.txtSizeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDWasherSize
            // 
            this.txtIDWasherSize.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDWasherSize.Location = new System.Drawing.Point(24, 463);
            this.txtIDWasherSize.Name = "txtIDWasherSize";
            this.txtIDWasherSize.ReadOnly = true;
            this.txtIDWasherSize.Size = new System.Drawing.Size(201, 33);
            this.txtIDWasherSize.TabIndex = 197;
            this.txtIDWasherSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(23, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(882, 36);
            this.label3.TabIndex = 196;
            this.label3.Text = "Select the Washer Size";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(729, 467);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(176, 29);
            this.btnCancelar.TabIndex = 195;
            this.btnCancelar.Text = "  Cancel";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnSelect.IconColor = System.Drawing.Color.White;
            this.btnSelect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelect.IconSize = 25;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(729, 429);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(176, 29);
            this.btnSelect.TabIndex = 194;
            this.btnSelect.Text = "       Select Washer Size";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // CIDWasherSize
            // 
            this.CIDWasherSize.DataPropertyName = "IDWasherSize";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CIDWasherSize.DefaultCellStyle = dataGridViewCellStyle2;
            this.CIDWasherSize.HeaderText = "ID Washer Size";
            this.CIDWasherSize.Name = "CIDWasherSize";
            this.CIDWasherSize.ReadOnly = true;
            this.CIDWasherSize.Width = 200;
            // 
            // CWasherSizeName
            // 
            this.CWasherSizeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CWasherSizeName.DataPropertyName = "WasherSizeName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CWasherSizeName.DefaultCellStyle = dataGridViewCellStyle3;
            this.CWasherSizeName.HeaderText = "Size Name";
            this.CWasherSizeName.Name = "CWasherSizeName";
            this.CWasherSizeName.ReadOnly = true;
            this.CWasherSizeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmSelectWasherSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWasherSizes);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.txtSizeName);
            this.Controls.Add(this.txtIDWasherSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pNavBar);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmSelectWasherSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Washer Size";
            this.Load += new System.EventHandler(this.FrmSelectWasherSize_Load);
            this.pNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWasherSizes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pNavBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWasherSizes;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TextBox txtSizeName;
        private System.Windows.Forms.TextBox txtIDWasherSize;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDWasherSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWasherSizeName;
    }
}