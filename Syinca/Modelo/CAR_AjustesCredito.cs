namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAR_AjustesCredito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAR_AjustesCredito()
        {
            CAR_AjusteCreditoDet = new HashSet<CAR_AjusteCreditoDet>();
        }

        public long id { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime FeCreacion { get; set; }

        public DateTime FeCierre { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        public int TipoAjuste { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAR_AjusteCreditoDet> CAR_AjusteCreditoDet { get; set; }
    }
}
