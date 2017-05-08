namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAA_CarteraCredito
    {
        public int id { get; set; }

        [StringLength(50)]
        public string NoCredito { get; set; }

        public DateTime? FeRecepcion { get; set; }

        [StringLength(50)]
        public string Cedula { get; set; }

        [StringLength(150)]
        public string nombre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Saldo { get; set; }
    }
}
