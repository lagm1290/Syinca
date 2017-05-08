namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAR_AjusteCreditoDet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAR_AjusteCreditoDet()
        {
            CAR_BeneficiariosAjuste = new HashSet<CAR_BeneficiariosAjuste>();
        }

        public long id { get; set; }

        public long AjusteCredito { get; set; }

        public long idCartera { get; set; }

        public int NoCredito { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrAjuste { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public DateTime FeCreacion { get; set; }

        public DateTime FeAplicacion { get; set; }

        [StringLength(250)]
        public string Nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAR_BeneficiariosAjuste> CAR_BeneficiariosAjuste { get; set; }

        public virtual CAR_AjustesCredito CAR_AjustesCredito { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
