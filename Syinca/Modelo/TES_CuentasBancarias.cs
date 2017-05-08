namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_CuentasBancarias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TES_CuentasBancarias()
        {
            CNT_Conciliacion = new HashSet<CNT_Conciliacion>();
            TES_Egreso = new HashSet<TES_Egreso>();
            TES_IngresosBancos = new HashSet<TES_IngresosBancos>();
            TES_Notas = new HashSet<TES_Notas>();
            TES_Traslados = new HashSet<TES_Traslados>();
            TES_TrasladosInternos = new HashSet<TES_TrasladosInternos>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Banco { get; set; }

        [Required]
        [StringLength(50)]
        public string Ciudad { get; set; }

        [Required]
        [StringLength(150)]
        public string Sucursal { get; set; }

        [Required]
        [StringLength(70)]
        public string NoCuenta { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

        [StringLength(100)]
        public string Telefono { get; set; }

        [StringLength(100)]
        public string Contacto { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime FeApertura { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoCuenta { get; set; }

        [Required]
        [StringLength(250)]
        public string Destinacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Saldo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_Conciliacion> CNT_Conciliacion { get; set; }

        public virtual MAE_Ciudad MAE_Ciudad { get; set; }

        public virtual TES_Bancos TES_Bancos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_Egreso> TES_Egreso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_IngresosBancos> TES_IngresosBancos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_Notas> TES_Notas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_Traslados> TES_Traslados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_TrasladosInternos> TES_TrasladosInternos { get; set; }
    }
}
