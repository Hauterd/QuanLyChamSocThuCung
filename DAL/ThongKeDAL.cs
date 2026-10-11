using Microsoft.EntityFrameworkCore;
using QuanLyChamSocThuCung.Models;
using System;
using System.Linq;

namespace QuanLyChamSocThuCung.DAL
{
    public class ThongKeDAL
    {
        // Đếm tổng số khách hàng
        public int DemKhachHang()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.KhachHangs.Count();
            }
        }

        // Đếm tổng số thú cưng
        public int DemThuCung()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.ThuCungs.Count();
            }
        }

        // Đếm tổng số lịch chăm sóc
        public int DemLichChamSoc()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.LichChamSocs.Count();
            }
        }

        // Tính tổng doanh thu hóa đơn đã thanh toán
        public decimal TinhTongDoanhThu()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.HoaDons
                    .Where(x => x.TrangThai == "Đã thanh toán")
                    .Sum(x => (decimal?)x.TongTien) ?? 0;
            }
        }

        // Đếm hóa đơn chưa thanh toán
        public int DemHoaDonChuaThanhToan()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.HoaDons
                    .Count(x => x.TrangThai == "Chưa thanh toán");
            }
        }

        // Đếm hóa đơn đã thanh toán
        public int DemHoaDonDaThanhToan()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.HoaDons
                    .Count(x => x.TrangThai == "Đã thanh toán");
            }
        }

        // Đếm hóa đơn đã hủy
        public int DemHoaDonDaHuy()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.HoaDons
                    .Count(x => x.TrangThai == "Đã hủy");
            }
        }
    }

}