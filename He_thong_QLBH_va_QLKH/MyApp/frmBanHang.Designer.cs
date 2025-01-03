namespace MyApp
{
    partial class frmBanHang
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
            lbMaDH = new Label();
            labelMaSP = new Label();
            lbMaGia = new Label();
            lbSoLuong = new Label();
            txtMaDH = new TextBox();
            txtMaSP = new TextBox();
            txtMaGia = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbMaDH
            // 
            lbMaDH.AutoSize = true;
            lbMaDH.Location = new Point(39, 35);
            lbMaDH.Name = "lbMaDH";
            lbMaDH.Size = new Size(97, 20);
            lbMaDH.TabIndex = 0;
            lbMaDH.Text = "Mã đơn hàng";
            // 
            // labelMaSP
            // 
            labelMaSP.AutoSize = true;
            labelMaSP.Location = new Point(39, 88);
            labelMaSP.Name = "labelMaSP";
            labelMaSP.Size = new Size(98, 20);
            labelMaSP.TabIndex = 1;
            labelMaSP.Text = "Mã sản phẩm";
            // 
            // lbMaGia
            // 
            lbMaGia.AutoSize = true;
            lbMaGia.Location = new Point(39, 141);
            lbMaGia.Name = "lbMaGia";
            lbMaGia.Size = new Size(55, 20);
            lbMaGia.TabIndex = 2;
            lbMaGia.Text = "Mã giá";
            // 
            // lbSoLuong
            // 
            lbSoLuong.AutoSize = true;
            lbSoLuong.Location = new Point(39, 194);
            lbSoLuong.Name = "lbSoLuong";
            lbSoLuong.Size = new Size(69, 20);
            lbSoLuong.TabIndex = 3;
            lbSoLuong.Text = "Số lượng";
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(172, 35);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(153, 27);
            txtMaDH.TabIndex = 4;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(173, 88);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(152, 27);
            txtMaSP.TabIndex = 5;
            // 
            // txtMaGia
            // 
            txtMaGia.Location = new Point(172, 146);
            txtMaGia.Name = "txtMaGia";
            txtMaGia.Size = new Size(153, 27);
            txtMaGia.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 27);
            textBox2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(832, 188);
            dataGridView1.TabIndex = 8;
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 504);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(txtMaGia);
            Controls.Add(txtMaSP);
            Controls.Add(txtMaDH);
            Controls.Add(lbSoLuong);
            Controls.Add(lbMaGia);
            Controls.Add(labelMaSP);
            Controls.Add(lbMaDH);
            Name = "frmBanHang";
            Text = "frmBanHang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMaDH;
        private Label labelMaSP;
        private Label lbMaGia;
        private Label lbSoLuong;
        private TextBox txtMaDH;
        private TextBox txtMaSP;
        private TextBox txtMaGia;
        private TextBox textBox2;
        private DataGridView dataGridView1;
    }
}