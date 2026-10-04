namespace QuanLyChamSocThuCung
{
    partial class FrmHoSoSucKhoe
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
            lblMaHoSo = new Label();
            lblThuCung = new Label();
            txtMaHoSo = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            lblGioiTinh = new Label();
            cboThuCung = new ComboBox();
            lblCanNang = new Label();
            txtCanNang = new TextBox();
            txtTinhTrangSucKhoe = new TextBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            btnQuayLai = new Button();
            lblTinhTrangSucKhoe = new Label();
            lblTienSuBenh = new Label();
            grpThongTinHoSo = new GroupBox();
            dtpNgayCapNhat = new DateTimePicker();
            lblNgayCapNhat = new Label();
            txtDiUng = new TextBox();
            lblDiUng = new Label();
            txtTienSuBenh = new TextBox();
            pnlTimKiem = new Panel();
            lblDSPet = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            btnLamMoi = new Button();
            dgvHoSoSucKhoe = new DataGridView();
            pnlTieuDe.SuspendLayout();
            grpThongTinHoSo.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoSoSucKhoe).BeginInit();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(1478, 73);
            pnlTieuDe.TabIndex = 1;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(512, 19);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(211, 20);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = " HỒ SƠ SỨC KHỎE THÚ CƯNG";
            // 
            // lblMaHoSo
            // 
            lblMaHoSo.AutoSize = true;
            lblMaHoSo.Dock = DockStyle.Top;
            lblMaHoSo.Location = new Point(3, 23);
            lblMaHoSo.Name = "lblMaHoSo";
            lblMaHoSo.Size = new Size(75, 20);
            lblMaHoSo.TabIndex = 0;
            lblMaHoSo.Text = "Mã Hồ Sơ";
            // 
            // lblThuCung
            // 
            lblThuCung.AutoSize = true;
            lblThuCung.Location = new Point(3, 73);
            lblThuCung.Name = "lblThuCung";
            lblThuCung.Size = new Size(73, 20);
            lblThuCung.TabIndex = 2;
            lblThuCung.Text = "Thú cưng:";
            lblThuCung.Click += lblLoai_Click;
            // 
            // txtMaHoSo
            // 
            txtMaHoSo.Dock = DockStyle.Left;
            txtMaHoSo.Location = new Point(3, 43);
            txtMaHoSo.Name = "txtMaHoSo";
            txtMaHoSo.ReadOnly = true;
            txtMaHoSo.Size = new Size(227, 27);
            txtMaHoSo.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(0, 448);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(109, 448);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(0, 483);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(315, 316);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(0, 20);
            lblGioiTinh.TabIndex = 3;
            // 
            // cboThuCung
            // 
            cboThuCung.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThuCung.FormattingEnabled = true;
            cboThuCung.Location = new Point(0, 96);
            cboThuCung.Name = "cboThuCung";
            cboThuCung.Size = new Size(151, 28);
            cboThuCung.TabIndex = 21;
            // 
            // lblCanNang
            // 
            lblCanNang.AutoSize = true;
            lblCanNang.Location = new Point(0, 127);
            lblCanNang.Name = "lblCanNang";
            lblCanNang.Size = new Size(74, 20);
            lblCanNang.TabIndex = 23;
            lblCanNang.Text = "Cân Nặng";
            lblCanNang.Click += lblCanNang_Click;
            // 
            // txtCanNang
            // 
            txtCanNang.Location = new Point(0, 150);
            txtCanNang.Name = "txtCanNang";
            txtCanNang.Size = new Size(151, 27);
            txtCanNang.TabIndex = 25;
            // 
            // txtTinhTrangSucKhoe
            // 
            txtTinhTrangSucKhoe.Location = new Point(0, 203);
            txtTinhTrangSucKhoe.Name = "txtTinhTrangSucKhoe";
            txtTinhTrangSucKhoe.Size = new Size(130, 27);
            txtTinhTrangSucKhoe.TabIndex = 26;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(-4, 392);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(60, 20);
            lblGhiChu.TabIndex = 30;
            lblGhiChu.Text = "Ghi Chú";
            lblGhiChu.Click += lblGhiChu_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(-4, 415);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(308, 27);
            txtGhiChu.TabIndex = 31;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(109, 483);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 33;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // lblTinhTrangSucKhoe
            // 
            lblTinhTrangSucKhoe.AutoSize = true;
            lblTinhTrangSucKhoe.Location = new Point(-1, 180);
            lblTinhTrangSucKhoe.Name = "lblTinhTrangSucKhoe";
            lblTinhTrangSucKhoe.Size = new Size(79, 20);
            lblTinhTrangSucKhoe.TabIndex = 34;
            lblTinhTrangSucKhoe.Text = "Tình trạng:";
            // 
            // lblTienSuBenh
            // 
            lblTienSuBenh.AutoSize = true;
            lblTienSuBenh.Location = new Point(-1, 233);
            lblTienSuBenh.Name = "lblTienSuBenh";
            lblTienSuBenh.Size = new Size(96, 20);
            lblTienSuBenh.TabIndex = 35;
            lblTienSuBenh.Text = "Tiền sử bệnh:";
            // 
            // grpThongTinHoSo
            // 
            grpThongTinHoSo.Controls.Add(dtpNgayCapNhat);
            grpThongTinHoSo.Controls.Add(lblNgayCapNhat);
            grpThongTinHoSo.Controls.Add(txtDiUng);
            grpThongTinHoSo.Controls.Add(lblDiUng);
            grpThongTinHoSo.Controls.Add(txtTienSuBenh);
            grpThongTinHoSo.Controls.Add(lblTienSuBenh);
            grpThongTinHoSo.Controls.Add(lblTinhTrangSucKhoe);
            grpThongTinHoSo.Controls.Add(btnQuayLai);
            grpThongTinHoSo.Controls.Add(txtGhiChu);
            grpThongTinHoSo.Controls.Add(lblGhiChu);
            grpThongTinHoSo.Controls.Add(txtTinhTrangSucKhoe);
            grpThongTinHoSo.Controls.Add(txtCanNang);
            grpThongTinHoSo.Controls.Add(lblCanNang);
            grpThongTinHoSo.Controls.Add(cboThuCung);
            grpThongTinHoSo.Controls.Add(lblGioiTinh);
            grpThongTinHoSo.Controls.Add(btnXoa);
            grpThongTinHoSo.Controls.Add(btnSua);
            grpThongTinHoSo.Controls.Add(btnThem);
            grpThongTinHoSo.Controls.Add(txtMaHoSo);
            grpThongTinHoSo.Controls.Add(lblThuCung);
            grpThongTinHoSo.Controls.Add(lblMaHoSo);
            grpThongTinHoSo.Dock = DockStyle.Left;
            grpThongTinHoSo.Location = new Point(0, 73);
            grpThongTinHoSo.Name = "grpThongTinHoSo";
            grpThongTinHoSo.Size = new Size(461, 627);
            grpThongTinHoSo.TabIndex = 2;
            grpThongTinHoSo.TabStop = false;
            grpThongTinHoSo.Text = "THÔNG TIN HỒ SƠ";
            // 
            // dtpNgayCapNhat
            // 
            dtpNgayCapNhat.CustomFormat = "dd/MM/yyyy";
            dtpNgayCapNhat.Location = new Point(-1, 362);
            dtpNgayCapNhat.Name = "dtpNgayCapNhat";
            dtpNgayCapNhat.Size = new Size(290, 27);
            dtpNgayCapNhat.TabIndex = 40;
            // 
            // lblNgayCapNhat
            // 
            lblNgayCapNhat.AutoSize = true;
            lblNgayCapNhat.Location = new Point(0, 339);
            lblNgayCapNhat.Name = "lblNgayCapNhat";
            lblNgayCapNhat.Size = new Size(108, 20);
            lblNgayCapNhat.TabIndex = 39;
            lblNgayCapNhat.Text = "Ngày cập nhật:";
            // 
            // txtDiUng
            // 
            txtDiUng.Location = new Point(0, 309);
            txtDiUng.Name = "txtDiUng";
            txtDiUng.Size = new Size(130, 27);
            txtDiUng.TabIndex = 38;
            // 
            // lblDiUng
            // 
            lblDiUng.AutoSize = true;
            lblDiUng.Location = new Point(-1, 286);
            lblDiUng.Name = "lblDiUng";
            lblDiUng.Size = new Size(57, 20);
            lblDiUng.TabIndex = 37;
            lblDiUng.Text = "Dị ứng:";
            // 
            // txtTienSuBenh
            // 
            txtTienSuBenh.Location = new Point(0, 256);
            txtTienSuBenh.Name = "txtTienSuBenh";
            txtTienSuBenh.Size = new Size(130, 27);
            txtTienSuBenh.TabIndex = 36;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(lblDSPet);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(lblTimKiem);
            pnlTimKiem.Controls.Add(btnLamMoi);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(461, 73);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1017, 125);
            pnlTimKiem.TabIndex = 7;
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
            // dgvHoSoSucKhoe
            // 
            dgvHoSoSucKhoe.AllowUserToAddRows = false;
            dgvHoSoSucKhoe.AllowUserToDeleteRows = false;
            dgvHoSoSucKhoe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoSoSucKhoe.Dock = DockStyle.Fill;
            dgvHoSoSucKhoe.Location = new Point(461, 198);
            dgvHoSoSucKhoe.Name = "dgvHoSoSucKhoe";
            dgvHoSoSucKhoe.ReadOnly = true;
            dgvHoSoSucKhoe.RowHeadersWidth = 51;
            dgvHoSoSucKhoe.Size = new Size(1017, 502);
            dgvHoSoSucKhoe.TabIndex = 8;
            dgvHoSoSucKhoe.CellContentClick += dgvHoSoSucKhoe_CellContentClick;
            // 
            // FrmHoSoSucKhoe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 700);
            Controls.Add(dgvHoSoSucKhoe);
            Controls.Add(pnlTimKiem);
            Controls.Add(grpThongTinHoSo);
            Controls.Add(pnlTieuDe);
            Name = "FrmHoSoSucKhoe";
            Text = "HoSoSucKhoe";
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            grpThongTinHoSo.ResumeLayout(false);
            grpThongTinHoSo.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoSoSucKhoe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Label lblMaHoSo;
        private Label lblThuCung;
        private TextBox txtMaHoSo;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label lblGioiTinh;
        private ComboBox cboThuCung;
        private Label lblCanNang;
        private TextBox txtCanNang;
        private TextBox txtTinhTrangSucKhoe;
        private Label lblGhiChu;
        private TextBox txtGhiChu;
        private Button btnQuayLai;
        private Label lblTinhTrangSucKhoe;
        private Label lblTienSuBenh;
        private GroupBox grpThongTinHoSo;
        private TextBox txtTienSuBenh;
        private TextBox txtDiUng;
        private Label lblDiUng;
        private Label lblNgayCapNhat;
        private DateTimePicker dtpNgayCapNhat;
        private Panel pnlTimKiem;
        private Label lblDSPet;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button btnLamMoi;
        private DataGridView dgvHoSoSucKhoe;
    }
}