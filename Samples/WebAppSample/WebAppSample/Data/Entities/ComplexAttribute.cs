namespace BMOD.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ComplexAttribute
    {
        [Key]
        public int ComplexAttribID { get; set; }

        [Required]
        [StringLength(5)]
        public string ComplexCode { get; set; }

        public int ComplexAttribCode { get; set; }

        [StringLength(200)]
        public string ComplexAttribDesc { get; set; }
    }
}
