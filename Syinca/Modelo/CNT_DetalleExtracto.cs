namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_DetalleExtracto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNT_DetalleExtracto()
        {
            CNT_DetalleConciliacion = new HashSet<CNT_DetalleConciliacion>();
        }

        public long Id { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(250)]
        public string Concepto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Saldo { get; set; }

        public long Partida { get; set; }

        public long? Conciliacion { get; set; }

        public virtual CNT_Conciliacion CNT_Conciliacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_DetalleConciliacion> CNT_DetalleConciliacion { get; set; }

        public virtual CNT_Partidas CNT_Partidas { get; set; }
    }
}
