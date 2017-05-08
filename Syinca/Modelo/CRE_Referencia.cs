namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Referencia
    {
        public int id { get; set; }

        public int Solicitud_Credito { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo_Referencia { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(150)]
        public string Empresa { get; set; }

        [StringLength(70)]
        public string Telefono { get; set; }

        [StringLength(70)]
        public string Correo { get; set; }

        [Required]
        [StringLength(50)]
        public string Parentesco { get; set; }

        public virtual CRE_Solicitud_Credito CRE_Solicitud_Credito { get; set; }
    }
}
