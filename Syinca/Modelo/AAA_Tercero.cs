namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAA_Tercero
    {
        public long id { get; set; }

        [Required]
        [StringLength(250)]
        public string nombre { get; set; }

        public long? consecutivo { get; set; }
    }
}
