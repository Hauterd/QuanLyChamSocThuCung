using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyChamSocThuCung.BUS;
namespace QuanLyChamSocThuCung
{
    public partial class FrmThongKe : Form
    {
        private readonly ThongKeBUS thongKeBUS = new ThongKeBUS();
        public FrmThongKe()
        {
            InitializeComponent();
            this.Load += FrmThongKe_Load;
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            HienThiThongKe();
        }

        private void HienThiThongKe()
        {
            try
            {
                lblTongKhachHang.Text =
                thongKeBUS.DemKhachHang().ToString("N0");

                lblTongThuCung.Text =
                    thongKeBUS.DemThuCung().ToString("N0");

                lblTongLichChamSoc.Text =
                    thongKeBUS.DemLichChamSoc().ToString("N0");

                lblTongDoanhThu.Text =
                    thongKeBUS.TinhTongDoanhThu().ToString("N0") + " VNĐ";

                lblChuaThanhToan.Text =
                    thongKeBUS.DemHoaDonChuaThanhToan().ToString("N0");

                lblDaThanhToan.Text =
                    thongKeBUS.DemHoaDonDaThanhToan().ToString("N0");

                lblDaHuy.Text =
                    thongKeBUS.DemHoaDonDaHuy().ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu thống kê: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
