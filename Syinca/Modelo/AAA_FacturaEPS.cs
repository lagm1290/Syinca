namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAA_FacturaEPS
    {
        public double? Foranea { get; set; }

        public string datos { get; set; }

        public double? Documento { get; set; }

        public double ID { get; set; }

        public double? IdExterno { get; set; }
    }
}
