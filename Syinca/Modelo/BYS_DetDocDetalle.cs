namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_DetDocDetalle
    {
        public long id { get; set; }

        public int DetDocumento { get; set; }

        public long Referencia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Cantidad { get; set; }

        public long DetSolicitud { get; set; }

        public long Solicitud { get; set; }

        public int CCosto { get; set; }

        public virtual BYS_DocumentoDetalle BYS_DocumentoDetalle { get; set; }
    }
}
