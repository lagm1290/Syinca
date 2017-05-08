namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_CreditosSuper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRE_CreditosSuper()
        {
            CRE_CreditosSuperDet = new HashSet<CRE_CreditosSuperDet>();
        }

        public long id { get; set; }

        public DateTime FeCreacion { get; set; }

        public int PeriodoINI { get; set; }

        public int PeriodoFIN { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrFondo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrFCuatro { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrFOtras { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoCredito { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_CreditosSuperDet> CRE_CreditosSuperDet { get; set; }
    }
}
