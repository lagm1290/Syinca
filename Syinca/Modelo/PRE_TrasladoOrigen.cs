namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_TrasladoOrigen
    {
        public int id { get; set; }

        public int Traslado { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public int Presupuesto { get; set; }

        public virtual PRE_Traslado PRE_Traslado { get; set; }
    }
}
