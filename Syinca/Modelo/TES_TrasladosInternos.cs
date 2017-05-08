namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_TrasladosInternos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TES_TrasladosInternos()
        {
            TES_TrasladoInternoDet = new HashSet<TES_TrasladoInternoDet>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string NoAprobacion { get; set; }

        public DateTime FeCreacion { get; set; }

        public DateTime FeDocumento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(250)]
        public string ValorLetras { get; set; }

        [StringLength(250)]
        public string Detalle { get; set; }

        public int CuentaBancarias { get; set; }

        public int CCosto { get; set; }

        public long Tercero { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }

        public virtual TES_CuentasBancarias TES_CuentasBancarias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_TrasladoInternoDet> TES_TrasladoInternoDet { get; set; }
    }
}
