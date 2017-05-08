namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Linea_Credito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRE_Linea_Credito()
        {
            CRE_AsientoLinea = new HashSet<CRE_AsientoLinea>();
            CRE_Requisito_Linea = new HashSet<CRE_Requisito_Linea>();
            CRE_Solicitud_Credito = new HashSet<CRE_Solicitud_Credito>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string Linea { get; set; }

        [Required]
        [StringLength(50)]
        public string Modalidad_Recaudo { get; set; }

        [Required]
        [StringLength(50)]
        public string Categoria { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Monto_Maximo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Plazo_Maximo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Interes_Mensual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Tasa_EA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Interes_Mora { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Seguro { get; set; }

        public int DiaCorte { get; set; }

        public int DiasGavela { get; set; }

        public int DiaFactura { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorComision { get; set; }

        [Required]
        [StringLength(50)]
        public string Indicador { get; set; }

        [StringLength(50)]
        public string ModalidadSuper { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_AsientoLinea> CRE_AsientoLinea { get; set; }

        public virtual CRE_Categoria CRE_Categoria { get; set; }

        public virtual CRE_Linea CRE_Linea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Requisito_Linea> CRE_Requisito_Linea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Solicitud_Credito> CRE_Solicitud_Credito { get; set; }

        public virtual CRE_Modalidad_Recaudo CRE_Modalidad_Recaudo { get; set; }
    }
}
