namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AUX_TipoSolicitud
    {
        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [StringLength(20)]
        public string Rubro { get; set; }
    }
}
