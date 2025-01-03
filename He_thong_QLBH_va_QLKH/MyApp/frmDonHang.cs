using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace MyApp
{
    public partial class frmDonHang : Form
    {
        string sCon = "Data Source=LAPTOP-KG7I3E9P\\MSSQLSERVER01;Initial Catalog=CRM_48K21107;Integrated Security=True";
        public frmDonHang()
        {
            InitializeComponent();
        }

        private void maKh_Click(object sender, EventArgs e)
        {

        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    // Tải dữ liệu cho dataGirdView1 (Don_hang)
                    string sQuery = "SELECT * FROM DON_HANG";
                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "DON_HANG");
                    dataGridView1.DataSource = ds.Tables["DON_HANG"];
                    // Đảm bảo dataGridView2 trống lúc ban đầu
                    dataGridView2.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình tải dữ liệu: " + ex.Message);
                }
                con.Close();
            }

            // Gắn sự kiện CellClick cho dataGridView1
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Gọi hàm tải dữ liệu cho ComboBox
            LoadComboBoxData();
            cboTenSP.SelectedIndexChanged += cboTenSP_SelectedIndexChanged;
            LoadComboBoxMaKH();
            LoadComboBoxMaNV();


            // Hoặc nếu muốn không hiển thị trạng thái chỉnh sửa
            txtMaDH.Enabled = false;
            txtTongTien.Enabled = false;
        }

        private void LoadComboBoxData()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Tải dữ liệu Tên sản phẩm
                    string sQuerySP = "SELECT MaSP, TenSP FROM SAN_PHAM";
                    SqlDataAdapter adapterSP = new SqlDataAdapter(sQuerySP, con);
                    DataTable dtSP = new DataTable();
                    adapterSP.Fill(dtSP);
                    cboTenSP.DataSource = dtSP;
                    cboTenSP.DisplayMember = "TenSP";
                    cboTenSP.ValueMember = "MaSP";

                    // Tải dữ liệu Mã Giá
                    string sQueryGia = "SELECT MaGia FROM GIA_THANH ";
                    SqlDataAdapter adapterGia = new SqlDataAdapter(sQueryGia, con);
                    DataTable dtGia = new DataTable();
                    adapterGia.Fill(dtGia);
                    cboMaGia.DataSource = dtGia;
                    cboMaGia.DisplayMember = "MaGia";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu ComboBox: " + ex.Message);
                }
            }
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Kiểm tra MaSP có tồn tại trong bảng SAN_PHAM hay không
                    string checkQuery = "SELECT COUNT(1) FROM SAN_PHAM WHERE MaSP = @MaSP";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());

                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists == 0)
                    {
                        MessageBox.Show("Mã sản phẩm không tồn tại trong bảng Sản Phẩm. Vui lòng kiểm tra lại.");
                        return; // Thoát nếu không tồn tại
                    }

                    // Chuẩn bị câu lệnh INSERT
                    string sQuery = @"
                INSERT INTO CHI_TIET_DON_HANG (MaDH, MaSP, MaGia, SoLuong)
                VALUES (@MaDH, @MaSP, @MaGia, @SoLuong)";

                    SqlCommand cmd = new SqlCommand(sQuery, con);

                    // Thêm tham số
                    cmd.Parameters.AddWithValue("@MaDH", txtMaDH.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaGia", cboMaGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@SoLuong", numSoLuong.Value);

                    // Thực thi lệnh INSERT
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm chi tiết đơn hàng thành công.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi thêm chi tiết đơn hàng: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                }
                // đổ dữ liệu về
                string sQuerry = "select MaDH, MaSP, MaGia, SoLuong from CHI_TIET_DON_HANG WHERE MaDH = @maDH";
                SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
                cmdFetch.Parameters.AddWithValue("@maDH", txtMaDH.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "CHI_TIET_DON_HANG");

                dataGridView2.DataSource = ds.Tables["CHI_TIET_DON_HANG"];

                string sQuerry2 = "select * from DON_HANG";
                SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

                DataSet ds2 = new DataSet();

                adapter2.Fill(ds2, "DON_HANG");

                dataGridView1.DataSource = ds2.Tables["DON_HANG"];
                // Hiển thị lại danh sách đơn hàng
                string sQuerySelectDH = "SELECT * FROM DON_HANG";
                SqlDataAdapter adapterDH = new SqlDataAdapter(sQuerySelectDH, con);

                DataSet dsDH = new DataSet();
                adapterDH.Fill(dsDH, "DON_HANG");

                dataGridView1.DataSource = dsDH.Tables["DON_HANG"];
                // không thay đổi vị trí click
                string tongTien = dsDH.Tables["DON_HANG"].Rows.Cast<DataRow>()
                 .Where(row => row["MaDH"].ToString() == txtMaDH.Text)
                 .Sum(row => Convert.ToDecimal(row["TongTien"]))
                 .ToString();
                txtTongTien.Text = tongTien;
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.ClearSelection();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["MaDH"].Value.ToString() == txtMaDH.Text)
                        {
                            row.Selected = true; // Đặt dòng được chọn
                            break;
                        }
                    }
                }

                // Đóng kết nối
                con.Close();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["MaDH"].Value != null)
            {
                // Lấy thông tin đơn hàng từ dòng được chọn
                txtMaDH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDH"].Value.ToString();
                txtMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                datetimeNgayMua.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayMua"].Value);
                txtLoaiDH.Text = dataGridView1.Rows[e.RowIndex].Cells["LoaiDH"].Value.ToString();
                txtTongTien.Text = dataGridView1.Rows[e.RowIndex].Cells["TongTien"].Value.ToString();
                txtMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();

                string selectedMaDH = txtMaDH.Text;

                // Hiển thị chi tiết đơn hàng liên quan
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    try
                    {
                        con.Open();

                        string sQuery = @"
                    SELECT ct.MaSP, sp.TenSP, ct.MaGia, gt.GiaBan, ct.SoLuong
                    FROM CHI_TIET_DON_HANG ct
                    JOIN SAN_PHAM sp ON ct.MaSP = sp.MaSP
                    JOIN GIA_THANH gt ON ct.MaGia = gt.MaGia
                    WHERE ct.MaDH = @MaDH";

                        SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                        adapter.SelectCommand.Parameters.AddWithValue("@MaDH", selectedMaDH);

                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "CHI_TIET_DON_HANG");

                        // Hiển thị dữ liệu chi tiết vào dataGridView2
                        if (ds.Tables["CHI_TIET_DON_HANG"].Rows.Count > 0)
                        {
                            dataGridView2.DataSource = ds.Tables["CHI_TIET_DON_HANG"];

                            // hiển thị thông tin của bảng chi tiết đơn hàng trên box
                            DataRow row = ds.Tables["CHI_TIET_DON_HANG"].Rows[0];
                            txtMaSP.Text = row["MaSP"].ToString();
                            cboTenSP.Text = row["TenSP"].ToString();
                            cboMaGia.Text = row["MaGia"].ToString();
                            txtGiaBan.Text = row["GiaBan"].ToString();
                            numSoLuong.Text = row["SoLuong"].ToString();
                            txtMaDH.Enabled = false;
                            txtMaSP.Enabled = false;
                            txtGiaBan.Enabled = false;
                            txtTongTien.Enabled = false;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải chi tiết đơn hàng: " + ex.Message);
                    }
                }
            }
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
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
                return; // Kết thúc nếu không kết nối được
            }

            // Bước 2: Chuẩn bị dữ liệu và kiểm tra tính hợp lệ
            string sMaDH = txtMaDH.Text.Trim();
            string sMaKH = txtMaKH.Text.Trim();
            string sMaNV = txtMaNV.Text.Trim();
            string sLoaiDH = txtLoaiDH.Text.Trim();
            float fTongTien = 0;


            // Kiểm tra ngày mua
            string sNgayMua = datetimeNgayMua.Value.ToString("yyyy-MM-dd");

            // Bước 3: Tạo command và thêm tham số để kiểm tra và thêm đơn hàng
            string sQuery = "exec ThemDonHang @MaDH, @MaKH, @MaNV, @NgayMua, @TongTien, @LoaiDH, @ret OUTPUT";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@MaDH", sMaDH);
            cmd.Parameters.AddWithValue("@MaKH", sMaKH);
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            cmd.Parameters.AddWithValue("@NgayMua", sNgayMua);
            cmd.Parameters.AddWithValue("@TongTien", fTongTien);
            cmd.Parameters.AddWithValue("@LoaiDH", sLoaiDH);

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
                    MessageBox.Show("Thêm mới đơn hàng thành công!");
                }
                else if (retValue == 0)
                {
                    MessageBox.Show("Thêm mới đơn hàng không thành công.");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi không xác định.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới đơn hàng: " + ex.Message);
            }
            // Hiển thị lại danh sách đơn hàng
            string sQuerySelectDH = "SELECT * FROM DON_HANG";
            SqlDataAdapter adapterDH = new SqlDataAdapter(sQuerySelectDH, con);
            DataSet dsDH = new DataSet();
            adapterDH.Fill(dsDH, "DON_HANG");

            dataGridView1.DataSource = dsDH.Tables["DON_HANG"];

            // Cập nhật Tổng tiền
            txtTongTien.Text = dsDH.Tables["DON_HANG"]
                .AsEnumerable()
                .Sum(row => Convert.ToDecimal(row["TongTien"])).ToString();

            // Đặt dòng cuối cùng là dòng được chọn
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ClearSelection();
                int lastRowIndex = dataGridView1.Rows.Count - 2; // Lấy chỉ số dòng cuối
                dataGridView1.Rows[lastRowIndex].Selected = true; // Đặt dòng cuối được chọn
                dataGridView1.FirstDisplayedScrollingRowIndex = lastRowIndex; // Cuộn đến dòng cuối
            }
            // Đóng kết nối
            con.Close();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult;

            // Kiểm tra nếu chọn dòng trong bảng chi tiết đơn hàng
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string maSP = dataGridView2.SelectedRows[0].Cells["MaSP"].Value.ToString();
                confirmResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa {maSP} khỏi đơn hàng không?",
                    "Xác nhận xóa chi tiết đơn hàng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
            }
            // Kiểm tra nếu chọn dòng trong bảng đơn hàng
            else if (dataGridView1.SelectedRows.Count > 0)
            {
                string maDH = dataGridView1.SelectedRows[0].Cells["MaDH"].Value.ToString();
                confirmResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa đơn hàng {maDH} này không?",
                    "Xác nhận xóa đơn hàng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng hoặc chi tiết đơn hàng cần xóa.");
                return; // Không làm gì thêm nếu không chọn dòng nào
            }

            // Nếu người dùng chọn "Có"
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    try
                    {
                        con.Open();
                        // Nếu chọn xóa chi tiết đơn hàng
                        if (dataGridView2.SelectedRows.Count > 0)
                        {
                            string sQueryChiTiet = "DELETE FROM CHI_TIET_DON_HANG WHERE MaSP = @MaSP";
                            SqlCommand cmdChiTiet = new SqlCommand(sQueryChiTiet, con);
                            cmdChiTiet.Parameters.AddWithValue("@MaSP", dataGridView2.SelectedRows[0].Cells["MaSP"].Value.ToString());
                            cmdChiTiet.ExecuteNonQuery();
                            MessageBox.Show("Xóa chi tiết đơn hàng thành công.");
                        }
                        // Nếu chọn xóa đơn hàng và các chi tiết liên quan
                        else if (dataGridView1.SelectedRows.Count > 0)
                        {
                            string sQueryChiTiet = "DELETE FROM CHI_TIET_DON_HANG WHERE MaDH = @MaDH";
                            SqlCommand cmdChiTiet = new SqlCommand(sQueryChiTiet, con);
                            cmdChiTiet.Parameters.AddWithValue("@MaDH", dataGridView1.SelectedRows[0].Cells["MaDH"].Value.ToString());
                            cmdChiTiet.ExecuteNonQuery();

                            string sQueryDonHang = "DELETE FROM DON_HANG WHERE MaDH = @MaDH";
                            SqlCommand cmdDonHang = new SqlCommand(sQueryDonHang, con);
                            cmdDonHang.Parameters.AddWithValue("@MaDH", dataGridView1.SelectedRows[0].Cells["MaDH"].Value.ToString());
                            cmdDonHang.ExecuteNonQuery();

                            MessageBox.Show("Xóa đơn hàng và chi tiết đơn hàng thành công.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // đổ dữ liệu về
                    string sQuerry = "select MaDH, MaSP, MaGia, SoLuong from CHI_TIET_DON_HANG WHERE MaDH = @maDH";
                    SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
                    cmdFetch.Parameters.AddWithValue("@maDH", txtMaDH.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

                    DataSet ds = new DataSet();

                    adapter.Fill(ds, "CHI_TIET_DON_HANG");

                    dataGridView2.DataSource = ds.Tables["CHI_TIET_DON_HANG"];

                    string sQuerry2 = "select * from DON_HANG";
                    SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

                    DataSet ds2 = new DataSet();

                    adapter2.Fill(ds2, "DON_HANG");

                    dataGridView1.DataSource = ds2.Tables["DON_HANG"];
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dataGridView2.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
            //cboTenSP.Text = dataGridView2.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
            cboMaGia.Text = dataGridView2.Rows[e.RowIndex].Cells["MaGia"].Value.ToString();
            //txtGiaBan.Text = dataGridView2.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString();
            numSoLuong.Text = dataGridView2.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            txtMaSP.Enabled = false;
            txtGiaBan.Enabled = false;
            txtTongTien.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
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
            string sMaDH = txtMaDH.Text.Trim();
            string sMaKH = txtMaKH.Text.Trim();
            string sMaNV = txtMaNV.Text.Trim();
            string sLoaiDH = txtLoaiDH.Text.Trim();
            DateTime dtNgayMua = datetimeNgayMua.Value;

            string queryDonHang = @"
            UPDATE DON_HANG 
            SET MaKH = @MaKH, MaNV = @MaNV, LoaiDH = @LoaiDH, NgayMua = @NgayMua
            WHERE MaDH = @MaDH";

            // Cập nhật thông tin đơn hàng
            SqlCommand cmdDonHang = new SqlCommand(queryDonHang, con);
            cmdDonHang.Parameters.AddWithValue("@MaDH", sMaDH);
            cmdDonHang.Parameters.AddWithValue("@MaKH", sMaKH);
            cmdDonHang.Parameters.AddWithValue("@MaNV", sMaNV);
            cmdDonHang.Parameters.AddWithValue("@LoaiDH", sLoaiDH);
            cmdDonHang.Parameters.AddWithValue("@NgayMua", dtNgayMua);

            try
            {
                // Thực thi lệnh cập nhật bảng DON_HANG
                int rowsAffectedDH = cmdDonHang.ExecuteNonQuery();
                if (rowsAffectedDH > 0)
                {
                    MessageBox.Show("Cập nhật đơn hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn hàng với mã đã nhập.");
                    con.Close();
                    return; // Thoát nếu không tìm thấy đơn hàng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật đơn hàng: " + ex.Message);
                con.Close();
                return; // Thoát nếu có lỗi
            }

            // Bước 3: Cập nhật chi tiết đơn hàng từ NumericUpDown
            try
            {
                string maSP = txtMaSP.Text.Trim(); // Lấy mã sản phẩm từ giao diện
                string maGia = cboMaGia.Text.Trim();
                string tenSP = cboTenSP.Text.Trim();
                int soLuong = (int)numSoLuong.Value; // Lấy số lượng từ NumericUpDown

                if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(maGia))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin chi tiết đơn hàng.");
                }
                else
                {
                    string queryChiTietDonHang = @"
            UPDATE CHI_TIET_DON_HANG 
            SET MaGia = @MaGia, SoLuong = @SoLuong
            WHERE MaDH = @MaDH AND MaSP = @MaSP";

                    using (SqlCommand cmdChiTiet = new SqlCommand(queryChiTietDonHang, con))
                    {
                        cmdChiTiet.Parameters.AddWithValue("@MaDH", sMaDH);
                        cmdChiTiet.Parameters.AddWithValue("@MaSP", maSP);
                        cmdChiTiet.Parameters.AddWithValue("@TenSP", tenSP);
                        cmdChiTiet.Parameters.AddWithValue("@MaGia", maGia);
                        cmdChiTiet.Parameters.AddWithValue("@SoLuong", soLuong);

                        int rowsAffectedCT = cmdChiTiet.ExecuteNonQuery();
                        if (rowsAffectedCT > 0)
                        {
                            MessageBox.Show("Cập nhật chi tiết đơn hàng thành công!");
                        }
                        else
                        {
                            MessageBox.Show($"Không tìm thấy sản phẩm với MaSP: {maSP} trong đơn hàng.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật chi tiết đơn hàng: {ex.Message}");
            }

            // đổ dữ liệu về
            string sQuerry = "select MaDH, MaSP, MaGia, SoLuong from CHI_TIET_DON_HANG WHERE MaDH = @maDH";
            SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
            cmdFetch.Parameters.AddWithValue("@maDH", txtMaDH.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "CHI_TIET_DON_HANG");

            dataGridView2.DataSource = ds.Tables["CHI_TIET_DON_HANG"];

            string sQuerry2 = "select * from DON_HANG";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

            DataSet ds2 = new DataSet();

            adapter2.Fill(ds2, "DON_HANG");

            dataGridView1.DataSource = ds2.Tables["DON_HANG"];




            // không thay đổi vị trí click
            string tongTien = ds2.Tables["DON_HANG"].Rows.Cast<DataRow>()
             .Where(row => row["MaDH"].ToString() == txtMaDH.Text)
             .Sum(row => Convert.ToDecimal(row["TongTien"]))
             .ToString();
            txtTongTien.Text = tongTien;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ClearSelection();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["MaDH"].Value.ToString() == txtMaDH.Text)
                    {
                        row.Selected = true; // Đặt dòng được chọn
                        break;
                    }
                }
            }

            con.Close();
        }



        private void cboTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy mã sản phẩm từ ComboBox
            string selectedMaSP = cboTenSP.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(selectedMaSP))
            {
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    try
                    {
                        con.Open();

                        // Lấy mã giá và giá bán từ bảng GIA_THANH
                        string sQuery = @"
                    SELECT TOP 1 MaGia, GiaBan
                    FROM GIA_THANH
                    WHERE MaSP = @MaSP
                    ORDER BY NgayApDung DESC"; // Lấy giá mới nhất

                        SqlCommand cmd = new SqlCommand(sQuery, con);
                        cmd.Parameters.AddWithValue("@MaSP", selectedMaSP);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtMaSP.Text = selectedMaSP; // Hiển thị mã sản phẩm
                            cboMaGia.Text = reader["MaGia"].ToString(); // Hiển thị mã giá
                            txtGiaBan.Text = reader["GiaBan"].ToString(); // Hiển thị giá bán
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải thông tin sản phẩm: " + ex.Message);
                    }
                }
            }
        }
        private void LoadComboBoxMaKH()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Câu lệnh SQL để lấy danh sách mã khách hàng
                    string query = "SELECT MaKH FROM KHACH_HANG";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Thêm một hàng trống vào DataTable
                    DataRow emptyRow = dt.NewRow();
                    emptyRow["MaKH"] = DBNull.Value; // Hoặc để chuỗi rỗng: ""
                    dt.Rows.InsertAt(emptyRow, 0); // Thêm vào vị trí đầu tiên

                    // Gán dữ liệu vào ComboBox
                    txtMaKH.DataSource = dt;
                    txtMaKH.ValueMember = "MaKH";    // Giá trị là mã khách hàng
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu mã khách hàng: " + ex.Message);
                }
            }
        }
        private void LoadComboBoxMaNV()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Câu lệnh SQL để lấy danh sách mã nhân viên
                    string query = "SELECT MaNV FROM NHAN_VIEN";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Thêm một dòng trống vào đầu danh sách
                    DataRow dr = dt.NewRow();
                    dr["MaNV"] = DBNull.Value;
                    dt.Rows.InsertAt(dr, 0);

                    // Gán dữ liệu vào ComboBox
                    txtMaNV.DataSource = dt;
                    txtMaNV.ValueMember = "MaNV";    // Giá trị của mỗi mục là mã nhân viên

                    // Đặt trạng thái ban đầu là trống
                    txtMaNV.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu mã nhân viên: " + ex.Message);
                }
            }
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

        private void shipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ship());

        }
        private void đơnVịVậnChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDVVC());
        }
        private void shipToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}


