namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EXT_Rubro
    {
        public int id { get; set; }

        [StringLength(3)]
        public string Nom_Rubro { get; set; }

        [StringLength(20)]
        public string Rubro { get; set; }

        [StringLength(150)]
        public string Nombre { get; set; }
    }
}
