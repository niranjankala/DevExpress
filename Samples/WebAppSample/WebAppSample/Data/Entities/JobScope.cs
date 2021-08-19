namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobScope")]
    public partial class JobScope
    {
        [Key]
        public int ScopeID { get; set; }

        [StringLength(6)]
        public string WorkOrder { get; set; }

        [StringLength(200)]
        public string Assignment { get; set; }

        [StringLength(80)]
        public string EmployeeCode { get; set; }

        public string ScopeDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ScopeDate { get; set; }

        public bool? PrintScope { get; set; }

        public bool? ScopeCompleted { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TargetCompDate { get; set; }

        public DateTime? ApptDate { get; set; }

        public DateTime? RECORDDATE { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        [StringLength(200)]
        public string UPDATEBY { get; set; }

        public int? SeqNo { get; set; }
    }
}
