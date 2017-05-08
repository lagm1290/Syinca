namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Solicitud_Credito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRE_Solicitud_Credito()
        {
            CRE_Amortizacion = new HashSet<CRE_Amortizacion>();
            CRE_Anexos = new HashSet<CRE_Anexos>();
            CRE_Beneficiarios = new HashSet<CRE_Beneficiarios>();
            CRE_Bienes_Solicitud = new HashSet<CRE_Bienes_Solicitud>();
            CRE_CreditosSuperDet = new HashSet<CRE_CreditosSuperDet>();
            CRE_Datos_Financieros = new HashSet<CRE_Datos_Financieros>();
            CRE_Enfermedad_Padecida = new HashSet<CRE_Enfermedad_Padecida>();
            CRE_ProcesoCredito = new HashSet<CRE_ProcesoCredito>();
            CRE_RecaudoCredito = new HashSet<CRE_RecaudoCredito>();
            CRE_Referencia = new HashSet<CRE_Referencia>();
            CRE_Requisito_Solicitud = new HashSet<CRE_Requisito_Solicitud>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Solicitud { get; set; }

        public long Persona { get; set; }

        public long? Conyugue { get; set; }

        public int Linea_Credito { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime Fe_Registro { get; set; }

        public DateTime? Fe_Verificacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor_Solicitado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor_Aprobado { get; set; }

        [Required]
        [StringLength(50)]
        public string Cuenta_Bancaria { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo_Cuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Banco { get; set; }

        public DateTime Fe_Inicio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Por_Intere { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Por_Mora { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Por_Comision { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Por_Seguro { get; set; }

        public int Cuotas { get; set; }

        public decimal? HNit { get; set; }

        [StringLength(150)]
        public string HRazonSocial { get; set; }

        [StringLength(50)]
        public string HCategoria { get; set; }

        public int? HTiempoAfiliacion { get; set; }

        public decimal? HIdTransaccion { get; set; }

        [Required]
        [StringLength(50)]
        public string Ciudad { get; set; }

        public long? Coodeudor { get; set; }

        [StringLength(250)]
        public string Observacion { get; set; }

        public long IdEgreso { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GastoAdministrativo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Amortizacion> CRE_Amortizacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Anexos> CRE_Anexos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Beneficiarios> CRE_Beneficiarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Bienes_Solicitud> CRE_Bienes_Solicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_CreditosSuperDet> CRE_CreditosSuperDet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Datos_Financieros> CRE_Datos_Financieros { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Enfermedad_Padecida> CRE_Enfermedad_Padecida { get; set; }

        public virtual CRE_Linea_Credito CRE_Linea_Credito { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_ProcesoCredito> CRE_ProcesoCredito { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_RecaudoCredito> CRE_RecaudoCredito { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Referencia> CRE_Referencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Requisito_Solicitud> CRE_Requisito_Solicitud { get; set; }

        public virtual MAE_Ciudad MAE_Ciudad { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }

        public virtual TES_Bancos TES_Bancos { get; set; }

        public virtual TER_Tercero TER_Tercero1 { get; set; }
    }
}
