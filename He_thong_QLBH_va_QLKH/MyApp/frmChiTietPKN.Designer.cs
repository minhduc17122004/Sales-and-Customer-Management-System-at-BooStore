namespace MyApp
{
    partial class frmChiTietPKN
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
            txtMaKN = new TextBox();
            txtMaNV = new TextBox();
            txtVanDe = new TextBox();
            txtPhuongAn = new TextBox();
            dataGridView1 = new DataGridView();
            dateTimeNgayGQ = new DateTimePicker();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 35);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã khiếu nại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 83);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 36);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Vấn đề";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 90);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 3;
            label4.Text = "Phương án";
            // 
            // txtMaKN
            // 
            txtMaKN.Location = new Point(173, 32);
            txtMaKN.Name = "txtMaKN";
            txtMaKN.Size = new Size(198, 27);
            txtMaKN.TabIndex = 5;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(173, 79);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(198, 27);
            txtMaNV.TabIndex = 6;
            // 
            // txtVanDe
            // 
            txtVanDe.Location = new Point(520, 32);
            txtVanDe.Name = "txtVanDe";
            txtVanDe.Size = new Size(293, 27);
            txtVanDe.TabIndex = 7;
            // 
            // txtPhuongAn
            // 
            txtPhuongAn.Location = new Point(520, 83);
            txtPhuongAn.Name = "txtPhuongAn";
            txtPhuongAn.Size = new Size(293, 27);
            txtPhuongAn.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(690, 262);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimeNgayGQ
            // 
            dateTimeNgayGQ.Location = new Point(173, 129);
            dateTimeNgayGQ.Name = "dateTimeNgayGQ";
            dateTimeNgayGQ.Size = new Size(198, 27);
            dateTimeNgayGQ.TabIndex = 10;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(36, 185);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(173, 185);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(310, 185);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 129);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 11;
            label5.Text = "Ngày giải quyết";
            // 
            // frmChiTietPKN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(941, 564);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(label5);
            Controls.Add(dateTimeNgayGQ);
            Controls.Add(dataGridView1);
            Controls.Add(txtPhuongAn);
            Controls.Add(txtVanDe);
            Controls.Add(txtMaNV);
            Controls.Add(txtMaKN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmChiTietPKN";
            Text = "Chi tiết phiếu khiếu nại";
            Load += frmChiTietPKN_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMaKN;
        private TextBox txtMaNV;
        private TextBox txtVanDe;
        private TextBox txtPhuongAn;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimeNgayGQ;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Label label5;
    }
}