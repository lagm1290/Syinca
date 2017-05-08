namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_DetallePagoCuotas
    {
        public long id { get; set; }

        public long DetalleCartera { get; set; }

        [Required]
        [StringLength(50)]
        public string idorigen { get; set; }

        [Required]
        [StringLength(150)]
        public string NomOrigen { get; set; }

        [Required]
        [StringLength(50)]
        public string Campo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }
    }
}
