namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAA_CarteraColegio
    {
        public long id { get; set; }

        public long? Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        public DateTime Fecha { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(50)]
        public string CodMatricula { get; set; }

        public int CCosto { get; set; }

        public int Anio { get; set; }
    }
}
