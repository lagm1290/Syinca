namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_PUC_General
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNT_PUC_General()
        {
            CNT_AsientoDetallePCGA = new HashSet<CNT_AsientoDetallePCGA>();
            CNT_PreasientoPCGA = new HashSet<CNT_PreasientoPCGA>();
            CNT_SI_PCGA = new HashSet<CNT_SI_PCGA>();
            PRE_Rubro = new HashSet<PRE_Rubro>();
        }

        [Key]
        [StringLength(20)]
        public string Codigo_Contable { get; set; }

        [Required]
        [StringLength(20)]
        public string Sumariza { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre_Cuenta { get; set; }

        [Required]
        [StringLength(10)]
        public string Naturaleza { get; set; }

        [Required]
        [StringLength(10)]
        public string Tipo_cuenta { get; set; }

        public int Nivel { get; set; }

        [Required]
        [StringLength(20)]
        public string Cuenta { get; set; }

        [Required]
        [StringLength(30)]
        public string Clase_Cuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoDisponible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoDetallePCGA> CNT_AsientoDetallePCGA { get; set; }

        public virtual CNT_ConceptoExogena CNT_ConceptoExogena { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_PreasientoPCGA> CNT_PreasientoPCGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_SI_PCGA> CNT_SI_PCGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_Rubro> PRE_Rubro { get; set; }
    }
}
