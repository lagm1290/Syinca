namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_SolicitudServicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BYS_SolicitudServicio()
        {
            BYS_CotizacionServicio = new HashSet<BYS_CotizacionServicio>();
            BYS_DistribucionServicio = new HashSet<BYS_DistribucionServicio>();
            BYS_FlujoServicio = new HashSet<BYS_FlujoServicio>();
            BYS_FuenteSolicitud = new HashSet<BYS_FuenteSolicitud>();
            BYS_RetencionS = new HashSet<BYS_RetencionS>();
            BYS_SolContrato = new HashSet<BYS_SolContrato>();
            BYS_SServicioDetalle = new HashSet<BYS_SServicioDetalle>();
        }

        public long id { get; set; }

        public long NoSolicitud { get; set; }

        [Required]
        [StringLength(50)]
        public string Clase { get; set; }

        public int CentroCosto { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public int Flujo { get; set; }

        public DateTime FeCreacion { get; set; }

        public int? Presupuesto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(1000)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(1000)]
        public string Justificacion { get; set; }

        [StringLength(50)]
        public string Contrato { get; set; }

        public int Editar { get; set; }

        [StringLength(2)]
        public string Mercadeo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrPresupuesto { get; set; }

        public virtual BYS_Clases BYS_Clases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_CotizacionServicio> BYS_CotizacionServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_DistribucionServicio> BYS_DistribucionServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_FlujoServicio> BYS_FlujoServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_FuenteSolicitud> BYS_FuenteSolicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_RetencionS> BYS_RetencionS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_SolContrato> BYS_SolContrato { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_SServicioDetalle> BYS_SServicioDetalle { get; set; }
    }
}
