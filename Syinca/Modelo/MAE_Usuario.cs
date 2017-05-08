namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAE_Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAE_Usuario()
        {
            BYS_CajaUsuario = new HashSet<BYS_CajaUsuario>();
            BYS_CajaUsuario1 = new HashSet<BYS_CajaUsuario>();
            BYS_FlujoAprobacion = new HashSet<BYS_FlujoAprobacion>();
            CNT_UsuariosPermisos = new HashSet<CNT_UsuariosPermisos>();
            MAE_Permisos = new HashSet<MAE_Permisos>();
            MAE_Usuario_Centro_Costo = new HashSet<MAE_Usuario_Centro_Costo>();
        }

        [Key]
        [StringLength(12)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(70)]
        public string Nombre { get; set; }

        [StringLength(70)]
        public string Apellido { get; set; }

        [StringLength(150)]
        public string Direccion { get; set; }

        [StringLength(150)]
        public string Telefono { get; set; }

        [StringLength(150)]
        public string Correo { get; set; }

        [StringLength(50)]
        public string Identificacion { get; set; }

        [StringLength(50)]
        public string CodCargo { get; set; }

        [StringLength(150)]
        public string NomCargo { get; set; }

        public DateTime FeClave { get; set; }

        [Column(TypeName = "image")]
        public byte[] Foto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_CajaUsuario> BYS_CajaUsuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_CajaUsuario> BYS_CajaUsuario1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_FlujoAprobacion> BYS_FlujoAprobacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_UsuariosPermisos> CNT_UsuariosPermisos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAE_Permisos> MAE_Permisos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAE_Usuario_Centro_Costo> MAE_Usuario_Centro_Costo { get; set; }
    }
}
