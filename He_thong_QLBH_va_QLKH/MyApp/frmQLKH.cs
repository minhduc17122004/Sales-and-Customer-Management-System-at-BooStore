using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // buoc 0
namespace MyApp
{
    public partial class frmQLKH : Form
    {
        string sCon = "Data Source=LAPTOP-KG7I3E9P\\MSSQLSERVER01;Initial Catalog=CRM_48K21107;Integrated Security=True";
        public frmQLKH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Bước 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

            }
            // Bước 2: Chuẩn bị dữ liệu và kiểm tra tính hợp lệ
            string sTenKH = txtTenKH.Text;
            string sSoDienThoai = txtSoDienThoai.Text;
            string sDiaChi = txtDiaChi.Text;

            // Tạo command và thêm tham số
            string sQuery = "exec kTraKH @TenKH, @SoDienThoai, @DiaChi, @ret OUTPUT";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@TenKH", sTenKH);
            cmd.Parameters.AddWithValue("@SoDienThoai", sSoDienThoai);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);

            // Thêm tham số OUTPUT
            SqlParameter retParam = new SqlParameter("@ret", SqlDbType.Int);
            retParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(retParam);

            try
            {
                cmd.ExecuteNonQuery();

                // Lấy giá trị @ret
                int retValue = Convert.ToInt32(retParam.Value);
                if (retValue == 1)
                {
                    MessageBox.Show("Thêm mới thành công!");

                }
                else if (retValue == 0)
                {
                    MessageBox.Show("Khách hàng đã tồn tại với số điện thoại này.");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi không xác định.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới: " + ex.Message);
            }

            string sQuerry = "select * from KHACH_HANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "KHACH_HANG");

            dataGridView1.DataSource = ds.Tables["KHACH_HANG"];

            con.Close(); // đóng kết nối

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSDT_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmQLKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        private void frmQLKH_Load(object sender, EventArgs e)
        {
            // Bước 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

            }

            // Bước 2: lấy DL về
            string sQuery = "select * from KHACH_HANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "KHACH_HANG");

            dataGridView1.DataSource = ds.Tables["KHACH_HANG"];
            txtMaKH.Enabled = false;

            con.Close(); //bước 3

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
            txtSoDienThoai.Text = dataGridView1.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            txtMaKH.Enabled = false;
        }

        private void btn_ClickSua(object sender, EventArgs e)
        {
            // Bước 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

            }
            //Bước 2
            //Lấy giá trị
            string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKH.Text;
            string sSoDienThoai = txtSoDienThoai.Text;
            string sDiaChi = txtDiaChi.Text;
            string sQuery = "update KHACH_HANG set TenKH = @TenKH, SoDienThoai = @SoDienThoai" +
                ", DiaChi= @DiaChi where MaKh = @MaKH";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaKH", sMaKH);
            cmd.Parameters.AddWithValue("@TenKH", sTenKH);
            cmd.Parameters.AddWithValue("@SoDienThoai", sSoDienThoai);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(" Xảy ra lỗi trong quá trình cập nhật");
            }

            string sQuerry = "select * from KHACH_HANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "KHACH_HANG");

            dataGridView1.DataSource = ds.Tables["KHACH_HANG"];

            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắc chắn xoá không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                // Bước 1
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

                }
                //Bước 2
                //Lấy giá trị
                string sMaKH = txtMaKH.Text;

                string sQuery = "delete KHACH_HANG  where MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaKH", sMaKH);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công!");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Xảy ra lỗi trong quá trình xoá");
                }

                string sQuerry = "select * from KHACH_HANG";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "KHACH_HANG");

                dataGridView1.DataSource = ds.Tables["KHACH_HANG"];

                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}