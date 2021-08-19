namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PropertyMgrComplex")]
    public partial class PropertyMgrComplex
    {
        [Key]
        [Column(Order = 0)]
        public int MGRPropID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ManagerID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string ComplexCode { get; set; }

        public DateTime? recorddate { get; set; }

        public DateTime? updatedate { get; set; }

        [StringLength(200)]
        public string updateby { get; set; }

        public virtual Complex Complex { get; set; }

        public virtual PropertyMgr PropertyMgr { get; set; }
    }
}
