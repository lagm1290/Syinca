namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_Control_Comprobante
    {
        public long id { get; set; }

        public long Comprobante { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(12)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoComprobante { get; set; }
    }
}
