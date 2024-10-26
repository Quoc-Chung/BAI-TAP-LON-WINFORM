
namespace QLKS
{
    partial class frmSDDichVu
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dTPicker_NgaySD = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.cboMaP = new System.Windows.Forms.ComboBox();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Controls.Add(this.dTPicker_NgaySD);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cboMaP);
			this.groupBox1.Controls.Add(this.btnThoat);
			this.groupBox1.Controls.Add(this.btnLuu);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(18, 19);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(460, 529);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(16, 128);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(428, 392);
			this.dataGridView1.TabIndex = 23;
			// 
			// dTPicker_NgaySD
			// 
			this.dTPicker_NgaySD.CustomFormat = "\"dd mm yyyy\"";
			this.dTPicker_NgaySD.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dTPicker_NgaySD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dTPicker_NgaySD.Location = new System.Drawing.Point(144, 75);
			this.dTPicker_NgaySD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dTPicker_NgaySD.Name = "dTPicker_NgaySD";
			this.dTPicker_NgaySD.Size = new System.Drawing.Size(130, 23);
			this.dTPicker_NgaySD.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 74);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 38);
			this.label1.TabIndex = 21;
			this.label1.Text = "Ngày sử dụng:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cboMaP
			// 
			this.cboMaP.Location = new System.Drawing.Point(144, 25);
			this.cboMaP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboMaP.Name = "cboMaP";
			this.cboMaP.Size = new System.Drawing.Size(130, 28);
			this.cboMaP.TabIndex = 12;
			// 
			// btnThoat
			// 
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnThoat.Location = new System.Drawing.Point(348, 69);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(96, 35);
			this.btnThoat.TabIndex = 11;
			this.btnThoat.Text = "Thoát";
		
			// btnLuu
			// 
			this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnLuu.Location = new System.Drawing.Point(348, 25);
			this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(96, 35);
			this.btnLuu.TabIndex = 10;
			this.btnLuu.Text = "Lưu";
			
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 19);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 38);
			this.label2.TabIndex = 9;
			this.label2.Text = "Mã phòng:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmSDDichVu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::BAITAPLON.Properties.Resources.anh8;
			this.ClientSize = new System.Drawing.Size(492, 553);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmSDDichVu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SỬ DỤNG DỊCH VỤ";
			
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dTPicker_NgaySD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaP;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}