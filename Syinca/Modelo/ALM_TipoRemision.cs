namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_TipoRemision
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALM_TipoRemision()
        {
            ALM_DetalleTipo = new HashSet<ALM_DetalleTipo>();
            ALM_Remision = new HashSet<ALM_Remision>();
        }

        [Key]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(70)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(20)]
        public string Tipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_DetalleTipo> ALM_DetalleTipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_Remision> ALM_Remision { get; set; }
    }
}
