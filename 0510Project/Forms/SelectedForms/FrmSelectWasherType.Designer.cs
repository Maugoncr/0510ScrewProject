namespace _0510Project.Forms.SelectedForms
{
    partial class FrmSelectWasherType
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDWasherType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWashersTypes = new System.Windows.Forms.DataGridView();
            this.CIDWasherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWasherTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnSelect = new FontAwesome.Sharp.IconButton();
            this.pNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWashersTypes)).BeginInit();
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
            this.pNavBar.Size = new System.Drawing.Size(933, 55);
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
            this.btnClose.Size = new System.Drawing.Size(63, 55);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 462);
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
            this.panel1.Location = new System.Drawing.Point(931, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 460);
            this.panel1.TabIndex = 193;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(26, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(882, 36);
            this.label3.TabIndex = 202;
            this.label3.Text = "Select the Washer Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(27, 119);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(881, 27);
            this.txtFilter.TabIndex = 201;
            this.txtFilter.Text = "Search...";
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFilter_MouseClick);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // txtTypeName
            // 
            this.txtTypeName.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(263, 464);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.ReadOnly = true;
            this.txtTypeName.Size = new System.Drawing.Size(385, 33);
            this.txtTypeName.TabIndex = 200;
            this.txtTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 29);
            this.label2.TabIndex = 199;
            this.label2.Text = "Type Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDWasherType
            // 
            this.txtIDWasherType.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDWasherType.Location = new System.Drawing.Point(26, 464);
            this.txtIDWasherType.Name = "txtIDWasherType";
            this.txtIDWasherType.ReadOnly = true;
            this.txtIDWasherType.Size = new System.Drawing.Size(201, 33);
            this.txtIDWasherType.TabIndex = 198;
            this.txtIDWasherType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 197;
            this.label1.Text = "ID Washer Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvWashersTypes
            // 
            this.dgvWashersTypes.AllowUserToAddRows = false;
            this.dgvWashersTypes.AllowUserToDeleteRows = false;
            this.dgvWashersTypes.AllowUserToResizeColumns = false;
            this.dgvWashersTypes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWashersTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWashersTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWashersTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDWasherType,
            this.CWasherTypeName});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWashersTypes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWashersTypes.Location = new System.Drawing.Point(27, 163);
            this.dgvWashersTypes.MultiSelect = false;
            this.dgvWashersTypes.Name = "dgvWashersTypes";
            this.dgvWashersTypes.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWashersTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWashersTypes.RowHeadersVisible = false;
            this.dgvWashersTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWashersTypes.Size = new System.Drawing.Size(881, 244);
            this.dgvWashersTypes.TabIndex = 196;
            this.dgvWashersTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWashersTypes_CellClick);
            // 
            // CIDWasherType
            // 
            this.CIDWasherType.DataPropertyName = "IDWasherType";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CIDWasherType.DefaultCellStyle = dataGridViewCellStyle2;
            this.CIDWasherType.HeaderText = "ID Washer Type";
            this.CIDWasherType.Name = "CIDWasherType";
            this.CIDWasherType.ReadOnly = true;
            this.CIDWasherType.Width = 200;
            // 
            // CWasherTypeName
            // 
            this.CWasherTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CWasherTypeName.DataPropertyName = "WasherTypeName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CWasherTypeName.DefaultCellStyle = dataGridViewCellStyle3;
            this.CWasherTypeName.HeaderText = "Type Name";
            this.CWasherTypeName.Name = "CWasherTypeName";
            this.CWasherTypeName.ReadOnly = true;
            this.CWasherTypeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.btnCancelar.Location = new System.Drawing.Point(732, 468);
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
            this.btnSelect.Location = new System.Drawing.Point(732, 430);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(176, 29);
            this.btnSelect.TabIndex = 194;
            this.btnSelect.Text = "       Select Washer Type";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FrmSelectWasherType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDWasherType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWashersTypes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pNavBar);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmSelectWasherType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Washer Type";
            this.Load += new System.EventHandler(this.FrmSelectWasherType_Load);
            this.pNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWashersTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pNavBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDWasherType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWashersTypes;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDWasherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWasherTypeName;
    }
}