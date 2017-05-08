namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAE_AE_Division
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAE_AE_Division()
        {
            MAE_AE_Division_sub = new HashSet<MAE_AE_Division_sub>();
        }

        [StringLength(2)]
        public string id { get; set; }

        [StringLength(1)]
        public string Seccion { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public virtual MAE_AE_Seccion MAE_AE_Seccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAE_AE_Division_sub> MAE_AE_Division_sub { get; set; }
    }
}
