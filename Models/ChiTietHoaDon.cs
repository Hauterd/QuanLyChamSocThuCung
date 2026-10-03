using System;
using System.Collections.Generic;

namespace QuanLyChamSocThuCung.Models;

public partial class ChiTietHoaDon
{
    public int MaHd { get; set; }

    public int MaDv { get; set; }

    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public decimal? ThanhTien { get; set; }

    public virtual DichVu MaDvNavigation { get; set; } = null!;

    public virtual HoaDon MaHdNavigation { get; set; } = null!;
}
