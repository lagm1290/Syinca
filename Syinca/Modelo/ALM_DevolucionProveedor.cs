namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_DevolucionProveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALM_DevolucionProveedor()
        {
            ALM_DPDetalle = new HashSet<ALM_DPDetalle>();
            ALM_RetencionDP = new HashSet<ALM_RetencionDP>();
        }

        public long id { get; set; }

        public int Numero { get; set; }

        public long NotaEntrada { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_DPDetalle> ALM_DPDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_RetencionDP> ALM_RetencionDP { get; set; }

        public virtual ALM_NotaEntrada ALM_NotaEntrada { get; set; }
    }
}
