namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Linea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRE_Linea()
        {
            CRE_Linea_Credito = new HashSet<CRE_Linea_Credito>();
        }

        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorFondo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoFondo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Linea_Credito> CRE_Linea_Credito { get; set; }
    }
}