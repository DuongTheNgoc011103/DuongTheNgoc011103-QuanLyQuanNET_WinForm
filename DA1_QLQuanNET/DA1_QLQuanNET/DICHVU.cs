namespace DA1_QLQuanNET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVU")]
    public partial class DICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            CTHOADONs = new HashSet<CTHOADON>();
        }

        [Key]
        [StringLength(8)]
        public string MaDV { get; set; }

        [StringLength(100)]
        public string TenDV { get; set; }

        [StringLength(50)]
        public string DVTinh { get; set; }

        public int? DonGia { get; set; }

        public double? SoLuong { get; set; }

        public string HinhAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOADON> CTHOADONs { get; set; }
    }
}
