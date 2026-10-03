using System;
using System.Collections.Generic;

namespace QuanLyChamSocThuCung.Models;

public partial class ChiTietLichChamSoc
{
    public int MaLich { get; set; }

    public int MaDv { get; set; }

    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public decimal? ThanhTien { get; set; }

    public virtual DichVu MaDvNavigation { get; set; } = null!;

    public virtual LichChamSoc MaLichNavigation { get; set; } = null!;
}
