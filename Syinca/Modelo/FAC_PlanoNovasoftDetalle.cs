namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_PlanoNovasoftDetalle
    {
        public long id { get; set; }

        public long PlanoNovasoft { get; set; }

        [StringLength(1500)]
        public string Detalle { get; set; }

        public virtual FAC_PlanoNovasoft FAC_PlanoNovasoft { get; set; }
    }
}
