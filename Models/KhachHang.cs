using System;
using System.Collections.Generic;

namespace QuanLyChamSocThuCung.Models;

public partial class KhachHang
{
    public int MaKh { get; set; }

    public string HoTen { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public string? Email { get; set; }

    public string? DiaChi { get; set; }

    public DateOnly NgayDangKy { get; set; }

    public string? GhiChu { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ICollection<ThuCung> ThuCungs { get; set; } = new List<ThuCung>();
}
