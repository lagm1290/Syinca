namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Bienes_Solicitud
    {
        public int id { get; set; }

        public int Solicitud_Credito { get; set; }

        [Required]
        [StringLength(50)]
        public string Bienes { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public virtual CRE_Bienes CRE_Bienes { get; set; }

        public virtual CRE_Solicitud_Credito CRE_Solicitud_Credito { get; set; }
    }
}
