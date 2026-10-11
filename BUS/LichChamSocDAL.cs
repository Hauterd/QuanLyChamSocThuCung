
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyChamSocThuCung.DAL;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.BUS
{
    public class LichChamSocBUS
    {
        private readonly LichChamSocDAL _lichChamSocDAL;

        public LichChamSocBUS()
        {
            _lichChamSocDAL = new LichChamSocDAL();
        }

        public List<LichChamSoc> GetAll()
        {
            return _lichChamSocDAL.GetAll();
        }

        public void Them(LichChamSoc lich)
        {
            KiemTraDuLieu(lich);
            _lichChamSocDAL.Them(lich);
        }

        public void Sua(LichChamSoc lich)
        {
            if (lich == null || lich.MaLich <= 0)
                throw new Exception("Vui lòng chọn lịch cần sửa.");

            KiemTraDuLieu(lich);
            _lichChamSocDAL.Sua(lich);
        }

        public void Xoa(int maLich)
        {
            if (maLich <= 0)
                throw new Exception("Vui lòng chọn lịch cần xóa.");

            _lichChamSocDAL.Xoa(maLich);
        }

        private void KiemTraDuLieu(LichChamSoc lich)
        {
            if (lich == null)
                throw new Exception("Dữ liệu lịch chăm sóc không hợp lệ.");

            if (lich.MaPet <= 0)
                throw new Exception("Vui lòng chọn thú cưng.");

            if (lich.MaNv <= 0)
                throw new Exception("Vui lòng chọn nhân viên.");

            if (lich.NgayHen == default)
                throw new Exception("Vui lòng chọn ngày hẹn.");

            if (string.IsNullOrWhiteSpace(lich.TrangThai))
                throw new Exception("Vui lòng chọn trạng thái lịch.");

            string[] trangThaiHopLe =
            {
                "Chờ xác nhận",
                "Đã xác nhận",
                "Đang thực hiện",
                "Hoàn thành",
                "Đã hủy"
            };

            if (!trangThaiHopLe.Contains(lich.TrangThai))
                throw new Exception("Trạng thái lịch không hợp lệ.");
        }
    }
}
