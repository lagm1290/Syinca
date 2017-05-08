namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_IngresosBancoDet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TES_IngresosBancoDet()
        {
            TES_IngresosBancoCar = new HashSet<TES_IngresosBancoCar>();
        }

        public long id { get; set; }

        public long IngresosBancarios { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        public DateTime Fecha { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Deposito { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [StringLength(250)]
        public string Oservacion { get; set; }

        public int CentroCosto { get; set; }

        [StringLength(50)]
        public string idExterno { get; set; }

        [Required]
        [StringLength(50)]
        public string Pendiente { get; set; }

        public long Cartera { get; set; }

        [Required]
        [StringLength(50)]
        public string FormaRecaudo { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero { get; set; }

        [StringLength(50)]
        public string Banco { get; set; }

        [StringLength(50)]
        public string CtaBancaria { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }

        public virtual TES_Concepto TES_Concepto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_IngresosBancoCar> TES_IngresosBancoCar { get; set; }

        public virtual TES_IngresosBancos TES_IngresosBancos { get; set; }
    }
}
