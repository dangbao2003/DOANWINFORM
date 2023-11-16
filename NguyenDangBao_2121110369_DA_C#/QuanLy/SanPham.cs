namespace QuanLy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(10)]
        public string id_sp { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        [StringLength(30)]
        public string loai { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaynhap { get; set; }

        public int? soluong { get; set; }

        [StringLength(12)]
        public string dongia { get; set; }

        [StringLength(10)]
        public string trongluong { get; set; }

        [StringLength(50)]
        public string hangsx { get; set; }

        [StringLength(20)]
        public string tinhtrang { get; set; }

        public byte[] hinhanh { get; set; }
    }
}
