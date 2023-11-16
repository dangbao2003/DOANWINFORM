namespace QuanLy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoiVien")]
    public partial class HoiVien
    {
        [Key]
        [StringLength(10)]
        public string id_hv { get; set; }

        [StringLength(50)]
        public string hoten { get; set; }

        [StringLength(3)]
        public string gioitinh { get; set; }

        [StringLength(12)]
        public string sdt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayhethan { get; set; }

        [StringLength(50)]
        public string goitap { get; set; }

        public byte[] hinhanh { get; set; }
    }
}
