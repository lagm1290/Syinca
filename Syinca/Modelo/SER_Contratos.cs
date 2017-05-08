namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_Contratos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SER_Contratos()
        {
            SER_FuenteContrato = new HashSet<SER_FuenteContrato>();
            SER_PlanPagos = new HashSet<SER_PlanPagos>();
            SER_ProrrateoContratos = new HashSet<SER_ProrrateoContratos>();
            SER_Requerimientos = new HashSet<SER_Requerimientos>();
            SER_Retencion = new HashSet<SER_Retencion>();
            SER_Seguimiento = new HashSet<SER_Seguimiento>();
            SER_TipoAporteContrato = new HashSet<SER_TipoAporteContrato>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string NoContrato { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime FeCreacion { get; set; }

        public DateTime FeInicio { get; set; }

        public DateTime? FeFin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorContrato { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PjAnticipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorAnticipo { get; set; }

        public int NoCuotas { get; set; }

        [StringLength(150)]
        public string Supervisor { get; set; }

        [Required]
        [StringLength(150)]
        public string Interventor { get; set; }

        [Required]
        [StringLength(250)]
        public string Objeto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(100)]
        public string Firma { get; set; }

        public int NoDias { get; set; }

        public long idSolicitudServicio { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Clase { get; set; }

        [StringLength(50)]
        public string NoActaCD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_FuenteContrato> SER_FuenteContrato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_PlanPagos> SER_PlanPagos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_ProrrateoContratos> SER_ProrrateoContratos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_Requerimientos> SER_Requerimientos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_Retencion> SER_Retencion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_Seguimiento> SER_Seguimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_TipoAporteContrato> SER_TipoAporteContrato { get; set; }

        public virtual SER_Firma SER_Firma { get; set; }

        public virtual SER_MaestroContrato SER_MaestroContrato { get; set; }
    }
}
