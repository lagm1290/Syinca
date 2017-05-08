namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_ContratoSuperCab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SER_ContratoSuperCab()
        {
            SER_ContratoSuperDet = new HashSet<SER_ContratoSuperDet>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime FeINI { get; set; }

        public DateTime FeFIN { get; set; }

        public int NoSalarios { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SMMLV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_ContratoSuperDet> SER_ContratoSuperDet { get; set; }
    }
}
