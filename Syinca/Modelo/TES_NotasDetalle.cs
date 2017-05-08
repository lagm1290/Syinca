namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_NotasDetalle
    {
        public long id { get; set; }

        public long Notas { get; set; }

        public long Tercero { get; set; }

        public int CentroCosto { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [StringLength(250)]
        public string Detalle { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }

        public virtual TES_Concepto TES_Concepto { get; set; }

        public virtual TES_Notas TES_Notas { get; set; }
    }
}
