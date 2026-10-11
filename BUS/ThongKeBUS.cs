using QuanLyChamSocThuCung.DAL;

namespace QuanLyChamSocThuCung.BUS
{
    public class ThongKeBUS
    {
        private readonly ThongKeDAL thongKeDAL = new ThongKeDAL();

        public int DemKhachHang()
        {
            return thongKeDAL.DemKhachHang();
        }

        public int DemThuCung()
        {
            return thongKeDAL.DemThuCung();
        }

        public int DemLichChamSoc()
        {
            return thongKeDAL.DemLichChamSoc();
        }

        public decimal TinhTongDoanhThu()
        {
            return thongKeDAL.TinhTongDoanhThu();
        }

        public int DemHoaDonChuaThanhToan()
        {
            return thongKeDAL.DemHoaDonChuaThanhToan();
        }

        public int DemHoaDonDaThanhToan()
        {
            return thongKeDAL.DemHoaDonDaThanhToan();
        }

        public int DemHoaDonDaHuy()
        {
            return thongKeDAL.DemHoaDonDaHuy();
        }
    }

}