namespace DA1_QLQuanNET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            CTHOADONs = new HashSet<CTHOADON>();
        }

        [Key]
        [StringLength(8)]
        public string MaHD { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(6)]
        public string MaMay { get; set; }

        public DateTime? TGBatDau { get; set; }

        public DateTime? TGKetThuc { get; set; }

        public int? TongTien { get; set; }

        [StringLength(20)]
        public string TrangThaiHD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOADON> CTHOADONs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
