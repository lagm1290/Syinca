namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_SolContrato
    {
        public long id { get; set; }

        public int Numero { get; set; }

        public long SolicitudServicio { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string NoActa { get; set; }

        public DateTime? FeActa { get; set; }

        [Required]
        [StringLength(50)]
        public string Supervisor { get; set; }

        public int CCosto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrSubtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TrIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VrTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PrAnticipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrAnticipo { get; set; }

        public int NoCuotas { get; set; }

        [Required]
        [StringLength(250)]
        public string FormaPago { get; set; }

        [Required]
        [StringLength(250)]
        public string Observaciones { get; set; }

        [Required]
        [StringLength(250)]
        public string Requerimiento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseIVA { get; set; }

        public int NoDias { get; set; }

        public virtual BYS_SolicitudServicio BYS_SolicitudServicio { get; set; }
    }
}
