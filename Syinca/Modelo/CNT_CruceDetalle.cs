namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_CruceDetalle
    {
        public long id { get; set; }

        public long Cruce { get; set; }

        public long CxP { get; set; }

        [Required]
        [StringLength(50)]
        public string ConceptoCxP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Saldo { get; set; }

        public long CxC { get; set; }

        [Required]
        [StringLength(50)]
        public string ConceptoCxC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public virtual CAR_Cartera CAR_Cartera { get; set; }

        public virtual CNT_Cruce CNT_Cruce { get; set; }

        public virtual TES_EgresosPendiente TES_EgresosPendiente { get; set; }
    }
}
