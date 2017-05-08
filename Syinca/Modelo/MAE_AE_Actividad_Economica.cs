namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAE_AE_Actividad_Economica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAE_AE_Actividad_Economica()
        {
            TER_actividad_economica = new HashSet<TER_actividad_economica>();
        }

        [StringLength(50)]
        public string id { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(3)]
        public string Division_Sub { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Retencion { get; set; }

        public virtual MAE_AE_Division_sub MAE_AE_Division_sub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_actividad_economica> TER_actividad_economica { get; set; }
    }
}
