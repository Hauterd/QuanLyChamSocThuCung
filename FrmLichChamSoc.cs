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
    public partial class FrmLichChamSoc : Form
    {
        private readonly LichChamSocBUS _lichChamSocBUS =
    new LichChamSocBUS();
        public FrmLichChamSoc()
        {
            InitializeComponent();
            txtMaLich.ReadOnly = true;

            cboThuCung.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpGioHen.Format = DateTimePickerFormat.Time;
            dtpGioHen.ShowUpDown = true;


            LoadThuCung();
            LoadNhanVien();
            LoadTrangThai();
            LoadDanhSachLich();

            lblTongTien.Text = "0 VNĐ";
        }
        private void LoadThuCung()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var danhSach = db.ThuCungs
                    .Select(x => new
                    {
                        x.MaPet,
                        x.TenPet
                    })
                    .ToList();

                cboThuCung.DataSource = danhSach;
                cboThuCung.DisplayMember = "TenPet";
                cboThuCung.ValueMember = "MaPet";
                cboThuCung.SelectedIndex = -1;
            }
        }

        private void LoadNhanVien()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var danhSach = db.NhanViens
                    .Where(x => x.TrangThai)
                    .Select(x => new
                    {
                        x.MaNv,
                        x.HoTen
                    })
                    .ToList();

                cboNhanVien.DataSource = danhSach;
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "MaNv";
                cboNhanVien.SelectedIndex = -1;
            }
        }
        private void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();

            cboTrangThai.Items.Add("Chờ xác nhận");
            cboTrangThai.Items.Add("Đã xác nhận");
            cboTrangThai.Items.Add("Đang thực hiện");
            cboTrangThai.Items.Add("Hoàn thành");
            cboTrangThai.Items.Add("Đã hủy");

            cboTrangThai.SelectedIndex = -1;
        }

        private void LoadDanhSachLich()
        {
            try
            {
                dgvLichChamSoc.DataSource = null;
                dgvLichChamSoc.AutoGenerateColumns = true;
                dgvLichChamSoc.DataSource = _lichChamSocBUS.GetAll()
                    .Select(x => new
                    {
                        x.MaLich,
                        TenThuCung = x.MaPetNavigation.TenPet,
                        TenNhanVien = x.MaNvNavigation.HoTen,
                        NgayHen = x.NgayHen.ToString("dd/MM/yyyy"),
                        GioHen = x.GioHen.ToString("HH:mm"),
                        x.TrangThai,
                        x.GhiChu
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách lịch chăm sóc:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private LichChamSoc LayDuLieuTuForm()
        {
            if (cboThuCung.SelectedValue == null)
                throw new Exception("Vui lòng chọn thú cưng.");

            if (cboNhanVien.SelectedValue == null)
                throw new Exception("Vui lòng chọn nhân viên.");

            if (cboTrangThai.SelectedItem == null)
                throw new Exception("Vui lòng chọn trạng thái.");

            return new LichChamSoc
            {
                MaPet = Convert.ToInt32(cboThuCung.SelectedValue),
                MaNv = Convert.ToInt32(cboNhanVien.SelectedValue),
                NgayHen = DateOnly.FromDateTime(dtpNgayHen.Value),
                GioHen = TimeOnly.FromDateTime(dtpGioHen.Value),
                TrangThai = cboTrangThai.SelectedItem.ToString()!,
                GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text)
                    ? null
                    : txtGhiChu.Text.Trim()
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LichChamSoc lich = LayDuLieuTuForm();

                _lichChamSocBUS.Them(lich);

                MessageBox.Show(
                    "Thêm lịch chăm sóc thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSachLich();
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
        private void LamMoi()
        {
            txtMaLich.Clear();
            cboThuCung.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            dtpNgayHen.Value = DateTime.Today;
            dtpGioHen.Value = DateTime.Now;
            txtGhiChu.Clear();
            lblTongTien.Text = "0 VNĐ";

            dgvLichChamSoc.ClearSelection();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSachLich();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaLich.Text, out int maLich))
                {
                    MessageBox.Show("Vui lòng chọn lịch cần sửa.");
                    return;
                }

                LichChamSoc lich = LayDuLieuTuForm();
                lich.MaLich = maLich;

                _lichChamSocBUS.Sua(lich);

                MessageBox.Show("Cập nhật lịch chăm sóc thành công!");

                LoadDanhSachLich();
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

        private void dgvLichChamSoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvLichChamSoc.Rows[e.RowIndex];

            txtMaLich.Text = row.Cells["MaLich"].Value?.ToString();

            string tenPet = row.Cells["TenThuCung"].Value?.ToString() ?? "";
            string tenNhanVien = row.Cells["TenNhanVien"].Value?.ToString() ?? "";

            using (var db = new QuanLyChamSocThuCungContext())
            {
                var pet = db.ThuCungs
                    .FirstOrDefault(x => x.TenPet == tenPet);

                if (pet != null)
                    cboThuCung.SelectedValue = pet.MaPet;

                var nhanVien = db.NhanViens
                    .FirstOrDefault(x => x.HoTen == tenNhanVien);

                if (nhanVien != null)
                    cboNhanVien.SelectedValue = nhanVien.MaNv;
            }

            DateTime ngayHen = DateTime.Parse(
                row.Cells["NgayHen"].Value?.ToString() ?? "");

            dtpNgayHen.Value = ngayHen;

            dtpGioHen.Value = DateTime.Today.Add(
                TimeSpan.Parse(row.Cells["GioHen"].Value?.ToString() ?? "00:00"));

            cboTrangThai.SelectedItem =
                row.Cells["TrangThai"].Value?.ToString();

            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaLich.Text, out int maLich))
                {
                    MessageBox.Show("Vui lòng chọn lịch cần xóa.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa lịch chăm sóc này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes) return;

                _lichChamSocBUS.Xoa(maLich);

                MessageBox.Show("Xóa lịch chăm sóc thành công!");

                LoadDanhSachLich();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Không thể xóa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();

                var ketQua = _lichChamSocBUS.GetAll()
                    .Where(x =>
                        x.MaPetNavigation.TenPet.Contains(
                            tuKhoa, StringComparison.OrdinalIgnoreCase)
                        || x.MaNvNavigation.HoTen.Contains(
                            tuKhoa, StringComparison.OrdinalIgnoreCase)
                        || x.TrangThai.Contains(
                            tuKhoa, StringComparison.OrdinalIgnoreCase))
                    .Select(x => new
                    {
                        x.MaLich,
                        TenThuCung = x.MaPetNavigation.TenPet,
                        TenNhanVien = x.MaNvNavigation.HoTen,
                        NgayHen = x.NgayHen.ToString("dd/MM/yyyy"),
                        GioHen = x.GioHen.ToString("HH:mm"),
                        x.TrangThai,
                        x.GhiChu
                    })
                    .ToList();

                dgvLichChamSoc.DataSource = null;
                dgvLichChamSoc.DataSource = ketQua;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
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
                if (dgvLichChamSoc.CurrentRow == null ||
                    dgvLichChamSoc.CurrentRow.IsNewRow)
                {
                    MessageBox.Show(
                        "Vui lòng chọn lịch chăm sóc cần xem chi tiết.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                object giaTriMaLich =
                    dgvLichChamSoc.CurrentRow.Cells["MaLich"].Value;

                if (giaTriMaLich == null ||
                    !int.TryParse(giaTriMaLich.ToString(), out int maLich) ||
                    maLich <= 0)
                {
                    MessageBox.Show("Không lấy được mã lịch chăm sóc.");
                    return;
                }

                using (FrmChiTietLichChamSoc frm =
     new FrmChiTietLichChamSoc(maLich))
                {
                    frm.ShowDialog(this);
                }

                // Sau khi đóng form chi tiết, cập nhật lại danh sách
                LoadDanhSachLich();

                // Cập nhật tổng tiền của lịch vừa chọn
                CapNhatTongTien(maLich);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể mở chi tiết lịch chăm sóc: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void CapNhatTongTien(int maLich)
        {
            try
            {
                using (var db = new QuanLyChamSocThuCungContext())
                {
                    decimal tongTien = db.ChiTietLichChamSocs
                        .Where(x => x.MaLich == maLich)
                        .Sum(x => x.ThanhTien ?? 0m);

                    lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi cập nhật tổng tiền dự tính: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }
    }
}
