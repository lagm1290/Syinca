namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Validador
    {
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public int Periodo { get; set; }

        public int Credito { get; set; }

        public long Tercero { get; set; }

        public long Amortizacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrCapital { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrInteres { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReCapital { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReInteres { get; set; }

        [Required]
        [StringLength(250)]
        public string Observacion { get; set; }

        public DateTime FeEnvio { get; set; }

        [StringLength(50)]
        public string Origen { get; set; }

        [StringLength(250)]
        public string NoCobrado { get; set; }

        public long Cabeza { get; set; }

        public decimal? idTransaccion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrRecaudado { get; set; }

        [StringLength(50)]
        public string Identificacion { get; set; }

        [StringLength(150)]
        public string NombreTer { get; set; }

        public virtual CRE_ValidadorCab CRE_ValidadorCab { get; set; }
    }
}
