namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_Presupuesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRE_Presupuesto()
        {
            BYS_DistribucionSolicitud = new HashSet<BYS_DistribucionSolicitud>();
            BYS_Movimiento = new HashSet<BYS_Movimiento>();
            CXP_Prorrateo = new HashSet<CXP_Prorrateo>();
            PRE_Detalle_Presupuesto = new HashSet<PRE_Detalle_Presupuesto>();
            PRE_Ejecucion = new HashSet<PRE_Ejecucion>();
            PRE_SolicitudCDP = new HashSet<PRE_SolicitudCDP>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo_Contable { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        public int Anio { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo_Presupuesto { get; set; }

        public int Centro_Costo { get; set; }

        public DateTime Fe_Preparacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Total { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Adicion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Descuentos { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Presupuestado { get; set; }

        public decimal Reservado { get; set; }

        public decimal Ejecutado { get; set; }

        public decimal Disponible { get; set; }

        [Required]
        [StringLength(4)]
        public string Grupo { get; set; }

        [Required]
        [StringLength(2)]
        public string Bloqueado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_DistribucionSolicitud> BYS_DistribucionSolicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_Movimiento> BYS_Movimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXP_Prorrateo> CXP_Prorrateo { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_Detalle_Presupuesto> PRE_Detalle_Presupuesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_Ejecucion> PRE_Ejecucion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_SolicitudCDP> PRE_SolicitudCDP { get; set; }
    }
}
