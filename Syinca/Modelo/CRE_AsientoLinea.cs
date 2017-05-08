namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_AsientoLinea
    {
        public int id { get; set; }

        public int LineaCredito { get; set; }

        [Required]
        [StringLength(50)]
        public string Campo { get; set; }

        [Required]
        [StringLength(50)]
        public string Naturaleza { get; set; }

        public virtual CRE_Linea_Credito CRE_Linea_Credito { get; set; }
    }
}
