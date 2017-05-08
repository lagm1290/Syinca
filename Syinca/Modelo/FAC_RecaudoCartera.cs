namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_RecaudoCartera
    {
        public long id { get; set; }

        public long Recaudo { get; set; }

        public long Cartera { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorCapital { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorInteres { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorMora { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorSeguro { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorComision { get; set; }
    }
}
