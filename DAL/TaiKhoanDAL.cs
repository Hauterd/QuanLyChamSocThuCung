using System.Linq;
using QuanLyChamSocThuCung.Models;

namespace QuanLyChamSocThuCung.DAL
{
    public class TaiKhoanDAL
    {
        public TaiKhoan? DangNhap(string tenDangNhap, string matKhau)
        {
            using (var db = new QuanLyChamSocThuCungContext())
            {
                return db.TaiKhoans
                    .FirstOrDefault(tk =>
                        tk.TenDangNhap == tenDangNhap &&
                        tk.MatKhau == matKhau &&
                        tk.TrangThai == true);
            }
        }
    }
}