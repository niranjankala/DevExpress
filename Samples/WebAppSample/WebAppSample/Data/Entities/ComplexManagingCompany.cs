namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComplexManagingCompany")]
    public partial class ComplexManagingCompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ComplexManagingCompany()
        {
            PropertyMgrs = new HashSet<PropertyMgr>();
        }

        [Key]
        [StringLength(35)]
        public string ManagingCompany { get; set; }

        public bool Inactive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyMgr> PropertyMgrs { get; set; }
    }
}
