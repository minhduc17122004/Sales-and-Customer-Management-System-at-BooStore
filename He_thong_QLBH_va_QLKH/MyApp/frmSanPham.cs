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
    public partial class frmSanPham : Form
    {
        string sCon = "Data Source=LAPTOP-KG7I3E9P\\MSSQLSERVER01;Initial Catalog=CRM_48K21107;Integrated Security=True";
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void labelTenSP_Click(object sender, EventArgs e)
        {

        }

        private void labelNgayKT_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSP_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                return; // Kết thúc nếu không kết nối được
            }

            // Bước 2: Chuẩn bị dữ liệu và kiểm tra tính hợp lệ
            string sMaSP = txtMaSP.Text;
            string sTenSP = txtTenSP.Text;
            int iSoLuongSP;
            string sMaGia = txtMaGia.Text;
            float fGiaBan;

            // Kiểm tra giá trị số lượng sản phẩm
            if (!int.TryParse(txtSoluong.Text, out iSoLuongSP) || iSoLuongSP < 0)
            {
                MessageBox.Show("Số lượng sản phẩm không hợp lệ. Vui lòng nhập số nguyên dương.");
                return;
            }

            // Kiểm tra giá trị giá bán
            if (!float.TryParse(txtGiaBan.Text, out fGiaBan) || fGiaBan <= 0)
            {
                MessageBox.Show("Giá bán không hợp lệ. Vui lòng nhập giá trị lớn hơn 0.");
                return;
            }

            // Lấy ngày áp dụng và ngày kết thúc
            string sNgayApDung = datetimeNgayApDung.Value.ToString("yyyy-MM-dd");
            string sNgayKetThuc = datetimeNgayKetThuc.Value.ToString("yyyy-MM-dd");

            // Bước 3: Tạo command và thêm tham số để kiểm tra sản phẩm
            string sQuery = "exec kTraSP @MaSP, @TenSP, @SoLuong_SP, @ret OUTPUT";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@MaSP", sMaSP);
            cmd.Parameters.AddWithValue("@TenSP", sTenSP);
            cmd.Parameters.AddWithValue("@SoLuong_SP", iSoLuongSP);

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
                    MessageBox.Show("Thêm mới sản phẩm thành công!");
                }
                else if (retValue == 0)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại với mã này.");
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

            // Bước 4: Thêm mới thông tin giá thành
            string sQueryGia = "exec kTraGia @MaGia, @MaSP, @GiaBan, @NgayApDung, @NgayKetThuc, @ret OUTPUT";
            SqlCommand cmdGia = new SqlCommand(sQueryGia, con);

            cmdGia.Parameters.AddWithValue("@MaGia", sMaGia);
            cmdGia.Parameters.AddWithValue("@MaSP", sMaSP);
            cmdGia.Parameters.AddWithValue("@GiaBan", fGiaBan);
            cmdGia.Parameters.AddWithValue("@NgayApDung", sNgayApDung);
            cmdGia.Parameters.AddWithValue("@NgayKetThuc", (object)sNgayKetThuc ?? DBNull.Value);

            SqlParameter retParamGia = new SqlParameter("@ret", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmdGia.Parameters.Add(retParamGia);

            try
            {
                cmdGia.ExecuteNonQuery();

                // Lấy giá trị @ret
                int retValueGia = Convert.ToInt32(retParamGia.Value);
                if (retValueGia == 1)
                {
                    MessageBox.Show("Thêm mới giá thành thành công!");
                }
                else if (retValueGia == 0)
                {
                    MessageBox.Show("Mã giá đã tồn tại.");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi không xác định khi thêm giá thành.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới giá thành: " + ex.Message);
            }

            // Hiển thị lại danh sách sản phẩm
            string sQuerry = "SELECT * FROM SAN_PHAM";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "SAN_PHAM");
            dataGridView1.DataSource = ds.Tables["SAN_PHAM"];

            // Hiển thị giá thành của sản phẩm được chọn
            string sQuerySelectGia = "SELECT * FROM GIA_THANH WHERE MaSP = @MaSP";
            SqlCommand cmdGia1 = new SqlCommand(sQuerySelectGia, con);
            cmdGia1.Parameters.AddWithValue("@MaSP", sMaSP); // Tham số mã sản phẩm được chọn

            SqlDataAdapter adapterGia = new SqlDataAdapter(cmdGia1);
            DataSet dsGia = new DataSet();
            adapterGia.Fill(dsGia, "GIA_THANH");

            dataGridView2.DataSource = dsGia.Tables["GIA_THANH"];

            // Đóng kết nối
            con.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu dòng được chọn hợp lệ
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["MaSP"].Value != null)
            {
                // Lấy thông tin sản phẩm từ dòng được chọn
                txtMaSP.Text = dataGridView1.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dataGridView1.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
                txtSoluong.Text = dataGridView1.Rows[e.RowIndex].Cells["SoLuong_SP"].Value.ToString();
                txtMaSP.Enabled = false; // Khóa không cho chỉnh sửa mã sản phẩm

                // Lấy mã sản phẩm để truy vấn giá thành
                string selectedMaSP = txtMaSP.Text;

                // Kết nối cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    try
                    {
                        con.Open();

                        // Truy vấn các mã giá liên quan đến sản phẩm
                        string sQuery = "SELECT * FROM GIA_THANH WHERE MaSP = @MaSP";
                        SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                        adapter.SelectCommand.Parameters.AddWithValue("@MaSP", selectedMaSP);

                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "GIA_THANH");

                        // Hiển thị dữ liệu trong dataGridView2
                        if (ds.Tables["GIA_THANH"].Rows.Count > 0)
                        {
                            dataGridView2.DataSource = ds.Tables["GIA_THANH"];

                            // Hiển thị thông tin giá thành vào các TextBox
                            DataRow row = ds.Tables["GIA_THANH"].Rows[0];
                            txtMaGia.Text = row["MaGia"].ToString();
                            txtGiaBan.Text = row["GiaBan"].ToString();
                            datetimeNgayApDung.Value = Convert.ToDateTime(row["NgayApDung"]);
                            datetimeNgayKetThuc.Value = row["NgayKetThuc"] != DBNull.Value
                                ? Convert.ToDateTime(row["NgayKetThuc"])
                                : DateTime.Now;
                        }
                        else
                        {
                            // Không tìm thấy giá thành nào
                            dataGridView2.DataSource = null;
                            txtMaGia.Text = string.Empty;
                            txtGiaBan.Text = string.Empty;
                            datetimeNgayApDung.Value = DateTime.Now;
                            datetimeNgayKetThuc.Value = DateTime.Now;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xảy ra lỗi trong quá trình tải dữ liệu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng hợp lệ.");
            }
        }


        private void buttonSua_Click(object sender, EventArgs e)
        {
            // Bước 1: Kết nối CSDL
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                return; // Thoát nếu không kết nối được
            }

            // Bước 2: Lấy giá trị từ giao diện
            string sMaSP = txtMaSP.Text;
            string sTenSP = txtTenSP.Text;
            int iSoLuongSP;
            string sMaGia = txtMaGia.Text;
            float fGiaBan;
            string sNgayApDung = datetimeNgayApDung.Value.ToString("yyyy-MM-dd");
            string sNgayKetThuc = datetimeNgayKetThuc.Value.ToString("yyyy-MM-dd");

            // Kiểm tra tính hợp lệ của số lượng sản phẩm
            if (!int.TryParse(txtSoluong.Text, out iSoLuongSP) || iSoLuongSP < 0)
            {
                MessageBox.Show("Số lượng sản phẩm không hợp lệ. Vui lòng nhập số nguyên dương.");
                return;
            }

            // Kiểm tra tính hợp lệ của giá bán
            if (!float.TryParse(txtGiaBan.Text, out fGiaBan) || fGiaBan <= 0)
            {
                MessageBox.Show("Giá bán không hợp lệ. Vui lòng nhập giá trị lớn hơn 0.");
                return;
            }

            // Bước 3: Cập nhật bảng SAN_PHAM
            string sQuerySP = "UPDATE SAN_PHAM SET TenSP = @TenSP, SoLuong_SP = @SoLuong_SP WHERE MaSP = @MaSP";
            SqlCommand cmdSP = new SqlCommand(sQuerySP, con);

            // Thêm các tham số vào câu lệnh SQL
            cmdSP.Parameters.AddWithValue("@MaSP", sMaSP);
            cmdSP.Parameters.AddWithValue("@TenSP", sTenSP);
            cmdSP.Parameters.AddWithValue("@SoLuong_SP", iSoLuongSP);

            try
            {
                // Thực thi lệnh cập nhật bảng SAN_PHAM
                int rowsAffectedSP = cmdSP.ExecuteNonQuery();
                if (rowsAffectedSP > 0)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm với mã đã nhập.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật sản phẩm: " + ex.Message);
            }

            // Bước 4: Cập nhật bảng GIÁ_THÀNH
            string sQueryGia = @"
        UPDATE GIA_THANH 
        SET GiaBan = @GiaBan, NgayApDung = @NgayApDung, NgayKetThuc = @NgayKetThuc 
        WHERE MaGia = @MaGia AND MaSP = @MaSP";
            SqlCommand cmdGia = new SqlCommand(sQueryGia, con);

            // Thêm các tham số vào câu lệnh SQL
            cmdGia.Parameters.AddWithValue("@MaGia", sMaGia);
            cmdGia.Parameters.AddWithValue("@MaSP", sMaSP);
            cmdGia.Parameters.AddWithValue("@GiaBan", fGiaBan);
            cmdGia.Parameters.AddWithValue("@NgayApDung", sNgayApDung);
            cmdGia.Parameters.AddWithValue("@NgayKetThuc", (object)sNgayKetThuc ?? DBNull.Value);

            try
            {
                // Thực thi lệnh cập nhật bảng GIÁ_THÀNH
                int rowsAffectedGia = cmdGia.ExecuteNonQuery();
                if (rowsAffectedGia > 0)
                {
                    MessageBox.Show("Cập nhật giá thành thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy giá thành với mã giá và sản phẩm tương ứng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật giá thành: " + ex.Message);
            }

            // Bước 5: Hiển thị lại danh sách sản phẩm
            string sQuerySelect = "SELECT * FROM SAN_PHAM";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerySelect, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "SAN_PHAM");

            dataGridView1.DataSource = ds.Tables["SAN_PHAM"];

            // Hiển thị giá thành của sản phẩm được chọn
            string sQuerySelectGia = "SELECT * FROM GIA_THANH WHERE MaSP = @MaSP";
            SqlCommand cmdGia1 = new SqlCommand(sQuerySelectGia, con);
            cmdGia1.Parameters.AddWithValue("@MaSP", sMaSP); // Tham số mã sản phẩm được chọn

            SqlDataAdapter adapterGia = new SqlDataAdapter(cmdGia1);
            DataSet dsGia = new DataSet();
            adapterGia.Fill(dsGia, "GIA_THANH");

            dataGridView2.DataSource = dsGia.Tables["GIA_THANH"];

            // Đóng kết nối
            con.Close();
        }


        private void frmSanPham_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Tải dữ liệu cho dataGridView1 (SAN_PHAM)
                    string sQuery = "SELECT * FROM SAN_PHAM";
                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "SAN_PHAM");
                    dataGridView1.DataSource = ds.Tables["SAN_PHAM"];

                    // Đảm bảo dataGridView2 trống lúc ban đầu
                    dataGridView2.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình tải dữ liệu: " + ex.Message);
                }
                con.Close(); //bước 3
            }

            // Gắn sự kiện CellClick cho dataGridView1
            dataGridView1.CellClick += dataGridView1_CellClick;



        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắc chắn xoá không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
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

                // Bước 2: Lấy giá trị từ giao diện
                string sMaSP = txtMaSP.Text;

                // Câu lệnh SQL để xóa sản phẩm
                string sQuery = "DELETE FROM SAN_PHAM WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaSP", sMaSP);

                try
                {
                    // Thực thi lệnh xóa
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm với mã đã nhập.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xóa: " + ex.Message);
                }

                // Bước 3: Hiển thị lại danh sách sản phẩm
                string sQuerySelect = "SELECT * FROM SAN_PHAM";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuerySelect, con);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "SAN_PHAM");

                dataGridView1.DataSource = ds.Tables["SAN_PHAM"];

                // Hiển thị giá thành của sản phẩm được chọn
                string sQuerySelectGia = "SELECT * FROM GIA_THANH WHERE MaSP = @MaSP";
                SqlCommand cmdGia1 = new SqlCommand(sQuerySelectGia, con);
                cmdGia1.Parameters.AddWithValue("@MaSP", sMaSP); // Tham số mã sản phẩm được chọn

                SqlDataAdapter adapterGia = new SqlDataAdapter(cmdGia1);
                DataSet dsGia = new DataSet();
                adapterGia.Fill(dsGia, "GIA_THANH");

                dataGridView2.DataSource = dsGia.Tables["GIA_THANH"];

                // Đóng kết nối
                con.Close();
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGia.Text = dataGridView2.Rows[e.RowIndex].Cells["MaGia"].Value.ToString();
            txtMaSP.Text = dataGridView2.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
            txtGiaBan.Text = dataGridView2.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString();
            datetimeNgayApDung.Value = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["NgayApDung"].Value);
            datetimeNgayKetThuc.Value = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["NgayKetThuc"].Value);
            txtMaSP.Enabled = false;

        }

        private void buttonTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(ofd.FileName);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemGia_Click(object sender, EventArgs e)
        {

        }
    }
}

