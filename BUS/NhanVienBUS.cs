using System.Collections.Generic;
using QuanLyChamSocThuCung.DAL;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.BUS
{
    public class NhanVienBUS
    {
        private readonly NhanVienDAL _nhanVienDAL;

        public NhanVienBUS()
        {
            _nhanVienDAL = new NhanVienDAL();
        }

        public List<NhanVien> GetAll()
        {
            return _nhanVienDAL.GetAll();
        }

        public void Them(NhanVien nhanVien)
        {
            _nhanVienDAL.Them(nhanVien);
        }

        public void Sua(NhanVien nhanVien)
        {
            _nhanVienDAL.Sua(nhanVien);
        }

        public void Xoa(int maNv)
        {
            _nhanVienDAL.Xoa(maNv);
        }
    }
}