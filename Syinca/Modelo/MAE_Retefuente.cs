namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAE_Retefuente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAE_Retefuente()
        {
            BYS_RetencionCaja = new HashSet<BYS_RetencionCaja>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorUVT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UVT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Base { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Tarifa { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public int Anio { get; set; }

        public bool iva { get; set; }

        [Required]
        [StringLength(50)]
        public string Calculo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorIVA { get; set; }

        public int Codigo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_RetencionCaja> BYS_RetencionCaja { get; set; }
    }
}
