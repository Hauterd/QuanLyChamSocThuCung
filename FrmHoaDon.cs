using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using QuanLyChamSocThuCung.BUS;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung
{
    public partial class FrmHoaDon : Form
    {
        private readonly HoaDonBUS hoaDonBUS = new HoaDonBUS();
        private readonly DichVuBUS dichVuBUS = new DichVuBUS();
        private readonly List<ChiTietHoaDon> danhSachChiTiet
    = new List<ChiTietHoaDon>();
        public FrmHoaDon()
        {
            InitializeComponent();
            // Thiết lập dữ liệu mặc định cho ComboBox
            cboPhuongThucTt.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhuongThucTt.Items.Clear();
            cboPhuongThucTt.Items.AddRange(new object[]
            {
                "Tiền mặt",
                "Chuyển khoản",
                "Thẻ"
            });

            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[]
            {
                "Chưa thanh toán",
                "Đã thanh toán",
                "Đã hủy"
            });

            txtMaHd.ReadOnly = true;
            txtTongTien.ReadOnly = true;

            // Ngày lập mặc định là ngày hiện tại
            dtpNgayLap.Value = DateTime.Now;

            // Tải dữ liệu khi mở form
            Load += FrmHoaDon_Load;
        }


        private void HienThiChiTietHoaDon()
        {
            dgvChiTietHoaDon.DataSource = null;

            dgvChiTietHoaDon.AutoGenerateColumns = true;
            dgvChiTietHoaDon.DataSource = danhSachChiTiet
                .Select(x => new
                {
                    MaDv = x.MaDv,
                    TenDichVu = x.MaDvNavigation?.TenDv,
                    SoLuong = x.SoLuong,
                    DonGia = x.DonGia,
                    ThanhTien = x.SoLuong * x.DonGia
                })
                .ToList();

            dgvChiTietHoaDon.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            txtTongTien.Text = danhSachChiTiet
                .Sum(x => x.SoLuong * x.DonGia)
                .ToString("N0");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDanhSachHoaDon();
                LoadKhachHang();
                LoadNhanVien();
                LoadDichVu();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải dữ liệu: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachHoaDon()
        {
            var danhSach = hoaDonBUS.GetAll();

            dgvHoaDon.DataSource = null;
            dgvHoaDon.AutoGenerateColumns = true;
            dgvHoaDon.Columns.Clear();

            dgvHoaDon.DataSource = danhSach.Select(x => new
            {
                MaHd = x.MaHd,
                MaKh = x.MaKh,
                TenKhachHang = x.MaKhNavigation?.HoTen,
                MaNv = x.MaNv,
                TenNhanVien = x.MaNvNavigation?.HoTen,
                NgayLap = x.NgayLap,
                TongTien = x.TongTien,
                PhuongThucTt = x.PhuongThucTt,
                TrangThai = x.TrangThai,
                GhiChu = x.GhiChu
            }).ToList();

            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void LoadDichVu()
        {
            var danhSach = dichVuBUS.GetAll()
                .OrderBy(x => x.TenDv)
                .ToList();

            cboDichVu.DataSource = null;
            cboDichVu.Items.Clear();

            cboDichVu.DisplayMember = "TenDv";
            cboDichVu.ValueMember = "MaDv";
            cboDichVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDichVu.DataSource = danhSach;
        }





        private void LoadKhachHang()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var danhSach = db.KhachHangs
                    .OrderBy(x => x.MaKh)
                    .ToList();

                cboKhachHang.DataSource = danhSach;
                cboKhachHang.DisplayMember = "HoTen";
                cboKhachHang.ValueMember = "MaKh";
                cboKhachHang.SelectedIndex = -1;
            }
        }

        private void LoadNhanVien()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var danhSach = db.NhanViens
                    .OrderBy(x => x.MaNv)
                    .ToList();

                cboNhanVien.DataSource = danhSach;
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "MaNv";
                cboNhanVien.SelectedIndex = -1;
            }
        }

        private void LamMoiForm()
        {
            txtMaHd.Clear();
            cboKhachHang.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            dtpNgayLap.Value = DateTime.Now;
            txtTongTien.Text = "0";
            cboPhuongThucTt.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            txtGhiChu.Clear();

            dgvHoaDon.ClearSelection();
        }

        private void HienThiHoaDon()
        {
            if (dgvHoaDon.CurrentRow == null ||
                dgvHoaDon.CurrentRow.IsNewRow)
                return;

            var row = dgvHoaDon.CurrentRow;

            if (row.Cells["MaHd"].Value == null)
                return;

            txtMaHd.Text = row.Cells["MaHd"].Value.ToString();
            cboKhachHang.SelectedValue = Convert.ToInt32(row.Cells["MaKh"].Value);
            cboNhanVien.SelectedValue = Convert.ToInt32(row.Cells["MaNv"].Value);
            dtpNgayLap.Value = Convert.ToDateTime(row.Cells["NgayLap"].Value);
            txtTongTien.Text = Convert.ToDecimal(row.Cells["TongTien"].Value)
                .ToString("N0");

            string phuongThuc = row.Cells["PhuongThucTt"].Value?.ToString() ?? "";
            cboPhuongThucTt.SelectedItem = phuongThuc;

            string trangThai = row.Cells["TrangThai"].Value?.ToString() ?? "";
            cboTrangThai.SelectedItem = trangThai;

            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                HienThiHoaDon();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboKhachHang.SelectedValue == null ||
                    cboNhanVien.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng và nhân viên.");
                    return;
                }

                if (cboTrangThai.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái hóa đơn.");
                    return;
                }

                if (danhSachChiTiet.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm ít nhất một dịch vụ vào hóa đơn.");
                    return;
                }

                decimal tongTien = danhSachChiTiet
                    .Sum(x => x.SoLuong * x.DonGia);

                HoaDon hoaDon = new HoaDon
                {
                    MaKh = Convert.ToInt32(cboKhachHang.SelectedValue),
                    MaNv = Convert.ToInt32(cboNhanVien.SelectedValue),
                    NgayLap = dtpNgayLap.Value,
                    TongTien = tongTien,
                    PhuongThucTt = cboPhuongThucTt.SelectedItem?.ToString(),
                    TrangThai = cboTrangThai.SelectedItem.ToString()!,
                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text)
                        ? null
                        : txtGhiChu.Text.Trim()
                };

                hoaDonBUS.Them(hoaDon);

                MessageBox.Show(
                    "Thêm hóa đơn thành công!\nTổng tiền: " +
                    tongTien.ToString("N0") + " VNĐ");

                LoadDanhSachHoaDon();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm hóa đơn: " + ex.Message);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaHd.Text, out int maHd) || maHd <= 0)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn cần sửa.");
                    return;
                }

                if (cboKhachHang.SelectedValue == null ||
                    cboNhanVien.SelectedValue == null ||
                    cboTrangThai.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hóa đơn.");
                    return;
                }

                HoaDon hoaDon = new HoaDon
                {
                    MaHd = maHd,
                    MaKh = Convert.ToInt32(cboKhachHang.SelectedValue),
                    MaNv = Convert.ToInt32(cboNhanVien.SelectedValue),
                    NgayLap = dtpNgayLap.Value,
                    TongTien = danhSachChiTiet.Sum(
                        x => x.SoLuong * x.DonGia),
                    PhuongThucTt = cboPhuongThucTt.SelectedItem?.ToString(),
                    TrangThai = cboTrangThai.SelectedItem.ToString()!,
                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text)
                        ? null
                        : txtGhiChu.Text.Trim()
                };

                hoaDonBUS.Sua(hoaDon);

                MessageBox.Show("Cập nhật hóa đơn thành công!");
                LoadDanhSachHoaDon();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa hóa đơn: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaHd.Text, out int maHd) || maHd <= 0)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.");
                    return;
                }

                DialogResult ketQua = MessageBox.Show(
                    "Bạn có chắc muốn xóa hóa đơn này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (ketQua != DialogResult.Yes)
                    return;

                hoaDonBUS.Xoa(maHd);

                MessageBox.Show("Xóa hóa đơn thành công!");
                LoadDanhSachHoaDon();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa hóa đơn: " + ex.Message);
            }
        }


        private void TimKiemDichVu()
        {
            string tuKhoa = txtTimKiemDichVu.Text.Trim();

            var danhSach = dichVuBUS.GetAll()
                .Where(x => x.TenDv != null &&
                            x.TenDv.IndexOf(
                                tuKhoa,
                                StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(x => x.TenDv)
                .ToList();

            cboDichVu.DataSource = null;
            cboDichVu.DisplayMember = "TenDv";
            cboDichVu.ValueMember = "MaDv";
            cboDichVu.DataSource = danhSach;
            cboDichVu.SelectedIndex = danhSach.Count > 0 ? 0 : -1;

            if (danhSach.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dịch vụ phù hợp.");
            }
        }

        private void btnTimKiemDichVu_Click(object sender, EventArgs e)
        {
            TimKiemDichVu();
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDichVu.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ.");
                    return;
                }

                var dichVu = cboDichVu.SelectedItem as DichVu;

                if (dichVu == null)
                {
                    MessageBox.Show("Không đọc được thông tin dịch vụ.");
                    return;
                }

                int soLuong = (int)nudSoLuong.Value;

                if (soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0.");
                    return;
                }

                var chiTietCu = danhSachChiTiet
                    .FirstOrDefault(x => x.MaDv == dichVu.MaDv);

                if (chiTietCu != null)
                {
                    chiTietCu.SoLuong += soLuong;
                }
                else
                {
                    danhSachChiTiet.Add(new ChiTietHoaDon
                    {
                        MaDv = dichVu.MaDv,
                        SoLuong = soLuong,
                        DonGia = dichVu.DonGia,
                        MaDvNavigation = dichVu
                    });
                }

                HienThiChiTietHoaDon();

                MessageBox.Show("Đã thêm dịch vụ vào chi tiết hóa đơn.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thêm dịch vụ: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvChiTietHoaDon.Rows[e.RowIndex];

            if (row.Cells["MaDv"].Value == null)
                return;

            int maDv = Convert.ToInt32(row.Cells["MaDv"].Value);

            var dichVu = dichVuBUS.GetAll()
                .FirstOrDefault(x => x.MaDv == maDv);

            if (dichVu == null)
            {
                MessageBox.Show("Không tìm thấy thông tin dịch vụ.");
                return;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHoaDon.CurrentRow == null ||
                    dgvHoaDon.CurrentRow.Cells["MaHd"].Value == null)
                {
                    MessageBox.Show(
                        "Vui lòng chọn hóa đơn cần xem chi tiết.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                int maHd = Convert.ToInt32(
                    dgvHoaDon.CurrentRow.Cells["MaHd"].Value);

                using (FrmChiTietHoaDon frm = new FrmChiTietHoaDon(maHd))
                {
                    frm.ShowDialog();
                }

                // Tải lại danh sách để cập nhật tổng tiền sau khi
                // thêm, sửa hoặc xóa chi tiết hóa đơn.
                LoadDanhSachHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể mở chi tiết hóa đơn: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
