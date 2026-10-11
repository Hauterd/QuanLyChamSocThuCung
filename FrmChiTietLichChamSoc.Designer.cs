namespace QuanLyChamSocThuCung
{
    partial class FrmChiTietLichChamSoc
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
            panel1 = new Panel();
            lbTieuDe = new Label();
            grbCTLichChamSoc = new GroupBox();
            txtThanhTien = new TextBox();
            lblThanhTien = new Label();
            txtDonGia = new TextBox();
            lblDonGia = new Label();
            nudSoLuong = new NumericUpDown();
            lblSoLuong = new Label();
            cboDichVu = new ComboBox();
            lblDichVu = new Label();
            txtMaLich = new TextBox();
            lblMaLich = new Label();
            pnlTien = new Panel();
            grbTongTien = new GroupBox();
            txtGhiChu = new TextBox();
            lblGhiChu = new Label();
            lblTongTien = new Label();
            lblTongTienTieuDe = new Label();
            panel2 = new Panel();
            grbDSCT = new GroupBox();
            dgvChiTietLich = new DataGridView();
            panel3 = new Panel();
            pnlTimKiem = new Panel();
            lblDSDV = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnLamMoi = new Button();
            panel4 = new Panel();
            btnQuayLai = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel1.SuspendLayout();
            grbCTLichChamSoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            grbTongTien.SuspendLayout();
            grbDSCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietLich).BeginInit();
            pnlTimKiem.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTieuDe);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 69);
            panel1.TabIndex = 0;
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTieuDe.Location = new Point(356, 18);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(359, 41);
            lbTieuDe.TabIndex = 0;
            lbTieuDe.Text = "CHI TIẾT LỊCH CHĂM SÓC";
            lbTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbCTLichChamSoc
            // 
            grbCTLichChamSoc.Controls.Add(txtThanhTien);
            grbCTLichChamSoc.Controls.Add(lblThanhTien);
            grbCTLichChamSoc.Controls.Add(txtDonGia);
            grbCTLichChamSoc.Controls.Add(lblDonGia);
            grbCTLichChamSoc.Controls.Add(nudSoLuong);
            grbCTLichChamSoc.Controls.Add(lblSoLuong);
            grbCTLichChamSoc.Controls.Add(cboDichVu);
            grbCTLichChamSoc.Controls.Add(lblDichVu);
            grbCTLichChamSoc.Controls.Add(txtMaLich);
            grbCTLichChamSoc.Controls.Add(lblMaLich);
            grbCTLichChamSoc.Controls.Add(pnlTien);
            grbCTLichChamSoc.Location = new Point(0, 75);
            grbCTLichChamSoc.Name = "grbCTLichChamSoc";
            grbCTLichChamSoc.Size = new Size(334, 224);
            grbCTLichChamSoc.TabIndex = 1;
            grbCTLichChamSoc.TabStop = false;
            grbCTLichChamSoc.Text = "Thông tin chi tiết lịch chăm sóc";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(138, 151);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(150, 27);
            txtThanhTien.TabIndex = 12;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Location = new Point(6, 151);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(81, 20);
            lblThanhTien.TabIndex = 11;
            lblThanhTien.Text = "Thành tiền:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(138, 118);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(150, 27);
            txtDonGia.TabIndex = 10;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(6, 119);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(65, 20);
            lblDonGia.TabIndex = 9;
            lblDonGia.Text = "Đơn giá:";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(138, 85);
            nudSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(150, 27);
            nudSoLuong.TabIndex = 8;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(6, 84);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(72, 20);
            lblSoLuong.TabIndex = 7;
            lblSoLuong.Text = "Số lượng:";
            // 
            // cboDichVu
            // 
            cboDichVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDichVu.FormattingEnabled = true;
            cboDichVu.Location = new Point(138, 51);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(190, 28);
            cboDichVu.TabIndex = 6;
            // 
            // lblDichVu
            // 
            lblDichVu.AutoSize = true;
            lblDichVu.Location = new Point(6, 54);
            lblDichVu.Name = "lblDichVu";
            lblDichVu.Size = new Size(61, 20);
            lblDichVu.TabIndex = 5;
            lblDichVu.Text = "Dịch vụ:";
            // 
            // txtMaLich
            // 
            txtMaLich.Location = new Point(138, 20);
            txtMaLich.Name = "txtMaLich";
            txtMaLich.ReadOnly = true;
            txtMaLich.Size = new Size(125, 27);
            txtMaLich.TabIndex = 4;
            // 
            // lblMaLich
            // 
            lblMaLich.AutoSize = true;
            lblMaLich.Location = new Point(6, 23);
            lblMaLich.Name = "lblMaLich";
            lblMaLich.Size = new Size(126, 20);
            lblMaLich.TabIndex = 3;
            lblMaLich.Text = "Mã lịch chăm sóc:";
            // 
            // pnlTien
            // 
            pnlTien.Location = new Point(6, 230);
            pnlTien.Name = "pnlTien";
            pnlTien.Size = new Size(244, 125);
            pnlTien.TabIndex = 2;
            // 
            // grbTongTien
            // 
            grbTongTien.Controls.Add(txtGhiChu);
            grbTongTien.Controls.Add(lblGhiChu);
            grbTongTien.Controls.Add(lblTongTien);
            grbTongTien.Controls.Add(lblTongTienTieuDe);
            grbTongTien.Controls.Add(panel2);
            grbTongTien.Location = new Point(0, 308);
            grbTongTien.Name = "grbTongTien";
            grbTongTien.Size = new Size(334, 183);
            grbTongTien.TabIndex = 2;
            grbTongTien.TabStop = false;
            grbTongTien.Text = "Tổng tiền của các dịch vụ ";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(6, 102);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(322, 75);
            txtGhiChu.TabIndex = 16;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(6, 79);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(63, 20);
            lblGhiChu.TabIndex = 15;
            lblGhiChu.Text = "Ghi Chú:";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(276, 44);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(52, 20);
            lblTongTien.TabIndex = 14;
            lblTongTien.Text = "0 VNĐ";
            // 
            // lblTongTienTieuDe
            // 
            lblTongTienTieuDe.AutoSize = true;
            lblTongTienTieuDe.Location = new Point(0, 44);
            lblTongTienTieuDe.Name = "lblTongTienTieuDe";
            lblTongTienTieuDe.Size = new Size(128, 20);
            lblTongTienTieuDe.TabIndex = 13;
            lblTongTienTieuDe.Text = "Tổng tiền dự kiến:";
            // 
            // panel2
            // 
            panel2.Location = new Point(6, 230);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 125);
            panel2.TabIndex = 2;
            // 
            // grbDSCT
            // 
            grbDSCT.Controls.Add(dgvChiTietLich);
            grbDSCT.Controls.Add(panel3);
            grbDSCT.Location = new Point(340, 75);
            grbDSCT.Name = "grbDSCT";
            grbDSCT.Size = new Size(621, 306);
            grbDSCT.TabIndex = 3;
            grbDSCT.TabStop = false;
            grbDSCT.Text = "Danh Sách Chi tiết Chăm Sóc";
            // 
            // dgvChiTietLich
            // 
            dgvChiTietLich.AllowUserToAddRows = false;
            dgvChiTietLich.AllowUserToDeleteRows = false;
            dgvChiTietLich.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietLich.Dock = DockStyle.Fill;
            dgvChiTietLich.Location = new Point(3, 23);
            dgvChiTietLich.MultiSelect = false;
            dgvChiTietLich.Name = "dgvChiTietLich";
            dgvChiTietLich.ReadOnly = true;
            dgvChiTietLich.RowHeadersWidth = 51;
            dgvChiTietLich.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietLich.Size = new Size(615, 280);
            dgvChiTietLich.TabIndex = 3;
            dgvChiTietLich.CellClick += dgvChiTietLich_CellClick;
            // 
            // panel3
            // 
            panel3.Location = new Point(6, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(244, 125);
            panel3.TabIndex = 2;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(lblDSDV);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(btnLamMoi);
            pnlTimKiem.Location = new Point(340, 387);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(630, 98);
            pnlTimKiem.TabIndex = 8;
            // 
            // lblDSDV
            // 
            lblDSDV.AutoSize = true;
            lblDSDV.Location = new Point(0, 0);
            lblDSDV.Name = "lblDSDV";
            lblDSDV.Size = new Size(182, 20);
            lblDSDV.TabIndex = 3;
            lblDSDV.Text = "Tìm kiếm dịch vụ cần thiết";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(321, 37);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(101, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(6, 37);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(292, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Transparent;
            btnLamMoi.Location = new Point(450, 36);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnQuayLai);
            panel4.Controls.Add(btnXoa);
            panel4.Controls.Add(btnSua);
            panel4.Controls.Add(btnThem);
            panel4.Location = new Point(0, 491);
            panel4.Name = "panel4";
            panel4.Size = new Size(961, 96);
            panel4.TabIndex = 9;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(855, 21);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 37;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(238, 21);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 36;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(138, 21);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 35;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(38, 21);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 34;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // FrmChiTietLichChamSoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 590);
            Controls.Add(panel4);
            Controls.Add(pnlTimKiem);
            Controls.Add(grbDSCT);
            Controls.Add(grbTongTien);
            Controls.Add(grbCTLichChamSoc);
            Controls.Add(panel1);
            Name = "FrmChiTietLichChamSoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmChiTietLichChamSoc";
            Load += FrmChiTietLichChamSoc_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbCTLichChamSoc.ResumeLayout(false);
            grbCTLichChamSoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            grbTongTien.ResumeLayout(false);
            grbTongTien.PerformLayout();
            grbDSCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTietLich).EndInit();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox grbCTLichChamSoc;
        private Panel pnlTien;
        private GroupBox grbTongTien;
        private Panel panel2;
        private GroupBox grbDSCT;
        private Panel panel3;
        private Panel pnlTimKiem;
        private Label lblDSDV;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Button btnLamMoi;
        private Panel panel4;
        private Label lbTieuDe;
        private Button btnQuayLai;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label lblMaLich;
        private Label lblDichVu;
        private TextBox txtMaLich;
        private TextBox txtDonGia;
        private Label lblDonGia;
        private NumericUpDown nudSoLuong;
        private Label lblSoLuong;
        private ComboBox cboDichVu;
        private TextBox txtThanhTien;
        private Label lblThanhTien;
        private DataGridView dgvChiTietLich;
        private Label lblTongTien;
        private Label lblTongTienTieuDe;
        private TextBox txtGhiChu;
        private Label lblGhiChu;
    }
}