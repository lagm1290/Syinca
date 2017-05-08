namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAR_FlujoCarteraDet
    {
        public long id { get; set; }

        public long FlujoCartera { get; set; }

        public long Cartera { get; set; }

        [Required]
        [StringLength(250)]
        public string Conclucion { get; set; }

        public virtual CAR_Cartera CAR_Cartera { get; set; }

        public virtual CAR_FlujoCartera CAR_FlujoCartera { get; set; }
    }
}
