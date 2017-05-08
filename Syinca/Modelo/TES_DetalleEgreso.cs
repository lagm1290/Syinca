namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_DetalleEgreso
    {
        public long id { get; set; }

        public long Egreso { get; set; }

        public long? EgresosPendiente { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Deuda { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Required]
        [StringLength(50)]
        public string Pendiente { get; set; }

        public int CCosto { get; set; }

        public virtual TES_Egreso TES_Egreso { get; set; }

        public virtual TES_EgresosPendiente TES_EgresosPendiente { get; set; }
    }
}
