namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_AcumuladoEPSC
    {
        public long id { get; set; }

        public int AnioFiscal { get; set; }

        public int Periodo { get; set; }

        [Required]
        [StringLength(20)]
        public string CtaContable { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Naturaleza { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoAnterior { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Debito { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Credito { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoNuevo { get; set; }
    }
}
