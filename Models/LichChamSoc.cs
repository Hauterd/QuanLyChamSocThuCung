using System;
using System.Collections.Generic;

namespace QuanLyChamSocThuCung.Models;

public partial class LichChamSoc
{
    public int MaLich { get; set; }

    public int MaPet { get; set; }

    public int MaNv { get; set; }

    public DateOnly NgayHen { get; set; }

    public TimeOnly GioHen { get; set; }

    public string TrangThai { get; set; } = null!;

    public string? GhiChu { get; set; }

    public virtual ICollection<ChiTietLichChamSoc> ChiTietLichChamSocs { get; set; } = new List<ChiTietLichChamSoc>();

    public virtual NhanVien MaNvNavigation { get; set; } = null!;

    public virtual ThuCung MaPetNavigation { get; set; } = null!;
}
