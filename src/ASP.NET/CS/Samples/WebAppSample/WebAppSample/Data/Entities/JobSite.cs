namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobSite")]
    public partial class JobSite
    {
        [Key]
        [StringLength(40)]
        public string JobSiteNo { get; set; }

        [StringLength(5)]
        public string Code { get; set; }

        public bool WorkOrderRequired { get; set; }

        public double? NotToExceed { get; set; }

        [StringLength(60)]
        public string LastName { get; set; }

        [StringLength(60)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string Address1 { get; set; }

        [StringLength(100)]
        public string Address2 { get; set; }

        [StringLength(60)]
        public string City { get; set; }

        [StringLength(4)]
        public string State { get; set; }

        [StringLength(20)]
        public string ZipCode { get; set; }

        [StringLength(100)]
        public string HomePhone { get; set; }

        [StringLength(100)]
        public string BusPhone { get; set; }

        [StringLength(100)]
        public string FaxPhone { get; set; }

        [StringLength(100)]
        public string OtherPhone { get; set; }

        public string Comment { get; set; }

        public int? BillOfficeCode { get; set; }

        [StringLength(100)]
        public string OthPhType1 { get; set; }

        [StringLength(100)]
        public string OthPhType2 { get; set; }

        [StringLength(100)]
        public string OthPhType3 { get; set; }

        [StringLength(100)]
        public string OthPhType4 { get; set; }

        public DateTime? recorddate { get; set; }

        public DateTime? updatedate { get; set; }

        [StringLength(100)]
        public string updateby { get; set; }

        [StringLength(60)]
        public string TenantLastName { get; set; }

        [StringLength(60)]
        public string TenantFirstName { get; set; }

        [StringLength(100)]
        public string TenantHomePhone { get; set; }

        [StringLength(100)]
        public string TenantMobilePhone { get; set; }

        [StringLength(100)]
        public string TenantWorkPhone { get; set; }
    }
}
