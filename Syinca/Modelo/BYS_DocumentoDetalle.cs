namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_DocumentoDetalle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BYS_DocumentoDetalle()
        {
            BYS_DetDocDetalle = new HashSet<BYS_DetDocDetalle>();
            BYS_Distribucion = new HashSet<BYS_Distribucion>();
        }

        public int id { get; set; }

        public long Documento { get; set; }

        public long Referencia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorUnitario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Descuento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorTotal { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoCantidad { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public virtual ALM_Referencia ALM_Referencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_DetDocDetalle> BYS_DetDocDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_Distribucion> BYS_Distribucion { get; set; }

        public virtual BYS_Documento BYS_Documento { get; set; }
    }
}
