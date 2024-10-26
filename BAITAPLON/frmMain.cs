using QLKS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAPLON
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}
		private void mnLoaiPhong_Click(object sender, EventArgs e)
		{
			frmLoaiPhong form = new frmLoaiPhong();
			form.Show(); 
		}
		private void mnTrangBiPhong_Click(object sender, EventArgs e)
		{
			frmPhong form = new frmPhong();
			form.Show();
		}

		private void mnTimKiemPhong_Click(object sender, EventArgs e)
		{
			frmSearchPhong form = new frmSearchPhong();
			form.Show();

		}

		private void mnKhachHang_Click(object sender, EventArgs e)
		{
			frmSearchKH form  = new frmSearchKH();
			form.Show();
		}

		private void mnTrangThietBiPhong_Click(object sender, EventArgs e)
		{
			frmTBTrangThietBi frmTBTrangThietBi = new frmTBTrangThietBi();
			frmTBTrangThietBi.Show();
		}

		private void mnTrangThietBi_Click(object sender, EventArgs e)
		{
			frmThietBi frm = new frmThietBi();
			frm.Show();
		}

		private void mnSDDichVu_Click(object sender, EventArgs e)
		{
			frmSDDichVu form = new frmSDDichVu();
			form.Show();
		}
		private void mnHoSoNhanVien_Click(object sender, EventArgs e)
		{
			frmNV frmNV = new frmNV();
			frmNV.Show();
		}

		private void nhậpLạiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmChangeProfile frmChangeProfile = new frmChangeProfile();
			frmChangeProfile.Show();
		}

		private void mnQLKhachHang_Click(object sender, EventArgs e)
		{
			frmKH frmKH = new frmKH();
			frmKH.Show();
		}
	}
}
