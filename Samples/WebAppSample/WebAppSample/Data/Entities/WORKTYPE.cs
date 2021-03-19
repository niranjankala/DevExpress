namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WORKTYPE")]
    public partial class WORKTYPE
    {
        [Key]
        [StringLength(2)]
        public string ABREVIATE { get; set; }

        [Column("WORKTYPE")]
        [StringLength(40)]
        public string WORKTYPE1 { get; set; }

        public bool IsActive { get; set; }

        public DateTime? RecordDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(200)]
        public string UpdateBy { get; set; }
    }
}
