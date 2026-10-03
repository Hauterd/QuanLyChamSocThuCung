using System;
using System.Collections.Generic;

namespace QuanLyChamSocThuCung.Models;

public partial class NhanVien
{
    public int MaNv { get; set; }

    public string HoTen { get; set; } = null!;

    public string? GioiTinh { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public string? Sdt { get; set; }

    public string? DiaChi { get; set; }

    public string? ChucVu { get; set; }

    public bool TrangThai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ICollection<LichChamSoc> LichChamSocs { get; set; } = new List<LichChamSoc>();

    public virtual TaiKhoan? TaiKhoan { get; set; }
}
