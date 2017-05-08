namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_TipoInversiones
    {
        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }
    }
}
