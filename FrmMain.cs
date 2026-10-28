
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung
{
    public partial class FrmMain : Form
    {
        private enum VaiTro
        {
            AdminToanQuyen,
            QuanLyTrungTam,
            TiepTan,
            NhanVienChamSoc,
            KhongXacDinh
        }

        private TaiKhoan? _taiKhoan;
        private VaiTro _vaiTro = VaiTro.KhongXacDinh;

        // Cho phép FrmLogin kiểm tra quyền trước khi hiển thị FrmMain.
        public bool QuyenHopLe =>
     _taiKhoan != null && _vaiTro != VaiTro.KhongXacDinh;

        // Constructor mặc định được giữ để WinForms Designer hoạt động.
        public FrmMain()
        {
            InitializeComponent();

            // Tránh đăng ký lặp sự kiện của các nút hiện đang xử lý thủ công.
            btnTrangChu.Click -= btnTrangChu_Click;
            btnTrangChu.Click += btnTrangChu_Click;

            btnKhachHang.Click -= btnKhachHang_Click;
            btnKhachHang.Click += btnKhachHang_Click;

            btnThuCung.Click -= btnThuCung_Click;
            btnThuCung.Click += btnThuCung_Click;
        }

        // Constructor sử dụng khi đăng nhập thực tế.
        public FrmMain(TaiKhoan taiKhoan) : this()
        {
            _taiKhoan = taiKhoan;
            _vaiTro = PhanLoaiQuyen(taiKhoan.Quyen);

            ApDungQuyenHienThi();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (_taiKhoan != null)
            {
                ApDungQuyenHienThi();
            }
        }

        private static string ChuanHoaQuyen(string? quyen)
        {
            if (string.IsNullOrWhiteSpace(quyen))
                return string.Empty;

            string chuoi = quyen.Trim()
                .ToLowerInvariant()
                .Replace('đ', 'd');

            string dangChuanHoa =
                chuoi.Normalize(NormalizationForm.FormD);

            StringBuilder ketQua = new StringBuilder();

            foreach (char kyTu in dangChuanHoa)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(kyTu)
                        != UnicodeCategory.NonSpacingMark
                    && char.IsLetterOrDigit(kyTu))
                {
                    ketQua.Append(kyTu);
                }
            }

            return ketQua.ToString();
        }

        private static VaiTro PhanLoaiQuyen(string? quyen)
        {
            string q = ChuanHoaQuyen(quyen);

            // Tài khoản Admin hiện tại vẫn có toàn quyền.
            if (q == "admin"
                || q == "superadmin"
                || q.Contains("quantrivien"))
            {
                return VaiTro.AdminToanQuyen;
            }

            if (q.Contains("quanlytrungtam")
                || q == "quanly"
                || q == "manager")
            {
                return VaiTro.QuanLyTrungTam;
            }

            if (q.Contains("tieptan")
                || q.Contains("letan")
                || q.Contains("reception"))
            {
                return VaiTro.TiepTan;
            }

            if (q.Contains("nhanvienchamsoc")
                || q.Contains("chamsoc")
                || q.Contains("carestaff"))
            {
                return VaiTro.NhanVienChamSoc;
            }

            return VaiTro.KhongXacDinh;
        }

        // Kiểm tra chức năng theo bảng phân quyền đã thống nhất.
        private bool CoQuyen(string chucNang)
        {
            // Không cấp quyền nếu chưa có tài khoản đăng nhập.
            if (_taiKhoan == null)
                return false;

            // Tài khoản Admin hiện tại có toàn quyền.
            if (_vaiTro == VaiTro.AdminToanQuyen)
                return true;

            switch (chucNang)
            {
                case "KhachHang":
                    return _vaiTro == VaiTro.TiepTan;

                case "ThuCung":
                    return _vaiTro == VaiTro.TiepTan
                        || _vaiTro == VaiTro.NhanVienChamSoc;

                case "NhanVien":
                case "DichVu":
                case "ThongKe":
                    return _vaiTro == VaiTro.QuanLyTrungTam;

                case "LichChamSoc":
                    return _vaiTro == VaiTro.TiepTan
                        || _vaiTro == VaiTro.NhanVienChamSoc;

                case "HoSoSucKhoe":
                case "TiemChung":
                    return _vaiTro == VaiTro.NhanVienChamSoc;

                case "HoaDon":
                    return _vaiTro == VaiTro.TiepTan;

                default:
                    return false;
            }
        }

        private void ApDungQuyenHienThi()
        {
            // Các nút điều hướng chung luôn hiển thị.
            btnTrangChu.Visible = true;
            btnDangXuat.Visible = true;

            btnKhachHang.Visible = CoQuyen("KhachHang");
            btnThuCung.Visible = CoQuyen("ThuCung");
            btnNhanVien.Visible = CoQuyen("NhanVien");
            btnDichVu.Visible = CoQuyen("DichVu");
            btnLichChamSoc.Visible = CoQuyen("LichChamSoc");
            btnHoSoSucKhoe.Visible = CoQuyen("HoSoSucKhoe");
            btnTiemChung.Visible = CoQuyen("TiemChung");
            btnHoaDon.Visible = CoQuyen("HoaDon");
            btnThongKe.Visible = CoQuyen("ThongKe");
        }

        // Hàm dùng chung để kiểm tra quyền và mở Form.
        private void MoFormCoQuyen(
            string chucNang,
            string tenChucNang,
            Func<Form> taoForm)
        {
            if (!CoQuyen(chucNang))
            {
                MessageBox.Show(
                    "Tài khoản không có quyền truy cập chức năng: "
                    + tenChucNang + ".",
                    "Không đủ quyền",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            this.Hide();

            Form frm = taoForm();

            frm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            frm.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            MoFormCoQuyen(
                "KhachHang",
                "Quản lý khách hàng",
                () => new FrmKhachHang());
        }

        private void btnThuCung_Click(object sender, EventArgs e)
        {
            MoFormCoQuyen(
                "ThuCung",
                "Quản lý thú cưng",
                () => new FrmThuCung());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            MoFormCoQuyen(
                "NhanVien",
                "Quản lý nhân viên",
                () => new FrmNhanVien());
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            MoFormCoQuyen(
                "DichVu",
                "Quản lý dịch vụ",
                () => new FrmDichVu());
        }

        private void btnLichChamSoc_Click(object sender, EventArgs e)
        {
            MoFormCoQuyen(
                "LichChamSoc",
                "Quản lý lịch chăm sóc",
                () => new FrmLichChamSoc());
        }

        private void btnHoSoSucKhoe_Click(object sender, EventArgs e)
        {
            MoFormCoQuyen(
                "HoSoSucKhoe",
                "Quản lý hồ sơ sức khỏe",
                () => new FrmHoSoSucKhoe());
        }

        private void btnTiemChung_Click(object sender, EventArgs e)
        {
            MoFormCoQuyen(
                "TiemChung",
                "Quản lý tiêm chủng",
                () => new FrmTiemChung());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            MoFormCoQuyen(
                "HoaDon",
                "Quản lý hóa đơn",
                () => new FrmHoaDon());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            MoFormCoQuyen(
                "ThongKe",
                "Thống kê",
                () => new FrmThongKe());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void lblChaoMung_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }
    }
}
