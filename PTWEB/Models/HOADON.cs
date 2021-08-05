namespace PTWEB.Models
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
            SP_HD = new HashSet<SP_HD>();
        }

        [Key]
        [StringLength(50)]
        public string mahd { get; set; }

        public DateTime? ngaytao { get; set; }

        [StringLength(50)]
        public string kh_id { get; set; }

        public int? tongtien { get; set; }

        public int? trangthai { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SP_HD> SP_HD { get; set; }
    }
}
