using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyChamSocThuCung.BUS;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung
{
    public partial class FrmLogin : Form
    {
        private readonly TaiKhoanBUS _taiKhoanBUS;

        public FrmLogin()
        {
            InitializeComponent();
            _taiKhoanBUS = new TaiKhoanBUS();
        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên đăng nhập.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show(
                    "Vui lòng nhập mật khẩu.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMatKhau.Focus();
                return;
            }

            try
            {
                TaiKhoan? taiKhoan =
                    _taiKhoanBUS.DangNhap(tenDangNhap, matKhau);

                if (taiKhoan == null)
                {
                    MessageBox.Show(
                        "Tên đăng nhập hoặc mật khẩu không đúng!",
                        "Đăng nhập thất bại",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                // Truyền tài khoản đã đăng nhập sang FrmMain.
                FrmMain frmMain = new FrmMain(taiKhoan);

                // Không mở màn hình nếu quyền chưa được cấu hình.
                if (!frmMain.QuyenHopLe)
                {
                    MessageBox.Show(
                        "Vai trò của tài khoản chưa được cấu hình đúng.\n" +
                        "Giá trị quyền hiện tại: " +
                        (taiKhoan.Quyen ?? "(chưa có quyền)") +
                        "\nVui lòng kiểm tra cột Quyen trong bảng TaiKhoan.",
                        "Lỗi phân quyền",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    frmMain.Dispose();
                    return;
                }

                this.Hide();

                frmMain.FormClosed += (s, args) =>
                {
                    this.Close();
                };

                frmMain.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra:\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                btnHienMatKhau.Text = "🙈";
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                btnHienMatKhau.Text = "👁";
            }
        }
    }
}
