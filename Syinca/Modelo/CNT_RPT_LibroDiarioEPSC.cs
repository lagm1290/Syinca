namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_RPT_LibroDiarioEPSC
    {
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string NoExterno { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoDocumento { get; set; }

        [Required]
        [StringLength(250)]
        public string Observacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorDB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorCR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Saldo { get; set; }

        public long idTercero { get; set; }

        [Required]
        [StringLength(50)]
        public string CtaContable { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCuenta { get; set; }

        public long idAsientoDet { get; set; }

        public long idAsiento { get; set; }

        [Required]
        [StringLength(50)]
        public string Naturaleza { get; set; }

        public DateTime FechaINI { get; set; }

        public DateTime FechaFIN { get; set; }

        [Required]
        [StringLength(50)]
        public string NoDocumento { get; set; }

        public int Periodo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseRet { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TasaRet { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Required]
        [StringLength(50)]
        public string CodCCosto { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCCosto { get; set; }
    }
}
