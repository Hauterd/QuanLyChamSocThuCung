using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QuanLyChamSocThuCung.Models;

public partial class QuanLyChamSocThuCungContext : DbContext
{
    public QuanLyChamSocThuCungContext()
    {
    }

    public QuanLyChamSocThuCungContext(DbContextOptions<QuanLyChamSocThuCungContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

    public virtual DbSet<ChiTietLichChamSoc> ChiTietLichChamSocs { get; set; }

    public virtual DbSet<DichVu> DichVus { get; set; }

    public virtual DbSet<HoSoSucKhoe> HoSoSucKhoes { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LichChamSoc> LichChamSocs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<ThuCung> ThuCungs { get; set; }

    public virtual DbSet<TiemChung> TiemChungs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=QuanLyChamSocThuCung;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietHoaDon>(entity =>
        {
            entity.HasKey(e => new { e.MaHd, e.MaDv });

            entity.ToTable("ChiTietHoaDon");

            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.MaDv).HasColumnName("MaDV");
            entity.Property(e => e.DonGia).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.SoLuong).HasDefaultValue(1);
            entity.Property(e => e.ThanhTien)
                .HasComputedColumnSql("([SoLuong]*[DonGia])", true)
                .HasColumnType("decimal(23, 2)");

            entity.HasOne(d => d.MaDvNavigation).WithMany(p => p.ChiTietHoaDons)
                .HasForeignKey(d => d.MaDv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietHoaDon_DichVu");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.ChiTietHoaDons)
                .HasForeignKey(d => d.MaHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietHoaDon_HoaDon");
        });

        modelBuilder.Entity<ChiTietLichChamSoc>(entity =>
        {
            entity.HasKey(e => new { e.MaLich, e.MaDv });

            entity.ToTable("ChiTietLichChamSoc");

            entity.Property(e => e.MaDv).HasColumnName("MaDV");
            entity.Property(e => e.DonGia).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.SoLuong).HasDefaultValue(1);
            entity.Property(e => e.ThanhTien)
                .HasComputedColumnSql("([SoLuong]*[DonGia])", true)
                .HasColumnType("decimal(23, 2)");

            entity.HasOne(d => d.MaDvNavigation).WithMany(p => p.ChiTietLichChamSocs)
                .HasForeignKey(d => d.MaDv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietLichChamSoc_DichVu");

            entity.HasOne(d => d.MaLichNavigation).WithMany(p => p.ChiTietLichChamSocs)
                .HasForeignKey(d => d.MaLich)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietLichChamSoc_LichChamSoc");
        });

        modelBuilder.Entity<DichVu>(entity =>
        {
            entity.HasKey(e => e.MaDv).HasName("PK__DichVu__27258657DB6069C0");

            entity.ToTable("DichVu");

            entity.Property(e => e.MaDv).HasColumnName("MaDV");
            entity.Property(e => e.DonGia).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.LoaiDv)
                .HasMaxLength(50)
                .HasColumnName("LoaiDV");
            entity.Property(e => e.MoTa).HasMaxLength(300);
            entity.Property(e => e.TenDv)
                .HasMaxLength(100)
                .HasColumnName("TenDV");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<HoSoSucKhoe>(entity =>
        {
            entity.HasKey(e => e.MaHoSo).HasName("PK__HoSoSucK__1666423C23A226F6");

            entity.ToTable("HoSoSucKhoe");

            entity.Property(e => e.CanNang).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DiUng).HasMaxLength(300);
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.NgayCapNhat).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.TienSuBenh).HasMaxLength(300);
            entity.Property(e => e.TinhTrangSucKhoe).HasMaxLength(200);

            entity.HasOne(d => d.MaPetNavigation).WithMany(p => p.HoSoSucKhoes)
                .HasForeignKey(d => d.MaPet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HoSoSucKhoe_ThuCung");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E006187E2B");

            entity.ToTable("HoaDon");

            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.NgayLap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PhuongThucTt)
                .HasMaxLength(30)
                .HasColumnName("PhuongThucTT");
            entity.Property(e => e.TongTien).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(30)
                .HasDefaultValue("Chưa thanh toán");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HoaDon_KhachHang");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HoaDon_NhanVien");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1EB658345F");

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.NgayDangKy).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
        });

        modelBuilder.Entity<LichChamSoc>(entity =>
        {
            entity.HasKey(e => e.MaLich).HasName("PK__LichCham__728A9AE98CB658DF");

            entity.ToTable("LichChamSoc");

            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(30)
                .HasDefaultValue("Đã đặt");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.LichChamSocs)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LichChamSoc_NhanVien");

            entity.HasOne(d => d.MaPetNavigation).WithMany(p => p.LichChamSocs)
                .HasForeignKey(d => d.MaPet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LichChamSoc_ThuCung");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D70AF01A146E");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.ChucVu).HasMaxLength(50);
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaTk).HasName("PK__TaiKhoan__27250070CDC9D4DA");

            entity.ToTable("TaiKhoan");

            entity.HasIndex(e => e.MaNv, "UQ__TaiKhoan__2725D70B9D9F0898").IsUnique();

            entity.HasIndex(e => e.TenDangNhap, "UQ__TaiKhoan__55F68FC01F7FE4FC").IsUnique();

            entity.Property(e => e.MaTk).HasColumnName("MaTK");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Quyen)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);

            entity.HasOne(d => d.MaNvNavigation).WithOne(p => p.TaiKhoan)
                .HasForeignKey<TaiKhoan>(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaiKhoan_NhanVien");
        });

        modelBuilder.Entity<ThuCung>(entity =>
        {
            entity.HasKey(e => e.MaPet).HasName("PK__ThuCung__3AE144E25CC0B3FD");

            entity.ToTable("ThuCung");

            entity.Property(e => e.CanNang).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.Giong).HasMaxLength(50);
            entity.Property(e => e.Loai).HasMaxLength(30);
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.MauLong).HasMaxLength(30);
            entity.Property(e => e.TenPet).HasMaxLength(50);

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.ThuCungs)
                .HasForeignKey(d => d.MaKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ThuCung_KhachHang");
        });

        modelBuilder.Entity<TiemChung>(entity =>
        {
            entity.HasKey(e => e.MaTiem).HasName("PK__TiemChun__4CC209DCF0D22B54");

            entity.ToTable("TiemChung");

            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.NoiTiem).HasMaxLength(200);
            entity.Property(e => e.TenVacXin).HasMaxLength(100);

            entity.HasOne(d => d.MaPetNavigation).WithMany(p => p.TiemChungs)
                .HasForeignKey(d => d.MaPet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TiemChung_ThuCung");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
