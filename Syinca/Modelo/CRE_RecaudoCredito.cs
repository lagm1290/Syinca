namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_RecaudoCredito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRE_RecaudoCredito()
        {
            CRE_RecaudoXamortizacion = new HashSet<CRE_RecaudoXamortizacion>();
        }

        public int id { get; set; }

        public int Numero { get; set; }

        public int SolicitudCredito { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoRecaudo { get; set; }

        [Required]
        [StringLength(50)]
        public string ModoRecaudo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        public int UsuarioCentro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_RecaudoXamortizacion> CRE_RecaudoXamortizacion { get; set; }

        public virtual CRE_Solicitud_Credito CRE_Solicitud_Credito { get; set; }

        public virtual MAE_Usuario_Centro_Costo MAE_Usuario_Centro_Costo { get; set; }
    }
}
