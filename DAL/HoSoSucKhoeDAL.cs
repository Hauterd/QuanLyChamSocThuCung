using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.DAL
{
    public class HoSoSucKhoeDAL
    {
        public List<HoSoSucKhoe> GetAll()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.HoSoSucKhoes
                    .OrderBy(x => x.MaHoSo)
                    .ToList();
            }
        }

        public void Them(HoSoSucKhoe hoSo)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                db.HoSoSucKhoes.Add(hoSo);
                db.SaveChanges();
            }
        }

        public void Sua(HoSoSucKhoe hoSo)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var hs = db.HoSoSucKhoes
                    .FirstOrDefault(x => x.MaHoSo == hoSo.MaHoSo);

                if (hs == null)
                    throw new Exception("Không tìm thấy hồ sơ sức khỏe.");

                hs.MaPet = hoSo.MaPet;
                hs.CanNang = hoSo.CanNang;
                hs.TinhTrangSucKhoe = hoSo.TinhTrangSucKhoe;
                hs.TienSuBenh = hoSo.TienSuBenh;
                hs.DiUng = hoSo.DiUng;
                hs.NgayCapNhat = hoSo.NgayCapNhat;
                hs.GhiChu = hoSo.GhiChu;

                db.SaveChanges();
            }
        }

        public void Xoa(int maHoSo)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var hs = db.HoSoSucKhoes
                    .FirstOrDefault(x => x.MaHoSo == maHoSo);

                if (hs == null)
                    throw new Exception("Không tìm thấy hồ sơ sức khỏe.");

                db.HoSoSucKhoes.Remove(hs);
                db.SaveChanges();
            }
        }
    }
}