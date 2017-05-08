namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_Notas
    {
        public long id { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string Balance { get; set; }

        public int Anio { get; set; }

        [Required]
        [StringLength(50)]
        public string Cuenta { get; set; }

        [Required]
        [StringLength(250)]
        public string Nota { get; set; }
    }
}
