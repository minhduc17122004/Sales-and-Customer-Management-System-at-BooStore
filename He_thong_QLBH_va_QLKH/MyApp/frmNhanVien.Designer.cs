namespace MyApp
{
    partial class frmNhanVien
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
            buttonLuu = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            dataGridView1 = new DataGridView();
            labelMaNV = new Label();
            labelTenNV = new Label();
            labelSDT = new Label();
            labelViTri = new Label();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            txtSDT = new TextBox();
            txtVitri = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonLuu
            // 
            buttonLuu.Location = new Point(50, 236);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(94, 29);
            buttonLuu.TabIndex = 0;
            buttonLuu.Text = "Lưu";
            buttonLuu.UseVisualStyleBackColor = true;
            buttonLuu.Click += buttonLuu_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(338, 236);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 29);
            buttonXoa.TabIndex = 1;
            buttonXoa.Text = "Xoá";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(194, 236);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 29);
            buttonSua.TabIndex = 2;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(560, 188);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelMaNV
            // 
            labelMaNV.AutoSize = true;
            labelMaNV.ForeColor = Color.Red;
            labelMaNV.Location = new Point(50, 121);
            labelMaNV.Name = "labelMaNV";
            labelMaNV.Size = new Size(97, 20);
            labelMaNV.TabIndex = 4;
            labelMaNV.Text = "Mã nhân viên";
            // 
            // labelTenNV
            // 
            labelTenNV.AutoSize = true;
            labelTenNV.Location = new Point(50, 172);
            labelTenNV.Name = "labelTenNV";
            labelTenNV.Size = new Size(99, 20);
            labelTenNV.TabIndex = 5;
            labelTenNV.Text = "Tên nhân viên";
            labelTenNV.Click += labelTenNV_Click;
            // 
            // labelSDT
            // 
            labelSDT.AutoSize = true;
            labelSDT.Location = new Point(450, 121);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(97, 20);
            labelSDT.TabIndex = 6;
            labelSDT.Text = "Số điện thoại";
            // 
            // labelViTri
            // 
            labelViTri.AutoSize = true;
            labelViTri.Location = new Point(450, 172);
            labelViTri.Name = "labelViTri";
            labelViTri.Size = new Size(40, 20);
            labelViTri.TabIndex = 7;
            labelViTri.Text = "Vị trí";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(163, 169);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(188, 27);
            txtTenNV.TabIndex = 8;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(163, 118);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(188, 27);
            txtMaNV.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(568, 118);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(188, 27);
            txtSDT.TabIndex = 10;
            // 
            // txtVitri
            // 
            txtVitri.Location = new Point(568, 169);
            txtVitri.Name = "txtVitri";
            txtVitri.Size = new Size(188, 27);
            txtVitri.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(244, 25);
            label1.Name = "label1";
            label1.Size = new Size(326, 41);
            label1.TabIndex = 12;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(856, 526);
            Controls.Add(label1);
            Controls.Add(txtVitri);
            Controls.Add(txtSDT);
            Controls.Add(txtMaNV);
            Controls.Add(txtTenNV);
            Controls.Add(labelViTri);
            Controls.Add(labelSDT);
            Controls.Add(labelTenNV);
            Controls.Add(labelMaNV);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSua);
            Controls.Add(buttonXoa);
            Controls.Add(buttonLuu);
            Name = "frmNhanVien";
            Text = "Nhân viên";
            FormClosing += frmNhanVien_FormClosing;
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLuu;
        private Button buttonXoa;
        private Button buttonSua;
        private DataGridView dataGridView1;
        private Label labelMaNV;
        private Label labelTenNV;
        private Label labelSDT;
        private Label labelViTri;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private TextBox txtSDT;
        private TextBox txtVitri;
        private Label label1;
    }
}