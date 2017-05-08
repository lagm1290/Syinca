namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_EgresosPendiente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TES_EgresosPendiente()
        {
            CNT_CesionDetalle = new HashSet<CNT_CesionDetalle>();
            CNT_CruceDetalle = new HashSet<CNT_CruceDetalle>();
            TES_DetalleEgreso = new HashSet<TES_DetalleEgreso>();
            TES_TrasladoDet = new HashSet<TES_TrasladoDet>();
            TES_EgresosPendienteDet = new HashSet<TES_EgresosPendienteDet>();
        }

        public long id { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(100)]
        public string Tipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Saldo { get; set; }

        public DateTime FeDisponible { get; set; }

        [Required]
        [StringLength(50)]
        public string idOrigne { get; set; }

        [Required]
        [StringLength(100)]
        public string Tabla { get; set; }

        [StringLength(50)]
        public string NoExterno { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public long idEgreso { get; set; }

        [Required]
        [StringLength(100)]
        public string TipoDocumento { get; set; }

        [Required]
        [StringLength(50)]
        public string NoInterno { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime FePlazo { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        public DateTime? FeDocumentoExt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_CesionDetalle> CNT_CesionDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_CruceDetalle> CNT_CruceDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_DetalleEgreso> TES_DetalleEgreso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_TrasladoDet> TES_TrasladoDet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_EgresosPendienteDet> TES_EgresosPendienteDet { get; set; }
    }
}
