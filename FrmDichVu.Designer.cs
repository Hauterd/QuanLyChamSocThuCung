namespace QuanLyChamSocThuCung
{
    partial class FrmDichVu
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
            pnlTieuDe = new Panel();
            lblTieuDe = new Label();
            grpThongTinDichVu = new GroupBox();
            chkTrangThai = new CheckBox();
            lblPhut = new Label();
            numThoiGianDuKien = new NumericUpDown();
            txtDonGia = new TextBox();
            cboLoaiDV = new ComboBox();
            txtTenDV = new TextBox();
            lblDonGia = new Label();
            lblThoiGianDuKien = new Label();
            btnQuayLai = new Button();
            txtMoTa = new TextBox();
            lblMota = new Label();
            lblLoaiDV = new Label();
            lblGioiTinh = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtMaDV = new TextBox();
            lblTenDV = new Label();
            lblMaDV = new Label();
            pnlTimKiem = new Panel();
            lblDSDV = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            btnLamMoi = new Button();
            dgvDichVu = new DataGridView();
            pnlTieuDe.SuspendLayout();
            grpThongTinDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numThoiGianDuKien).BeginInit();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).BeginInit();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(1324, 73);
            pnlTieuDe.TabIndex = 1;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(512, 19);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(180, 20);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "DỊCH VỤ CHO THÚ CƯNG";
            // 
            // grpThongTinDichVu
            // 
            grpThongTinDichVu.Controls.Add(chkTrangThai);
            grpThongTinDichVu.Controls.Add(lblPhut);
            grpThongTinDichVu.Controls.Add(numThoiGianDuKien);
            grpThongTinDichVu.Controls.Add(txtDonGia);
            grpThongTinDichVu.Controls.Add(cboLoaiDV);
            grpThongTinDichVu.Controls.Add(txtTenDV);
            grpThongTinDichVu.Controls.Add(lblDonGia);
            grpThongTinDichVu.Controls.Add(lblThoiGianDuKien);
            grpThongTinDichVu.Controls.Add(btnQuayLai);
            grpThongTinDichVu.Controls.Add(txtMoTa);
            grpThongTinDichVu.Controls.Add(lblMota);
            grpThongTinDichVu.Controls.Add(lblLoaiDV);
            grpThongTinDichVu.Controls.Add(lblGioiTinh);
            grpThongTinDichVu.Controls.Add(btnXoa);
            grpThongTinDichVu.Controls.Add(btnSua);
            grpThongTinDichVu.Controls.Add(btnThem);
            grpThongTinDichVu.Controls.Add(txtMaDV);
            grpThongTinDichVu.Controls.Add(lblTenDV);
            grpThongTinDichVu.Controls.Add(lblMaDV);
            grpThongTinDichVu.Dock = DockStyle.Left;
            grpThongTinDichVu.Location = new Point(0, 73);
            grpThongTinDichVu.Name = "grpThongTinDichVu";
            grpThongTinDichVu.Size = new Size(544, 552);
            grpThongTinDichVu.TabIndex = 4;
            grpThongTinDichVu.TabStop = false;
            grpThongTinDichVu.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Checked = true;
            chkTrangThai.CheckState = CheckState.Checked;
            chkTrangThai.Location = new Point(343, 312);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(144, 24);
            chkTrangThai.TabIndex = 54;
            chkTrangThai.Text = " Đang hoạt động";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // lblPhut
            // 
            lblPhut.AutoSize = true;
            lblPhut.Location = new Point(156, 256);
            lblPhut.Name = "lblPhut";
            lblPhut.Size = new Size(38, 20);
            lblPhut.TabIndex = 53;
            lblPhut.Text = "Phút";
            // 
            // numThoiGianDuKien
            // 
            numThoiGianDuKien.Location = new Point(0, 256);
            numThoiGianDuKien.Name = "numThoiGianDuKien";
            numThoiGianDuKien.Size = new Size(150, 27);
            numThoiGianDuKien.TabIndex = 51;
            numThoiGianDuKien.Tag = "";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(2, 201);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 50;
            // 
            // cboLoaiDV
            // 
            cboLoaiDV.FormattingEnabled = true;
            cboLoaiDV.Location = new Point(0, 149);
            cboLoaiDV.Name = "cboLoaiDV";
            cboLoaiDV.Size = new Size(151, 28);
            cboLoaiDV.TabIndex = 49;
            // 
            // txtTenDV
            // 
            txtTenDV.Location = new Point(3, 96);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(151, 27);
            txtTenDV.TabIndex = 48;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(0, 180);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(62, 20);
            lblDonGia.TabIndex = 41;
            lblDonGia.Text = "Đơn giá";
            // 
            // lblThoiGianDuKien
            // 
            lblThoiGianDuKien.AutoSize = true;
            lblThoiGianDuKien.Location = new Point(0, 233);
            lblThoiGianDuKien.Name = "lblThoiGianDuKien";
            lblThoiGianDuKien.Size = new Size(124, 20);
            lblThoiGianDuKien.TabIndex = 39;
            lblThoiGianDuKien.Text = "Thời gian dự kiến";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(300, 364);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 33;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(0, 313);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(308, 27);
            txtMoTa.TabIndex = 31;
            // 
            // lblMota
            // 
            lblMota.AutoSize = true;
            lblMota.Location = new Point(0, 290);
            lblMota.Name = "lblMota";
            lblMota.Size = new Size(48, 20);
            lblMota.TabIndex = 30;
            lblMota.Text = "Mô tả";
            // 
            // lblLoaiDV
            // 
            lblLoaiDV.AutoSize = true;
            lblLoaiDV.Location = new Point(0, 127);
            lblLoaiDV.Name = "lblLoaiDV";
            lblLoaiDV.Size = new Size(96, 20);
            lblLoaiDV.TabIndex = 23;
            lblLoaiDV.Text = "Loại  Dịch Vụ";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(315, 316);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(0, 20);
            lblGioiTinh.TabIndex = 3;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(200, 364);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(100, 364);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(0, 364);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtMaDV
            // 
            txtMaDV.Dock = DockStyle.Left;
            txtMaDV.Location = new Point(3, 43);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.ReadOnly = true;
            txtMaDV.Size = new Size(227, 27);
            txtMaDV.TabIndex = 6;
            // 
            // lblTenDV
            // 
            lblTenDV.AutoSize = true;
            lblTenDV.Location = new Point(3, 73);
            lblTenDV.Name = "lblTenDV";
            lblTenDV.Size = new Size(83, 20);
            lblTenDV.TabIndex = 2;
            lblTenDV.Text = "Tên dịch vụ";
            // 
            // lblMaDV
            // 
            lblMaDV.AutoSize = true;
            lblMaDV.Dock = DockStyle.Top;
            lblMaDV.Location = new Point(3, 23);
            lblMaDV.Name = "lblMaDV";
            lblMaDV.Size = new Size(81, 20);
            lblMaDV.TabIndex = 0;
            lblMaDV.Text = "Mã dịch vụ";
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(lblDSDV);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(lblTimKiem);
            pnlTimKiem.Controls.Add(btnLamMoi);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(544, 73);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(780, 125);
            pnlTimKiem.TabIndex = 7;
            // 
            // lblDSDV
            // 
            lblDSDV.AutoSize = true;
            lblDSDV.Location = new Point(309, 16);
            lblDSDV.Name = "lblDSDV";
            lblDSDV.Size = new Size(156, 20);
            lblDSDV.TabIndex = 3;
            lblDSDV.Text = "DANH SÁCH DỊCH VỤ";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(521, 42);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(101, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(293, 46);
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
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Transparent;
            btnLamMoi.Location = new Point(656, 42);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvDichVu
            // 
            dgvDichVu.AllowUserToAddRows = false;
            dgvDichVu.AllowUserToDeleteRows = false;
            dgvDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDichVu.Dock = DockStyle.Fill;
            dgvDichVu.Location = new Point(544, 198);
            dgvDichVu.Name = "dgvDichVu";
            dgvDichVu.ReadOnly = true;
            dgvDichVu.RowHeadersWidth = 51;
            dgvDichVu.Size = new Size(780, 427);
            dgvDichVu.TabIndex = 8;
            dgvDichVu.CellContentClick += dgvDichVu_CellContentClick;
            // 
            // FrmDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 625);
            Controls.Add(dgvDichVu);
            Controls.Add(pnlTimKiem);
            Controls.Add(grpThongTinDichVu);
            Controls.Add(pnlTieuDe);
            Name = "FrmDichVu";
            Text = "FrmDichVu";
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            grpThongTinDichVu.ResumeLayout(false);
            grpThongTinDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numThoiGianDuKien).EndInit();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private GroupBox grpThongTinDichVu;
        private TextBox txtNoiTiem;
        private Label lblNoiTiem;
        private CheckBox chkCoNgayNhac;
        private Label lblNgayNhac;
        private Label lblDonGia;
        private Label lblThoiGianDuKien;
        private Button btnQuayLai;
        private TextBox txtMoTa;
        private Label lblMota;
        private Label lblLoaiDV;
        private Label lblGioiTinh;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtMaDV;
        private Label lblTenDV;
        private Label lblMaDV;
        private TextBox txtTenDV;
        private ComboBox cboLoaiDV;
        private TextBox txtDonGia;
        private NumericUpDown numThoiGianDuKien;
        private Label lblPhut;
        private CheckBox chkTrangThai;
        private TextBox textBox1;
        private Panel pnlTimKiem;
        private Label lblDSDV;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button btnLamMoi;
        private DataGridView dgvDichVu;
    }
}