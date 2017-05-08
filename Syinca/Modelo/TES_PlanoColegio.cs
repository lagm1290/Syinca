namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_PlanoColegio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TES_PlanoColegio()
        {
            TES_PlanoColegioDet = new HashSet<TES_PlanoColegioDet>();
        }

        public long id { get; set; }

        public int Cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorTotal { get; set; }

        public DateTime FeDocumento { get; set; }

        [Required]
        [StringLength(250)]
        public string Detalle { get; set; }

        public int Periodo { get; set; }

        [Required]
        [StringLength(2)]
        public string Procesado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_PlanoColegioDet> TES_PlanoColegioDet { get; set; }
    }
}
