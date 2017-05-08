namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_Periodicidad
    {
        [Key]
        [StringLength(40)]
        public string Rango { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }
    }
}
