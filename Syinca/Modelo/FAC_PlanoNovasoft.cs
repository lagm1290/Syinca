namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_PlanoNovasoft
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FAC_PlanoNovasoft()
        {
            FAC_PlanoNovasoftDetalle = new HashSet<FAC_PlanoNovasoftDetalle>();
        }

        public long id { get; set; }

        public DateTime Fecha { get; set; }

        public int NoIni { get; set; }

        public int NoFin { get; set; }

        public int Periodo { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string CCosto { get; set; }

        [Required]
        [StringLength(150)]
        public string Ruta { get; set; }

        [Required]
        [StringLength(50)]
        public string Secuencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_PlanoNovasoftDetalle> FAC_PlanoNovasoftDetalle { get; set; }
    }
}
