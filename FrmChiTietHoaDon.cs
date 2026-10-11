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
    public partial class FrmChiTietHoaDon : Form
    {

        private readonly ChiTietHoaDonBUS chiTietBUS = new ChiTietHoaDonBUS();
        private readonly HoaDonBUS hoaDonBUS = new HoaDonBUS();
        private readonly DichVuBUS dichVuBUS = new DichVuBUS();
        private int? maHoaDonDuocChon;
        private int? maDichVuDangChon;
        public FrmChiTietHoaDon()
        {
            InitializeComponent();
            cboHoaDon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDichVu.DropDownStyle = ComboBoxStyle.DropDownList;

            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;

            nudSoLuong.Minimum = 1;
            nudSoLuong.Value = 1;

            cboHoaDon.SelectedIndexChanged += cboHoaDon_SelectedIndexChanged;
            cboDichVu.SelectedIndexChanged += cboDichVu_SelectedIndexChanged;
            nudSoLuong.ValueChanged += nudSoLuong_ValueChanged;

            Load += FrmChiTietHoaDon_Load;
        }
        public FrmChiTietHoaDon(int maHd)
    : this()
        {
            maHoaDonDuocChon = maHd;
        }


        private void FrmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                var danhSachHoaDon = hoaDonBUS.GetAll()
                    .Select(x => new
                    {
                        x.MaHd,
                        TenHienThi = "Hóa đơn #" + x.MaHd
                            + " - " + (x.MaKhNavigation?.HoTen
                            ?? "Chưa có tên khách hàng")
                    })
                    .ToList();

                cboHoaDon.DataSource = danhSachHoaDon;
                cboHoaDon.DisplayMember = "TenHienThi";
                cboHoaDon.ValueMember = "MaHd";

                var danhSachDichVu = dichVuBUS.GetAll()
                    .OrderBy(x => x.TenDv)
                    .ToList();

                cboDichVu.DataSource = danhSachDichVu;
                cboDichVu.DisplayMember = "TenDv";
                cboDichVu.ValueMember = "MaDv";

                // Chọn hóa đơn được truyền từ FrmHoaDon
                if (maHoaDonDuocChon.HasValue)
                {
                    cboHoaDon.SelectedValue = maHoaDonDuocChon.Value;
                }
                else if (cboHoaDon.Items.Count > 0)
                {
                    cboHoaDon.SelectedIndex = 0;
                }

                // Chọn dịch vụ đầu tiên nếu có
                if (cboDichVu.Items.Count > 0)
                {
                    cboDichVu.SelectedIndex = 0;
                }

                // Hiển thị chi tiết và cập nhật tiền sau khi nạp dữ liệu
                HienThiChiTiet();
                CapNhatThanhTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void HienThiChiTiet()
        {
            if (cboHoaDon.SelectedValue == null)
                return;

            int maHd = Convert.ToInt32(cboHoaDon.SelectedValue);

            var danhSach = chiTietBUS.GetByMaHd(maHd)
                .Select(x => new
                {
                    x.MaHd,
                    x.MaDv,
                    TenDichVu = x.MaDvNavigation.TenDv,
                    x.SoLuong,
                    x.DonGia,
                    ThanhTien = x.ThanhTien ?? (x.SoLuong * x.DonGia)
                })
                .ToList();

            dgvChiTietHoaDon.DataSource = null;
            dgvChiTietHoaDon.DataSource = danhSach;

            txtTongTien.Text = danhSach
                .Sum(x => x.ThanhTien)
                .ToString("N0");
        }

        private void CapNhatThanhTien()
        {
            if (cboDichVu.SelectedItem is DichVu dichVu)
                txtDonGia.Text = dichVu.DonGia.ToString("N0");
            else
                txtDonGia.Clear();

            decimal donGia = 0;

            if (cboDichVu.SelectedItem is DichVu dv)
                donGia = dv.DonGia;

            txtThanhTien.Text =
                (donGia * nudSoLuong.Value).ToString("N0");
        }

        private void cboHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHoaDon.SelectedValue is int)
                HienThiChiTiet();
        }

        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboHoaDon.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn.");
                    return;
                }

                if (!(cboDichVu.SelectedItem is DichVu dichVu))
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ.");
                    return;
                }

                int maHd = Convert.ToInt32(cboHoaDon.SelectedValue);
                int soLuong = (int)nudSoLuong.Value;

                var chiTiet = new ChiTietHoaDon
                {
                    MaHd = maHd,
                    MaDv = dichVu.MaDv,
                    SoLuong = soLuong,
                    DonGia = dichVu.DonGia,
                    ThanhTien = soLuong * dichVu.DonGia
                };

                // Thêm một dòng dịch vụ mới vào hóa đơn
                chiTietBUS.Them(chiTiet);

                // Bỏ chọn dòng chi tiết cũ
                maDichVuDangChon = null;

                HienThiChiTiet();
                dgvChiTietHoaDon.ClearSelection();

                nudSoLuong.Value = 1;
                CapNhatThanhTien();

                MessageBox.Show(
                    "Đã thêm dịch vụ vào hóa đơn thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thêm dịch vụ: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dgvChiTietHoaDon.Rows[e.RowIndex];

            if (row.Cells["MaDv"].Value == null)
                return;

            maDichVuDangChon = Convert.ToInt32(row.Cells["MaDv"].Value);

            if (row.Cells["SoLuong"].Value != null)
            {
                nudSoLuong.Value = Math.Min(
                    nudSoLuong.Maximum,
                    Math.Max(
                        nudSoLuong.Minimum,
                        Convert.ToDecimal(row.Cells["SoLuong"].Value)));
            }

            if (row.Cells["MaDv"].Value != null)
                cboDichVu.SelectedValue = maDichVuDangChon.Value;

            CapNhatThanhTien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboHoaDon.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn.");
                    return;
                }

                if (!maDichVuDangChon.HasValue)
                {
                    MessageBox.Show(
                        "Vui lòng chọn chi tiết cần sửa trong bảng.");
                    return;
                }

                int maHd = Convert.ToInt32(cboHoaDon.SelectedValue);
                int maDv = maDichVuDangChon.Value;

                // Lấy chi tiết đang lưu để giữ nguyên đơn giá.
                var chiTietCu = chiTietBUS.GetByMaHd(maHd)
                    .FirstOrDefault(x => x.MaDv == maDv);

                if (chiTietCu == null)
                {
                    MessageBox.Show("Không tìm thấy chi tiết hóa đơn.");
                    return;
                }

                var chiTiet = new ChiTietHoaDon
                {
                    MaHd = maHd,
                    MaDv = maDv,
                    SoLuong = (int)nudSoLuong.Value,
                    DonGia = chiTietCu.DonGia,
                    ThanhTien = nudSoLuong.Value * chiTietCu.DonGia
                };

                chiTietBUS.Sua(chiTiet);

                HienThiChiTiet();
                CapNhatThanhTien();

                MessageBox.Show(
                    "Cập nhật chi tiết hóa đơn thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể sửa chi tiết hóa đơn: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboHoaDon.SelectedValue == null ||
                    !maDichVuDangChon.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết cần xóa.");
                    return;
                }

                var xacNhan = MessageBox.Show(
                    "Bạn có chắc muốn xóa chi tiết hóa đơn này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (xacNhan != DialogResult.Yes)
                    return;

                int maHd = Convert.ToInt32(cboHoaDon.SelectedValue);
                int maDv = maDichVuDangChon.Value;

                chiTietBUS.Xoa(maHd, maDv);

                maDichVuDangChon = null;

                HienThiChiTiet();
                CapNhatThanhTien();

                MessageBox.Show("Xóa chi tiết hóa đơn thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa chi tiết hóa đơn: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            maDichVuDangChon = null;

            if (cboDichVu.Items.Count > 0)
                cboDichVu.SelectedIndex = 0;

            nudSoLuong.Value = 1;

            dgvChiTietHoaDon.ClearSelection();

            CapNhatThanhTien();
        }
    }
}
