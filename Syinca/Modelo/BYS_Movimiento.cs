namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_Movimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BYS_Movimiento()
        {
            BYS_MovimientoDetalle = new HashSet<BYS_MovimientoDetalle>();
            BYS_RetencionCaja = new HashSet<BYS_RetencionCaja>();
        }

        public long id { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string NoFactura { get; set; }

        public int CentroCosto { get; set; }

        public int Presupuesto { get; set; }

        public DateTime FeCreacion { get; set; }

        public DateTime FeLegalizacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public int Periodo { get; set; }

        [Required]
        [StringLength(50)]
        public string Caja { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(150)]
        public string Recibe { get; set; }

        public long Tercero { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TotalIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TotalRetencion { get; set; }

        public decimal Total { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TotalEstimado { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public int Cierre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalAdicion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalDeduccion { get; set; }

        public virtual BYS_Caja BYS_Caja { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_MovimientoDetalle> BYS_MovimientoDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_RetencionCaja> BYS_RetencionCaja { get; set; }

        public virtual PRE_Presupuesto PRE_Presupuesto { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
