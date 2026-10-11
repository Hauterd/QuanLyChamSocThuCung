using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyChamSocThuCung.DAL;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.BUS
{
    public class HoaDonBUS
    {
        private readonly HoaDonDAL hoaDonDAL = new HoaDonDAL();

        // Lấy danh sách hóa đơn
        public List<HoaDon> GetAll()
        {
            return hoaDonDAL.GetAll();
        }

        // Lấy hóa đơn theo mã
        public HoaDon? GetById(int maHd)
        {
            if (maHd <= 0)
                throw new Exception("Mã hóa đơn không hợp lệ.");

            return hoaDonDAL.GetById(maHd);
        }

        // Tìm kiếm hóa đơn
        public List<HoaDon> TimKiem(int maHd)
        {
            if (maHd <= 0)
                throw new Exception("Vui lòng nhập mã hóa đơn hợp lệ.");

            return hoaDonDAL.TimKiem(maHd);
        }

        // Thêm hóa đơn
        public void Them(HoaDon hoaDon)
        {
            if (hoaDon == null)
                throw new Exception("Dữ liệu hóa đơn không được để trống.");

            if (hoaDon.MaKh <= 0)
                throw new Exception("Vui lòng chọn khách hàng.");

            if (hoaDon.MaNv <= 0)
                throw new Exception("Vui lòng chọn nhân viên.");

            if (hoaDon.NgayLap > DateTime.Now)
                throw new Exception("Ngày lập hóa đơn không được ở tương lai.");

            if (hoaDon.TongTien < 0)
                throw new Exception("Tổng tiền không được âm.");

            if (string.IsNullOrWhiteSpace(hoaDon.TrangThai))
                throw new Exception("Vui lòng chọn trạng thái hóa đơn.");

            hoaDon.TrangThai = hoaDon.TrangThai.Trim();

            hoaDon.PhuongThucTt =
                string.IsNullOrWhiteSpace(hoaDon.PhuongThucTt)
                    ? null
                    : hoaDon.PhuongThucTt.Trim();

            hoaDon.GhiChu =
                string.IsNullOrWhiteSpace(hoaDon.GhiChu)
                    ? null
                    : hoaDon.GhiChu.Trim();

            hoaDonDAL.Them(hoaDon);
        }

        // Cập nhật hóa đơn
        public void Sua(HoaDon hoaDon)
        {
            if (hoaDon == null)
                throw new Exception("Dữ liệu hóa đơn không được để trống.");

            if (hoaDon.MaHd <= 0)
                throw new Exception("Mã hóa đơn không hợp lệ.");

            if (hoaDon.MaKh <= 0)
                throw new Exception("Vui lòng chọn khách hàng.");

            if (hoaDon.MaNv <= 0)
                throw new Exception("Vui lòng chọn nhân viên.");

            if (hoaDon.NgayLap > DateTime.Now)
                throw new Exception("Ngày lập hóa đơn không được ở tương lai.");

            if (hoaDon.TongTien < 0)
                throw new Exception("Tổng tiền không được âm.");

            if (string.IsNullOrWhiteSpace(hoaDon.TrangThai))
                throw new Exception("Vui lòng chọn trạng thái hóa đơn.");

            hoaDon.TrangThai = hoaDon.TrangThai.Trim();

            hoaDon.PhuongThucTt =
                string.IsNullOrWhiteSpace(hoaDon.PhuongThucTt)
                    ? null
                    : hoaDon.PhuongThucTt.Trim();

            hoaDon.GhiChu =
                string.IsNullOrWhiteSpace(hoaDon.GhiChu)
                    ? null
                    : hoaDon.GhiChu.Trim();

            hoaDonDAL.Sua(hoaDon);
        }

        // Xóa hóa đơn
        public void Xoa(int maHd)
        {
            if (maHd <= 0)
                throw new Exception("Mã hóa đơn không hợp lệ.");

            hoaDonDAL.Xoa(maHd);
        }
    }
}