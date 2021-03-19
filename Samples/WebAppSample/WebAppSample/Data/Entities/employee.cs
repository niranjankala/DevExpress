namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employee")]
    public partial class employee
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string EMPNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool PERSON { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool ONPAYROLL { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool ACTIVE { get; set; }

        [StringLength(22)]
        public string SSNUMBER { get; set; }

        [StringLength(4)]
        public string WORKTYPE { get; set; }

        [StringLength(32)]
        public string LASTNAME { get; set; }

        [StringLength(28)]
        public string FIRSTNAME { get; set; }

        public DateTime? BD { get; set; }

        [StringLength(72)]
        public string ADDRESS1 { get; set; }

        [StringLength(72)]
        public string ADDRESS2 { get; set; }

        [StringLength(60)]
        public string CITY { get; set; }

        [StringLength(4)]
        public string STATE { get; set; }

        [StringLength(20)]
        public string ZIPCODE { get; set; }

        [StringLength(100)]
        public string HOMEPHONE { get; set; }

        [StringLength(100)]
        public string BUSPHONE { get; set; }

        [StringLength(100)]
        public string FAXPHONE { get; set; }

        [StringLength(100)]
        public string OTHERPHONE { get; set; }

        [StringLength(100)]
        public string OTHPHTYPE1 { get; set; }

        [StringLength(100)]
        public string OTHPHTYPE2 { get; set; }

        [StringLength(100)]
        public string OTHPHTYPE3 { get; set; }

        [StringLength(100)]
        public string OTHPHTYPE4 { get; set; }

        public string COMMENT { get; set; }

        public short? IncludeWorkDetails { get; set; }

        public short? IncludeMileage { get; set; }

        [StringLength(28)]
        public string MIDDLENAME { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool ALLOWLOGIN { get; set; }

        [StringLength(400)]
        public string LOGIN_NAME { get; set; }

        [StringLength(10)]
        public string USERINITIALS { get; set; }

        public DateTime? hr_date { get; set; }

        public short? employee_type { get; set; }

        public DateTime? RECORDDATE { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        [StringLength(100)]
        public string UPDATEBY { get; set; }

        public int? EMPLOYEEFACTOR { get; set; }
    }
}
