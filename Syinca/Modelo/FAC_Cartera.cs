namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_Cartera
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FAC_Cartera()
        {
            CXP_CruceCuentas = new HashSet<CXP_CruceCuentas>();
            FAC_CarteraDetalle = new HashSet<FAC_CarteraDetalle>();
            TES_IngresosBancoCar = new HashSet<TES_IngresosBancoCar>();
            FAC_PreasientoCartera = new HashSet<FAC_PreasientoCartera>();
            FAC_SeguimientoCartera = new HashSet<FAC_SeguimientoCartera>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string idOrigen { get; set; }

        [Required]
        [StringLength(150)]
        public string NomOrigen { get; set; }

        public long Tercero { get; set; }

        public DateTime Fecha_ini { get; set; }

        public DateTime Fecha_fin { get; set; }

        public int Dias { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorMora { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorInteres { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorComision { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorSeguro { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Required]
        [StringLength(20)]
        public string CuentaContable { get; set; }

        [Required]
        [StringLength(12)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string CentroCosto { get; set; }

        public int NoCuotas { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorBase { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorInteres { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorComision { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorSeguro { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Saldo { get; set; }

        public long IdIngreso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXP_CruceCuentas> CXP_CruceCuentas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_CarteraDetalle> FAC_CarteraDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_IngresosBancoCar> TES_IngresosBancoCar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_PreasientoCartera> FAC_PreasientoCartera { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_SeguimientoCartera> FAC_SeguimientoCartera { get; set; }
    }
}
