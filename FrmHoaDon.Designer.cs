namespace QuanLyChamSocThuCung
{
    partial class FrmHoaDon
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
            grbThongTinHoaDon = new GroupBox();
            txtGhiChu = new TextBox();
            lblGhiChu = new Label();
            dtpNgayLap = new DateTimePicker();
            lblNgLap = new Label();
            cboTrangThai = new ComboBox();
            lblTrangThai = new Label();
            cboNhanVien = new ComboBox();
            lblNV = new Label();
            cboPhuongThucTt = new ComboBox();
            lblPTTT = new Label();
            cboKhachHang = new ComboBox();
            lblKhachHang = new Label();
            txtTongTien = new TextBox();
            lblTongTien = new Label();
            txtMaHd = new TextBox();
            lblMaHD = new Label();
            grbDSDV = new GroupBox();
            dgvChiTietHoaDon = new DataGridView();
            pnlTimKiem = new Panel();
            nudSoLuong = new NumericUpDown();
            lblSL = new Label();
            cboDichVu = new ComboBox();
            lblDV = new Label();
            btnThemDichVu = new Button();
            btnTimKiemDichVu = new Button();
            txtTimKiemDichVu = new TextBox();
            btnLamMoi = new Button();
            grbCacChucNang = new GroupBox();
            btnXuatExcel = new Button();
            btnChiTiet = new Button();
            btnQuayLai = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            grbLuoiDSHD = new GroupBox();
            dgvHoaDon = new DataGridView();
            pnlTieuDe.SuspendLayout();
            grbThongTinHoaDon.SuspendLayout();
            grbDSDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            grbCacChucNang.SuspendLayout();
            grbLuoiDSHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(960, 41);
            pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(73, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(142, 20);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // grbThongTinHoaDon
            // 
            grbThongTinHoaDon.Controls.Add(txtGhiChu);
            grbThongTinHoaDon.Controls.Add(lblGhiChu);
            grbThongTinHoaDon.Controls.Add(dtpNgayLap);
            grbThongTinHoaDon.Controls.Add(lblNgLap);
            grbThongTinHoaDon.Controls.Add(cboTrangThai);
            grbThongTinHoaDon.Controls.Add(lblTrangThai);
            grbThongTinHoaDon.Controls.Add(cboNhanVien);
            grbThongTinHoaDon.Controls.Add(lblNV);
            grbThongTinHoaDon.Controls.Add(cboPhuongThucTt);
            grbThongTinHoaDon.Controls.Add(lblPTTT);
            grbThongTinHoaDon.Controls.Add(cboKhachHang);
            grbThongTinHoaDon.Controls.Add(lblKhachHang);
            grbThongTinHoaDon.Controls.Add(txtTongTien);
            grbThongTinHoaDon.Controls.Add(lblTongTien);
            grbThongTinHoaDon.Controls.Add(txtMaHd);
            grbThongTinHoaDon.Controls.Add(lblMaHD);
            grbThongTinHoaDon.Dock = DockStyle.Top;
            grbThongTinHoaDon.Location = new Point(0, 41);
            grbThongTinHoaDon.Name = "grbThongTinHoaDon";
            grbThongTinHoaDon.Size = new Size(960, 233);
            grbThongTinHoaDon.TabIndex = 1;
            grbThongTinHoaDon.TabStop = false;
            grbThongTinHoaDon.Text = "Thông tin hóa đơn";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(671, 162);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(264, 65);
            txtGhiChu.TabIndex = 15;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(485, 162);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(63, 20);
            lblGhiChu.TabIndex = 14;
            lblGhiChu.Text = "Ghi Chú:";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Short;
            dtpNgayLap.Location = new Point(158, 162);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(264, 27);
            dtpNgayLap.TabIndex = 13;
            // 
            // lblNgLap
            // 
            lblNgLap.AutoSize = true;
            lblNgLap.Location = new Point(55, 162);
            lblNgLap.Name = "lblNgLap";
            lblNgLap.Size = new Size(75, 20);
            lblNgLap.TabIndex = 12;
            lblNgLap.Text = "Ngày Lập:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(671, 113);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(264, 28);
            cboTrangThai.TabIndex = 11;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(485, 121);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(81, 20);
            lblTrangThai.TabIndex = 10;
            lblTrangThai.Text = "Trạng Thái:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(158, 118);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(264, 28);
            cboNhanVien.TabIndex = 9;
            // 
            // lblNV
            // 
            lblNV.AutoSize = true;
            lblNV.Location = new Point(55, 121);
            lblNV.Name = "lblNV";
            lblNV.Size = new Size(80, 20);
            lblNV.TabIndex = 8;
            lblNV.Text = "Nhân Viên:";
            // 
            // cboPhuongThucTt
            // 
            cboPhuongThucTt.FormattingEnabled = true;
            cboPhuongThucTt.Location = new Point(671, 68);
            cboPhuongThucTt.Name = "cboPhuongThucTt";
            cboPhuongThucTt.Size = new Size(264, 28);
            cboPhuongThucTt.TabIndex = 7;
            // 
            // lblPTTT
            // 
            lblPTTT.AutoSize = true;
            lblPTTT.Location = new Point(485, 71);
            lblPTTT.Name = "lblPTTT";
            lblPTTT.Size = new Size(180, 20);
            lblPTTT.TabIndex = 6;
            lblPTTT.Text = "Phương thước thanh toán:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(158, 68);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(264, 28);
            cboKhachHang.TabIndex = 5;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Location = new Point(55, 71);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(92, 20);
            lblKhachHang.TabIndex = 4;
            lblKhachHang.Text = "Khách Hàng:";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(671, 20);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(125, 27);
            txtTongTien.TabIndex = 3;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(485, 27);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(78, 20);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "Tổng Tiền:";
            // 
            // txtMaHd
            // 
            txtMaHd.Location = new Point(158, 20);
            txtMaHd.Name = "txtMaHd";
            txtMaHd.ReadOnly = true;
            txtMaHd.Size = new Size(125, 27);
            txtMaHd.TabIndex = 1;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Location = new Point(55, 23);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(97, 20);
            lblMaHD.TabIndex = 0;
            lblMaHD.Text = "Mã Hóa Đơn:";
            // 
            // grbDSDV
            // 
            grbDSDV.Controls.Add(dgvChiTietHoaDon);
            grbDSDV.Controls.Add(pnlTimKiem);
            grbDSDV.Dock = DockStyle.Top;
            grbDSDV.Location = new Point(0, 274);
            grbDSDV.Name = "grbDSDV";
            grbDSDV.Size = new Size(960, 207);
            grbDSDV.TabIndex = 2;
            grbDSDV.TabStop = false;
            grbDSDV.Text = "Danh Sách Dịch Vụ";
            // 
            // dgvChiTietHoaDon
            // 
            dgvChiTietHoaDon.AllowUserToAddRows = false;
            dgvChiTietHoaDon.AllowUserToDeleteRows = false;
            dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHoaDon.Dock = DockStyle.Left;
            dgvChiTietHoaDon.Location = new Point(3, 23);
            dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            dgvChiTietHoaDon.ReadOnly = true;
            dgvChiTietHoaDon.RowHeadersWidth = 51;
            dgvChiTietHoaDon.Size = new Size(657, 181);
            dgvChiTietHoaDon.TabIndex = 11;
            dgvChiTietHoaDon.CellClick += dgvDichVu_CellClick;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(nudSoLuong);
            pnlTimKiem.Controls.Add(lblSL);
            pnlTimKiem.Controls.Add(cboDichVu);
            pnlTimKiem.Controls.Add(lblDV);
            pnlTimKiem.Controls.Add(btnThemDichVu);
            pnlTimKiem.Controls.Add(btnTimKiemDichVu);
            pnlTimKiem.Controls.Add(txtTimKiemDichVu);
            pnlTimKiem.Location = new Point(666, 23);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(288, 178);
            pnlTimKiem.TabIndex = 10;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(24, 110);
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(245, 27);
            nudSoLuong.TabIndex = 7;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSL
            // 
            lblSL.AutoSize = true;
            lblSL.Location = new Point(19, 87);
            lblSL.Name = "lblSL";
            lblSL.Size = new Size(75, 20);
            lblSL.TabIndex = 6;
            lblSL.Text = "Số Lượng:";
            // 
            // cboDichVu
            // 
            cboDichVu.FormattingEnabled = true;
            cboDichVu.Location = new Point(24, 56);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(245, 28);
            cboDichVu.TabIndex = 5;
            // 
            // lblDV
            // 
            lblDV.AutoSize = true;
            lblDV.Location = new Point(19, 33);
            lblDV.Name = "lblDV";
            lblDV.Size = new Size(63, 20);
            lblDV.TabIndex = 4;
            lblDV.Text = "Dịch Vụ:";
            // 
            // btnThemDichVu
            // 
            btnThemDichVu.Location = new Point(5, 143);
            btnThemDichVu.Name = "btnThemDichVu";
            btnThemDichVu.Size = new Size(170, 29);
            btnThemDichVu.TabIndex = 3;
            btnThemDichVu.Text = "Thêm Dịch Vụ";
            btnThemDichVu.UseVisualStyleBackColor = true;
            btnThemDichVu.Click += btnThemDichVu_Click;
            // 
            // btnTimKiemDichVu
            // 
            btnTimKiemDichVu.Location = new Point(181, 143);
            btnTimKiemDichVu.Name = "btnTimKiemDichVu";
            btnTimKiemDichVu.Size = new Size(101, 29);
            btnTimKiemDichVu.TabIndex = 2;
            btnTimKiemDichVu.Text = "Tìm";
            btnTimKiemDichVu.UseVisualStyleBackColor = true;
            btnTimKiemDichVu.Click += btnTimKiemDichVu_Click;
            // 
            // txtTimKiemDichVu
            // 
            txtTimKiemDichVu.Location = new Point(24, 3);
            txtTimKiemDichVu.Name = "txtTimKiemDichVu";
            txtTimKiemDichVu.Size = new Size(245, 27);
            txtTimKiemDichVu.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Transparent;
            btnLamMoi.Location = new Point(421, 16);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // grbCacChucNang
            // 
            grbCacChucNang.Controls.Add(btnXuatExcel);
            grbCacChucNang.Controls.Add(btnChiTiet);
            grbCacChucNang.Controls.Add(btnQuayLai);
            grbCacChucNang.Controls.Add(btnXoa);
            grbCacChucNang.Controls.Add(btnSua);
            grbCacChucNang.Controls.Add(btnThem);
            grbCacChucNang.Controls.Add(btnLamMoi);
            grbCacChucNang.Dock = DockStyle.Top;
            grbCacChucNang.Location = new Point(0, 481);
            grbCacChucNang.Name = "grbCacChucNang";
            grbCacChucNang.Size = new Size(960, 52);
            grbCacChucNang.TabIndex = 3;
            grbCacChucNang.TabStop = false;
            grbCacChucNang.Text = "Các Chức Năng";
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(621, 16);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(94, 29);
            btnXuatExcel.TabIndex = 46;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnChiTiet
            // 
            btnChiTiet.Location = new Point(521, 16);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(94, 29);
            btnChiTiet.TabIndex = 45;
            btnChiTiet.Text = "Chi tiết";
            btnChiTiet.UseVisualStyleBackColor = true;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(860, 16);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 44;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(321, 16);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 43;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(221, 16);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 42;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(121, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 41;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // grbLuoiDSHD
            // 
            grbLuoiDSHD.Controls.Add(dgvHoaDon);
            grbLuoiDSHD.Dock = DockStyle.Top;
            grbLuoiDSHD.Location = new Point(0, 533);
            grbLuoiDSHD.Name = "grbLuoiDSHD";
            grbLuoiDSHD.Size = new Size(960, 106);
            grbLuoiDSHD.TabIndex = 4;
            grbLuoiDSHD.TabStop = false;
            grbLuoiDSHD.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(3, 23);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(954, 80);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // FrmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 650);
            Controls.Add(grbLuoiDSHD);
            Controls.Add(grbCacChucNang);
            Controls.Add(grbDSDV);
            Controls.Add(grbThongTinHoaDon);
            Controls.Add(pnlTieuDe);
            Name = "FrmHoaDon";
            Text = "FrmHoaDon";
            Load += FrmHoaDon_Load;
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            grbThongTinHoaDon.ResumeLayout(false);
            grbThongTinHoaDon.PerformLayout();
            grbDSDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            grbCacChucNang.ResumeLayout(false);
            grbLuoiDSHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private GroupBox grbThongTinHoaDon;
        private TextBox txtTongTien;
        private Label lblTongTien;
        private TextBox txtMaHd;
        private Label lblMaHD;
        private ComboBox cboPhuongThucTt;
        private Label lblPTTT;
        private ComboBox cboKhachHang;
        private Label lblKhachHang;
        private ComboBox cboTrangThai;
        private Label lblTrangThai;
        private ComboBox cboNhanVien;
        private Label lblNV;
        private TextBox txtGhiChu;
        private Label lblGhiChu;
        private DateTimePicker dtpNgayLap;
        private Label lblNgLap;
        private GroupBox grbDSDV;
        private Panel pnlTimKiem;
        private Button btnTimKiemDichVu;
        private TextBox txtTimKiemDichVu;
        private Button btnLamMoi;
        private Button btnThemDichVu;
        private GroupBox grbCacChucNang;
        private Label lblDV;
        private Label lblSL;
        private ComboBox cboDichVu;
        private NumericUpDown nudSoLuong;
        private DataGridView dgvChiTietHoaDon;
        private Button btnChiTiet;
        private Button btnQuayLai;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox grbLuoiDSHD;
        private DataGridView dgvHoaDon;
        private Button btnXuatExcel;
    }
}