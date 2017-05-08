namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_FlujoCDP
    {
        public int Id { get; set; }

        public int SolicitudCDP { get; set; }

        public int Usuario { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(250)]
        public string Observacion { get; set; }

        public virtual PRE_SolicitudCDP PRE_SolicitudCDP { get; set; }
    }
}
