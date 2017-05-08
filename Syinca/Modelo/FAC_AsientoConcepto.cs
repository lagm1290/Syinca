namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_AsientoConcepto
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Required]
        [StringLength(50)]
        public string Campo { get; set; }

        [Required]
        [StringLength(50)]
        public string Naturaleza { get; set; }

        public virtual FAC_Concepto FAC_Concepto { get; set; }
    }
}
