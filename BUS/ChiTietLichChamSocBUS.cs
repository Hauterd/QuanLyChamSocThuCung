
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyChamSocThuCung.DAL;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.BUS
{
    public class ChiTietLichChamSocBUS
    {
        private readonly ChiTietLichChamSocDAL _dal;

        public ChiTietLichChamSocBUS()
        {
            _dal = new ChiTietLichChamSocDAL();
        }

        // Lấy danh sách dịch vụ theo lịch
        public List<ChiTietLichChamSoc> GetByMaLich(int maLich)
        {
            if (maLich <= 0)
                throw new Exception("Mã lịch chăm sóc không hợp lệ.");

            return _dal.GetByMaLich(maLich);
        }

        // Thêm dịch vụ
        public void Them(ChiTietLichChamSoc chiTiet)
        {
            KiemTraDuLieu(chiTiet);
            _dal.Them(chiTiet);
        }

        // Sửa dịch vụ
        public void Sua(ChiTietLichChamSoc chiTiet)
        {
            KiemTraDuLieu(chiTiet);
            _dal.Sua(chiTiet);
        }

        // Xóa dịch vụ
        public void Xoa(int maLich, int maDv)
        {
            if (maLich <= 0)
                throw new Exception("Mã lịch chăm sóc không hợp lệ.");

            if (maDv <= 0)
                throw new Exception("Vui lòng chọn dịch vụ cần xóa.");

            _dal.Xoa(maLich, maDv);
        }

        // Tính tổng tiền dịch vụ
        public decimal TinhTongTien(int maLich)
        {
            if (maLich <= 0)
                throw new Exception("Mã lịch chăm sóc không hợp lệ.");

            return _dal.TinhTongTien(maLich);
        }

        private void KiemTraDuLieu(ChiTietLichChamSoc chiTiet)
        {
            if (chiTiet == null)
                throw new Exception("Dữ liệu chi tiết lịch không hợp lệ.");

            if (chiTiet.MaLich <= 0)
                throw new Exception("Vui lòng chọn lịch chăm sóc.");

            if (chiTiet.MaDv <= 0)
                throw new Exception("Vui lòng chọn dịch vụ.");

            if (chiTiet.SoLuong <= 0)
                throw new Exception("Số lượng dịch vụ phải lớn hơn 0.");

            if (chiTiet.DonGia < 0)
                throw new Exception("Đơn giá không được âm.");

            chiTiet.ThanhTien = chiTiet.SoLuong * chiTiet.DonGia;
        }
    }
}
