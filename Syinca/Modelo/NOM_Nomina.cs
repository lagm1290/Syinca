namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NOM_Nomina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NOM_Nomina()
        {
            NOM_NominaDet = new HashSet<NOM_NominaDet>();
        }

        public long id { get; set; }

        public int Periodo { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoNomina { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(250)]
        public string Leyenda { get; set; }

        public int NoDias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_NominaDet> NOM_NominaDet { get; set; }

        public virtual NOM_TipoNomina NOM_TipoNomina { get; set; }
    }
}
