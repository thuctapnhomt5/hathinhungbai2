namespace QLSTHi
{
    partial class frmHangHoa
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
            this.gbxHangHoa = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.txtGiaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblTenHangHoa = new System.Windows.Forms.Label();
            this.lblMaHangHoa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxHangHoa
            // 
            this.gbxHangHoa.BackColor = System.Drawing.Color.MediumAquamarine;
            this.gbxHangHoa.Controls.Add(this.btnTimKiem);
            this.gbxHangHoa.Controls.Add(this.txtFind);
            this.gbxHangHoa.Controls.Add(this.btnThongKe);
            this.gbxHangHoa.Controls.Add(this.btnBanHang);
            this.gbxHangHoa.Controls.Add(this.btnNhapHang);
            this.gbxHangHoa.Controls.Add(this.txtNgayNhap);
            this.gbxHangHoa.Controls.Add(this.txtGiaHang);
            this.gbxHangHoa.Controls.Add(this.txtTenHang);
            this.gbxHangHoa.Controls.Add(this.txtID);
            this.gbxHangHoa.Controls.Add(this.lblSoLuong);
            this.gbxHangHoa.Controls.Add(this.lblGiaBan);
            this.gbxHangHoa.Controls.Add(this.lblTenHangHoa);
            this.gbxHangHoa.Controls.Add(this.lblMaHangHoa);
            this.gbxHangHoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxHangHoa.Location = new System.Drawing.Point(12, 12);
            this.gbxHangHoa.Name = "gbxHangHoa";
            this.gbxHangHoa.Size = new System.Drawing.Size(698, 257);
            this.gbxHangHoa.TabIndex = 0;
            this.gbxHangHoa.TabStop = false;
            this.gbxHangHoa.Text = "Thông Tin Hàng Hóa";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(38, 195);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(84, 37);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(167, 204);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(195, 20);
            this.txtFind.TabIndex = 12;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnThongKe.Location = new System.Drawing.Point(471, 189);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(127, 43);
            this.btnThongKe.TabIndex = 10;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBanHang.Location = new System.Drawing.Point(471, 107);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(127, 43);
            this.btnBanHang.TabIndex = 9;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnNhapHang.Location = new System.Drawing.Point(471, 26);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(127, 48);
            this.btnNhapHang.TabIndex = 8;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Location = new System.Drawing.Point(167, 156);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(195, 20);
            this.txtNgayNhap.TabIndex = 7;
            // 
            // txtGiaHang
            // 
            this.txtGiaHang.Location = new System.Drawing.Point(167, 107);
            this.txtGiaHang.Name = "txtGiaHang";
            this.txtGiaHang.Size = new System.Drawing.Size(195, 20);
            this.txtGiaHang.TabIndex = 6;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(167, 73);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(195, 20);
            this.txtTenHang.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(167, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(195, 20);
            this.txtID.TabIndex = 4;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(35, 160);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(65, 16);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.Location = new System.Drawing.Point(35, 114);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(56, 16);
            this.lblGiaBan.TabIndex = 2;
            this.lblGiaBan.Text = "Giá Bán";
            // 
            // lblTenHangHoa
            // 
            this.lblTenHangHoa.AutoSize = true;
            this.lblTenHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHangHoa.Location = new System.Drawing.Point(35, 77);
            this.lblTenHangHoa.Name = "lblTenHangHoa";
            this.lblTenHangHoa.Size = new System.Drawing.Size(68, 16);
            this.lblTenHangHoa.TabIndex = 1;
            this.lblTenHangHoa.Text = "Tên Hàng";
            // 
            // lblMaHangHoa
            // 
            this.lblMaHangHoa.AutoSize = true;
            this.lblMaHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHangHoa.Location = new System.Drawing.Point(35, 34);
            this.lblMaHangHoa.Name = "lblMaHangHoa";
            this.lblMaHangHoa.Size = new System.Drawing.Size(87, 16);
            this.lblMaHangHoa.TabIndex = 0;
            this.lblMaHangHoa.Text = "ID_HangHoa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 197);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 474);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxHangHoa);
            this.Name = "frmHangHoa";
            this.Text = "frmHangHoa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.gbxHangHoa.ResumeLayout(false);
            this.gbxHangHoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHangHoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.TextBox txtGiaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblTenHangHoa;
        private System.Windows.Forms.Label lblMaHangHoa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}