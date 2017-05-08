namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_ClaseRubro
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Clase { get; set; }

        [Required]
        [StringLength(20)]
        public string Rubro { get; set; }

        public virtual BYS_Clases BYS_Clases { get; set; }

        public virtual PRE_Rubro PRE_Rubro { get; set; }
    }
}
