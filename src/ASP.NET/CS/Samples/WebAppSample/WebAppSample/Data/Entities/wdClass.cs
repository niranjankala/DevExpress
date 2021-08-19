namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("wdClass")]
    public partial class wdClass
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkClassID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string WorkClassDescription { get; set; }

        public int? SeqNo { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsActive { get; set; }

        public DateTime? RecordDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(100)]
        public string Updateby { get; set; }
    }
}
