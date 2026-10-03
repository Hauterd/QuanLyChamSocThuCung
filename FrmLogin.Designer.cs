namespace QuanLyChamSocThuCung
{
    partial class FrmLogin
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
            lblTieuDe = new Label();
            lblDangNhap = new Label();
            lblTenDangNhap = new Label();
            groupBox1 = new GroupBox();
            chkHienMatKhau = new CheckBox();
            btnThoat = new Button();
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(22, 30);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(198, 20);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Quản Lý Chăm Sóc Thú Cưng";
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Location = new Point(172, 47);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(154, 20);
            lblDangNhap.TabIndex = 1;
            lblDangNhap.Text = "Đăng Nhập Hệ Thống";
            lblDangNhap.Click += lblDangNhap_Click;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(32, 92);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(107, 20);
            lblTenDangNhap.TabIndex = 2;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkHienMatKhau);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(lblMatKhau);
            groupBox1.Controls.Add(lblDangNhap);
            groupBox1.Controls.Add(lblTenDangNhap);
            groupBox1.Location = new Point(415, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 319);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giao Diện Đăng Nhập";
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(43, 189);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(129, 24);
            chkHienMatKhau.TabIndex = 8;
            chkHienMatKhau.Text = "Hiện Mật Khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(232, 231);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(118, 231);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(94, 29);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(166, 146);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(154, 27);
            txtMatKhau.TabIndex = 5;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(172, 89);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(154, 27);
            txtTenDangNhap.TabIndex = 4;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(43, 146);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(70, 20);
            lblMatKhau.TabIndex = 3;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1473, 557);
            Controls.Add(groupBox1);
            Controls.Add(lblTieuDe);
            Name = "FrmLogin";
            Text = "FrmLogin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblDangNhap;
        private Label lblTenDangNhap;
        private GroupBox groupBox1;
        private TextBox txtTenDangNhap;
        private Label lblMatKhau;
        private CheckBox chkHienMatKhau;
        private Button btnThoat;
        private Button btnDangNhap;
        private TextBox txtMatKhau;
    }
}