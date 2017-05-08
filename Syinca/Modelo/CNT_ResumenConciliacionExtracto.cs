namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_ResumenConciliacionExtracto
    {
        public long Id { get; set; }

        public DateTime? Fecha { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Valor { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public int? Partida { get; set; }

        [StringLength(20)]
        public string Estado { get; set; }

        public long? Conciliacion { get; set; }

        public virtual CNT_Conciliacion CNT_Conciliacion { get; set; }
    }
}
