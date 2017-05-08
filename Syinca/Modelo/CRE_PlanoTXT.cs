namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_PlanoTXT
    {
        public int id { get; set; }

        [StringLength(1000)]
        public string Detalle { get; set; }
    }
}
