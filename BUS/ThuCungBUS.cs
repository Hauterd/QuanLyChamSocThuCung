using System.Collections.Generic;
using QuanLyChamSocThuCung.DAL;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.BUS
{
    public class ThuCungBUS
    {
        private readonly ThuCungDAL _thuCungDAL;

        public ThuCungBUS()
        {
            _thuCungDAL = new ThuCungDAL();
        }

        // Lấy danh sách thú cưng
        public List<ThuCung> GetAll()
        {
            return _thuCungDAL.GetAll();
        }

        // Thêm thú cưng
        public void Them(ThuCung thuCung)
        {
            _thuCungDAL.Them(thuCung);
        }

        // Sửa thú cưng
        public void Sua(ThuCung thuCung)
        {
            _thuCungDAL.Sua(thuCung);
        }

        // Xóa thú cưng
        public void Xoa(int maPet)
        {
            _thuCungDAL.Xoa(maPet);
        }

        // Tìm kiếm thú cưng
        public List<ThuCung> TimKiem(string tuKhoa)
        {
            return _thuCungDAL.TimKiem(tuKhoa);
        }
    }
}