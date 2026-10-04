namespace QuanLyChamSocThuCung
{
    partial class FrmKhachHang
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
            grpKhachHang = new GroupBox();
            btnQuayLai = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtGhiChu = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            txtMaKH = new TextBox();
            lblGhiChu = new Label();
            lblDiaChi = new Label();
            lblEmail = new Label();
            lblSDT = new Label();
            lblHoTen = new Label();
            lblMaKH = new Label();
            btnLamMoi = new Button();
            pnlTimKiem = new Panel();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            dgvKhachHang = new DataGridView();
            lblDSKhachHang = new Label();
            grpKhachHang.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // grpKhachHang
            // 
            grpKhachHang.Controls.Add(btnQuayLai);
            grpKhachHang.Controls.Add(btnXoa);
            grpKhachHang.Controls.Add(btnSua);
            grpKhachHang.Controls.Add(btnThem);
            grpKhachHang.Controls.Add(txtGhiChu);
            grpKhachHang.Controls.Add(txtDiaChi);
            grpKhachHang.Controls.Add(txtEmail);
            grpKhachHang.Controls.Add(txtSDT);
            grpKhachHang.Controls.Add(txtHoTen);
            grpKhachHang.Controls.Add(txtMaKH);
            grpKhachHang.Controls.Add(lblGhiChu);
            grpKhachHang.Controls.Add(lblDiaChi);
            grpKhachHang.Controls.Add(lblEmail);
            grpKhachHang.Controls.Add(lblSDT);
            grpKhachHang.Controls.Add(lblHoTen);
            grpKhachHang.Controls.Add(lblMaKH);
            grpKhachHang.Dock = DockStyle.Left;
            grpKhachHang.Location = new Point(0, 0);
            grpKhachHang.Name = "grpKhachHang";
            grpKhachHang.Size = new Size(439, 733);
            grpKhachHang.TabIndex = 0;
            grpKhachHang.TabStop = false;
            grpKhachHang.Text = "Thông tin Khách Hàng";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(320, 457);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 34;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(220, 457);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(120, 457);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(20, 457);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(28, 409);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(286, 27);
            txtGhiChu.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(28, 344);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(386, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(28, 277);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(386, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(28, 207);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(186, 27);
            txtSDT.TabIndex = 8;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(28, 137);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(286, 27);
            txtHoTen.TabIndex = 7;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(28, 73);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(125, 27);
            txtMaKH.TabIndex = 6;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(28, 386);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(58, 20);
            lblGhiChu.TabIndex = 5;
            lblGhiChu.Text = "Ghi chú";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(28, 321);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(55, 20);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(28, 254);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(28, 184);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(97, 20);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số điện thoại";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(28, 114);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 20);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên";
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Location = new Point(28, 50);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(109, 20);
            lblMaKH.TabIndex = 0;
            lblMaKH.Text = "Mã khách hàng";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Transparent;
            btnLamMoi.Location = new Point(644, 37);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(lblDSKhachHang);
            pnlTimKiem.Controls.Add(btnLamMoi);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(lblTimKiem);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(439, 0);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1043, 125);
            pnlTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(518, 37);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(101, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(293, 39);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(187, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(201, 46);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(70, 20);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(439, 125);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(1043, 608);
            dgvKhachHang.TabIndex = 2;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // lblDSKhachHang
            // 
            lblDSKhachHang.AutoSize = true;
            lblDSKhachHang.Location = new Point(388, 92);
            lblDSKhachHang.Name = "lblDSKhachHang";
            lblDSKhachHang.Size = new Size(163, 20);
            lblDSKhachHang.TabIndex = 16;
            lblDSKhachHang.Text = "Danh Sách Khách Hàng";
            // 
            // FrmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 733);
            Controls.Add(dgvKhachHang);
            Controls.Add(pnlTimKiem);
            Controls.Add(grpKhachHang);
            Name = "FrmKhachHang";
            Text = "Quản lý khách hàng";
            grpKhachHang.ResumeLayout(false);
            grpKhachHang.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpKhachHang;
        private Panel pnlTimKiem;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private DataGridView dgvKhachHang;
        private Label lblGhiChu;
        private Label lblDiaChi;
        private Label lblEmail;
        private Label lblSDT;
        private Label lblHoTen;
        private Label lblMaKH;
        private TextBox txtGhiChu;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtHoTen;
        private TextBox txtMaKH;
        private Button btnThem;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnQuayLai;
        private Label lblDSKhachHang;
    }
}