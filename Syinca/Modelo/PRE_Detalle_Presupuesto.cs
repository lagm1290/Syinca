namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_Detalle_Presupuesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRE_Detalle_Presupuesto()
        {
            PRE_Detalle_Traslado = new HashSet<PRE_Detalle_Traslado>();
        }

        public int id { get; set; }

        public int Presupuesto { get; set; }

        public int Periodo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Disponible { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Comprometido { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor_Real { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Disponible_Real { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Comprometido_Real { get; set; }

        public virtual PRE_Presupuesto PRE_Presupuesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_Detalle_Traslado> PRE_Detalle_Traslado { get; set; }
    }
}
