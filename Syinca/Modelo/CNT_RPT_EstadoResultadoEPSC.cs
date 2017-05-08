namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_RPT_EstadoResultadoEPSC
    {
        public long id { get; set; }

        public int Periodo { get; set; }

        [Required]
        [StringLength(50)]
        public string CtaContable { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Naturaleza { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public int Nivel { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        public int idCCosto { get; set; }

        [Required]
        [StringLength(50)]
        public string CodigoCCosto { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCCosto { get; set; }

        [Required]
        [StringLength(50)]
        public string CodSubCentro { get; set; }

        [Required]
        [StringLength(150)]
        public string NomSubCentro { get; set; }

        [Required]
        [StringLength(50)]
        public string CodArea { get; set; }

        [Required]
        [StringLength(50)]
        public string NomArea { get; set; }
    }
}
