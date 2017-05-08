namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_MovimientoDetalle
    {
        public long id { get; set; }

        public long Movimiento { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrBase { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Tasa { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Total { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        public virtual BYS_Conceptos BYS_Conceptos { get; set; }

        public virtual BYS_Movimiento BYS_Movimiento { get; set; }
    }
}
