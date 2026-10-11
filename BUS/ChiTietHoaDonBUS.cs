
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyChamSocThuCung.DAL;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.BUS
{
    public class ChiTietHoaDonBUS
    {
        private readonly ChiTietHoaDonDAL _chiTietDAL =
            new ChiTietHoaDonDAL();

        public List<ChiTietHoaDon> GetAll()
        {
            return _chiTietDAL.GetAll();
        }

        public List<ChiTietHoaDon> GetByMaHd(int maHd)
        {
            if (maHd <= 0)
                throw new Exception("Mã hóa đơn không hợp lệ.");

            return _chiTietDAL.GetByMaHd(maHd);
        }

        public void Them(ChiTietHoaDon chiTiet)
        {
            KiemTraDuLieu(chiTiet);
            _chiTietDAL.Them(chiTiet);
        }

        public void Sua(ChiTietHoaDon chiTiet)
        {
            KiemTraDuLieu(chiTiet);
            _chiTietDAL.Sua(chiTiet);
        }

        public void Xoa(int maHd, int maDv)
        {
            if (maHd <= 0 || maDv <= 0)
                throw new Exception(
                    "Vui lòng chọn chi tiết hóa đơn cần xóa.");

            _chiTietDAL.Xoa(maHd, maDv);
        }

        private void KiemTraDuLieu(ChiTietHoaDon chiTiet)
        {
            if (chiTiet == null)
                throw new Exception(
                    "Dữ liệu chi tiết hóa đơn không hợp lệ.");

            if (chiTiet.MaHd <= 0)
                throw new Exception("Vui lòng chọn hóa đơn.");

            if (chiTiet.MaDv <= 0)
                throw new Exception("Vui lòng chọn dịch vụ.");

            if (chiTiet.SoLuong <= 0)
                throw new Exception("Số lượng phải lớn hơn 0.");

            if (chiTiet.DonGia < 0)
                throw new Exception("Đơn giá không được âm.");

            chiTiet.ThanhTien =
                chiTiet.SoLuong * chiTiet.DonGia;
        }
    }
}
