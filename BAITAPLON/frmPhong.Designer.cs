
namespace QLKS
{
    partial class frmPhong
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
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
			this.txtMaPhong = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.radKhongTrong = new System.Windows.Forms.RadioButton();
			this.radTrong = new System.Windows.Forms.RadioButton();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.grpFunction = new System.Windows.Forms.GroupBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.grpFunction.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// btnHuy
			// 
			this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.Location = new System.Drawing.Point(398, 93);
			this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(99, 31);
			this.btnHuy.TabIndex = 11;
			this.btnHuy.Text = "Hủy bỏ";
			this.btnHuy.Visible = false;
			// 
			// btnLuu
			// 
			this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Location = new System.Drawing.Point(399, 32);
			this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(99, 31);
			this.btnLuu.TabIndex = 10;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Visible = false;
			// 
			// cboLoaiPhong
			// 
			this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLoaiPhong.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboLoaiPhong.Location = new System.Drawing.Point(165, 69);
			this.cboLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cboLoaiPhong.Name = "cboLoaiPhong";
			this.cboLoaiPhong.Size = new System.Drawing.Size(187, 24);
			this.cboLoaiPhong.TabIndex = 6;
			// 
			// txtMaPhong
			// 
			this.txtMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaPhong.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaPhong.Location = new System.Drawing.Point(165, 22);
			this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtMaPhong.Multiline = true;
			this.txtMaPhong.Name = "txtMaPhong";
			this.txtMaPhong.Size = new System.Drawing.Size(149, 27);
			this.txtMaPhong.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 17);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 32);
			this.label2.TabIndex = 9;
			this.label2.Text = "Mã số phòng:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 61);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 32);
			this.label3.TabIndex = 8;
			this.label3.Text = "Loại phòng:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 144);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 32);
			this.label1.TabIndex = 8;
			this.label1.Text = "Tình trạng:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.radKhongTrong);
			this.groupBox1.Controls.Add(this.radTrong);
			this.groupBox1.Controls.Add(this.btnHuy);
			this.groupBox1.Controls.Add(this.btnLuu);
			this.groupBox1.Controls.Add(this.cboLoaiPhong);
			this.groupBox1.Controls.Add(this.txtMaPhong);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Size = new System.Drawing.Size(544, 186);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(165, 111);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(61, 30);
			this.numericUpDown1.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 109);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 32);
			this.label4.TabIndex = 14;
			this.label4.Text = "Tầng";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// radKhongTrong
			// 
			this.radKhongTrong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radKhongTrong.Location = new System.Drawing.Point(267, 144);
			this.radKhongTrong.Name = "radKhongTrong";
			this.radKhongTrong.Size = new System.Drawing.Size(133, 32);
			this.radKhongTrong.TabIndex = 13;
			this.radKhongTrong.TabStop = true;
			this.radKhongTrong.Text = "Không Trống";
			this.radKhongTrong.UseVisualStyleBackColor = true;
			// 
			// radTrong
			// 
			this.radTrong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radTrong.Location = new System.Drawing.Point(165, 144);
			this.radTrong.Name = "radTrong";
			this.radTrong.Size = new System.Drawing.Size(96, 32);
			this.radTrong.TabIndex = 12;
			this.radTrong.TabStop = true;
			this.radTrong.Text = "Trống";
			this.radTrong.UseVisualStyleBackColor = true;
			// 
			// btnThoat
			// 
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(10, 138);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(123, 31);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "Thoát";
			// 
			// btnXoa
			// 
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(10, 93);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(124, 31);
			this.btnXoa.TabIndex = 2;
			this.btnXoa.Text = "Xóa";
			// 
			// btnSua
			// 
			this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(9, 55);
			this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(124, 31);
			this.btnSua.TabIndex = 1;
			this.btnSua.Text = "Sửa";
			// 
			// grpFunction
			// 
			this.grpFunction.Controls.Add(this.btnThoat);
			this.grpFunction.Controls.Add(this.btnXoa);
			this.grpFunction.Controls.Add(this.btnSua);
			this.grpFunction.Controls.Add(this.btnThem);
			this.grpFunction.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpFunction.Location = new System.Drawing.Point(569, 16);
			this.grpFunction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.grpFunction.Name = "grpFunction";
			this.grpFunction.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.grpFunction.Size = new System.Drawing.Size(143, 176);
			this.grpFunction.TabIndex = 8;
			this.grpFunction.TabStop = false;
			// 
			// btnThem
			// 
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(10, 17);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(124, 31);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm";
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 208);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(696, 285);
			this.dataGridView.TabIndex = 10;
			// 
			// frmPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::BAITAPLON.Properties.Resources.anh4;
			this.ClientSize = new System.Drawing.Size(735, 492);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grpFunction);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "frmPhong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PHÒNG ";
			this.Load += new System.EventHandler(this.frmPhong_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.grpFunction.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grpFunction;
        private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.RadioButton radKhongTrong;
		private System.Windows.Forms.RadioButton radTrong;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}