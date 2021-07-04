namespace WindowsFormsApp3.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangHoa")]
    public partial class HangHoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangHoa()
        {
            ChiTietHDs = new HashSet<ChiTietHD>();
            ChiTietPNs = new HashSet<ChiTietPN>();
        }

        [Key]
        [StringLength(50)]
        public string MaHang { get; set; }

        [StringLength(50)]
        public string TenHang { get; set; }

        [Required]
        [StringLength(10)]
        public string DonVi { get; set; }

        public long? GiaBan { get; set; }

        public int? SoLuong { get; set; }

        public long? GiaGoc { get; set; }

        [Column(TypeName = "image")]
        public byte[] Anh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPN> ChiTietPNs { get; set; }
    }
}
