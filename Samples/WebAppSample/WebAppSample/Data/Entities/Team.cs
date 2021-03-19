namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Team")]
    public partial class Team
    {
        public int TeamId { get; set; }

        [Required]
        [StringLength(6)]
        public string WorkOrder { get; set; }

        public DateTime? DateLogged { get; set; }

        [StringLength(12)]
        public string EmpNum { get; set; }

        public DateTime? recorddate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(100)]
        public string Updateby { get; set; }
    }
}
