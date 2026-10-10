namespace QuanLyChamSocThuCung
{
    partial class FrmTiemChung
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
            pnlHeader = new Panel();
            lblTieuDe = new Label();
            grpThongTinTiemChung = new GroupBox();
            txtNoiTiem = new TextBox();
            lblNoiTiem = new Label();
            chkCoNgayNhac = new CheckBox();
            dtpNgayNhac = new DateTimePicker();
            lblNgayNhac = new Label();
            numMuiTiem = new NumericUpDown();
            lblMuiTiem = new Label();
            dtpNgayTiem = new DateTimePicker();
            lblNgayTiem = new Label();
            btnQuayLai = new Button();
            txtGhiChu = new TextBox();
            lblGhiChu = new Label();
            txtTenVacXin = new TextBox();
            lblVacXin = new Label();
            cboThuCung = new ComboBox();
            lblGioiTinh = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtMaTiem = new TextBox();
            lblThuCung = new Label();
            lblMaTiem = new Label();
            pnlTimKiem = new Panel();
            lblDSTiemChung = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            btnLamMoi = new Button();
            dgvTiemChung = new DataGridView();
            pnlHeader.SuspendLayout();
            grpThongTinTiemChung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMuiTiem).BeginInit();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTiemChung).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTieuDe);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1339, 70);
            pnlHeader.TabIndex = 2;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(617, 42);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(161, 20);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ TIÊM CHỦNG";
            // 
            // grpThongTinTiemChung
            // 
            grpThongTinTiemChung.Controls.Add(txtNoiTiem);
            grpThongTinTiemChung.Controls.Add(lblNoiTiem);
            grpThongTinTiemChung.Controls.Add(chkCoNgayNhac);
            grpThongTinTiemChung.Controls.Add(dtpNgayNhac);
            grpThongTinTiemChung.Controls.Add(lblNgayNhac);
            grpThongTinTiemChung.Controls.Add(numMuiTiem);
            grpThongTinTiemChung.Controls.Add(lblMuiTiem);
            grpThongTinTiemChung.Controls.Add(dtpNgayTiem);
            grpThongTinTiemChung.Controls.Add(lblNgayTiem);
            grpThongTinTiemChung.Controls.Add(btnQuayLai);
            grpThongTinTiemChung.Controls.Add(txtGhiChu);
            grpThongTinTiemChung.Controls.Add(lblGhiChu);
            grpThongTinTiemChung.Controls.Add(txtTenVacXin);
            grpThongTinTiemChung.Controls.Add(lblVacXin);
            grpThongTinTiemChung.Controls.Add(cboThuCung);
            grpThongTinTiemChung.Controls.Add(lblGioiTinh);
            grpThongTinTiemChung.Controls.Add(btnXoa);
            grpThongTinTiemChung.Controls.Add(btnSua);
            grpThongTinTiemChung.Controls.Add(btnThem);
            grpThongTinTiemChung.Controls.Add(txtMaTiem);
            grpThongTinTiemChung.Controls.Add(lblThuCung);
            grpThongTinTiemChung.Controls.Add(lblMaTiem);
            grpThongTinTiemChung.Dock = DockStyle.Left;
            grpThongTinTiemChung.Location = new Point(0, 70);
            grpThongTinTiemChung.Name = "grpThongTinTiemChung";
            grpThongTinTiemChung.Size = new Size(461, 534);
            grpThongTinTiemChung.TabIndex = 3;
            grpThongTinTiemChung.TabStop = false;
            grpThongTinTiemChung.Text = "THÔNG TIN TIÊM CHỦNG";
            // 
            // txtNoiTiem
            // 
            txtNoiTiem.Location = new Point(0, 362);
            txtNoiTiem.Name = "txtNoiTiem";
            txtNoiTiem.Size = new Size(308, 27);
            txtNoiTiem.TabIndex = 47;
            // 
            // lblNoiTiem
            // 
            lblNoiTiem.AutoSize = true;
            lblNoiTiem.Location = new Point(0, 339);
            lblNoiTiem.Name = "lblNoiTiem";
            lblNoiTiem.Size = new Size(70, 20);
            lblNoiTiem.TabIndex = 46;
            lblNoiTiem.Text = "Nơi Tiêm";
            // 
            // chkCoNgayNhac
            // 
            chkCoNgayNhac.AutoSize = true;
            chkCoNgayNhac.Location = new Point(321, 309);
            chkCoNgayNhac.Name = "chkCoNgayNhac";
            chkCoNgayNhac.Size = new Size(120, 24);
            chkCoNgayNhac.TabIndex = 45;
            chkCoNgayNhac.Text = "Có ngày nhắc";
            chkCoNgayNhac.UseVisualStyleBackColor = true;
            chkCoNgayNhac.CheckedChanged += chkCoNgayNhac_CheckedChanged;
            // 
            // dtpNgayNhac
            // 
            dtpNgayNhac.CustomFormat = "dd/MM/yyyy";
            dtpNgayNhac.Enabled = false;
            dtpNgayNhac.Format = DateTimePickerFormat.Custom;
            dtpNgayNhac.Location = new Point(0, 309);
            dtpNgayNhac.Name = "dtpNgayNhac";
            dtpNgayNhac.Size = new Size(290, 27);
            dtpNgayNhac.TabIndex = 44;
            // 
            // lblNgayNhac
            // 
            lblNgayNhac.AutoSize = true;
            lblNgayNhac.Location = new Point(3, 286);
            lblNgayNhac.Name = "lblNgayNhac";
            lblNgayNhac.Size = new Size(82, 20);
            lblNgayNhac.TabIndex = 43;
            lblNgayNhac.Text = "Ngày nhắc:";
            // 
            // numMuiTiem
            // 
            numMuiTiem.Location = new Point(0, 203);
            numMuiTiem.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMuiTiem.Name = "numMuiTiem";
            numMuiTiem.Size = new Size(150, 27);
            numMuiTiem.TabIndex = 42;
            numMuiTiem.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblMuiTiem
            // 
            lblMuiTiem.AutoSize = true;
            lblMuiTiem.Location = new Point(0, 180);
            lblMuiTiem.Name = "lblMuiTiem";
            lblMuiTiem.Size = new Size(71, 20);
            lblMuiTiem.TabIndex = 41;
            lblMuiTiem.Text = "Mũi tiêm:";
            // 
            // dtpNgayTiem
            // 
            dtpNgayTiem.CustomFormat = "dd/MM/yyyy";
            dtpNgayTiem.Format = DateTimePickerFormat.Custom;
            dtpNgayTiem.Location = new Point(0, 256);
            dtpNgayTiem.Name = "dtpNgayTiem";
            dtpNgayTiem.Size = new Size(290, 27);
            dtpNgayTiem.TabIndex = 40;
            // 
            // lblNgayTiem
            // 
            lblNgayTiem.AutoSize = true;
            lblNgayTiem.Location = new Point(0, 233);
            lblNgayTiem.Name = "lblNgayTiem";
            lblNgayTiem.Size = new Size(81, 20);
            lblNgayTiem.TabIndex = 39;
            lblNgayTiem.Text = "Ngày tiêm:";
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
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(-4, 415);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(308, 27);
            txtGhiChu.TabIndex = 31;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(-4, 392);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(60, 20);
            lblGhiChu.TabIndex = 30;
            lblGhiChu.Text = "Ghi Chú";
            // 
            // txtTenVacXin
            // 
            txtTenVacXin.Location = new Point(0, 150);
            txtTenVacXin.Name = "txtTenVacXin";
            txtTenVacXin.Size = new Size(151, 27);
            txtTenVacXin.TabIndex = 25;
            // 
            // lblVacXin
            // 
            lblVacXin.AutoSize = true;
            lblVacXin.Location = new Point(0, 127);
            lblVacXin.Name = "lblVacXin";
            lblVacXin.Size = new Size(81, 20);
            lblVacXin.TabIndex = 23;
            lblVacXin.Text = "Tên vắc xin";
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
            btnXoa.Location = new Point(0, 483);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
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
            // txtMaTiem
            // 
            txtMaTiem.Dock = DockStyle.Left;
            txtMaTiem.Location = new Point(3, 43);
            txtMaTiem.Name = "txtMaTiem";
            txtMaTiem.ReadOnly = true;
            txtMaTiem.Size = new Size(227, 27);
            txtMaTiem.TabIndex = 6;
            // 
            // lblThuCung
            // 
            lblThuCung.AutoSize = true;
            lblThuCung.Location = new Point(3, 73);
            lblThuCung.Name = "lblThuCung";
            lblThuCung.Size = new Size(73, 20);
            lblThuCung.TabIndex = 2;
            lblThuCung.Text = "Thú cưng:";
            // 
            // lblMaTiem
            // 
            lblMaTiem.AutoSize = true;
            lblMaTiem.Dock = DockStyle.Top;
            lblMaTiem.Location = new Point(3, 23);
            lblMaTiem.Name = "lblMaTiem";
            lblMaTiem.Size = new Size(67, 20);
            lblMaTiem.TabIndex = 0;
            lblMaTiem.Text = "Mã Tiêm";
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(lblDSTiemChung);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(lblTimKiem);
            pnlTimKiem.Controls.Add(btnLamMoi);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(461, 70);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(878, 125);
            pnlTimKiem.TabIndex = 8;
            // 
            // lblDSTiemChung
            // 
            lblDSTiemChung.AutoSize = true;
            lblDSTiemChung.Location = new Point(309, 16);
            lblDSTiemChung.Name = "lblDSTiemChung";
            lblDSTiemChung.Size = new Size(186, 20);
            lblDSTiemChung.TabIndex = 3;
            lblDSTiemChung.Text = "DANH SÁCH TIÊM CHỦNG";
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
            // dgvTiemChung
            // 
            dgvTiemChung.AllowUserToAddRows = false;
            dgvTiemChung.AllowUserToDeleteRows = false;
            dgvTiemChung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTiemChung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiemChung.Dock = DockStyle.Fill;
            dgvTiemChung.Location = new Point(461, 195);
            dgvTiemChung.Name = "dgvTiemChung";
            dgvTiemChung.ReadOnly = true;
            dgvTiemChung.RowHeadersWidth = 51;
            dgvTiemChung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTiemChung.Size = new Size(878, 409);
            dgvTiemChung.TabIndex = 9;
            dgvTiemChung.CellContentClick += dgvTiemChung_CellContentClick;
            // 
            // FrmTiemChung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 604);
            Controls.Add(dgvTiemChung);
            Controls.Add(pnlTimKiem);
            Controls.Add(grpThongTinTiemChung);
            Controls.Add(pnlHeader);
            Name = "FrmTiemChung";
            Text = "FrmTiemChung";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpThongTinTiemChung.ResumeLayout(false);
            grpThongTinTiemChung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMuiTiem).EndInit();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTiemChung).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTieuDe;
        private GroupBox grpThongTinTiemChung;
        private DateTimePicker dtpNgayTiem;
        private Label lblNgayTiem;
        private Button btnQuayLai;
        private TextBox txtGhiChu;
        private Label lblGhiChu;
        private TextBox txtTenVacXin;
        private Label lblVacXin;
        private ComboBox cboThuCung;
        private Label lblGioiTinh;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtMaTiem;
        private Label lblThuCung;
        private Label lblMaTiem;
        private Panel pnlTimKiem;
        private Label lblDSTiemChung;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button btnLamMoi;
        private NumericUpDown numMuiTiem;
        private Label lblMuiTiem;
        private DateTimePicker dtpNgayNhac;
        private Label lblNgayNhac;
        private CheckBox chkCoNgayNhac;
        private TextBox txtNoiTiem;
        private Label lblNoiTiem;
        private DataGridView dgvTiemChung;
    }
}