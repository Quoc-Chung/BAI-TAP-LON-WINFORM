using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLKS
{
	public partial class frmKH : Form
	{
		private SqlConnection connection;
		private string connectionString = "Data Source=LAPTOP-LACSE5QS\\SQLEXPRESS;Initial Catalog=QUANLI_KHACHSAN_BTL;Integrated Security=True;";
		private DataTable table = new DataTable();

		private string msPhong = "", maHDTPhong = "";
		private bool trang_thai_trong = true;

		public frmKH()
		{
			InitializeComponent();
		}
		public void LoadData()
		{
			using (connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					string query = "SELECT * FROM DANHMUCPHONG";
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						using (SqlDataAdapter adapter = new SqlDataAdapter(command))
						{
							table.Clear(); // Xóa dữ liệu cũ (nếu thực sự cần)
							adapter.Fill(table);
							Load_Phong(table); // Chỉ tải dữ liệu một lần
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
				}
			}
		}
		private void Load_Phong(DataTable dt)
		{
			panP.Controls.Clear();
			int i = 0;
			foreach (DataRow row in dt.Rows)
			{
				Label lb = new Label
				{
					Location = new Point(i * 80, 0),
					Height = panP.Height - 20,
					Width = 80,
					TextAlign = ContentAlignment.MiddleCenter,
					BorderStyle = BorderStyle.FixedSingle,
					Text = row["MAPHONG"].ToString().Trim(),
					Name = "lb;" + row["MAPHONG"].ToString(),
					BackColor = row["TINHTRANG"].ToString() == "True" ? Color.Red : Color.LightGreen,
					Tag = row["TINHTRANG"].ToString() == "True" ? "Red" : "LightGreen"
				};
				lb.Click += lb_Click;
				panP.Controls.Add(lb);
				i++;
			}
		}
		private void LoadKhachHangTrongPhong()
		{

		}
		private void frmKH_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		public void ResetHienThi()
		{
			txtHoTen.Text =" ";
			txtCMND.Text = " ";
			radNam.Checked = false;		
			radNu.Checked = false;
			
			txtDiaChi.Text =" ";
			txtDienThoai.Text = " ";
		}
		private void lView_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Kiểm tra nếu có mục nào được chọn
			if (lView.SelectedItems.Count > 0)
			{
				// Lấy mục đầu tiên trong danh sách đã chọn
				ListViewItem selectedItem = lView.SelectedItems[0];
				string MaKhachHang = selectedItem.SubItems[0].Text;
				string HoTen = selectedItem.SubItems[1].Text; 
				string CMND = selectedItem.SubItems[2].Text; 
				string GioiTinh = selectedItem.SubItems[3].Text; 
				string DiaChi = selectedItem.SubItems[4].Text;
				string DienThoai = selectedItem.SubItems[5].Text;    
				txtMaKhachHang.Text = MaKhachHang;
				txtHoTen.Text = HoTen; 
				txtCMND.Text = CMND;
				
				if(GioiTinh == "Nam")
				{
					radNam.Checked = true;
				}
				else
				{
					radNu.Checked = true;
				}
				txtDiaChi.Text = DiaChi;
				txtDienThoai.Text = DienThoai;	    
			}
		}

		private void cmdExit_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Bạn có muốn thoát chương trình ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private bool KiemTraKhachHangTonTaiTrongPhong(string maKhachHang, string shdThuePhong)
		{
			using (connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					string query = @"
										SELECT COUNT(*) 
										FROM CHITIETTHUEPHONG 
										WHERE MAKHACHHANG = @MAKHACHHANG AND SHDTHUEPHONG = @SHDTHUEPHONG";

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@MAKHACHHANG", maKhachHang);
						command.Parameters.AddWithValue("@SHDTHUEPHONG", shdThuePhong);

						int count = (int)command.ExecuteScalar();
						return count > 0;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi kiểm tra khách hàng trong phòng: " + ex.Message);
					return false;
				}
			}
		}



		private void btnThem_Click(object sender, EventArgs e)
		{
			// Highlight the selected room
			foreach (Control control in panP.Controls)
			{
				if (control is Label && control.Name.StartsWith("lb;"))
				{
					control.BackColor = control.Tag.ToString() == "Red" ? Color.Red : Color.LightGreen;
				}
			}

			Label lb = sender as Label;
			if (lb == null) return;

			msPhong = lb.Text;  // Selected room ID
			string maKhachHang = txtMaKhachHang.Text.Trim(); // Customer ID

			// Check if the customer already exists in the selected room
			if (KiemTraKhachHangTonTaiTrongPhong(maKhachHang, msPhong))
			{
				MessageBox.Show("Khách hàng đã tồn tại trong phòng này!");
				return;
			}

			using (connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					// Insert the customer if they don't already exist
					string insertCustomerQuery = @"
                IF NOT EXISTS (SELECT 1 FROM KHACHHANG WHERE MAKHACHHANG = @MAKHACHHANG)
                BEGIN
                    INSERT INTO KHACHHANG (MAKHACHHANG, HOTEN, CMND, GIOITINH, DIACHI, DIENTHOAI)
                    VALUES (@MAKHACHHANG, @HOTEN, @CMND, @GIOITINH, @DIACHI, @DIENTHOAI)
                END";

					using (SqlCommand command = new SqlCommand(insertCustomerQuery, connection))
					{
						command.Parameters.AddWithValue("@MAKHACHHANG", maKhachHang);
						command.Parameters.AddWithValue("@HOTEN", txtHoTen.Text.Trim());
						command.Parameters.AddWithValue("@CMND", txtCMND.Text.Trim());
						command.Parameters.AddWithValue("@GIOITINH", radNam.Checked ? 1 : 0);
						command.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);
						command.Parameters.AddWithValue("@DIENTHOAI", txtDienThoai.Text.Trim());

						command.ExecuteNonQuery();
					}

					// Insert the customer-room relationship in CHITIETTHUEPHONG
					string insertRoomDetailQuery = "INSERT INTO CHITIETTHUEPHONG (SHDTHUEPHONG, MAKHACHHANG) VALUES (@SHDTHUEPHONG, @MAKHACHHANG)";
					using (SqlCommand roomCommand = new SqlCommand(insertRoomDetailQuery, connection))
					{
						roomCommand.Parameters.AddWithValue("@SHDTHUEPHONG", msPhong);
						roomCommand.Parameters.AddWithValue("@MAKHACHHANG", maKhachHang);

						roomCommand.ExecuteNonQuery();
					}

					MessageBox.Show("Thêm khách hàng vào phòng thành công!");
					LoadRoomDetails(msPhong); // Reload the ListView with updated room details
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi thêm khách hàng vào phòng: " + ex.Message);
				}
			}
		}

		// Method to load the room details into the ListView
		private void LoadRoomDetails(string shdThuePhong)
		{
			lView.Items.Clear();

			using (connection = new SqlConnection(connectionString))
			{
				string query = @"
            SELECT KHACHHANG.MAKHACHHANG, KHACHHANG.HOTEN, KHACHHANG.CMND, 
                   KHACHHANG.GIOITINH, KHACHHANG.DIACHI, KHACHHANG.DIENTHOAI 
            FROM CHITIETTHUEPHONG
            JOIN KHACHHANG ON CHITIETTHUEPHONG.MAKHACHHANG = KHACHHANG.MAKHACHHANG
            WHERE CHITIETTHUEPHONG.SHDTHUEPHONG = @SHDTHUEPHONG";

				try
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@SHDTHUEPHONG", shdThuePhong);
						using (SqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								ListViewItem item = new ListViewItem(reader["MAKHACHHANG"].ToString());
								item.SubItems.Add(reader["HOTEN"].ToString());
								item.SubItems.Add(reader["CMND"].ToString());
								item.SubItems.Add((bool)reader["GIOITINH"] ? "Nam" : "Nữ");
								item.SubItems.Add(reader["DIACHI"].ToString());
								item.SubItems.Add(reader["DIENTHOAI"].ToString());

								lView.Items.Add(item);
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi tải chi tiết phòng: " + ex.Message);
				}
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			using (connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					string query = "UPDATE KHACHHANG SET HOTEN = @HOTEN, GIOITINH = @GIOITINH, DIACHI = @DIACHI, DIENTHOAI = @DIENTHOAI WHERE CMND = @CMND";
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@HOTEN", txtHoTen.Text.Trim());
						command.Parameters.AddWithValue("@GIOITINH", radNam.Checked ? 1 : 0);

						command.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text.Trim());
						command.Parameters.AddWithValue("@DIENTHOAI", txtDienThoai.Text.Trim());
						command.Parameters.AddWithValue("@CMND", txtCMND.Text.Trim());

						int result = command.ExecuteNonQuery();
						if (result > 0)
						{
							MessageBox.Show("Sửa thông tin khách hàng thành công!");
							ResetHienThi();

							
							if (!string.IsNullOrEmpty(msPhong))
							{
								Label selectedLabel = panP.Controls.Find("lb;" + msPhong, false).FirstOrDefault() as Label;
								if (selectedLabel != null)
								{
									lb_Click(selectedLabel, EventArgs.Empty);
								}
							}
						}
						else
						{
							MessageBox.Show("Sửa thông tin khách hàng thất bại.");
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi sửa thông tin khách hàng: " + ex.Message);
				}
			}
		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				using (connection = new SqlConnection(connectionString))
				{
					try
					{
						connection.Open();
						string query = "DELETE FROM KHACHHANG WHERE CMND = @CMND";
						using (SqlCommand command = new SqlCommand(query, connection))
						{
							command.Parameters.AddWithValue("@CMND", txtCMND.Text.Trim());

							int result = command.ExecuteNonQuery();
							if (result > 0)
							{
								MessageBox.Show("Xóa khách hàng thành công!");
								LoadData(); // Tải lại dữ liệu
							}
							else
							{
								MessageBox.Show("Xóa khách hàng thất bại.");
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
					}
				}
			}
		}
	


		private void lb_Click(object sender, EventArgs e)
		{
			ResetHienThi();
			foreach (Control control in panP.Controls)
			{
				if (control is Label && control.Name.StartsWith("lb;"))
				{
					control.BackColor = control.Tag.ToString() == "Red" ? Color.Red : Color.LightGreen;
				}
			}

			Label lb = sender as Label;
			if (lb == null) return;

			msPhong = lb.Text;

			if (lb.Tag.ToString() == "Red") // Nếu phòng đang được thuê
			{
				lb.BackColor = Color.Gray;
				trang_thai_trong = false;
				btnThem.Enabled = true;
				btnLuu.Enabled = false;
				lView.Items.Clear();
				using (connection = new SqlConnection(connectionString))
				{
					try
					{
						connection.Open();
						using (SqlCommand command = new SqlCommand("sp_Phong_KH", connection))
						{
							command.CommandType = CommandType.StoredProcedure;
							command.Parameters.AddWithValue("@msphong", msPhong);

							using (SqlDataAdapter adapter = new SqlDataAdapter(command))
							{
								DataTable dtPhong_KH = new DataTable();
								adapter.Fill(dtPhong_KH);

								if (dtPhong_KH.Rows.Count > 0)
								{
									lView.Items.Clear();

									foreach (DataRow row in dtPhong_KH.Rows)
									{
										ListViewItem item = new ListViewItem(row["MAKHACHHANG"].ToString())
										{
											SubItems = {
												row["HOTEN"].ToString(),
												row["CMND"].ToString(),
												row["GIOITINH"].ToString() == "True" ? "Nam" : "Nu",
												row["DIACHI"].ToString(),
												row["DIENTHOAI"].ToString()
											}
										};
										maHDTPhong = row["SHDTHUEPHONG"].ToString();
										lView.Items.Add(item);
									}

									dTPicker_Thue.Text = dtPhong_KH.Rows[0]["NGAYTHUE"].ToString();
									dTPicker_Tra.Text = dtPhong_KH.Rows[0]["NGAYTRA"].ToString();
								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Lỗi khi lấy thông tin khách hàng: " + ex.Message);
					}
				}
			}
			else // Nếu phòng trống
			{
				lb.BackColor = Color.LightGray;
				if (!trang_thai_trong)
					lView.Items.Clear();

				trang_thai_trong = true;
				btnThem.Enabled = false;
				btnLuu.Enabled = true;
			}
		}
	}
}

