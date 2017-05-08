namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_Firmas
    {
        [Key]
        [StringLength(250)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(70)]
        public string Cargo { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }
    }
}
