namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_Egreso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TES_Egreso()
        {
            TES_DetalleEgreso = new HashSet<TES_DetalleEgreso>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero { get; set; }

        [StringLength(20)]
        public string Prefijo { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(12)]
        public string Usuario { get; set; }

        public int CuentaCB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(250)]
        public string ValorLetras { get; set; }

        public DateTime FeCreacion { get; set; }

        public DateTime FeDocumento { get; set; }

        [StringLength(250)]
        public string Detalle { get; set; }

        public int Periodo { get; set; }

        public long NoComprobante { get; set; }

        [StringLength(50)]
        public string CuentaDestino { get; set; }

        [StringLength(50)]
        public string NoCtaDestino { get; set; }

        public long TerceroCheque { get; set; }

        public virtual CNT_Periodo CNT_Periodo { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }

        public virtual TES_CuentasBancarias TES_CuentasBancarias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_DetalleEgreso> TES_DetalleEgreso { get; set; }
    }
}