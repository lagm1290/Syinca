namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_ProrrateoContratos
    {
        public long id { get; set; }

        public long Contrato { get; set; }

        public int CentroCosto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Porcentaje { get; set; }

        [Required]
        [StringLength(20)]
        public string Rubro { get; set; }

        [Required]
        [StringLength(20)]
        public string PlanCuenta { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCuenta { get; set; }

        public int? Presupuesto { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        public virtual PRE_Rubro PRE_Rubro { get; set; }

        public virtual SER_Contratos SER_Contratos { get; set; }
    }
}
