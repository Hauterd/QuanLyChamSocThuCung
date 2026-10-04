using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using QuanLyChamSocThuCung.BUS;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung
{
    public partial class FrmHoSoSucKhoe : Form
    {
        private readonly HoSoSucKhoeBUS _hoSoSucKhoeBUS;
        private readonly ThuCungBUS _thuCungBUS;
        public FrmHoSoSucKhoe()
        {
            InitializeComponent();
            _hoSoSucKhoeBUS = new HoSoSucKhoeBUS();
            _thuCungBUS = new ThuCungBUS();

            LoadThuCung();
            LoadDanhSachHoSo();

            dtpNgayCapNhat.Value = DateTime.Now;

            txtMaHoSo.ReadOnly = true;
        }
        // LOAD THÚ CƯNG
        // =========================
        private void LoadThuCung()
        {
            try
            {
                var danhSach = _thuCungBUS.GetAll();

                cboThuCung.DataSource = null;
                cboThuCung.DataSource = danhSach;
                cboThuCung.DisplayMember = "TenPet";
                cboThuCung.ValueMember = "MaPet";
                cboThuCung.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải danh sách thú cưng:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // LOAD DANH SÁCH HỒ SƠ
        // =========================
        private void LoadDanhSachHoSo()
        {
            try
            {
                var danhSach = _hoSoSucKhoeBUS.GetAll();

                dgvHoSoSucKhoe.DataSource = null;
                dgvHoSoSucKhoe.DataSource = danhSach;

                if (dgvHoSoSucKhoe.Columns.Count > 0)
                {
                    dgvHoSoSucKhoe.Columns["MaHoSo"].HeaderText = "Mã hồ sơ";
                    dgvHoSoSucKhoe.Columns["MaPet"].HeaderText = "Mã thú cưng";
                    dgvHoSoSucKhoe.Columns["CanNang"].HeaderText = "Cân nặng";
                    dgvHoSoSucKhoe.Columns["TinhTrangSucKhoe"].HeaderText = "Tình trạng sức khỏe";
                    dgvHoSoSucKhoe.Columns["TienSuBenh"].HeaderText = "Tiền sử bệnh";
                    dgvHoSoSucKhoe.Columns["DiUng"].HeaderText = "Dị ứng";
                    dgvHoSoSucKhoe.Columns["NgayCapNhat"].HeaderText = "Ngày cập nhật";
                    dgvHoSoSucKhoe.Columns["GhiChu"].HeaderText = "Ghi chú";

                    dgvHoSoSucKhoe.Columns["MaPetNavigation"].Visible = false;

                    dgvHoSoSucKhoe.Columns["NgayCapNhat"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    dgvHoSoSucKhoe.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;

                    dgvHoSoSucKhoe.AllowUserToAddRows = false;
                    dgvHoSoSucKhoe.ReadOnly = true;
                    dgvHoSoSucKhoe.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải danh sách hồ sơ:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // LẤY DỮ LIỆU TỪ FORM
        // =========================
        private HoSoSucKhoe LayDuLieuTuForm()
        {
            if (cboThuCung.SelectedIndex == -1)
                throw new Exception("Vui lòng chọn thú cưng.");

            decimal? canNang = null;

            if (!string.IsNullOrWhiteSpace(txtCanNang.Text))
            {
                if (!decimal.TryParse(txtCanNang.Text, out decimal trongLuong))
                    throw new Exception("Cân nặng phải là số.");

                if (trongLuong <= 0)
                    throw new Exception("Cân nặng phải lớn hơn 0.");

                canNang = trongLuong;
            }

            return new HoSoSucKhoe
            {
                MaPet = Convert.ToInt32(cboThuCung.SelectedValue),
                CanNang = canNang,
                TinhTrangSucKhoe = txtTinhTrangSucKhoe.Text.Trim(),
                TienSuBenh = txtTienSuBenh.Text.Trim(),
                DiUng = txtDiUng.Text.Trim(),
                NgayCapNhat = DateOnly.FromDateTime(dtpNgayCapNhat.Value),
                GhiChu = txtGhiChu.Text.Trim()
            };
        }

        // =========================


        private void lblLoai_Click(object sender, EventArgs e)
        {

        }

        private void lblCanNang_Click(object sender, EventArgs e)
        {

        }

        private void lblGhiChu_Click(object sender, EventArgs e)
        {

        }
        // THÊM
        // =========================
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HoSoSucKhoe hoSo = LayDuLieuTuForm();

                _hoSoSucKhoeBUS.Them(hoSo);

                MessageBox.Show(
                    "Thêm hồ sơ sức khỏe thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachHoSo();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        // SỬA
        // =========================

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaHoSo.Text))
                {
                    MessageBox.Show("Vui lòng chọn hồ sơ cần sửa.");
                    return;
                }

                HoSoSucKhoe hoSo = LayDuLieuTuForm();

                hoSo.MaHoSo = int.Parse(txtMaHoSo.Text);

                _hoSoSucKhoeBUS.Sua(hoSo);

                MessageBox.Show(
                    "Cập nhật hồ sơ sức khỏe thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachHoSo();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        // XÓA
        // =========================

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaHoSo.Text))
                {
                    MessageBox.Show("Vui lòng chọn hồ sơ cần xóa.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa hồ sơ này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                int maHoSo = int.Parse(txtMaHoSo.Text);

                _hoSoSucKhoeBUS.Xoa(maHoSo);

                MessageBox.Show(
                    "Xóa hồ sơ sức khỏe thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachHoSo();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        // LÀM MỚI
        // =========================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSachHoSo();
        }

        private void LamMoi()
        {
            txtMaHoSo.Clear();

            cboThuCung.SelectedIndex = -1;

            txtCanNang.Clear();
            txtTinhTrangSucKhoe.Clear();
            txtTienSuBenh.Clear();
            txtDiUng.Clear();
            txtGhiChu.Clear();

            dtpNgayCapNhat.Value = DateTime.Now;

            txtTimKiem.Clear();

            dgvHoSoSucKhoe.ClearSelection();
        }
        // =========================

        private void dgvHoSoSucKhoe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow row = dgvHoSoSucKhoe.Rows[e.RowIndex];

                txtMaHoSo.Text =
                    row.Cells["MaHoSo"].Value?.ToString();

                if (row.Cells["MaPet"].Value != null)
                {
                    cboThuCung.SelectedValue =
                        Convert.ToInt32(row.Cells["MaPet"].Value);
                }

                txtCanNang.Text =
                    row.Cells["CanNang"].Value?.ToString();

                txtTinhTrangSucKhoe.Text =
                    row.Cells["TinhTrangSucKhoe"].Value?.ToString();

                txtTienSuBenh.Text =
                    row.Cells["TienSuBenh"].Value?.ToString();

                txtDiUng.Text =
                    row.Cells["DiUng"].Value?.ToString();

                if (row.Cells["NgayCapNhat"].Value != null)
                {
                    DateOnly ngay =
                        (DateOnly)row.Cells["NgayCapNhat"].Value;

                    dtpNgayCapNhat.Value =
                        ngay.ToDateTime(TimeOnly.MinValue);
                }

                txtGhiChu.Text =
                    row.Cells["GhiChu"].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể hiển thị thông tin:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        // TÌM KIẾM
        // =========================

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadDanhSachHoSo();
                return;
            }

            try
            {
                var danhSach = _hoSoSucKhoeBUS.GetAll();

                var ketQua = danhSach.Where(x =>
                    (x.TinhTrangSucKhoe ?? "")
                        .Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                    ||
                    (x.TienSuBenh ?? "")
                        .Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                    ||
                    (x.DiUng ?? "")
                        .Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                    ||
                    (x.GhiChu ?? "")
                        .Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                ).ToList();

                dgvHoSoSucKhoe.DataSource = null;
                dgvHoSoSucKhoe.DataSource = ketQua;

                CauHinhDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tìm kiếm:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        // CẤU HÌNH DATAGRIDVIEW
        // =========================
        private void CauHinhDataGridView()
        {
            if (dgvHoSoSucKhoe.Columns.Count == 0)
                return;

            dgvHoSoSucKhoe.Columns["MaHoSo"].HeaderText = "Mã hồ sơ";
            dgvHoSoSucKhoe.Columns["MaPet"].HeaderText = "Mã thú cưng";
            dgvHoSoSucKhoe.Columns["CanNang"].HeaderText = "Cân nặng";
            dgvHoSoSucKhoe.Columns["TinhTrangSucKhoe"].HeaderText =
                "Tình trạng sức khỏe";
            dgvHoSoSucKhoe.Columns["TienSuBenh"].HeaderText =
                "Tiền sử bệnh";
            dgvHoSoSucKhoe.Columns["DiUng"].HeaderText = "Dị ứng";
            dgvHoSoSucKhoe.Columns["NgayCapNhat"].HeaderText =
                "Ngày cập nhật";
            dgvHoSoSucKhoe.Columns["GhiChu"].HeaderText = "Ghi chú";

            dgvHoSoSucKhoe.Columns["MaPetNavigation"].Visible = false;

            dgvHoSoSucKhoe.Columns["NgayCapNhat"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvHoSoSucKhoe.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
        // =========================
        // QUAY LẠI
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
