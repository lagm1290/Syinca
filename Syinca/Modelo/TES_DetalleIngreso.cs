namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_DetalleIngreso
    {
        public long id { get; set; }

        public long Ingresos { get; set; }

        public long Cartera { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Required]
        [StringLength(50)]
        public string Pendiente { get; set; }

        public int CCosto { get; set; }

        [Required]
        [StringLength(50)]
        public string FormaRecaudo { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero { get; set; }

        [StringLength(50)]
        public string Banco { get; set; }

        [StringLength(50)]
        public string CtaBancaria { get; set; }

        public virtual TES_Concepto TES_Concepto { get; set; }

        public virtual TES_Ingresos TES_Ingresos { get; set; }
    }
}
