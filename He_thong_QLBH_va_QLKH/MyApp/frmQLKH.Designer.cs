namespace MyApp
{
    partial class frmQLKH
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            labelTenKH = new Label();
            labelmaKH = new Label();
            labelSDT = new Label();
            txtSoDienThoai = new TextBox();
            labelDiaChi = new Label();
            txtDiaChi = new TextBox();
            buttonLuu = new Button();
            buttonSua = new Button();
            dataGridView1 = new DataGridView();
            btnXoa = new Button();
            lbQLKH = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(203, 76);
            txtMaKH.Margin = new Padding(3, 4, 3, 4);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(237, 27);
            txtMaKH.TabIndex = 0;
            txtMaKH.TextChanged += textBox1_TextChanged;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(203, 135);
            txtTenKH.Margin = new Padding(3, 4, 3, 4);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(237, 27);
            txtTenKH.TabIndex = 2;
            // 
            // labelTenKH
            // 
            labelTenKH.AutoSize = true;
            labelTenKH.Location = new Point(45, 145);
            labelTenKH.Name = "labelTenKH";
            labelTenKH.Size = new Size(111, 20);
            labelTenKH.TabIndex = 2;
            labelTenKH.Text = "Tên khách hàng";
            labelTenKH.Click += label2_Click;
            // 
            // labelmaKH
            // 
            labelmaKH.AutoSize = true;
            labelmaKH.ForeColor = Color.Red;
            labelmaKH.Location = new Point(43, 80);
            labelmaKH.Name = "labelmaKH";
            labelmaKH.Size = new Size(109, 20);
            labelmaKH.TabIndex = 1;
            labelmaKH.Text = "Mã khách hàng";
            labelmaKH.Click += label1_Click;
            // 
            // labelSDT
            // 
            labelSDT.AutoSize = true;
            labelSDT.Location = new Point(486, 80);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(97, 20);
            labelSDT.TabIndex = 5;
            labelSDT.Text = "Số điện thoại";
            labelSDT.Click += label3_Click;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(646, 80);
            txtSoDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(237, 27);
            txtSoDienThoai.TabIndex = 3;
            txtSoDienThoai.TextChanged += textBoxSDT_TextChanged;
            // 
            // labelDiaChi
            // 
            labelDiaChi.AutoSize = true;
            labelDiaChi.Location = new Point(486, 145);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(55, 20);
            labelDiaChi.TabIndex = 7;
            labelDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(646, 141);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(237, 27);
            txtDiaChi.TabIndex = 4;
            // 
            // buttonLuu
            // 
            buttonLuu.Location = new Point(232, 201);
            buttonLuu.Margin = new Padding(3, 4, 3, 4);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(86, 31);
            buttonLuu.TabIndex = 5;
            buttonLuu.Text = "Lưu";
            buttonLuu.UseVisualStyleBackColor = true;
            buttonLuu.Click += button1_Click_1;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(364, 201);
            buttonSua.Margin = new Padding(3, 4, 3, 4);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(86, 31);
            buttonSua.TabIndex = 7;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += btn_ClickSua;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 312);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(562, 259);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(496, 201);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lbQLKH
            // 
            lbQLKH.AutoSize = true;
            lbQLKH.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLKH.Location = new Point(264, 9);
            lbQLKH.Name = "lbQLKH";
            lbQLKH.Size = new Size(358, 41);
            lbQLKH.TabIndex = 13;
            lbQLKH.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // frmQLKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(917, 593);
            Controls.Add(lbQLKH);
            Controls.Add(btnXoa);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSua);
            Controls.Add(buttonLuu);
            Controls.Add(txtDiaChi);
            Controls.Add(labelDiaChi);
            Controls.Add(txtSoDienThoai);
            Controls.Add(labelSDT);
            Controls.Add(txtTenKH);
            Controls.Add(txtMaKH);
            Controls.Add(labelTenKH);
            Controls.Add(labelmaKH);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmQLKH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin khách hàng";
            FormClosing += frmQLKH_FormClosing;
            Load += frmQLKH_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMaKH;
        private TextBox txtTenKH;
        private Label labelTenKH;
        private Label labelmaKH;
        private Label labelSDT;
        private TextBox txtSDT;
        private Label labelDiaChi;
        private TextBox txtDiaChi;
        private Button buttonLuu;
        private Button buttonSua;
        private DataGridView dataGridView1;
        private Button btnXoa;
        private TextBox txtSoDienThoai;
        private Label lbQLKH;
    }
}