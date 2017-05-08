namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_Inversiones
    {
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoInversiones { get; set; }

        [Required]
        [StringLength(50)]
        public string usuario { get; set; }

        public DateTime FeCreacion { get; set; }

        public DateTime FeRegistro { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }
    }
}
