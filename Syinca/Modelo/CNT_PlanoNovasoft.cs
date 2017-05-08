namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_PlanoNovasoft
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNT_PlanoNovasoft()
        {
            CNT_PlanoNovasoftDetalle = new HashSet<CNT_PlanoNovasoftDetalle>();
        }

        public long id { get; set; }

        public DateTime Fecha { get; set; }

        public int Periodo { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(100)]
        public string Documento { get; set; }

        [Required]
        [StringLength(50)]
        public string NoExterno { get; set; }

        [Required]
        [StringLength(150)]
        public string Ruta { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoNova { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoTXT { get; set; }

        [StringLength(50)]
        public string Prefijo { get; set; }

        public DateTime FechaHasta { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreArchivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_PlanoNovasoftDetalle> CNT_PlanoNovasoftDetalle { get; set; }
    }
}
