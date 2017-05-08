namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZYS_Entradas
    {
        public long id { get; set; }

        [Required]
        [StringLength(20)]
        public string Usuario { get; set; }

        public DateTime Fe_Entrada { get; set; }

        public DateTime? Fe_Salida { get; set; }
    }
}
