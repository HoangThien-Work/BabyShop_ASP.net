namespace PTWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [StringLength(50)]
        public string kh_id { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        [StringLength(50)]
        public string mk { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public DateTime? ngaysinh { get; set; }

        [StringLength(10)]
        public string sdt { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(10)]
        public string quyen { get; set; }

        public int? trangthai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
