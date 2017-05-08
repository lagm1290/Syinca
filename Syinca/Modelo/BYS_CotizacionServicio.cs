namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_CotizacionServicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BYS_CotizacionServicio()
        {
            BYS_SCotizacionDetalle = new HashSet<BYS_SCotizacionDetalle>();
        }

        public long id { get; set; }

        public long SolicitudServicio { get; set; }

        [Required]
        [StringLength(50)]
        public string NoCotizacion { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime FeCreacion { get; set; }

        public DateTime FeEnvio { get; set; }

        public DateTime FeRecepcion { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_SCotizacionDetalle> BYS_SCotizacionDetalle { get; set; }

        public virtual BYS_SolicitudServicio BYS_SolicitudServicio { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
