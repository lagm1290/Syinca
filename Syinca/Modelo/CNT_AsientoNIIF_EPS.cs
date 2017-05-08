namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_AsientoNIIF_EPS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNT_AsientoNIIF_EPS()
        {
            CNT_AsientoDetalleNIIF_EPS = new HashSet<CNT_AsientoDetalleNIIF_EPS>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(2)]
        public string Aprobado { get; set; }

        public long NoAsiento { get; set; }

        [Required]
        [StringLength(100)]
        public string TipoDocumento { get; set; }

        [Required]
        [StringLength(50)]
        public string NoDocumento { get; set; }

        [Required]
        [StringLength(50)]
        public string NoExterno { get; set; }

        public DateTime FeCreacion { get; set; }

        public int Periodo { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuarioCreador { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuarioAprobacion { get; set; }

        public DateTime FeAprobacion { get; set; }

        [StringLength(150)]
        public string Observacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoDetalleNIIF_EPS> CNT_AsientoDetalleNIIF_EPS { get; set; }

        public virtual CNT_Periodo CNT_Periodo { get; set; }

        public virtual CNT_TipoDocumento CNT_TipoDocumento { get; set; }
    }
}
