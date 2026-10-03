using System;
using System.Collections.Generic;

namespace QuanLyChamSocThuCung.Models;

public partial class TaiKhoan
{
    public int MaTk { get; set; }

    public string TenDangNhap { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public int MaNv { get; set; }

    public string Quyen { get; set; } = null!;

    public bool TrangThai { get; set; }

    public virtual NhanVien MaNvNavigation { get; set; } = null!;
}
