namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_Proveedor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public int? Personal_Planta { get; set; }

        public int? Personal_Temporal { get; set; }

        public DateTime? Fe_Radicacion_RUT { get; set; }

        [StringLength(50)]
        public string Tipo_Descuento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Porc_Descuento { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }

        public virtual TER_Tipo_Descuento TER_Tipo_Descuento { get; set; }
    }
}
