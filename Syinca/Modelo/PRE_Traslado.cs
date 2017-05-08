namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_Traslado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRE_Traslado()
        {
            PRE_TrasladoFin = new HashSet<PRE_TrasladoFin>();
            PRE_TrasladoOrigen = new HashSet<PRE_TrasladoOrigen>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo_presupuesto { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string CentroCosto { get; set; }

        [StringLength(150)]
        public string Observacion { get; set; }

        [StringLength(150)]
        public string Respuesta { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Adicion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Deduccion { get; set; }

        public int Presupuesto { get; set; }

        public virtual PRE_Tipo_Presupuesto PRE_Tipo_Presupuesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_TrasladoFin> PRE_TrasladoFin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_TrasladoOrigen> PRE_TrasladoOrigen { get; set; }
    }
}
