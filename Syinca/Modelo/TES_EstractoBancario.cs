namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_EstractoBancario
    {
        public long Id { get; set; }

        public long ConciliacionID { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string TransaccionNro { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Required]
        [StringLength(50)]
        public string Ciudad { get; set; }

        [Required]
        [StringLength(50)]
        public string DocumentoNumero { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorDB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorCR { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public virtual TES_Conciliacion TES_Conciliacion { get; set; }
    }
}
