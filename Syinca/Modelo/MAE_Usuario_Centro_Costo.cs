namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAE_Usuario_Centro_Costo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAE_Usuario_Centro_Costo()
        {
            CRE_RecaudoCredito = new HashSet<CRE_RecaudoCredito>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(12)]
        public string Usuario { get; set; }

        public int Centro_Costo { get; set; }

        public DateTime Fe_Inicio { get; set; }

        public DateTime? Fe_Fin { get; set; }

        public bool Activo { get; set; }

        public int Nivel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_RecaudoCredito> CRE_RecaudoCredito { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        public virtual MAE_Usuario MAE_Usuario { get; set; }
    }
}
