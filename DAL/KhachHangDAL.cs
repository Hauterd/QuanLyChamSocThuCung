using System.Collections.Generic;
using System.Linq;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.DAL
{
    public class KhachHangDAL
    {
        public List<KhachHang> GetAll()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.KhachHangs
            .OrderBy(x => x.MaKh)
            .ToList();
            }
        }
     public void Them(KhachHang khachHang)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                db.KhachHangs.Add(khachHang);
                db.SaveChanges();
            }
        }

        public void Sua(KhachHang khachHang)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var kh = db.KhachHangs
                    .FirstOrDefault(x => x.MaKh == khachHang.MaKh);

                if (kh != null)
                {
                    kh.HoTen = khachHang.HoTen;
                    kh.Sdt = khachHang.Sdt;
                    kh.Email = khachHang.Email;
                    kh.DiaChi = khachHang.DiaChi;
                    kh.GhiChu = khachHang.GhiChu;

                    db.SaveChanges();
                }
            }
        }

        public void Xoa(int maKH)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var kh = db.KhachHangs
                    .FirstOrDefault(x => x.MaKh == maKH);

                if (kh != null)
                {
                    db.KhachHangs.Remove(kh);
                    db.SaveChanges();
                }
            }
        }

        public List<KhachHang> TimKiem(string tuKhoa)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.KhachHangs
                    .Where(x =>
                        x.HoTen.Contains(tuKhoa) ||
                        x.Sdt.Contains(tuKhoa))
                    .ToList();
            }
        }
    }
}