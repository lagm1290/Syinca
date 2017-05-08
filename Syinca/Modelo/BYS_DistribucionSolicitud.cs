namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_DistribucionSolicitud
    {
        public long id { get; set; }

        public long Solicitud { get; set; }

        public int CentroCosto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public int Presupuesto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Porcentaje { get; set; }

        public virtual PRE_Presupuesto PRE_Presupuesto { get; set; }

        public virtual BYS_Solicitud BYS_Solicitud { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }
    }
}
