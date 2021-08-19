namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WORKORDR")]
    public partial class WORKORDR
    {
        [Key]
        [StringLength(6)]
        public string WORKORDER { get; set; }

        public DateTime? DATELOGGED { get; set; }

        [StringLength(52)]
        public string CALLINNAME { get; set; }

        public bool COMPLETE { get; set; }

        public DateTime COMPDATE { get; set; }

        [StringLength(40)]
        public string JOBSITENO { get; set; }

        [StringLength(52)]
        public string Tenant { get; set; }

        public short? BtCode { get; set; }

        public string WODESCRIP { get; set; }

        public string FOUNDWHAT { get; set; }

        public string COMMENT { get; set; }

        public bool InvNotReq { get; set; }

        public double? EstMat { get; set; }

        public double? EstEmp { get; set; }

        public double? EstOth { get; set; }

        [StringLength(100)]
        public string CUSTOMER { get; set; }

        public bool? noEmpCost { get; set; }

        public bool? noMatCost { get; set; }

        public bool? noOthCost { get; set; }

        [StringLength(100)]
        public string BusPhone { get; set; }

        [StringLength(100)]
        public string HomePhone { get; set; }

        [StringLength(100)]
        public string FaxPhone { get; set; }

        [StringLength(100)]
        public string OtherPhone { get; set; }

        [StringLength(100)]
        public string othPhoneType1 { get; set; }

        [StringLength(100)]
        public string othPhoneType2 { get; set; }

        [StringLength(100)]
        public string othPhoneType3 { get; set; }

        [StringLength(100)]
        public string othPhoneType4 { get; set; }

        [StringLength(60)]
        public string CUSTWORKORDER { get; set; }

        public bool WorkOrderRequired { get; set; }

        public bool? IsVoid { get; set; }

        public double? NotToExceed { get; set; }

        public DateTime? recorddate { get; set; }

        public DateTime? updatedate { get; set; }

        [StringLength(100)]
        public string updateby { get; set; }

        public bool FieldSubmitted { get; set; }

        public bool OfficeApproved { get; set; }

        public int? TeamAssigned { get; set; }

        public string FieldNotes { get; set; }

        public DateTime? FieldRecorddate { get; set; }

        public DateTime? FieldUpdatedate { get; set; }

        [StringLength(100)]
        public string FieldUpdateby { get; set; }

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
