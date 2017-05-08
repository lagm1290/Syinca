namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_DistribucionServicio
    {
        public long id { get; set; }

        public long SolicitudServicio { get; set; }

        public int CentroCosto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Porcentaje { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public int Presupuesto { get; set; }

        public virtual BYS_SolicitudServicio BYS_SolicitudServicio { get; set; }
    }
}
