namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NOM_Colilla
    {
        public long id { get; set; }

        public long NominaDet { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorB { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Indicador { get; set; }

        public virtual NOM_Concepto NOM_Concepto { get; set; }

        public virtual NOM_NominaDet NOM_NominaDet { get; set; }
    }
}
