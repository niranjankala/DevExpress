namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PropertyMgr")]
    public partial class PropertyMgr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PropertyMgr()
        {
            PropertyMgrComplexes = new HashSet<PropertyMgrComplex>();
        }

        [Key]
        public int ManagerID { get; set; }

        [StringLength(200)]
        public string UserTitle { get; set; }

        [StringLength(80)]
        public string LastName { get; set; }

        [StringLength(80)]
        public string FirstName { get; set; }

        [StringLength(400)]
        public string EmailAddress { get; set; }

        public bool? Inactive { get; set; }

        [StringLength(80)]
        public string PrimPhone { get; set; }

        [StringLength(80)]
        public string AltPhone { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RelStart { get; set; }

        public string Comment { get; set; }

        public DateTime? recorddate { get; set; }

        public DateTime? updatedate { get; set; }

        [StringLength(200)]
        public string updateby { get; set; }

        public DateTime Bday { get; set; }

        public bool Xmas { get; set; }

        public bool EmailInvoice { get; set; }

        [StringLength(35)]
        public string ManagingComp { get; set; }

        public virtual ComplexManagingCompany ComplexManagingCompany { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyMgrComplex> PropertyMgrComplexes { get; set; }
    }
}
