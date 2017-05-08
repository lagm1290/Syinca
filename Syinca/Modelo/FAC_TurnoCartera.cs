namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_TurnoCartera
    {
        public int id { get; set; }

        [Required]
        [StringLength(12)]
        public string Usuario { get; set; }

        public int Concepto { get; set; }

        [Required]
        [StringLength(2)]
        public string Turno { get; set; }
    }
}
