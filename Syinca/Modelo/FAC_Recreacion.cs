namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_Recreacion
    {
        public long id { get; set; }

        public long idOrigen { get; set; }

        [Required]
        [StringLength(100)]
        public string Tabla { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        public DateTime Fecha { get; set; }

        public int idServicio { get; set; }

        public int Cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorUnitario { get; set; }

        public int FormaRecaudo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(50)]
        public string IdentificacionDeuda { get; set; }
    }
}
