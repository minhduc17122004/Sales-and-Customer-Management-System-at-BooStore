using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class frmNhanVien : Form
    {
        string sCon = "Data Source=LAPTOP-KG7I3E9P\\MSSQLSERVER01;Initial Catalog=CRM_48K21107;User ID=QUANLY;Password=123456";
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void labelTenNV_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            txtTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["SoDienThoaiNV"].Value.ToString();
            txtVitri.Text = dataGridView1.Rows[e.RowIndex].Cells["Vitri"].Value.ToString();
            txtMaNV.Enabled = false;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
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
            string sQuery = "select * from NHAN_VIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "NHAN_VIEN");

            dataGridView1.DataSource = ds.Tables["NHAN_VIEN"];

            con.Close(); //bước 3
            txtMaNV.Enabled = false;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            // Bước 1: Kết nối CSDL
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB: " + ex.Message);
                return; // Thoát nếu không kết nối được
            }

            // Bước 2: Chuẩn bị dữ liệu và kiểm tra tính hợp lệ
            string sTenNV = txtTenNV.Text.Trim();
            string sSoDienThoaiNV = txtSDT.Text.Trim();
            string sViTri = txtVitri.Text.Trim();

            // Bước 3: Tạo command và thêm tham số
            string sQuery = "exec kTraNV @TenNV, @SoDienThoaiNV, @ViTri, @ret OUTPUT";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@TenNV", sTenNV);
            cmd.Parameters.AddWithValue("@SoDienThoaiNV", sSoDienThoaiNV);
            cmd.Parameters.AddWithValue("@ViTri", sViTri);

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
                    MessageBox.Show("Thêm mới nhân viên thành công!");
                }
                else if (retValue == 0)
                {
                    MessageBox.Show("Nhân viên đã tồn tại với mã hoặc số điện thoại này.");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi không xác định.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới nhân viên: " + ex.Message);
            }

            // Bước 4: Hiển thị lại danh sách nhân viên
            string sQuerySelect = "SELECT * FROM NHAN_VIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerySelect, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "NHAN_VIEN");

            dataGridView1.DataSource = ds.Tables["NHAN_VIEN"];

            con.Close(); // Đóng kết nối
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            // Bước 1: Kết nối cơ sở dữ liệu
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                return;
            }

            // Bước 2: Lấy giá trị từ giao diện
            string sMaNV = txtMaNV.Text;
            string sTenNV = txtTenNV.Text;
            string sSoDienThoaiNV = txtSDT.Text;
            string sViTri = txtVitri.Text;

            // Câu lệnh cập nhật dữ liệu
            string sQuery = "UPDATE NHAN_VIEN SET TenNV = @TenNV, SoDienThoaiNV = @SoDienThoaiNV, Vitri = @Vitri WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Gắn tham số
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            cmd.Parameters.AddWithValue("@TenNV", sTenNV);
            cmd.Parameters.AddWithValue("@SoDienThoaiNV", sSoDienThoaiNV);
            cmd.Parameters.AddWithValue("@Vitri", sViTri);
            // kiểm tra sdt
            if (sSoDienThoaiNV.Length != 10 || !sSoDienThoaiNV.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập đúng 10 chữ số.");
                return;
            }
            try
            {
                // Thực thi lệnh cập nhật
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật: " + ex.Message);
            }

            // Hiển thị lại danh sách nhân viên
            string sQuerySelect = "SELECT * FROM NHAN_VIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerySelect, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "NHAN_VIEN");

            dataGridView1.DataSource = ds.Tables["NHAN_VIEN"];

            // Đóng kết nối
            con.Close();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắc chắn xoá không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                // Bước 1: Kết nối cơ sở dữ liệu
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB: " + ex.Message);
                    return;
                }

                // Bước 2: Lấy giá trị từ giao diện
                string sMaNV = txtMaNV.Text; // Lấy mã nhân viên từ textbox

                // Tạo câu truy vấn SQL để xóa nhân viên
                string sQuery = "DELETE FROM NHAN_VIEN WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaNV", sMaNV);

                try
                {
                    // Thực thi lệnh xóa
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa nhân viên thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xóa: " + ex.Message);
                }

                // Bước 3: Hiển thị lại danh sách nhân viên
                string sQuerry = "SELECT * FROM NHAN_VIEN";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "NHAN_VIEN");

                dataGridView1.DataSource = ds.Tables["NHAN_VIEN"];

                // Đóng kết nối
                con.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
