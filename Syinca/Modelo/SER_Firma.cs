namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_Firma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SER_Firma()
        {
            SER_Contratos = new HashSet<SER_Contratos>();
        }

        [Key]
        [StringLength(100)]
        public string Codigo { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [StringLength(150)]
        public string Cargo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_Contratos> SER_Contratos { get; set; }
    }
}
