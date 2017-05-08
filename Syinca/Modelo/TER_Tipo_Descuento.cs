namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_Tipo_Descuento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TER_Tipo_Descuento()
        {
            TER_Proveedor = new HashSet<TER_Proveedor>();
        }

        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_Proveedor> TER_Proveedor { get; set; }
    }
}
