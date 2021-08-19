namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MATERIAL")]
    public partial class MATERIAL
    {
        public int ID { get; set; }

        [StringLength(6)]
        public string WorkOrder { get; set; }

        public DateTime? DATE { get; set; }

        public string ITEM { get; set; }

        public double? TOTAL { get; set; }

        [StringLength(64)]
        public string RECEIPTNO { get; set; }

        public bool PictureTaken { get; set; }

        [StringLength(120)]
        public string VENDOR { get; set; }

        public bool Cleanup { get; set; }

        public string COMMENT { get; set; }

        [StringLength(48)]
        public string EMPNUM { get; set; }

        public DateTime? recorddate { get; set; }

        public DateTime? updatedate { get; set; }

        [StringLength(200)]
        public string updateby { get; set; }
    }
}
