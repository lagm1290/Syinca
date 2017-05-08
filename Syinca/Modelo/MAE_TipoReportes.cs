namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAE_TipoReportes
    {
        [Key]
        [StringLength(100)]
        public string Modulo { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }
    }
}
