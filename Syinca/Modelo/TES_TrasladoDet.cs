namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_TrasladoDet
    {
        public long id { get; set; }

        public long Traslado { get; set; }

        public long EgresoPendiente { get; set; }

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

        public long Tercero { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }

        public virtual TES_Concepto TES_Concepto { get; set; }

        public virtual TES_EgresosPendiente TES_EgresosPendiente { get; set; }

        public virtual TES_Traslados TES_Traslados { get; set; }
    }
}
