namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_Remision
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALM_Remision()
        {
            ALM_DetalleRemision = new HashSet<ALM_DetalleRemision>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(20)]
        public string Tipo { get; set; }

        public int Numero { get; set; }

        public long? Documento { get; set; }

        public int CentroCosto { get; set; }

        public long? Solicitud { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime Fe_Creacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string NoExterno { get; set; }

        [StringLength(250)]
        public string Nota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_DetalleRemision> ALM_DetalleRemision { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        public virtual BYS_Documento BYS_Documento { get; set; }

        public virtual BYS_Solicitud BYS_Solicitud { get; set; }

        public virtual ALM_TipoRemision ALM_TipoRemision { get; set; }
    }
}
