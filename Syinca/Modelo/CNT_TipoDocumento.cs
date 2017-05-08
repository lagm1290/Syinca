namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_TipoDocumento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNT_TipoDocumento()
        {
            CNT_AsientoEPS = new HashSet<CNT_AsientoEPS>();
            CNT_AsientoEPSC = new HashSet<CNT_AsientoEPSC>();
            CNT_AsientoNIIF = new HashSet<CNT_AsientoNIIF>();
            CNT_AsientoNIIF_EPS = new HashSet<CNT_AsientoNIIF_EPS>();
            CNT_AsientoNIIF_EPSC = new HashSet<CNT_AsientoNIIF_EPSC>();
            CNT_AsientoPCGA = new HashSet<CNT_AsientoPCGA>();
            CNT_PreasientoEPS = new HashSet<CNT_PreasientoEPS>();
            CNT_PreasientoEPSC = new HashSet<CNT_PreasientoEPSC>();
            CNT_PreasientoNIIF = new HashSet<CNT_PreasientoNIIF>();
            CNT_PreasientoNIIF_EPS = new HashSet<CNT_PreasientoNIIF_EPS>();
            CNT_PreasientoNIIF_EPSC = new HashSet<CNT_PreasientoNIIF_EPSC>();
            CNT_PreasientoPCGA = new HashSet<CNT_PreasientoPCGA>();
            CXP_Item = new HashSet<CXP_Item>();
            CNT_UsuariosPermisos = new HashSet<CNT_UsuariosPermisos>();
        }

        [Key]
        [StringLength(100)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Modulo { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

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

        public virtual CNT_Modulos CNT_Modulos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_PreasientoEPS> CNT_PreasientoEPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_PreasientoEPSC> CNT_PreasientoEPSC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_PreasientoNIIF> CNT_PreasientoNIIF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_PreasientoNIIF_EPS> CNT_PreasientoNIIF_EPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_PreasientoNIIF_EPSC> CNT_PreasientoNIIF_EPSC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_PreasientoPCGA> CNT_PreasientoPCGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXP_Item> CXP_Item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_UsuariosPermisos> CNT_UsuariosPermisos { get; set; }
    }
}
