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
    public partial class FrmNhanVien : Form
    {
        private readonly NhanVienBUS _nhanVienBUS;
        public FrmNhanVien()
        {
            InitializeComponent();
            _nhanVienBUS = new NhanVienBUS();

            LoadDanhSachNhanVien();

            txtMaNV.ReadOnly = true;

            dtpNgaySinh.Value = DateTime.Now;

            chkTrangThai.Checked = true;

            rdoNam.Checked = false;
            rdoNu.Checked = false;

            LoadChucVu();
        }
        // ==============================
        // LOAD CHỨC VỤ
        // ==============================
        private void LoadChucVu()
        {
            cboChucVu.Items.Clear();

            cboChucVu.Items.Add("Quản lý");
            cboChucVu.Items.Add("Bác sĩ thú y");
            cboChucVu.Items.Add("Nhân viên chăm sóc");
            cboChucVu.Items.Add("Nhân viên thu ngân");
            cboChucVu.Items.Add("Nhân viên lễ tân");

            cboChucVu.SelectedIndex = -1;
        }

        // ==============================
        // LOAD DANH SÁCH
        // ==============================
        private void LoadDanhSachNhanVien()
        {
            try
            {
                var danhSach = _nhanVienBUS.GetAll();

                dgvNhanVien.DataSource = null;

                dgvNhanVien.AutoGenerateColumns = true;

                dgvNhanVien.DataSource = danhSach;

                CauHinhDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải danh sách nhân viên:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==============================
        // CẤU HÌNH DATAGRIDVIEW
        // ==============================
        private void CauHinhDataGridView()
        {
            if (dgvNhanVien.Columns.Count == 0)
                return;

            dgvNhanVien.Columns["MaNv"].HeaderText =
                "Mã nhân viên";

            dgvNhanVien.Columns["HoTen"].HeaderText =
                "Họ tên";

            dgvNhanVien.Columns["GioiTinh"].HeaderText =
                "Giới tính";

            dgvNhanVien.Columns["NgaySinh"].HeaderText =
                "Ngày sinh";

            dgvNhanVien.Columns["Sdt"].HeaderText =
                "Số điện thoại";

            dgvNhanVien.Columns["DiaChi"].HeaderText =
                "Địa chỉ";

            dgvNhanVien.Columns["ChucVu"].HeaderText =
                "Chức vụ";

            dgvNhanVien.Columns["TrangThai"].HeaderText =
                "Trạng thái";

            if (dgvNhanVien.Columns.Contains("HoaDons"))
                dgvNhanVien.Columns["HoaDons"].Visible = false;

            if (dgvNhanVien.Columns.Contains("LichChamSocs"))
                dgvNhanVien.Columns["LichChamSocs"].Visible = false;

            if (dgvNhanVien.Columns.Contains("TaiKhoan"))
                dgvNhanVien.Columns["TaiKhoan"].Visible = false;

            dgvNhanVien.Columns["NgaySinh"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvNhanVien.Columns["TrangThai"]
                .DefaultCellStyle.NullValue = false;

            dgvNhanVien.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvNhanVien.AllowUserToAddRows = false;

            dgvNhanVien.ReadOnly = true;

            dgvNhanVien.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        // ==============================
        // LẤY DỮ LIỆU TỪ FORM
        // ==============================
        private NhanVien LayDuLieuTuForm()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                throw new Exception("Vui lòng nhập họ tên.");

            if (!rdoNam.Checked && !rdoNu.Checked)
                throw new Exception("Vui lòng chọn giới tính.");

            if (cboChucVu.SelectedIndex == -1)
                throw new Exception("Vui lòng chọn chức vụ.");

            string gioiTinh;

            if (rdoNam.Checked)
                gioiTinh = "Nam";
            else
                gioiTinh = "Nữ";

            return new NhanVien
            {
                HoTen = txtHoTen.Text.Trim(),

                GioiTinh = gioiTinh,

                NgaySinh =
                    DateOnly.FromDateTime(
                        dtpNgaySinh.Value),

                Sdt = txtSdt.Text.Trim(),

                DiaChi = txtDiaChi.Text.Trim(),

                ChucVu =
                    cboChucVu.SelectedItem?.ToString(),

                TrangThai = chkTrangThai.Checked
            };
        }
        //==============================
        // THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nhanVien =
                    LayDuLieuTuForm();

                _nhanVienBUS.Them(nhanVien);

                MessageBox.Show(
                    "Thêm nhân viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachNhanVien();

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
        // ==============================
        // SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaNV.Text))
                {
                    MessageBox.Show(
                        "Vui lòng chọn nhân viên cần sửa.");

                    return;
                }

                NhanVien nhanVien =
                    LayDuLieuTuForm();

                nhanVien.MaNv =
                    int.Parse(txtMaNV.Text);

                _nhanVienBUS.Sua(nhanVien);

                MessageBox.Show(
                    "Cập nhật nhân viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachNhanVien();

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
        // ==============================
        // XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaNV.Text))
                {
                    MessageBox.Show(
                        "Vui lòng chọn nhân viên cần xóa.");

                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa nhân viên này?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                int maNv =
                    int.Parse(txtMaNV.Text);

                _nhanVienBUS.Xoa(maNv);

                MessageBox.Show(
                    "Xóa nhân viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachNhanVien();

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
        // ==============================
        // LÀM MỚI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            LamMoi();

            LoadDanhSachNhanVien();
        }

        private void LamMoi()
        {
            txtMaNV.Clear();

            txtHoTen.Clear();

            rdoNam.Checked = false;
            rdoNu.Checked = false;

            dtpNgaySinh.Value = DateTime.Now;

            txtSdt.Clear();

            txtDiaChi.Clear();

            cboChucVu.SelectedIndex = -1;

            chkTrangThai.Checked = true;

            txtTimKiem.Clear();

            dgvNhanVien.ClearSelection();
        }
        // ==============================
        // CLICK DATAGRIDVIEW
        // ==============================
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow row =
                    dgvNhanVien.Rows[e.RowIndex];

                txtMaNV.Text =
                    row.Cells["MaNv"].Value?.ToString();

                txtHoTen.Text =
                    row.Cells["HoTen"].Value?.ToString();

                string gioiTinh =
                    row.Cells["GioiTinh"].Value?.ToString()
                    ?? "";

                if (gioiTinh == "Nam")
                {
                    rdoNam.Checked = true;
                    rdoNu.Checked = false;
                }
                else if (gioiTinh == "Nữ")
                {
                    rdoNam.Checked = false;
                    rdoNu.Checked = true;
                }
                else
                {
                    rdoNam.Checked = false;
                    rdoNu.Checked = false;
                }

                if (row.Cells["NgaySinh"].Value != null)
                {
                    DateOnly ngaySinh =
                        (DateOnly)row.Cells["NgaySinh"].Value;

                    dtpNgaySinh.Value =
                        ngaySinh.ToDateTime(
                            TimeOnly.MinValue);
                }

                txtSdt.Text =
                    row.Cells["Sdt"].Value?.ToString();

                txtDiaChi.Text =
                    row.Cells["DiaChi"].Value?.ToString();

                cboChucVu.SelectedItem =
                    row.Cells["ChucVu"].Value?.ToString();

                if (row.Cells["TrangThai"].Value != null)
                {
                    chkTrangThai.Checked =
                        Convert.ToBoolean(
                            row.Cells["TrangThai"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể hiển thị thông tin nhân viên:\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        // ==============================
        // TÌM KIẾM
        // ==============================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa =
                txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadDanhSachNhanVien();
                return;
            }

            try
            {
                var danhSach =
                    _nhanVienBUS.GetAll();

                var ketQua =
                    danhSach
                    .Where(x =>
                        (x.HoTen ?? "")
                            .Contains(
                                tuKhoa,
                                StringComparison.OrdinalIgnoreCase)

                        ||

                        (x.Sdt ?? "")
                            .Contains(
                                tuKhoa,
                                StringComparison.OrdinalIgnoreCase)

                        ||

                        (x.DiaChi ?? "")
                            .Contains(
                                tuKhoa,
                                StringComparison.OrdinalIgnoreCase)

                        ||

                        (x.ChucVu ?? "")
                            .Contains(
                                tuKhoa,
                                StringComparison.OrdinalIgnoreCase)

                        ||

                        (x.GioiTinh ?? "")
                            .Contains(
                                tuKhoa,
                                StringComparison.OrdinalIgnoreCase)
                    )
                    .ToList();

                dgvNhanVien.DataSource = null;

                dgvNhanVien.DataSource = ketQua;

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
        // ==============================
        // QUAY LẠI
        // ==============================

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ==============================


    }
}
