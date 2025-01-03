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
    public partial class frmKhieuNai : Form
    {
        string sCon = "Data Source=LAPTOP-KG7I3E9P\\MSSQLSERVER01;Initial Catalog=CRM_48K21107;Integrated Security=True";
        public frmKhieuNai()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmKhieuNai_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    // Tải dữ liệu cho dataGridView1 
                    string sQuery = "SELECT * FROM PHIEU_KHIEU_NAI";
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
                LoadComboBoxMaDH();
                LoadComboBoxLoaiKN();
                LoadComboBoxTrangThaiKN();
                cboMaDH.SelectedIndexChanged += cboMaDH_SelectedIndexChanged;
                txtMaKN.Enabled = false;
            }
        }
        private void cboMaDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy mã đơn hàng từ ComboBox
            string selectedMaDH = cboMaDH.SelectedValue?.ToString();

            if (!string.IsNullOrEmpty(selectedMaDH))
            {
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    try
                    {
                        con.Open();

                        // Câu lệnh SQL để lấy MaKH tương ứng với MaDH
                        string sQuery = @"
                SELECT MaKH 
                FROM DON_HANG
                WHERE MaDH = @MaDH";

                        SqlCommand cmd = new SqlCommand(sQuery, con);
                        cmd.Parameters.AddWithValue("@MaDH", selectedMaDH);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Hiển thị MaKH vào TextBox txtMaKH
                            txtMaKH.Text = reader["MaKH"].ToString();
                        }
                        else
                        {
                            // Nếu không tìm thấy MaKH, xóa TextBox
                            txtMaKH.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải mã khách hàng: " + ex.Message);
                    }
                }
            }
            else
            {
                // Nếu không có mã đơn hàng nào được chọn
                txtMaKH.Text = "";
            }
        }
        private void LoadComboBoxMaDH()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Lấy danh sách MaDH từ bảng DON_HANG
                    string sQuery = "SELECT MaDH FROM DON_HANG";

                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Thêm dòng trống vào DataTable để hiển thị giá trị "null"
                    DataRow emptyRow = dt.NewRow();
                    emptyRow["MaDH"] = DBNull.Value; // Dòng trống
                    dt.Rows.InsertAt(emptyRow, 0); // Thêm vào đầu bảng

                    // Gán dữ liệu vào ComboBox
                    cboMaDH.DataSource = dt;
                    cboMaDH.DisplayMember = "MaDH"; // Hiển thị MaDH
                    cboMaDH.ValueMember = "MaDH";   // Giá trị MaDH

                    // Thiết lập ComboBox mặc định là trống
                    cboMaDH.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách mã đơn hàng: " + ex.Message);
                }
            }
        }
        private void LoadComboBoxLoaiKN()
        {
            // Tạo một DataTable để lưu danh sách loại khiếu nại
            DataTable dtLoaiKN = new DataTable();
            dtLoaiKN.Columns.Add("Value", typeof(int));
            dtLoaiKN.Columns.Add("Display", typeof(string));

            // Thêm các giá trị 1, 2, 3 vào ComboBox
            dtLoaiKN.Rows.Add(1, "1");
            dtLoaiKN.Rows.Add(2, "2");
            dtLoaiKN.Rows.Add(3, "3");

            // Gán dữ liệu cho ComboBox
            cboLoaiKN.DataSource = dtLoaiKN;
            cboLoaiKN.DisplayMember = "Display"; // Giá trị hiển thị
            cboLoaiKN.ValueMember = "Value";     // Giá trị thực tế

            // Thiết lập ComboBox mặc định là trống
            cboLoaiKN.SelectedIndex = -1;
        }
        private void LoadComboBoxTrangThaiKN()
        {
            // Tạo một DataTable để lưu danh sách loại khiếu nại
            DataTable dtTTKN = new DataTable();
            dtTTKN.Columns.Add("Value", typeof(int));
            dtTTKN.Columns.Add("Display", typeof(string));

            // Thêm các giá trị 0,1 vào ComboBox
            dtTTKN.Rows.Add(1, "0");
            dtTTKN.Rows.Add(2, "1");


            // Gán dữ liệu cho ComboBox
            cboTTKN.DataSource = dtTTKN;
            cboTTKN.DisplayMember = "Display"; // Giá trị hiển thị
            cboTTKN.ValueMember = "Value";     // Giá trị thực tế

            // Thiết lập ComboBox mặc định là trống
            cboTTKN.SelectedIndex = -1;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin đơn hàng từ dòng được chọn
            txtMaKN.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKN"].Value.ToString();
            txtMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            cboMaDH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDH"].Value.ToString();
            dateTimeNgayKN.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayKN"].Value);
            cboLoaiKN.Text = dataGridView1.Rows[e.RowIndex].Cells["LoaiKN"].Value.ToString();
            cboTTKN.Text = dataGridView1.Rows[e.RowIndex].Cells["TrangThaiKN"].Value.ToString();
            txtMaKN.Enabled = false;
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
            string sMaKH = txtMaKH.Text;             // Mã khách hàng
            string sMaDH = cboMaDH.SelectedValue?.ToString(); // Mã đơn hàng
            string sNgayKN = dateTimeNgayKN.Value.ToString("yyyy-MM-dd"); // Ngày khiếu nại
            string sLoaiKN = cboLoaiKN.SelectedValue?.ToString();         // Loại khiếu nại
            string sTrangThaiKN = cboTTKN.SelectedValue?.ToString(); // Trạng thái khiếu nại

            // Bước 3: Tạo command để gọi thủ tục AddPhieuKN
            string sQuery = "exec AddPhieuKN @MaKH, @MaDH, @NgayKN, @LoaiKN, @TrangThaiKN, @ret OUTPUT";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số vào command
            cmd.Parameters.AddWithValue("@MaKH", sMaKH);
            cmd.Parameters.AddWithValue("@MaDH", sMaDH);
            cmd.Parameters.AddWithValue("@NgayKN", sNgayKN);
            cmd.Parameters.AddWithValue("@LoaiKN", sLoaiKN);
            cmd.Parameters.AddWithValue("@TrangThaiKN", sTrangThaiKN);

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
                    MessageBox.Show("Thêm mới phiếu khiếu nại thành công!");

                    // Bước 5: Tải lại dữ liệu lên dataGridView2
                    string sQueryReload = "SELECT * FROM PHIEU_KHIEU_NAI";
                    SqlDataAdapter adapter = new SqlDataAdapter(sQueryReload, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "PHIEU_KHIEU_NAI");
                    dataGridView1.DataSource = ds.Tables["PHIEU_KHIEU_NAI"];

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
                    MessageBox.Show("Thêm mới phiếu khiếu nại thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới phiếu khiếu nại: " + ex.Message);
            }

            // Bước 6: Đóng kết nối
            con.Close();
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
            string sMaKN = txtMaKN.Text;                       // Mã khiếu nại
            string sMaKH = txtMaKH.Text;                       // Mã khách hàng
            string sMaDH = cboMaDH.Text;  // Mã đơn hàng
            string sNgayKN = dateTimeNgayKN.Value.ToString("yyyy-MM-dd"); // Ngày khiếu nại
            string sLoaiKN = cboLoaiKN.Text;         // Loại khiếu nại
            string sTrangThaiKN = cboTTKN.Text; // Trạng thái khiếu nại

            // Câu lệnh SQL UPDATE
            string sQuery = @"UPDATE PHIEU_KHIEU_NAI
                      SET MaKH = @MaKH, MaDH = @MaDH, NgayKN = @NgayKN, 
                          LoaiKN = @LoaiKN, TrangThaiKN = @TrangThaiKN
                      WHERE MaKN = @MaKN";

            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@MaKN", sMaKN);
            cmd.Parameters.AddWithValue("@MaKH", sMaKH);
            cmd.Parameters.AddWithValue("@MaDH", sMaDH);
            cmd.Parameters.AddWithValue("@NgayKN", sNgayKN);
            cmd.Parameters.AddWithValue("@LoaiKN", sLoaiKN);
            cmd.Parameters.AddWithValue("@TrangThaiKN", sTrangThaiKN);

            try
            {
                // Thực thi lệnh UPDATE
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật phiếu khiếu nại thành công!");
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

            // Bước 3: Tải lại dữ liệu bảng PHIEU_KHIEU_NAI vào DataGridView
            string sQueryReload = "SELECT * FROM PHIEU_KHIEU_NAI";
            SqlDataAdapter adapter = new SqlDataAdapter(sQueryReload, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "PHIEU_KHIEU_NAI");
            dataGridView1.DataSource = ds.Tables["PHIEU_KHIEU_NAI"];

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
            string sMaKN = txtMaKN.Text;

            // Câu lệnh SQL DELETE
            string sQuery = @"DELETE FROM PHIEU_KHIEU_NAI 
                      WHERE MaKN = @MaKN";

            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@MaKN", sMaKN);

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
            string sQueryReload = "SELECT * FROM PHIEU_KHIEU_NAI";
            SqlDataAdapter adapter = new SqlDataAdapter(sQueryReload, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "PHIEU_KHIEU_NAI");
            dataGridView1.DataSource = ds.Tables["PHIEU_KHIEU_NAI"];

            // Bước 4: Đóng kết nối
            con.Close();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false; // Không phải form cấp cao
            childForm.FormBorderStyle = FormBorderStyle.None; // Bỏ viền form
            childForm.Dock = DockStyle.Fill; // Điền đầy form cha

            this.Controls.Add(childForm); // Thêm form con vào frmDonHang
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void chiTiếtPhiếuKhiếuNạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChiTietPKN());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

