namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_Bancos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TES_Bancos()
        {
            CRE_Solicitud_Credito = new HashSet<CRE_Solicitud_Credito>();
            TES_CuentasBancarias = new HashSet<TES_CuentasBancarias>();
        }

        [StringLength(50)]
        public string id { get; set; }

        [Required]
        [StringLength(2)]
        public string CodigoSector { get; set; }

        [Required]
        [StringLength(3)]
        public string CodigoEntidad { get; set; }

        [Required]
        [StringLength(150)]
        public string NombreBanco { get; set; }

        public long Tercero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Solicitud_Credito> CRE_Solicitud_Credito { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_CuentasBancarias> TES_CuentasBancarias { get; set; }
    }
}
