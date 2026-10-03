using QuanLyChamSocThuCung.BUS;

namespace QuanLyThuCung
{
    public partial class Form1 : Form
    {
        private readonly KhachHangBUS _khachHangBUS;

        public Form1()
        {
            InitializeComponent();
            _khachHangBUS = new KhachHangBUS();
        }

        private void btnTestDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                var danhSach = _khachHangBUS.GetAll();

                dgvKhachHang.DataSource = danhSach;

                MessageBox.Show(
                    $"Kết nối thành công!\nCó {danhSach.Count} khách hàng.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Kết nối thất bại!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
