namespace QuanLy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVien")]
    public partial class ThanhVien
    {
        [Key]
        public int MaTV { get; set; }

        [Required]
        [StringLength(200)]
        public string TenDN { get; set; }

        [Required]
        [StringLength(200)]
        public string MatKhau { get; set; }
    }
}
