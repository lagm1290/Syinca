namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_ColegioIngresoDetalle
    {
        public long id { get; set; }

        public long ColegioIngresos { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Matricula { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public int CCosto { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        public virtual TES_ColegioIngresos TES_ColegioIngresos { get; set; }
    }
}
