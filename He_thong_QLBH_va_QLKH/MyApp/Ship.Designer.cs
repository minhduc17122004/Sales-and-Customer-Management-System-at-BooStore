namespace MyApp
{
    partial class Ship
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
            labelMaShip = new Label();
            labelMaDH = new Label();
            labelMaDVVC = new Label();
            labelPhiShip = new Label();
            labelTTGH = new Label();
            Ngaygiao = new Label();
            txtMaShip = new TextBox();
            txtPhiShip = new TextBox();
            txtTTGH = new TextBox();
            dateTimeNgayGiao = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            cbxMaDH = new ComboBox();
            cbxMaDVVC = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelMaShip
            // 
            labelMaShip.AutoSize = true;
            labelMaShip.ForeColor = Color.Red;
            labelMaShip.Location = new Point(33, 49);
            labelMaShip.Name = "labelMaShip";
            labelMaShip.Size = new Size(61, 20);
            labelMaShip.TabIndex = 1;
            labelMaShip.Text = "Mã ship";
            // 
            // labelMaDH
            // 
            labelMaDH.AutoSize = true;
            labelMaDH.Location = new Point(32, 100);
            labelMaDH.Name = "labelMaDH";
            labelMaDH.Size = new Size(97, 20);
            labelMaDH.TabIndex = 2;
            labelMaDH.Text = "Mã đơn hàng";
            // 
            // labelMaDVVC
            // 
            labelMaDVVC.AutoSize = true;
            labelMaDVVC.Location = new Point(34, 151);
            labelMaDVVC.Name = "labelMaDVVC";
            labelMaDVVC.Size = new Size(72, 20);
            labelMaDVVC.TabIndex = 3;
            labelMaDVVC.Text = "Mã DVVC";
            // 
            // labelPhiShip
            // 
            labelPhiShip.AutoSize = true;
            labelPhiShip.Location = new Point(403, 52);
            labelPhiShip.Name = "labelPhiShip";
            labelPhiShip.Size = new Size(60, 20);
            labelPhiShip.TabIndex = 4;
            labelPhiShip.Text = "Phí ship";
            labelPhiShip.Click += labelPhiShip_Click;
            // 
            // labelTTGH
            // 
            labelTTGH.AutoSize = true;
            labelTTGH.Location = new Point(403, 101);
            labelTTGH.Name = "labelTTGH";
            labelTTGH.Size = new Size(100, 20);
            labelTTGH.TabIndex = 5;
            labelTTGH.Text = "Trạng thái GH";
            labelTTGH.Click += labelTTGH_Click;
            // 
            // Ngaygiao
            // 
            Ngaygiao.AutoSize = true;
            Ngaygiao.Location = new Point(403, 150);
            Ngaygiao.Name = "Ngaygiao";
            Ngaygiao.Size = new Size(78, 20);
            Ngaygiao.TabIndex = 6;
            Ngaygiao.Text = "Ngày giao";
            Ngaygiao.Click += Ngaygiao_Click;
            // 
            // txtMaShip
            // 
            txtMaShip.Location = new Point(176, 49);
            txtMaShip.Name = "txtMaShip";
            txtMaShip.Size = new Size(145, 27);
            txtMaShip.TabIndex = 7;
            // 
            // txtPhiShip
            // 
            txtPhiShip.Location = new Point(545, 49);
            txtPhiShip.Name = "txtPhiShip";
            txtPhiShip.Size = new Size(145, 27);
            txtPhiShip.TabIndex = 10;
            // 
            // txtTTGH
            // 
            txtTTGH.Location = new Point(546, 98);
            txtTTGH.Name = "txtTTGH";
            txtTTGH.Size = new Size(145, 27);
            txtTTGH.TabIndex = 11;
            // 
            // dateTimeNgayGiao
            // 
            dateTimeNgayGiao.Location = new Point(545, 147);
            dateTimeNgayGiao.Name = "dateTimeNgayGiao";
            dateTimeNgayGiao.Size = new Size(212, 27);
            dateTimeNgayGiao.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(658, 188);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(27, 201);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(325, 201);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(176, 201);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // cbxMaDH
            // 
            cbxMaDH.FormattingEnabled = true;
            cbxMaDH.Location = new Point(176, 101);
            cbxMaDH.Name = "cbxMaDH";
            cbxMaDH.Size = new Size(151, 28);
            cbxMaDH.TabIndex = 17;
            // 
            // cbxMaDVVC
            // 
            cbxMaDVVC.FormattingEnabled = true;
            cbxMaDVVC.Location = new Point(176, 151);
            cbxMaDVVC.Name = "cbxMaDVVC";
            cbxMaDVVC.Size = new Size(151, 28);
            cbxMaDVVC.TabIndex = 18;
            // 
            // Ship
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxMaDVVC);
            Controls.Add(cbxMaDH);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimeNgayGiao);
            Controls.Add(txtTTGH);
            Controls.Add(txtPhiShip);
            Controls.Add(txtMaShip);
            Controls.Add(Ngaygiao);
            Controls.Add(labelTTGH);
            Controls.Add(labelPhiShip);
            Controls.Add(labelMaDVVC);
            Controls.Add(labelMaDH);
            Controls.Add(labelMaShip);
            Name = "Ship";
            Text = "Ship";
            TransparencyKey = Color.White;
            Load += Ship_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelMaShip;
        private Label labelMaDH;
        private Label labelMaDVVC;
        private Label labelPhiShip;
        private Label labelTTGH;
        private Label Ngaygiao;
        private TextBox txtMaShip;
        private TextBox txtPhiShip;
        private TextBox txtTTGH;
        private DateTimePicker dateTimeNgayGiao;
        private DataGridView dataGridView1;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private ComboBox cbxMaDH;
        private ComboBox cbxMaDVVC;
    }
}