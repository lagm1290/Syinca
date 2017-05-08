namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_PlanoNovasoftDetalle
    {
        public long id { get; set; }

        public long PlanoNovasoft { get; set; }

        [StringLength(1500)]
        public string Detalle { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }
    }
}
