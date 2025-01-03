namespace MyApp
{
    partial class frmSanPham
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
            labelMaSP = new Label();
            labelTenSP = new Label();
            labelSoLuong = new Label();
            txtMaGia = new TextBox();
            txtTenSP = new TextBox();
            txtSoluong = new TextBox();
            txtMaSP = new TextBox();
            labelNgayKT = new Label();
            labelNgayApDung = new Label();
            labeliMaGia = new Label();
            datetimeNgayApDung = new DateTimePicker();
            datetimeNgayKetThuc = new DateTimePicker();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            buttonLuu = new Button();
            buttonSua = new Button();
            btnXoa = new Button();
            labelGiaBan = new Label();
            txtGiaBan = new TextBox();
            picAnh = new PictureBox();
            btnTaiAnh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            SuspendLayout();
            // 
            // labelMaSP
            // 
            labelMaSP.AutoSize = true;
            labelMaSP.ForeColor = Color.Red;
            labelMaSP.Location = new Point(54, 54);
            labelMaSP.Name = "labelMaSP";
            labelMaSP.Size = new Size(98, 20);
            labelMaSP.TabIndex = 0;
            labelMaSP.Text = "Mã sản phẩm";
            // 
            // labelTenSP
            // 
            labelTenSP.AutoSize = true;
            labelTenSP.Location = new Point(54, 122);
            labelTenSP.Name = "labelTenSP";
            labelTenSP.Size = new Size(100, 20);
            labelTenSP.TabIndex = 1;
            labelTenSP.Text = "Tên sản phẩm";
            labelTenSP.Click += labelTenSP_Click;
            // 
            // labelSoLuong
            // 
            labelSoLuong.AutoSize = true;
            labelSoLuong.Location = new Point(54, 195);
            labelSoLuong.Name = "labelSoLuong";
            labelSoLuong.Size = new Size(69, 20);
            labelSoLuong.TabIndex = 2;
            labelSoLuong.Text = "Số lượng";
            // 
            // txtMaGia
            // 
            txtMaGia.Location = new Point(611, 52);
            txtMaGia.Name = "txtMaGia";
            txtMaGia.Size = new Size(222, 27);
            txtMaGia.TabIndex = 3;
            txtMaGia.TextChanged += txtMaSP_TextChanged;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(190, 119);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(222, 27);
            txtTenSP.TabIndex = 4;
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(190, 192);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(222, 27);
            txtSoluong.TabIndex = 5;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(190, 51);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(222, 27);
            txtMaSP.TabIndex = 9;
            txtMaSP.Click += txtMaSP_Click;
            // 
            // labelNgayKT
            // 
            labelNgayKT.AutoSize = true;
            labelNgayKT.Location = new Point(475, 199);
            labelNgayKT.Name = "labelNgayKT";
            labelNgayKT.Size = new Size(100, 20);
            labelNgayKT.TabIndex = 8;
            labelNgayKT.Text = "Ngày kết thúc";
            labelNgayKT.Click += labelNgayKT_Click;
            // 
            // labelNgayApDung
            // 
            labelNgayApDung.AutoSize = true;
            labelNgayApDung.Location = new Point(475, 151);
            labelNgayApDung.Name = "labelNgayApDung";
            labelNgayApDung.Size = new Size(103, 20);
            labelNgayApDung.TabIndex = 7;
            labelNgayApDung.Text = "Ngày áp dụng";
            // 
            // labeliMaGia
            // 
            labeliMaGia.AutoSize = true;
            labeliMaGia.ForeColor = Color.Red;
            labeliMaGia.Location = new Point(475, 55);
            labeliMaGia.Name = "labeliMaGia";
            labeliMaGia.Size = new Size(55, 20);
            labeliMaGia.TabIndex = 6;
            labeliMaGia.Text = "Mã giá";
            // 
            // datetimeNgayApDung
            // 
            datetimeNgayApDung.Location = new Point(611, 148);
            datetimeNgayApDung.Name = "datetimeNgayApDung";
            datetimeNgayApDung.Size = new Size(222, 27);
            datetimeNgayApDung.TabIndex = 10;
            // 
            // datetimeNgayKetThuc
            // 
            datetimeNgayKetThuc.Location = new Point(611, 196);
            datetimeNgayKetThuc.Name = "datetimeNgayKetThuc";
            datetimeNgayKetThuc.Size = new Size(222, 27);
            datetimeNgayKetThuc.TabIndex = 11;
            datetimeNgayKetThuc.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(395, 317);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(475, 307);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(664, 317);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // buttonLuu
            // 
            buttonLuu.Location = new Point(54, 251);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(94, 29);
            buttonLuu.TabIndex = 14;
            buttonLuu.Text = "Lưu";
            buttonLuu.UseVisualStyleBackColor = true;
            buttonLuu.Click += buttonLuu_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(196, 251);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 29);
            buttonSua.TabIndex = 15;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(338, 251);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += buttonXoa_Click;
            // 
            // labelGiaBan
            // 
            labelGiaBan.AutoSize = true;
            labelGiaBan.ForeColor = SystemColors.ControlText;
            labelGiaBan.Location = new Point(475, 103);
            labelGiaBan.Name = "labelGiaBan";
            labelGiaBan.Size = new Size(60, 20);
            labelGiaBan.TabIndex = 18;
            labelGiaBan.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(611, 100);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(222, 27);
            txtGiaBan.TabIndex = 17;
            // 
            // picAnh
            // 
            picAnh.BackColor = SystemColors.ButtonFace;
            picAnh.Location = new Point(916, 29);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(213, 194);
            picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnh.TabIndex = 19;
            picAnh.TabStop = false;
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Location = new Point(977, 251);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(94, 29);
            btnTaiAnh.TabIndex = 20;
            btnTaiAnh.Text = "Tải lên";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += buttonTaiAnh_Click;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1195, 668);
            Controls.Add(btnTaiAnh);
            Controls.Add(picAnh);
            Controls.Add(labelGiaBan);
            Controls.Add(txtGiaBan);
            Controls.Add(btnXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonLuu);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(datetimeNgayKetThuc);
            Controls.Add(datetimeNgayApDung);
            Controls.Add(txtMaSP);
            Controls.Add(labelNgayKT);
            Controls.Add(labelNgayApDung);
            Controls.Add(labeliMaGia);
            Controls.Add(txtSoluong);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaGia);
            Controls.Add(labelSoLuong);
            Controls.Add(labelTenSP);
            Controls.Add(labelMaSP);
            Name = "frmSanPham";
            Text = "Sản phẩm";
            FormClosing += frmSanPham_FormClosing;
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMaSP;
        private Label labelTenSP;
        private Label labelSoLuong;
        private TextBox txtMaGia;
        private TextBox txtTenSP;
        private TextBox txtSoluong;
        private TextBox txtMaSP;
        private Label labelNgayKT;
        private Label labelNgayApDung;
        private Label labeliMaGia;
        private DateTimePicker datetimeNgayApDung;
        private DateTimePicker datetimeNgayKetThuc;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button buttonLuu;
        private Button buttonSua;
        private Button btnXoa;
        private Label labelGiaBan;
        private TextBox txtGiaBan;
        private PictureBox picAnh;
        private Button btnTaiAnh;
        private Button btnThemGia;
    }
}