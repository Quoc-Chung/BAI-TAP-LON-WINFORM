
namespace QLKS
{
    partial class frmSearchPhong
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
			this.chkTrong = new System.Windows.Forms.CheckBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.dtGrid = new System.Windows.Forms.DataGrid();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMaSo = new System.Windows.Forms.TextBox();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.BackgroundImage = global::BAITAPLON.Properties.Resources.anh5;
			this.groupBox2.Controls.Add(this.txtMaSo);
			this.groupBox2.Controls.Add(this.cboLoaiPhong);
			this.groupBox2.Controls.Add(this.chkTrong);
			this.groupBox2.Controls.Add(this.btnTim);
			this.groupBox2.Controls.Add(this.btnThoat);
			this.groupBox2.Controls.Add(this.dtGrid);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(16, 19);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Size = new System.Drawing.Size(608, 532);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin cần tìm";
			// 
			// cboLoaiPhong
			// 
			this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLoaiPhong.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboLoaiPhong.Location = new System.Drawing.Point(141, 74);
			this.cboLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboLoaiPhong.Name = "cboLoaiPhong";
			this.cboLoaiPhong.Size = new System.Drawing.Size(191, 24);
			this.cboLoaiPhong.TabIndex = 20;
			// 
			// chkTrong
			// 
			this.chkTrong.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkTrong.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkTrong.Location = new System.Drawing.Point(11, 111);
			this.chkTrong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkTrong.Name = "chkTrong";
			this.chkTrong.Size = new System.Drawing.Size(149, 25);
			this.chkTrong.TabIndex = 19;
			this.chkTrong.Text = "Phòng trống";
			// 
			// btnTim
			// 
			this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.Location = new System.Drawing.Point(427, 38);
			this.btnTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(100, 35);
			this.btnTim.TabIndex = 18;
			this.btnTim.Text = "Tìm";
			// 
			// btnThoat
			// 
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(427, 99);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(100, 35);
			this.btnThoat.TabIndex = 17;
			this.btnThoat.Text = "Thoát";
			// 
			// dtGrid
			// 
			this.dtGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dtGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dtGrid.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dtGrid.CaptionForeColor = System.Drawing.SystemColors.ControlText;
			this.dtGrid.CaptionText = "Danh sách phòng thỏa điều kiện";
			this.dtGrid.DataMember = "";
			this.dtGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dtGrid.Location = new System.Drawing.Point(11, 148);
			this.dtGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dtGrid.Name = "dtGrid";
			this.dtGrid.ReadOnly = true;
			this.dtGrid.Size = new System.Drawing.Size(589, 377);
			this.dtGrid.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 32);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 38);
			this.label3.TabIndex = 14;
			this.label3.Text = "Mã số phòng:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 74);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 38);
			this.label1.TabIndex = 15;
			this.label1.Text = "Loại phòng:";
			// 
			// txtMaSo
			// 
			this.txtMaSo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaSo.Location = new System.Drawing.Point(141, 32);
			this.txtMaSo.Name = "txtMaSo";
			this.txtMaSo.Size = new System.Drawing.Size(191, 27);
			this.txtMaSo.TabIndex = 21;
			// 
			// frmSearchPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::BAITAPLON.Properties.Resources.anh52;
			this.ClientSize = new System.Drawing.Size(646, 558);
			this.Controls.Add(this.groupBox2);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmSearchPhong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TÌM KIẾM PHÒNG";
			this.Load += new System.EventHandler(this.frmSearchPhong_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.CheckBox chkTrong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGrid dtGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMaSo;
	}
}