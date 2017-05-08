namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_DPDetalle
    {
        public long id { get; set; }

        public long DevolucionProveedor { get; set; }

        public long Referencia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorUnitario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Descuento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorTotal { get; set; }

        public long idNEDetalle { get; set; }

        public virtual ALM_DevolucionProveedor ALM_DevolucionProveedor { get; set; }
    }
}
