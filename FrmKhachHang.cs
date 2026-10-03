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
    public partial class FrmKhachHang : Form
    {
        private readonly KhachHangBUS _khachHangBUS;
        public FrmKhachHang()
        {
            InitializeComponent();
            _khachHangBUS = new KhachHangBUS();

            LoadDanhSachKhachHang();
        }
        private void LoadDanhSachKhachHang()
        {
            try
            {
                dgvKhachHang.DataSource = null;

                var danhSach = _khachHangBUS.GetAll();

                dgvKhachHang.DataSource = danhSach;

                CauHinhDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách khách hàng!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

            txtMaKH.Text = row.Cells["MaKh"].Value?.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
            txtSDT.Text = row.Cells["Sdt"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên khách hàng!");
                    txtHoTen.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!");
                    txtSDT.Focus();
                    return;
                }

                KhachHang khachHang = new KhachHang
                {
                    HoTen = txtHoTen.Text.Trim(),
                    Sdt = txtSDT.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    GhiChu = txtGhiChu.Text.Trim()
                };

                _khachHangBUS.Them(khachHang);

                MessageBox.Show(
                    "Thêm khách hàng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachKhachHang();

                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thêm khách hàng!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void XoaTrang()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtGhiChu.Clear();

            txtHoTen.Focus();

            dgvKhachHang.ClearSelection();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaKH.Text, out int maKh))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên!");
                    txtHoTen.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!");
                    txtSDT.Focus();
                    return;
                }

                var khachHang = new KhachHang
                {
                    MaKh = maKh,
                    HoTen = txtHoTen.Text.Trim(),
                    Sdt = txtSDT.Text.Trim(),
                    Email = string.IsNullOrWhiteSpace(txtEmail.Text)
                        ? null : txtEmail.Text.Trim(),
                    DiaChi = string.IsNullOrWhiteSpace(txtDiaChi.Text)
                        ? null : txtDiaChi.Text.Trim(),
                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text)
                        ? null : txtGhiChu.Text.Trim()
                };

                _khachHangBUS.Sua(khachHang);

                MessageBox.Show("Cập nhật khách hàng thành công!");

                LoadDanhSachKhachHang();
                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể sửa khách hàng!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaKH.Text, out int maKh))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                    return;
                }

                DialogResult ketQua = MessageBox.Show(
                    "Bạn có chắc muốn xóa khách hàng này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (ketQua != DialogResult.Yes)
                    return;

                _khachHangBUS.Xoa(maKh);

                MessageBox.Show("Xóa khách hàng thành công!");

                LoadDanhSachKhachHang();
                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa khách hàng!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaTrang();
            LoadDanhSachKhachHang();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();

                if (string.IsNullOrWhiteSpace(tuKhoa))
                {
                    LoadDanhSachKhachHang();
                    return;
                }
                dgvKhachHang.DataSource = null;

                var danhSach = _khachHangBUS.TimKiem(tuKhoa);

                dgvKhachHang.DataSource = danhSach;

                CauHinhDataGridView();

                if (dgvKhachHang.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng phù hợp.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Tìm kiếm thất bại!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void CauHinhDataGridView()
        {
            if (dgvKhachHang.Columns["MaKh"] != null)
                dgvKhachHang.Columns["MaKh"].HeaderText = "Mã KH";

            if (dgvKhachHang.Columns["HoTen"] != null)
                dgvKhachHang.Columns["HoTen"].HeaderText = "Họ tên";

            if (dgvKhachHang.Columns["Sdt"] != null)
                dgvKhachHang.Columns["Sdt"].HeaderText = "Số điện thoại";

            if (dgvKhachHang.Columns["Email"] != null)
                dgvKhachHang.Columns["Email"].HeaderText = "Email";

            if (dgvKhachHang.Columns["DiaChi"] != null)
                dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";

            if (dgvKhachHang.Columns["NgayDangKy"] != null)
            {
                dgvKhachHang.Columns["NgayDangKy"].HeaderText = "Ngày đăng ký";

                dgvKhachHang.Columns["NgayDangKy"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvKhachHang.Columns["GhiChu"] != null)
                dgvKhachHang.Columns["GhiChu"].HeaderText = "Ghi chú";

            dgvKhachHang.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvKhachHang.AllowUserToAddRows = false;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
