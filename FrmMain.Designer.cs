namespace QuanLyChamSocThuCung
{
    partial class FrmMain
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
            lblNguoiDung = new Label();
            lblTieuDe = new Label();
            pnlContent = new Panel();
            pnlTrangChu = new Panel();
            lblChaoMung = new Label();
            pnlMenu = new Panel();
            btnDangXuat = new Button();
            btnThongKe = new Button();
            btnHoaDon = new Button();
            btnTiemChung = new Button();
            btnHoSoSucKhoe = new Button();
            btnLichChamSoc = new Button();
            btnDichVu = new Button();
            btnNhanVien = new Button();
            btnThuCung = new Button();
            btnKhachHang = new Button();
            btnTrangChu = new Button();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblNguoiDung);
            pnlHeader.Controls.Add(lblTieuDe);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1475, 70);
            pnlHeader.TabIndex = 1;
            // 
            // lblNguoiDung
            // 
            lblNguoiDung.AutoSize = true;
            lblNguoiDung.Location = new Point(977, 9);
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Size = new Size(117, 20);
            lblNguoiDung.TabIndex = 1;
            lblNguoiDung.Text = "Xin chào, Admin";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(617, 42);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(226, 20);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ CHĂM SÓC THÚ CƯNG";
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(pnlTrangChu);
            pnlContent.Controls.Add(lblChaoMung);
            pnlContent.Dock = DockStyle.Right;
            pnlContent.Location = new Point(226, 70);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1249, 492);
            pnlContent.TabIndex = 4;
            // 
            // pnlTrangChu
            // 
            pnlTrangChu.Location = new Point(529, 132);
            pnlTrangChu.Name = "pnlTrangChu";
            pnlTrangChu.Size = new Size(250, 125);
            pnlTrangChu.TabIndex = 1;
            // 
            // lblChaoMung
            // 
            lblChaoMung.AutoSize = true;
            lblChaoMung.Location = new Point(415, 14);
            lblChaoMung.Name = "lblChaoMung";
            lblChaoMung.Size = new Size(353, 20);
            lblChaoMung.TabIndex = 0;
            lblChaoMung.Text = "CHÀO MỪNG ĐẾN HỆ THỐNG QUẢN LÝ THÚ CƯNG";
            lblChaoMung.Click += lblChaoMung_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnDangXuat);
            pnlMenu.Controls.Add(btnThongKe);
            pnlMenu.Controls.Add(btnHoaDon);
            pnlMenu.Controls.Add(btnTiemChung);
            pnlMenu.Controls.Add(btnHoSoSucKhoe);
            pnlMenu.Controls.Add(btnLichChamSoc);
            pnlMenu.Controls.Add(btnDichVu);
            pnlMenu.Controls.Add(btnNhanVien);
            pnlMenu.Controls.Add(btnThuCung);
            pnlMenu.Controls.Add(btnKhachHang);
            pnlMenu.Controls.Add(btnTrangChu);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 70);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 492);
            pnlMenu.TabIndex = 5;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.Location = new Point(0, 290);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(220, 29);
            btnDangXuat.TabIndex = 10;
            btnDangXuat.Text = "🚪 Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.Location = new Point(0, 261);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(220, 29);
            btnThongKe.TabIndex = 9;
            btnThongKe.Text = "📊 Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.Location = new Point(0, 232);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(220, 29);
            btnHoaDon.TabIndex = 8;
            btnHoaDon.Text = "💰 Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnTiemChung
            // 
            btnTiemChung.Dock = DockStyle.Top;
            btnTiemChung.Location = new Point(0, 203);
            btnTiemChung.Name = "btnTiemChung";
            btnTiemChung.Size = new Size(220, 29);
            btnTiemChung.TabIndex = 7;
            btnTiemChung.Text = "💉 Tiêm chủng";
            btnTiemChung.UseVisualStyleBackColor = true;
            // 
            // btnHoSoSucKhoe
            // 
            btnHoSoSucKhoe.Dock = DockStyle.Top;
            btnHoSoSucKhoe.Location = new Point(0, 174);
            btnHoSoSucKhoe.Name = "btnHoSoSucKhoe";
            btnHoSoSucKhoe.Size = new Size(220, 29);
            btnHoSoSucKhoe.TabIndex = 6;
            btnHoSoSucKhoe.Text = "❤️ Hồ sơ sức khỏe";
            btnHoSoSucKhoe.UseVisualStyleBackColor = true;
            btnHoSoSucKhoe.Click += btnHoSoSucKhoe_Click;
            // 
            // btnLichChamSoc
            // 
            btnLichChamSoc.Dock = DockStyle.Top;
            btnLichChamSoc.Location = new Point(0, 145);
            btnLichChamSoc.Name = "btnLichChamSoc";
            btnLichChamSoc.Size = new Size(220, 29);
            btnLichChamSoc.TabIndex = 5;
            btnLichChamSoc.Text = "📅 Lịch chăm sóc";
            btnLichChamSoc.UseVisualStyleBackColor = true;
            // 
            // btnDichVu
            // 
            btnDichVu.Dock = DockStyle.Top;
            btnDichVu.Location = new Point(0, 116);
            btnDichVu.Name = "btnDichVu";
            btnDichVu.Size = new Size(220, 29);
            btnDichVu.TabIndex = 4;
            btnDichVu.Text = "💊 Dịch vụ";
            btnDichVu.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.Location = new Point(0, 87);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(220, 29);
            btnNhanVien.TabIndex = 3;
            btnNhanVien.Text = "👨 Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnThuCung
            // 
            btnThuCung.Dock = DockStyle.Top;
            btnThuCung.Location = new Point(0, 58);
            btnThuCung.Name = "btnThuCung";
            btnThuCung.Size = new Size(220, 29);
            btnThuCung.TabIndex = 2;
            btnThuCung.Text = "🐶 Thú cưng";
            btnThuCung.UseVisualStyleBackColor = true;
            btnThuCung.Click += btnThuCung_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.Location = new Point(0, 29);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(220, 29);
            btnKhachHang.TabIndex = 1;
            btnKhachHang.Text = "👤 Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Dock = DockStyle.Top;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(220, 29);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "🏠 Trang chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 562);
            Controls.Add(pnlMenu);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ CHĂM SÓC THÚ CƯNG";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlHeader;
        private Label lblNguoiDung;
        private Label lblTieuDe;
        private Panel pnlContent;
        private Label lblChaoMung;
        private Panel pnlMenu;
        private Button btnDangXuat;
        private Button btnThongKe;
        private Button btnHoaDon;
        private Button btnTiemChung;
        private Button btnHoSoSucKhoe;
        private Button btnLichChamSoc;
        private Button btnDichVu;
        private Button btnNhanVien;
        private Button btnThuCung;
        private Button btnKhachHang;
        private Button btnTrangChu;
        private Panel pnlTrangChu;
    }
}