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
    public partial class frmChiTietPKN : Form
    {
        string sCon = "Data Source=LAPTOP-KG7I3E9P\\MSSQLSERVER01;Initial Catalog=CRM_48K21107;Integrated Security=True";
        public frmChiTietPKN()
        {
            InitializeComponent();
        }

        private void frmChiTietPKN_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    // Tải dữ liệu cho dataGridView1 
                    string sQuery = "SELECT * FROM CHI_TIET_KHIEU_NAI";
                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "CHI_TIET_KHIEU_NAI");
                    dataGridView1.DataSource = ds.Tables["CHI_TIET_KHIEU_NAI"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình tải dữ liệu: " + ex.Message);
                }
                con.Close();


            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Bước 1: Mở kết nối SQL
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

            // Bước 2: Lấy giá trị từ các controls
            string sMaKN = txtMaKN.Text;                        // Mã khiếu nại
            string sMaNV = txtMaNV.Text;                        // Mã nhân viên
            string sVanDe = txtVanDe.Text;                      // Vấn đề
            string sPhuongAn = txtPhuongAn.Text;                // Phương án
            string sNgayGQ = dateTimeNgayGQ.Value.ToString("yyyy-MM-dd"); // Ngày giải quyết

            // Câu lệnh SQL UPDATE
            string sQuery = @"UPDATE CHI_TIET_KHIEU_NAI
              SET MaNV = @MaNV, VanDe = @VanDe, PhuongAn = @PhuongAn, 
                  NgayGiaiQuyet = @NgayGiaiQuyet
              WHERE MaKN = @MaKN";

            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@MaKN", sMaKN);
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            cmd.Parameters.AddWithValue("@VanDe", sVanDe);
            cmd.Parameters.AddWithValue("@PhuongAn", sPhuongAn);
            cmd.Parameters.AddWithValue("@NgayGiaiQuyet", sNgayGQ);

            try
            {
                // Thực thi lệnh UPDATE
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật chi tiết phiếu khiếu nại thành công!");
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào được cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật: " + ex.Message);
            }

            int selectedIndex = -1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedIndex = dataGridView1.SelectedRows[0].Index; // Lưu vị trí dòng đang chọn
            }

            // Bước 3: Tải lại dữ liệu bảng CHI_TIET_KHIEU_NAI vào DataGridView
            string sQueryReload = "SELECT * FROM CHI_TIET_KHIEU_NAI";
            SqlDataAdapter adapter = new SqlDataAdapter(sQueryReload, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "CHI_TIET_KHIEU_NAI");
            dataGridView1.DataSource = ds.Tables["CHI_TIET_KHIEU_NAI"];

            if (selectedIndex >= 0 && selectedIndex < dataGridView1.Rows.Count)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[selectedIndex].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = selectedIndex; // Cuộn đến dòng được chọn
            }

            // Bước 4: Đóng kết nối
            con.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Bước 1: Kết nối đến CSDL
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB: " + ex.Message);
                return; // Thoát khỏi hàm nếu kết nối thất bại
            }

            // Bước 2: Chuẩn bị dữ liệu
            string sMaKN = txtMaKN.Text;
            string sMaNV = txtMaNV.Text;             // Mã NV
            string sVanDe = txtVanDe.Text;
            string sPhuongAn = txtPhuongAn.Text;
            string sNgayGQ = dateTimeNgayGQ.Value.ToString("yyyy-MM-dd"); // Ngày khiếu nại


            // Bước 3: Tạo command để gọi thủ tục AddPhieuKN
            string sQuery = "exec addCTKN @MaKN, @MaNV, @VanDe, @PhuongAn ,@NgayGiaiQuyet, @ret OUTPUT";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số vào command
            cmd.Parameters.AddWithValue("@MaKN", sMaKN);
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            cmd.Parameters.AddWithValue("@VanDe", sVanDe);
            cmd.Parameters.AddWithValue("@PhuongAn", sPhuongAn);
            cmd.Parameters.AddWithValue("@NgayGiaiQuyet", sNgayGQ);

            // Thêm tham số OUTPUT
            SqlParameter retParam = new SqlParameter("@ret", SqlDbType.Int);
            retParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(retParam);

            try
            {
                // Bước 4: Thực thi thủ tục
                cmd.ExecuteNonQuery();

                // Lấy giá trị OUTPUT từ thủ tục
                int retValue = Convert.ToInt32(retParam.Value);
                if (retValue == 1)
                {
                    MessageBox.Show("Thêm mới chi tiết phiếu khiếu nại thành công!");

                    // Bước 5: Tải lại dữ liệu lên dataGridView1
                    string sQueryReload = "SELECT * FROM CHI_TIET_KHIEU_NAI";
                    SqlDataAdapter adapter = new SqlDataAdapter(sQueryReload, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "CHI_TIET_KHIEU_NAI");
                    dataGridView1.DataSource = ds.Tables["CHI_TIET_KHIEU_NAI"];

                    // Đặt dòng cuối cùng là dòng được chọn trong dataGridView1
                    if (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.ClearSelection(); // Xóa các lựa chọn cũ

                        int lastRowIndex = dataGridView1.Rows.Count - 2; // Lấy chỉ số dòng cuối
                        if (lastRowIndex >= 0) // Kiểm tra có dòng nào hay không
                        {
                            dataGridView1.Rows[lastRowIndex].Selected = true; // Đặt dòng cuối được chọn
                            dataGridView1.FirstDisplayedScrollingRowIndex = lastRowIndex; // Cuộn đến dòng cuối
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thêm mới chi tiết phiếu khiếu nại thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới chi tiết phiếu khiếu nại: " + ex.Message);
            }

            // Bước 6: Đóng kết nối
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin đơn hàng từ dòng được chọn
            txtMaKN.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKN"].Value.ToString();
            txtMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            txtVanDe.Text = dataGridView1.Rows[e.RowIndex].Cells["VanDe"].Value.ToString();
            txtPhuongAn.Text = dataGridView1.Rows[e.RowIndex].Cells["PhuongAn"].Value.ToString();
            dateTimeNgayGQ.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayGiaiQuyet"].Value);
            txtMaKN.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            DialogResult ret = MessageBox.Show("Có chắc chắn xoá không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret != DialogResult.OK) return;

            // Bước 1: Mở kết nối SQL
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

            // Bước 2: Lấy giá trị từ các controls
            string sMaKN = txtMaKN.Text;
            string sMaNV = txtMaNV.Text;

            // Câu lệnh SQL DELETE
            string sQuery = @"DELETE FROM CHI_TIET_KHIEU_NAI 
                      WHERE MaKN = @MaKN AND MaNV = @MaNV";

            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@MaKN", sMaKN);
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);

            try
            {
                // Thực thi lệnh DELETE
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xoá chi tiết phiếu khiếu nại thành công!");
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào được xoá.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình xoá: " + ex.Message);
            }

            // Bước 3: Tải lại dữ liệu bảng CHI_TIET_KHIEU_NAI vào DataGridView
            string sQueryReload = "SELECT * FROM CHI_TIET_KHIEU_NAI";
            SqlDataAdapter adapter = new SqlDataAdapter(sQueryReload, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "CHI_TIET_KHIEU_NAI");
            dataGridView1.DataSource = ds.Tables["CHI_TIET_KHIEU_NAI"];

            // Bước 4: Đóng kết nối
            con.Close();
        }
    }
}
