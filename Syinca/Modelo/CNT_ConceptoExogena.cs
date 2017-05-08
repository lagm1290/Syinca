namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_ConceptoExogena
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNT_ConceptoExogena()
        {
            CNT_PUC_General = new HashSet<CNT_PUC_General>();
            CNT_PUC_GeneralEPS = new HashSet<CNT_PUC_GeneralEPS>();
            CNT_PUC_GeneralEPSC = new HashSet<CNT_PUC_GeneralEPSC>();
        }

        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_PUC_General> CNT_PUC_General { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_PUC_GeneralEPS> CNT_PUC_GeneralEPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_PUC_GeneralEPSC> CNT_PUC_GeneralEPSC { get; set; }
    }
}
