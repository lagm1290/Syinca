namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_NSDetalle
    {
        public long id { get; set; }

        public long NotaSalida { get; set; }

        public long Referencia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorUnitario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorTotal { get; set; }

        public long Kardex { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VrIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TotalIVA { get; set; }

        public long Tercero { get; set; }

        public virtual ALM_NotaSalida ALM_NotaSalida { get; set; }
    }
}
