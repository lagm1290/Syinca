namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_PUC_NIIF_EPSC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNT_PUC_NIIF_EPSC()
        {
            CNT_AsientoDetalleNIIF_EPSC = new HashSet<CNT_AsientoDetalleNIIF_EPSC>();
        }

        [Key]
        [StringLength(20)]
        public string CodigoContable { get; set; }

        [Required]
        [StringLength(20)]
        public string Sumariza { get; set; }

        [Required]
        [StringLength(150)]
        public string NombreCuenta { get; set; }

        [Required]
        [StringLength(10)]
        public string Naturaleza { get; set; }

        [Required]
        [StringLength(10)]
        public string TipoCuenta { get; set; }

        public int Nivel { get; set; }

        [Required]
        [StringLength(20)]
        public string Cuenta { get; set; }

        [Required]
        [StringLength(30)]
        public string ClaseCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoDisponible { get; set; }

        [Required]
        [StringLength(50)]
        public string Seccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoDetalleNIIF_EPSC> CNT_AsientoDetalleNIIF_EPSC { get; set; }
    }
}
