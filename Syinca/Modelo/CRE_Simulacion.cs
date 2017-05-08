namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Simulacion
    {
        public int id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CuotaTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CuotaCapital { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CuotaInteres { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CuotaMora { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CuotaComision { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CuotaSeguro { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoNuevo { get; set; }

        public DateTime Fe_Corte { get; set; }

        public DateTime Fe_Plazo { get; set; }

        public int Numero { get; set; }
    }
}
