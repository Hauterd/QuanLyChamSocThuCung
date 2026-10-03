using System;
using System.Collections.Generic;

namespace QuanLyChamSocThuCung.Models;

public partial class DichVu
{
    public int MaDv { get; set; }

    public string TenDv { get; set; } = null!;

    public string? LoaiDv { get; set; }

    public decimal DonGia { get; set; }

    public int? ThoiGianDuKien { get; set; }

    public string? MoTa { get; set; }

    public bool TrangThai { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual ICollection<ChiTietLichChamSoc> ChiTietLichChamSocs { get; set; } = new List<ChiTietLichChamSoc>();
}
