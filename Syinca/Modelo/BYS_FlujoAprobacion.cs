namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_FlujoAprobacion
    {
        public int id { get; set; }

        public long Solicitud { get; set; }

        [Required]
        [StringLength(12)]
        public string Usuario { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }

        public virtual BYS_Solicitud BYS_Solicitud { get; set; }

        public virtual MAE_Usuario MAE_Usuario { get; set; }
    }
}
