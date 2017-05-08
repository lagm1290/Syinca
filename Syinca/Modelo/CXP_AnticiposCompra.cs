namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CXP_AnticiposCompra
    {
        public long id { get; set; }

        public long Tercero { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public long Compra { get; set; }

        public long? AnticipoCompra { get; set; }

        [StringLength(50)]
        public string NoExterno { get; set; }

        public int? Numero { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Saldo { get; set; }

        public virtual CXP_Compras CXP_Compras { get; set; }
    }
}
