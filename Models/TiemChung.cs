using System;
using System.Collections.Generic;

namespace QuanLyChamSocThuCung.Models;

public partial class TiemChung
{
    public int MaTiem { get; set; }

    public int MaPet { get; set; }

    public string TenVacXin { get; set; } = null!;

    public int MuiTiem { get; set; }

    public DateOnly NgayTiem { get; set; }

    public DateOnly? NgayNhac { get; set; }

    public string? NoiTiem { get; set; }

    public string? GhiChu { get; set; }

    public virtual ThuCung MaPetNavigation { get; set; } = null!;
}
