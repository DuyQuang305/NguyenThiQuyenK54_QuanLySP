namespace QuanLySanPhamTheThao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimGia = new System.Windows.Forms.TextBox();
            this.btnTimGia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.btnTimTen = new System.Windows.Forms.Button();
            this.txtGiaSp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSlSp = new System.Windows.Forms.TextBox();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.txtMaSp = new System.Windows.Forms.TextBox();
            this.btnGiamAZ = new System.Windows.Forms.Button();
            this.btnGiaMin = new System.Windows.Forms.Button();
            this.btnGiaMax = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChen = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTangAZ = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTimGia);
            this.groupBox1.Controls.Add(this.btnTimGia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTimTen);
            this.groupBox1.Controls.Add(this.btnTimTen);
            this.groupBox1.Controls.Add(this.txtGiaSp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSlSp);
            this.groupBox1.Controls.Add(this.txtTenSp);
            this.groupBox1.Controls.Add(this.txtMaSp);
            this.groupBox1.Controls.Add(this.btnGiamAZ);
            this.groupBox1.Controls.Add(this.btnGiaMin);
            this.groupBox1.Controls.Add(this.btnGiaMax);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnChen);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTangAZ);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 575);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(456, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 33);
            this.button3.TabIndex = 24;
            this.button3.Text = "Hủy tìm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnHuyTim_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 43);
            this.button2.TabIndex = 23;
            this.button2.Text = "GiaGiam";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGiaGiam_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "GiaTang";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGiaTang_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Đơn giá";
            // 
            // txtTimGia
            // 
            this.txtTimGia.Location = new System.Drawing.Point(135, 501);
            this.txtTimGia.Name = "txtTimGia";
            this.txtTimGia.Size = new System.Drawing.Size(200, 30);
            this.txtTimGia.TabIndex = 20;
            // 
            // btnTimGia
            // 
            this.btnTimGia.Location = new System.Drawing.Point(341, 500);
            this.btnTimGia.Name = "btnTimGia";
            this.btnTimGia.Size = new System.Drawing.Size(98, 33);
            this.btnTimGia.TabIndex = 19;
            this.btnTimGia.Text = "Tìm";
            this.btnTimGia.UseVisualStyleBackColor = true;
            this.btnTimGia.Click += new System.EventHandler(this.btnTimGia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "TênSp";
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(135, 448);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(200, 30);
            this.txtTimTen.TabIndex = 17;
            // 
            // btnTimTen
            // 
            this.btnTimTen.Location = new System.Drawing.Point(341, 448);
            this.btnTimTen.Name = "btnTimTen";
            this.btnTimTen.Size = new System.Drawing.Size(98, 32);
            this.btnTimTen.TabIndex = 16;
            this.btnTimTen.Text = "Tìm";
            this.btnTimTen.UseVisualStyleBackColor = true;
            this.btnTimTen.Click += new System.EventHandler(this.btnTimTen_Click);
            // 
            // txtGiaSp
            // 
            this.txtGiaSp.Location = new System.Drawing.Point(167, 207);
            this.txtGiaSp.Name = "txtGiaSp";
            this.txtGiaSp.Size = new System.Drawing.Size(327, 30);
            this.txtGiaSp.TabIndex = 15;
            this.txtGiaSp.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Đơn giá";
            // 
            // txtSlSp
            // 
            this.txtSlSp.Location = new System.Drawing.Point(167, 148);
            this.txtSlSp.Name = "txtSlSp";
            this.txtSlSp.Size = new System.Drawing.Size(327, 30);
            this.txtSlSp.TabIndex = 13;
            this.txtSlSp.Tag = "";
            // 
            // txtTenSp
            // 
            this.txtTenSp.Location = new System.Drawing.Point(167, 98);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(327, 30);
            this.txtTenSp.TabIndex = 3;
            this.txtTenSp.Tag = "";
            // 
            // txtMaSp
            // 
            this.txtMaSp.Location = new System.Drawing.Point(167, 46);
            this.txtMaSp.Name = "txtMaSp";
            this.txtMaSp.Size = new System.Drawing.Size(327, 30);
            this.txtMaSp.TabIndex = 12;
            this.txtMaSp.Tag = "";
            // 
            // btnGiamAZ
            // 
            this.btnGiamAZ.Location = new System.Drawing.Point(381, 384);
            this.btnGiamAZ.Name = "btnGiamAZ";
            this.btnGiamAZ.Size = new System.Drawing.Size(177, 43);
            this.btnGiamAZ.TabIndex = 10;
            this.btnGiamAZ.Tag = "";
            this.btnGiamAZ.Text = "GiamAZ";
            this.btnGiamAZ.UseVisualStyleBackColor = true;
            this.btnGiamAZ.Click += new System.EventHandler(this.btnGiamAZ_Click);
            // 
            // btnGiaMin
            // 
            this.btnGiaMin.Location = new System.Drawing.Point(205, 384);
            this.btnGiaMin.Name = "btnGiaMin";
            this.btnGiaMin.Size = new System.Drawing.Size(172, 43);
            this.btnGiaMin.TabIndex = 8;
            this.btnGiaMin.Tag = "";
            this.btnGiaMin.Text = "Giá bé nhất";
            this.btnGiaMin.UseVisualStyleBackColor = true;
            this.btnGiaMin.Click += new System.EventHandler(this.btnGiaMin_Click);
            // 
            // btnGiaMax
            // 
            this.btnGiaMax.Location = new System.Drawing.Point(29, 384);
            this.btnGiaMax.Name = "btnGiaMax";
            this.btnGiaMax.Size = new System.Drawing.Size(165, 43);
            this.btnGiaMax.TabIndex = 7;
            this.btnGiaMax.Tag = "";
            this.btnGiaMax.Text = "Giá lớn nhất";
            this.btnGiaMax.UseVisualStyleBackColor = true;
            this.btnGiaMax.Click += new System.EventHandler(this.btnGiaMax_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(421, 272);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 44);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Tag = "";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(285, 272);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 44);
            this.btnSua.TabIndex = 5;
            this.btnSua.Tag = "";
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnChen
            // 
            this.btnChen.Location = new System.Drawing.Point(157, 272);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(122, 44);
            this.btnChen.TabIndex = 4;
            this.btnChen.Tag = "";
            this.btnChen.Text = "Chèn";
            this.btnChen.UseVisualStyleBackColor = true;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(28, 272);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(122, 44);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Tag = "";
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // btnTangAZ
            // 
            this.btnTangAZ.Location = new System.Drawing.Point(381, 327);
            this.btnTangAZ.Name = "btnTangAZ";
            this.btnTangAZ.Size = new System.Drawing.Size(175, 43);
            this.btnTangAZ.TabIndex = 9;
            this.btnTangAZ.Tag = "";
            this.btnTangAZ.Text = "TangAZ";
            this.btnTangAZ.UseVisualStyleBackColor = true;
            this.btnTangAZ.Click += new System.EventHandler(this.btnTangAZ_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvSanPham);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(561, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 575);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm";
            // 
            // lsvSanPham
            // 
            this.lsvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvSanPham.FullRowSelect = true;
            this.lsvSanPham.GridLines = true;
            this.lsvSanPham.HideSelection = false;
            this.lsvSanPham.Location = new System.Drawing.Point(3, 26);
            this.lsvSanPham.Name = "lsvSanPham";
            this.lsvSanPham.Size = new System.Drawing.Size(577, 546);
            this.lsvSanPham.TabIndex = 0;
            this.lsvSanPham.UseCompatibleStateImageBehavior = false;
            this.lsvSanPham.View = System.Windows.Forms.View.Details;
            this.lsvSanPham.SelectedIndexChanged += new System.EventHandler(this.lsvSanPham_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "STT";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sp";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 176;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 216;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGiamAZ;
        private System.Windows.Forms.Button btnTangAZ;
        private System.Windows.Forms.Button btnGiaMin;
        private System.Windows.Forms.Button btnGiaMax;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSlSp;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.TextBox txtMaSp;
        private System.Windows.Forms.ListView lsvSanPham;
        private System.Windows.Forms.TextBox txtGiaSp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnTimTen;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimGia;
        private System.Windows.Forms.Button btnTimGia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

