using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.DAL
{
    public class NhanVienDAL
    {
        public List<NhanVien> GetAll()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.NhanViens
                    .OrderBy(x => x.MaNv)
                    .ToList();
            }
        }

        public void Them(NhanVien nhanVien)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                db.NhanViens.Add(nhanVien);
                db.SaveChanges();
            }
        }

        public void Sua(NhanVien nhanVien)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var nv = db.NhanViens
                    .FirstOrDefault(x => x.MaNv == nhanVien.MaNv);

                if (nv == null)
                    throw new Exception("Không tìm thấy nhân viên.");

                nv.HoTen = nhanVien.HoTen;
                nv.GioiTinh = nhanVien.GioiTinh;
                nv.NgaySinh = nhanVien.NgaySinh;
                nv.Sdt = nhanVien.Sdt;
                nv.DiaChi = nhanVien.DiaChi;
                nv.ChucVu = nhanVien.ChucVu;
                nv.TrangThai = nhanVien.TrangThai;

                db.SaveChanges();
            }
        }

        public void Xoa(int maNv)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var nv = db.NhanViens
                    .FirstOrDefault(x => x.MaNv == maNv);

                if (nv == null)
                    throw new Exception("Không tìm thấy nhân viên.");

                db.NhanViens.Remove(nv);
                db.SaveChanges();
            }
        }
    }
}