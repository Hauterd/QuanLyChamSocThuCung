using System;
using System.Collections.Generic;

namespace QuanLyChamSocThuCung.Models;

public partial class HoSoSucKhoe
{
    public int MaHoSo { get; set; }

    public int MaPet { get; set; }

    public decimal? CanNang { get; set; }

    public string? TinhTrangSucKhoe { get; set; }

    public string? TienSuBenh { get; set; }

    public string? DiUng { get; set; }

    public DateOnly NgayCapNhat { get; set; }

    public string? GhiChu { get; set; }

    public virtual ThuCung MaPetNavigation { get; set; } = null!;
}
