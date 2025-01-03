namespace MyApp
{
    partial class frmDVVC
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            txtMaDVVC = new TextBox();
            txtTenDVVC = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(33, 70);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã DVVC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 130);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên DVVC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 130);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 70);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(571, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(33, 192);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(328, 192);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(178, 192);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txtMaDVVC
            // 
            txtMaDVVC.Location = new Point(131, 70);
            txtMaDVVC.Name = "txtMaDVVC";
            txtMaDVVC.Size = new Size(154, 27);
            txtMaDVVC.TabIndex = 8;
            // 
            // txtTenDVVC
            // 
            txtTenDVVC.Location = new Point(131, 133);
            txtTenDVVC.Name = "txtTenDVVC";
            txtTenDVVC.Size = new Size(154, 27);
            txtTenDVVC.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(484, 70);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(201, 27);
            txtSDT.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(484, 133);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(201, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // frmDVVC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtTenDVVC);
            Controls.Add(txtMaDVVC);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDVVC";
            Text = "Đơn vị vận chuyển";
            Load += frmDVVC_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtMaDVVC;
        private TextBox txtTenDVVC;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
    }
}