namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_ClaseTercero
    {
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Clase { get; set; }

        public long Tercero { get; set; }

        public virtual BYS_Clases BYS_Clases { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
