namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_Documento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BYS_Documento()
        {
            ALM_NotaEntrada = new HashSet<ALM_NotaEntrada>();
            ALM_Remision = new HashSet<ALM_Remision>();
            BYS_SolicitudCotizacion = new HashSet<BYS_SolicitudCotizacion>();
            BYS_DocumentoDetalle = new HashSet<BYS_DocumentoDetalle>();
            BYS_RetencionOC = new HashSet<BYS_RetencionOC>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Clase { get; set; }

        public DateTime Fe_CreacionCot { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public long Proveedor { get; set; }

        [StringLength(250)]
        public string Detalle { get; set; }

        public DateTime? Fe_Envio { get; set; }

        public DateTime? Fe_Recibo { get; set; }

        public int NoCotizacion { get; set; }

        public int NoOrden { get; set; }

        public DateTime? Fe_CreacionOr { get; set; }

        public DateTime? Fe_Inico_Compra { get; set; }

        public DateTime? Fe_Fin_Compra { get; set; }

        public int? Bodega { get; set; }

        [Required]
        [StringLength(50)]
        public string CodComparacion { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoDocumento { get; set; }

        [Required]
        [StringLength(2)]
        public string Visto { get; set; }

        [Required]
        [StringLength(2)]
        public string Recibido { get; set; }

        [Required]
        [StringLength(2)]
        public string Anticipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_NotaEntrada> ALM_NotaEntrada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_Remision> ALM_Remision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_SolicitudCotizacion> BYS_SolicitudCotizacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_DocumentoDetalle> BYS_DocumentoDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_RetencionOC> BYS_RetencionOC { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
