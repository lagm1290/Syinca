namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_Concepto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TES_Concepto()
        {
            CAR_Cartera = new HashSet<CAR_Cartera>();
            TES_DetalleIngreso = new HashSet<TES_DetalleIngreso>();
            TES_IngresosBancoDet = new HashSet<TES_IngresosBancoDet>();
            TES_NotasDetalle = new HashSet<TES_NotasDetalle>();
            TES_TrasladoDet = new HashSet<TES_TrasladoDet>();
        }

        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoConcepto { get; set; }

        [Required]
        [StringLength(50)]
        public string Alias { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string Pendiente { get; set; }

        [Required]
        [StringLength(50)]
        public string GrupoConceptos { get; set; }

        [Required]
        [StringLength(2)]
        public string Visible { get; set; }

        public int CCosto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAR_Cartera> CAR_Cartera { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_DetalleIngreso> TES_DetalleIngreso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_IngresosBancoDet> TES_IngresosBancoDet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_NotasDetalle> TES_NotasDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_TrasladoDet> TES_TrasladoDet { get; set; }

        public virtual TES_GrupoConceptos TES_GrupoConceptos { get; set; }
    }
}
