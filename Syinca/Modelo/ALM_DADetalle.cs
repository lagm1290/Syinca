namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_DADetalle
    {
        public long id { get; set; }

        public long DevolucionAlmacen { get; set; }

        public long Referencia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorUnitario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorTotal { get; set; }

        public long idNSDetalle { get; set; }

        public long Tercero { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrIVA { get; set; }

        public virtual ALM_DevolucionAlmacen ALM_DevolucionAlmacen { get; set; }
    }
}
