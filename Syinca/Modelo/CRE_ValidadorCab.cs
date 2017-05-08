namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_ValidadorCab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRE_ValidadorCab()
        {
            CRE_Validador = new HashSet<CRE_Validador>();
        }

        public long id { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public int Periodo { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Validador> CRE_Validador { get; set; }
    }
}
