namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_Clases
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BYS_Clases()
        {
            ALM_BienesServicios = new HashSet<ALM_BienesServicios>();
            BYS_ClaseRubro = new HashSet<BYS_ClaseRubro>();
            TER_ClaseTercero = new HashSet<TER_ClaseTercero>();
            BYS_Solicitud = new HashSet<BYS_Solicitud>();
            BYS_SolicitudServicio = new HashSet<BYS_SolicitudServicio>();
        }

        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoSolicitud { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [StringLength(20)]
        public string RubroPresupuesto { get; set; }

        [Required]
        [StringLength(50)]
        public string Filtro { get; set; }

        [Required]
        [StringLength(2)]
        public string Activo { get; set; }

        [StringLength(20)]
        public string rubro_presupuesto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Aumento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_BienesServicios> ALM_BienesServicios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_ClaseRubro> BYS_ClaseRubro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_ClaseTercero> TER_ClaseTercero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_Solicitud> BYS_Solicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_SolicitudServicio> BYS_SolicitudServicio { get; set; }

        public virtual BYS_TipoSolicitud BYS_TipoSolicitud { get; set; }
    }
}
