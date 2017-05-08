namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_Extracto
    {
        public long id { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(70)]
        public string CuentaNumero { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoCuenta { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SaldoInicial { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalAbonos { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalCargos { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalIva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalCuatroPorMil { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalRetencion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalIntereses { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SaldoFinal { get; set; }

        public long? Conciliacion { get; set; }
    }
}
