namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_BienesServicios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALM_BienesServicios()
        {
            ALM_Referencia = new HashSet<ALM_Referencia>();
        }

        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string UnidadMedida { get; set; }

        [Required]
        [StringLength(150)]
        public string Detalle { get; set; }

        [Required]
        [StringLength(15)]
        public string ClaseBien { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Required]
        [StringLength(2)]
        public string EnUso { get; set; }

        [Required]
        [StringLength(50)]
        public string Clase { get; set; }

        [Required]
        [StringLength(50)]
        public string Clasificacion { get; set; }

        public int idIVA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_Referencia> ALM_Referencia { get; set; }

        public virtual BYS_Clases BYS_Clases { get; set; }

        public virtual ALM_Clasificacion ALM_Clasificacion { get; set; }

        public virtual ALM_UnidadMedida ALM_UnidadMedida { get; set; }
    }
}
