﻿namespace _0510Project.Forms
{
    partial class FrmNutsType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNutsType));
            this.pNavBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvNutsTypes = new System.Windows.Forms.DataGridView();
            this.CIDNutsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNutsTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDisable = new FontAwesome.Sharp.IconButton();
            this.checkActives = new System.Windows.Forms.CheckBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnClean = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDNutsType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNutsTypes)).BeginInit();
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
            this.pNavBar.Size = new System.Drawing.Size(1100, 48);
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
            this.btnClose.Location = new System.Drawing.Point(1046, 0);
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
            this.label7.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(29, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1030, 49);
            this.label7.TabIndex = 134;
            this.label7.Text = "Nuts Type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNutsTypes
            // 
            this.dgvNutsTypes.AllowUserToAddRows = false;
            this.dgvNutsTypes.AllowUserToDeleteRows = false;
            this.dgvNutsTypes.AllowUserToResizeColumns = false;
            this.dgvNutsTypes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNutsTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNutsTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNutsTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDNutsType,
            this.CNutsTypeName});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNutsTypes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNutsTypes.Location = new System.Drawing.Point(37, 167);
            this.dgvNutsTypes.MultiSelect = false;
            this.dgvNutsTypes.Name = "dgvNutsTypes";
            this.dgvNutsTypes.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNutsTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNutsTypes.RowHeadersVisible = false;
            this.dgvNutsTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNutsTypes.Size = new System.Drawing.Size(1030, 244);
            this.dgvNutsTypes.TabIndex = 149;
            this.dgvNutsTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNutsTypes_CellClick);
            // 
            // CIDNutsType
            // 
            this.CIDNutsType.DataPropertyName = "IDNutsType";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CIDNutsType.DefaultCellStyle = dataGridViewCellStyle2;
            this.CIDNutsType.HeaderText = "ID Nuts Size";
            this.CIDNutsType.Name = "CIDNutsType";
            this.CIDNutsType.ReadOnly = true;
            this.CIDNutsType.Width = 200;
            // 
            // CNutsTypeName
            // 
            this.CNutsTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNutsTypeName.DataPropertyName = "NutsTypeName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CNutsTypeName.DefaultCellStyle = dataGridViewCellStyle3;
            this.CNutsTypeName.HeaderText = "Type Name";
            this.CNutsTypeName.Name = "CNutsTypeName";
            this.CNutsTypeName.ReadOnly = true;
            this.CNutsTypeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.btnDisable.Location = new System.Drawing.Point(946, 478);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(121, 33);
            this.btnDisable.TabIndex = 155;
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
            this.checkActives.Location = new System.Drawing.Point(962, 417);
            this.checkActives.Name = "checkActives";
            this.checkActives.Size = new System.Drawing.Size(105, 23);
            this.checkActives.TabIndex = 154;
            this.checkActives.Text = "See Actives";
            this.checkActives.UseVisualStyleBackColor = true;
            this.checkActives.CheckedChanged += new System.EventHandler(this.checkActives_CheckedChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(37, 128);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(1030, 27);
            this.txtFilter.TabIndex = 153;
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
            this.btnClean.Location = new System.Drawing.Point(953, 559);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(114, 33);
            this.btnClean.TabIndex = 152;
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
            this.btnUpdate.Location = new System.Drawing.Point(823, 478);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 33);
            this.btnUpdate.TabIndex = 151;
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
            this.btnSave.Location = new System.Drawing.Point(710, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 33);
            this.btnSave.TabIndex = 150;
            this.btnSave.Text = "     Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTypeName
            // 
            this.txtTypeName.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(274, 478);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(385, 33);
            this.txtTypeName.TabIndex = 148;
            this.txtTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 29);
            this.label2.TabIndex = 147;
            this.label2.Text = "Type Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDNutsType
            // 
            this.txtIDNutsType.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNutsType.Location = new System.Drawing.Point(37, 478);
            this.txtIDNutsType.Name = "txtIDNutsType";
            this.txtIDNutsType.ReadOnly = true;
            this.txtIDNutsType.Size = new System.Drawing.Size(201, 33);
            this.txtIDNutsType.TabIndex = 146;
            this.txtIDNutsType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 145;
            this.label1.Text = "ID Nuts Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmNutsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.dgvNutsTypes);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.checkActives);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDNutsType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pNavBar);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmNutsType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuts Type";
            this.Load += new System.EventHandler(this.FrmNutsType_Load);
            this.pNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNutsTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pNavBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvNutsTypes;
        private FontAwesome.Sharp.IconButton btnDisable;
        private System.Windows.Forms.CheckBox checkActives;
        private System.Windows.Forms.TextBox txtFilter;
        private FontAwesome.Sharp.IconButton btnClean;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDNutsType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDNutsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNutsTypeName;
    }
}