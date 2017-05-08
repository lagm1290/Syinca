namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_LibroAuxiliar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TES_LibroAuxiliar()
        {
            CNT_DetalleConciliacion = new HashSet<CNT_DetalleConciliacion>();
        }

        public long Id { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(20)]
        public string CtaContable { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCuenta { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorDB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorCR { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(100)]
        public string TipoDocumento { get; set; }

        public long Conciliacion { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public int? Partida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_DetalleConciliacion> CNT_DetalleConciliacion { get; set; }
    }
}
