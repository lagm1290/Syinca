namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_FormaRecaudo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FAC_FormaRecaudo()
        {
            FAC_MedioRecaudoVenta = new HashSet<FAC_MedioRecaudoVenta>();
        }

        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string CentroCosto { get; set; }

        public int CuentasCB { get; set; }

        [Required]
        [StringLength(2)]
        public string Cartera { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Interes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Mora { get; set; }

        public int DiaCorte { get; set; }

        public int DiasGavela { get; set; }

        public int DiaFacturacion { get; set; }

        public int Plazo { get; set; }

        public virtual FAC_Concepto FAC_Concepto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_MedioRecaudoVenta> FAC_MedioRecaudoVenta { get; set; }
    }
}
