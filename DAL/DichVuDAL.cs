
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.DAL
{
    public class DichVuDAL
    {
        // Lấy danh sách dịch vụ
        public List<DichVu> GetAll()
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.DichVus
                    .OrderBy(x => x.MaDv)
                    .ToList();
            }
        }

        // Thêm dịch vụ
        public void Them(DichVu dichVu)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                db.DichVus.Add(dichVu);
                db.SaveChanges();
            }
        }

        // Cập nhật dịch vụ
        public void Sua(DichVu dichVu)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var dv = db.DichVus
                    .FirstOrDefault(x => x.MaDv == dichVu.MaDv);

                if (dv == null)
                    throw new Exception("Không tìm thấy dịch vụ.");

                dv.TenDv = dichVu.TenDv;
                dv.LoaiDv = dichVu.LoaiDv;
                dv.DonGia = dichVu.DonGia;
                dv.ThoiGianDuKien = dichVu.ThoiGianDuKien;
                dv.MoTa = dichVu.MoTa;
                dv.TrangThai = dichVu.TrangThai;

                db.SaveChanges();
            }
        }

        // Xóa dịch vụ
        public void Xoa(int maDv)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                var dv = db.DichVus
                    .FirstOrDefault(x => x.MaDv == maDv);

                if (dv == null)
                    throw new Exception("Không tìm thấy dịch vụ.");

                db.DichVus.Remove(dv);
                db.SaveChanges();
            }
        }
    }
}
