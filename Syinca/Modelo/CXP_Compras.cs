namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CXP_Compras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CXP_Compras()
        {
            CXP_AnticiposCompra = new HashSet<CXP_AnticiposCompra>();
            CXP_ComprasDetalle = new HashSet<CXP_ComprasDetalle>();
            CXP_PlanPago = new HashSet<CXP_PlanPago>();
            CXP_Prorrateo = new HashSet<CXP_Prorrateo>();
            CXP_RetencionCompra = new HashSet<CXP_RetencionCompra>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string NoExterno { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public long Tercero { get; set; }

        public DateTime Fe_Creacion { get; set; }

        public DateTime Fe_Factura { get; set; }

        public DateTime Fe_Vencimiento { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string idExterno { get; set; }

        [StringLength(150)]
        public string Tabla { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        [Required]
        [StringLength(2)]
        public string Anticipo { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoFactura { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoTercero { get; set; }

        [Required]
        [StringLength(2)]
        public string Diferir { get; set; }

        public int? Tiempo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Saldo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXP_AnticiposCompra> CXP_AnticiposCompra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXP_ComprasDetalle> CXP_ComprasDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXP_PlanPago> CXP_PlanPago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXP_Prorrateo> CXP_Prorrateo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXP_RetencionCompra> CXP_RetencionCompra { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
