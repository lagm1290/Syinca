namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_Servicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FAC_Servicio()
        {
            FAC_DetalleFactura = new HashSet<FAC_DetalleFactura>();
            FAC_TablaPrecio = new HashSet<FAC_TablaPrecio>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public int CentroCosto { get; set; }

        [Required]
        [StringLength(2)]
        public string Activo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Required]
        [StringLength(50)]
        public string Clase { get; set; }

        [Required]
        [StringLength(20)]
        public string Rubro { get; set; }

        [StringLength(50)]
        public string CodExterno { get; set; }

        public int idIVA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_DetalleFactura> FAC_DetalleFactura { get; set; }

        public virtual PRE_Rubro PRE_Rubro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_TablaPrecio> FAC_TablaPrecio { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }
    }
}
