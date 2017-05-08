namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_FuenteSolicitud
    {
        public long id { get; set; }

        public long Solicitud { get; set; }

        [Required]
        [StringLength(50)]
        public string Fuente { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Porcentaje { get; set; }

        [StringLength(150)]
        public string Observacion { get; set; }

        public virtual BYS_SolicitudServicio BYS_SolicitudServicio { get; set; }
    }
}
