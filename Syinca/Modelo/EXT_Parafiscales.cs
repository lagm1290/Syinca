namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EXT_Parafiscales
    {
        public int id { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(2)]
        public string TipoID { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        [StringLength(70)]
        public string Nombre_1 { get; set; }

        [StringLength(70)]
        public string Nombre_2 { get; set; }

        [StringLength(70)]
        public string Apellido_1 { get; set; }

        [StringLength(70)]
        public string Apellido_2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Sena { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ICBF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CCF { get; set; }

        public decimal? idTransaccion { get; set; }
    }
}
