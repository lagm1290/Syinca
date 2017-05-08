namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_DetalleSolicitud
    {
        public long id { get; set; }

        public long Solicitud { get; set; }

        public long Referencia { get; set; }

        public int Cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorUnitario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SubTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Descuento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorTotal { get; set; }

        public int Saldo { get; set; }

        [StringLength(50)]
        public string Comprado { get; set; }

        public virtual ALM_Referencia ALM_Referencia { get; set; }

        public virtual BYS_Solicitud BYS_Solicitud { get; set; }
    }
}
