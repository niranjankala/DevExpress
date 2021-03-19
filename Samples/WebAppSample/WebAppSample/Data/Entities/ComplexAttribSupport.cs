namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComplexAttribSupport")]
    public partial class ComplexAttribSupport
    {
        [Key]
        [Column(Order = 0)]
        public int ComplexAttribSupportID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string ComplexAttrib { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool ComplexAttrbSupportInActive { get; set; }
    }
}
