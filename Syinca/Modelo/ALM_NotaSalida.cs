namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_NotaSalida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALM_NotaSalida()
        {
            ALM_DevolucionAlmacen = new HashSet<ALM_DevolucionAlmacen>();
            ALM_NSDetalle = new HashSet<ALM_NSDetalle>();
        }

        public long id { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public long Solicitud { get; set; }

        public int CentroCosto { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_DevolucionAlmacen> ALM_DevolucionAlmacen { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_NSDetalle> ALM_NSDetalle { get; set; }

        public virtual BYS_Solicitud BYS_Solicitud { get; set; }
    }
}
