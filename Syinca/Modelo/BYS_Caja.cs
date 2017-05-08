namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_Caja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BYS_Caja()
        {
            BYS_CajaUsuario = new HashSet<BYS_CajaUsuario>();
            BYS_IngresosCaja = new HashSet<BYS_IngresosCaja>();
            BYS_Movimiento = new HashSet<BYS_Movimiento>();
            BYS_Mivimiento = new HashSet<BYS_Mivimiento>();
            BYS_CajaUsuario1 = new HashSet<BYS_CajaUsuario>();
        }

        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Saldo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TopeMaximo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TopeMinimo { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_CajaUsuario> BYS_CajaUsuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_IngresosCaja> BYS_IngresosCaja { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_Movimiento> BYS_Movimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_Mivimiento> BYS_Mivimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_CajaUsuario> BYS_CajaUsuario1 { get; set; }
    }
}
