namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAA_Kardex
    {
        public int id { get; set; }

        public int? referencia { get; set; }

        [StringLength(250)]
        public string descripcion { get; set; }

        public int? cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VrUnitario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VrIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VrTotal { get; set; }

        public long? Tercero { get; set; }
    }
}
