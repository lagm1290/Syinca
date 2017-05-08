namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_Retencion
    {
        public long id { get; set; }

        public long Contrato { get; set; }

        public int Retencion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Base { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorRetencion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseLiquidacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Liquidacion { get; set; }

        public virtual SER_Contratos SER_Contratos { get; set; }
    }
}
