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
using ClosedXML.Excel;
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
            btnXuatExcel.Click -= btnXuatExcel_Click;
            btnXuatExcel.Click += btnXuatExcel_Click;
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

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            // Bước 1: Kiểm tra khách hàng được chọn
            if (cboKhachHang.SelectedValue == null ||
                !int.TryParse(
                    Convert.ToString(cboKhachHang.SelectedValue),
                    out int maKh))
            {
                MessageBox.Show(
                    "Vui lòng chọn khách hàng cần xuất Excel.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new QuanLyChamSocThuCungContext())
                {
                    // Bước 2: Lấy thông tin khách hàng
                    var khachHang = db.KhachHangs
                        .Where(k => k.MaKh == maKh)
                        .Select(k => new
                        {
                            k.MaKh,
                            k.HoTen,
                            k.Sdt,
                            k.Email,
                            k.DiaChi,
                            k.GhiChu
                        })
                        .FirstOrDefault();

                    if (khachHang == null)
                    {
                        MessageBox.Show(
                            "Không tìm thấy thông tin khách hàng.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    // Bước 3: Lấy tất cả hóa đơn của khách hàng
                    var hoaDons = db.HoaDons
                        .Where(h => h.MaKh == maKh)
                        .Select(h => new
                        {
                            h.MaHd,
                            h.NgayLap,
                            TenNhanVien = h.MaNvNavigation != null
                                ? h.MaNvNavigation.HoTen
                                : "",
                            h.TongTien,
                            h.PhuongThucTt,
                            h.TrangThai,
                            h.GhiChu
                        })
                        .OrderBy(h => h.NgayLap)
                        .ToList();

                    // Bước 4: Lấy chi tiết của các hóa đơn trên
                    var danhSachMaHd = hoaDons
                        .Select(h => h.MaHd)
                        .ToList();

                    var chiTiets = db.ChiTietHoaDons
                        .Where(ct => danhSachMaHd.Contains(ct.MaHd))
                        .Select(ct => new
                        {
                            ct.MaHd,
                            ct.MaDv,
                            TenDichVu = ct.MaDvNavigation != null
                                ? ct.MaDvNavigation.TenDv
                                : "",
                            ct.SoLuong,
                            ct.DonGia,

                            // ThanhTien là decimal? nên có giá trị dự phòng
                            ThanhTien = ct.ThanhTien
                                ?? (ct.SoLuong * ct.DonGia)
                        })
                        .OrderBy(ct => ct.MaHd)
                        .ThenBy(ct => ct.MaDv)
                        .ToList();

                    // Bước 5: Chọn nơi lưu file Excel
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Title = "Xuất báo cáo hóa đơn khách hàng";
                        sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                        sfd.DefaultExt = "xlsx";
                        sfd.AddExtension = true;
                        sfd.FileName =
                            $"BaoCaoHoaDon_KH_{maKh}_{DateTime.Now:yyyyMMdd}.xlsx";

                        if (sfd.ShowDialog() != DialogResult.OK)
                            return;

                        // Bước 6: Tạo workbook Excel
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            // ==========================================
                            // SHEET 1: THÔNG TIN KHÁCH HÀNG
                            // ==========================================
                            var wsKH = workbook.Worksheets
                                .Add("ThongTinKhachHang");

                            wsKH.Cell("A1").Value =
                                "PET HEAL - THÔNG TIN KHÁCH HÀNG";

                            wsKH.Range("A1:B1").Merge();

                            wsKH.Cell("A3").Value = "Mã khách hàng";
                            wsKH.Cell("B3").Value = khachHang.MaKh;

                            wsKH.Cell("A4").Value = "Họ tên";
                            wsKH.Cell("B4").Value = khachHang.HoTen ?? "";

                            wsKH.Cell("A5").Value = "Số điện thoại";
                            wsKH.Cell("B5").Value = khachHang.Sdt ?? "";

                            wsKH.Cell("A6").Value = "Email";
                            wsKH.Cell("B6").Value = khachHang.Email ?? "";

                            wsKH.Cell("A7").Value = "Địa chỉ";
                            wsKH.Cell("B7").Value = khachHang.DiaChi ?? "";

                            wsKH.Cell("A8").Value = "Ghi chú";
                            wsKH.Cell("B8").Value = khachHang.GhiChu ?? "";

                            wsKH.Range("A1:B1").Style.Font.Bold = true;
                            wsKH.Range("A1:B1").Style.Font.FontSize = 16;
                            wsKH.Range("A1:B1").Style.Alignment
                                .Horizontal = XLAlignmentHorizontalValues.Center;

                            wsKH.Range("A3:A8").Style.Font.Bold = true;
                            wsKH.Columns().AdjustToContents();

                            // ==========================================
                            // SHEET 2: DANH SÁCH HÓA ĐƠN
                            // ==========================================
                            var wsHD = workbook.Worksheets
                                .Add("DanhSachHoaDon");

                            string[] tieuDeHD =
                            {
                        "Mã hóa đơn",
                        "Ngày lập",
                        "Nhân viên",
                        "Tổng tiền",
                        "Phương thức thanh toán",
                        "Trạng thái",
                        "Ghi chú"
                    };

                            for (int i = 0; i < tieuDeHD.Length; i++)
                            {
                                wsHD.Cell(1, i + 1).Value = tieuDeHD[i];
                            }

                            int dongHD = 2;

                            foreach (var hd in hoaDons)
                            {
                                wsHD.Cell(dongHD, 1).Value = hd.MaHd;
                                wsHD.Cell(dongHD, 2).Value = hd.NgayLap;
                                wsHD.Cell(dongHD, 3).Value =
                                    hd.TenNhanVien ?? "";
                                wsHD.Cell(dongHD, 4).Value =
                                    Convert.ToDecimal(hd.TongTien);
                                wsHD.Cell(dongHD, 5).Value =
                                    hd.PhuongThucTt ?? "";
                                wsHD.Cell(dongHD, 6).Value =
                                    hd.TrangThai ?? "";
                                wsHD.Cell(dongHD, 7).Value =
                                    hd.GhiChu ?? "";

                                dongHD++;
                            }

                            // Chỉ định dạng ngày tháng cho các dòng hóa đơn,
                            // không áp dụng cho phần tổng hợp ở cuối bảng.
                            if (dongHD > 2)
                            {
                                wsHD.Range(2, 2, dongHD - 1, 2)
                                    .Style.DateFormat.Format = "dd/MM/yyyy";
                            }

                            wsHD.Column(4).Style.NumberFormat.Format =
                                "#,##0";

                            wsHD.Range(1, 1, 1, 7).Style.Font.Bold = true;

                            wsHD.Range(1, 1, 1, 7).Style.Fill
                                .BackgroundColor = XLColor.LightBlue;

                            // Chỉ tạo bảng nếu có dữ liệu hóa đơn
                            if (dongHD > 2)
                            {
                                wsHD.Range(1, 1, dongHD - 1, 7).CreateTable();
                            }

                            // Tổng hợp hóa đơn
                            int dongTongHop = dongHD + 1;

                            decimal tongGiaTri = hoaDons.Sum(
                                h => Convert.ToDecimal(h.TongTien));

                            decimal tongDaThanhToan = hoaDons
                                .Where(h => h.TrangThai == "Đã thanh toán")
                                .Sum(h => Convert.ToDecimal(h.TongTien));

                            wsHD.Cell(dongTongHop, 1).Value = "TỔNG HỢP";
                            wsHD.Cell(dongTongHop, 1).Style.Font.Bold = true;

                            wsHD.Cell(dongTongHop + 1, 1).Value =
                                "Số lượng hóa đơn";
                            wsHD.Cell(dongTongHop + 1, 2).Value =
                                hoaDons.Count;

                            wsHD.Cell(dongTongHop + 2, 1).Value =
                                "Tổng giá trị hóa đơn";
                            wsHD.Cell(dongTongHop + 2, 2).Value =
                                tongGiaTri;

                            wsHD.Cell(dongTongHop + 3, 1).Value =
                                "Giá trị hóa đơn đã thanh toán";
                            wsHD.Cell(dongTongHop + 3, 2).Value =
                                tongDaThanhToan;

                            wsHD.Cell(dongTongHop + 4, 1).Value =
                                "Số hóa đơn chưa thanh toán";
                            wsHD.Cell(dongTongHop + 4, 2).Value =
                                hoaDons.Count(
                                    h => h.TrangThai == "Chưa thanh toán");

                            wsHD.Cell(dongTongHop + 5, 1).Value =
                                "Số hóa đơn đã hủy";
                            wsHD.Cell(dongTongHop + 5, 2).Value =
                                hoaDons.Count(
                                    h => h.TrangThai == "Đã hủy");

                            wsHD.Range(
                                dongTongHop + 2, 2,
                                dongTongHop + 3, 2
                            ).Style.NumberFormat.Format = "#,##0";

                            wsHD.Columns().AdjustToContents();
                            wsHD.SheetView.FreezeRows(1);

                            // ==========================================
                            // SHEET 3: CHI TIẾT HÓA ĐƠN
                            // ==========================================
                            var wsCT = workbook.Worksheets
                                .Add("ChiTietHoaDon");

                            string[] tieuDeCT =
                            {
                        "Mã hóa đơn",
                        "Mã dịch vụ",
                        "Tên dịch vụ",
                        "Số lượng",
                        "Đơn giá",
                        "Thành tiền"
                    };

                            for (int i = 0; i < tieuDeCT.Length; i++)
                            {
                                wsCT.Cell(1, i + 1).Value = tieuDeCT[i];
                            }

                            int dongCT = 2;

                            foreach (var ct in chiTiets)
                            {
                                wsCT.Cell(dongCT, 1).Value = ct.MaHd;
                                wsCT.Cell(dongCT, 2).Value = ct.MaDv;
                                wsCT.Cell(dongCT, 3).Value =
                                    ct.TenDichVu ?? "";
                                wsCT.Cell(dongCT, 4).Value = ct.SoLuong;
                                wsCT.Cell(dongCT, 5).Value =
                                    Convert.ToDecimal(ct.DonGia);
                                wsCT.Cell(dongCT, 6).Value =
                                    Convert.ToDecimal(ct.ThanhTien);

                                dongCT++;
                            }

                            wsCT.Range(1, 1, 1, 6).Style.Font.Bold = true;
                            wsCT.Range(1, 1, 1, 6).Style.Fill
                                .BackgroundColor = XLColor.LightBlue;

                            wsCT.Column(5).Style.NumberFormat.Format = "#,##0";
                            wsCT.Column(6).Style.NumberFormat.Format = "#,##0";

                            if (dongCT > 2)
                            {
                                wsCT.Range(1, 1, dongCT - 1, 6).CreateTable();
                            }
                            // Định dạng số lượng hóa đơn là số nguyên
                            wsHD.Cell(dongTongHop + 1, 2)
                                .Style.NumberFormat.Format = "0";

                            wsHD.Cell(dongTongHop + 4, 2)
                                .Style.NumberFormat.Format = "0";

                            wsHD.Cell(dongTongHop + 5, 2)
                                .Style.NumberFormat.Format = "0";

                            // Định dạng tiền
                            wsHD.Cell(dongTongHop + 2, 2)
                                .Style.NumberFormat.Format = "#,##0";

                            wsHD.Cell(dongTongHop + 3, 2)
                                .Style.NumberFormat.Format = "#,##0";

                            wsCT.Columns().AdjustToContents();
                            wsCT.SheetView.FreezeRows(1);

                            // Bước 7: Lưu file
                            workbook.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show(
                            "Xuất Excel thành công!\n\n" +
                            "Khách hàng: " + khachHang.HoTen + "\n" +
                            "Số hóa đơn: " + hoaDons.Count + "\n" +
                            "Đường dẫn: " + sfd.FileName,
                            "Hoàn tất",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xuất Excel:\n\n" + ex.Message,
                    "Lỗi xuất Excel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}
