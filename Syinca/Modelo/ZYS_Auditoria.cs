namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZYS_Auditoria
    {
        public long id { get; set; }

        public long? Lave_Objeto { get; set; }

        [StringLength(50)]
        public string Objeto { get; set; }

        [StringLength(50)]
        public string Accion { get; set; }

        [StringLength(20)]
        public string Usuario { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(1000)]
        public string Antes { get; set; }

        [StringLength(1000)]
        public string Despues { get; set; }
    }
}
