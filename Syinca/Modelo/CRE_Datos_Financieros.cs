namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Datos_Financieros
    {
        public int id { get; set; }

        public int Solicitud_Credito { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor_Egreso { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor_Ingreso { get; set; }

        public virtual CRE_Concepto CRE_Concepto { get; set; }

        public virtual CRE_Solicitud_Credito CRE_Solicitud_Credito { get; set; }
    }
}
