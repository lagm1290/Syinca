namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_Solicitud
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BYS_Solicitud()
        {
            ALM_NotaSalida = new HashSet<ALM_NotaSalida>();
            ALM_Remision = new HashSet<ALM_Remision>();
            BYS_DetalleSolicitud = new HashSet<BYS_DetalleSolicitud>();
            BYS_DistribucionSolicitud = new HashSet<BYS_DistribucionSolicitud>();
            BYS_FlujoAprobacion = new HashSet<BYS_FlujoAprobacion>();
            BYS_SolicitudCotizacion = new HashSet<BYS_SolicitudCotizacion>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Clase { get; set; }

        public int NoSolicitud { get; set; }

        public DateTime Fe_Creacion { get; set; }

        public int CentroCosto { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public int Flujo { get; set; }

        [Required]
        [StringLength(250)]
        public string Justificacion { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoRP { get; set; }

        public int NoCuotas { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TotalEstimado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TotalPresupuestado { get; set; }

        public int Presupuesto { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoSolicitud { get; set; }

        [Required]
        [StringLength(2)]
        public string Publicidad { get; set; }

        [StringLength(2)]
        public string Mercadeo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_NotaSalida> ALM_NotaSalida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_Remision> ALM_Remision { get; set; }

        public virtual BYS_Clases BYS_Clases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_DetalleSolicitud> BYS_DetalleSolicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_DistribucionSolicitud> BYS_DistribucionSolicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_FlujoAprobacion> BYS_FlujoAprobacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_SolicitudCotizacion> BYS_SolicitudCotizacion { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }
    }
}
