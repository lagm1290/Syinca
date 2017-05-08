namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAR_Cartera
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAR_Cartera()
        {
            CNT_CruceDetalle = new HashSet<CNT_CruceDetalle>();
            CAR_FlujoCarteraDet = new HashSet<CAR_FlujoCarteraDet>();
            CAR_Movimiento = new HashSet<CAR_Movimiento>();
            CAR_Seguimiento = new HashSet<CAR_Seguimiento>();
        }

        public long id { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string idOrigen { get; set; }

        [Required]
        [StringLength(100)]
        public string NomOrigen { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime FeCompromiso { get; set; }

        public DateTime FeVencimiento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrGastos { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrMora { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrIntereses { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrCapital { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SlGastos { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SlMora { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SlIntereses { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SlCapital { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoTotal { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        public int CCosto { get; set; }

        [Required]
        [StringLength(50)]
        public string NoExterno { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        public long? idIngresos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_CruceDetalle> CNT_CruceDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAR_FlujoCarteraDet> CAR_FlujoCarteraDet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAR_Movimiento> CAR_Movimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAR_Seguimiento> CAR_Seguimiento { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        public virtual TES_Concepto TES_Concepto { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
