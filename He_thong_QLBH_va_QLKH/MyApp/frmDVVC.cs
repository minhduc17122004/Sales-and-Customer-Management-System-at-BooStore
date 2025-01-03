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
    public partial class frmDVVC : Form
    {
        string sCon = "Data Source=LAPTOP-KG7I3E9P\\MSSQLSERVER01;Initial Catalog=CRM_48K21107;Integrated Security=True";
        public frmDVVC()
        {
            InitializeComponent();
        }

        private void frmDVVC_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    // Tải dữ liệu cho dataGridView1 (Ship)
                    string sQuery = "SELECT * FROM DON_VI_VAN_CHUYEN";
                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "DON_VI_VAN_CHUYEN");
                    dataGridView1.DataSource = ds.Tables["DON_VI_VAN_CHUYEN"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình tải dữ liệu: " + ex.Message);
                }
                con.Close();
                txtMaDVVC.Enabled = false;
            }
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
            string sTenDV = txtTenDVVC.Text;       // Tên đơn vị vận chuyển
            string sSDT = txtSDT.Text; // Số điện thoại
            string sDiaChi = txtDiaChi.Text;   // Địa chỉ

            // Bước 3: Tạo command để gọi thủ tục `AddDVVC`
            string sQuery = "exec AddDVVC @TenDV, @SDT, @DiaChi, @ret OUTPUT";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số vào command
            cmd.Parameters.AddWithValue("@TenDV", sTenDV);
            cmd.Parameters.AddWithValue("@SDT", sSDT);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);

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
                    MessageBox.Show("Thêm mới đơn vị vận chuyển thành công!");

                    // Bước 5: Tải lại dữ liệu lên dataGridView2
                    string sQueryReload = "SELECT * FROM DON_VI_VAN_CHUYEN";
                    SqlDataAdapter adapter = new SqlDataAdapter(sQueryReload, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "DON_VI_VAN_CHUYEN");
                    dataGridView1.DataSource = ds.Tables["DON_VI_VAN_CHUYEN"];

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
                    MessageBox.Show("Thêm mới đơn vị vận chuyển thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới đơn vị vận chuyển: " + ex.Message);
            }

            // Bước 6: Đóng kết nối
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin đơn hàng từ dòng được chọn
            txtMaDVVC.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDVVC"].Value.ToString();
            txtTenDVVC.Text = dataGridView1.Rows[e.RowIndex].Cells["TenDV"].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["SoDienThoaiDV"].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChiDV"].Value.ToString();
            txtMaDVVC.Enabled = false;
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
            string sMaDVVC = txtMaDVVC.Text;
            string sTenDVVC = txtTenDVVC.Text;
            string sDiaChi = txtDiaChi.Text;
            string sSoDienThoai = txtSDT.Text;

            // Câu lệnh SQL UPDATE
            string sQuery = @"UPDATE DON_VI_VAN_CHUYEN 
                      SET TenDV = @TenDV, DiaChiDV = @DiaChiDV, SoDienThoaiDV = @SoDienThoaiDV
                      WHERE MaDVVC = @MaDVVC";

            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@MaDVVC", sMaDVVC);
            cmd.Parameters.AddWithValue("@TenDV", sTenDVVC);
            cmd.Parameters.AddWithValue("@DiaChiDV", sDiaChi);
            cmd.Parameters.AddWithValue("@SoDienThoaiDV", sSoDienThoai);

            try
            {
                // Thực thi lệnh UPDATE
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
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

            // Bước 3: Tải lại dữ liệu bảng DON_VI_VAN_CHUYEN vào DataGridView
            string sQueryReload = "SELECT * FROM DON_VI_VAN_CHUYEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQueryReload, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "DON_VI_VAN_CHUYEN");
            dataGridView1.DataSource = ds.Tables["DON_VI_VAN_CHUYEN"]; // Giả sử bạn hiển thị dữ liệu lên dataGridView2

            if (selectedIndex >= 0 && selectedIndex < dataGridView1.Rows.Count)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[selectedIndex].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = selectedIndex; // Cuộn đến dòng được chọn
            }
            // Bước 4: Đóng kết nối
            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắc chắn xoá không?", "Thông báo", MessageBoxButtons.OKCancel);
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
            string sMaDVVC = txtMaDVVC.Text;

            // Câu lệnh SQL DELETE
            string sQuery = @"DELETE FROM DON_VI_VAN_CHUYEN 
                      WHERE MaDVVC = @MaDVVC";

            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@MaDVVC", sMaDVVC);

            try
            {
                // Thực thi lệnh DELETE
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xoá thành công!");
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

            // Bước 3: Tải lại dữ liệu bảng SHIP vào DataGridView
            string sQueryReload = "SELECT * FROM DON_VI_VAN_CHUYEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQueryReload, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "DON_VI_VAN_CHUYEN");
            dataGridView1.DataSource = ds.Tables["DON_VI_VAN_CHUYEN"];

            // Bước 4: Đóng kết nối
            con.Close();
        }
    }
}
