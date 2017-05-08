namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AACaja")]
    public partial class AACaja
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string CCosto { get; set; }

        [Required]
        [StringLength(20)]
        public string Rubro { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }
    }
}
