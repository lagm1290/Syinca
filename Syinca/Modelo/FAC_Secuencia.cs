namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_Secuencia
    {
        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Prefijo { get; set; }

        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }

        public int Secuencia { get; set; }

        public int CentroCosto { get; set; }

        public int NoIni { get; set; }

        public int NoFin { get; set; }

        public DateTime FeIni { get; set; }

        public DateTime FeFin { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(250)]
        public string Leyenda { get; set; }

        [StringLength(250)]
        public string Observacion { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }
    }
}
