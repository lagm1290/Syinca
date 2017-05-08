namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_CesionDetalle
    {
        public long id { get; set; }

        public long Cesion { get; set; }

        public long CxP { get; set; }

        [Required]
        [StringLength(50)]
        public string ConceptoCxP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Saldo { get; set; }

        [Required]
        [StringLength(50)]
        public string NoExterno { get; set; }

        public DateTime Fecha { get; set; }

        public virtual CNT_Cesion CNT_Cesion { get; set; }

        public virtual TES_EgresosPendiente TES_EgresosPendiente { get; set; }
    }
}
