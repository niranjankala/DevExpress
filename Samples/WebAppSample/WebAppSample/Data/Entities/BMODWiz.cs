namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BMODWiz")]
    public partial class BMODWiz
    {
        [Key]
        public int ChkID { get; set; }

        [Required]
        [StringLength(6)]
        public string WorkOrder { get; set; }

        public bool? WOStarted { get; set; }

        public DateTime? WoStartedRecordDate { get; set; }

        public DateTime? woStartedUpdateDate { get; set; }

        [StringLength(200)]
        public string woStartedUpdateBy { get; set; }

        public bool? APTaken { get; set; }

        public DateTime? APRecordDate { get; set; }

        public DateTime? APUpdateDate { get; set; }

        [StringLength(200)]
        public string APUpdateBy { get; set; }

        public bool? Inspected { get; set; }

        public DateTime? InspectedRecordDate { get; set; }

        public DateTime? InspectedUpdateDate { get; set; }

        [StringLength(200)]
        public string InspectedUpdateBy { get; set; }

        public bool? BPTaken { get; set; }

        public DateTime? BPTakenRecordDate { get; set; }

        public DateTime? BPTakenUpdateDate { get; set; }

        [StringLength(200)]
        public string BPTakenUpdateBy { get; set; }

        public bool? AfterPic { get; set; }

        public DateTime? AfterPicRecordDate { get; set; }

        public DateTime? AfterPicUpdateDate { get; set; }

        [StringLength(200)]
        public string AfterPicUpdateBy { get; set; }

        public bool? SiteCleaned { get; set; }

        public DateTime? SiteCleanedRecordDate { get; set; }

        public DateTime? SiteCleanedUpdateDate { get; set; }

        [StringLength(200)]
        public string SiteCleanedUpdateBy { get; set; }

        public bool? WorkPerformed { get; set; }

        public DateTime? WorkPerformedRecordDate { get; set; }

        public DateTime? WorkPerformedUpdateDate { get; set; }

        [StringLength(200)]
        public string WorkPerformedUpdateBy { get; set; }

        public bool? NTR { get; set; }

        public DateTime? NTRRecordDate { get; set; }

        public DateTime? NTRUpdateDate { get; set; }

        [StringLength(200)]
        public string NTRUpdateBy { get; set; }

        public bool? StockUsed { get; set; }

        public DateTime? StockUsedRecordDate { get; set; }

        public DateTime? StockUsedUpdateDate { get; set; }

        [StringLength(200)]
        public string StockUsedUpdateBy { get; set; }

        public bool? Receipts { get; set; }

        public DateTime? ReceiptsRecordDate { get; set; }

        public DateTime? ReceiptsUpdateDate { get; set; }

        [StringLength(200)]
        public string ReceiptsUpdateBy { get; set; }

        public bool? Debris { get; set; }

        public DateTime? DebrisRecordDate { get; set; }

        public DateTime? DebrisUpdateDate { get; set; }

        [StringLength(200)]
        public string DebrisUpdateBy { get; set; }

        public bool? EquipmentUsed { get; set; }

        public DateTime? EquipmentUsedRecordDate { get; set; }

        public DateTime? EquipmentUsedUpdateDate { get; set; }

        [StringLength(200)]
        public string EquipmentUsedUpdateBy { get; set; }

        public bool? WrapUp { get; set; }

        public DateTime? WrapUpRecordDate { get; set; }

        public DateTime? WrapUpUpdateDate { get; set; }

        [StringLength(200)]
        public string WrapUpUpdateBy { get; set; }
    }
}
