namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_RecaudoXamortizacion
    {
        public int id { get; set; }

        public int RecaudoCredito { get; set; }

        public int Amortizacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CuotaCapital { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CuotaInteres { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CuotaMora { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CuotaComision { get; set; }

        public virtual CRE_RecaudoCredito CRE_RecaudoCredito { get; set; }
    }
}
