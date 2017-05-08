namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_FlujoServicio
    {
        public long id { get; set; }

        public long SolicitudServicion { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public int Flujo { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(250)]
        public string Observacion { get; set; }

        public virtual BYS_SolicitudServicio BYS_SolicitudServicio { get; set; }
    }
}
