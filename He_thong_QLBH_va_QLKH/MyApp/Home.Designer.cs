namespace MyApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            btnKN = new Button();
            btnSP = new Button();
            btnDH = new Button();
            btnKH = new Button();
            btnNV = new Button();
            pictureBox1 = new PictureBox();
            panel_Top = new Panel();
            labelHome = new Label();
            panelBody = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_Top.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnKN);
            panel1.Controls.Add(btnSP);
            panel1.Controls.Add(btnDH);
            panel1.Controls.Add(btnKH);
            panel1.Controls.Add(btnNV);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 0;
            // 
            // btnKN
            // 
            btnKN.Dock = DockStyle.Top;
            btnKN.Location = new Point(0, 379);
            btnKN.Name = "btnKN";
            btnKN.Size = new Size(250, 63);
            btnKN.TabIndex = 5;
            btnKN.Text = "Khiếu nại ";
            btnKN.UseVisualStyleBackColor = true;
            btnKN.Click += btnKN_Click;
            // 
            // btnSP
            // 
            btnSP.Dock = DockStyle.Top;
            btnSP.Location = new Point(0, 316);
            btnSP.Name = "btnSP";
            btnSP.Size = new Size(250, 63);
            btnSP.TabIndex = 4;
            btnSP.Text = "Sản phẩm";
            btnSP.UseVisualStyleBackColor = true;
            btnSP.Click += btnSP_Click;
            // 
            // btnDH
            // 
            btnDH.Dock = DockStyle.Top;
            btnDH.Location = new Point(0, 253);
            btnDH.Name = "btnDH";
            btnDH.Size = new Size(250, 63);
            btnDH.TabIndex = 3;
            btnDH.Text = "Đơn hàng";
            btnDH.UseVisualStyleBackColor = true;
            btnDH.Click += btnDH_Click;
            // 
            // btnKH
            // 
            btnKH.Dock = DockStyle.Top;
            btnKH.Location = new Point(0, 190);
            btnKH.Name = "btnKH";
            btnKH.Size = new Size(250, 63);
            btnKH.TabIndex = 2;
            btnKH.Text = "Khách hàng";
            btnKH.UseVisualStyleBackColor = true;
            btnKH.Click += btnKH_Click;
            // 
            // btnNV
            // 
            btnNV.Dock = DockStyle.Top;
            btnNV.Location = new Point(0, 127);
            btnNV.Name = "btnNV";
            btnNV.Size = new Size(250, 63);
            btnNV.TabIndex = 1;
            btnNV.Text = "Nhân viên";
            btnNV.UseVisualStyleBackColor = true;
            btnNV.Click += btnNV_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 127);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_Top
            // 
            panel_Top.BackColor = SystemColors.ActiveCaption;
            panel_Top.Controls.Add(labelHome);
            panel_Top.Dock = DockStyle.Top;
            panel_Top.Location = new Point(250, 0);
            panel_Top.Name = "panel_Top";
            panel_Top.Size = new Size(550, 125);
            panel_Top.TabIndex = 1;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelHome.Location = new Point(30, 45);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(124, 31);
            labelHome.TabIndex = 0;
            labelHome.Text = "Trang chủ";
            // 
            // panelBody
            // 
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(250, 125);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(550, 325);
            panelBody.TabIndex = 2;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelBody);
            Controls.Add(panel_Top);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Home";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_Top.ResumeLayout(false);
            panel_Top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNV;
        private PictureBox pictureBox1;
        private Panel panel_Top;
        private Label labelHome;
        private Panel panelBody;
        private Button btnKN;
        private Button btnSP;
        private Button btnDH;
        private Button btnKH;
    }
}