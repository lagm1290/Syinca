namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_TipoTercero
    {
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }

        public virtual TER_Tipo TER_Tipo { get; set; }
    }
}
