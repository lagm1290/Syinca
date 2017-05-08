namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_Rubro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRE_Rubro()
        {
            BYS_ClaseRubro = new HashSet<BYS_ClaseRubro>();
            CXP_Item = new HashSet<CXP_Item>();
            FAC_Servicio = new HashSet<FAC_Servicio>();
            SER_ProrrateoContratos = new HashSet<SER_ProrrateoContratos>();
        }

        [Key]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoPresupuesto { get; set; }

        [Required]
        [StringLength(20)]
        public string PlanCuenta { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoInversion { get; set; }

        [Required]
        [StringLength(50)]
        public string Grupo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_ClaseRubro> BYS_ClaseRubro { get; set; }

        public virtual CNT_PUC_General CNT_PUC_General { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXP_Item> CXP_Item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_Servicio> FAC_Servicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_ProrrateoContratos> SER_ProrrateoContratos { get; set; }

        public virtual PRE_TipoInversion PRE_TipoInversion { get; set; }

        public virtual PRE_Tipo_Presupuesto PRE_Tipo_Presupuesto { get; set; }
    }
}
