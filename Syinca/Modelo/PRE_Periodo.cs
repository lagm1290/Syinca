namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_Periodo
    {
        public int id { get; set; }

        [Required]
        [StringLength(40)]
        public string Periodicidad { get; set; }

        public DateTime Fe_Inicio { get; set; }

        public DateTime Fe_Fin { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }
    }
}
