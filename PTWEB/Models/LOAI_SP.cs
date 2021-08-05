namespace PTWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOAI_SP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAI_SP()
        {
            SAN_PHAM = new HashSet<SAN_PHAM>();
        }

        [Key]
        [StringLength(50)]
        public string maloai { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAN_PHAM> SAN_PHAM { get; set; }
    }
}
