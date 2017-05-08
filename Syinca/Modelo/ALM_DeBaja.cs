namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_DeBaja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALM_DeBaja()
        {
            ALM_DBDetalle = new HashSet<ALM_DBDetalle>();
            ALM_PreasientoDB = new HashSet<ALM_PreasientoDB>();
        }

        public long id { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public int CentroCosto { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public DateTime? FeActa { get; set; }

        [StringLength(50)]
        public string NoActa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_DBDetalle> ALM_DBDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_PreasientoDB> ALM_PreasientoDB { get; set; }
    }
}
