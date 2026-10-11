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
    public partial class FrmChiTietLichChamSoc : Form
    {
        private readonly ChiTietLichChamSocBUS _bus =
            new ChiTietLichChamSocBUS();

        private int _maLich;
        private int _maDvDangChon;
        public FrmChiTietLichChamSoc()
        {
            InitializeComponent();
            txtMaLich.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;

            cboDichVu.DropDownStyle =
                ComboBoxStyle.DropDownList;

            dgvChiTietLich.AutoGenerateColumns = true;
            dgvChiTietLich.ReadOnly = true;
            dgvChiTietLich.AllowUserToAddRows = false;
            dgvChiTietLich.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietLich.MultiSelect = false;

            nudSoLuong.Minimum = 1;
            nudSoLuong.Maximum = 1000;
            nudSoLuong.Value = 1;

            cboDichVu.SelectedIndexChanged +=
                cboDichVu_SelectedIndexChanged;

            nudSoLuong.ValueChanged +=
                nudSoLuong_ValueChanged;

            dgvChiTietLich.CellClick +=
                dgvChiTietLich_CellClick;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            btnQuayLai.Click += btnQuayLai_Click;
        }
        public FrmChiTietLichChamSoc(int maLich)
           : this()
        {
            if (maLich <= 0)
                throw new ArgumentException(
                    "Mã lịch chăm sóc không hợp lệ.");

            _maLich = maLich;
            txtMaLich.Text = maLich.ToString();
        }
        private void LoadDichVu()
        {
            try
            {
                using (var db = new QuanLyChamSocThuCungContext())
                {
                    var danhSach = db.DichVus
                        .Where(x => x.TrangThai)
                        .OrderBy(x => x.TenDv)
                        .Select(x => new
                        {
                            x.MaDv,
                            x.TenDv,
                            x.DonGia
                        })
                        .ToList();

                    cboDichVu.DataSource = null;
                    cboDichVu.DataSource = danhSach;
                    cboDichVu.DisplayMember = "TenDv";
                    cboDichVu.ValueMember = "MaDv";
                    cboDichVu.SelectedIndex = -1;
                }

                txtDonGia.Text = "0 VNĐ";
                txtThanhTien.Text = "0 VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách dịch vụ: " + ex.Message);
            }
        }


        private decimal LayDonGia()
        {
            if (cboDichVu.SelectedValue == null)
                return 0;

            int maDv;
            if (!int.TryParse(cboDichVu.SelectedValue.ToString(), out maDv))
                return 0;

            using (var db = new QuanLyChamSocThuCungContext())
            {
                var dichVu = db.DichVus
                    .FirstOrDefault(x => x.MaDv == maDv);

                return dichVu?.DonGia ?? 0m;
            }
        }


        private void CapNhatThanhTien()
        {
            decimal donGia = LayDonGia();
            decimal thanhTien = donGia * nudSoLuong.Value;

            txtDonGia.Text = donGia.ToString("N0") + " VNĐ";
            txtThanhTien.Text = thanhTien.ToString("N0") + " VNĐ";
        }

        private void cboDichVu_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void nudSoLuong_ValueChanged(
            object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void LoadChiTiet()
        {
            try
            {
                dgvChiTietLich.DataSource = null;

                var danhSach = _bus.GetByMaLich(_maLich)
                    .Select(x => new
                    {
                        x.MaLich,
                        x.MaDv,
                        TenDichVu = x.MaDvNavigation.TenDv,
                        x.SoLuong,
                        DonGia = x.DonGia.ToString("N0"),
                        ThanhTien = (x.ThanhTien ?? 0m).ToString("N0")
                    })
                    .ToList();

                dgvChiTietLich.DataSource = danhSach;

                // Ẩn cột mã kỹ thuật, nhưng vẫn giữ dữ liệu để chọn dòng
                if (dgvChiTietLich.Columns["MaLich"] != null)
                    dgvChiTietLich.Columns["MaLich"].Visible = false;

                if (dgvChiTietLich.Columns["MaDv"] != null)
                    dgvChiTietLich.Columns["MaDv"].Visible = false;

                dgvChiTietLich.ClearSelection();

                // Cập nhật tổng tiền của lịch
                decimal tongTien = _bus.TinhTongTien(_maLich);
                lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải chi tiết lịch chăm sóc: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        private void FrmChiTietLichChamSoc_Load(object sender, EventArgs e)
        {
            LoadDichVu();

            if (_maLich > 0)
            {
                LoadChiTiet();
            }
        }

        private void dgvChiTietLich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvChiTietLich.Rows[e.RowIndex];

            if (row.Cells["MaDv"].Value == null)
                return;

            _maDvDangChon = Convert.ToInt32(row.Cells["MaDv"].Value);

            // Chọn dịch vụ tương ứng
            cboDichVu.SelectedValue = _maDvDangChon;

            // Điền số lượng
            nudSoLuong.Value = Convert.ToDecimal(
                row.Cells["SoLuong"].Value);

            // Điền ghi chú: model hiện tại chưa lưu ghi chú chi tiết
            txtGhiChu.Clear();

            CapNhatThanhTien();
        }

        private void LamMoiChiTiet()
        {
            cboDichVu.SelectedIndex = -1;
            nudSoLuong.Value = 1;

            _maDvDangChon = 0;

            txtDonGia.Text = "0 VNĐ";
            txtThanhTien.Text = "0 VNĐ";
            txtGhiChu.Clear();

            dgvChiTietLich.ClearSelection();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiChiTiet();
        }
        private ChiTietLichChamSoc LayDuLieuTuForm()
        {
            if (cboDichVu.SelectedValue == null)
                throw new Exception("Vui lòng chọn dịch vụ.");

            int maDv = Convert.ToInt32(cboDichVu.SelectedValue);
            decimal donGia = LayDonGia();
            int soLuong = (int)nudSoLuong.Value;

            if (donGia < 0)
                throw new Exception("Đơn giá không hợp lệ.");

            return new ChiTietLichChamSoc
            {
                MaLich = _maLich,
                MaDv = maDv,
                SoLuong = soLuong,
                DonGia = donGia,
                ThanhTien = soLuong * donGia
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietLichChamSoc chiTiet = LayDuLieuTuForm();

                _bus.Them(chiTiet);

                MessageBox.Show(
                    "Thêm dịch vụ vào lịch chăm sóc thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadChiTiet();
                LamMoiChiTiet();
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
                if (_maDvDangChon <= 0)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần sửa.");
                    return;
                }

                ChiTietLichChamSoc chiTiet = LayDuLieuTuForm();

                // Giữ đúng dịch vụ đã chọn trên bảng
                chiTiet.MaDv = _maDvDangChon;

                _bus.Sua(chiTiet);

                MessageBox.Show(
                    "Cập nhật dịch vụ thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadChiTiet();
                LamMoiChiTiet();
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
                if (_maDvDangChon <= 0)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa.");
                    return;
                }

                DialogResult ketQua = MessageBox.Show(
                    "Em có chắc muốn xóa dịch vụ này khỏi lịch chăm sóc không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (ketQua != DialogResult.Yes)
                    return;

                _bus.Xoa(_maLich, _maDvDangChon);

                MessageBox.Show(
                    "Xóa dịch vụ thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadChiTiet();
                LamMoiChiTiet();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();

                var danhSach = _bus.GetByMaLich(_maLich)
                    .Where(x => string.IsNullOrEmpty(tuKhoa)
                        || x.MaDvNavigation.TenDv
                            .IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0
                        || x.MaDv.ToString().Contains(tuKhoa))
                    .Select(x => new
                    {
                        x.MaLich,
                        x.MaDv,
                        TenDichVu = x.MaDvNavigation.TenDv,
                        x.SoLuong,
                        DonGia = x.DonGia.ToString("N0"),
                        ThanhTien = (x.ThanhTien ?? 0m).ToString("N0")
                    })
                    .ToList();

                dgvChiTietLich.DataSource = null;
                dgvChiTietLich.DataSource = danhSach;

                if (dgvChiTietLich.Columns["MaLich"] != null)
                    dgvChiTietLich.Columns["MaLich"].Visible = false;

                if (dgvChiTietLich.Columns["MaDv"] != null)
                    dgvChiTietLich.Columns["MaDv"].Visible = false;

                dgvChiTietLich.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tìm kiếm dịch vụ: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
