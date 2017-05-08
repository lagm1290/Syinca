namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_ResponsabilidadesTercero
    {
        public long id { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Responsabilidades { get; set; }

        [Required]
        [StringLength(2)]
        public string Vigente { get; set; }

        public virtual TER_Responsabilidades TER_Responsabilidades { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
