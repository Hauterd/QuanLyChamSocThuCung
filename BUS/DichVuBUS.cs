
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyChamSocThuCung.DAL;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.BUS
{
    public class DichVuBUS
    {
        private readonly DichVuDAL _dichVuDAL;

        public DichVuBUS()
        {
            _dichVuDAL = new DichVuDAL();
        }

        // Lấy danh sách dịch vụ
        public List<DichVu> GetAll()
        {
            return _dichVuDAL.GetAll();
        }

        // Thêm dịch vụ
        public void Them(DichVu dichVu)
        {
            KiemTraDuLieu(dichVu);
            _dichVuDAL.Them(dichVu);
        }

        // Sửa dịch vụ
        public void Sua(DichVu dichVu)
        {
            if (dichVu.MaDv <= 0)
                throw new Exception("Mã dịch vụ không hợp lệ.");

            KiemTraDuLieu(dichVu);
            _dichVuDAL.Sua(dichVu);
        }

        // Xóa dịch vụ
        public void Xoa(int maDv)
        {
            if (maDv <= 0)
                throw new Exception("Vui lòng chọn dịch vụ cần xóa.");

            _dichVuDAL.Xoa(maDv);
        }

        // Kiểm tra dữ liệu đầu vào
        private void KiemTraDuLieu(DichVu dichVu)
        {
            if (dichVu == null)
                throw new Exception("Dữ liệu dịch vụ không hợp lệ.");

            if (string.IsNullOrWhiteSpace(dichVu.TenDv))
                throw new Exception("Vui lòng nhập tên dịch vụ.");

            if (string.IsNullOrWhiteSpace(dichVu.LoaiDv))
                throw new Exception("Vui lòng chọn loại dịch vụ.");

            if (dichVu.DonGia < 0)
                throw new Exception("Đơn giá không được âm.");

            if (dichVu.ThoiGianDuKien.HasValue &&
                dichVu.ThoiGianDuKien.Value < 0)
                throw new Exception("Thời gian dự kiến không được âm.");
        }
    }
}
