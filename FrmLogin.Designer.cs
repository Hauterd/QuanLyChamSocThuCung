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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblDangNhap = new Label();
            groupBox1 = new GroupBox();
            btnHienMatKhau = new Button();
            pictureBox1 = new PictureBox();
            lblDN = new Label();
            btnThoat = new Button();
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDangNhap.ForeColor = Color.DarkSlateGray;
            lblDangNhap.Location = new Point(24, 135);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(351, 20);
            lblDangNhap.TabIndex = 1;
            lblDangNhap.Text = "🐾 Chăm sóc thú cưng – Tận tâm từng khoảnh khắc\r\n";
            lblDangNhap.Click += lblDangNhap_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.BackgroundImageLayout = ImageLayout.Center;
            groupBox1.CausesValidation = false;
            groupBox1.Controls.Add(btnHienMatKhau);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblDN);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(lblDangNhap);
            groupBox1.Cursor = Cursors.Hand;
            groupBox1.Location = new Point(673, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 456);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnHienMatKhau
            // 
            btnHienMatKhau.Cursor = Cursors.Hand;
            btnHienMatKhau.FlatStyle = FlatStyle.Flat;
            btnHienMatKhau.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHienMatKhau.ForeColor = Color.Teal;
            btnHienMatKhau.Location = new Point(323, 218);
            btnHienMatKhau.Name = "btnHienMatKhau";
            btnHienMatKhau.Size = new Size(33, 31);
            btnHienMatKhau.TabIndex = 11;
            btnHienMatKhau.TabStop = false;
            btnHienMatKhau.Text = "👁";
            btnHienMatKhau.UseVisualStyleBackColor = true;
            btnHienMatKhau.Click += btnHienMatKhau_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lblDN
            // 
            lblDN.AutoSize = true;
            lblDN.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDN.Location = new Point(24, 86);
            lblDN.Name = "lblDN";
            lblDN.Size = new Size(332, 38);
            lblDN.TabIndex = 9;
            lblDN.Text = " ĐĂNG NHẬP HỆ THỐNG";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Gainsboro;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.DarkSlateGray;
            btnThoat.Location = new Point(211, 279);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(145, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.LightSeaGreen;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(51, 279);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(144, 29);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(51, 218);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "🔒Mật Khẩu";
            txtMatKhau.Size = new Size(305, 31);
            txtMatKhau.TabIndex = 5;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(51, 174);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "👤Tài Khoản";
            txtTenDangNhap.Size = new Size(305, 31);
            txtTenDangNhap.TabIndex = 4;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 653);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblDangNhap;
        private GroupBox groupBox1;
        private TextBox txtTenDangNhap;
        private Button btnThoat;
        private Button btnDangNhap;
        private TextBox txtMatKhau;
        private Label lblDN;
        private PictureBox pictureBox1;
        private Button btnHienMatKhau;
    }
}