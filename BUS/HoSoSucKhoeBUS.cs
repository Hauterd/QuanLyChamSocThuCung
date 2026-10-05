using System.Collections.Generic;
using QuanLyChamSocThuCung.DAL;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.BUS
{
    public class HoSoSucKhoeBUS
    {
        private readonly HoSoSucKhoeDAL _hoSoSucKhoeDAL;

        public HoSoSucKhoeBUS()
        {
            _hoSoSucKhoeDAL = new HoSoSucKhoeDAL();
        }

        public List<HoSoSucKhoe> GetAll()
        {
            return _hoSoSucKhoeDAL.GetAll();
        }

        public void Them(HoSoSucKhoe hoSo)
        {
            _hoSoSucKhoeDAL.Them(hoSo);
        }

        public void Sua(HoSoSucKhoe hoSo)
        {
            _hoSoSucKhoeDAL.Sua(hoSo);
        }

        public void Xoa(int maHoSo)
        {
            _hoSoSucKhoeDAL.Xoa(maHoSo);;
        }
    }
}
