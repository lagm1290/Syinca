namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_TablaPrecio
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Precio { get; set; }

        public int Servicio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorSub { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorReal { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(2)]
        public string Vigente { get; set; }

        public virtual FAC_Precio FAC_Precio { get; set; }

        public virtual FAC_Servicio FAC_Servicio { get; set; }
    }
}
