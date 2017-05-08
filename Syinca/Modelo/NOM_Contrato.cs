namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NOM_Contrato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NOM_Contrato()
        {
            NOM_DistribucionContrato = new HashSet<NOM_DistribucionContrato>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public long Tercero { get; set; }

        public int TipoContrato { get; set; }

        public int Cargo { get; set; }

        public DateTime FeInicio { get; set; }

        public DateTime? FeFin { get; set; }

        [Required]
        [StringLength(50)]
        public string NoCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Banco { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Salario { get; set; }

        public long Pension { get; set; }

        public long EPS { get; set; }

        public long ARL { get; set; }

        public long Caja { get; set; }

        public virtual NOM_Cargo NOM_Cargo { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }

        public virtual TER_Tercero TER_Tercero1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_DistribucionContrato> NOM_DistribucionContrato { get; set; }

        public virtual TER_Tercero TER_Tercero2 { get; set; }

        public virtual TER_Tercero TER_Tercero3 { get; set; }

        public virtual TER_Tercero TER_Tercero4 { get; set; }

        public virtual NOM_TipoContrato NOM_TipoContrato { get; set; }
    }
}
