namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_PlanoNovasoftDetalleCxP
    {
        public long id { get; set; }

        public long PlanoNovasoft { get; set; }

        [StringLength(1500)]
        public string Detalle { get; set; }

        [StringLength(100)]
        public string Documento { get; set; }

        [StringLength(50)]
        public string IDExterno { get; set; }

        public long? idAsiento { get; set; }

        public virtual CNT_PlanoNovasoftCxP CNT_PlanoNovasoftCxP { get; set; }
    }
}
