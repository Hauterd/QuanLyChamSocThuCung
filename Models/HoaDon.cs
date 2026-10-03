using System;
using System.Collections.Generic;

namespace QuanLyChamSocThuCung.Models;

public partial class HoaDon
{
    public int MaHd { get; set; }

    public int MaKh { get; set; }

    public int MaNv { get; set; }

    public DateTime NgayLap { get; set; }

    public decimal TongTien { get; set; }

    public string? PhuongThucTt { get; set; }

    public string TrangThai { get; set; } = null!;

    public string? GhiChu { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual KhachHang MaKhNavigation { get; set; } = null!;

    public virtual NhanVien MaNvNavigation { get; set; } = null!;
}
