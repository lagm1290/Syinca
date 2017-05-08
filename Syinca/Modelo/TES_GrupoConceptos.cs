namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_GrupoConceptos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TES_GrupoConceptos()
        {
            TES_Concepto = new HashSet<TES_Concepto>();
        }

        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public int Area { get; set; }

        [Required]
        [StringLength(50)]
        public string CodArea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_Concepto> TES_Concepto { get; set; }
    }
}
