namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_SCotizacionDetalle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long Cotizacion { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

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
        public decimal Total { get; set; }

        public virtual BYS_CotizacionServicio BYS_CotizacionServicio { get; set; }
    }
}
