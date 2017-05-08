namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CXP_CruceCuentas
    {
        public long id { get; set; }

        public long CompraDetalle { get; set; }

        public long Cartera { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public virtual CXP_ComprasDetalle CXP_ComprasDetalle { get; set; }

        public virtual FAC_Cartera FAC_Cartera { get; set; }
    }
}
