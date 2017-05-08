namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_SolicitudCDP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRE_SolicitudCDP()
        {
            PRE_FlujoCDP = new HashSet<PRE_FlujoCDP>();
            PRE_RP = new HashSet<PRE_RP>();
        }

        public int ID { get; set; }

        public DateTime Fecha { get; set; }

        public int SubCentro { get; set; }

        public int Presupuesto { get; set; }

        [Required]
        [StringLength(20)]
        public string NumeroSolicitud { get; set; }

        public decimal Valor { get; set; }

        [StringLength(250)]
        public string Observacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string Impresion { get; set; }

        public int Flujo { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_FlujoCDP> PRE_FlujoCDP { get; set; }

        public virtual PRE_Presupuesto PRE_Presupuesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_RP> PRE_RP { get; set; }
    }
}
