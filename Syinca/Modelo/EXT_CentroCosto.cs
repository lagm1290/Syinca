namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EXT_CentroCosto
    {
        public int id { get; set; }

        [StringLength(11)]
        public string Nom_CentroCosto { get; set; }

        [StringLength(50)]
        public string CentroCosto { get; set; }

        [StringLength(150)]
        public string Nombre { get; set; }
    }
}
