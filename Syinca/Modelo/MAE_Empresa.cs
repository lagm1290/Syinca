namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAE_Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAE_Empresa()
        {
            MAE_Subcentro = new HashSet<MAE_Subcentro>();
        }

        [Key]
        [StringLength(50)]
        public string NIT { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(150)]
        public string Direccion { get; set; }

        [StringLength(150)]
        public string Telefono { get; set; }

        [StringLength(150)]
        public string Correo { get; set; }

        [StringLength(50)]
        public string Id_Representante { get; set; }

        [StringLength(150)]
        public string Nom_Representante { get; set; }

        public int Nivel_Cotizacion { get; set; }

        public int Rango_Inicial { get; set; }

        public int Rango_Final { get; set; }

        public int Nivel_Subdireccion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ComiteCompras { get; set; }

        public DateTime FeMora { get; set; }

        [Required]
        [StringLength(250)]
        public string Contador { get; set; }

        [Required]
        [StringLength(50)]
        public string TpContador { get; set; }

        [Required]
        [StringLength(250)]
        public string RevisorFis { get; set; }

        [Required]
        [StringLength(50)]
        public string TpRevisor { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Logo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAE_Subcentro> MAE_Subcentro { get; set; }
    }
}
