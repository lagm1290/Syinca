namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_IngresosBancoCar
    {
        public long id { get; set; }

        public long Cartera { get; set; }

        public long Detalle { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Saldo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorRecaudado { get; set; }

        public virtual FAC_Cartera FAC_Cartera { get; set; }

        public virtual TES_IngresosBancoDet TES_IngresosBancoDet { get; set; }
    }
}
