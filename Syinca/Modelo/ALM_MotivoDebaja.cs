namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_MotivoDebaja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALM_MotivoDebaja()
        {
            ALM_DBDetalle = new HashSet<ALM_DBDetalle>();
        }

        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [StringLength(150)]
        public string Nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_DBDetalle> ALM_DBDetalle { get; set; }
    }
}
