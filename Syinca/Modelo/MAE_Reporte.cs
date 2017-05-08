namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAE_Reporte
    {
        [StringLength(50)]
        public string id { get; set; }

        [Required]
        [StringLength(100)]
        public string TipoReporte { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string Ruta { get; set; }

        [StringLength(150)]
        public string VentanaParametro { get; set; }

        [StringLength(250)]
        public string Parametros { get; set; }
    }
}
