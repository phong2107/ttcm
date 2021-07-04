using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp3.database
{
	public partial class QLKS : DbContext
	{
		public QLKS()
			: base("name=QLKS")
		{
		}

		public virtual DbSet<ChiTietHD> ChiTietHDs { get; set; }
		public virtual DbSet<ChiTietPN> ChiTietPNs { get; set; }
		public virtual DbSet<HangHoa> HangHoas { get; set; }
		public virtual DbSet<HoaDon> HoaDons { get; set; }
		public virtual DbSet<KhachHang> KhachHangs { get; set; }
		public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
		public virtual DbSet<NhanVien> NhanViens { get; set; }
		public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ChiTietPN>()
				.Property(e => e.MaPN)
				.IsFixedLength();

			modelBuilder.Entity<HangHoa>()
				.Property(e => e.DonVi)
				.IsUnicode(false);

			modelBuilder.Entity<HangHoa>()
				.HasMany(e => e.ChiTietHDs)
				.WithRequired(e => e.HangHoa)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<HangHoa>()
				.HasMany(e => e.ChiTietPNs)
				.WithRequired(e => e.HangHoa)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<HoaDon>()
				.Property(e => e.MaKH)
				.IsFixedLength();

			modelBuilder.Entity<HoaDon>()
				.Property(e => e.TenDangNhap)
				.IsUnicode(false);

			modelBuilder.Entity<HoaDon>()
				.HasMany(e => e.ChiTietHDs)
				.WithRequired(e => e.HoaDon)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<KhachHang>()
				.Property(e => e.MaKH)
				.IsUnicode(false);

			modelBuilder.Entity<KhachHang>()
				.Property(e => e.SDT)
				.IsUnicode(false);

			modelBuilder.Entity<KhachHang>()
				.Property(e => e.MatKhau)
				.IsUnicode(false);

			modelBuilder.Entity<KhachHang>()
				.Property(e => e.MaHang)
				.IsUnicode(false);

			modelBuilder.Entity<NhaCungCap>()
				.Property(e => e.MaNCC)
				.IsFixedLength();

			modelBuilder.Entity<NhaCungCap>()
				.HasMany(e => e.PhieuNhaps)
				.WithRequired(e => e.NhaCungCap)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<NhanVien>()
				.Property(e => e.TenDangNhap)
				.IsUnicode(false);

			modelBuilder.Entity<NhanVien>()
				.Property(e => e.MatKhau)
				.IsUnicode(false);

			modelBuilder.Entity<NhanVien>()
				.HasMany(e => e.HoaDons)
				.WithRequired(e => e.NhanVien)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<PhieuNhap>()
				.Property(e => e.MaPN)
				.IsFixedLength();

			modelBuilder.Entity<PhieuNhap>()
				.Property(e => e.MaNCC)
				.IsFixedLength();

			modelBuilder.Entity<PhieuNhap>()
				.Property(e => e.TenDangNhap)
				.IsUnicode(false);
		}
	}
}
