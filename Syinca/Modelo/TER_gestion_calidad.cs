namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_gestion_calidad
    {
        public int id { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Norma_Version { get; set; }

        [StringLength(150)]
        public string Alcance { get; set; }

        [StringLength(150)]
        public string Entidad_Certificadora { get; set; }

        public DateTime? Vigenca_Desde { get; set; }

        public DateTime? Vigencia_Hasta { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
