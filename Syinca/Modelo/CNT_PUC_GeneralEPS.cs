namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_PUC_GeneralEPS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNT_PUC_GeneralEPS()
        {
            CNT_AsientoDetalleEPS = new HashSet<CNT_AsientoDetalleEPS>();
            CNT_AsientoDetalleEPS1 = new HashSet<CNT_AsientoDetalleEPS>();
            CNT_PreasientoEPS = new HashSet<CNT_PreasientoEPS>();
        }

        [Key]
        [StringLength(20)]
        public string Codigo_Contable { get; set; }

        [Required]
        [StringLength(20)]
        public string Sumariza { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre_Cuenta { get; set; }

        [Required]
        [StringLength(10)]
        public string Naturaleza { get; set; }

        [Required]
        [StringLength(10)]
        public string Tipo_cuenta { get; set; }

        public int Nivel { get; set; }

        [Required]
        [StringLength(20)]
        public string Cuenta { get; set; }

        [Required]
        [StringLength(30)]
        public string Clase_Cuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoDisponible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoDetalleEPS> CNT_AsientoDetalleEPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoDetalleEPS> CNT_AsientoDetalleEPS1 { get; set; }

        public virtual CNT_ConceptoExogena CNT_ConceptoExogena { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_PreasientoEPS> CNT_PreasientoEPS { get; set; }
    }
}
