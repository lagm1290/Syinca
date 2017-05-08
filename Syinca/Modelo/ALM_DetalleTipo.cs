namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_DetalleTipo
    {
        public int id { get; set; }

        [StringLength(20)]
        public string TipoRemision { get; set; }

        [StringLength(20)]
        public string Debito { get; set; }

        [StringLength(150)]
        public string NomDebito { get; set; }

        [StringLength(20)]
        public string Credito { get; set; }

        [StringLength(150)]
        public string NomCredito { get; set; }

        public virtual ALM_TipoRemision ALM_TipoRemision { get; set; }
    }
}
