namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_IngresosBancos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TES_IngresosBancos()
        {
            TES_IngresosBancoDet = new HashSet<TES_IngresosBancoDet>();
        }

        public long id { get; set; }

        public int Banco { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public long Numero { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(250)]
        public string ValorLetras { get; set; }

        public DateTime FeCreacion { get; set; }

        public DateTime FeDocumento { get; set; }

        public int Periodo { get; set; }

        [Required]
        [StringLength(12)]
        public string Usuario { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(2)]
        public string Automatico { get; set; }

        [Required]
        [StringLength(50)]
        public string Proceso { get; set; }

        [Required]
        [StringLength(50)]
        public string IdExterno { get; set; }

        [Required]
        [StringLength(50)]
        public string Oigen { get; set; }

        public DateTime? FeConsignacion { get; set; }

        public virtual TES_CuentasBancarias TES_CuentasBancarias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_IngresosBancoDet> TES_IngresosBancoDet { get; set; }
    }
}
