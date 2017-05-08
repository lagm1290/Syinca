namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CXP_ComprasDetalle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CXP_ComprasDetalle()
        {
            CXP_CruceCuentas = new HashSet<CXP_CruceCuentas>();
        }

        public long id { get; set; }

        public long Compra { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Base { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Tasa { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Total { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        public virtual BYS_Conceptos BYS_Conceptos { get; set; }

        public virtual CXP_Compras CXP_Compras { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXP_CruceCuentas> CXP_CruceCuentas { get; set; }
    }
}
