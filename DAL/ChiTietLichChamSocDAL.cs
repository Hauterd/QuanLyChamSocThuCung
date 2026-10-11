using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.DAL
{
    public class ChiTietLichChamSocDAL
    {
        // Lấy danh sách dịch vụ theo mã lịch chăm sóc
        public List<ChiTietLichChamSoc> GetByMaLich(int maLich)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.ChiTietLichChamSocs
                    .Include(x => x.MaDvNavigation)
                    .Where(x => x.MaLich == maLich)
                    .OrderBy(x => x.MaDv)
                    .ToList();
            }
        }

        // Thêm dịch vụ vào lịch chăm sóc
        public void Them(ChiTietLichChamSoc chiTiet)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                bool daTonTai = db.ChiTietLichChamSocs.Any(x =>
                    x.MaLich == chiTiet.MaLich &&
                    x.MaDv == chiTiet.MaDv);

                if (daTonTai)
                {
                    throw new Exception(
                        "Dịch vụ này đã có trong lịch. Em hãy sửa số lượng nếu cần.");
                }

                chiTiet.ThanhTien = chiTiet.SoLuong * chiTiet.DonGia;

                db.ChiTietLichChamSocs.Add(chiTiet);
                db.SaveChanges();
            }
        }

        // Cập nhật số lượng và đơn giá của dịch vụ
        public void Sua(ChiTietLichChamSoc chiTiet)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var item = db.ChiTietLichChamSocs.FirstOrDefault(x =>
                    x.MaLich == chiTiet.MaLich &&
                    x.MaDv == chiTiet.MaDv);

                if (item == null)
                {
                    throw new Exception(
                        "Không tìm thấy dịch vụ trong lịch chăm sóc.");
                }

                item.SoLuong = chiTiet.SoLuong;
                item.DonGia = chiTiet.DonGia;
                item.ThanhTien = item.SoLuong * item.DonGia;

                db.SaveChanges();
            }
        }

        // Xóa dịch vụ khỏi lịch chăm sóc
        public void Xoa(int maLich, int maDv)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var item = db.ChiTietLichChamSocs.FirstOrDefault(x =>
                    x.MaLich == maLich &&
                    x.MaDv == maDv);

                if (item == null)
                {
                    throw new Exception(
                        "Không tìm thấy dịch vụ cần xóa.");
                }

                db.ChiTietLichChamSocs.Remove(item);
                db.SaveChanges();
            }
        }

        // Tính tổng tiền dịch vụ của một lịch
        public decimal TinhTongTien(int maLich)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.ChiTietLichChamSocs
                    .Where(x => x.MaLich == maLich)
                    .Sum(x => x.ThanhTien ?? 0m);
            }
        }
    }
}