namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_ContratoSuperDet
    {
        public long id { get; set; }

        public long ContratoSuperCab { get; set; }

        [Required]
        [StringLength(50)]
        public string NoContrato { get; set; }

        [Required]
        [StringLength(50)]
        public string CCosto { get; set; }

        public DateTime FeFirma { get; set; }

        [Required]
        [StringLength(50)]
        public string NoActaCD { get; set; }

        [Required]
        [StringLength(50)]
        public string NomSuscriptor { get; set; }

        [Required]
        [StringLength(50)]
        public string CargoSuscriptor { get; set; }

        [Required]
        [StringLength(100)]
        public string NomContratista { get; set; }

        [Required]
        [StringLength(20)]
        public string NIT { get; set; }

        [Required]
        [StringLength(50)]
        public string Modalidad { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoContrato { get; set; }

        [Required]
        [StringLength(500)]
        public string Objeto { get; set; }

        public DateTime FeInicio { get; set; }

        public DateTime FeFin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorInicial { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorAdicion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrAproteCCF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrCooperante { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoAporteCoop { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoAporteCCF { get; set; }

        [Required]
        [StringLength(100)]
        public string NomSupervisor { get; set; }

        [Required]
        [StringLength(50)]
        public string CargoSupervisor { get; set; }

        public DateTime? FeActaLiq { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorAnticipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorAnticipo { get; set; }

        [Required]
        [StringLength(50)]
        public string AnticipoLegalizado { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public virtual SER_ContratoSuperCab SER_ContratoSuperCab { get; set; }
    }
}
