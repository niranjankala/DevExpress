namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPLWORKLVL1
    {
        public long EMPLWORKLVL1id { get; set; }

        public int NodeID { get; set; }

        [Required]
        [StringLength(50)]
        public string LVL1DESCRIPTION { get; set; }

        public int ParentID { get; set; }

        public int? SeqNo { get; set; }

        public bool Active { get; set; }

        public DateTime? recorddate { get; set; }

        public DateTime? updatedate { get; set; }

        [StringLength(100)]
        public string updateby { get; set; }
    }
}
