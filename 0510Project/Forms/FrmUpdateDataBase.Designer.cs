namespace _0510Project.Forms
{
    partial class FrmUpdateDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateDataBase));
            this.pNavBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbWhoAreYou = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDownloadDataBase = new FontAwesome.Sharp.IconButton();
            this.btnCheckUpdate = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.pNavBar.SuspendLayout();
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
            this.pNavBar.Size = new System.Drawing.Size(933, 47);
            this.pNavBar.TabIndex = 7;
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
            this.btnClose.Location = new System.Drawing.Point(876, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 47);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbWhoAreYou
            // 
            this.lbWhoAreYou.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhoAreYou.ForeColor = System.Drawing.Color.Black;
            this.lbWhoAreYou.Location = new System.Drawing.Point(12, 50);
            this.lbWhoAreYou.Name = "lbWhoAreYou";
            this.lbWhoAreYou.Size = new System.Drawing.Size(909, 108);
            this.lbWhoAreYou.TabIndex = 149;
            this.lbWhoAreYou.Text = "Test";
            this.lbWhoAreYou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(909, 33);
            this.label2.TabIndex = 173;
            this.label2.Text = "Follow these instructions exactly as indicated for a successful process.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(904, 25);
            this.label1.TabIndex = 174;
            this.label1.Text = "This function allows the user to update their database.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(149, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(617, 39);
            this.label3.TabIndex = 175;
            this.label3.Text = "To do so, click the \"Download Database\" button, which will open a Google Drive in" +
    " your browser where you will find a file named \"0510Project.db.\"";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(160, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(617, 56);
            this.label4.TabIndex = 176;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(149, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(617, 40);
            this.label5.TabIndex = 177;
            this.label5.Text = "Once finished, simply restart the software and do not return to this window unles" +
    "s instructed by the administrators.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(160, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(617, 41);
            this.label6.TabIndex = 178;
            this.label6.Text = "Remember, if you cannot find the \"0510Project.db\" file in Google Drive, you shoul" +
    "d contact the administrators for technical assistance.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnDownloadDataBase.Location = new System.Drawing.Point(348, 395);
            this.btnDownloadDataBase.Name = "btnDownloadDataBase";
            this.btnDownloadDataBase.Size = new System.Drawing.Size(225, 37);
            this.btnDownloadDataBase.TabIndex = 179;
            this.btnDownloadDataBase.Text = "1. Download DataBase";
            this.btnDownloadDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadDataBase.UseVisualStyleBackColor = false;
            this.btnDownloadDataBase.Click += new System.EventHandler(this.btnDownloadDataBase_Click);
            // 
            // btnCheckUpdate
            // 
            this.btnCheckUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnCheckUpdate.FlatAppearance.BorderSize = 0;
            this.btnCheckUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckUpdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckUpdate.ForeColor = System.Drawing.Color.White;
            this.btnCheckUpdate.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnCheckUpdate.IconColor = System.Drawing.Color.White;
            this.btnCheckUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckUpdate.IconSize = 25;
            this.btnCheckUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckUpdate.Location = new System.Drawing.Point(364, 450);
            this.btnCheckUpdate.Name = "btnCheckUpdate";
            this.btnCheckUpdate.Size = new System.Drawing.Size(191, 37);
            this.btnCheckUpdate.TabIndex = 180;
            this.btnCheckUpdate.Text = "2. Check DataBase";
            this.btnCheckUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckUpdate.UseVisualStyleBackColor = false;
            this.btnCheckUpdate.Click += new System.EventHandler(this.btnCheckUpdate_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(704, 539);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(191, 37);
            this.iconButton2.TabIndex = 181;
            this.iconButton2.Text = "2. Check DataBase";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // FrmUpdateDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 612);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btnCheckUpdate);
            this.Controls.Add(this.btnDownloadDataBase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbWhoAreYou);
            this.Controls.Add(this.pNavBar);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmUpdateDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdateDataBase";
            this.Load += new System.EventHandler(this.FrmUpdateDataBase_Load);
            this.pNavBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNavBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbWhoAreYou;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnDownloadDataBase;
        private FontAwesome.Sharp.IconButton btnCheckUpdate;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}