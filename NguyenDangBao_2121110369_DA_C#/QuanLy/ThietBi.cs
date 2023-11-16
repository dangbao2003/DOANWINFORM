namespace QuanLy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThietBi")]
    public partial class ThietBi
    {
        [Key]
        [StringLength(10)]
        public string id_tb { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        [StringLength(10)]
        public string loai { get; set; }

        public int? soluong { get; set; }

        [StringLength(50)]
        public string hangsx { get; set; }

        [StringLength(20)]
        public string tinhtrang { get; set; }

        public int? soluonghu { get; set; }

        [StringLength(200)]
        public string ghichu { get; set; }

        public byte[] hinhanh { get; set; }
    }
}
