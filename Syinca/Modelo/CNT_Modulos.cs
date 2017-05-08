namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_Modulos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNT_Modulos()
        {
            CNT_TipoDocumento = new HashSet<CNT_TipoDocumento>();
        }

        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(2)]
        public string Activo { get; set; }

        [Required]
        [StringLength(2)]
        public string EPS { get; set; }

        [Required]
        [StringLength(2)]
        public string EPSC { get; set; }

        [Required]
        [StringLength(2)]
        public string Tesoreria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_TipoDocumento> CNT_TipoDocumento { get; set; }
    }
}
