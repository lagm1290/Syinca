namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_PlanPagos
    {
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public long Contratos { get; set; }

        public int NoCuota { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(2)]
        public string Anticipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorTotal { get; set; }

        [StringLength(50)]
        public string Factura { get; set; }

        public long? idTesoreria { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrRetefuente { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrReteIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrAnticipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseRetefuente { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseReteIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrFactura { get; set; }

        public virtual SER_Contratos SER_Contratos { get; set; }
    }
}
