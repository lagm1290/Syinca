namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_Ingresos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TES_Ingresos()
        {
            TES_DetalleIngreso = new HashSet<TES_DetalleIngreso>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public long Numero { get; set; }

        [Required]
        [StringLength(12)]
        public string Usuario { get; set; }

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

        public int Caja { get; set; }

        public long Tercero { get; set; }

        public virtual CNT_Periodo CNT_Periodo { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }

        public virtual TES_Cuentas_CB TES_Cuentas_CB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_DetalleIngreso> TES_DetalleIngreso { get; set; }
    }
}
