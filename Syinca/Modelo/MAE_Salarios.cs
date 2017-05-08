namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAE_Salarios
    {
        public int id { get; set; }

        public DateTime Fecha { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SMLV { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Auxilio { get; set; }

        public int Anio { get; set; }

        public bool Vigencia { get; set; }
    }
}
