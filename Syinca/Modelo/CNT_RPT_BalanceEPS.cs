namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_RPT_BalanceEPS
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public int Periodo { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string CtaCuenta { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Naturaleza { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AnteriorDB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AnteriorCR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Debito { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Credito { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoDB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoCR { get; set; }

        public int Nivel { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoDisponible { get; set; }

        public int Sumar { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }
    }
}
