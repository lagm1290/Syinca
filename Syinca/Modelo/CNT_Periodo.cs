namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_Periodo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNT_Periodo()
        {
            CNT_AsientoEPS = new HashSet<CNT_AsientoEPS>();
            CNT_AsientoEPSC = new HashSet<CNT_AsientoEPSC>();
            CNT_AsientoNIIF = new HashSet<CNT_AsientoNIIF>();
            CNT_AsientoNIIF_EPS = new HashSet<CNT_AsientoNIIF_EPS>();
            CNT_AsientoNIIF_EPSC = new HashSet<CNT_AsientoNIIF_EPSC>();
            CNT_AsientoPCGA = new HashSet<CNT_AsientoPCGA>();
            TES_Egreso = new HashSet<TES_Egreso>();
            TES_Ingresos = new HashSet<TES_Ingresos>();
            TES_Notas = new HashSet<TES_Notas>();
            TES_Traslados = new HashSet<TES_Traslados>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Periodo { get; set; }

        public int AnioFiscal { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime? FeCreacion { get; set; }

        public DateTime? FeApertura { get; set; }

        public DateTime? FeCierre { get; set; }

        public virtual CNT_Anio_Fiscal CNT_Anio_Fiscal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoEPS> CNT_AsientoEPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoEPSC> CNT_AsientoEPSC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoNIIF> CNT_AsientoNIIF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoNIIF_EPS> CNT_AsientoNIIF_EPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoNIIF_EPSC> CNT_AsientoNIIF_EPSC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoPCGA> CNT_AsientoPCGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_Egreso> TES_Egreso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_Ingresos> TES_Ingresos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_Notas> TES_Notas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_Traslados> TES_Traslados { get; set; }
    }
}
