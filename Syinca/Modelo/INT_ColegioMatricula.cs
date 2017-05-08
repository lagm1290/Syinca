namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INT_ColegioMatricula
    {
        public long id { get; set; }

        public long Matricula { get; set; }

        [Required]
        [StringLength(50)]
        public string IdentifiacionAcudiente { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string CodEstudiante { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(2)]
        public string Anticipado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrMatriculo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrSistematizacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrPapeleria { get; set; }
    }
}
