namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAE_AE_Division_sub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAE_AE_Division_sub()
        {
            MAE_AE_Actividad_Economica = new HashSet<MAE_AE_Actividad_Economica>();
        }

        [StringLength(3)]
        public string id { get; set; }

        [StringLength(2)]
        public string Division { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAE_AE_Actividad_Economica> MAE_AE_Actividad_Economica { get; set; }

        public virtual MAE_AE_Division MAE_AE_Division { get; set; }
    }
}
