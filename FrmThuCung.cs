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
    public partial class FrmThuCung : Form
    {
        private readonly ThuCungBUS _thuCungBUS;
        private readonly KhachHangBUS _khachHangBUS;
        public FrmThuCung()
        {
            InitializeComponent();
            txtMaPet.ReadOnly = true;

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.ShowCheckBox = true;

            txtCanNang.Text = "";

            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;

            _thuCungBUS = new ThuCungBUS();
            _khachHangBUS = new KhachHangBUS();

            LoadKhachHang();
            LoadLoai();
            LoadGioiTinh();
            LoadDanhSachThuCung();

        }
        private void LoadKhachHang()
        {
            try
            {
                var danhSach = _khachHangBUS.GetAll();

                cboKhachHang.DataSource = null;
                cboKhachHang.DataSource = danhSach;

                cboKhachHang.DisplayMember = "HoTen";
                cboKhachHang.ValueMember = "MaKh";

                cboKhachHang.SelectedIndex = -1;
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
        private void LoadDanhSachThuCung()
        {
            try
            {
                dgvThuCung.DataSource = null;

                var danhSach = _thuCungBUS.GetAll();

                dgvThuCung.DataSource = danhSach;

                dgvThuCung.Columns["MaPet"].HeaderText = "Mã Pet";
                dgvThuCung.Columns["MaKh"].HeaderText = "Mã KH";
                dgvThuCung.Columns["TenPet"].HeaderText = "Tên thú cưng";
                dgvThuCung.Columns["Loai"].HeaderText = "Loài";
                dgvThuCung.Columns["Giong"].HeaderText = "Giống";
                dgvThuCung.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvThuCung.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvThuCung.Columns["CanNang"].HeaderText = "Cân nặng";
                dgvThuCung.Columns["MauLong"].HeaderText = "Màu lông";
                dgvThuCung.Columns["GhiChu"].HeaderText = "Ghi chú";

                dgvThuCung.Columns["NgaySinh"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvThuCung.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách thú cưng!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void LoadLoai()
        {
            cboLoai.Items.Clear();

            cboLoai.Items.Add("Chó");
            cboLoai.Items.Add("Mèo");
            cboLoai.Items.Add("Chim");
            cboLoai.Items.Add("Cá");
            cboLoai.Items.Add("Thỏ");
            cboLoai.Items.Add("Khác");

            cboLoai.SelectedIndex = -1;
        }
        private void LoadGioiTinh()
        {
            cboGioiTinh.Items.Clear();

            cboGioiTinh.Items.Add("Đực");
            cboGioiTinh.Items.Add("Cái");

            cboGioiTinh.SelectedIndex = -1;
        }


        private void grpThongTinPet_Enter(object sender, EventArgs e)
        {

        }

        private void lbllblTenThuCung_Click(object sender, EventArgs e)
        {

        }

        private void lblMaThuCung_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvThuCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvThuCung.Rows[e.RowIndex];

            txtMaPet.Text = row.Cells["MaPet"].Value?.ToString();

            if (row.Cells["MaKh"].Value != null)
            {
                cboKhachHang.SelectedValue = row.Cells["MaKh"].Value;
            }

            txtTenPet.Text = row.Cells["TenPet"].Value?.ToString();

            if (row.Cells["Loai"].Value != null)
            {
                cboLoai.SelectedItem = row.Cells["Loai"].Value.ToString();
            }

            txtGiong.Text = row.Cells["Giong"].Value?.ToString();

            if (row.Cells["GioiTinh"].Value != null)
            {
                cboGioiTinh.SelectedItem =
                    row.Cells["GioiTinh"].Value.ToString();
            }

            if (row.Cells["NgaySinh"].Value != null &&
                row.Cells["NgaySinh"].Value != DBNull.Value)
            {
                DateOnly ngaySinh =
                    (DateOnly)row.Cells["NgaySinh"].Value;

                dtpNgaySinh.Value = ngaySinh.ToDateTime(TimeOnly.MinValue);
                dtpNgaySinh.Checked = true;
            }
            else
            {
                dtpNgaySinh.Checked = false;
            }

            txtCanNang.Text = row.Cells["CanNang"].Value?.ToString();
            txtMauLong.Text = row.Cells["MauLong"].Value?.ToString();
            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra khách hàng
                if (cboKhachHang.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng!");
                    cboKhachHang.Focus();
                    return;
                }

                // 2. Kiểm tra tên thú cưng
                if (string.IsNullOrWhiteSpace(txtTenPet.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên thú cưng!");
                    txtTenPet.Focus();
                    return;
                }

                // 3. Kiểm tra loài
                if (cboLoai.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn loài!");
                    cboLoai.Focus();
                    return;
                }

                // 4. Kiểm tra cân nặng nếu có nhập
                decimal? canNang = null;

                if (!string.IsNullOrWhiteSpace(txtCanNang.Text))
                {
                    if (!decimal.TryParse(txtCanNang.Text, out decimal giaTriCanNang))
                    {
                        MessageBox.Show("Cân nặng phải là số!");
                        txtCanNang.Focus();
                        return;
                    }

                    if (giaTriCanNang <= 0)
                    {
                        MessageBox.Show("Cân nặng phải lớn hơn 0!");
                        txtCanNang.Focus();
                        return;
                    }

                    canNang = giaTriCanNang;
                }

                // 5. Tạo đối tượng thú cưng
                ThuCung thuCung = new ThuCung
                {
                    MaKh = Convert.ToInt32(cboKhachHang.SelectedValue),

                    TenPet = txtTenPet.Text.Trim(),

                    Loai = cboLoai.SelectedItem.ToString(),

                    Giong = string.IsNullOrWhiteSpace(txtGiong.Text)
                        ? null
                        : txtGiong.Text.Trim(),

                    GioiTinh = cboGioiTinh.SelectedIndex == -1
                        ? null
                        : cboGioiTinh.SelectedItem.ToString(),

                    NgaySinh = dtpNgaySinh.Checked
                        ? DateOnly.FromDateTime(dtpNgaySinh.Value)
                        : null,

                    CanNang = canNang,

                    MauLong = string.IsNullOrWhiteSpace(txtMauLong.Text)
                        ? null
                        : txtMauLong.Text.Trim(),

                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text)
                        ? null
                        : txtGhiChu.Text.Trim()
                };

                // 6. Gọi BUS thêm dữ liệu
                _thuCungBUS.Them(thuCung);

                // 7. Thông báo
                MessageBox.Show(
                    "Thêm thú cưng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // 8. Load lại danh sách
                LoadDanhSachThuCung();

                // 9. Xóa trắng form
                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thêm thú cưng!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void XoaTrang()
        {
            txtMaPet.Clear();

            cboKhachHang.SelectedIndex = -1;
            txtTenPet.Clear();
            cboLoai.SelectedIndex = -1;
            txtGiong.Clear();
            cboGioiTinh.SelectedIndex = -1;

            dtpNgaySinh.Checked = false;

            txtCanNang.Clear();
            txtMauLong.Clear();
            txtGhiChu.Clear();

            txtTimKiem.Clear();

            txtTenPet.Focus();

            dgvThuCung.ClearSelection();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn thú cưng chưa
                if (!int.TryParse(txtMaPet.Text, out int maPet))
                {
                    MessageBox.Show("Vui lòng chọn thú cưng cần sửa!");
                    return;
                }

                // Kiểm tra khách hàng
                if (cboKhachHang.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng!");
                    cboKhachHang.Focus();
                    return;
                }

                // Kiểm tra tên
                if (string.IsNullOrWhiteSpace(txtTenPet.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên thú cưng!");
                    txtTenPet.Focus();
                    return;
                }

                // Kiểm tra loài
                if (cboLoai.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn loài!");
                    cboLoai.Focus();
                    return;
                }

                // Kiểm tra cân nặng
                decimal? canNang = null;

                if (!string.IsNullOrWhiteSpace(txtCanNang.Text))
                {
                    if (!decimal.TryParse(txtCanNang.Text, out decimal giaTriCanNang))
                    {
                        MessageBox.Show("Cân nặng phải là số!");
                        txtCanNang.Focus();
                        return;
                    }

                    if (giaTriCanNang <= 0)
                    {
                        MessageBox.Show("Cân nặng phải lớn hơn 0!");
                        txtCanNang.Focus();
                        return;
                    }

                    canNang = giaTriCanNang;
                }

                // Tạo đối tượng thú cưng
                ThuCung thuCung = new ThuCung
                {
                    MaPet = maPet,

                    MaKh = Convert.ToInt32(cboKhachHang.SelectedValue),

                    TenPet = txtTenPet.Text.Trim(),

                    Loai = cboLoai.SelectedItem.ToString(),

                    Giong = string.IsNullOrWhiteSpace(txtGiong.Text)
                        ? null
                        : txtGiong.Text.Trim(),

                    GioiTinh = cboGioiTinh.SelectedIndex == -1
                        ? null
                        : cboGioiTinh.SelectedItem.ToString(),

                    NgaySinh = dtpNgaySinh.Checked
                        ? DateOnly.FromDateTime(dtpNgaySinh.Value)
                        : null,

                    CanNang = canNang,

                    MauLong = string.IsNullOrWhiteSpace(txtMauLong.Text)
                        ? null
                        : txtMauLong.Text.Trim(),

                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text)
                        ? null
                        : txtGhiChu.Text.Trim()
                };

                // Gọi BUS
                _thuCungBUS.Sua(thuCung);

                MessageBox.Show(
                    "Cập nhật thú cưng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Load lại danh sách
                LoadDanhSachThuCung();

                // Xóa form
                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể sửa thú cưng!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn thú cưng
                if (!int.TryParse(txtMaPet.Text, out int maPet))
                {
                    MessageBox.Show("Vui lòng chọn thú cưng cần xóa!");
                    return;
                }

                // Xác nhận xóa
                DialogResult ketQua = MessageBox.Show(
                    "Bạn có chắc muốn xóa thú cưng này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (ketQua != DialogResult.Yes)
                    return;

                // Gọi BUS xóa
                _thuCungBUS.Xoa(maPet);

                MessageBox.Show(
                    "Xóa thú cưng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Load lại danh sách
                LoadDanhSachThuCung();

                // Xóa dữ liệu trên form
                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa thú cưng!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaTrang();
            LoadDanhSachThuCung();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();

                // Nếu không nhập từ khóa → hiển thị toàn bộ
                if (string.IsNullOrWhiteSpace(tuKhoa))
                {
                    LoadDanhSachThuCung();
                    return;
                }

                dgvThuCung.DataSource = null;

                var danhSach = _thuCungBUS.TimKiem(tuKhoa);

                dgvThuCung.DataSource = danhSach;

                // Đặt lại tên cột
                dgvThuCung.Columns["MaPet"].HeaderText = "Mã Pet";
                dgvThuCung.Columns["MaKh"].HeaderText = "Mã KH";
                dgvThuCung.Columns["TenPet"].HeaderText = "Tên thú cưng";
                dgvThuCung.Columns["Loai"].HeaderText = "Loài";
                dgvThuCung.Columns["Giong"].HeaderText = "Giống";
                dgvThuCung.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvThuCung.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvThuCung.Columns["CanNang"].HeaderText = "Cân nặng";
                dgvThuCung.Columns["MauLong"].HeaderText = "Màu lông";
                dgvThuCung.Columns["GhiChu"].HeaderText = "Ghi chú";

                dgvThuCung.Columns["NgaySinh"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvThuCung.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvThuCung.AllowUserToAddRows = false;

                if (dgvThuCung.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thú cưng phù hợp.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Tìm kiếm thất bại!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
