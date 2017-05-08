namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AAFctura")]
    public partial class AAFctura
    {
        public int? CodServicio { get; set; }

        [StringLength(255)]
        public string Programa { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string Cedula { get; set; }

        [StringLength(255)]
        public string Estudiante { get; set; }

        [StringLength(255)]
        public string Teléfono { get; set; }

        [StringLength(255)]
        public string Fecha { get; set; }

        [Column("No#")]
        [StringLength(255)]
        public string No_ { get; set; }

        public int? Cuotas { get; set; }

        public int? Corriente { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Valor { get; set; }

        [StringLength(255)]
        public string Asesor { get; set; }
    }
}
