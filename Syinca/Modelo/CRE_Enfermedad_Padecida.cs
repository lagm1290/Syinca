namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Enfermedad_Padecida
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string Enfermedad { get; set; }

        public int Solicitud_Credito { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        public virtual CRE_Enfermedades CRE_Enfermedades { get; set; }

        public virtual CRE_Solicitud_Credito CRE_Solicitud_Credito { get; set; }
    }
}
