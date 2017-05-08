namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class XXX_Presupuesto
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Tipo { get; set; }

        [StringLength(50)]
        public string CCosto { get; set; }

        [StringLength(4)]
        public string Grupo { get; set; }

        [StringLength(20)]
        public string Rubro { get; set; }

        [StringLength(150)]
        public string Nombre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Valor { get; set; }
    }
}
