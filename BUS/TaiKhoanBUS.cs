using QuanLyChamSocThuCung.DAL;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.BUS
{
    public class TaiKhoanBUS
    {
        private readonly TaiKhoanDAL _taiKhoanDAL;

        public TaiKhoanBUS()
        {
            _taiKhoanDAL = new TaiKhoanDAL();
        }

        public TaiKhoan? DangNhap(string tenDangNhap, string matKhau)
        {
            return _taiKhoanDAL.DangNhap(tenDangNhap, matKhau);
        }
    }
}