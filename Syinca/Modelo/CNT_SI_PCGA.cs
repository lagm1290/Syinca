namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_SI_PCGA
    {
        public int id { get; set; }

        public int SaldoInicialCab { get; set; }

        [Required]
        [StringLength(20)]
        public string CtaContable { get; set; }

        [Required]
        [StringLength(50)]
        public string Naturaleza { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCuenta { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorDB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorCR { get; set; }

        public virtual CNT_PUC_General CNT_PUC_General { get; set; }

        public virtual CNT_SaldoInicialCab CNT_SaldoInicialCab { get; set; }
    }
}
