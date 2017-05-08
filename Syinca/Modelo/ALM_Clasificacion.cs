namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_Clasificacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALM_Clasificacion()
        {
            ALM_BienesServicios = new HashSet<ALM_BienesServicios>();
        }

        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_BienesServicios> ALM_BienesServicios { get; set; }
    }
}
