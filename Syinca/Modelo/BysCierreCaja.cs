namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BysCierreCaja")]
    public partial class BysCierreCaja
    {
        [Column(TypeName = "numeric")]
        public decimal id { get; set; }

        [Required]
        [StringLength(50)]
        public string estado { get; set; }

        public DateTime fecha { get; set; }

        [Column(TypeName = "numeric")]
        public decimal total { get; set; }
    }
}
