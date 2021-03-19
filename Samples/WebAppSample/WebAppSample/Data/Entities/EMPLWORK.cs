namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPLWORK")]
    public partial class EMPLWORK
    {
        public int ID { get; set; }

        public DateTime? DATE { get; set; }

        public DateTime? DATEIN { get; set; }

        [StringLength(24)]
        public string WHOWORKED { get; set; }

        [StringLength(6)]
        public string WorkOrder { get; set; }

        public DateTime? WKTIME_IN { get; set; }

        public double? TIMEOFF { get; set; }

        public DateTime? WKTIME_OUT { get; set; }

        public double? TOTTIME { get; set; }

        public double? AMOUNT { get; set; }

        [StringLength(4)]
        public string WORKTYPE { get; set; }

        public string DIDWHAT { get; set; }

        public DateTime? OWKTIME_IN { get; set; }

        public DateTime? OWKTIME_OUT { get; set; }

        public double? OTIMEOFF { get; set; }

        public double? OTOTTIME { get; set; }

        [StringLength(20)]
        public string RWorkClass { get; set; }

        [StringLength(20)]
        public string OWorkClass { get; set; }

        public bool? DOUBLETIME { get; set; }

        public DateTime? PAYWEEK_DATE { get; set; }

        public double? emp_rate { get; set; }

        public double? oamount { get; set; }

        public double? ramount { get; set; }

        public int? EmployeeFactor { get; set; }

        public DateTime? recorddate { get; set; }

        public DateTime? updatedate { get; set; }

        [StringLength(100)]
        public string updateby { get; set; }
    }
}
