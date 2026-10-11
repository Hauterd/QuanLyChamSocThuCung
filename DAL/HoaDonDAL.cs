using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.DAL
{
    public class HoaDonDAL
    {
        // Lấy danh sách hóa đơn
        public List<HoaDon> GetAll()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.HoaDons
                    .Include(x => x.MaKhNavigation)
                    .Include(x => x.MaNvNavigation)
                    .OrderByDescending(x => x.MaHd)
                    .ToList();
            }
        }

        // Lấy hóa đơn theo mã
        public HoaDon? GetById(int maHd)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.HoaDons
                    .Include(x => x.MaKhNavigation)
                    .Include(x => x.MaNvNavigation)
                    .Include(x => x.ChiTietHoaDons)
                    .FirstOrDefault(x => x.MaHd == maHd);
            }
        }

        // Tìm kiếm hóa đơn theo mã
        public List<HoaDon> TimKiem(int maHd)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.HoaDons
                    .Include(x => x.MaKhNavigation)
                    .Include(x => x.MaNvNavigation)
                    .Where(x => x.MaHd == maHd)
                    .OrderByDescending(x => x.MaHd)
                    .ToList();
            }
        }

        // Thêm hóa đơn
        public void Them(HoaDon hoaDon)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                db.HoaDons.Add(hoaDon);
                db.SaveChanges();
            }
        }

        // Cập nhật hóa đơn
        public void Sua(HoaDon hoaDon)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var hd = db.HoaDons
                    .FirstOrDefault(x => x.MaHd == hoaDon.MaHd);

                if (hd == null)
                    throw new Exception("Không tìm thấy hóa đơn.");

                hd.MaKh = hoaDon.MaKh;
                hd.MaNv = hoaDon.MaNv;
                hd.NgayLap = hoaDon.NgayLap;
                hd.TongTien = hoaDon.TongTien;
                hd.PhuongThucTt = hoaDon.PhuongThucTt;
                hd.TrangThai = hoaDon.TrangThai;
                hd.GhiChu = hoaDon.GhiChu;

                db.SaveChanges();
            }
        }

        // Xóa hóa đơn
        public void Xoa(int maHd)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var hd = db.HoaDons
                    .FirstOrDefault(x => x.MaHd == maHd);

                if (hd == null)
                    throw new Exception("Không tìm thấy hóa đơn.");

                if (hd.ChiTietHoaDons.Any())
                {
                    throw new Exception(
                        "Hóa đơn đã có chi tiết, không thể xóa.");
                }

                db.HoaDons.Remove(hd);
                db.SaveChanges();
            }
        }
    }
}