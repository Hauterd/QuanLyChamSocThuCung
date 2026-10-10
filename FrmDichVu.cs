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
    public partial class FrmDichVu : Form
    {
        private readonly DichVuBUS _dichVuBUS;
        public FrmDichVu()
        {
            InitializeComponent();
            _dichVuBUS = new DichVuBUS();

            txtMaDV.ReadOnly = true;

            LoadLoaiDichVu();

            numThoiGianDuKien.Minimum = 0;
            numThoiGianDuKien.Maximum = 1440;

            chkTrangThai.Checked = true;

            CauHinhDataGridView();
            LoadDanhSachDichVu();
        }

        private void lblGhiChu_Click(object sender, EventArgs e)
        {


        }
        private void LoadLoaiDichVu()
        {
            cboLoaiDV.Items.Clear();
            cboLoaiDV.Items.Add("Khám chữa bệnh");
            cboLoaiDV.Items.Add("Tiêm chủng");
            cboLoaiDV.Items.Add("Chăm sóc");
            cboLoaiDV.Items.Add("Vệ sinh");
            cboLoaiDV.Items.Add("Khác");
            cboLoaiDV.SelectedIndex = -1;
        }
        private void CauHinhDataGridView()
        {
            // Sử dụng các cột đã tạo trong Designer.
            dgvDichVu.AutoGenerateColumns = true;
            dgvDichVu.AllowUserToAddRows = false;
            dgvDichVu.ReadOnly = true;
            dgvDichVu.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvDichVu.MultiSelect = false;
            dgvDichVu.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadDanhSachDichVu()
        {
            try
            {
                dgvDichVu.DataSource = null;
                dgvDichVu.DataSource = _dichVuBUS.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách dịch vụ:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private DichVu LayDuLieuTuForm()
        {
            if (string.IsNullOrWhiteSpace(txtTenDV.Text))
                throw new Exception("Vui lòng nhập tên dịch vụ.");

            if (cboLoaiDV.SelectedIndex < 0)
                throw new Exception("Vui lòng chọn loại dịch vụ.");

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia))
                throw new Exception("Đơn giá phải là số hợp lệ.");

            if (donGia < 0)
                throw new Exception("Đơn giá không được âm.");

            if (donGia > 999999999999.99m)
                throw new Exception("Đơn giá vượt quá giới hạn.");

            return new DichVu
            {
                TenDv = txtTenDV.Text.Trim(),
                LoaiDv = cboLoaiDV.SelectedItem.ToString(),
                DonGia = donGia,
                ThoiGianDuKien = (int)numThoiGianDuKien.Value,
                MoTa = txtMoTa.Text.Trim(),
                TrangThai = chkTrangThai.Checked
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DichVu dichVu = LayDuLieuTuForm();

                _dichVuBUS.Them(dichVu);

                MessageBox.Show(
                    "Thêm dịch vụ thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachDichVu();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaDV.Text, out int maDv))
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần sửa.");
                    return;
                }

                DichVu dichVu = LayDuLieuTuForm();
                dichVu.MaDv = maDv;

                _dichVuBUS.Sua(dichVu);

                MessageBox.Show(
                    "Cập nhật dịch vụ thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachDichVu();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaDV.Text, out int maDv))
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa dịch vụ này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                _dichVuBUS.Xoa(maDv);

                MessageBox.Show(
                    "Xóa dịch vụ thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachDichVu();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa dịch vụ. Có thể dịch vụ đang được sử dụng.\n"
                    + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSachDichVu();
        }
        private void LamMoi()
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            cboLoaiDV.SelectedIndex = -1;
            txtDonGia.Clear();
            numThoiGianDuKien.Value = 0;
            txtMoTa.Clear();
            chkTrangThai.Checked = true;
            txtTimKiem.Clear();
            dgvDichVu.ClearSelection();
        }

        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];

            txtMaDV.Text = row.Cells["MaDv"].Value?.ToString();
            txtTenDV.Text = row.Cells["TenDv"].Value?.ToString();

            string loaiDv = row.Cells["LoaiDv"].Value?.ToString() ?? "";
            cboLoaiDV.SelectedItem = loaiDv;

            txtDonGia.Text = row.Cells["DonGia"].Value?.ToString();

            if (row.Cells["ThoiGianDuKien"].Value != null &&
                row.Cells["ThoiGianDuKien"].Value != DBNull.Value)
            {
                decimal thoiGian = Convert.ToDecimal(
                    row.Cells["ThoiGianDuKien"].Value);

                numThoiGianDuKien.Value = Math.Max(
                    numThoiGianDuKien.Minimum,
                    Math.Min(numThoiGianDuKien.Maximum, thoiGian));
            }
            else
            {
                numThoiGianDuKien.Value = 0;
            }

            txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();

            if (row.Cells["TrangThai"].Value != null)
            {
                chkTrangThai.Checked =
                    Convert.ToBoolean(row.Cells["TrangThai"].Value);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();

                var danhSach = _dichVuBUS.GetAll();

                var ketQua = danhSach
                    .Where(x =>
                        (x.TenDv ?? "").Contains(
                            tuKhoa, StringComparison.OrdinalIgnoreCase)
                        ||
                        (x.LoaiDv ?? "").Contains(
                            tuKhoa, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                dgvDichVu.DataSource = null;
                dgvDichVu.DataSource = ketQua;
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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
