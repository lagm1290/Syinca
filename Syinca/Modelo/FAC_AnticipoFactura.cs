namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_AnticipoFactura
    {
        public int id { get; set; }

        public long Factura { get; set; }

        public long RpotTesoreria { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoDisponible { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public virtual FAC_Factura FAC_Factura { get; set; }
    }
}
