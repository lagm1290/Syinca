namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INT_SubsidioDet
    {
        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string idRecibe { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public long Tercero { get; set; }
    }
}
