namespace DA1_QLQuanNET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHOADON")]
    public partial class CTHOADON
    {
        [Key]
        [StringLength(10)]
        public string MaCTHD { get; set; }

        [StringLength(8)]
        public string MaHD { get; set; }

        [StringLength(8)]
        public string MaDV { get; set; }

        public int? DonGia { get; set; }

        public double? SoLuong { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
