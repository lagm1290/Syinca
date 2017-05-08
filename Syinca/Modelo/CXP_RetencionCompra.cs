namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CXP_RetencionCompra
    {
        public long id { get; set; }

        public long Compra { get; set; }

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

        [Required]
        [StringLength(150)]
        public string NomCuenta { get; set; }

        public virtual CXP_Compras CXP_Compras { get; set; }
    }
}
