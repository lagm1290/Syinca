namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NOM_DistribucionContrato
    {
        public long id { get; set; }

        public int Contrato { get; set; }

        public int CCsoto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Porcentaje { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        public virtual NOM_Contrato NOM_Contrato { get; set; }
    }
}
