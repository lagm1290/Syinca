namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_tipo_sociedad
    {
        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
