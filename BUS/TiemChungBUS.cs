using System.Collections.Generic;
using QuanLyChamSocThuCung.DAL;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.BUS
{
    public class TiemChungBUS
    {
        private readonly TiemChungDAL _tiemChungDAL;

        public TiemChungBUS()
        {
            _tiemChungDAL = new TiemChungDAL();
        }

        public List<TiemChung> GetAll()
        {
            return _tiemChungDAL.GetAll();
        }

        public void Them(TiemChung tiemChung)
        {
            _tiemChungDAL.Them(tiemChung);
        }

        public void Sua(TiemChung tiemChung)
        {
            _tiemChungDAL.Sua(tiemChung);
        }

        public void Xoa(int maTiem)
        {
            _tiemChungDAL.Xoa(maTiem);
        }
    }
}