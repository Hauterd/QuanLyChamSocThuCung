namespace QuanLyChamSocThuCung
{
    partial class FrmNhanVien
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
            grpNhanVien = new GroupBox();
            lblTrangThai = new Label();
            chkTrangThai = new CheckBox();
            cboChucVu = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            rdoNu = new RadioButton();
            lblGioiTinh = new Label();
            rdoNam = new RadioButton();
            btnQuayLai = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            txtSdt = new TextBox();
            txtHoTen = new TextBox();
            txtMaNV = new TextBox();
            lblChucVu = new Label();
            lblDiaChi = new Label();
            lblSdt = new Label();
            lblHoTen = new Label();
            lblMaNV = new Label();
            pnlTimKiem = new Panel();
            lblDSNV = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            btnLamMoi = new Button();
            dgvNhanVien = new DataGridView();
            pnlTieuDe.SuspendLayout();
            grpNhanVien.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(1340, 73);
            pnlTieuDe.TabIndex = 2;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(558, 24);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(156, 20);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = " QUẢN LÝ NHÂN VIÊN";
            // 
            // grpNhanVien
            // 
            grpNhanVien.Controls.Add(lblTrangThai);
            grpNhanVien.Controls.Add(chkTrangThai);
            grpNhanVien.Controls.Add(cboChucVu);
            grpNhanVien.Controls.Add(dtpNgaySinh);
            grpNhanVien.Controls.Add(lblNgaySinh);
            grpNhanVien.Controls.Add(rdoNu);
            grpNhanVien.Controls.Add(lblGioiTinh);
            grpNhanVien.Controls.Add(rdoNam);
            grpNhanVien.Controls.Add(btnQuayLai);
            grpNhanVien.Controls.Add(btnXoa);
            grpNhanVien.Controls.Add(btnSua);
            grpNhanVien.Controls.Add(btnThem);
            grpNhanVien.Controls.Add(txtDiaChi);
            grpNhanVien.Controls.Add(txtSdt);
            grpNhanVien.Controls.Add(txtHoTen);
            grpNhanVien.Controls.Add(txtMaNV);
            grpNhanVien.Controls.Add(lblChucVu);
            grpNhanVien.Controls.Add(lblDiaChi);
            grpNhanVien.Controls.Add(lblSdt);
            grpNhanVien.Controls.Add(lblHoTen);
            grpNhanVien.Controls.Add(lblMaNV);
            grpNhanVien.Dock = DockStyle.Left;
            grpNhanVien.Location = new Point(0, 73);
            grpNhanVien.Name = "grpNhanVien";
            grpNhanVien.Size = new Size(439, 618);
            grpNhanVien.TabIndex = 3;
            grpNhanVien.TabStop = false;
            grpNhanVien.Text = "Thông tin Nhân viên";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(32, 491);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 45;
            lblTrangThai.Text = "Trạng Thái";
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Location = new Point(139, 490);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(126, 24);
            chkTrangThai.TabIndex = 44;
            chkTrangThai.Text = "Đang làm việc";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(24, 447);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(162, 28);
            cboChucVu.TabIndex = 43;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Location = new Point(24, 245);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(290, 27);
            dtpNgaySinh.TabIndex = 42;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(25, 222);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(77, 20);
            lblNgaySinh.TabIndex = 41;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(190, 185);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 37;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(27, 187);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(65, 20);
            lblGioiTinh.TabIndex = 36;
            lblGioiTinh.Text = "Giới tính";
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(112, 185);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 35;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(312, 540);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 34;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(212, 540);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(112, 540);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 540);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(28, 380);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(386, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(25, 314);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(186, 27);
            txtSdt.TabIndex = 8;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(28, 137);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(286, 27);
            txtHoTen.TabIndex = 7;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(28, 73);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(125, 27);
            txtMaNV.TabIndex = 6;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(25, 424);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(63, 20);
            lblChucVu.TabIndex = 5;
            lblChucVu.Text = "Chức Vụ";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(27, 357);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(55, 20);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // lblSdt
            // 
            lblSdt.AutoSize = true;
            lblSdt.Location = new Point(24, 291);
            lblSdt.Name = "lblSdt";
            lblSdt.Size = new Size(100, 20);
            lblSdt.TabIndex = 2;
            lblSdt.Text = "Số điện thoại:";
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
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(28, 50);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(100, 20);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã nhân viên:";
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(lblDSNV);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(lblTimKiem);
            pnlTimKiem.Controls.Add(btnLamMoi);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(439, 73);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(901, 125);
            pnlTimKiem.TabIndex = 8;
            // 
            // lblDSNV
            // 
            lblDSNV.AutoSize = true;
            lblDSNV.Location = new Point(293, 12);
            lblDSNV.Name = "lblDSNV";
            lblDSNV.Size = new Size(177, 20);
            lblDSNV.TabIndex = 3;
            lblDSNV.Text = "DANH SÁCH NHÂN VIÊN";
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
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(439, 198);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(901, 493);
            dgvNhanVien.TabIndex = 9;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 691);
            Controls.Add(dgvNhanVien);
            Controls.Add(pnlTimKiem);
            Controls.Add(grpNhanVien);
            Controls.Add(pnlTieuDe);
            Name = "FrmNhanVien";
            Text = "FrmNhanVien";
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            grpNhanVien.ResumeLayout(false);
            grpNhanVien.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private GroupBox grpNhanVien;
        private Button btnQuayLai;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtDiaChi;
        private TextBox txtSdt;
        private TextBox txtHoTen;
        private TextBox txtMaNV;
        private Label lblChucVu;
        private Label lblDiaChi;
        private Label lblSdt;
        private Label lblHoTen;
        private Label lblMaNV;
        private RadioButton rdoNu;
        private Label lblGioiTinh;
        private RadioButton rdoNam;
        private DateTimePicker dtpNgaySinh;
        private Label lblNgaySinh;
        private CheckBox chkTrangThai;
        private ComboBox cboChucVu;
        private Label lblTrangThai;
        private Panel pnlTimKiem;
        private Label lblDSNV;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button btnLamMoi;
        private DataGridView dgvNhanVien;
    }
}