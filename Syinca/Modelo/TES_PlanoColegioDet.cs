namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_PlanoColegioDet
    {
        public long id { get; set; }

        public long PlanoColegio { get; set; }

        [Required]
        [StringLength(200)]
        public string Detalle { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Required]
        [StringLength(30)]
        public string Factura { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(50)]
        public string CCosto { get; set; }

        public DateTime FechaPago { get; set; }

        [Required]
        [StringLength(50)]
        public string FormaRecaudo { get; set; }

        [Required]
        [StringLength(2)]
        public string Procesado { get; set; }

        public virtual TES_PlanoColegio TES_PlanoColegio { get; set; }
    }
}
