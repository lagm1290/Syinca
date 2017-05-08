namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_representante
    {
        public int id { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(1)]
        public string Representante { get; set; }

        [StringLength(50)]
        public string Identificacion { get; set; }

        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Cargo { get; set; }

        [StringLength(150)]
        public string Telefono { get; set; }

        [StringLength(150)]
        public string Correo { get; set; }

        [StringLength(150)]
        public string Area { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
