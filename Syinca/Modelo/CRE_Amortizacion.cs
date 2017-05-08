namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Amortizacion
    {
        public long id { get; set; }

        public int Credito { get; set; }

        public DateTime FechaIni { get; set; }

        public DateTime FechaFin { get; set; }

        public int Dias { get; set; }

        public DateTime FechaCalculo { get; set; }

        public DateTime FePago { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorBase { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorInteres { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorMora { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorSeguro { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorComision { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoBase { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoInteres { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoMora { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoSeguro { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoComision { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoTotal { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(3)]
        public string Causado { get; set; }

        public virtual CRE_Solicitud_Credito CRE_Solicitud_Credito { get; set; }
    }
}
