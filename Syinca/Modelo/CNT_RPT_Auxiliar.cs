namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_RPT_Auxiliar
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string NoExterno { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoDocumento { get; set; }

        [Required]
        [StringLength(150)]
        public string NomDocumento { get; set; }

        [Required]
        [StringLength(250)]
        public string Observacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorDB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorCR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Saldo { get; set; }

        public long idAsientoDet { get; set; }

        public long idAsiento { get; set; }

        [Required]
        [StringLength(50)]
        public string Naturaleza { get; set; }

        public DateTime FechaINI { get; set; }

        public DateTime FechaFIN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Base { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Tasa { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseIVA { get; set; }

        [Required]
        [StringLength(50)]
        public string Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        [Required]
        [StringLength(150)]
        public string NomTercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Area { get; set; }

        [Required]
        [StringLength(150)]
        public string NomArea { get; set; }

        [Required]
        [StringLength(50)]
        public string Centro { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCentro { get; set; }

        [Required]
        [StringLength(50)]
        public string CCosto { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCCosto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        public int CodRetencion { get; set; }

        [Required]
        [StringLength(50)]
        public string Clase { get; set; }

        [Required]
        [StringLength(150)]
        public string NomClase { get; set; }

        [Required]
        [StringLength(50)]
        public string Grupo { get; set; }

        [Required]
        [StringLength(150)]
        public string NomGrupo { get; set; }

        [Required]
        [StringLength(50)]
        public string Cuenta { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Subcuenta { get; set; }

        [Required]
        [StringLength(150)]
        public string NomSubcuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Subcuenta2 { get; set; }

        [Required]
        [StringLength(150)]
        public string NomSubcuenta2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Auxiliar { get; set; }

        [Required]
        [StringLength(150)]
        public string Nomauxiliar { get; set; }
    }
}
