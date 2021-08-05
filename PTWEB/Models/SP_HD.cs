namespace PTWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SP_HD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string masp { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string mahd { get; set; }

        public int? soluong { get; set; }

        public int? gia { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual SAN_PHAM SAN_PHAM { get; set; }
    }
}
