namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_RetencionOC
    {
        public long id { get; set; }

        public long OrdenCompra { get; set; }

        public int Retencion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Base { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorRetencion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseLiquidacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Liquidacion { get; set; }

        public virtual BYS_Documento BYS_Documento { get; set; }
    }
}
