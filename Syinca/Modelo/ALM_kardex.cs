namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_kardex
    {
        public long id { get; set; }

        public long Referencia { get; set; }

        public DateTime Fe_Movimiento { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(20)]
        public string Tipo { get; set; }

        public int Cantidad { get; set; }

        public int Disponible { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorUnitario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Total { get; set; }

        public long? idDetRemision { get; set; }

        public long Tercero { get; set; }

        [Column(TypeName = "numeric")]
        public decimal iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrIVA { get; set; }

        public virtual ALM_Referencia ALM_Referencia { get; set; }
    }
}
