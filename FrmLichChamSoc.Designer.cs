namespace QuanLyChamSocThuCung
{
    partial class FrmLichChamSoc
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
            grbLichChamSoc = new GroupBox();
            cboTrangThai = new ComboBox();
            lblTrangThai = new Label();
            btnQuayLai = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtGhiChu = new TextBox();
            lblGhiChu = new Label();
            dtpGioHen = new DateTimePicker();
            lblGioHen = new Label();
            dtpNgayHen = new DateTimePicker();
            lblNgayHen = new Label();
            cboNhanVien = new ComboBox();
            lblNhanVien = new Label();
            cboThuCung = new ComboBox();
            lblThuCung = new Label();
            txtMaLich = new TextBox();
            lblMaLich = new Label();
            pnlTimKiem = new Panel();
            lblDSLich = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            btnLamMoi = new Button();
            dgvLichChamSoc = new DataGridView();
            lblTieuDeTongTien = new Label();
            lblTongTien = new Label();
            btnChiTiet = new Button();
            pnlTieuDe.SuspendLayout();
            grbLichChamSoc.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichChamSoc).BeginInit();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(1227, 87);
            pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(256, 25);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(261, 20);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ LỊCH CHĂM SÓC THÚ CƯNG";
            // 
            // grbLichChamSoc
            // 
            grbLichChamSoc.Controls.Add(btnChiTiet);
            grbLichChamSoc.Controls.Add(cboTrangThai);
            grbLichChamSoc.Controls.Add(lblTrangThai);
            grbLichChamSoc.Controls.Add(btnQuayLai);
            grbLichChamSoc.Controls.Add(btnXoa);
            grbLichChamSoc.Controls.Add(btnSua);
            grbLichChamSoc.Controls.Add(btnThem);
            grbLichChamSoc.Controls.Add(txtGhiChu);
            grbLichChamSoc.Controls.Add(lblGhiChu);
            grbLichChamSoc.Controls.Add(dtpGioHen);
            grbLichChamSoc.Controls.Add(lblGioHen);
            grbLichChamSoc.Controls.Add(dtpNgayHen);
            grbLichChamSoc.Controls.Add(lblNgayHen);
            grbLichChamSoc.Controls.Add(cboNhanVien);
            grbLichChamSoc.Controls.Add(lblNhanVien);
            grbLichChamSoc.Controls.Add(cboThuCung);
            grbLichChamSoc.Controls.Add(lblThuCung);
            grbLichChamSoc.Controls.Add(txtMaLich);
            grbLichChamSoc.Controls.Add(lblMaLich);
            grbLichChamSoc.Dock = DockStyle.Left;
            grbLichChamSoc.Location = new Point(0, 87);
            grbLichChamSoc.Name = "grbLichChamSoc";
            grbLichChamSoc.Size = new Size(329, 511);
            grbLichChamSoc.TabIndex = 1;
            grbLichChamSoc.TabStop = false;
            grbLichChamSoc.Text = "Lịch Chăm Sóc Thú Cưng";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(6, 207);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 39;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(6, 184);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(75, 20);
            lblTrangThai.TabIndex = 38;
            lblTrangThai.Text = "Trạng thái";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(212, 448);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 37;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(3, 448);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 36;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(112, 413);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 35;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 413);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 34;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(3, 380);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(289, 27);
            txtGhiChu.TabIndex = 11;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(3, 357);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(63, 20);
            lblGhiChu.TabIndex = 10;
            lblGhiChu.Text = "Ghi Chú:";
            // 
            // dtpGioHen
            // 
            dtpGioHen.Format = DateTimePickerFormat.Time;
            dtpGioHen.Location = new Point(3, 327);
            dtpGioHen.Name = "dtpGioHen";
            dtpGioHen.ShowUpDown = true;
            dtpGioHen.Size = new Size(250, 27);
            dtpGioHen.TabIndex = 9;
            // 
            // lblGioHen
            // 
            lblGioHen.AutoSize = true;
            lblGioHen.Location = new Point(3, 304);
            lblGioHen.Name = "lblGioHen";
            lblGioHen.Size = new Size(63, 20);
            lblGioHen.TabIndex = 8;
            lblGioHen.Text = "Giờ Hẹn";
            // 
            // dtpNgayHen
            // 
            dtpNgayHen.Format = DateTimePickerFormat.Short;
            dtpNgayHen.Location = new Point(3, 271);
            dtpNgayHen.Name = "dtpNgayHen";
            dtpNgayHen.Size = new Size(250, 27);
            dtpNgayHen.TabIndex = 7;
            // 
            // lblNgayHen
            // 
            lblNgayHen.AutoSize = true;
            lblNgayHen.Location = new Point(3, 248);
            lblNgayHen.Name = "lblNgayHen";
            lblNgayHen.Size = new Size(75, 20);
            lblNgayHen.TabIndex = 6;
            lblNgayHen.Text = "Ngày Hẹn";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(6, 153);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(151, 28);
            cboNhanVien.TabIndex = 5;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new Point(6, 130);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(77, 20);
            lblNhanVien.TabIndex = 4;
            lblNhanVien.Text = "Nhân Viên";
            // 
            // cboThuCung
            // 
            cboThuCung.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThuCung.FormattingEnabled = true;
            cboThuCung.Location = new Point(6, 99);
            cboThuCung.Name = "cboThuCung";
            cboThuCung.Size = new Size(151, 28);
            cboThuCung.TabIndex = 3;
            // 
            // lblThuCung
            // 
            lblThuCung.AutoSize = true;
            lblThuCung.Location = new Point(6, 76);
            lblThuCung.Name = "lblThuCung";
            lblThuCung.Size = new Size(72, 20);
            lblThuCung.TabIndex = 2;
            lblThuCung.Text = "Thú Cưng";
            // 
            // txtMaLich
            // 
            txtMaLich.Location = new Point(6, 46);
            txtMaLich.Name = "txtMaLich";
            txtMaLich.ReadOnly = true;
            txtMaLich.Size = new Size(125, 27);
            txtMaLich.TabIndex = 1;
            // 
            // lblMaLich
            // 
            lblMaLich.AutoSize = true;
            lblMaLich.Location = new Point(6, 23);
            lblMaLich.Name = "lblMaLich";
            lblMaLich.Size = new Size(60, 20);
            lblMaLich.TabIndex = 0;
            lblMaLich.Text = "Mã lịch:";
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(lblDSLich);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(lblTimKiem);
            pnlTimKiem.Controls.Add(btnLamMoi);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(329, 87);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(898, 125);
            pnlTimKiem.TabIndex = 9;
            // 
            // lblDSLich
            // 
            lblDSLich.AutoSize = true;
            lblDSLich.Location = new Point(309, 16);
            lblDSLich.Name = "lblDSLich";
            lblDSLich.Size = new Size(197, 20);
            lblDSLich.TabIndex = 3;
            lblDSLich.Text = "LỊCH CHĂM SÓC THÚ CƯNG";
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
            // dgvLichChamSoc
            // 
            dgvLichChamSoc.AllowUserToAddRows = false;
            dgvLichChamSoc.AllowUserToDeleteRows = false;
            dgvLichChamSoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichChamSoc.Dock = DockStyle.Top;
            dgvLichChamSoc.Location = new Point(329, 212);
            dgvLichChamSoc.Name = "dgvLichChamSoc";
            dgvLichChamSoc.ReadOnly = true;
            dgvLichChamSoc.RowHeadersWidth = 51;
            dgvLichChamSoc.Size = new Size(898, 188);
            dgvLichChamSoc.TabIndex = 10;
            dgvLichChamSoc.CellContentClick += dgvLichChamSoc_CellContentClick;
            // 
            // lblTieuDeTongTien
            // 
            lblTieuDeTongTien.AutoSize = true;
            lblTieuDeTongTien.Location = new Point(687, 479);
            lblTieuDeTongTien.Name = "lblTieuDeTongTien";
            lblTieuDeTongTien.Size = new Size(149, 20);
            lblTieuDeTongTien.TabIndex = 11;
            lblTieuDeTongTien.Text = "TỔNG TIỀN DỰ KIẾN:";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(908, 479);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(52, 20);
            lblTongTien.TabIndex = 12;
            lblTongTien.Text = "0 VNĐ";
            // 
            // btnChiTiet
            // 
            btnChiTiet.Location = new Point(112, 448);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(94, 29);
            btnChiTiet.TabIndex = 40;
            btnChiTiet.Text = "Chi tiết";
            btnChiTiet.UseVisualStyleBackColor = true;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // FrmLichChamSoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 598);
            Controls.Add(lblTongTien);
            Controls.Add(lblTieuDeTongTien);
            Controls.Add(dgvLichChamSoc);
            Controls.Add(pnlTimKiem);
            Controls.Add(grbLichChamSoc);
            Controls.Add(pnlTieuDe);
            Name = "FrmLichChamSoc";
            Text = "FrmLichChamSoc";
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            grbLichChamSoc.ResumeLayout(false);
            grbLichChamSoc.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichChamSoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private GroupBox grbLichChamSoc;
        private Label lblThuCung;
        private TextBox txtMaLich;
        private Label lblMaLich;
        private Label lblNgayHen;
        private ComboBox cboNhanVien;
        private Label lblNhanVien;
        private ComboBox cboThuCung;
        private DateTimePicker dtpGioHen;
        private Label lblGioHen;
        private DateTimePicker dtpNgayHen;
        private TextBox txtGhiChu;
        private Label lblGhiChu;
        private Button btnQuayLai;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel pnlTimKiem;
        private Label lblDSLich;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button btnLamMoi;
        private DataGridView dgvLichChamSoc;
        private ComboBox cboTrangThai;
        private Label lblTrangThai;
        private Label lblTieuDeTongTien;
        private Label lblTongTien;
        private Button btnChiTiet;
    }
}