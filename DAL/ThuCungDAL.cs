using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.DAL
{
    public class ThuCungDAL
    {
        // Lấy toàn bộ danh sách thú cưng
        public List<ThuCung> GetAll()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.ThuCungs
    .OrderBy(x => x.MaKh)
    .ThenBy(x => x.MaPet)
    .ToList();
            }
        }

        // Thêm thú cưng
        public void Them(ThuCung thuCung)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                db.ThuCungs.Add(thuCung);
                db.SaveChanges();
            }
        }

        // Sửa thú cưng
        public void Sua(ThuCung thuCung)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var pet = db.ThuCungs
                    .FirstOrDefault(x => x.MaPet == thuCung.MaPet);

                if (pet == null)
                    throw new Exception("Không tìm thấy thú cưng.");

                pet.MaKh = thuCung.MaKh;
                pet.TenPet = thuCung.TenPet;
                pet.Loai = thuCung.Loai;
                pet.Giong = thuCung.Giong;
                pet.GioiTinh = thuCung.GioiTinh;
                pet.NgaySinh = thuCung.NgaySinh;
                pet.CanNang = thuCung.CanNang;
                pet.MauLong = thuCung.MauLong;
                pet.GhiChu = thuCung.GhiChu;

                db.SaveChanges();
            }
        }

        // Xóa thú cưng
        public void Xoa(int maPet)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var pet = db.ThuCungs
                    .FirstOrDefault(x => x.MaPet == maPet);

                if (pet == null)
                    throw new Exception("Không tìm thấy thú cưng.");

                db.ThuCungs.Remove(pet);
                db.SaveChanges();
            }
        }

        // Tìm kiếm thú cưng
        public List<ThuCung> TimKiem(string tuKhoa)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                tuKhoa = tuKhoa.Trim();

                return db.ThuCungs
                    .Where(x =>
                        x.TenPet.Contains(tuKhoa) ||
                        x.Loai.Contains(tuKhoa) ||
                        (x.Giong != null && x.Giong.Contains(tuKhoa)))
                    .OrderBy(x => x.MaPet)
                    .ToList();
            }
        }
    }
}