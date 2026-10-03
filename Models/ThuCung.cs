using System;
using System.Collections.Generic;

namespace QuanLyChamSocThuCung.Models;

public partial class ThuCung
{
    public int MaPet { get; set; }

    public int MaKh { get; set; }

    public string TenPet { get; set; } = null!;

    public string Loai { get; set; } = null!;

    public string? Giong { get; set; }

    public string? GioiTinh { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public decimal? CanNang { get; set; }

    public string? MauLong { get; set; }

    public string? GhiChu { get; set; }

    public virtual ICollection<HoSoSucKhoe> HoSoSucKhoes { get; set; } = new List<HoSoSucKhoe>();

    public virtual ICollection<LichChamSoc> LichChamSocs { get; set; } = new List<LichChamSoc>();

    public virtual KhachHang MaKhNavigation { get; set; } = null!;

    public virtual ICollection<TiemChung> TiemChungs { get; set; } = new List<TiemChung>();
}
