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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLKS
{
    public partial class frmNV : Form
    {
        SqlConnection connection;
        SqlCommand command;

        string str = "Data Source=HUNGHOANG-LAPTO\\SQLEXPRESS;Initial Catalog=QUANLI_KHACHSAN_BTL;Integrated Security=True;";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frmNV()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM NHANVIEN";

            /* - CÂU LỆNH THỰC THI CÂU TRUY VẤN -*/
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;

            table.Clear();
            adapter.Fill(table);

            dataGridView.DataSource = table;
        }
        private void frmNV_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        private string selectedImagePath = ""; // Biến lưu đường dẫn ảnh
        private void cmdAdd_Click(object sender, EventArgs e)
        {

            // Kiểm tra mã nhân viên phải đủ 5 ký tự
            if (txtMaNV.Text.Length != 5)
            {
                MessageBox.Show("Mã nhân viên phải đủ 5 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra Họ tên và Địa chỉ không được bỏ trống
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtDChi.Text))
            {
                MessageBox.Show("Họ tên và địa chỉ nhân viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra các trường nhập liệu khác
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtMKhau.Text) ||
                string.IsNullOrEmpty(txtDThoai.Text))
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDThoai.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Chuyển đổi các giá trị kiểu số từ TextBox
                int sdt;
                if (!int.TryParse(txtDThoai.Text, out sdt))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Tạo câu lệnh SQL INSERT
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO NHANVIEN (MANHANVIEN, MATKHAU, HOTEN, NGAYSINH, GIOITINH, DIACHI, SODIENTHOAI,NGAYVAOLAM,ANH) " +
                                      "VALUES (@MaNhanVien, @MatKhau, @HoTen, @NgaySinh, @GioiTinh, @DiaCHi,@SoDienThoai,@NgayVaoLam,@Anh)";

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@MaNhanVien", txtMaNV.Text);
                command.Parameters.AddWithValue("@MatKhau", txtMKhau.Text);
                command.Parameters.AddWithValue("@HoTen", txtTenNV.Text);
                command.Parameters.AddWithValue("@NgaySinh", dTPicker_NSinh.Value);
                command.Parameters.AddWithValue("@DiaCHi", txtDChi.Text);
                command.Parameters.AddWithValue("@SoDienThoai", txtDThoai.Text);
                command.Parameters.AddWithValue("@NgayVaoLam", dTPicker_NVaoLam.Value);

                string gioiTinh = optNam.Checked ? "True" : (optNu.Checked ? "False" : null);

                if (gioiTinh != null)
                {
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn giới tính.");
                }

                command.Parameters.AddWithValue("@Anh", string.IsNullOrEmpty(selectedImagePath) ? DBNull.Value : (object)selectedImagePath);

                // Sử dụng biến selectedImagePath trong cmdAdd_Click
                //command.Parameters.AddWithValue("@Anh", selectedImagePath);

                // Thực thi câu lệnh SQL
                command.ExecuteNonQuery();

                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại dữ liệu sau khi thêm mới
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã nhân viên phải đủ 5 ký tự
            if (txtMaNV.Text.Length != 5)
            {
                MessageBox.Show("Mã nhân viên phải đủ 5 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra Họ tên và Địa chỉ không được bỏ trống
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtDChi.Text))
            {
                MessageBox.Show("Họ tên và địa chỉ nhân viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra các trường nhập liệu khác
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtMKhau.Text) ||
                string.IsNullOrEmpty(txtDThoai.Text))
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDThoai.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Chuyển đổi các giá trị kiểu số từ TextBox
                int sdt;
                if (!int.TryParse(txtDThoai.Text, out sdt))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string oldMaNV = dataGridView.CurrentRow.Cells["MANHANVIEN"].Value.ToString();
                // Tạo câu lệnh SQL INSERT
                command = connection.CreateCommand();
                command.CommandText = "UPDATE NHANVIEN SET MANHANVIEN=@MaNhanVien, MATKHAU=@MatKhau, HOTEN=@HoTen, NGAYSINH=@NgaySinh, GIOITINH=@GioiTinh, DIACHI=@DiaCHi, SODIENTHOAI=@SoDienThoai,NGAYVAOLAM=@NgayVaoLam,ANH=@Anh " +
                                      " WHERE MANHANVIEN = @OldMaNV";

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@MaNhanVien", txtMaNV.Text);
                command.Parameters.AddWithValue("@MatKhau", txtMKhau.Text);
                command.Parameters.AddWithValue("@HoTen", txtTenNV.Text);
                command.Parameters.AddWithValue("@NgaySinh", dTPicker_NSinh.Value);
                command.Parameters.AddWithValue("@DiaCHi", txtDChi.Text);
                command.Parameters.AddWithValue("@SoDienThoai", txtDThoai.Text);
                command.Parameters.AddWithValue("@NgayVaoLam", dTPicker_NVaoLam.Value);
                command.Parameters.AddWithValue("@OldMaNV", oldMaNV);

                string gioiTinh = optNam.Checked ? "True" : (optNu.Checked ? "False" : null);

                if (gioiTinh != null)
                {
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn giới tính.");
                }

                command.Parameters.AddWithValue("@Anh", string.IsNullOrEmpty(selectedImagePath) ? DBNull.Value : (object)selectedImagePath);

                // Sử dụng biến selectedImagePath trong cmdAdd_Click
                //command.Parameters.AddWithValue("@Anh", selectedImagePath);

                // Thực thi câu lệnh SQL
                command.ExecuteNonQuery();

                MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại dữ liệu sau khi thêm mới
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã nhập mã hàng chưa
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Bạn vui lòng nhập mã nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Hỏi người dùng xác nhận việc xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    // Tạo câu lệnh SQL DELETE
                    command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM NHANVIEN WHERE MANHANVIEN = @MaNV";

                    // Thêm tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@MaNV", txtMaNV.Text);

                    // Thực thi câu lệnh SQL
                    command.ExecuteNonQuery();

                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại dữ liệu sau khi xóa
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            // Khởi tạo OpenFileDialog để chọn ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            // Nếu người dùng chọn tệp thành công
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn tới file ảnh
                selectedImagePath = openFileDialog.FileName;

                // Hiển thị ảnh trong PictureBox
                pictureBox1.Image = Image.FromFile(selectedImagePath); // Hiển thị trong PictureBox nếu cần
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào hàng hợp lệ hay không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string gioiTinh = optNam.Checked ? "True" : (optNu.Checked ? "False" : null);
                // Lấy hàng được click
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                // Gán giá trị từ các ô trong hàng được chọn vào các TextBox tương ứng
                txtMaNV.Text = row.Cells["MANHANVIEN"].Value.ToString();
                txtMKhau.Text = row.Cells["MATKHAU"].Value.ToString();
                txtTenNV.Text = row.Cells["HOTEN"].Value.ToString();
                dTPicker_NSinh.Value = DateTime.Parse(row.Cells["NGAYSINH"].Value.ToString());
                txtDChi.Text = row.Cells["DIACHI"].Value.ToString();
                txtDThoai.Text = row.Cells["SODIENTHOAI"].Value.ToString();
                dTPicker_NVaoLam.Value= DateTime.Parse(row.Cells["NGAYVAOLAM"].Value.ToString());
                
                if (row.Cells["GIOITINH"].Value.ToString() == "True")
                {
                    optNam.Checked = true;
                    optNu.Checked = false;
                }
                else if (row.Cells["GIOITINH"].Value.ToString() == "False")
                {
                    optNu.Checked = true;
                    optNam.Checked = false;
                }
                if (row.Cells["ANH"].Value != DBNull.Value && !string.IsNullOrEmpty(row.Cells["ANH"].Value.ToString()))
                {
                    selectedImagePath = row.Cells["ANH"].Value.ToString();
                    try
                    {
                        pictureBox1.Image = Image.FromFile(selectedImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pictureBox1.Image = null; // Xóa ảnh nếu không tải được
                    }
                }
                else
                {
                    pictureBox1.Image = null; // Nếu không có ảnh, hiển thị PictureBox trống
                }

            }
        }
    }
}
