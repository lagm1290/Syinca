namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_SeleccionProveedor
    {
        public long id { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
