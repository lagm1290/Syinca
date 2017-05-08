namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_MedioRecaudoVenta
    {
        public long id { get; set; }

        public long Factura { get; set; }

        [Required]
        [StringLength(50)]
        public string FormaRecaudo { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public long Tercero { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Interes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Mora { get; set; }

        public int DiaCorte { get; set; }

        public int DiasGavela { get; set; }

        public int DiaFacturacion { get; set; }

        public int Plazo { get; set; }

        public virtual FAC_Factura FAC_Factura { get; set; }

        public virtual FAC_FormaRecaudo FAC_FormaRecaudo { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
