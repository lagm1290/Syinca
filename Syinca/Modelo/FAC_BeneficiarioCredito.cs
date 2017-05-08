namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_BeneficiarioCredito
    {
        public long id { get; set; }

        public long Cartera { get; set; }

        public decimal Beneficiario { get; set; }
    }
}
