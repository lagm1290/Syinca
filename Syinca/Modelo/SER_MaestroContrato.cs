namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_MaestroContrato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SER_MaestroContrato()
        {
            SER_Contratos = new HashSet<SER_Contratos>();
        }

        [Key]
        [StringLength(50)]
        public string NoContrato { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public long Proveedor { get; set; }

        public DateTime FeCreacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Required]
        [StringLength(50)]
        public string Modalidad { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoContrato { get; set; }

        [StringLength(10)]
        public string Clase { get; set; }

        public virtual SER_Concepto SER_Concepto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_Contratos> SER_Contratos { get; set; }

        public virtual SER_Modalidad SER_Modalidad { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }

        public virtual SER_TipoContratos SER_TipoContratos { get; set; }
    }
}
