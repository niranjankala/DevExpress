namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Complex")]
    public partial class Complex
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Complex()
        {
            PropertyMgrComplexes = new HashSet<PropertyMgrComplex>();
        }

        [Key]
        [StringLength(5)]
        public string Code { get; set; }

        [Column("Complex")]
        [StringLength(120)]
        public string Complex1 { get; set; }

        [StringLength(120)]
        public string City { get; set; }

        [StringLength(8)]
        public string State { get; set; }

        [StringLength(40)]
        public string ZipCode { get; set; }

        public string Location { get; set; }

        public int? BillOfficeCode { get; set; }

        [StringLength(80)]
        public string ReferenceCode { get; set; }

        public bool WorkOrderRequired { get; set; }

        public double? NotToExceed { get; set; }

        public bool SplitterPageRequired { get; set; }

        [StringLength(200)]
        public string SplitterPageLocation { get; set; }

        public string Comment { get; set; }

        [StringLength(1)]
        public string Inactive { get; set; }

        public DateTime? recorddate { get; set; }

        public DateTime? updatedate { get; set; }

        [StringLength(200)]
        public string updateby { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyMgrComplex> PropertyMgrComplexes { get; set; }
    }
}
