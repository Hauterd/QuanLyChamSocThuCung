
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.DAL
{
    public class LichChamSocDAL
    {
        public List<LichChamSoc> GetAll()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.LichChamSocs
                    .Include(x => x.MaPetNavigation)
                    .Include(x => x.MaNvNavigation)
                    .OrderByDescending(x => x.NgayHen)
                    .ThenBy(x => x.GioHen)
                    .ToList();
            }
        }

        public void Them(LichChamSoc lich)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                db.LichChamSocs.Add(lich);
                db.SaveChanges();
            }
        }

        public void Sua(LichChamSoc lich)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var item = db.LichChamSocs
                    .FirstOrDefault(x => x.MaLich == lich.MaLich);

                if (item == null)
                    throw new Exception("Không tìm thấy lịch chăm sóc.");

                item.MaPet = lich.MaPet;
                item.MaNv = lich.MaNv;
                item.NgayHen = lich.NgayHen;
                item.GioHen = lich.GioHen;
                item.TrangThai = lich.TrangThai;
                item.GhiChu = lich.GhiChu;

                db.SaveChanges();
            }
        }

        public void Xoa(int maLich)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var item = db.LichChamSocs
                    .FirstOrDefault(x => x.MaLich == maLich);

                if (item == null)
                    throw new Exception("Không tìm thấy lịch chăm sóc.");

                if (db.ChiTietLichChamSocs.Any(x => x.MaLich == maLich))
                    throw new Exception(
                        "Lịch đã có dịch vụ chi tiết, không thể xóa trực tiếp.");

                db.LichChamSocs.Remove(item);
                db.SaveChanges();
            }
        }
    }
}
