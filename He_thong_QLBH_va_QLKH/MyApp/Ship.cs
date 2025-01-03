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
    public partial class Ship : Form
    {
        string sCon = "Data Source=LAPTOP-KG7I3E9P\\MSSQLSERVER01;Initial Catalog=CRM_48K21107;Integrated Security=True";
        public Ship()
        {
            InitializeComponent();
        }

        private void labelPhiShip_Click(object sender, EventArgs e)
        {

        }

        private void labelTTGH_Click(object sender, EventArgs e)
        {
        }

        private void Ngaygiao_Click(object sender, EventArgs e)
        {
        }

        private void Ship_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    // Tải dữ liệu cho dataGridView1 (Ship)
                    string sQuery = "SELECT * FROM SHIP";
                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "SHIP");
                    dataGridView1.DataSource = ds.Tables["SHIP"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình tải dữ liệu: " + ex.Message);
                }
                con.Close();
            }

            // Gọi hàm tải dữ liệu cho ComboBox
            LoadComboBoxMaDH();
            LoadComboBoxMaDVVC();
            txtMaShip.Enabled = false;
        }
        private void LoadComboBoxMaDH()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sQueryMaDH = "SELECT MaDH FROM DON_HANG WHERE LoaiDH = '1'";
                    SqlDataAdapter adapterMaDH = new SqlDataAdapter(sQueryMaDH, con);
                    DataTable dtMaDH = new DataTable();
                    adapterMaDH.Fill(dtMaDH);

                    cbxMaDH.DataSource = dtMaDH;
                    cbxMaDH.DisplayMember = "MaDH";
                    cbxMaDH.ValueMember = "MaDH";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu Mã Đơn Hàng: " + ex.Message);
                }
            }
        }

        // Hàm tải dữ liệu cho cbxMaDVVC
        private void LoadComboBoxMaDVVC()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Tải dữ liệu cho MaDH (chỉ lấy các đơn hàng LoaiDH = '1')
                    string sQueryMaDH = "SELECT MaDH FROM DON_HANG WHERE LoaiDH = '1'";
                    SqlDataAdapter adapterMaDH = new SqlDataAdapter(sQueryMaDH, con);
                    DataTable dtMaDH = new DataTable();
                    adapterMaDH.Fill(dtMaDH);

                    cbxMaDH.DataSource = dtMaDH;
                    cbxMaDH.DisplayMember = "MaDH";
                    cbxMaDH.ValueMember = "MaDH";

                    // Đặt giá trị ban đầu là null (trống)
                    cbxMaDH.SelectedIndex = -1;

                    // Tải dữ liệu cho MaDVVC
                    string sQueryMaDVVC = "SELECT MaDVVC FROM DON_VI_VAN_CHUYEN";
                    SqlDataAdapter adapterMaDVVC = new SqlDataAdapter(sQueryMaDVVC, con);
                    DataTable dtMaDVVC = new DataTable();
                    adapterMaDVVC.Fill(dtMaDVVC);

                    cbxMaDVVC.DataSource = dtMaDVVC;
                    cbxMaDVVC.DisplayMember = "MaDVVC";
                    cbxMaDVVC.ValueMember = "MaDVVC";

                    // Đặt giá trị ban đầu là null (trống)
                    cbxMaDVVC.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu ComboBox: " + ex.Message);
                }
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
            string sMaDH = cbxMaDH.SelectedValue.ToString();    // Mã đơn hàng từ ComboBox
            string sMaDVVC = cbxMaDVVC.SelectedValue.ToString(); // Mã DVVC từ ComboBox
            float fPhiShip = float.Parse(txtPhiShip.Text);      // Phí ship
            string sTrangThai = txtTTGH.Text;             // Trạng thái giao hàng
            DateTime dNgayGiao = dateTimeNgayGiao.Value;            // Ngày giao hàng từ DateTimePicker

            // Bước 3: Tạo command để gọi thủ tục `AddShip`
            string sQuery = "exec AddShip @MaShip, @MaDH, @MaDVVC, @PhiShip, @TrangThai, @NgayGiao, @ret OUTPUT";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số vào command
            cmd.Parameters.AddWithValue("@MaShip", DBNull.Value); // Giá trị này sẽ được set trong thủ tục
            cmd.Parameters.AddWithValue("@MaDH", sMaDH);
            cmd.Parameters.AddWithValue("@MaDVVC", sMaDVVC);
            cmd.Parameters.AddWithValue("@PhiShip", fPhiShip);
            cmd.Parameters.AddWithValue("@TrangThai", sTrangThai);
            cmd.Parameters.AddWithValue("@NgayGiao", dNgayGiao);

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
                    MessageBox.Show("Thêm mới Ship thành công!");

                    // Bước 5: Tải lại dữ liệu lên dataGridView1
                    string sQueryReload = "SELECT * FROM SHIP";
                    SqlDataAdapter adapter = new SqlDataAdapter(sQueryReload, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "SHIP");
                    dataGridView1.DataSource = ds.Tables["SHIP"];

                    // Đặt dòng cuối cùng là dòng được chọn trong dataGridView1 (Ship)
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
                    MessageBox.Show("Thêm mới Ship thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới Ship: " + ex.Message);
            }
            con.Close(); // Đóng kết nối
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin đơn hàng từ dòng được chọn
            txtMaShip.Text = dataGridView1.Rows[e.RowIndex].Cells["MaShip"].Value.ToString();
            cbxMaDH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDH"].Value.ToString();
            dateTimeNgayGiao.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayGiao"].Value);
            cbxMaDVVC.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDVVC"].Value.ToString();
            txtTTGH.Text = dataGridView1.Rows[e.RowIndex].Cells["TrangThaiGiaoHang"].Value.ToString();
            txtPhiShip.Text = dataGridView1.Rows[e.RowIndex].Cells["PhiShip"].Value.ToString();
            txtMaShip.Enabled = false;
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
            string sMaShip = txtMaShip.Text;
            string sMaDH = cbxMaDH.SelectedValue?.ToString();
            string sMaDVVC = cbxMaDVVC.SelectedValue?.ToString();
            string sPhiShip = txtPhiShip.Text;
            string sTrangThai = txtTTGH.Text;
            string sNgayGiao = dateTimeNgayGiao.Value.ToString("yyyy-MM-dd");

            // Câu lệnh SQL UPDATE
            string sQuery = @"UPDATE SHIP 
                      SET MaDH = @MaDH, MaDVVC = @MaDVVC, PhiShip = @PhiShip, 
                          TrangThaiGiaoHang = @TrangThai, NgayGiao = @NgayGiao
                      WHERE MaShip = @MaShip";

            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@MaShip", sMaShip);
            cmd.Parameters.AddWithValue("@MaDH", sMaDH ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@MaDVVC", sMaDVVC ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@PhiShip", sPhiShip);
            cmd.Parameters.AddWithValue("@TrangThai", sTrangThai);
            cmd.Parameters.AddWithValue("@NgayGiao", sNgayGiao);

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

            // Bước 3: Tải lại dữ liệu bảng SHIP vào DataGridView
            string sQueryReload = "SELECT * FROM SHIP";
            SqlDataAdapter adapter = new SqlDataAdapter(sQueryReload, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "SHIP");
            dataGridView1.DataSource = ds.Tables["SHIP"];

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
            string sMaShip = txtMaShip.Text;

            // Câu lệnh SQL DELETE
            string sQuery = @"DELETE FROM SHIP 
                      WHERE MaShip = @MaShip";

            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@MaShip", sMaShip);

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
            string sQueryReload = "SELECT * FROM SHIP";
            SqlDataAdapter adapter = new SqlDataAdapter(sQueryReload, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "SHIP");
            dataGridView1.DataSource = ds.Tables["SHIP"];

            // Bước 4: Đóng kết nối
            con.Close();
        }
        

    }
}
