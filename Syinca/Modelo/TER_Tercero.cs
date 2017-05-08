namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_Tercero
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TER_Tercero()
        {
            BYS_CotizacionServicio = new HashSet<BYS_CotizacionServicio>();
            BYS_Documento = new HashSet<BYS_Documento>();
            BYS_Movimiento = new HashSet<BYS_Movimiento>();
            CAR_AjusteCreditoDet = new HashSet<CAR_AjusteCreditoDet>();
            CAR_Cartera = new HashSet<CAR_Cartera>();
            CNT_AsientoDetalleEPS = new HashSet<CNT_AsientoDetalleEPS>();
            CNT_AsientoDetalleEPSC = new HashSet<CNT_AsientoDetalleEPSC>();
            CNT_AsientoDetalleNIIF = new HashSet<CNT_AsientoDetalleNIIF>();
            CNT_AsientoDetalleNIIF_EPS = new HashSet<CNT_AsientoDetalleNIIF_EPS>();
            CNT_AsientoDetalleNIIF_EPSC = new HashSet<CNT_AsientoDetalleNIIF_EPSC>();
            CNT_AsientoDetallePCGA = new HashSet<CNT_AsientoDetallePCGA>();
            CNT_Cesion = new HashSet<CNT_Cesion>();
            CNT_Cesion1 = new HashSet<CNT_Cesion>();
            CNT_Cruce = new HashSet<CNT_Cruce>();
            CRE_Solicitud_Credito = new HashSet<CRE_Solicitud_Credito>();
            CRE_Solicitud_Credito1 = new HashSet<CRE_Solicitud_Credito>();
            CXC_Ventas = new HashSet<CXC_Ventas>();
            CXP_Compras = new HashSet<CXP_Compras>();
            FAC_Factura = new HashSet<FAC_Factura>();
            FAC_MedioRecaudoVenta = new HashSet<FAC_MedioRecaudoVenta>();
            NOM_Contrato = new HashSet<NOM_Contrato>();
            NOM_Contrato1 = new HashSet<NOM_Contrato>();
            NOM_Contrato2 = new HashSet<NOM_Contrato>();
            NOM_Contrato3 = new HashSet<NOM_Contrato>();
            NOM_Contrato4 = new HashSet<NOM_Contrato>();
            NOM_NominaDet = new HashSet<NOM_NominaDet>();
            SER_MaestroContrato = new HashSet<SER_MaestroContrato>();
            TER_actividad_economica = new HashSet<TER_actividad_economica>();
            TER_ClaseTercero = new HashSet<TER_ClaseTercero>();
            TER_Documento = new HashSet<TER_Documento>();
            TER_Financiera = new HashSet<TER_Financiera>();
            TER_General = new HashSet<TER_General>();
            TER_gestion_calidad = new HashSet<TER_gestion_calidad>();
            TER_marca_tercero = new HashSet<TER_marca_tercero>();
            TER_representante = new HashSet<TER_representante>();
            TER_ResponsabilidadesTercero = new HashSet<TER_ResponsabilidadesTercero>();
            TER_SeleccionProveedor = new HashSet<TER_SeleccionProveedor>();
            TER_sucursales = new HashSet<TER_sucursales>();
            TES_Egreso = new HashSet<TES_Egreso>();
            TES_Ingresos = new HashSet<TES_Ingresos>();
            TES_IngresosBancoDet = new HashSet<TES_IngresosBancoDet>();
            TES_NotasDetalle = new HashSet<TES_NotasDetalle>();
            TER_TipoTercero = new HashSet<TER_TipoTercero>();
            TES_TrasladoDet = new HashSet<TES_TrasladoDet>();
            TES_TrasladosInternos = new HashSet<TES_TrasladosInternos>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(2)]
        public string TipoContribuyente { get; set; }

        public int TipoDocumento { get; set; }

        [Required]
        [StringLength(2)]
        public string Contribuyente { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        public int DV { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreI { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreII { get; set; }

        [Required]
        [StringLength(100)]
        public string ApellidoI { get; set; }

        [Required]
        [StringLength(100)]
        public string ApellidoII { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(150)]
        public string RazonSocial { get; set; }

        [Required]
        [StringLength(250)]
        public string NombreComercial { get; set; }

        public DateTime Fe_Inscripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Categoria { get; set; }

        public decimal idTransaccion { get; set; }

        [StringLength(50)]
        public string Ciudad { get; set; }

        [StringLength(150)]
        public string Direccion { get; set; }

        [StringLength(100)]
        public string Telefono { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public DateTime? FeActualizacion { get; set; }

        [StringLength(2)]
        public string Actualizado { get; set; }

        public decimal? Otro_id { get; set; }

        public DateTime? fe_actualizacion { get; set; }

        [Required]
        [StringLength(50)]
        public string VoBo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_CotizacionServicio> BYS_CotizacionServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_Documento> BYS_Documento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_Movimiento> BYS_Movimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAR_AjusteCreditoDet> CAR_AjusteCreditoDet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAR_Cartera> CAR_Cartera { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoDetalleEPS> CNT_AsientoDetalleEPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoDetalleEPSC> CNT_AsientoDetalleEPSC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoDetalleNIIF> CNT_AsientoDetalleNIIF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoDetalleNIIF_EPS> CNT_AsientoDetalleNIIF_EPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoDetalleNIIF_EPSC> CNT_AsientoDetalleNIIF_EPSC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_AsientoDetallePCGA> CNT_AsientoDetallePCGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_Cesion> CNT_Cesion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_Cesion> CNT_Cesion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_Cruce> CNT_Cruce { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Solicitud_Credito> CRE_Solicitud_Credito { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRE_Solicitud_Credito> CRE_Solicitud_Credito1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXC_Ventas> CXC_Ventas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXP_Compras> CXP_Compras { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_Factura> FAC_Factura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_MedioRecaudoVenta> FAC_MedioRecaudoVenta { get; set; }

        public virtual MAE_Tipo_Identificacion MAE_Tipo_Identificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_Contrato> NOM_Contrato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_Contrato> NOM_Contrato1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_Contrato> NOM_Contrato2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_Contrato> NOM_Contrato3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_Contrato> NOM_Contrato4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_NominaDet> NOM_NominaDet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_MaestroContrato> SER_MaestroContrato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_actividad_economica> TER_actividad_economica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_ClaseTercero> TER_ClaseTercero { get; set; }

        public virtual TER_Cliente TER_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_Documento> TER_Documento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_Financiera> TER_Financiera { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_General> TER_General { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_gestion_calidad> TER_gestion_calidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_marca_tercero> TER_marca_tercero { get; set; }

        public virtual TER_Proveedor TER_Proveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_representante> TER_representante { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_ResponsabilidadesTercero> TER_ResponsabilidadesTercero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_SeleccionProveedor> TER_SeleccionProveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_sucursales> TER_sucursales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_Egreso> TES_Egreso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_Ingresos> TES_Ingresos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_IngresosBancoDet> TES_IngresosBancoDet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_NotasDetalle> TES_NotasDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TER_TipoTercero> TER_TipoTercero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_TrasladoDet> TES_TrasladoDet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_TrasladosInternos> TES_TrasladosInternos { get; set; }
    }
}
