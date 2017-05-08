namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_NotaEntrada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALM_NotaEntrada()
        {
            ALM_DevolucionProveedor = new HashSet<ALM_DevolucionProveedor>();
            ALM_DistribucionNE = new HashSet<ALM_DistribucionNE>();
            ALM_NEDetalle = new HashSet<ALM_NEDetalle>();
            ALM_Retencion = new HashSet<ALM_Retencion>();
        }

        public long id { get; set; }

        public int Numero { get; set; }

        public long OrdenCompra { get; set; }

        public int CentroCosto { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string NoFactura { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrFactura { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Ajuste { get; set; }

        public DateTime FeFactura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_DevolucionProveedor> ALM_DevolucionProveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_DistribucionNE> ALM_DistribucionNE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_NEDetalle> ALM_NEDetalle { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        public virtual BYS_Documento BYS_Documento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_Retencion> ALM_Retencion { get; set; }
    }
}
