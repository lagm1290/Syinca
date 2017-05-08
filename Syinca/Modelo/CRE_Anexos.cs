namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Anexos
    {
        public int id { get; set; }

        public int SolicituCredito { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        [StringLength(250)]
        public string Ruta { get; set; }

        public virtual CRE_Solicitud_Credito CRE_Solicitud_Credito { get; set; }
    }
}
