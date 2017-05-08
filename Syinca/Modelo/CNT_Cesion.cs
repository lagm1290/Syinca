namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_Cesion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNT_Cesion()
        {
            CNT_CesionDetalle = new HashSet<CNT_CesionDetalle>();
        }

        public long id { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(250)]
        public string Observacion { get; set; }

        public long TerOrigen { get; set; }

        public long TerDestino { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_CesionDetalle> CNT_CesionDetalle { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }

        public virtual TER_Tercero TER_Tercero1 { get; set; }
    }
}
