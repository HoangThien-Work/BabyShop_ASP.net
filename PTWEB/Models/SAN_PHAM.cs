namespace PTWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAN_PHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAN_PHAM()
        {
            SP_HD = new HashSet<SP_HD>();
        }

        [Key]
        [StringLength(50)]
        public string masp { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        public int? gia { get; set; }

        public int? soluong { get; set; }

        [StringLength(100)]
        public string mota { get; set; }

        [StringLength(50)]
        public string anh { get; set; }

        [StringLength(50)]
        public string maloai { get; set; }

        public virtual LOAI_SP LOAI_SP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SP_HD> SP_HD { get; set; }
    }
}
