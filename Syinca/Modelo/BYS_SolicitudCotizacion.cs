namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_SolicitudCotizacion
    {
        public int id { get; set; }

        public long Cotizacion { get; set; }

        public long Solicitud { get; set; }

        public virtual BYS_Documento BYS_Documento { get; set; }

        public virtual BYS_Solicitud BYS_Solicitud { get; set; }
    }
}
