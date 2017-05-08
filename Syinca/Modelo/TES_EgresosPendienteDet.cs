namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_EgresosPendienteDet
    {
        public long id { get; set; }

        public long EgresoPendiente { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(100)]
        public string TipoMovimiento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(50)]
        public string Naturaleza { get; set; }

        public virtual TES_EgresosPendiente TES_EgresosPendiente { get; set; }
    }
}
