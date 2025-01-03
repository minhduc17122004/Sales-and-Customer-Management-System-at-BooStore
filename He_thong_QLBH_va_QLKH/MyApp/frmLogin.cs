using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{

    public partial class frmLogin : Form
    {
        string sCon = "Data Source=LAPTOP-KG7I3E9P\\MSSQLSERVER01;Initial Catalog=CRM_48K21107;Integrated Security=True";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDN_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    // Mở kết nối
                    con.Open();

                    // Tạo command gọi stored procedure
                    SqlCommand cmd = new SqlCommand("sp_DangNhap", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Thêm tham số
                    cmd.Parameters.AddWithValue("@TAIKHOAN", txtTK.Text);
                    cmd.Parameters.AddWithValue("@MATKHAU", txtMatKhau.Text);

                    // Thêm tham số đầu ra
                    SqlParameter retParam = new SqlParameter("@ret", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(retParam);

                    // Thực thi stored procedure
                    cmd.ExecuteNonQuery();

                    // Kiểm tra kết quả
                    if ((int)retParam.Value == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                        new Home().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
                }
            }
        }


        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                pictureBox3.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                pictureBox2.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void labelMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
