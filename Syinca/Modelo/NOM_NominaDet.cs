namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NOM_NominaDet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NOM_NominaDet()
        {
            NOM_Colilla = new HashSet<NOM_Colilla>();
        }

        public long id { get; set; }

        public long Nomina { get; set; }

        public long Tercero { get; set; }

        public long Contrato { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Sueldo { get; set; }

        public int NoDias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_Colilla> NOM_Colilla { get; set; }

        public virtual NOM_Nomina NOM_Nomina { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
