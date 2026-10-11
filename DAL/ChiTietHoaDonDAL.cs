
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.DAL
{
    public class ChiTietHoaDonDAL
    {
        // Lấy toàn bộ chi tiết hóa đơn
        public List<ChiTietHoaDon> GetAll()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.ChiTietHoaDons
                    .Include(x => x.MaDvNavigation)
                    .OrderBy(x => x.MaHd)
                    .ThenBy(x => x.MaDv)
                    .ToList();
            }
        }

        // Lấy chi tiết theo mã hóa đơn
        public List<ChiTietHoaDon> GetByMaHd(int maHd)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.ChiTietHoaDons
                    .Include(x => x.MaDvNavigation)
                    .Where(x => x.MaHd == maHd)
                    .OrderBy(x => x.MaDv)
                    .ToList();
            }
        }

        // Thêm chi tiết hóa đơn

        public void Them(ChiTietHoaDon chiTiet)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                bool daTonTai = db.ChiTietHoaDons.Any(x =>
                    x.MaHd == chiTiet.MaHd &&
                    x.MaDv == chiTiet.MaDv);

                if (daTonTai)
                    throw new Exception("Dịch vụ này đã có trong hóa đơn.");

                chiTiet.ThanhTien = chiTiet.SoLuong * chiTiet.DonGia;

                db.ChiTietHoaDons.Add(chiTiet);
                CapNhatTongTien(db, chiTiet.MaHd);

                db.SaveChanges();
            }
        }


        // Sửa chi tiết hóa đơn

        public void Sua(ChiTietHoaDon chiTiet)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var item = db.ChiTietHoaDons.FirstOrDefault(x =>
                    x.MaHd == chiTiet.MaHd &&
                    x.MaDv == chiTiet.MaDv);

                if (item == null)
                    throw new Exception("Không tìm thấy chi tiết hóa đơn.");

                item.SoLuong = chiTiet.SoLuong;
                item.DonGia = chiTiet.DonGia;
                item.ThanhTien = item.SoLuong * item.DonGia;

                CapNhatTongTien(db, item.MaHd);
                db.SaveChanges();
            }
        }


        // Xóa chi tiết hóa đơn

        public void Xoa(int maHd, int maDv)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var item = db.ChiTietHoaDons.FirstOrDefault(x =>
                    x.MaHd == maHd &&
                    x.MaDv == maDv);

                if (item == null)
                    throw new Exception("Không tìm thấy chi tiết hóa đơn.");

                db.ChiTietHoaDons.Remove(item);

                CapNhatTongTien(db, maHd);
                db.SaveChanges();
            }
        }

        private void CapNhatTongTien(
            QuanLyChamSocThuCungContext db, int maHd)
        {
            var hoaDon = db.HoaDons.FirstOrDefault(x => x.MaHd == maHd);

            if (hoaDon == null)
                throw new Exception("Không tìm thấy hóa đơn.");

            hoaDon.TongTien = db.ChiTietHoaDons
                .Where(x => x.MaHd == maHd)
                .Select(x => x.ThanhTien ?? (x.SoLuong * x.DonGia))
                .Sum();
        }

    }
}
