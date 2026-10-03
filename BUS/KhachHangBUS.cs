using System.Collections.Generic;
using QuanLyChamSocThuCung.DAL;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.BUS
{
    public class KhachHangBUS
    {
        private readonly KhachHangDAL _khachHangDAL;

        public KhachHangBUS()
        {
            _khachHangDAL = new KhachHangDAL();
        }

        public List<KhachHang> GetAll()
        {
            return _khachHangDAL.GetAll();
        }
        public void Them(KhachHang khachHang)
        {
            _khachHangDAL.Them(khachHang);
        }

        public void Sua(KhachHang khachHang)
        {
            _khachHangDAL.Sua(khachHang);
        }

        public void Xoa(int maKH)
        {
            _khachHangDAL.Xoa(maKH);
        }

        public List<KhachHang> TimKiem(string tuKhoa)
        {
            return _khachHangDAL.TimKiem(tuKhoa);
        }
    }
}
