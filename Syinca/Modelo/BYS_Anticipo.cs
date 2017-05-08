namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_Anticipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BYS_Anticipo()
        {
            BYS_FlujoAnticipo = new HashSet<BYS_FlujoAnticipo>();
        }

        public long id { get; set; }

        public long Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoAnticipo { get; set; }

        public DateTime Fecha { get; set; }

        public int Flujo { get; set; }

        public long OrdenCompra { get; set; }

        public long Contratos { get; set; }

        public long OPS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorValor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorTotal { get; set; }

        [Required]
        [StringLength(50)]
        public string NoCheque { get; set; }

        [Required]
        [StringLength(50)]
        public string NoTransaccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_FlujoAnticipo> BYS_FlujoAnticipo { get; set; }

        public virtual BYS_TipoAnticipo BYS_TipoAnticipo { get; set; }
    }
}
