namespace MyApp
{
    partial class frmKhieuNai
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
            label5 = new Label();
            label6 = new Label();
            txtMaKN = new TextBox();
            cboMaDH = new ComboBox();
            cboLoaiKN = new ComboBox();
            cboTTKN = new ComboBox();
            dateTimeNgayKN = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtMaKH = new TextBox();
            menuStrip1 = new MenuStrip();
            chiTiếtPhiếuKhiếuNạiToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 54);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã khiếu nại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 105);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 163);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã đơn hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 47);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "Loại khiếu nại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(385, 163);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 4;
            label5.Text = "Trạng thái khiếu nại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(385, 105);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 5;
            label6.Text = "Ngày khiếu nại";
            // 
            // txtMaKN
            // 
            txtMaKN.Location = new Point(172, 47);
            txtMaKN.Name = "txtMaKN";
            txtMaKN.Size = new Size(125, 27);
            txtMaKN.TabIndex = 6;
            // 
            // cboMaDH
            // 
            cboMaDH.FormattingEnabled = true;
            cboMaDH.Location = new Point(172, 160);
            cboMaDH.Name = "cboMaDH";
            cboMaDH.Size = new Size(125, 28);
            cboMaDH.TabIndex = 8;
            // 
            // cboLoaiKN
            // 
            cboLoaiKN.FormattingEnabled = true;
            cboLoaiKN.Location = new Point(529, 44);
            cboLoaiKN.Name = "cboLoaiKN";
            cboLoaiKN.Size = new Size(65, 28);
            cboLoaiKN.TabIndex = 11;
            // 
            // cboTTKN
            // 
            cboTTKN.FormattingEnabled = true;
            cboTTKN.Location = new Point(529, 160);
            cboTTKN.Name = "cboTTKN";
            cboTTKN.Size = new Size(65, 28);
            cboTTKN.TabIndex = 12;
            cboTTKN.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // dateTimeNgayKN
            // 
            dateTimeNgayKN.Location = new Point(529, 103);
            dateTimeNgayKN.Name = "dateTimeNgayKN";
            dateTimeNgayKN.Size = new Size(213, 27);
            dateTimeNgayKN.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(696, 188);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(49, 208);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(190, 208);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(331, 208);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(172, 103);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(125, 27);
            txtMaKH.TabIndex = 17;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chiTiếtPhiếuKhiếuNạiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // chiTiếtPhiếuKhiếuNạiToolStripMenuItem
            // 
            chiTiếtPhiếuKhiếuNạiToolStripMenuItem.Name = "chiTiếtPhiếuKhiếuNạiToolStripMenuItem";
            chiTiếtPhiếuKhiếuNạiToolStripMenuItem.Size = new Size(174, 24);
            chiTiếtPhiếuKhiếuNạiToolStripMenuItem.Text = "Chi tiết phiếu khiếu nại";
            chiTiếtPhiếuKhiếuNạiToolStripMenuItem.Click += chiTiếtPhiếuKhiếuNạiToolStripMenuItem_Click;
            // 
            // frmKhieuNai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMaKH);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimeNgayKN);
            Controls.Add(cboTTKN);
            Controls.Add(cboLoaiKN);
            Controls.Add(cboMaDH);
            Controls.Add(txtMaKN);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmKhieuNai";
            Text = "Phiếu khiếu nại";
            Load += frmKhieuNai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaKN;
        private ComboBox cboMaDH;
        private ComboBox cboLoaiKN;
        private ComboBox cboTTKN;
        private DateTimePicker dateTimeNgayKN;
        private DataGridView dataGridView1;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtMaKH;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chiTiếtPhiếuKhiếuNạiToolStripMenuItem;
    }
}