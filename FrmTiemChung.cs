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
    public partial class FrmTiemChung : Form
    {
        private readonly TiemChungBUS _tiemChungBUS;
        private readonly ThuCungBUS _thuCungBUS;
        public FrmTiemChung()
        {
            InitializeComponent();
            _tiemChungBUS = new TiemChungBUS();
            _thuCungBUS = new ThuCungBUS();

            LoadThuCung();
            LoadDanhSachTiemChung();

            txtMaTiem.ReadOnly = true;

            dtpNgayTiem.Value = DateTime.Now;
            dtpNgayNhac.Value = DateTime.Now;

            dtpNgayNhac.Enabled = false;

            numMuiTiem.Minimum = 1;
            numMuiTiem.Value = 1;

        }
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

        private void LoadDanhSachTiemChung()
        {
            try
            {
                var danhSach = _tiemChungBUS.GetAll();

                dgvTiemChung.DataSource = null;
                dgvTiemChung.DataSource = danhSach;

                CauHinhDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải danh sách tiêm chủng:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CauHinhDataGridView()
        {
            if (dgvTiemChung.Columns.Count == 0)
                return;

            dgvTiemChung.Columns["MaTiem"].HeaderText = "Mã tiêm";
            dgvTiemChung.Columns["MaPet"].HeaderText = "Mã thú cưng";
            dgvTiemChung.Columns["TenVacXin"].HeaderText = "Tên vắc xin";
            dgvTiemChung.Columns["MuiTiem"].HeaderText = "Mũi tiêm";
            dgvTiemChung.Columns["NgayTiem"].HeaderText = "Ngày tiêm";
            dgvTiemChung.Columns["NgayNhac"].HeaderText = "Ngày nhắc";
            dgvTiemChung.Columns["NoiTiem"].HeaderText = "Nơi tiêm";
            dgvTiemChung.Columns["GhiChu"].HeaderText = "Ghi chú";

            dgvTiemChung.Columns["MaPetNavigation"].Visible = false;

            dgvTiemChung.Columns["NgayTiem"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvTiemChung.Columns["NgayNhac"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvTiemChung.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvTiemChung.AllowUserToAddRows = false;
            dgvTiemChung.ReadOnly = true;
            dgvTiemChung.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        private TiemChung LayDuLieuTuForm()
        {
            if (cboThuCung.SelectedIndex == -1)
                throw new Exception("Vui lòng chọn thú cưng.");

            if (string.IsNullOrWhiteSpace(txtTenVacXin.Text))
                throw new Exception("Vui lòng nhập tên vắc xin.");

            DateOnly? ngayNhac = null;

            if (chkCoNgayNhac.Checked)
            {
                ngayNhac = DateOnly.FromDateTime(
                    dtpNgayNhac.Value);
            }

            return new TiemChung
            {
                MaPet = Convert.ToInt32(cboThuCung.SelectedValue),

                TenVacXin = txtTenVacXin.Text.Trim(),

                MuiTiem = Convert.ToInt32(numMuiTiem.Value),

                NgayTiem = DateOnly.FromDateTime(
                    dtpNgayTiem.Value),

                NgayNhac = ngayNhac,

                NoiTiem = txtNoiTiem.Text.Trim(),

                GhiChu = txtGhiChu.Text.Trim()
            };
        }
        //==========================================
        //Check Box Ngày Nhắc
        private void chkCoNgayNhac_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgayNhac.Enabled = chkCoNgayNhac.Checked;
        }
        //==========================================
        //Thêm thông tin tiêm chủng
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                TiemChung tiemChung = LayDuLieuTuForm();

                _tiemChungBUS.Them(tiemChung);

                MessageBox.Show(
                    "Thêm thông tin tiêm chủng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachTiemChung();
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
        //==========================================
        //Sửa thông tin tiêm chủng
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaTiem.Text))
                {
                    MessageBox.Show("Vui lòng chọn thông tin cần sửa.");
                    return;
                }

                TiemChung tiemChung = LayDuLieuTuForm();

                tiemChung.MaTiem =
                    int.Parse(txtMaTiem.Text);

                _tiemChungBUS.Sua(tiemChung);

                MessageBox.Show(
                    "Cập nhật thông tin tiêm chủng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachTiemChung();
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
        //==========================================
        //Xoa thông tin tiêm chủng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaTiem.Text))
                {
                    MessageBox.Show("Vui lòng chọn thông tin cần xóa.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa thông tin tiêm chủng này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                int maTiem = int.Parse(txtMaTiem.Text);

                _tiemChungBUS.Xoa(maTiem);

                MessageBox.Show(
                    "Xóa thông tin tiêm chủng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachTiemChung();
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
        //==========================================
        //Làm mới thông tin tiêm chủng
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSachTiemChung();
        }

        private void LamMoi()
        {
            txtMaTiem.Clear();

            cboThuCung.SelectedIndex = -1;

            txtTenVacXin.Clear();

            numMuiTiem.Value = 1;

            dtpNgayTiem.Value = DateTime.Now;

            chkCoNgayNhac.Checked = false;

            dtpNgayNhac.Value = DateTime.Now;
            dtpNgayNhac.Enabled = false;

            txtNoiTiem.Clear();
            txtGhiChu.Clear();

            txtTimKiem.Clear();

            dgvTiemChung.ClearSelection();
        }
        //==========================================
        //Danh sách thông tin tiêm chủng
        private void dgvTiemChung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow row =
                    dgvTiemChung.Rows[e.RowIndex];

                txtMaTiem.Text =
                    row.Cells["MaTiem"].Value?.ToString();

                if (row.Cells["MaPet"].Value != null)
                {
                    cboThuCung.SelectedValue =
                        Convert.ToInt32(
                            row.Cells["MaPet"].Value);
                }

                txtTenVacXin.Text =
                    row.Cells["TenVacXin"].Value?.ToString();

                if (row.Cells["MuiTiem"].Value != null)
                {
                    numMuiTiem.Value =
                        Convert.ToDecimal(
                            row.Cells["MuiTiem"].Value);
                }

                if (row.Cells["NgayTiem"].Value != null)
                {
                    DateOnly ngayTiem =
                        (DateOnly)row.Cells["NgayTiem"].Value;

                    dtpNgayTiem.Value =
                        ngayTiem.ToDateTime(
                            TimeOnly.MinValue);
                }

                if (row.Cells["NgayNhac"].Value != null &&
                    row.Cells["NgayNhac"].Value != DBNull.Value)
                {
                    DateOnly ngayNhac =
                        (DateOnly)row.Cells["NgayNhac"].Value;

                    dtpNgayNhac.Value =
                        ngayNhac.ToDateTime(
                            TimeOnly.MinValue);

                    chkCoNgayNhac.Checked = true;
                }
                else
                {
                    chkCoNgayNhac.Checked = false;
                }

                txtNoiTiem.Text =
                    row.Cells["NoiTiem"].Value?.ToString();

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
        //==========================================
        //Tìm kiếm thông tin tiêm chủng

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa =
                txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadDanhSachTiemChung();
                return;
            }

            try
            {
                var danhSach =
                    _tiemChungBUS.GetAll();

                var ketQua = danhSach
                    .Where(x =>
                        (x.TenVacXin ?? "")
                            .Contains(
                                tuKhoa,
                                StringComparison.OrdinalIgnoreCase)
                        ||
                        (x.NoiTiem ?? "")
                            .Contains(
                                tuKhoa,
                                StringComparison.OrdinalIgnoreCase)
                        ||
                        (x.GhiChu ?? "")
                            .Contains(
                                tuKhoa,
                                StringComparison.OrdinalIgnoreCase)
                    )
                    .ToList();

                dgvTiemChung.DataSource = null;
                dgvTiemChung.DataSource = ketQua;

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
        //==========================================
        //Quay lại form chính
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
