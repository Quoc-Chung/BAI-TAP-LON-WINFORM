
namespace QLKS
{
    partial class frmThanhToanPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnThanhToan = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.cboMaP = new System.Windows.Forms.ComboBox();
			this.btnXem = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnInHoaDon = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnThanhToan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThanhToan.Location = new System.Drawing.Point(21, 559);
			this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.Size = new System.Drawing.Size(184, 39);
			this.btnThanhToan.TabIndex = 31;
			this.btnThanhToan.Text = "Thanh toán";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(13, 55);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(704, 498);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chi tiết sử dụng dịch vụ";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(8, 280);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(681, 210);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "BÁO CÁO";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(672, 188);
			this.label2.TabIndex = 0;
			this.label2.Text = "Hiển thj báo cáo ở đây";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(8, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(681, 248);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 38);
			this.label1.TabIndex = 27;
			this.label1.Text = "Chọn mã phòng:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cboMaP
			// 
			this.cboMaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMaP.Location = new System.Drawing.Point(162, 20);
			this.cboMaP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboMaP.Name = "cboMaP";
			this.cboMaP.Size = new System.Drawing.Size(137, 25);
			this.cboMaP.TabIndex = 28;
			// 
			// btnXem
			// 
			this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXem.Location = new System.Drawing.Point(323, 12);
			this.btnXem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnXem.Name = "btnXem";
			this.btnXem.Size = new System.Drawing.Size(96, 38);
			this.btnXem.TabIndex = 29;
			this.btnXem.Text = "Xem";
			// 
			// btnThoat
			// 
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnThoat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(522, 563);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(180, 39);
			this.btnThoat.TabIndex = 31;
			this.btnThoat.Text = "Thoát";
			// 
			// btnInHoaDon
			// 
			this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnInHoaDon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInHoaDon.Location = new System.Drawing.Point(251, 563);
			this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnInHoaDon.Name = "btnInHoaDon";
			this.btnInHoaDon.Size = new System.Drawing.Size(184, 39);
			this.btnInHoaDon.TabIndex = 32;
			this.btnInHoaDon.Text = "Xuất Hóa Đơn";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnInHoaDon);
			this.groupBox2.Controls.Add(this.btnThoat);
			this.groupBox2.Controls.Add(this.btnXem);
			this.groupBox2.Controls.Add(this.cboMaP);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.btnThanhToan);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(16, 14);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Size = new System.Drawing.Size(725, 608);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			// 
			// frmThanhToanPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::BAITAPLON.Properties.Resources.anh7;
			this.ClientSize = new System.Drawing.Size(757, 630);
			this.Controls.Add(this.groupBox2);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmThanhToanPhong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HỢP ĐỒNG THANH TOÁN";
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button btnThanhToan;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboMaP;
		private System.Windows.Forms.Button btnXem;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnInHoaDon;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label2;
	}
}