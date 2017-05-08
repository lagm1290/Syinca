namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_Tipo_Presupuesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRE_Tipo_Presupuesto()
        {
            PRE_Rubro = new HashSet<PRE_Rubro>();
            PRE_Traslado = new HashSet<PRE_Traslado>();
        }

        [Key]
        [StringLength(50)]
        public string Nombre { get; set; }

        public decimal Cuenta_Ini { get; set; }

        public decimal Cuenta_Fin { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_Rubro> PRE_Rubro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_Traslado> PRE_Traslado { get; set; }
    }
}
