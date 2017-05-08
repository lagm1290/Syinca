namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_RetencionFactura
    {
        public long id { get; set; }

        public long Factura { get; set; }

        public int Retencion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Base { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorRetencion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseLiquidacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Liquidacion { get; set; }

        [Required]
        [StringLength(20)]
        public string CuentaContable { get; set; }

        public virtual FAC_Factura FAC_Factura { get; set; }
    }
}
