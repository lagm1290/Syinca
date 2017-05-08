namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Coodeudor
    {
        public int id { get; set; }

        public long Coodeudor { get; set; }

        public int Solicitud { get; set; }
    }
}
