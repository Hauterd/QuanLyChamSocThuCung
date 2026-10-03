namespace QuanLyChamSocThuCung
{
    partial class FrmThuCung
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
            grpThongTinPet = new GroupBox();
            btnQuayLai = new Button();
            cboKhachHang = new ComboBox();
            txtGhiChu = new TextBox();
            lblGhiChu = new Label();
            ablChuNuoi = new Label();
            txtMauLong = new TextBox();
            txtCanNang = new TextBox();
            lblMauLong = new Label();
            lblCanNang = new Label();
            dtpNgaySinh = new DateTimePicker();
            cboLoai = new ComboBox();
            cboGioiTinh = new ComboBox();
            lblNgaySinh = new Label();
            lblGioiTinh = new Label();
            txtGiong = new TextBox();
            lblGiong = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenPet = new TextBox();
            txtMaPet = new TextBox();
            lblLoai = new Label();
            lblTenThuCung = new Label();
            lblMaThuCung = new Label();
            btnLamMoi = new Button();
            panel1 = new Panel();
            dgvThuCung = new DataGridView();
            pnlTimKiem = new Panel();
            lblDSPet = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            pnlTieuDe.SuspendLayout();
            grpThongTinPet.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuCung).BeginInit();
            pnlTimKiem.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(1503, 73);
            pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(512, 19);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(147, 20);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ THÚ CƯNG";
            // 
            // grpThongTinPet
            // 
            grpThongTinPet.Controls.Add(btnQuayLai);
            grpThongTinPet.Controls.Add(cboKhachHang);
            grpThongTinPet.Controls.Add(txtGhiChu);
            grpThongTinPet.Controls.Add(lblGhiChu);
            grpThongTinPet.Controls.Add(ablChuNuoi);
            grpThongTinPet.Controls.Add(txtMauLong);
            grpThongTinPet.Controls.Add(txtCanNang);
            grpThongTinPet.Controls.Add(lblMauLong);
            grpThongTinPet.Controls.Add(lblCanNang);
            grpThongTinPet.Controls.Add(dtpNgaySinh);
            grpThongTinPet.Controls.Add(cboLoai);
            grpThongTinPet.Controls.Add(cboGioiTinh);
            grpThongTinPet.Controls.Add(lblNgaySinh);
            grpThongTinPet.Controls.Add(lblGioiTinh);
            grpThongTinPet.Controls.Add(txtGiong);
            grpThongTinPet.Controls.Add(lblGiong);
            grpThongTinPet.Controls.Add(btnXoa);
            grpThongTinPet.Controls.Add(btnSua);
            grpThongTinPet.Controls.Add(btnThem);
            grpThongTinPet.Controls.Add(txtTenPet);
            grpThongTinPet.Controls.Add(txtMaPet);
            grpThongTinPet.Controls.Add(lblLoai);
            grpThongTinPet.Controls.Add(lblTenThuCung);
            grpThongTinPet.Controls.Add(lblMaThuCung);
            grpThongTinPet.Dock = DockStyle.Left;
            grpThongTinPet.Location = new Point(0, 73);
            grpThongTinPet.Name = "grpThongTinPet";
            grpThongTinPet.Size = new Size(461, 680);
            grpThongTinPet.TabIndex = 1;
            grpThongTinPet.TabStop = false;
            grpThongTinPet.Text = "Thông tin PET";
            grpThongTinPet.Enter += grpThongTinPet_Enter;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(115, 433);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 33;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(0, 285);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(151, 28);
            cboKhachHang.TabIndex = 32;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(6, 339);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(308, 27);
            txtGhiChu.TabIndex = 31;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(6, 316);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(60, 20);
            lblGhiChu.TabIndex = 30;
            lblGhiChu.Text = "Ghi Chú";
            // 
            // ablChuNuoi
            // 
            ablChuNuoi.AutoSize = true;
            ablChuNuoi.Location = new Point(6, 263);
            ablChuNuoi.Name = "ablChuNuoi";
            ablChuNuoi.Size = new Size(70, 20);
            ablChuNuoi.TabIndex = 28;
            ablChuNuoi.Text = "Chủ Nuôi";
            // 
            // txtMauLong
            // 
            txtMauLong.Location = new Point(175, 233);
            txtMauLong.Name = "txtMauLong";
            txtMauLong.Size = new Size(130, 27);
            txtMauLong.TabIndex = 26;
            // 
            // txtCanNang
            // 
            txtCanNang.Location = new Point(6, 233);
            txtCanNang.Name = "txtCanNang";
            txtCanNang.Size = new Size(151, 27);
            txtCanNang.TabIndex = 25;
            // 
            // lblMauLong
            // 
            lblMauLong.AutoSize = true;
            lblMauLong.Location = new Point(220, 210);
            lblMauLong.Name = "lblMauLong";
            lblMauLong.Size = new Size(75, 20);
            lblMauLong.TabIndex = 24;
            lblMauLong.Text = "Màu Lông";
            // 
            // lblCanNang
            // 
            lblCanNang.AutoSize = true;
            lblCanNang.Location = new Point(34, 210);
            lblCanNang.Name = "lblCanNang";
            lblCanNang.Size = new Size(74, 20);
            lblCanNang.TabIndex = 23;
            lblCanNang.Text = "Cân Nặng";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(175, 179);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(290, 27);
            dtpNgaySinh.TabIndex = 22;
            // 
            // cboLoai
            // 
            cboLoai.FormattingEnabled = true;
            cboLoai.Location = new Point(6, 125);
            cboLoai.Name = "cboLoai";
            cboLoai.Size = new Size(151, 28);
            cboLoai.TabIndex = 21;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Location = new Point(6, 179);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(151, 28);
            cboGioiTinh.TabIndex = 20;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(220, 155);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(74, 20);
            lblNgaySinh.TabIndex = 18;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(34, 156);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(65, 20);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới tính";
            // 
            // txtGiong
            // 
            txtGiong.Location = new Point(175, 125);
            txtGiong.Name = "txtGiong";
            txtGiong.Size = new Size(284, 27);
            txtGiong.TabIndex = 17;
            // 
            // lblGiong
            // 
            lblGiong.AutoSize = true;
            lblGiong.Location = new Point(220, 103);
            lblGiong.Name = "lblGiong";
            lblGiong.Size = new Size(49, 20);
            lblGiong.TabIndex = 16;
            lblGiong.Text = "Giống";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(6, 433);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(115, 385);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 385);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenPet
            // 
            txtTenPet.Location = new Point(175, 75);
            txtTenPet.Name = "txtTenPet";
            txtTenPet.Size = new Size(286, 27);
            txtTenPet.TabIndex = 7;
            // 
            // txtMaPet
            // 
            txtMaPet.Location = new Point(6, 73);
            txtMaPet.Name = "txtMaPet";
            txtMaPet.ReadOnly = true;
            txtMaPet.Size = new Size(125, 27);
            txtMaPet.TabIndex = 6;
            // 
            // lblLoai
            // 
            lblLoai.AutoSize = true;
            lblLoai.Location = new Point(46, 103);
            lblLoai.Name = "lblLoai";
            lblLoai.Size = new Size(37, 20);
            lblLoai.TabIndex = 2;
            lblLoai.Text = "Loài";
            // 
            // lblTenThuCung
            // 
            lblTenThuCung.AutoSize = true;
            lblTenThuCung.Location = new Point(220, 50);
            lblTenThuCung.Name = "lblTenThuCung";
            lblTenThuCung.Size = new Size(102, 20);
            lblTenThuCung.TabIndex = 1;
            lblTenThuCung.Text = "Tên Thú Cưng:";
            lblTenThuCung.Click += lbllblTenThuCung_Click;
            // 
            // lblMaThuCung
            // 
            lblMaThuCung.AutoSize = true;
            lblMaThuCung.Location = new Point(20, 50);
            lblMaThuCung.Name = "lblMaThuCung";
            lblMaThuCung.Size = new Size(100, 20);
            lblMaThuCung.TabIndex = 0;
            lblMaThuCung.Text = "Mã Thú Cưng:";
            lblMaThuCung.Click += lblMaThuCung_Click;
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
            // panel1
            // 
            panel1.Controls.Add(dgvThuCung);
            panel1.Controls.Add(pnlTimKiem);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(461, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 680);
            panel1.TabIndex = 2;
            // 
            // dgvThuCung
            // 
            dgvThuCung.AllowUserToAddRows = false;
            dgvThuCung.AllowUserToDeleteRows = false;
            dgvThuCung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThuCung.Dock = DockStyle.Fill;
            dgvThuCung.Location = new Point(0, 125);
            dgvThuCung.Name = "dgvThuCung";
            dgvThuCung.ReadOnly = true;
            dgvThuCung.RowHeadersWidth = 51;
            dgvThuCung.Size = new Size(1042, 555);
            dgvThuCung.TabIndex = 7;
            dgvThuCung.CellClick += dgvThuCung_CellClick;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(lblDSPet);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(lblTimKiem);
            pnlTimKiem.Controls.Add(btnLamMoi);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(0, 0);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1042, 125);
            pnlTimKiem.TabIndex = 6;
            // 
            // lblDSPet
            // 
            lblDSPet.AutoSize = true;
            lblDSPet.Location = new Point(309, 16);
            lblDSPet.Name = "lblDSPet";
            lblDSPet.Size = new Size(172, 20);
            lblDSPet.TabIndex = 3;
            lblDSPet.Text = "DANH SÁCH THÚ CƯNG";
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
            // FrmThuCung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 753);
            Controls.Add(panel1);
            Controls.Add(grpThongTinPet);
            Controls.Add(pnlTieuDe);
            Name = "FrmThuCung";
            Text = "Thú Cưng";
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            grpThongTinPet.ResumeLayout(false);
            grpThongTinPet.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThuCung).EndInit();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private GroupBox grpThongTinPet;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenPet;
        private TextBox txtMaPet;
        private Label lblLoai;
        private Label lblTenThuCung;
        private Label lblMaThuCung;
        private Label lblGioiTinh;
        private TextBox txtGiong;
        private Label lblGiong;
        private Label lblNgaySinh;
        private Label lblMauLong;
        private Label lblCanNang;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboLoai;
        private ComboBox cboGioiTinh;
        private Label ablChuNuoi;
        private TextBox txtMauLong;
        private TextBox txtCanNang;
        private TextBox txtGhiChu;
        private Label lblGhiChu;
        private Panel panel1;
        private ComboBox cboKhachHang;
        private Panel pnlTimKiem;
        private Label lblDSPet;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private DataGridView dgvThuCung;
        private Button btnQuayLai;
    }
}