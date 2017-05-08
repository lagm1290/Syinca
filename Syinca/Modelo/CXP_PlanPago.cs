namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CXP_PlanPago
    {
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public long Compra { get; set; }

        public int NoCuota { get; set; }

        public DateTime FePago { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(20)]
        public string CuentaContable { get; set; }

        public virtual CXP_Compras CXP_Compras { get; set; }
    }
}
