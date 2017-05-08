namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_Conciliacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TES_Conciliacion()
        {
            TES_EstractoBancario = new HashSet<TES_EstractoBancario>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ConciliacionID { get; set; }

        public long ConciliacionNumero { get; set; }

        [Required]
        [StringLength(50)]
        public string ExtractoNumero { get; set; }

        public DateTime FechaExtracto { get; set; }

        public int CuentaBancoId { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoInicial { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TotalDB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TotalCR { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal SaldoFinal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_EstractoBancario> TES_EstractoBancario { get; set; }
    }
}
