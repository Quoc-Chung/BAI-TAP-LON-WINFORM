﻿namespace BAITAPLON
{
	partial class frmDangNhap
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.txtMaNhanVien = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã Số NV:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 81);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mật Khẩu:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMatKhau.Location = new System.Drawing.Point(129, 82);
			this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMatKhau.Multiline = true;
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(315, 28);
			this.txtMatKhau.TabIndex = 3;
			// 
			// txtMaNhanVien
			// 
			this.txtMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaNhanVien.Location = new System.Drawing.Point(129, 26);
			this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMaNhanVien.Multiline = true;
			this.txtMaNhanVien.Name = "txtMaNhanVien";
			this.txtMaNhanVien.Size = new System.Drawing.Size(315, 28);
			this.txtMaNhanVien.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(45, 138);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 34);
			this.button1.TabIndex = 5;
			this.button1.Text = "Đăng Nhập";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(280, 140);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(140, 34);
			this.button2.TabIndex = 6;
			this.button2.Text = "Thoát";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// frmDangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(461, 190);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtMaNhanVien);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmDangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ĐĂNG NHẬP";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.TextBox txtMaNhanVien;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}