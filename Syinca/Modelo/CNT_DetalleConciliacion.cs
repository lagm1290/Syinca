namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_DetalleConciliacion
    {
        public long Id { get; set; }

        public long DetConciliacion { get; set; }

        public long? DetExtracto { get; set; }

        public long? LibroAuxiliar { get; set; }

        public int Ind { get; set; }

        public virtual CNT_Conciliacion CNT_Conciliacion { get; set; }

        public virtual CNT_DetalleExtracto CNT_DetalleExtracto { get; set; }

        public virtual TES_LibroAuxiliar TES_LibroAuxiliar { get; set; }
    }
}
