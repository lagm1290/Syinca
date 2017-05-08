namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_Anio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Anio { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; }

        public DateTime Fe_Creacion { get; set; }

        public DateTime Fe_Apertura { get; set; }

        public DateTime Fe_Cierre { get; set; }

        public DateTime? Fe_Consolidacion { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }

        [Required]
        [StringLength(40)]
        public string Periodicidad { get; set; }
    }
}
