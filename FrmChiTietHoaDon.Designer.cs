namespace QuanLyChamSocThuCung
{
    partial class FrmChiTietHoaDon
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
            grbThongTinCTHoaDon = new GroupBox();
            txtThanhTien = new TextBox();
            lblThanhTien = new Label();
            txtDonGia = new TextBox();
            nudSoLuong = new NumericUpDown();
            lblDG = new Label();
            lblSL = new Label();
            cboDichVu = new ComboBox();
            lblMaDV = new Label();
            cboHoaDon = new ComboBox();
            lblMaHD = new Label();
            grbDSDV = new GroupBox();
            dgvChiTietHoaDon = new DataGridView();
            grbCacChucNang = new GroupBox();
            btnQuayLai = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnLamMoi = new Button();
            lblTongTienHD = new Label();
            txtTongTien = new TextBox();
            pnlTieuDe.SuspendLayout();
            grbThongTinCTHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            grbDSDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
            grbCacChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(808, 41);
            pnlTieuDe.TabIndex = 1;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(73, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(202, 20);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ CHI TIẾT HÓA ĐƠN";
            // 
            // grbThongTinCTHoaDon
            // 
            grbThongTinCTHoaDon.Controls.Add(txtThanhTien);
            grbThongTinCTHoaDon.Controls.Add(lblThanhTien);
            grbThongTinCTHoaDon.Controls.Add(txtDonGia);
            grbThongTinCTHoaDon.Controls.Add(nudSoLuong);
            grbThongTinCTHoaDon.Controls.Add(lblDG);
            grbThongTinCTHoaDon.Controls.Add(lblSL);
            grbThongTinCTHoaDon.Controls.Add(cboDichVu);
            grbThongTinCTHoaDon.Controls.Add(lblMaDV);
            grbThongTinCTHoaDon.Controls.Add(cboHoaDon);
            grbThongTinCTHoaDon.Controls.Add(lblMaHD);
            grbThongTinCTHoaDon.Dock = DockStyle.Top;
            grbThongTinCTHoaDon.Location = new Point(0, 41);
            grbThongTinCTHoaDon.Name = "grbThongTinCTHoaDon";
            grbThongTinCTHoaDon.Size = new Size(808, 189);
            grbThongTinCTHoaDon.TabIndex = 2;
            grbThongTinCTHoaDon.TabStop = false;
            grbThongTinCTHoaDon.Text = "Thông tin chi tiết hóa đơn";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(12, 153);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(343, 27);
            txtThanhTien.TabIndex = 9;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Location = new Point(12, 130);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(81, 20);
            lblThanhTien.TabIndex = 8;
            lblThanhTien.Text = "Thành Tiền";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(390, 100);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(343, 27);
            txtDonGia.TabIndex = 7;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(12, 100);
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(343, 27);
            nudSoLuong.TabIndex = 6;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDG
            // 
            lblDG.AutoSize = true;
            lblDG.Location = new Point(390, 77);
            lblDG.Name = "lblDG";
            lblDG.Size = new Size(62, 20);
            lblDG.TabIndex = 5;
            lblDG.Text = "Đơn giá";
            // 
            // lblSL
            // 
            lblSL.AutoSize = true;
            lblSL.Location = new Point(12, 77);
            lblSL.Name = "lblSL";
            lblSL.Size = new Size(69, 20);
            lblSL.TabIndex = 4;
            lblSL.Text = "Số lượng";
            // 
            // cboDichVu
            // 
            cboDichVu.FormattingEnabled = true;
            cboDichVu.Location = new Point(390, 46);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(343, 28);
            cboDichVu.TabIndex = 3;
            // 
            // lblMaDV
            // 
            lblMaDV.AutoSize = true;
            lblMaDV.Location = new Point(390, 23);
            lblMaDV.Name = "lblMaDV";
            lblMaDV.Size = new Size(81, 20);
            lblMaDV.TabIndex = 2;
            lblMaDV.Text = "Mã dịch vụ";
            // 
            // cboHoaDon
            // 
            cboHoaDon.FormattingEnabled = true;
            cboHoaDon.Location = new Point(12, 46);
            cboHoaDon.Name = "cboHoaDon";
            cboHoaDon.Size = new Size(343, 28);
            cboHoaDon.TabIndex = 1;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Location = new Point(12, 23);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(89, 20);
            lblMaHD.TabIndex = 0;
            lblMaHD.Text = "Mã hóa đơn";
            // 
            // grbDSDV
            // 
            grbDSDV.Controls.Add(dgvChiTietHoaDon);
            grbDSDV.Dock = DockStyle.Top;
            grbDSDV.Location = new Point(0, 230);
            grbDSDV.Name = "grbDSDV";
            grbDSDV.Size = new Size(808, 207);
            grbDSDV.TabIndex = 3;
            grbDSDV.TabStop = false;
            grbDSDV.Text = "Danh Sách Chi tiết Hóa đơn";
            // 
            // dgvChiTietHoaDon
            // 
            dgvChiTietHoaDon.AllowUserToAddRows = false;
            dgvChiTietHoaDon.AllowUserToDeleteRows = false;
            dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHoaDon.Dock = DockStyle.Fill;
            dgvChiTietHoaDon.Location = new Point(3, 23);
            dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            dgvChiTietHoaDon.ReadOnly = true;
            dgvChiTietHoaDon.RowHeadersWidth = 51;
            dgvChiTietHoaDon.Size = new Size(802, 181);
            dgvChiTietHoaDon.TabIndex = 11;
            dgvChiTietHoaDon.CellClick += dgvChiTietHoaDon_CellClick;
            // 
            // grbCacChucNang
            // 
            grbCacChucNang.Controls.Add(btnQuayLai);
            grbCacChucNang.Controls.Add(btnXoa);
            grbCacChucNang.Controls.Add(btnSua);
            grbCacChucNang.Controls.Add(btnThem);
            grbCacChucNang.Controls.Add(btnLamMoi);
            grbCacChucNang.Dock = DockStyle.Top;
            grbCacChucNang.Location = new Point(0, 437);
            grbCacChucNang.Name = "grbCacChucNang";
            grbCacChucNang.Size = new Size(808, 80);
            grbCacChucNang.TabIndex = 4;
            grbCacChucNang.TabStop = false;
            grbCacChucNang.Text = "Các Chức Năng";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(711, 16);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 44;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(121, 45);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 43;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(221, 12);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 42;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(121, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 41;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Transparent;
            btnLamMoi.Location = new Point(221, 45);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTongTienHD
            // 
            lblTongTienHD.AutoSize = true;
            lblTongTienHD.Location = new Point(12, 536);
            lblTongTienHD.Name = "lblTongTienHD";
            lblTongTienHD.Size = new Size(131, 20);
            lblTongTienHD.TabIndex = 5;
            lblTongTienHD.Text = "Tổng tiền hóa đơn";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(441, 536);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(253, 27);
            txtTongTien.TabIndex = 6;
            txtTongTien.Text = "VND";
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // FrmChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 609);
            Controls.Add(txtTongTien);
            Controls.Add(lblTongTienHD);
            Controls.Add(grbCacChucNang);
            Controls.Add(grbDSDV);
            Controls.Add(grbThongTinCTHoaDon);
            Controls.Add(pnlTieuDe);
            Name = "FrmChiTietHoaDon";
            Text = "FrmChiTietHoaDon";
            Load += FrmChiTietHoaDon_Load;
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            grbThongTinCTHoaDon.ResumeLayout(false);
            grbThongTinCTHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            grbDSDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
            grbCacChucNang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private GroupBox grbThongTinCTHoaDon;
        private Label lblDG;
        private Label lblSL;
        private ComboBox cboDichVu;
        private Label lblMaDV;
        private ComboBox cboHoaDon;
        private Label lblMaHD;
        private TextBox txtThanhTien;
        private Label lblThanhTien;
        private TextBox txtDonGia;
        private NumericUpDown nudSoLuong;
        private GroupBox grbDSDV;
        private DataGridView dgvChiTietHoaDon;
        private GroupBox grbCacChucNang;
        private Button btnQuayLai;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnLamMoi;
        private Label lblTongTienHD;
        private TextBox txtTongTien;
    }
}