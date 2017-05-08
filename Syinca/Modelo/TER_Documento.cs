namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_Documento
    {
        public int id { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
