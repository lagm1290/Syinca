namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AUX_Jefe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AUX_Jefe()
        {
            AUX_jefe_centro_costo = new HashSet<AUX_jefe_centro_costo>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(150)]
        public string Apellido { get; set; }

        [StringLength(150)]
        public string Direccion { get; set; }

        [StringLength(150)]
        public string Telefono { get; set; }

        [StringLength(150)]
        public string Correo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUX_jefe_centro_costo> AUX_jefe_centro_costo { get; set; }
    }
}
