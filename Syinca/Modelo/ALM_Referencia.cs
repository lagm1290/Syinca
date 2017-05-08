namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_Referencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALM_Referencia()
        {
            ALM_DetalleRemision = new HashSet<ALM_DetalleRemision>();
            ALM_kardex = new HashSet<ALM_kardex>();
            BYS_DocumentoDetalle = new HashSet<BYS_DocumentoDetalle>();
            BYS_DetalleSolicitud = new HashSet<BYS_DetalleSolicitud>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Articulo { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(2)]
        public string EnUso { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public int Disponible { get; set; }

        public DateTime FeActualizacion { get; set; }

        public virtual ALM_BienesServicios ALM_BienesServicios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_DetalleRemision> ALM_DetalleRemision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_kardex> ALM_kardex { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_DocumentoDetalle> BYS_DocumentoDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_DetalleSolicitud> BYS_DetalleSolicitud { get; set; }
    }
}
