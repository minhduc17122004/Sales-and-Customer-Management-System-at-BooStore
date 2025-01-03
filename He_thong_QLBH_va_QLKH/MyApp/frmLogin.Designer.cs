namespace MyApp
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            labelTK = new Label();
            labelMK = new Label();
            txtTK = new TextBox();
            txtMatKhau = new TextBox();
            BtnDN = new Button();
            btnHuy = new Button();
            labeltileDN = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Azure;
            pictureBox1.Location = new Point(268, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(444, 356);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelTK
            // 
            labelTK.AutoSize = true;
            labelTK.BackColor = Color.Azure;
            labelTK.Location = new Point(329, 234);
            labelTK.Name = "labelTK";
            labelTK.Size = new Size(71, 20);
            labelTK.TabIndex = 1;
            labelTK.Text = "Tài khoản";
            labelTK.TextChanged += labelTK_TextChanged;
            labelTK.Click += label1_Click;
            // 
            // labelMK
            // 
            labelMK.AutoSize = true;
            labelMK.BackColor = Color.Azure;
            labelMK.Location = new Point(329, 282);
            labelMK.Name = "labelMK";
            labelMK.Size = new Size(70, 20);
            labelMK.TabIndex = 2;
            labelMK.Text = "Mật khẩu";
            labelMK.TextChanged += labelMK_TextChanged;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(417, 226);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(188, 27);
            txtTK.TabIndex = 3;
            txtTK.TextChanged += txtTK_TextChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(417, 274);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(188, 27);
            txtMatKhau.TabIndex = 4;
            // 
            // BtnDN
            // 
            BtnDN.BackColor = Color.DarkCyan;
            BtnDN.ForeColor = Color.White;
            BtnDN.Location = new Point(427, 336);
            BtnDN.Name = "BtnDN";
            BtnDN.Size = new Size(94, 29);
            BtnDN.TabIndex = 5;
            BtnDN.Text = "Đăng nhập";
            BtnDN.UseVisualStyleBackColor = false;
            BtnDN.Click += BtnDN_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Gray;
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(427, 385);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // labeltileDN
            // 
            labeltileDN.AutoSize = true;
            labeltileDN.BackColor = Color.Azure;
            labeltileDN.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labeltileDN.Location = new Point(404, 121);
            labeltileDN.Name = "labeltileDN";
            labeltileDN.Size = new Size(200, 41);
            labeltileDN.TabIndex = 7;
            labeltileDN.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(611, 275);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Azure;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(611, 275);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Studios_BOO_11a_1024x671;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(975, 528);
            Controls.Add(pictureBox2);
            Controls.Add(labeltileDN);
            Controls.Add(btnHuy);
            Controls.Add(BtnDN);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTK);
            Controls.Add(labelMK);
            Controls.Add(labelTK);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            Text = "Đăng nhập";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTK;
        private PictureBox pictureBox1;
        private Label labelTK;
        private Label labelMK;
        private TextBox txtMatKhau;
        private Button BtnDN;
        private Button btnHuy;
        private Label labeltileDN;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}