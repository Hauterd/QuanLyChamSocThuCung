using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.DAL
{
    public class TiemChungDAL
    {
        public List<TiemChung> GetAll()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.TiemChungs
                    .OrderBy(x => x.MaTiem)
                    .ToList();
            }
        }

        public void Them(TiemChung tiemChung)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                db.TiemChungs.Add(tiemChung);
                db.SaveChanges();
            }
        }

        public void Sua(TiemChung tiemChung)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var tc = db.TiemChungs
                    .FirstOrDefault(x => x.MaTiem == tiemChung.MaTiem);

                if (tc == null)
                    throw new Exception("Không tìm thấy thông tin tiêm chủng.");

                tc.MaPet = tiemChung.MaPet;
                tc.TenVacXin = tiemChung.TenVacXin;
                tc.MuiTiem = tiemChung.MuiTiem;
                tc.NgayTiem = tiemChung.NgayTiem;
                tc.NgayNhac = tiemChung.NgayNhac;
                tc.NoiTiem = tiemChung.NoiTiem;
                tc.GhiChu = tiemChung.GhiChu;

                db.SaveChanges();
            }
        }

        public void Xoa(int maTiem)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var tc = db.TiemChungs
                    .FirstOrDefault(x => x.MaTiem == maTiem);

                if (tc == null)
                    throw new Exception("Không tìm thấy thông tin tiêm chủng.");

                db.TiemChungs.Remove(tc);
                db.SaveChanges();
            }
        }
    }
}