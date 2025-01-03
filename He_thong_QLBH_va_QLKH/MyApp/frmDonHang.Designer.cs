namespace MyApp
{
    partial class frmDonHang
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
            labelTongTien = new Label();
            labelNgayMua = new Label();
            maKh = new Label();
            labeldh = new Label();
            label1 = new Label();
            label2 = new Label();
            txtMaDH = new TextBox();
            txtLoaiDH = new TextBox();
            txtTongTien = new TextBox();
            datetimeNgayMua = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dataGridView2 = new DataGridView();
            cboTenSP = new ComboBox();
            labelTenSP = new Label();
            label3 = new Label();
            txtMaSP = new TextBox();
            numSoLuong = new NumericUpDown();
            labelMaGia = new Label();
            cboMaGia = new ComboBox();
            labelGiaBan = new Label();
            txtGiaBan = new TextBox();
            menuStrip1 = new MenuStrip();
            shipToolStripMenuItem = new ToolStripMenuItem();
            đơnVịVậnChuyểnToolStripMenuItem = new ToolStripMenuItem();
            btnThemMoi = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtMaKH = new ComboBox();
            txtMaNV = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTongTien
            // 
            labelTongTien.AutoSize = true;
            labelTongTien.Location = new Point(463, 145);
            labelTongTien.Name = "labelTongTien";
            labelTongTien.Size = new Size(72, 20);
            labelTongTien.TabIndex = 3;
            labelTongTien.Text = "Tổng tiền";
            // 
            // labelNgayMua
            // 
            labelNgayMua.AutoSize = true;
            labelNgayMua.Location = new Point(463, 50);
            labelNgayMua.Name = "labelNgayMua";
            labelNgayMua.Size = new Size(77, 20);
            labelNgayMua.TabIndex = 2;
            labelNgayMua.Text = "Ngày mua";
            // 
            // maKh
            // 
            maKh.AutoSize = true;
            maKh.Location = new Point(46, 99);
            maKh.Name = "maKh";
            maKh.Size = new Size(109, 20);
            maKh.TabIndex = 1;
            maKh.Text = "Mã khách hàng";
            maKh.Click += maKh_Click;
            // 
            // labeldh
            // 
            labeldh.AutoSize = true;
            labeldh.Location = new Point(46, 50);
            labeldh.Name = "labeldh";
            labeldh.Size = new Size(97, 20);
            labeldh.TabIndex = 0;
            labeldh.Text = "Mã đơn hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(463, 99);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 4;
            label1.Text = "Loại đơn hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 145);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã nhân viên";
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(183, 50);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(215, 27);
            txtMaDH.TabIndex = 0;
            // 
            // txtLoaiDH
            // 
            txtLoaiDH.Location = new Point(616, 96);
            txtLoaiDH.Name = "txtLoaiDH";
            txtLoaiDH.Size = new Size(215, 27);
            txtLoaiDH.TabIndex = 4;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(616, 142);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(215, 27);
            txtTongTien.TabIndex = 5;
            // 
            // datetimeNgayMua
            // 
            datetimeNgayMua.Location = new Point(616, 47);
            datetimeNgayMua.Name = "datetimeNgayMua";
            datetimeNgayMua.Size = new Size(215, 27);
            datetimeNgayMua.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(575, 420);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(46, 197);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Tạo đơn";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnTaoDon_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(237, 197);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(428, 197);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(655, 377);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(474, 298);
            dataGridView2.TabIndex = 14;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // cboTenSP
            // 
            cboTenSP.FormattingEnabled = true;
            cboTenSP.Location = new Point(816, 265);
            cboTenSP.Name = "cboTenSP";
            cboTenSP.Size = new Size(215, 28);
            cboTenSP.TabIndex = 10;
            cboTenSP.SelectedIndexChanged += cboTenSP_SelectedIndexChanged;
            // 
            // labelTenSP
            // 
            labelTenSP.AutoSize = true;
            labelTenSP.Location = new Point(664, 271);
            labelTenSP.Name = "labelTenSP";
            labelTenSP.Size = new Size(100, 20);
            labelTenSP.TabIndex = 16;
            labelTenSP.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(664, 234);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 17;
            label3.Text = "Mã sản phẩm";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(816, 227);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(215, 27);
            txtMaSP.TabIndex = 9;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(1048, 265);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(44, 27);
            numSoLuong.TabIndex = 19;
            // 
            // labelMaGia
            // 
            labelMaGia.AutoSize = true;
            labelMaGia.Location = new Point(665, 308);
            labelMaGia.Name = "labelMaGia";
            labelMaGia.Size = new Size(56, 20);
            labelMaGia.TabIndex = 20;
            labelMaGia.Text = "Mã Giá";
            // 
            // cboMaGia
            // 
            cboMaGia.FormattingEnabled = true;
            cboMaGia.Location = new Point(816, 301);
            cboMaGia.Name = "cboMaGia";
            cboMaGia.Size = new Size(215, 28);
            cboMaGia.TabIndex = 11;
            // 
            // labelGiaBan
            // 
            labelGiaBan.AutoSize = true;
            labelGiaBan.Location = new Point(665, 345);
            labelGiaBan.Name = "labelGiaBan";
            labelGiaBan.Size = new Size(60, 20);
            labelGiaBan.TabIndex = 22;
            labelGiaBan.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(816, 342);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(215, 27);
            txtGiaBan.TabIndex = 12;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { shipToolStripMenuItem, đơnVịVậnChuyểnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1172, 28);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // shipToolStripMenuItem
            // 
            shipToolStripMenuItem.BackColor = SystemColors.ButtonFace;
            shipToolStripMenuItem.Name = "shipToolStripMenuItem";
            shipToolStripMenuItem.Size = new Size(52, 24);
            shipToolStripMenuItem.Text = "Ship";
            shipToolStripMenuItem.Click += shipToolStripMenuItem_Click;
            shipToolStripMenuItem.DoubleClick += shipToolStripMenuItem_DoubleClick;
            // 
            // đơnVịVậnChuyểnToolStripMenuItem
            // 
            đơnVịVậnChuyểnToolStripMenuItem.Name = "đơnVịVậnChuyểnToolStripMenuItem";
            đơnVịVậnChuyểnToolStripMenuItem.Size = new Size(143, 24);
            đơnVịVậnChuyểnToolStripMenuItem.Text = "Đơn vị vận chuyển";
            đơnVịVậnChuyểnToolStripMenuItem.Click += đơnVịVậnChuyểnToolStripMenuItem_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(1048, 314);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(81, 55);
            btnThemMoi.TabIndex = 25;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // txtMaKH
            // 
            txtMaKH.FormattingEnabled = true;
            txtMaKH.Location = new Point(183, 96);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(215, 28);
            txtMaKH.TabIndex = 26;
            txtMaKH.SelectedIndexChanged += txtMaKH_SelectedIndexChanged;
            // 
            // txtMaNV
            // 
            txtMaNV.FormattingEnabled = true;
            txtMaNV.Location = new Point(183, 142);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(215, 28);
            txtMaNV.TabIndex = 27;
            // 
            // frmDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 701);
            Controls.Add(txtMaNV);
            Controls.Add(txtMaKH);
            Controls.Add(btnThemMoi);
            Controls.Add(txtGiaBan);
            Controls.Add(labelGiaBan);
            Controls.Add(cboMaGia);
            Controls.Add(labelMaGia);
            Controls.Add(numSoLuong);
            Controls.Add(txtMaSP);
            Controls.Add(label3);
            Controls.Add(labelTenSP);
            Controls.Add(cboTenSP);
            Controls.Add(dataGridView2);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(dataGridView1);
            Controls.Add(datetimeNgayMua);
            Controls.Add(txtTongTien);
            Controls.Add(txtLoaiDH);
            Controls.Add(txtMaDH);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelTongTien);
            Controls.Add(labelNgayMua);
            Controls.Add(maKh);
            Controls.Add(labeldh);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmDonHang";
            Text = "Đơn hàng";
            Load += frmDonHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTongTien;
        private Label labelNgayMua;
        private Label maKh;
        private Label labeldh;
        private Label label1;
        private Label label2;
        private TextBox txtMaDH;
        private TextBox txtLoaiDH;
        private TextBox txtTongTien;
        private DateTimePicker datetimeNgayMua;
        private DataGridView dataGridView1;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dataGridView2;
        private ComboBox cboTenSP;
        private Label labelTenSP;
        private Label label3;
        private TextBox txtMaSP;
        private NumericUpDown numSoLuong;
        private Label labelMaGia;
        private ComboBox cboMaGia;
        private Label labelGiaBan;
        private TextBox txtGiaBan;
        private MenuStrip menuStrip1;
        private Button btnThemMoi;
        private ToolStripMenuItem shipToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox txtMaKH;
        private ComboBox txtMaNV;
        private ToolStripMenuItem đơnVịVậnChuyểnToolStripMenuItem;
    }
}