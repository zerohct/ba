namespace bai6_01
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSach = new System.Windows.Forms.GroupBox();
            this.gvSach = new System.Windows.Forms.DataGridView();
            this.lbTittle = new System.Windows.Forms.Label();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.gbSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // gbSach
            // 
            this.gbSach.Controls.Add(this.cbTheLoai);
            this.gbSach.Controls.Add(this.txtNam);
            this.gbSach.Controls.Add(this.txtTenSach);
            this.gbSach.Controls.Add(this.txtMaSach);
            this.gbSach.Controls.Add(this.lbMaSach);
            this.gbSach.Controls.Add(this.lbTheLoai);
            this.gbSach.Controls.Add(this.lbTenSach);
            this.gbSach.Controls.Add(this.lbNam);
            this.gbSach.Location = new System.Drawing.Point(39, 137);
            this.gbSach.Name = "gbSach";
            this.gbSach.Size = new System.Drawing.Size(310, 210);
            this.gbSach.TabIndex = 1;
            this.gbSach.TabStop = false;
            this.gbSach.Text = "Thông Tin Sách";
            // 
            // gvSach
            // 
            this.gvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gvSach.Location = new System.Drawing.Point(380, 133);
            this.gvSach.Name = "gvSach";
            this.gvSach.RowHeadersWidth = 51;
            this.gvSach.RowTemplate.Height = 24;
            this.gvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSach.Size = new System.Drawing.Size(409, 308);
            this.gvSach.TabIndex = 2;
            this.gvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSach_CellClick);
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTittle.Location = new System.Drawing.Point(175, 43);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(485, 46);
            this.lbTittle.TabIndex = 3;
            this.lbTittle.Text = "Quản Lý Thông Tin Sách";
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Location = new System.Drawing.Point(21, 40);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(63, 16);
            this.lbMaSach.TabIndex = 4;
            this.lbMaSach.Text = "Mã Sách:";
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Location = new System.Drawing.Point(21, 75);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(65, 16);
            this.lbTenSach.TabIndex = 5;
            this.lbTenSach.Text = "Tên Sách";
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Location = new System.Drawing.Point(21, 112);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(56, 16);
            this.lbNam.TabIndex = 6;
            this.lbNam.Text = "Năm XB";
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.AutoSize = true;
            this.lbTheLoai.Location = new System.Drawing.Point(21, 152);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(56, 16);
            this.lbTheLoai.TabIndex = 7;
            this.lbTheLoai.Text = "Thể loại";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(648, 105);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(141, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(120, 72);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(141, 22);
            this.txtTenSach.TabIndex = 5;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(120, 37);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(141, 22);
            this.txtMaSach.TabIndex = 6;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(120, 112);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(141, 22);
            this.txtNam.TabIndex = 8;
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(120, 152);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(141, 24);
            this.cbTheLoai.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(39, 370);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(159, 370);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(277, 370);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MaSach";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TenSach";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NamXB";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TheLoai";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.gvSach);
            this.Controls.Add(this.gbSach);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbSach.ResumeLayout(false);
            this.gbSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbSach;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.DataGridView gvSach;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

