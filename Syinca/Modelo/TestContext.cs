namespace Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TestContext : DbContext
    {
        public TestContext()
            : base("name=TestContext")
        {
        }

        public virtual DbSet<AAA_BalanceMigrado> AAA_BalanceMigrado { get; set; }
        public virtual DbSet<AAA_CarteraColegio> AAA_CarteraColegio { get; set; }
        public virtual DbSet<AAA_CarteraCredito> AAA_CarteraCredito { get; set; }
        public virtual DbSet<AAA_CarteraIFC> AAA_CarteraIFC { get; set; }
        public virtual DbSet<AAA_CxP> AAA_CxP { get; set; }
        public virtual DbSet<AAA_CxPNova> AAA_CxPNova { get; set; }
        public virtual DbSet<AAA_Documento> AAA_Documento { get; set; }
        public virtual DbSet<AAA_FacturaEPS> AAA_FacturaEPS { get; set; }
        public virtual DbSet<AAA_Kardex> AAA_Kardex { get; set; }
        public virtual DbSet<AAA_Tercero> AAA_Tercero { get; set; }
        public virtual DbSet<AACaja> AACaja { get; set; }
        public virtual DbSet<AAFctura> AAFctura { get; set; }
        public virtual DbSet<ALM_BienesServicios> ALM_BienesServicios { get; set; }
        public virtual DbSet<ALM_Bodega> ALM_Bodega { get; set; }
        public virtual DbSet<ALM_Clasificacion> ALM_Clasificacion { get; set; }
        public virtual DbSet<ALM_DADetalle> ALM_DADetalle { get; set; }
        public virtual DbSet<ALM_DBDetalle> ALM_DBDetalle { get; set; }
        public virtual DbSet<ALM_DeBaja> ALM_DeBaja { get; set; }
        public virtual DbSet<ALM_DetalleRemision> ALM_DetalleRemision { get; set; }
        public virtual DbSet<ALM_DetalleTipo> ALM_DetalleTipo { get; set; }
        public virtual DbSet<ALM_DevolucionAlmacen> ALM_DevolucionAlmacen { get; set; }
        public virtual DbSet<ALM_DevolucionProveedor> ALM_DevolucionProveedor { get; set; }
        public virtual DbSet<ALM_Distribucion> ALM_Distribucion { get; set; }
        public virtual DbSet<ALM_DistribucionNE> ALM_DistribucionNE { get; set; }
        public virtual DbSet<ALM_DPDetalle> ALM_DPDetalle { get; set; }
        public virtual DbSet<ALM_IVA> ALM_IVA { get; set; }
        public virtual DbSet<ALM_kardex> ALM_kardex { get; set; }
        public virtual DbSet<ALM_MotivoDebaja> ALM_MotivoDebaja { get; set; }
        public virtual DbSet<ALM_NEDetalle> ALM_NEDetalle { get; set; }
        public virtual DbSet<ALM_NotaEntrada> ALM_NotaEntrada { get; set; }
        public virtual DbSet<ALM_NotaSalida> ALM_NotaSalida { get; set; }
        public virtual DbSet<ALM_NSDetalle> ALM_NSDetalle { get; set; }
        public virtual DbSet<ALM_PreasientoDA> ALM_PreasientoDA { get; set; }
        public virtual DbSet<ALM_PreasientoDB> ALM_PreasientoDB { get; set; }
        public virtual DbSet<ALM_PreasientoDP> ALM_PreasientoDP { get; set; }
        public virtual DbSet<ALM_PreasientoNE> ALM_PreasientoNE { get; set; }
        public virtual DbSet<ALM_PreasientoNS> ALM_PreasientoNS { get; set; }
        public virtual DbSet<ALM_Referencia> ALM_Referencia { get; set; }
        public virtual DbSet<ALM_Remision> ALM_Remision { get; set; }
        public virtual DbSet<ALM_Retencion> ALM_Retencion { get; set; }
        public virtual DbSet<ALM_RetencionDP> ALM_RetencionDP { get; set; }
        public virtual DbSet<ALM_TipoRemision> ALM_TipoRemision { get; set; }
        public virtual DbSet<ALM_UnidadMedida> ALM_UnidadMedida { get; set; }
        public virtual DbSet<AUX_Jefe> AUX_Jefe { get; set; }
        public virtual DbSet<AUX_jefe_centro_costo> AUX_jefe_centro_costo { get; set; }
        public virtual DbSet<AUX_Rubro> AUX_Rubro { get; set; }
        public virtual DbSet<AUX_TipoSolicitud> AUX_TipoSolicitud { get; set; }
        public virtual DbSet<BOL_Area> BOL_Area { get; set; }
        public virtual DbSet<BOL_Bolsa> BOL_Bolsa { get; set; }
        public virtual DbSet<BOL_Cargo> BOL_Cargo { get; set; }
        public virtual DbSet<BOL_Contrato> BOL_Contrato { get; set; }
        public virtual DbSet<BOL_Persona> BOL_Persona { get; set; }
        public virtual DbSet<BYS_Anticipo> BYS_Anticipo { get; set; }
        public virtual DbSet<BYS_Caja> BYS_Caja { get; set; }
        public virtual DbSet<BYS_CajaUsuario> BYS_CajaUsuario { get; set; }
        public virtual DbSet<BYS_CierreCaja> BYS_CierreCaja { get; set; }
        public virtual DbSet<BYS_ClaseRubro> BYS_ClaseRubro { get; set; }
        public virtual DbSet<BYS_Clases> BYS_Clases { get; set; }
        public virtual DbSet<BYS_Conceptos> BYS_Conceptos { get; set; }
        public virtual DbSet<BYS_CotizacionServicio> BYS_CotizacionServicio { get; set; }
        public virtual DbSet<BYS_DetalleSolicitud> BYS_DetalleSolicitud { get; set; }
        public virtual DbSet<BYS_DetDocDetalle> BYS_DetDocDetalle { get; set; }
        public virtual DbSet<BYS_Distribucion> BYS_Distribucion { get; set; }
        public virtual DbSet<BYS_DistribucionReferencia> BYS_DistribucionReferencia { get; set; }
        public virtual DbSet<BYS_DistribucionServicio> BYS_DistribucionServicio { get; set; }
        public virtual DbSet<BYS_DistribucionSolicitud> BYS_DistribucionSolicitud { get; set; }
        public virtual DbSet<BYS_Documento> BYS_Documento { get; set; }
        public virtual DbSet<BYS_DocumentoDetalle> BYS_DocumentoDetalle { get; set; }
        public virtual DbSet<BYS_Firmas> BYS_Firmas { get; set; }
        public virtual DbSet<BYS_FlujoAnticipo> BYS_FlujoAnticipo { get; set; }
        public virtual DbSet<BYS_FlujoAprobacion> BYS_FlujoAprobacion { get; set; }
        public virtual DbSet<BYS_FlujoServicio> BYS_FlujoServicio { get; set; }
        public virtual DbSet<BYS_FuenteSolicitud> BYS_FuenteSolicitud { get; set; }
        public virtual DbSet<BYS_IngresosCaja> BYS_IngresosCaja { get; set; }
        public virtual DbSet<BYS_Mivimiento> BYS_Mivimiento { get; set; }
        public virtual DbSet<BYS_Movimiento> BYS_Movimiento { get; set; }
        public virtual DbSet<BYS_MovimientoDetalle> BYS_MovimientoDetalle { get; set; }
        public virtual DbSet<BYS_RetencionCaja> BYS_RetencionCaja { get; set; }
        public virtual DbSet<BYS_RetencionOC> BYS_RetencionOC { get; set; }
        public virtual DbSet<BYS_RetencionS> BYS_RetencionS { get; set; }
        public virtual DbSet<BYS_SCotizacionDetalle> BYS_SCotizacionDetalle { get; set; }
        public virtual DbSet<BYS_SolContrato> BYS_SolContrato { get; set; }
        public virtual DbSet<BYS_Solicitud> BYS_Solicitud { get; set; }
        public virtual DbSet<BYS_SolicitudCotizacion> BYS_SolicitudCotizacion { get; set; }
        public virtual DbSet<BYS_SolicitudServicio> BYS_SolicitudServicio { get; set; }
        public virtual DbSet<BYS_SServicioDetalle> BYS_SServicioDetalle { get; set; }
        public virtual DbSet<BYS_TipoAnticipo> BYS_TipoAnticipo { get; set; }
        public virtual DbSet<BYS_TipoSolicitud> BYS_TipoSolicitud { get; set; }
        public virtual DbSet<BysCierreCaja> BysCierreCaja { get; set; }
        public virtual DbSet<CAR_AjusteCreditoDet> CAR_AjusteCreditoDet { get; set; }
        public virtual DbSet<CAR_AjustesCredito> CAR_AjustesCredito { get; set; }
        public virtual DbSet<CAR_BeneficiariosAjuste> CAR_BeneficiariosAjuste { get; set; }
        public virtual DbSet<CAR_Cartera> CAR_Cartera { get; set; }
        public virtual DbSet<CAR_FlujoCartera> CAR_FlujoCartera { get; set; }
        public virtual DbSet<CAR_FlujoCarteraDet> CAR_FlujoCarteraDet { get; set; }
        public virtual DbSet<CAR_Movimiento> CAR_Movimiento { get; set; }
        public virtual DbSet<CAR_Seguimiento> CAR_Seguimiento { get; set; }
        public virtual DbSet<CNT_AcumuladoEPS> CNT_AcumuladoEPS { get; set; }
        public virtual DbSet<CNT_AcumuladoEPSC> CNT_AcumuladoEPSC { get; set; }
        public virtual DbSet<CNT_AcumuladoNIIF> CNT_AcumuladoNIIF { get; set; }
        public virtual DbSet<CNT_AcumuladoNIIF_EPS> CNT_AcumuladoNIIF_EPS { get; set; }
        public virtual DbSet<CNT_AcumuladoNIIF_EPSC> CNT_AcumuladoNIIF_EPSC { get; set; }
        public virtual DbSet<CNT_AcumuladoPCGA> CNT_AcumuladoPCGA { get; set; }
        public virtual DbSet<CNT_AcumuladoPCGA_CCosto> CNT_AcumuladoPCGA_CCosto { get; set; }
        public virtual DbSet<CNT_AcumuladoPCGA_TER> CNT_AcumuladoPCGA_TER { get; set; }
        public virtual DbSet<CNT_Anio_Fiscal> CNT_Anio_Fiscal { get; set; }
        public virtual DbSet<CNT_AsientoDetalleEPS> CNT_AsientoDetalleEPS { get; set; }
        public virtual DbSet<CNT_AsientoDetalleEPSC> CNT_AsientoDetalleEPSC { get; set; }
        public virtual DbSet<CNT_AsientoDetalleNIIF> CNT_AsientoDetalleNIIF { get; set; }
        public virtual DbSet<CNT_AsientoDetalleNIIF_EPS> CNT_AsientoDetalleNIIF_EPS { get; set; }
        public virtual DbSet<CNT_AsientoDetalleNIIF_EPSC> CNT_AsientoDetalleNIIF_EPSC { get; set; }
        public virtual DbSet<CNT_AsientoDetallePCGA> CNT_AsientoDetallePCGA { get; set; }
        public virtual DbSet<CNT_AsientoEPS> CNT_AsientoEPS { get; set; }
        public virtual DbSet<CNT_AsientoEPSC> CNT_AsientoEPSC { get; set; }
        public virtual DbSet<CNT_AsientoNIIF> CNT_AsientoNIIF { get; set; }
        public virtual DbSet<CNT_AsientoNIIF_EPS> CNT_AsientoNIIF_EPS { get; set; }
        public virtual DbSet<CNT_AsientoNIIF_EPSC> CNT_AsientoNIIF_EPSC { get; set; }
        public virtual DbSet<CNT_AsientoPCGA> CNT_AsientoPCGA { get; set; }
        public virtual DbSet<CNT_Cesion> CNT_Cesion { get; set; }
        public virtual DbSet<CNT_CesionDetalle> CNT_CesionDetalle { get; set; }
        public virtual DbSet<CNT_ConceptoExogena> CNT_ConceptoExogena { get; set; }
        public virtual DbSet<CNT_Conciliacion> CNT_Conciliacion { get; set; }
        public virtual DbSet<CNT_Cruce> CNT_Cruce { get; set; }
        public virtual DbSet<CNT_CruceDetalle> CNT_CruceDetalle { get; set; }
        public virtual DbSet<CNT_DetalleConciliacion> CNT_DetalleConciliacion { get; set; }
        public virtual DbSet<CNT_DetalleExtracto> CNT_DetalleExtracto { get; set; }
        public virtual DbSet<CNT_Extracto> CNT_Extracto { get; set; }
        public virtual DbSet<CNT_Modulos> CNT_Modulos { get; set; }
        public virtual DbSet<CNT_Notas> CNT_Notas { get; set; }
        public virtual DbSet<CNT_Partidas> CNT_Partidas { get; set; }
        public virtual DbSet<CNT_Periodo> CNT_Periodo { get; set; }
        public virtual DbSet<CNT_PlanoNovasoft> CNT_PlanoNovasoft { get; set; }
        public virtual DbSet<CNT_PlanoNovasoftCxP> CNT_PlanoNovasoftCxP { get; set; }
        public virtual DbSet<CNT_PlanoNovasoftDetalle> CNT_PlanoNovasoftDetalle { get; set; }
        public virtual DbSet<CNT_PlanoNovasoftDetalleCxP> CNT_PlanoNovasoftDetalleCxP { get; set; }
        public virtual DbSet<CNT_PreasientoEPS> CNT_PreasientoEPS { get; set; }
        public virtual DbSet<CNT_PreasientoEPSC> CNT_PreasientoEPSC { get; set; }
        public virtual DbSet<CNT_PreasientoNIIF> CNT_PreasientoNIIF { get; set; }
        public virtual DbSet<CNT_PreasientoNIIF_EPS> CNT_PreasientoNIIF_EPS { get; set; }
        public virtual DbSet<CNT_PreasientoNIIF_EPSC> CNT_PreasientoNIIF_EPSC { get; set; }
        public virtual DbSet<CNT_PreasientoPCGA> CNT_PreasientoPCGA { get; set; }
        public virtual DbSet<CNT_PUC_General> CNT_PUC_General { get; set; }
        public virtual DbSet<CNT_PUC_GeneralEPS> CNT_PUC_GeneralEPS { get; set; }
        public virtual DbSet<CNT_PUC_GeneralEPSC> CNT_PUC_GeneralEPSC { get; set; }
        public virtual DbSet<CNT_PUC_NIIF> CNT_PUC_NIIF { get; set; }
        public virtual DbSet<CNT_PUC_NIIF_EPS> CNT_PUC_NIIF_EPS { get; set; }
        public virtual DbSet<CNT_PUC_NIIF_EPSC> CNT_PUC_NIIF_EPSC { get; set; }
        public virtual DbSet<CNT_ResumenConciliacionExtracto> CNT_ResumenConciliacionExtracto { get; set; }
        public virtual DbSet<CNT_ResumenConciliacionLibro> CNT_ResumenConciliacionLibro { get; set; }
        public virtual DbSet<CNT_RPT_Auxiliar> CNT_RPT_Auxiliar { get; set; }
        public virtual DbSet<CNT_RPT_Balance> CNT_RPT_Balance { get; set; }
        public virtual DbSet<CNT_RPT_BalanceEPS> CNT_RPT_BalanceEPS { get; set; }
        public virtual DbSet<CNT_RPT_EstadoResultadoEPSC> CNT_RPT_EstadoResultadoEPSC { get; set; }
        public virtual DbSet<CNT_RPT_EstadoResultadoEPSS> CNT_RPT_EstadoResultadoEPSS { get; set; }
        public virtual DbSet<CNT_RPT_LibroDiario> CNT_RPT_LibroDiario { get; set; }
        public virtual DbSet<CNT_RPT_LibroDiarioEPS> CNT_RPT_LibroDiarioEPS { get; set; }
        public virtual DbSet<CNT_RPT_LibroDiarioEPSC> CNT_RPT_LibroDiarioEPSC { get; set; }
        public virtual DbSet<CNT_SaldoInicialCab> CNT_SaldoInicialCab { get; set; }
        public virtual DbSet<CNT_SI_PCGA> CNT_SI_PCGA { get; set; }
        public virtual DbSet<CNT_SI_PCGA_CCosto> CNT_SI_PCGA_CCosto { get; set; }
        public virtual DbSet<CNT_SI_PCGA_Tercero> CNT_SI_PCGA_Tercero { get; set; }
        public virtual DbSet<CNT_TipoDocumento> CNT_TipoDocumento { get; set; }
        public virtual DbSet<CNT_UsuariosPermisos> CNT_UsuariosPermisos { get; set; }
        public virtual DbSet<CRE_Amortizacion> CRE_Amortizacion { get; set; }
        public virtual DbSet<CRE_Anexos> CRE_Anexos { get; set; }
        public virtual DbSet<CRE_AsientoLinea> CRE_AsientoLinea { get; set; }
        public virtual DbSet<CRE_Beneficiarios> CRE_Beneficiarios { get; set; }
        public virtual DbSet<CRE_Bienes> CRE_Bienes { get; set; }
        public virtual DbSet<CRE_Bienes_Solicitud> CRE_Bienes_Solicitud { get; set; }
        public virtual DbSet<CRE_Categoria> CRE_Categoria { get; set; }
        public virtual DbSet<CRE_Concepto> CRE_Concepto { get; set; }
        public virtual DbSet<CRE_Coodeudor> CRE_Coodeudor { get; set; }
        public virtual DbSet<CRE_CreditosSuper> CRE_CreditosSuper { get; set; }
        public virtual DbSet<CRE_CreditosSuperDet> CRE_CreditosSuperDet { get; set; }
        public virtual DbSet<CRE_Datos_Financieros> CRE_Datos_Financieros { get; set; }
        public virtual DbSet<CRE_Enfermedad_Padecida> CRE_Enfermedad_Padecida { get; set; }
        public virtual DbSet<CRE_Enfermedades> CRE_Enfermedades { get; set; }
        public virtual DbSet<CRE_Linea> CRE_Linea { get; set; }
        public virtual DbSet<CRE_Linea_Credito> CRE_Linea_Credito { get; set; }
        public virtual DbSet<CRE_Modalidad_Recaudo> CRE_Modalidad_Recaudo { get; set; }
        public virtual DbSet<CRE_PlanoNovasoft> CRE_PlanoNovasoft { get; set; }
        public virtual DbSet<CRE_PlanoNovasoftDetalle> CRE_PlanoNovasoftDetalle { get; set; }
        public virtual DbSet<CRE_PlanoTXT> CRE_PlanoTXT { get; set; }
        public virtual DbSet<CRE_Proceso> CRE_Proceso { get; set; }
        public virtual DbSet<CRE_ProcesoCredito> CRE_ProcesoCredito { get; set; }
        public virtual DbSet<CRE_RecaudoCredito> CRE_RecaudoCredito { get; set; }
        public virtual DbSet<CRE_RecaudoXamortizacion> CRE_RecaudoXamortizacion { get; set; }
        public virtual DbSet<CRE_Referencia> CRE_Referencia { get; set; }
        public virtual DbSet<CRE_Requisito> CRE_Requisito { get; set; }
        public virtual DbSet<CRE_Requisito_Linea> CRE_Requisito_Linea { get; set; }
        public virtual DbSet<CRE_Requisito_Solicitud> CRE_Requisito_Solicitud { get; set; }
        public virtual DbSet<CRE_Simulacion> CRE_Simulacion { get; set; }
        public virtual DbSet<CRE_Solicitud_Credito> CRE_Solicitud_Credito { get; set; }
        public virtual DbSet<CRE_Validador> CRE_Validador { get; set; }
        public virtual DbSet<CRE_ValidadorCab> CRE_ValidadorCab { get; set; }
        public virtual DbSet<CXC_Concepto> CXC_Concepto { get; set; }
        public virtual DbSet<CXC_Preasiento> CXC_Preasiento { get; set; }
        public virtual DbSet<CXC_Ventas> CXC_Ventas { get; set; }
        public virtual DbSet<CXP_AnticiposCompra> CXP_AnticiposCompra { get; set; }
        public virtual DbSet<CXP_Compras> CXP_Compras { get; set; }
        public virtual DbSet<CXP_ComprasDetalle> CXP_ComprasDetalle { get; set; }
        public virtual DbSet<CXP_CruceCuentas> CXP_CruceCuentas { get; set; }
        public virtual DbSet<CXP_Item> CXP_Item { get; set; }
        public virtual DbSet<CXP_PlanPago> CXP_PlanPago { get; set; }
        public virtual DbSet<CXP_Prorrateo> CXP_Prorrateo { get; set; }
        public virtual DbSet<CXP_RetencionCompra> CXP_RetencionCompra { get; set; }
        public virtual DbSet<dssw21> dssw21 { get; set; }
        public virtual DbSet<dssw22> dssw22 { get; set; }
        public virtual DbSet<dssw23> dssw23 { get; set; }
        public virtual DbSet<dssw25> dssw25 { get; set; }
        public virtual DbSet<EXT_CentroCosto> EXT_CentroCosto { get; set; }
        public virtual DbSet<EXT_Parafiscales> EXT_Parafiscales { get; set; }
        public virtual DbSet<EXT_Rubro> EXT_Rubro { get; set; }
        public virtual DbSet<FAC_AgenciaViaje> FAC_AgenciaViaje { get; set; }
        public virtual DbSet<FAC_AnticipoFactura> FAC_AnticipoFactura { get; set; }
        public virtual DbSet<FAC_AsientoConcepto> FAC_AsientoConcepto { get; set; }
        public virtual DbSet<FAC_BeneficiarioCredito> FAC_BeneficiarioCredito { get; set; }
        public virtual DbSet<FAC_Cartera> FAC_Cartera { get; set; }
        public virtual DbSet<FAC_CarteraDetalle> FAC_CarteraDetalle { get; set; }
        public virtual DbSet<FAC_Cierre> FAC_Cierre { get; set; }
        public virtual DbSet<FAC_Concepto> FAC_Concepto { get; set; }
        public virtual DbSet<FAC_DetalleFactura> FAC_DetalleFactura { get; set; }
        public virtual DbSet<FAC_DetallePagoCuotas> FAC_DetallePagoCuotas { get; set; }
        public virtual DbSet<FAC_Factura> FAC_Factura { get; set; }
        public virtual DbSet<FAC_FormaRecaudo> FAC_FormaRecaudo { get; set; }
        public virtual DbSet<FAC_MedioRecaudoVenta> FAC_MedioRecaudoVenta { get; set; }
        public virtual DbSet<FAC_PlanoNovasoft> FAC_PlanoNovasoft { get; set; }
        public virtual DbSet<FAC_PlanoNovasoftDetalle> FAC_PlanoNovasoftDetalle { get; set; }
        public virtual DbSet<FAC_Preasiento> FAC_Preasiento { get; set; }
        public virtual DbSet<FAC_PreasientoCartera> FAC_PreasientoCartera { get; set; }
        public virtual DbSet<FAC_Precio> FAC_Precio { get; set; }
        public virtual DbSet<FAC_RecaudoCartera> FAC_RecaudoCartera { get; set; }
        public virtual DbSet<FAC_Recreacion> FAC_Recreacion { get; set; }
        public virtual DbSet<FAC_RetencionFactura> FAC_RetencionFactura { get; set; }
        public virtual DbSet<FAC_Secuencia> FAC_Secuencia { get; set; }
        public virtual DbSet<FAC_SeguimientoCartera> FAC_SeguimientoCartera { get; set; }
        public virtual DbSet<FAC_Servicio> FAC_Servicio { get; set; }
        public virtual DbSet<FAC_TablaPrecio> FAC_TablaPrecio { get; set; }
        public virtual DbSet<FAC_TemporalFacturacion> FAC_TemporalFacturacion { get; set; }
        public virtual DbSet<FAC_TurnoCartera> FAC_TurnoCartera { get; set; }
        public virtual DbSet<INT_ActivoFijo> INT_ActivoFijo { get; set; }
        public virtual DbSet<INT_Biblioteca> INT_Biblioteca { get; set; }
        public virtual DbSet<INT_CierreCaja> INT_CierreCaja { get; set; }
        public virtual DbSet<INT_Colegio> INT_Colegio { get; set; }
        public virtual DbSet<INT_ColegioMatricula> INT_ColegioMatricula { get; set; }
        public virtual DbSet<INT_CxP> INT_CxP { get; set; }
        public virtual DbSet<INT_FacturaPrestadores> INT_FacturaPrestadores { get; set; }
        public virtual DbSet<INT_Nomina> INT_Nomina { get; set; }
        public virtual DbSet<INT_Nomina2> INT_Nomina2 { get; set; }
        public virtual DbSet<INT_Recreacion> INT_Recreacion { get; set; }
        public virtual DbSet<INT_Subsidio> INT_Subsidio { get; set; }
        public virtual DbSet<INT_SubsidioDet> INT_SubsidioDet { get; set; }
        public virtual DbSet<MAE_Abreviaturas> MAE_Abreviaturas { get; set; }
        public virtual DbSet<MAE_AE_Actividad_Economica> MAE_AE_Actividad_Economica { get; set; }
        public virtual DbSet<MAE_AE_Division> MAE_AE_Division { get; set; }
        public virtual DbSet<MAE_AE_Division_sub> MAE_AE_Division_sub { get; set; }
        public virtual DbSet<MAE_AE_Seccion> MAE_AE_Seccion { get; set; }
        public virtual DbSet<MAE_Ciudad> MAE_Ciudad { get; set; }
        public virtual DbSet<MAE_Condiciones_Pago> MAE_Condiciones_Pago { get; set; }
        public virtual DbSet<MAE_Departamento> MAE_Departamento { get; set; }
        public virtual DbSet<MAE_Empresa> MAE_Empresa { get; set; }
        public virtual DbSet<MAE_Menu> MAE_Menu { get; set; }
        public virtual DbSet<MAE_Pais> MAE_Pais { get; set; }
        public virtual DbSet<MAE_Permisos> MAE_Permisos { get; set; }
        public virtual DbSet<MAE_Reporte> MAE_Reporte { get; set; }
        public virtual DbSet<MAE_ReporteUsuario> MAE_ReporteUsuario { get; set; }
        public virtual DbSet<MAE_Retefuente> MAE_Retefuente { get; set; }
        public virtual DbSet<MAE_Salarios> MAE_Salarios { get; set; }
        public virtual DbSet<MAE_Subcentro> MAE_Subcentro { get; set; }
        public virtual DbSet<MAE_Tipo_Comprobantes> MAE_Tipo_Comprobantes { get; set; }
        public virtual DbSet<MAE_Tipo_Identificacion> MAE_Tipo_Identificacion { get; set; }
        public virtual DbSet<MAE_Tipo_Movimiento> MAE_Tipo_Movimiento { get; set; }
        public virtual DbSet<MAE_TipoReportes> MAE_TipoReportes { get; set; }
        public virtual DbSet<MAE_Usuario> MAE_Usuario { get; set; }
        public virtual DbSet<MAE_Usuario_Centro_Costo> MAE_Usuario_Centro_Costo { get; set; }
        public virtual DbSet<MAE_Vereda> MAE_Vereda { get; set; }
        public virtual DbSet<MIG_CabCxP> MIG_CabCxP { get; set; }
        public virtual DbSet<MIG_DetCxP> MIG_DetCxP { get; set; }
        public virtual DbSet<NOM_Cargo> NOM_Cargo { get; set; }
        public virtual DbSet<NOM_Colilla> NOM_Colilla { get; set; }
        public virtual DbSet<NOM_Concepto> NOM_Concepto { get; set; }
        public virtual DbSet<NOM_Contrato> NOM_Contrato { get; set; }
        public virtual DbSet<NOM_DistribucionContrato> NOM_DistribucionContrato { get; set; }
        public virtual DbSet<NOM_Nomina> NOM_Nomina { get; set; }
        public virtual DbSet<NOM_NominaDet> NOM_NominaDet { get; set; }
        public virtual DbSet<NOM_Parametros> NOM_Parametros { get; set; }
        public virtual DbSet<NOM_TipoContrato> NOM_TipoContrato { get; set; }
        public virtual DbSet<NOM_TipoNomina> NOM_TipoNomina { get; set; }
        public virtual DbSet<PRE_Anio> PRE_Anio { get; set; }
        public virtual DbSet<PRE_Detalle_Pre_X_Dependencia> PRE_Detalle_Pre_X_Dependencia { get; set; }
        public virtual DbSet<PRE_Detalle_Presupuesto> PRE_Detalle_Presupuesto { get; set; }
        public virtual DbSet<PRE_Detalle_Traslado> PRE_Detalle_Traslado { get; set; }
        public virtual DbSet<PRE_Ejecucion> PRE_Ejecucion { get; set; }
        public virtual DbSet<PRE_FlujoCDP> PRE_FlujoCDP { get; set; }
        public virtual DbSet<PRE_Periodicidad> PRE_Periodicidad { get; set; }
        public virtual DbSet<PRE_Periodo> PRE_Periodo { get; set; }
        public virtual DbSet<PRE_Presupuesto> PRE_Presupuesto { get; set; }
        public virtual DbSet<PRE_RP> PRE_RP { get; set; }
        public virtual DbSet<PRE_Rubro> PRE_Rubro { get; set; }
        public virtual DbSet<PRE_SolicitudCDP> PRE_SolicitudCDP { get; set; }
        public virtual DbSet<PRE_Tipo_Presupuesto> PRE_Tipo_Presupuesto { get; set; }
        public virtual DbSet<PRE_TipoInversion> PRE_TipoInversion { get; set; }
        public virtual DbSet<PRE_Traslado> PRE_Traslado { get; set; }
        public virtual DbSet<PRE_TrasladoFin> PRE_TrasladoFin { get; set; }
        public virtual DbSet<PRE_TrasladoOrigen> PRE_TrasladoOrigen { get; set; }
        public virtual DbSet<SER_Concepto> SER_Concepto { get; set; }
        public virtual DbSet<SER_ConceptoRetencion> SER_ConceptoRetencion { get; set; }
        public virtual DbSet<SER_Contratos> SER_Contratos { get; set; }
        public virtual DbSet<SER_ContratoSuperCab> SER_ContratoSuperCab { get; set; }
        public virtual DbSet<SER_ContratoSuperDet> SER_ContratoSuperDet { get; set; }
        public virtual DbSet<SER_Destino> SER_Destino { get; set; }
        public virtual DbSet<SER_Estados> SER_Estados { get; set; }
        public virtual DbSet<SER_Firma> SER_Firma { get; set; }
        public virtual DbSet<SER_FuenteContrato> SER_FuenteContrato { get; set; }
        public virtual DbSet<SER_FuenteFinanciacion> SER_FuenteFinanciacion { get; set; }
        public virtual DbSet<SER_MaestroContrato> SER_MaestroContrato { get; set; }
        public virtual DbSet<SER_Modalidad> SER_Modalidad { get; set; }
        public virtual DbSet<SER_PlanPagos> SER_PlanPagos { get; set; }
        public virtual DbSet<SER_ProrrateoContratos> SER_ProrrateoContratos { get; set; }
        public virtual DbSet<SER_Requerimientos> SER_Requerimientos { get; set; }
        public virtual DbSet<SER_Requisitos> SER_Requisitos { get; set; }
        public virtual DbSet<SER_Retencion> SER_Retencion { get; set; }
        public virtual DbSet<SER_Seguimiento> SER_Seguimiento { get; set; }
        public virtual DbSet<SER_TipoAporte> SER_TipoAporte { get; set; }
        public virtual DbSet<SER_TipoAporteContrato> SER_TipoAporteContrato { get; set; }
        public virtual DbSet<SER_TipoContratos> SER_TipoContratos { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TER_actividad_economica> TER_actividad_economica { get; set; }
        public virtual DbSet<TER_ClaseTercero> TER_ClaseTercero { get; set; }
        public virtual DbSet<TER_Cliente> TER_Cliente { get; set; }
        public virtual DbSet<TER_Documento> TER_Documento { get; set; }
        public virtual DbSet<TER_Estado_Civil> TER_Estado_Civil { get; set; }
        public virtual DbSet<TER_Financiera> TER_Financiera { get; set; }
        public virtual DbSet<TER_General> TER_General { get; set; }
        public virtual DbSet<TER_gestion_calidad> TER_gestion_calidad { get; set; }
        public virtual DbSet<TER_marca_tercero> TER_marca_tercero { get; set; }
        public virtual DbSet<TER_Nivel_Educativo> TER_Nivel_Educativo { get; set; }
        public virtual DbSet<TER_Producto> TER_Producto { get; set; }
        public virtual DbSet<TER_Proveedor> TER_Proveedor { get; set; }
        public virtual DbSet<TER_Regimen> TER_Regimen { get; set; }
        public virtual DbSet<TER_representante> TER_representante { get; set; }
        public virtual DbSet<TER_Responsabilidades> TER_Responsabilidades { get; set; }
        public virtual DbSet<TER_ResponsabilidadesTercero> TER_ResponsabilidadesTercero { get; set; }
        public virtual DbSet<TER_SeleccionProveedor> TER_SeleccionProveedor { get; set; }
        public virtual DbSet<TER_sucursales> TER_sucursales { get; set; }
        public virtual DbSet<TER_Tercero> TER_Tercero { get; set; }
        public virtual DbSet<TER_Tipo> TER_Tipo { get; set; }
        public virtual DbSet<TER_Tipo_Descuento> TER_Tipo_Descuento { get; set; }
        public virtual DbSet<TER_tipo_sociedad> TER_tipo_sociedad { get; set; }
        public virtual DbSet<TER_TipoTercero> TER_TipoTercero { get; set; }
        public virtual DbSet<TES_Bancos> TES_Bancos { get; set; }
        public virtual DbSet<TES_CajaUsuario> TES_CajaUsuario { get; set; }
        public virtual DbSet<TES_ColegioIngresoDetalle> TES_ColegioIngresoDetalle { get; set; }
        public virtual DbSet<TES_ColegioIngresos> TES_ColegioIngresos { get; set; }
        public virtual DbSet<TES_Concepto> TES_Concepto { get; set; }
        public virtual DbSet<TES_Conciliacion> TES_Conciliacion { get; set; }
        public virtual DbSet<TES_Control_Comprobante> TES_Control_Comprobante { get; set; }
        public virtual DbSet<TES_Cuentas_CB> TES_Cuentas_CB { get; set; }
        public virtual DbSet<TES_CuentasBancarias> TES_CuentasBancarias { get; set; }
        public virtual DbSet<TES_DetalleEgreso> TES_DetalleEgreso { get; set; }
        public virtual DbSet<TES_DetalleIngreso> TES_DetalleIngreso { get; set; }
        public virtual DbSet<TES_Egreso> TES_Egreso { get; set; }
        public virtual DbSet<TES_EgresosPendiente> TES_EgresosPendiente { get; set; }
        public virtual DbSet<TES_EgresosPendienteDet> TES_EgresosPendienteDet { get; set; }
        public virtual DbSet<TES_EstractoBancario> TES_EstractoBancario { get; set; }
        public virtual DbSet<TES_FormaPago> TES_FormaPago { get; set; }
        public virtual DbSet<TES_GrupoConceptos> TES_GrupoConceptos { get; set; }
        public virtual DbSet<TES_Ingresos> TES_Ingresos { get; set; }
        public virtual DbSet<TES_IngresosBancoCar> TES_IngresosBancoCar { get; set; }
        public virtual DbSet<TES_IngresosBancoDet> TES_IngresosBancoDet { get; set; }
        public virtual DbSet<TES_IngresosBancos> TES_IngresosBancos { get; set; }
        public virtual DbSet<TES_Inversiones> TES_Inversiones { get; set; }
        public virtual DbSet<TES_LibroAuxiliar> TES_LibroAuxiliar { get; set; }
        public virtual DbSet<TES_MedioRecaudo> TES_MedioRecaudo { get; set; }
        public virtual DbSet<TES_Notas> TES_Notas { get; set; }
        public virtual DbSet<TES_NotasDetalle> TES_NotasDetalle { get; set; }
        public virtual DbSet<TES_PlanoColegio> TES_PlanoColegio { get; set; }
        public virtual DbSet<TES_PlanoColegioDet> TES_PlanoColegioDet { get; set; }
        public virtual DbSet<TES_TipoInversiones> TES_TipoInversiones { get; set; }
        public virtual DbSet<TES_TrasladoDet> TES_TrasladoDet { get; set; }
        public virtual DbSet<TES_TrasladoInternoDet> TES_TrasladoInternoDet { get; set; }
        public virtual DbSet<TES_Traslados> TES_Traslados { get; set; }
        public virtual DbSet<TES_TrasladosInternos> TES_TrasladosInternos { get; set; }
        public virtual DbSet<XXX_Presupuesto> XXX_Presupuesto { get; set; }
        public virtual DbSet<ZYS_Auditoria> ZYS_Auditoria { get; set; }
        public virtual DbSet<ZYS_Diccionario> ZYS_Diccionario { get; set; }
        public virtual DbSet<ZYS_Entradas> ZYS_Entradas { get; set; }
        public virtual DbSet<ZYS_Version> ZYS_Version { get; set; }
        public virtual DbSet<dssw24> dssw24 { get; set; }
        public virtual DbSet<prueba> prueba { get; set; }
        public virtual DbSet<SER_ContraloriaDet> SER_ContraloriaDet { get; set; }
        public virtual DbSet<TES_Temporal_Comprobante_Egreso> TES_Temporal_Comprobante_Egreso { get; set; }
        public virtual DbSet<TES_Temporal_Traslados> TES_Temporal_Traslados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AAA_BalanceMigrado>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraColegio>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraColegio>()
                .Property(e => e.CodMatricula)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraCredito>()
                .Property(e => e.NoCredito)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraCredito>()
                .Property(e => e.Cedula)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraCredito>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraIFC>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraIFC>()
                .Property(e => e.NombreI)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraIFC>()
                .Property(e => e.nombreII)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraIFC>()
                .Property(e => e.ApellidoI)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraIFC>()
                .Property(e => e.ApellidoII)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraIFC>()
                .Property(e => e.NombreIII)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraIFC>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraIFC>()
                .Property(e => e.CodContable)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_CarteraIFC>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_Documento>()
                .Property(e => e.Clase)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_Documento>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_Documento>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_Documento>()
                .Property(e => e.CodComparacion)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_Documento>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_Documento>()
                .Property(e => e.Visto)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_Documento>()
                .Property(e => e.Recibido)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_Kardex>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<AAA_Tercero>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<AACaja>()
                .Property(e => e.CCosto)
                .IsUnicode(false);

            modelBuilder.Entity<AACaja>()
                .Property(e => e.Rubro)
                .IsUnicode(false);

            modelBuilder.Entity<AACaja>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_BienesServicios>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_BienesServicios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_BienesServicios>()
                .Property(e => e.UnidadMedida)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_BienesServicios>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_BienesServicios>()
                .Property(e => e.ClaseBien)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_BienesServicios>()
                .Property(e => e.IVA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ALM_BienesServicios>()
                .Property(e => e.EnUso)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_BienesServicios>()
                .Property(e => e.Clase)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_BienesServicios>()
                .Property(e => e.Clasificacion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_BienesServicios>()
                .HasMany(e => e.ALM_Referencia)
                .WithRequired(e => e.ALM_BienesServicios)
                .HasForeignKey(e => e.Articulo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_Bodega>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Bodega>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Bodega>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Bodega>()
                .Property(e => e.Responsable)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Bodega>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Clasificacion>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Clasificacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Clasificacion>()
                .HasMany(e => e.ALM_BienesServicios)
                .WithRequired(e => e.ALM_Clasificacion)
                .HasForeignKey(e => e.Clasificacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_DBDetalle>()
                .Property(e => e.Motivo)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DeBaja>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DeBaja>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DeBaja>()
                .Property(e => e.NoActa)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DeBaja>()
                .HasMany(e => e.ALM_DBDetalle)
                .WithRequired(e => e.ALM_DeBaja)
                .HasForeignKey(e => e.DeBaja)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_DeBaja>()
                .HasMany(e => e.ALM_PreasientoDB)
                .WithRequired(e => e.ALM_DeBaja)
                .HasForeignKey(e => e.DeBaja)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_DetalleTipo>()
                .Property(e => e.TipoRemision)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DetalleTipo>()
                .Property(e => e.Debito)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DetalleTipo>()
                .Property(e => e.NomDebito)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DetalleTipo>()
                .Property(e => e.Credito)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DetalleTipo>()
                .Property(e => e.NomCredito)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DevolucionAlmacen>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DevolucionAlmacen>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DevolucionAlmacen>()
                .HasMany(e => e.ALM_DADetalle)
                .WithRequired(e => e.ALM_DevolucionAlmacen)
                .HasForeignKey(e => e.DevolucionAlmacen);

            modelBuilder.Entity<ALM_DevolucionProveedor>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DevolucionProveedor>()
                .Property(e => e.NoFactura)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DevolucionProveedor>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DevolucionProveedor>()
                .HasMany(e => e.ALM_DPDetalle)
                .WithRequired(e => e.ALM_DevolucionProveedor)
                .HasForeignKey(e => e.DevolucionProveedor);

            modelBuilder.Entity<ALM_DevolucionProveedor>()
                .HasMany(e => e.ALM_RetencionDP)
                .WithRequired(e => e.ALM_DevolucionProveedor)
                .HasForeignKey(e => e.DevolucionProveedor);

            modelBuilder.Entity<ALM_Distribucion>()
                .Property(e => e.PartParcial)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ALM_Distribucion>()
                .Property(e => e.PartTotal)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ALM_DistribucionNE>()
                .Property(e => e.CodCCosto)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_DistribucionNE>()
                .Property(e => e.NomCCosto)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_IVA>()
                .Property(e => e.IVA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ALM_IVA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_IVA>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_kardex>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_kardex>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_kardex>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_MotivoDebaja>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_MotivoDebaja>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_MotivoDebaja>()
                .HasMany(e => e.ALM_DBDetalle)
                .WithRequired(e => e.ALM_MotivoDebaja)
                .HasForeignKey(e => e.Motivo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_NotaEntrada>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_NotaEntrada>()
                .Property(e => e.NoFactura)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_NotaEntrada>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_NotaEntrada>()
                .HasMany(e => e.ALM_DevolucionProveedor)
                .WithRequired(e => e.ALM_NotaEntrada)
                .HasForeignKey(e => e.NotaEntrada)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_NotaEntrada>()
                .HasMany(e => e.ALM_DistribucionNE)
                .WithRequired(e => e.ALM_NotaEntrada)
                .HasForeignKey(e => e.NotaEntrada);

            modelBuilder.Entity<ALM_NotaEntrada>()
                .HasMany(e => e.ALM_NEDetalle)
                .WithRequired(e => e.ALM_NotaEntrada)
                .HasForeignKey(e => e.NotaEntrada)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_NotaEntrada>()
                .HasMany(e => e.ALM_Retencion)
                .WithRequired(e => e.ALM_NotaEntrada)
                .HasForeignKey(e => e.NotaEntrada)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_NotaSalida>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_NotaSalida>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_NotaSalida>()
                .HasMany(e => e.ALM_DevolucionAlmacen)
                .WithRequired(e => e.ALM_NotaSalida)
                .HasForeignKey(e => e.NotaSalida)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_NotaSalida>()
                .HasMany(e => e.ALM_NSDetalle)
                .WithRequired(e => e.ALM_NotaSalida)
                .HasForeignKey(e => e.NotaSalida);

            modelBuilder.Entity<ALM_PreasientoDA>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDA>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDA>()
                .Property(e => e.NombreCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDA>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDA>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDB>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDB>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDB>()
                .Property(e => e.NombreCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDB>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDB>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDP>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDP>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDP>()
                .Property(e => e.NombreCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDP>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoDP>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoNE>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoNE>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoNE>()
                .Property(e => e.NombreCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoNE>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoNE>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoNS>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoNS>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoNS>()
                .Property(e => e.NombreCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoNS>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_PreasientoNS>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Referencia>()
                .Property(e => e.Articulo)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Referencia>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Referencia>()
                .Property(e => e.EnUso)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Referencia>()
                .HasMany(e => e.ALM_DetalleRemision)
                .WithRequired(e => e.ALM_Referencia)
                .HasForeignKey(e => e.Referencia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_Referencia>()
                .HasMany(e => e.ALM_kardex)
                .WithRequired(e => e.ALM_Referencia)
                .HasForeignKey(e => e.Referencia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_Referencia>()
                .HasMany(e => e.BYS_DocumentoDetalle)
                .WithRequired(e => e.ALM_Referencia)
                .HasForeignKey(e => e.Referencia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_Referencia>()
                .HasMany(e => e.BYS_DetalleSolicitud)
                .WithRequired(e => e.ALM_Referencia)
                .HasForeignKey(e => e.Referencia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_Remision>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Remision>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Remision>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Remision>()
                .Property(e => e.Nota)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Remision>()
                .HasMany(e => e.ALM_DetalleRemision)
                .WithRequired(e => e.ALM_Remision)
                .HasForeignKey(e => e.Remision)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_Retencion>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_Retencion>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_RetencionDP>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_RetencionDP>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_TipoRemision>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_TipoRemision>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_TipoRemision>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_TipoRemision>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_TipoRemision>()
                .HasMany(e => e.ALM_DetalleTipo)
                .WithOptional(e => e.ALM_TipoRemision)
                .HasForeignKey(e => e.TipoRemision);

            modelBuilder.Entity<ALM_TipoRemision>()
                .HasMany(e => e.ALM_Remision)
                .WithRequired(e => e.ALM_TipoRemision)
                .HasForeignKey(e => e.Tipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALM_UnidadMedida>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_UnidadMedida>()
                .Property(e => e.Ddescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALM_UnidadMedida>()
                .HasMany(e => e.ALM_BienesServicios)
                .WithRequired(e => e.ALM_UnidadMedida)
                .HasForeignKey(e => e.UnidadMedida)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AUX_Jefe>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<AUX_Jefe>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<AUX_Jefe>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<AUX_Jefe>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<AUX_Jefe>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<AUX_Jefe>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<AUX_Jefe>()
                .HasMany(e => e.AUX_jefe_centro_costo)
                .WithRequired(e => e.AUX_Jefe)
                .HasForeignKey(e => e.Jefe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AUX_Rubro>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<AUX_Rubro>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<AUX_TipoSolicitud>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<AUX_TipoSolicitud>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<AUX_TipoSolicitud>()
                .Property(e => e.Rubro)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Area>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Area>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Area>()
                .HasMany(e => e.BOL_Contrato)
                .WithRequired(e => e.BOL_Area)
                .HasForeignKey(e => e.Area)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOL_Bolsa>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Bolsa>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Bolsa>()
                .HasMany(e => e.BOL_Contrato)
                .WithRequired(e => e.BOL_Bolsa)
                .HasForeignKey(e => e.Bolsa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOL_Cargo>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Cargo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Cargo>()
                .HasMany(e => e.BOL_Contrato)
                .WithRequired(e => e.BOL_Cargo)
                .HasForeignKey(e => e.Cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOL_Contrato>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Contrato>()
                .Property(e => e.Bolsa)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Contrato>()
                .Property(e => e.Persona)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Contrato>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Contrato>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Contrato>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Contrato>()
                .Property(e => e.Control)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Persona>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Persona>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Persona>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<BOL_Persona>()
                .HasMany(e => e.BOL_Contrato)
                .WithRequired(e => e.BOL_Persona)
                .HasForeignKey(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Anticipo>()
                .Property(e => e.TipoAnticipo)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Anticipo>()
                .Property(e => e.NoCheque)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Anticipo>()
                .Property(e => e.NoTransaccion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Anticipo>()
                .HasMany(e => e.BYS_FlujoAnticipo)
                .WithRequired(e => e.BYS_Anticipo)
                .HasForeignKey(e => e.Anticipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Caja>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Caja>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Caja>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Caja>()
                .HasMany(e => e.BYS_CajaUsuario)
                .WithRequired(e => e.BYS_Caja)
                .HasForeignKey(e => e.Caja)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Caja>()
                .HasMany(e => e.BYS_IngresosCaja)
                .WithRequired(e => e.BYS_Caja)
                .HasForeignKey(e => e.Caja)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Caja>()
                .HasMany(e => e.BYS_Movimiento)
                .WithRequired(e => e.BYS_Caja)
                .HasForeignKey(e => e.Caja)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Caja>()
                .HasMany(e => e.BYS_Mivimiento)
                .WithRequired(e => e.BYS_Caja)
                .HasForeignKey(e => e.bys_caja_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Caja>()
                .HasMany(e => e.BYS_CajaUsuario1)
                .WithRequired(e => e.BYS_Caja1)
                .HasForeignKey(e => e.bys_caja_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_CajaUsuario>()
                .Property(e => e.Caja)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_CajaUsuario>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_CajaUsuario>()
                .Property(e => e.Activo)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_CajaUsuario>()
                .Property(e => e.bys_caja_id)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_CajaUsuario>()
                .Property(e => e.mae_usuario_id)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_CierreCaja>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_ClaseRubro>()
                .Property(e => e.Clase)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_ClaseRubro>()
                .Property(e => e.Rubro)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Clases>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Clases>()
                .Property(e => e.TipoSolicitud)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Clases>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Clases>()
                .Property(e => e.RubroPresupuesto)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Clases>()
                .Property(e => e.Filtro)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Clases>()
                .Property(e => e.Activo)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Clases>()
                .Property(e => e.rubro_presupuesto)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Clases>()
                .HasMany(e => e.ALM_BienesServicios)
                .WithRequired(e => e.BYS_Clases)
                .HasForeignKey(e => e.Clase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Clases>()
                .HasMany(e => e.BYS_ClaseRubro)
                .WithRequired(e => e.BYS_Clases)
                .HasForeignKey(e => e.Clase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Clases>()
                .HasMany(e => e.TER_ClaseTercero)
                .WithRequired(e => e.BYS_Clases)
                .HasForeignKey(e => e.Clase);

            modelBuilder.Entity<BYS_Clases>()
                .HasMany(e => e.BYS_Solicitud)
                .WithRequired(e => e.BYS_Clases)
                .HasForeignKey(e => e.Clase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Clases>()
                .HasMany(e => e.BYS_SolicitudServicio)
                .WithRequired(e => e.BYS_Clases)
                .HasForeignKey(e => e.Clase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Conceptos>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Conceptos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Conceptos>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Conceptos>()
                .HasMany(e => e.CXP_ComprasDetalle)
                .WithRequired(e => e.BYS_Conceptos)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Conceptos>()
                .HasMany(e => e.BYS_MovimientoDetalle)
                .WithRequired(e => e.BYS_Conceptos)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_CotizacionServicio>()
                .Property(e => e.NoCotizacion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_CotizacionServicio>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_CotizacionServicio>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_CotizacionServicio>()
                .HasMany(e => e.BYS_SCotizacionDetalle)
                .WithRequired(e => e.BYS_CotizacionServicio)
                .HasForeignKey(e => e.Cotizacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_DetalleSolicitud>()
                .Property(e => e.Comprado)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Distribucion>()
                .Property(e => e.PartParcial)
                .HasPrecision(18, 4);

            modelBuilder.Entity<BYS_Distribucion>()
                .Property(e => e.PartTotal)
                .HasPrecision(18, 4);

            modelBuilder.Entity<BYS_DistribucionReferencia>()
                .Property(e => e.Distribucion)
                .HasPrecision(18, 4);

            modelBuilder.Entity<BYS_DistribucionSolicitud>()
                .Property(e => e.Porcentaje)
                .HasPrecision(18, 4);

            modelBuilder.Entity<BYS_Documento>()
                .Property(e => e.Clase)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Documento>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Documento>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Documento>()
                .Property(e => e.CodComparacion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Documento>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Documento>()
                .Property(e => e.Visto)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Documento>()
                .Property(e => e.Recibido)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Documento>()
                .Property(e => e.Anticipo)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Documento>()
                .HasMany(e => e.ALM_NotaEntrada)
                .WithRequired(e => e.BYS_Documento)
                .HasForeignKey(e => e.OrdenCompra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Documento>()
                .HasMany(e => e.ALM_Remision)
                .WithOptional(e => e.BYS_Documento)
                .HasForeignKey(e => e.Documento);

            modelBuilder.Entity<BYS_Documento>()
                .HasMany(e => e.BYS_SolicitudCotizacion)
                .WithRequired(e => e.BYS_Documento)
                .HasForeignKey(e => e.Cotizacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Documento>()
                .HasMany(e => e.BYS_DocumentoDetalle)
                .WithRequired(e => e.BYS_Documento)
                .HasForeignKey(e => e.Documento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Documento>()
                .HasMany(e => e.BYS_RetencionOC)
                .WithRequired(e => e.BYS_Documento)
                .HasForeignKey(e => e.OrdenCompra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_DocumentoDetalle>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_DocumentoDetalle>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_DocumentoDetalle>()
                .HasMany(e => e.BYS_DetDocDetalle)
                .WithRequired(e => e.BYS_DocumentoDetalle)
                .HasForeignKey(e => e.DetDocumento);

            modelBuilder.Entity<BYS_DocumentoDetalle>()
                .HasMany(e => e.BYS_Distribucion)
                .WithRequired(e => e.BYS_DocumentoDetalle)
                .HasForeignKey(e => e.Detalle);

            modelBuilder.Entity<BYS_Firmas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Firmas>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Firmas>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_FlujoAnticipo>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_FlujoAnticipo>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_FlujoAprobacion>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_FlujoAprobacion>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_FlujoServicio>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_FlujoServicio>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_FuenteSolicitud>()
                .Property(e => e.Fuente)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_FuenteSolicitud>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_IngresosCaja>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_IngresosCaja>()
                .Property(e => e.TipoGiro)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_IngresosCaja>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_IngresosCaja>()
                .Property(e => e.Caja)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.id)
                .HasPrecision(19, 0);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.bys_caja_id)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.iva)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.mae_subcentro_id)
                .HasPrecision(19, 0);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.no_factura)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.pre_presupuesto_id)
                .HasPrecision(19, 0);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.recibe)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.subtotal)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.ter_tercero_id)
                .HasPrecision(19, 0);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.total)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.total_adicion)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.total_deduccion)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.total_estimado)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.total_iva)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.total_retencion)
                .HasPrecision(19, 2);

            modelBuilder.Entity<BYS_Mivimiento>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Movimiento>()
                .Property(e => e.NoFactura)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Movimiento>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Movimiento>()
                .Property(e => e.Caja)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Movimiento>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Movimiento>()
                .Property(e => e.Recibe)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Movimiento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Movimiento>()
                .HasMany(e => e.BYS_MovimientoDetalle)
                .WithRequired(e => e.BYS_Movimiento)
                .HasForeignKey(e => e.Movimiento);

            modelBuilder.Entity<BYS_Movimiento>()
                .HasMany(e => e.BYS_RetencionCaja)
                .WithRequired(e => e.BYS_Movimiento)
                .HasForeignKey(e => e.Movimiento);

            modelBuilder.Entity<BYS_MovimientoDetalle>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_MovimientoDetalle>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_SCotizacionDetalle>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_SolContrato>()
                .Property(e => e.NoActa)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_SolContrato>()
                .Property(e => e.Supervisor)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_SolContrato>()
                .Property(e => e.FormaPago)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_SolContrato>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_SolContrato>()
                .Property(e => e.Requerimiento)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Solicitud>()
                .Property(e => e.Clase)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Solicitud>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Solicitud>()
                .Property(e => e.Justificacion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Solicitud>()
                .Property(e => e.TipoRP)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Solicitud>()
                .Property(e => e.TipoSolicitud)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Solicitud>()
                .Property(e => e.Publicidad)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Solicitud>()
                .Property(e => e.Mercadeo)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_Solicitud>()
                .HasMany(e => e.ALM_NotaSalida)
                .WithRequired(e => e.BYS_Solicitud)
                .HasForeignKey(e => e.Solicitud)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Solicitud>()
                .HasMany(e => e.ALM_Remision)
                .WithOptional(e => e.BYS_Solicitud)
                .HasForeignKey(e => e.Solicitud);

            modelBuilder.Entity<BYS_Solicitud>()
                .HasMany(e => e.BYS_DetalleSolicitud)
                .WithRequired(e => e.BYS_Solicitud)
                .HasForeignKey(e => e.Solicitud)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Solicitud>()
                .HasMany(e => e.BYS_DistribucionSolicitud)
                .WithRequired(e => e.BYS_Solicitud)
                .HasForeignKey(e => e.Solicitud)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Solicitud>()
                .HasMany(e => e.BYS_FlujoAprobacion)
                .WithRequired(e => e.BYS_Solicitud)
                .HasForeignKey(e => e.Solicitud)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_Solicitud>()
                .HasMany(e => e.BYS_SolicitudCotizacion)
                .WithRequired(e => e.BYS_Solicitud)
                .HasForeignKey(e => e.Solicitud)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_SolicitudServicio>()
                .Property(e => e.Clase)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_SolicitudServicio>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_SolicitudServicio>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_SolicitudServicio>()
                .Property(e => e.Justificacion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_SolicitudServicio>()
                .Property(e => e.Contrato)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_SolicitudServicio>()
                .Property(e => e.Mercadeo)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_SolicitudServicio>()
                .HasMany(e => e.BYS_CotizacionServicio)
                .WithRequired(e => e.BYS_SolicitudServicio)
                .HasForeignKey(e => e.SolicitudServicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_SolicitudServicio>()
                .HasMany(e => e.BYS_DistribucionServicio)
                .WithRequired(e => e.BYS_SolicitudServicio)
                .HasForeignKey(e => e.SolicitudServicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_SolicitudServicio>()
                .HasMany(e => e.BYS_FlujoServicio)
                .WithRequired(e => e.BYS_SolicitudServicio)
                .HasForeignKey(e => e.SolicitudServicion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_SolicitudServicio>()
                .HasMany(e => e.BYS_FuenteSolicitud)
                .WithRequired(e => e.BYS_SolicitudServicio)
                .HasForeignKey(e => e.Solicitud)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_SolicitudServicio>()
                .HasMany(e => e.BYS_RetencionS)
                .WithRequired(e => e.BYS_SolicitudServicio)
                .HasForeignKey(e => e.SolicitudServicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_SolicitudServicio>()
                .HasMany(e => e.BYS_SolContrato)
                .WithRequired(e => e.BYS_SolicitudServicio)
                .HasForeignKey(e => e.SolicitudServicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_SolicitudServicio>()
                .HasMany(e => e.BYS_SServicioDetalle)
                .WithRequired(e => e.BYS_SolicitudServicio)
                .HasForeignKey(e => e.SolicitudServicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_SServicioDetalle>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_TipoAnticipo>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_TipoAnticipo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_TipoAnticipo>()
                .HasMany(e => e.BYS_Anticipo)
                .WithRequired(e => e.BYS_TipoAnticipo)
                .HasForeignKey(e => e.TipoAnticipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BYS_TipoSolicitud>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_TipoSolicitud>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BYS_TipoSolicitud>()
                .HasMany(e => e.BYS_Clases)
                .WithRequired(e => e.BYS_TipoSolicitud)
                .HasForeignKey(e => e.TipoSolicitud)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BysCierreCaja>()
                .Property(e => e.id)
                .HasPrecision(19, 0);

            modelBuilder.Entity<BysCierreCaja>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<BysCierreCaja>()
                .Property(e => e.total)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CAR_AjusteCreditoDet>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_AjusteCreditoDet>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_AjusteCreditoDet>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_AjusteCreditoDet>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_AjusteCreditoDet>()
                .HasMany(e => e.CAR_BeneficiariosAjuste)
                .WithRequired(e => e.CAR_AjusteCreditoDet)
                .HasForeignKey(e => e.AjusteCreditoDet);

            modelBuilder.Entity<CAR_AjustesCredito>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_AjustesCredito>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_AjustesCredito>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_AjustesCredito>()
                .HasMany(e => e.CAR_AjusteCreditoDet)
                .WithRequired(e => e.CAR_AjustesCredito)
                .HasForeignKey(e => e.AjusteCredito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAR_BeneficiariosAjuste>()
                .Property(e => e.idTransaccion)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CAR_BeneficiariosAjuste>()
                .Property(e => e.Documento)
                .HasPrecision(20, 0);

            modelBuilder.Entity<CAR_BeneficiariosAjuste>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_BeneficiariosAjuste>()
                .Property(e => e.Parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Cartera>()
                .Property(e => e.idOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Cartera>()
                .Property(e => e.NomOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Cartera>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Cartera>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Cartera>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Cartera>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Cartera>()
                .HasMany(e => e.CNT_CruceDetalle)
                .WithRequired(e => e.CAR_Cartera)
                .HasForeignKey(e => e.CxC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAR_Cartera>()
                .HasMany(e => e.CAR_FlujoCarteraDet)
                .WithRequired(e => e.CAR_Cartera)
                .HasForeignKey(e => e.Cartera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAR_Cartera>()
                .HasMany(e => e.CAR_Movimiento)
                .WithRequired(e => e.CAR_Cartera)
                .HasForeignKey(e => e.Cartera);

            modelBuilder.Entity<CAR_Cartera>()
                .HasMany(e => e.CAR_Seguimiento)
                .WithRequired(e => e.CAR_Cartera)
                .HasForeignKey(e => e.Cartera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAR_FlujoCartera>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_FlujoCartera>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_FlujoCartera>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_FlujoCartera>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_FlujoCartera>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_FlujoCartera>()
                .HasMany(e => e.CAR_FlujoCarteraDet)
                .WithRequired(e => e.CAR_FlujoCartera)
                .HasForeignKey(e => e.FlujoCartera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAR_FlujoCarteraDet>()
                .Property(e => e.Conclucion)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Movimiento>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Movimiento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Movimiento>()
                .Property(e => e.idOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Movimiento>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Seguimiento>()
                .Property(e => e.Accion)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Seguimiento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Seguimiento>()
                .Property(e => e.Conclusion)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_Seguimiento>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoEPS>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoEPS>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoEPS>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoEPS>()
                .Property(e => e.CentroCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoEPSC>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoEPSC>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoEPSC>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoNIIF>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoNIIF>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoNIIF>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoNIIF>()
                .Property(e => e.CentroCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoNIIF_EPS>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoNIIF_EPS>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoNIIF_EPS>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoNIIF_EPS>()
                .Property(e => e.CentroCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoNIIF_EPSC>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoNIIF_EPSC>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoNIIF_EPSC>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoNIIF_EPSC>()
                .Property(e => e.CentroCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoPCGA>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoPCGA>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoPCGA>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoPCGA_CCosto>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoPCGA_CCosto>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoPCGA_CCosto>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoPCGA_CCosto>()
                .Property(e => e.CCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoPCGA_CCosto>()
                .Property(e => e.CCostoNombre)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoPCGA_TER>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoPCGA_TER>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoPCGA_TER>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoPCGA_TER>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AcumuladoPCGA_TER>()
                .Property(e => e.NombreTer)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Anio_Fiscal>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Anio_Fiscal>()
                .HasMany(e => e.CNT_Periodo)
                .WithRequired(e => e.CNT_Anio_Fiscal)
                .HasForeignKey(e => e.AnioFiscal);

            modelBuilder.Entity<CNT_AsientoDetalleEPS>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleEPS>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleEPS>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleEPS>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleEPS>()
                .Property(e => e.ConceptoExogena)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleEPSC>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleEPSC>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleEPSC>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleEPSC>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleEPSC>()
                .Property(e => e.ConceptoExogena)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleNIIF>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleNIIF>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleNIIF>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleNIIF>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleNIIF_EPS>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleNIIF_EPS>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleNIIF_EPS>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleNIIF_EPS>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleNIIF_EPSC>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleNIIF_EPSC>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleNIIF_EPSC>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetalleNIIF_EPSC>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetallePCGA>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetallePCGA>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetallePCGA>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetallePCGA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoDetallePCGA>()
                .Property(e => e.ConceptoExogena)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPS>()
                .Property(e => e.Aprobado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPS>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPS>()
                .Property(e => e.NoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPS>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPS>()
                .Property(e => e.UsuarioCreador)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPS>()
                .Property(e => e.UsuarioAprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPS>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPS>()
                .Property(e => e.Cuadrado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPS>()
                .HasMany(e => e.CNT_AsientoDetalleEPS)
                .WithRequired(e => e.CNT_AsientoEPS)
                .HasForeignKey(e => e.Asiento);

            modelBuilder.Entity<CNT_AsientoEPSC>()
                .Property(e => e.Aprobado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPSC>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPSC>()
                .Property(e => e.NoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPSC>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPSC>()
                .Property(e => e.UsuarioCreador)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPSC>()
                .Property(e => e.UsuarioAprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPSC>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPSC>()
                .Property(e => e.Cuadrado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoEPSC>()
                .HasMany(e => e.CNT_AsientoDetalleEPSC)
                .WithRequired(e => e.CNT_AsientoEPSC)
                .HasForeignKey(e => e.Asiento);

            modelBuilder.Entity<CNT_AsientoNIIF>()
                .Property(e => e.Aprobado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF>()
                .Property(e => e.NoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF>()
                .Property(e => e.UsuarioCreador)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF>()
                .Property(e => e.UsuarioAprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF>()
                .HasMany(e => e.CNT_AsientoDetalleNIIF)
                .WithRequired(e => e.CNT_AsientoNIIF)
                .HasForeignKey(e => e.Asiento);

            modelBuilder.Entity<CNT_AsientoNIIF_EPS>()
                .Property(e => e.Aprobado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPS>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPS>()
                .Property(e => e.NoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPS>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPS>()
                .Property(e => e.UsuarioCreador)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPS>()
                .Property(e => e.UsuarioAprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPS>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPS>()
                .HasMany(e => e.CNT_AsientoDetalleNIIF_EPS)
                .WithRequired(e => e.CNT_AsientoNIIF_EPS)
                .HasForeignKey(e => e.Asiento);

            modelBuilder.Entity<CNT_AsientoNIIF_EPSC>()
                .Property(e => e.Aprobado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPSC>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPSC>()
                .Property(e => e.NoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPSC>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPSC>()
                .Property(e => e.UsuarioCreador)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPSC>()
                .Property(e => e.UsuarioAprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPSC>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPSC>()
                .Property(e => e.Cuadrado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoNIIF_EPSC>()
                .HasMany(e => e.CNT_AsientoDetalleNIIF_EPSC)
                .WithRequired(e => e.CNT_AsientoNIIF_EPSC)
                .HasForeignKey(e => e.Asiento);

            modelBuilder.Entity<CNT_AsientoPCGA>()
                .Property(e => e.Aprobado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoPCGA>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoPCGA>()
                .Property(e => e.NoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoPCGA>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoPCGA>()
                .Property(e => e.UsuarioCreador)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoPCGA>()
                .Property(e => e.UsuarioAprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoPCGA>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoPCGA>()
                .Property(e => e.Cuadrado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoPCGA>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoPCGA>()
                .Property(e => e.idExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoPCGA>()
                .Property(e => e.TablaExterna)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoPCGA>()
                .Property(e => e.Exportado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_AsientoPCGA>()
                .HasMany(e => e.CNT_AsientoDetallePCGA)
                .WithRequired(e => e.CNT_AsientoPCGA)
                .HasForeignKey(e => e.Asiento);

            modelBuilder.Entity<CNT_Cesion>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Cesion>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Cesion>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Cesion>()
                .HasMany(e => e.CNT_CesionDetalle)
                .WithRequired(e => e.CNT_Cesion)
                .HasForeignKey(e => e.Cesion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_CesionDetalle>()
                .Property(e => e.ConceptoCxP)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_CesionDetalle>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_ConceptoExogena>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_ConceptoExogena>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_ConceptoExogena>()
                .HasMany(e => e.CNT_PUC_General)
                .WithRequired(e => e.CNT_ConceptoExogena)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_ConceptoExogena>()
                .HasMany(e => e.CNT_PUC_GeneralEPS)
                .WithRequired(e => e.CNT_ConceptoExogena)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_ConceptoExogena>()
                .HasMany(e => e.CNT_PUC_GeneralEPSC)
                .WithRequired(e => e.CNT_ConceptoExogena)
                .HasForeignKey(e => e.TipoDisponible)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Conciliacion>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Conciliacion>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Conciliacion>()
                .Property(e => e.Banco)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Conciliacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Conciliacion>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Conciliacion>()
                .HasMany(e => e.CNT_ResumenConciliacionExtracto)
                .WithOptional(e => e.CNT_Conciliacion)
                .HasForeignKey(e => e.Conciliacion);

            modelBuilder.Entity<CNT_Conciliacion>()
                .HasMany(e => e.CNT_DetalleConciliacion)
                .WithRequired(e => e.CNT_Conciliacion)
                .HasForeignKey(e => e.DetConciliacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Conciliacion>()
                .HasMany(e => e.CNT_DetalleExtracto)
                .WithOptional(e => e.CNT_Conciliacion)
                .HasForeignKey(e => e.Conciliacion);

            modelBuilder.Entity<CNT_Conciliacion>()
                .HasMany(e => e.CNT_ResumenConciliacionLibro)
                .WithRequired(e => e.CNT_Conciliacion)
                .HasForeignKey(e => e.Conciliacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Cruce>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Cruce>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Cruce>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Cruce>()
                .HasMany(e => e.CNT_CruceDetalle)
                .WithRequired(e => e.CNT_Cruce)
                .HasForeignKey(e => e.Cruce)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_CruceDetalle>()
                .Property(e => e.ConceptoCxP)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_CruceDetalle>()
                .Property(e => e.ConceptoCxC)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_DetalleExtracto>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_DetalleExtracto>()
                .HasMany(e => e.CNT_DetalleConciliacion)
                .WithOptional(e => e.CNT_DetalleExtracto)
                .HasForeignKey(e => e.DetExtracto);

            modelBuilder.Entity<CNT_Extracto>()
                .Property(e => e.CuentaNumero)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Extracto>()
                .Property(e => e.TipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Modulos>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Modulos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Modulos>()
                .Property(e => e.Activo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Modulos>()
                .Property(e => e.EPS)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Modulos>()
                .Property(e => e.EPSC)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Modulos>()
                .Property(e => e.Tesoreria)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Modulos>()
                .HasMany(e => e.CNT_TipoDocumento)
                .WithRequired(e => e.CNT_Modulos)
                .HasForeignKey(e => e.Modulo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Notas>()
                .Property(e => e.Balance)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Notas>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Notas>()
                .Property(e => e.Nota)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Partidas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Partidas>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Partidas>()
                .Property(e => e.Accion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Partidas>()
                .HasMany(e => e.CNT_DetalleExtracto)
                .WithRequired(e => e.CNT_Partidas)
                .HasForeignKey(e => e.Partida)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Periodo>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_Periodo>()
                .HasMany(e => e.CNT_AsientoEPS)
                .WithRequired(e => e.CNT_Periodo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Periodo>()
                .HasMany(e => e.CNT_AsientoEPSC)
                .WithRequired(e => e.CNT_Periodo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Periodo>()
                .HasMany(e => e.CNT_AsientoNIIF)
                .WithRequired(e => e.CNT_Periodo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Periodo>()
                .HasMany(e => e.CNT_AsientoNIIF_EPS)
                .WithRequired(e => e.CNT_Periodo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Periodo>()
                .HasMany(e => e.CNT_AsientoNIIF_EPSC)
                .WithRequired(e => e.CNT_Periodo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Periodo>()
                .HasMany(e => e.CNT_AsientoPCGA)
                .WithRequired(e => e.CNT_Periodo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Periodo>()
                .HasMany(e => e.TES_Egreso)
                .WithRequired(e => e.CNT_Periodo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Periodo>()
                .HasMany(e => e.TES_Ingresos)
                .WithRequired(e => e.CNT_Periodo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Periodo>()
                .HasMany(e => e.TES_Notas)
                .WithRequired(e => e.CNT_Periodo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_Periodo>()
                .HasMany(e => e.TES_Traslados)
                .WithRequired(e => e.CNT_Periodo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_PlanoNovasoft>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoft>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoft>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoft>()
                .Property(e => e.Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoft>()
                .Property(e => e.TipoNova)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoft>()
                .Property(e => e.TipoTXT)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoft>()
                .Property(e => e.Prefijo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoft>()
                .Property(e => e.NombreArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoft>()
                .HasMany(e => e.CNT_PlanoNovasoftDetalle)
                .WithRequired(e => e.CNT_PlanoNovasoft)
                .HasForeignKey(e => e.PlanoNovasoft)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_PlanoNovasoftCxP>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoftCxP>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoftCxP>()
                .Property(e => e.Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoftCxP>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoftCxP>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoftCxP>()
                .Property(e => e.DocNovasoft)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoftCxP>()
                .HasMany(e => e.CNT_PlanoNovasoftDetalleCxP)
                .WithRequired(e => e.CNT_PlanoNovasoftCxP)
                .HasForeignKey(e => e.PlanoNovasoft);

            modelBuilder.Entity<CNT_PlanoNovasoftDetalle>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoftDetalleCxP>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoftDetalleCxP>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PlanoNovasoftDetalleCxP>()
                .Property(e => e.IDExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPS>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPS>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPS>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPS>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPS>()
                .Property(e => e.Acreedora)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPS>()
                .Property(e => e.Interface)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPS>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPS>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPSC>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPSC>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPSC>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPSC>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPSC>()
                .Property(e => e.Acreedora)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPSC>()
                .Property(e => e.Interface)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPSC>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoEPSC>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF>()
                .Property(e => e.Acreedora)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF>()
                .Property(e => e.Interface)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPS>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPS>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPS>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPS>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPS>()
                .Property(e => e.Acreedora)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPS>()
                .Property(e => e.Interface)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPS>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPS>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPSC>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPSC>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPSC>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPSC>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPSC>()
                .Property(e => e.Acreedora)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPSC>()
                .Property(e => e.Interface)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPSC>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoNIIF_EPSC>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoPCGA>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoPCGA>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoPCGA>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoPCGA>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoPCGA>()
                .Property(e => e.Acreedora)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoPCGA>()
                .Property(e => e.Interface)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoPCGA>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoPCGA>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PreasientoPCGA>()
                .Property(e => e.ConceptoPago)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_General>()
                .Property(e => e.Codigo_Contable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_General>()
                .Property(e => e.Sumariza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_General>()
                .Property(e => e.Nombre_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_General>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_General>()
                .Property(e => e.Tipo_cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_General>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_General>()
                .Property(e => e.Clase_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_General>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_General>()
                .Property(e => e.TipoDisponible)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_General>()
                .HasMany(e => e.CNT_AsientoDetallePCGA)
                .WithRequired(e => e.CNT_PUC_General)
                .HasForeignKey(e => e.CtaContable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_PUC_General>()
                .HasMany(e => e.CNT_PreasientoPCGA)
                .WithRequired(e => e.CNT_PUC_General)
                .HasForeignKey(e => e.CtaContable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_PUC_General>()
                .HasMany(e => e.CNT_SI_PCGA)
                .WithRequired(e => e.CNT_PUC_General)
                .HasForeignKey(e => e.CtaContable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_PUC_General>()
                .HasMany(e => e.PRE_Rubro)
                .WithRequired(e => e.CNT_PUC_General)
                .HasForeignKey(e => e.PlanCuenta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPS>()
                .Property(e => e.Codigo_Contable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPS>()
                .Property(e => e.Sumariza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPS>()
                .Property(e => e.Nombre_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPS>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPS>()
                .Property(e => e.Tipo_cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPS>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPS>()
                .Property(e => e.Clase_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPS>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPS>()
                .Property(e => e.TipoDisponible)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPS>()
                .HasMany(e => e.CNT_AsientoDetalleEPS)
                .WithRequired(e => e.CNT_PUC_GeneralEPS)
                .HasForeignKey(e => e.CtaContable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPS>()
                .HasMany(e => e.CNT_AsientoDetalleEPS1)
                .WithRequired(e => e.CNT_PUC_GeneralEPS1)
                .HasForeignKey(e => e.CtaContable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPS>()
                .HasMany(e => e.CNT_PreasientoEPS)
                .WithRequired(e => e.CNT_PUC_GeneralEPS)
                .HasForeignKey(e => e.CtaContable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPSC>()
                .Property(e => e.Codigo_Contable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPSC>()
                .Property(e => e.Sumariza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPSC>()
                .Property(e => e.Nombre_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPSC>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPSC>()
                .Property(e => e.Tipo_cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPSC>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPSC>()
                .Property(e => e.Clase_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPSC>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPSC>()
                .Property(e => e.TipoDisponible)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPSC>()
                .HasMany(e => e.CNT_AsientoDetalleEPSC)
                .WithRequired(e => e.CNT_PUC_GeneralEPSC)
                .HasForeignKey(e => e.CtaContable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_PUC_GeneralEPSC>()
                .HasMany(e => e.CNT_PreasientoEPSC)
                .WithRequired(e => e.CNT_PUC_GeneralEPSC)
                .HasForeignKey(e => e.CtaContable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_PUC_NIIF>()
                .Property(e => e.CodigoContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF>()
                .Property(e => e.Sumariza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF>()
                .Property(e => e.NombreCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF>()
                .Property(e => e.TipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF>()
                .Property(e => e.ClaseCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF>()
                .Property(e => e.TipoDisponible)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF>()
                .Property(e => e.Seccion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF>()
                .HasMany(e => e.CNT_AsientoDetalleNIIF)
                .WithRequired(e => e.CNT_PUC_NIIF)
                .HasForeignKey(e => e.CtaContable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPS>()
                .Property(e => e.CodigoContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPS>()
                .Property(e => e.Sumariza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPS>()
                .Property(e => e.NombreCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPS>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPS>()
                .Property(e => e.TipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPS>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPS>()
                .Property(e => e.ClaseCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPS>()
                .Property(e => e.TipoDisponible)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPS>()
                .Property(e => e.Seccion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPS>()
                .HasMany(e => e.CNT_AsientoDetalleNIIF_EPS)
                .WithRequired(e => e.CNT_PUC_NIIF_EPS)
                .HasForeignKey(e => e.CtaContable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPSC>()
                .Property(e => e.CodigoContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPSC>()
                .Property(e => e.Sumariza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPSC>()
                .Property(e => e.NombreCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPSC>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPSC>()
                .Property(e => e.TipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPSC>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPSC>()
                .Property(e => e.ClaseCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPSC>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPSC>()
                .Property(e => e.TipoDisponible)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPSC>()
                .Property(e => e.Seccion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_PUC_NIIF_EPSC>()
                .HasMany(e => e.CNT_AsientoDetalleNIIF_EPSC)
                .WithRequired(e => e.CNT_PUC_NIIF_EPSC)
                .HasForeignKey(e => e.CtaContable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_ResumenConciliacionExtracto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_ResumenConciliacionExtracto>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_ResumenConciliacionLibro>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_ResumenConciliacionLibro>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_ResumenConciliacionLibro>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.NomDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Tercero)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.NomTercero)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.NomArea)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Centro)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.NomCentro)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.CCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.NomCCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Clase)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.NomClase)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.NomGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Subcuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.NomSubcuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Subcuenta2)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.NomSubcuenta2)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Auxiliar)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Auxiliar>()
                .Property(e => e.Nomauxiliar)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.Clase)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.NomClase)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.NomGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.Subcuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.NomSubcuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.Subcuenta2)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.NomSubcuenta2)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.Auxiliar)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_Balance>()
                .Property(e => e.Nomauxiliar)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_BalanceEPS>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_BalanceEPS>()
                .Property(e => e.CtaCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_BalanceEPS>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_BalanceEPS>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_BalanceEPS>()
                .Property(e => e.TipoDisponible)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_BalanceEPS>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSC>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSC>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSC>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSC>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSC>()
                .Property(e => e.CodigoCCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSC>()
                .Property(e => e.NomCCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSC>()
                .Property(e => e.CodSubCentro)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSC>()
                .Property(e => e.NomSubCentro)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSC>()
                .Property(e => e.CodArea)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSC>()
                .Property(e => e.NomArea)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSS>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSS>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSS>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSS>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSS>()
                .Property(e => e.CodigoCCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSS>()
                .Property(e => e.NomCCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSS>()
                .Property(e => e.CodSubCentro)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSS>()
                .Property(e => e.NomSubCentro)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSS>()
                .Property(e => e.CodArea)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_EstadoResultadoEPSS>()
                .Property(e => e.NomArea)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiario>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiario>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiario>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiario>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiario>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiario>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiario>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiario>()
                .Property(e => e.NoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiario>()
                .Property(e => e.CodCCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiario>()
                .Property(e => e.NomCCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPS>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPS>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPS>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPS>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPS>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPS>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPS>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPS>()
                .Property(e => e.NoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPS>()
                .Property(e => e.CodCCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPS>()
                .Property(e => e.NomCCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPSC>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPSC>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPSC>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPSC>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPSC>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPSC>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPSC>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPSC>()
                .Property(e => e.NoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPSC>()
                .Property(e => e.CodCCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_RPT_LibroDiarioEPSC>()
                .Property(e => e.NomCCosto)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SaldoInicialCab>()
                .Property(e => e.Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SaldoInicialCab>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SaldoInicialCab>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SaldoInicialCab>()
                .HasMany(e => e.CNT_SI_PCGA)
                .WithRequired(e => e.CNT_SaldoInicialCab)
                .HasForeignKey(e => e.SaldoInicialCab);

            modelBuilder.Entity<CNT_SI_PCGA>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SI_PCGA>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SI_PCGA>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SI_PCGA_CCosto>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SI_PCGA_CCosto>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SI_PCGA_CCosto>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SI_PCGA_CCosto>()
                .Property(e => e.CCostoCod)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SI_PCGA_CCosto>()
                .Property(e => e.CcostoNombre)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SI_PCGA_Tercero>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SI_PCGA_Tercero>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SI_PCGA_Tercero>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SI_PCGA_Tercero>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_SI_PCGA_Tercero>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .Property(e => e.Modulo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CNT_AsientoEPS)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CNT_AsientoEPSC)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CNT_AsientoNIIF)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CNT_AsientoNIIF_EPS)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CNT_AsientoNIIF_EPSC)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CNT_AsientoPCGA)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CNT_PreasientoEPS)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CNT_PreasientoEPSC)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CNT_PreasientoNIIF)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CNT_PreasientoNIIF_EPS)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CNT_PreasientoNIIF_EPSC)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CNT_PreasientoPCGA)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CXP_Item)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.Documento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNT_TipoDocumento>()
                .HasMany(e => e.CNT_UsuariosPermisos)
                .WithRequired(e => e.CNT_TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento);

            modelBuilder.Entity<CNT_UsuariosPermisos>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CNT_UsuariosPermisos>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Amortizacion>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Amortizacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Amortizacion>()
                .Property(e => e.Causado)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Anexos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Anexos>()
                .Property(e => e.Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_AsientoLinea>()
                .Property(e => e.Campo)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_AsientoLinea>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Beneficiarios>()
                .Property(e => e.idTransaccion)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CRE_Beneficiarios>()
                .Property(e => e.Documento)
                .HasPrecision(20, 0);

            modelBuilder.Entity<CRE_Beneficiarios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Beneficiarios>()
                .Property(e => e.Parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Bienes>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Bienes>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Bienes>()
                .HasMany(e => e.CRE_Bienes_Solicitud)
                .WithRequired(e => e.CRE_Bienes)
                .HasForeignKey(e => e.Bienes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_Bienes_Solicitud>()
                .Property(e => e.Bienes)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Bienes_Solicitud>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Categoria>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Categoria>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Categoria>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Categoria>()
                .HasMany(e => e.CRE_Linea_Credito)
                .WithRequired(e => e.CRE_Categoria)
                .HasForeignKey(e => e.Categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_Concepto>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Concepto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Concepto>()
                .HasMany(e => e.CRE_Datos_Financieros)
                .WithRequired(e => e.CRE_Concepto)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_CreditosSuper>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuper>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuper>()
                .Property(e => e.TipoCredito)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuper>()
                .HasMany(e => e.CRE_CreditosSuperDet)
                .WithRequired(e => e.CRE_CreditosSuper)
                .HasForeignKey(e => e.CreditosSuper);

            modelBuilder.Entity<CRE_CreditosSuperDet>()
                .Property(e => e.Modalidad)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuperDet>()
                .Property(e => e.Categoria)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuperDet>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuperDet>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuperDet>()
                .Property(e => e.NombreI)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuperDet>()
                .Property(e => e.NombreII)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuperDet>()
                .Property(e => e.ApellidoI)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuperDet>()
                .Property(e => e.ApellidoII)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuperDet>()
                .Property(e => e.MunCliente)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuperDet>()
                .Property(e => e.NomEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuperDet>()
                .Property(e => e.NITEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_CreditosSuperDet>()
                .Property(e => e.MunEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Datos_Financieros>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Enfermedad_Padecida>()
                .Property(e => e.Enfermedad)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Enfermedad_Padecida>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Enfermedades>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Enfermedades>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Enfermedades>()
                .HasMany(e => e.CRE_Enfermedad_Padecida)
                .WithRequired(e => e.CRE_Enfermedades)
                .HasForeignKey(e => e.Enfermedad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_Linea>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Linea>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Linea>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Linea>()
                .HasMany(e => e.CRE_Linea_Credito)
                .WithRequired(e => e.CRE_Linea)
                .HasForeignKey(e => e.Linea);

            modelBuilder.Entity<CRE_Linea_Credito>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Linea_Credito>()
                .Property(e => e.Linea)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Linea_Credito>()
                .Property(e => e.Modalidad_Recaudo)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Linea_Credito>()
                .Property(e => e.Categoria)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Linea_Credito>()
                .Property(e => e.Indicador)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Linea_Credito>()
                .Property(e => e.ModalidadSuper)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Linea_Credito>()
                .HasMany(e => e.CRE_AsientoLinea)
                .WithRequired(e => e.CRE_Linea_Credito)
                .HasForeignKey(e => e.LineaCredito);

            modelBuilder.Entity<CRE_Linea_Credito>()
                .HasMany(e => e.CRE_Requisito_Linea)
                .WithRequired(e => e.CRE_Linea_Credito)
                .HasForeignKey(e => e.Linea_Credito);

            modelBuilder.Entity<CRE_Linea_Credito>()
                .HasMany(e => e.CRE_Solicitud_Credito)
                .WithRequired(e => e.CRE_Linea_Credito)
                .HasForeignKey(e => e.Linea_Credito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_Modalidad_Recaudo>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Modalidad_Recaudo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Modalidad_Recaudo>()
                .HasMany(e => e.CRE_Linea_Credito)
                .WithRequired(e => e.CRE_Modalidad_Recaudo)
                .HasForeignKey(e => e.Modalidad_Recaudo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Descripcion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Fecha_Dispersion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Tipo_Cta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Nro_Cta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Nombre_Empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Nit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Tipo_Movimiento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Codigo_Ciudad_Cta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Fecha_Aplica_Dispersion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Codigo_Oficina_Cta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Tipo_Id_Empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoft>()
                .Property(e => e.Indicador_Envio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CRE_PlanoNovasoftDetalle>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Proceso>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Proceso>()
                .HasMany(e => e.CRE_ProcesoCredito)
                .WithRequired(e => e.CRE_Proceso)
                .HasForeignKey(e => e.Procesos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_ProcesoCredito>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_ProcesoCredito>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_RecaudoCredito>()
                .Property(e => e.TipoRecaudo)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_RecaudoCredito>()
                .Property(e => e.ModoRecaudo)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_RecaudoCredito>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_RecaudoCredito>()
                .HasMany(e => e.CRE_RecaudoXamortizacion)
                .WithRequired(e => e.CRE_RecaudoCredito)
                .HasForeignKey(e => e.RecaudoCredito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_Referencia>()
                .Property(e => e.Tipo_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Referencia>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Referencia>()
                .Property(e => e.Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Referencia>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Referencia>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Referencia>()
                .Property(e => e.Parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Requisito>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Requisito>()
                .HasMany(e => e.CRE_Requisito_Linea)
                .WithRequired(e => e.CRE_Requisito)
                .HasForeignKey(e => e.Requisitos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_Requisito_Solicitud>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Requisito_Solicitud>()
                .Property(e => e.Obtenido)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .Property(e => e.Cuenta_Bancaria)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .Property(e => e.Tipo_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .Property(e => e.Banco)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .Property(e => e.HNit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .Property(e => e.HRazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .Property(e => e.HCategoria)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .Property(e => e.HIdTransaccion)
                .HasPrecision(20, 0);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .HasMany(e => e.CRE_Amortizacion)
                .WithRequired(e => e.CRE_Solicitud_Credito)
                .HasForeignKey(e => e.Credito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .HasMany(e => e.CRE_Anexos)
                .WithRequired(e => e.CRE_Solicitud_Credito)
                .HasForeignKey(e => e.SolicituCredito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .HasMany(e => e.CRE_Beneficiarios)
                .WithRequired(e => e.CRE_Solicitud_Credito)
                .HasForeignKey(e => e.SolicituCredito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .HasMany(e => e.CRE_Bienes_Solicitud)
                .WithRequired(e => e.CRE_Solicitud_Credito)
                .HasForeignKey(e => e.Solicitud_Credito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .HasMany(e => e.CRE_CreditosSuperDet)
                .WithRequired(e => e.CRE_Solicitud_Credito)
                .HasForeignKey(e => e.Credito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .HasMany(e => e.CRE_Datos_Financieros)
                .WithRequired(e => e.CRE_Solicitud_Credito)
                .HasForeignKey(e => e.Solicitud_Credito);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .HasMany(e => e.CRE_Enfermedad_Padecida)
                .WithRequired(e => e.CRE_Solicitud_Credito)
                .HasForeignKey(e => e.Solicitud_Credito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .HasMany(e => e.CRE_ProcesoCredito)
                .WithRequired(e => e.CRE_Solicitud_Credito)
                .HasForeignKey(e => e.Credito);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .HasMany(e => e.CRE_RecaudoCredito)
                .WithRequired(e => e.CRE_Solicitud_Credito)
                .HasForeignKey(e => e.SolicitudCredito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .HasMany(e => e.CRE_Referencia)
                .WithRequired(e => e.CRE_Solicitud_Credito)
                .HasForeignKey(e => e.Solicitud_Credito);

            modelBuilder.Entity<CRE_Solicitud_Credito>()
                .HasMany(e => e.CRE_Requisito_Solicitud)
                .WithRequired(e => e.CRE_Solicitud_Credito)
                .HasForeignKey(e => e.SolicitudCredito);

            modelBuilder.Entity<CRE_Validador>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Validador>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Validador>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Validador>()
                .Property(e => e.NoCobrado)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Validador>()
                .Property(e => e.idTransaccion)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CRE_Validador>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_Validador>()
                .Property(e => e.NombreTer)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_ValidadorCab>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_ValidadorCab>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_ValidadorCab>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CRE_ValidadorCab>()
                .HasMany(e => e.CRE_Validador)
                .WithRequired(e => e.CRE_ValidadorCab)
                .HasForeignKey(e => e.Cabeza);

            modelBuilder.Entity<CXC_Concepto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Concepto>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Concepto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Concepto>()
                .HasMany(e => e.CXC_Ventas)
                .WithRequired(e => e.CXC_Concepto)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CXC_Preasiento>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Preasiento>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Preasiento>()
                .Property(e => e.NombreCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Preasiento>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Preasiento>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Ventas>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Ventas>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Ventas>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Ventas>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Ventas>()
                .Property(e => e.idOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Ventas>()
                .Property(e => e.Tabla)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Ventas>()
                .Property(e => e.CtaDebito)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Ventas>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CXC_Ventas>()
                .HasMany(e => e.CXC_Preasiento)
                .WithRequired(e => e.CXC_Ventas)
                .HasForeignKey(e => e.Ventas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CXP_AnticiposCompra>()
                .Property(e => e.Valor)
                .HasPrecision(18, 1);

            modelBuilder.Entity<CXP_AnticiposCompra>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Compras>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Compras>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Compras>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Compras>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Compras>()
                .Property(e => e.idExterno)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Compras>()
                .Property(e => e.Tabla)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Compras>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Compras>()
                .Property(e => e.Anticipo)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Compras>()
                .Property(e => e.TipoFactura)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Compras>()
                .Property(e => e.TipoTercero)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Compras>()
                .Property(e => e.Diferir)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Compras>()
                .HasMany(e => e.CXP_AnticiposCompra)
                .WithRequired(e => e.CXP_Compras)
                .HasForeignKey(e => e.Compra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CXP_Compras>()
                .HasMany(e => e.CXP_ComprasDetalle)
                .WithRequired(e => e.CXP_Compras)
                .HasForeignKey(e => e.Compra);

            modelBuilder.Entity<CXP_Compras>()
                .HasMany(e => e.CXP_PlanPago)
                .WithRequired(e => e.CXP_Compras)
                .HasForeignKey(e => e.Compra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CXP_Compras>()
                .HasMany(e => e.CXP_Prorrateo)
                .WithRequired(e => e.CXP_Compras)
                .HasForeignKey(e => e.Compra);

            modelBuilder.Entity<CXP_Compras>()
                .HasMany(e => e.CXP_RetencionCompra)
                .WithRequired(e => e.CXP_Compras)
                .HasForeignKey(e => e.Compra);

            modelBuilder.Entity<CXP_ComprasDetalle>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_ComprasDetalle>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_ComprasDetalle>()
                .HasMany(e => e.CXP_CruceCuentas)
                .WithRequired(e => e.CXP_ComprasDetalle)
                .HasForeignKey(e => e.CompraDetalle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CXP_CruceCuentas>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Item>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Item>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Item>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Item>()
                .Property(e => e.Rubro)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_Item>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_PlanPago>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_PlanPago>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_RetencionCompra>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<CXP_RetencionCompra>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<dssw21>()
                .Property(e => e.OPE_LOGIN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dssw21>()
                .Property(e => e.OPE_FIRSTNAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dssw21>()
                .Property(e => e.OPE_SURNAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dssw21>()
                .Property(e => e.OPE_PASSWORD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dssw21>()
                .Property(e => e.OPE_HOOK2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dssw23>()
                .Property(e => e.NAM_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dssw25>()
                .Property(e => e.LIC_LICENCEDTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dssw25>()
                .Property(e => e.LIC_PRODUCT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dssw25>()
                .Property(e => e.LIC_SERIALNUMBER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dssw25>()
                .Property(e => e.LIC_OTHER1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dssw25>()
                .Property(e => e.LIC_OTHER2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EXT_CentroCosto>()
                .Property(e => e.Nom_CentroCosto)
                .IsUnicode(false);

            modelBuilder.Entity<EXT_CentroCosto>()
                .Property(e => e.CentroCosto)
                .IsUnicode(false);

            modelBuilder.Entity<EXT_CentroCosto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<EXT_Parafiscales>()
                .Property(e => e.TipoID)
                .IsUnicode(false);

            modelBuilder.Entity<EXT_Parafiscales>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<EXT_Parafiscales>()
                .Property(e => e.Nombre_1)
                .IsUnicode(false);

            modelBuilder.Entity<EXT_Parafiscales>()
                .Property(e => e.Nombre_2)
                .IsUnicode(false);

            modelBuilder.Entity<EXT_Parafiscales>()
                .Property(e => e.Apellido_1)
                .IsUnicode(false);

            modelBuilder.Entity<EXT_Parafiscales>()
                .Property(e => e.Apellido_2)
                .IsUnicode(false);

            modelBuilder.Entity<EXT_Parafiscales>()
                .Property(e => e.idTransaccion)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EXT_Rubro>()
                .Property(e => e.Nom_Rubro)
                .IsUnicode(false);

            modelBuilder.Entity<EXT_Rubro>()
                .Property(e => e.Rubro)
                .IsUnicode(false);

            modelBuilder.Entity<EXT_Rubro>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_AgenciaViaje>()
                .Property(e => e.Tabla)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_AgenciaViaje>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_AgenciaViaje>()
                .Property(e => e.IdentificacionDeuda)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_AnticipoFactura>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_AsientoConcepto>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_AsientoConcepto>()
                .Property(e => e.Campo)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_AsientoConcepto>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_BeneficiarioCredito>()
                .Property(e => e.Beneficiario)
                .HasPrecision(18, 0);

            modelBuilder.Entity<FAC_Cartera>()
                .Property(e => e.idOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Cartera>()
                .Property(e => e.NomOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Cartera>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Cartera>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Cartera>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Cartera>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Cartera>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Cartera>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Cartera>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Cartera>()
                .Property(e => e.CentroCosto)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Cartera>()
                .HasMany(e => e.CXP_CruceCuentas)
                .WithRequired(e => e.FAC_Cartera)
                .HasForeignKey(e => e.Cartera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAC_Cartera>()
                .HasMany(e => e.FAC_CarteraDetalle)
                .WithRequired(e => e.FAC_Cartera)
                .HasForeignKey(e => e.Cartera);

            modelBuilder.Entity<FAC_Cartera>()
                .HasMany(e => e.TES_IngresosBancoCar)
                .WithRequired(e => e.FAC_Cartera)
                .HasForeignKey(e => e.Cartera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAC_Cartera>()
                .HasMany(e => e.FAC_PreasientoCartera)
                .WithRequired(e => e.FAC_Cartera)
                .HasForeignKey(e => e.Cartera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAC_Cartera>()
                .HasMany(e => e.FAC_SeguimientoCartera)
                .WithRequired(e => e.FAC_Cartera)
                .HasForeignKey(e => e.Cartera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAC_CarteraDetalle>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_CarteraDetalle>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_CarteraDetalle>()
                .Property(e => e.Causado)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Cierre>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Cierre>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Cierre>()
                .Property(e => e.Descripción)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Concepto>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Concepto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Concepto>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Concepto>()
                .Property(e => e.CodExterno)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Concepto>()
                .Property(e => e.TipoConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Concepto>()
                .HasMany(e => e.FAC_AsientoConcepto)
                .WithRequired(e => e.FAC_Concepto)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAC_Concepto>()
                .HasMany(e => e.FAC_FormaRecaudo)
                .WithRequired(e => e.FAC_Concepto)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAC_DetalleFactura>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_DetallePagoCuotas>()
                .Property(e => e.idorigen)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_DetallePagoCuotas>()
                .Property(e => e.NomOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_DetallePagoCuotas>()
                .Property(e => e.Campo)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Factura>()
                .Property(e => e.Prefijo)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Factura>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Factura>()
                .Property(e => e.Categoria)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Factura>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Factura>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Factura>()
                .Property(e => e.idOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Factura>()
                .Property(e => e.Tabla)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Factura>()
                .Property(e => e.ValorLetras)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Factura>()
                .Property(e => e.Impresion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Factura>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Factura>()
                .HasMany(e => e.FAC_AnticipoFactura)
                .WithRequired(e => e.FAC_Factura)
                .HasForeignKey(e => e.Factura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAC_Factura>()
                .HasMany(e => e.FAC_DetalleFactura)
                .WithRequired(e => e.FAC_Factura)
                .HasForeignKey(e => e.Factura);

            modelBuilder.Entity<FAC_Factura>()
                .HasMany(e => e.FAC_MedioRecaudoVenta)
                .WithRequired(e => e.FAC_Factura)
                .HasForeignKey(e => e.Factura);

            modelBuilder.Entity<FAC_Factura>()
                .HasMany(e => e.FAC_RetencionFactura)
                .WithRequired(e => e.FAC_Factura)
                .HasForeignKey(e => e.Factura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAC_FormaRecaudo>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_FormaRecaudo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_FormaRecaudo>()
                .Property(e => e.CentroCosto)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_FormaRecaudo>()
                .Property(e => e.Cartera)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_FormaRecaudo>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_FormaRecaudo>()
                .HasMany(e => e.FAC_MedioRecaudoVenta)
                .WithRequired(e => e.FAC_FormaRecaudo)
                .HasForeignKey(e => e.FormaRecaudo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAC_MedioRecaudoVenta>()
                .Property(e => e.FormaRecaudo)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_MedioRecaudoVenta>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_PlanoNovasoft>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_PlanoNovasoft>()
                .Property(e => e.CCosto)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_PlanoNovasoft>()
                .Property(e => e.Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_PlanoNovasoft>()
                .Property(e => e.Secuencia)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_PlanoNovasoft>()
                .HasMany(e => e.FAC_PlanoNovasoftDetalle)
                .WithRequired(e => e.FAC_PlanoNovasoft)
                .HasForeignKey(e => e.PlanoNovasoft);

            modelBuilder.Entity<FAC_PlanoNovasoftDetalle>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Preasiento>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Preasiento>()
                .Property(e => e.NombreCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Preasiento>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Preasiento>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_PreasientoCartera>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_PreasientoCartera>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_PreasientoCartera>()
                .Property(e => e.NombreCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_PreasientoCartera>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_PreasientoCartera>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Precio>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Precio>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Precio>()
                .HasMany(e => e.FAC_TablaPrecio)
                .WithRequired(e => e.FAC_Precio)
                .HasForeignKey(e => e.Precio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAC_Recreacion>()
                .Property(e => e.Tabla)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Recreacion>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Recreacion>()
                .Property(e => e.IdentificacionDeuda)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_RetencionFactura>()
                .Property(e => e.CuentaContable)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Secuencia>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Secuencia>()
                .Property(e => e.Prefijo)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Secuencia>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Secuencia>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Secuencia>()
                .Property(e => e.Leyenda)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Secuencia>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_SeguimientoCartera>()
                .Property(e => e.Accion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_SeguimientoCartera>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_SeguimientoCartera>()
                .Property(e => e.Conclusion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_SeguimientoCartera>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Servicio>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Servicio>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Servicio>()
                .Property(e => e.Activo)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Servicio>()
                .Property(e => e.IVA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FAC_Servicio>()
                .Property(e => e.Clase)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Servicio>()
                .Property(e => e.Rubro)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Servicio>()
                .Property(e => e.CodExterno)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_Servicio>()
                .HasMany(e => e.FAC_DetalleFactura)
                .WithRequired(e => e.FAC_Servicio)
                .HasForeignKey(e => e.Servicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAC_Servicio>()
                .HasMany(e => e.FAC_TablaPrecio)
                .WithRequired(e => e.FAC_Servicio)
                .HasForeignKey(e => e.Servicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAC_TablaPrecio>()
                .Property(e => e.Precio)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TablaPrecio>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TablaPrecio>()
                .Property(e => e.Vigente)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TemporalFacturacion>()
                .Property(e => e.NoItem)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TemporalFacturacion>()
                .Property(e => e.NoConsecutivo)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TemporalFacturacion>()
                .Property(e => e.NombreI)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TemporalFacturacion>()
                .Property(e => e.NombreII)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TemporalFacturacion>()
                .Property(e => e.ApellidoI)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TemporalFacturacion>()
                .Property(e => e.ApellidoII)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TemporalFacturacion>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TemporalFacturacion>()
                .Property(e => e.identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TemporalFacturacion>()
                .Property(e => e.CentroCosto)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TemporalFacturacion>()
                .Property(e => e.Radicado)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TemporalFacturacion>()
                .Property(e => e.Tercero)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TurnoCartera>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<FAC_TurnoCartera>()
                .Property(e => e.Turno)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Biblioteca>()
                .Property(e => e.Servicio)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Biblioteca>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Biblioteca>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Biblioteca>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Biblioteca>()
                .Property(e => e.FormaRecaudo)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CierreCaja>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Colegio>()
                .Property(e => e.Servicio)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Colegio>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Colegio>()
                .Property(e => e.CCostos)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Colegio>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Colegio>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Colegio>()
                .Property(e => e.FormaRecaudo)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Colegio>()
                .Property(e => e.Matricula)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Colegio>()
                .Property(e => e.IdEstudiante)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Colegio>()
                .Property(e => e.NomEstudiante)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Colegio>()
                .Property(e => e.Categoria)
                .IsUnicode(false);

            modelBuilder.Entity<INT_ColegioMatricula>()
                .Property(e => e.IdentifiacionAcudiente)
                .IsUnicode(false);

            modelBuilder.Entity<INT_ColegioMatricula>()
                .Property(e => e.CodEstudiante)
                .IsUnicode(false);

            modelBuilder.Entity<INT_ColegioMatricula>()
                .Property(e => e.Anticipado)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.Exportado)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.ano_doc)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.per_doc)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.tip_doc)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.num_doc)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.reg_doc)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.fch_doc)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.cod_pro)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.val_doc)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.por_iva)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.mon_iva)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.por_des)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.mon_des)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.por_ret)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.mon_ret)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.por_ica)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.mon_ica)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.por_riv)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.mon_riv)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.ind_con)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.ano_ref)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.per_ref)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.tip_ref)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.num_ref)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.reg_ref)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.ano_ant)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.per_ant)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.tip_ant)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.doc_ant)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.reg_ant)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.ant_doc)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.ind_tra)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.cod_suc)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.cod_cco)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.cod_cl1)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.cod_cl2)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.cod_cl3)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.det_doc)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.fec_ven)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.ind_mp)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.fec_tas)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.tasa)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.num_fac)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.dia_pla)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.cod_ciu)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CxP>()
                .Property(e => e.tip_ret)
                .IsUnicode(false);

            modelBuilder.Entity<INT_FacturaPrestadores>()
                .Property(e => e.NoFactura)
                .IsUnicode(false);

            modelBuilder.Entity<INT_FacturaPrestadores>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<INT_FacturaPrestadores>()
                .Property(e => e.CodServicio)
                .IsUnicode(false);

            modelBuilder.Entity<INT_FacturaPrestadores>()
                .Property(e => e.Servicio)
                .IsUnicode(false);

            modelBuilder.Entity<INT_FacturaPrestadores>()
                .Property(e => e.NomServicio)
                .IsUnicode(false);

            modelBuilder.Entity<INT_FacturaPrestadores>()
                .Property(e => e.idRetencion)
                .IsUnicode(false);

            modelBuilder.Entity<INT_FacturaPrestadores>()
                .Property(e => e.NomRetencion)
                .IsUnicode(false);

            modelBuilder.Entity<INT_FacturaPrestadores>()
                .Property(e => e.CCostos)
                .IsUnicode(false);

            modelBuilder.Entity<INT_FacturaPrestadores>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<INT_FacturaPrestadores>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina>()
                .Property(e => e.idConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina>()
                .Property(e => e.NomConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina>()
                .Property(e => e.idTercero)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina>()
                .Property(e => e.IdTerPatronal)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina>()
                .Property(e => e.IdenPatronal)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina>()
                .Property(e => e.NomPatronal)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina>()
                .Property(e => e.GastosCosto)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina>()
                .Property(e => e.Rubro)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina2>()
                .Property(e => e.Anio)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina2>()
                .Property(e => e.Mes)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina2>()
                .Property(e => e.Id_Transaccion)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina2>()
                .Property(e => e.Tipo_Descuento)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina2>()
                .Property(e => e.NRO_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina2>()
                .Property(e => e.IdTercero)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina2>()
                .Property(e => e.ApellidosNombres)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina2>()
                .Property(e => e.IdSena)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina2>()
                .Property(e => e.IdICBF)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina2>()
                .Property(e => e.IdCCF)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina2>()
                .Property(e => e.IdARL)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina2>()
                .Property(e => e.idTerSalud)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Nomina2>()
                .Property(e => e.idTerPension)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Recreacion>()
                .Property(e => e.Servicio)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Recreacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Recreacion>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Recreacion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Recreacion>()
                .Property(e => e.FormaRecaudo)
                .IsUnicode(false);

            modelBuilder.Entity<INT_Subsidio>()
                .Property(e => e.id_beneficiario)
                .HasPrecision(18, 0);

            modelBuilder.Entity<INT_Subsidio>()
                .Property(e => e.id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<INT_Subsidio>()
                .Property(e => e.id_Recibe)
                .HasPrecision(18, 0);

            modelBuilder.Entity<INT_Subsidio>()
                .Property(e => e.Destino)
                .IsUnicode(false);

            modelBuilder.Entity<INT_SubsidioDet>()
                .Property(e => e.idRecibe)
                .IsFixedLength();

            modelBuilder.Entity<INT_SubsidioDet>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Abreviaturas>()
                .Property(e => e.Abreviatura)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Abreviaturas>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Abreviaturas>()
                .HasMany(e => e.TER_sucursales)
                .WithRequired(e => e.MAE_Abreviaturas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_AE_Actividad_Economica>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_AE_Actividad_Economica>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_AE_Actividad_Economica>()
                .Property(e => e.Division_Sub)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MAE_AE_Actividad_Economica>()
                .HasMany(e => e.TER_actividad_economica)
                .WithRequired(e => e.MAE_AE_Actividad_Economica)
                .HasForeignKey(e => e.Actividad_Economica)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_AE_Division>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MAE_AE_Division>()
                .Property(e => e.Seccion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MAE_AE_Division>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_AE_Division>()
                .HasMany(e => e.MAE_AE_Division_sub)
                .WithOptional(e => e.MAE_AE_Division)
                .HasForeignKey(e => e.Division);

            modelBuilder.Entity<MAE_AE_Division_sub>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MAE_AE_Division_sub>()
                .Property(e => e.Division)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MAE_AE_Division_sub>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_AE_Division_sub>()
                .HasMany(e => e.MAE_AE_Actividad_Economica)
                .WithRequired(e => e.MAE_AE_Division_sub)
                .HasForeignKey(e => e.Division_Sub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_AE_Seccion>()
                .Property(e => e.Codigo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MAE_AE_Seccion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_AE_Seccion>()
                .HasMany(e => e.MAE_AE_Division)
                .WithOptional(e => e.MAE_AE_Seccion)
                .HasForeignKey(e => e.Seccion);

            modelBuilder.Entity<MAE_Ciudad>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Ciudad>()
                .Property(e => e.Departamento)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Ciudad>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Ciudad>()
                .HasMany(e => e.CRE_Solicitud_Credito)
                .WithRequired(e => e.MAE_Ciudad)
                .HasForeignKey(e => e.Ciudad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Ciudad>()
                .HasMany(e => e.TES_CuentasBancarias)
                .WithRequired(e => e.MAE_Ciudad)
                .HasForeignKey(e => e.Ciudad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Ciudad>()
                .HasMany(e => e.MAE_Vereda)
                .WithRequired(e => e.MAE_Ciudad)
                .HasForeignKey(e => e.Ciudad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Condiciones_Pago>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Condiciones_Pago>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Departamento>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Departamento>()
                .Property(e => e.Pais)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Departamento>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Departamento>()
                .HasMany(e => e.MAE_Ciudad)
                .WithRequired(e => e.MAE_Departamento)
                .HasForeignKey(e => e.Departamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Empresa>()
                .Property(e => e.NIT)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Empresa>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Empresa>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Empresa>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Empresa>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Empresa>()
                .Property(e => e.Id_Representante)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Empresa>()
                .Property(e => e.Nom_Representante)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Empresa>()
                .Property(e => e.Contador)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Empresa>()
                .Property(e => e.TpContador)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Empresa>()
                .Property(e => e.RevisorFis)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Empresa>()
                .Property(e => e.TpRevisor)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Empresa>()
                .HasMany(e => e.MAE_Subcentro)
                .WithRequired(e => e.MAE_Empresa)
                .HasForeignKey(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Menu>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Menu>()
                .Property(e => e.Opcion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Menu>()
                .HasMany(e => e.MAE_Permisos)
                .WithRequired(e => e.MAE_Menu)
                .HasForeignKey(e => e.Menu);

            modelBuilder.Entity<MAE_Pais>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Pais>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Pais>()
                .HasMany(e => e.MAE_Departamento)
                .WithRequired(e => e.MAE_Pais)
                .HasForeignKey(e => e.Pais)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Permisos>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Permisos>()
                .Property(e => e.Permiso)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Reporte>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Reporte>()
                .Property(e => e.TipoReporte)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Reporte>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Reporte>()
                .Property(e => e.Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Reporte>()
                .Property(e => e.VentanaParametro)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Reporte>()
                .Property(e => e.Parametros)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_ReporteUsuario>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_ReporteUsuario>()
                .Property(e => e.Reporte)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Retefuente>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Retefuente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Retefuente>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Retefuente>()
                .Property(e => e.Calculo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Retefuente>()
                .Property(e => e.PorIVA)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MAE_Retefuente>()
                .HasMany(e => e.BYS_RetencionCaja)
                .WithRequired(e => e.MAE_Retefuente)
                .HasForeignKey(e => e.Retencion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .Property(e => e.Pertenece)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .Property(e => e.Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .Property(e => e.UltimoNivel)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .Property(e => e.CntPertenece)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .Property(e => e.CntNombre)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .Property(e => e.GastosCosto)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .Property(e => e.Organigrama)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .Property(e => e.CodigoOLD)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .Property(e => e.CodigoNew)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .Property(e => e.CodNova)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.ALM_NotaEntrada)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.ALM_NotaSalida)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.ALM_Remision)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.AUX_jefe_centro_costo)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.Centro_Costo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.BYS_DistribucionSolicitud)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.BYS_Movimiento)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.BYS_Solicitud)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.BYS_SolicitudServicio)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.CAR_Cartera)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.CNT_AsientoDetalleEPS)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentoCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.CNT_AsientoDetalleEPSC)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentoCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.CNT_AsientoDetalleNIIF)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentoCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.CNT_AsientoDetalleNIIF_EPS)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentoCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.CNT_AsientoDetalleNIIF_EPSC)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentoCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.CNT_AsientoDetallePCGA)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentoCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.CXC_Ventas)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.CXP_Prorrateo)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.FAC_Cierre)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.FAC_Factura)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.FAC_Secuencia)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.FAC_Servicio)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.NOM_DistribucionContrato)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CCsoto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.TES_NotasDetalle)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.TES_TrasladoDet)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.TES_TrasladosInternos)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.MAE_Usuario_Centro_Costo)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.Centro_Costo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.TES_IngresosBancoDet)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.PRE_Presupuesto)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.Centro_Costo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.SER_ProrrateoContratos)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Subcentro>()
                .HasMany(e => e.PRE_SolicitudCDP)
                .WithRequired(e => e.MAE_Subcentro)
                .HasForeignKey(e => e.SubCentro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Tipo_Comprobantes>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Tipo_Comprobantes>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Tipo_Comprobantes>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Tipo_Comprobantes>()
                .Property(e => e.Modulo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Tipo_Identificacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Tipo_Identificacion>()
                .HasMany(e => e.TER_Tercero)
                .WithRequired(e => e.MAE_Tipo_Identificacion)
                .HasForeignKey(e => e.TipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Tipo_Movimiento>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_TipoReportes>()
                .Property(e => e.Modulo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_TipoReportes>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Usuario>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Usuario>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Usuario>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Usuario>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Usuario>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Usuario>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Usuario>()
                .Property(e => e.CodCargo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Usuario>()
                .Property(e => e.NomCargo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Usuario>()
                .HasMany(e => e.BYS_CajaUsuario)
                .WithRequired(e => e.MAE_Usuario)
                .HasForeignKey(e => e.mae_usuario_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Usuario>()
                .HasMany(e => e.BYS_CajaUsuario1)
                .WithRequired(e => e.MAE_Usuario1)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Usuario>()
                .HasMany(e => e.BYS_FlujoAprobacion)
                .WithRequired(e => e.MAE_Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Usuario>()
                .HasMany(e => e.MAE_Usuario_Centro_Costo)
                .WithRequired(e => e.MAE_Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Usuario_Centro_Costo>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Usuario_Centro_Costo>()
                .HasMany(e => e.CRE_RecaudoCredito)
                .WithRequired(e => e.MAE_Usuario_Centro_Costo)
                .HasForeignKey(e => e.UsuarioCentro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAE_Vereda>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Vereda>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Vereda>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MAE_Vereda>()
                .HasMany(e => e.TER_sucursales)
                .WithRequired(e => e.MAE_Vereda)
                .HasForeignKey(e => e.Vereda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MIG_CabCxP>()
                .HasMany(e => e.MIG_DetCxP)
                .WithRequired(e => e.MIG_CabCxP)
                .HasForeignKey(e => e.CabCxP);

            modelBuilder.Entity<NOM_Cargo>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Cargo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Cargo>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Cargo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Cargo>()
                .HasMany(e => e.NOM_Contrato)
                .WithRequired(e => e.NOM_Cargo)
                .HasForeignKey(e => e.Cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOM_Colilla>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Colilla>()
                .Property(e => e.Indicador)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Concepto>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Concepto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Concepto>()
                .Property(e => e.RubroGasto)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Concepto>()
                .Property(e => e.RubroCosto)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Concepto>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Concepto>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Concepto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Concepto>()
                .HasMany(e => e.NOM_Colilla)
                .WithRequired(e => e.NOM_Concepto)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOM_Contrato>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Contrato>()
                .Property(e => e.NoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Contrato>()
                .Property(e => e.TipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Contrato>()
                .Property(e => e.Banco)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Contrato>()
                .HasMany(e => e.NOM_DistribucionContrato)
                .WithRequired(e => e.NOM_Contrato)
                .HasForeignKey(e => e.Contrato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOM_Nomina>()
                .Property(e => e.TipoNomina)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Nomina>()
                .Property(e => e.Leyenda)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_Nomina>()
                .HasMany(e => e.NOM_NominaDet)
                .WithRequired(e => e.NOM_Nomina)
                .HasForeignKey(e => e.Nomina)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOM_NominaDet>()
                .HasMany(e => e.NOM_Colilla)
                .WithRequired(e => e.NOM_NominaDet)
                .HasForeignKey(e => e.NominaDet);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.SaludEmpleado)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.SaludEmpleador)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.RiesgoProfecional)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.FondoPensionesEmpleado)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.FondoPensionesEmpleador)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.ICBF)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.SENA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.CajaCompensacion)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.Cesantia)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.IntCesantia)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.PrimaServicio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.Vacaciones)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.Esap)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.EscuelasIndustriales)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.UVT)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.FondoSolidaridad1)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.FondoSolidaridad2)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.FondoSolidaridad3)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.FondoSolidaridad4)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.FondoSolidaridad5)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.FondoSolidaridad6)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.RN)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.HED)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.HEN)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.HODF)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.HEDDF)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.HENDF)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_Parametros>()
                .Property(e => e.Retencion)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NOM_TipoContrato>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_TipoContrato>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_TipoContrato>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_TipoContrato>()
                .HasMany(e => e.NOM_Contrato)
                .WithRequired(e => e.NOM_TipoContrato)
                .HasForeignKey(e => e.TipoContrato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOM_TipoNomina>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_TipoNomina>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_TipoNomina>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_TipoNomina>()
                .HasMany(e => e.NOM_Nomina)
                .WithRequired(e => e.NOM_TipoNomina)
                .HasForeignKey(e => e.TipoNomina)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_Anio>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Anio>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Anio>()
                .Property(e => e.Periodicidad)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Detalle_Pre_X_Dependencia>()
                .Property(e => e.Periodicicad)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Detalle_Pre_X_Dependencia>()
                .Property(e => e.Codigo_Rubro)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Detalle_Pre_X_Dependencia>()
                .Property(e => e.Nombre_Rubro)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Detalle_Pre_X_Dependencia>()
                .Property(e => e.Tipo_Presupuesto)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Detalle_Presupuesto>()
                .Property(e => e.Valor)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRE_Detalle_Presupuesto>()
                .Property(e => e.Disponible)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRE_Detalle_Presupuesto>()
                .Property(e => e.Comprometido)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRE_Detalle_Presupuesto>()
                .HasMany(e => e.PRE_Detalle_Traslado)
                .WithRequired(e => e.PRE_Detalle_Presupuesto)
                .HasForeignKey(e => e.Det_Presupuesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_Ejecucion>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Ejecucion>()
                .Property(e => e.Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Ejecucion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Ejecucion>()
                .Property(e => e.idExterno)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Ejecucion>()
                .Property(e => e.TablaExterna)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Ejecucion>()
                .Property(e => e.id_externo)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Ejecucion>()
                .Property(e => e.id_nota_salida)
                .HasPrecision(19, 0);

            modelBuilder.Entity<PRE_Ejecucion>()
                .Property(e => e.tabla_externa)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_FlujoCDP>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Periodicidad>()
                .Property(e => e.Rango)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Periodicidad>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Periodo>()
                .Property(e => e.Periodicidad)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Periodo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Presupuesto>()
                .Property(e => e.Codigo_Contable)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Presupuesto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Presupuesto>()
                .Property(e => e.Tipo_Presupuesto)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Presupuesto>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Presupuesto>()
                .Property(e => e.Bloqueado)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Presupuesto>()
                .HasMany(e => e.BYS_DistribucionSolicitud)
                .WithRequired(e => e.PRE_Presupuesto)
                .HasForeignKey(e => e.Presupuesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_Presupuesto>()
                .HasMany(e => e.BYS_Movimiento)
                .WithRequired(e => e.PRE_Presupuesto)
                .HasForeignKey(e => e.Presupuesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_Presupuesto>()
                .HasMany(e => e.CXP_Prorrateo)
                .WithRequired(e => e.PRE_Presupuesto)
                .HasForeignKey(e => e.Presupuesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_Presupuesto>()
                .HasMany(e => e.PRE_Detalle_Presupuesto)
                .WithRequired(e => e.PRE_Presupuesto)
                .HasForeignKey(e => e.Presupuesto);

            modelBuilder.Entity<PRE_Presupuesto>()
                .HasMany(e => e.PRE_Ejecucion)
                .WithRequired(e => e.PRE_Presupuesto)
                .HasForeignKey(e => e.Presupuesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_Presupuesto>()
                .HasMany(e => e.PRE_SolicitudCDP)
                .WithRequired(e => e.PRE_Presupuesto)
                .HasForeignKey(e => e.Presupuesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_RP>()
                .Property(e => e.Observarcion)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_RP>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Rubro>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Rubro>()
                .Property(e => e.TipoPresupuesto)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Rubro>()
                .Property(e => e.PlanCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Rubro>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Rubro>()
                .Property(e => e.TipoInversion)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Rubro>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Rubro>()
                .HasMany(e => e.BYS_ClaseRubro)
                .WithRequired(e => e.PRE_Rubro)
                .HasForeignKey(e => e.Rubro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_Rubro>()
                .HasMany(e => e.CXP_Item)
                .WithRequired(e => e.PRE_Rubro)
                .HasForeignKey(e => e.Rubro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_Rubro>()
                .HasMany(e => e.FAC_Servicio)
                .WithRequired(e => e.PRE_Rubro)
                .HasForeignKey(e => e.Rubro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_Rubro>()
                .HasMany(e => e.SER_ProrrateoContratos)
                .WithRequired(e => e.PRE_Rubro)
                .HasForeignKey(e => e.Rubro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_SolicitudCDP>()
                .Property(e => e.NumeroSolicitud)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_SolicitudCDP>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_SolicitudCDP>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_SolicitudCDP>()
                .Property(e => e.Impresion)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_SolicitudCDP>()
                .HasMany(e => e.PRE_FlujoCDP)
                .WithRequired(e => e.PRE_SolicitudCDP)
                .HasForeignKey(e => e.SolicitudCDP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_SolicitudCDP>()
                .HasMany(e => e.PRE_RP)
                .WithRequired(e => e.PRE_SolicitudCDP)
                .HasForeignKey(e => e.SolicitudCDP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_Tipo_Presupuesto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Tipo_Presupuesto>()
                .Property(e => e.Cuenta_Ini)
                .HasPrecision(15, 0);

            modelBuilder.Entity<PRE_Tipo_Presupuesto>()
                .Property(e => e.Cuenta_Fin)
                .HasPrecision(15, 0);

            modelBuilder.Entity<PRE_Tipo_Presupuesto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Tipo_Presupuesto>()
                .HasMany(e => e.PRE_Rubro)
                .WithRequired(e => e.PRE_Tipo_Presupuesto)
                .HasForeignKey(e => e.TipoPresupuesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_Tipo_Presupuesto>()
                .HasMany(e => e.PRE_Traslado)
                .WithRequired(e => e.PRE_Tipo_Presupuesto)
                .HasForeignKey(e => e.Tipo_presupuesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_TipoInversion>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_TipoInversion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_TipoInversion>()
                .HasMany(e => e.PRE_Rubro)
                .WithRequired(e => e.PRE_TipoInversion)
                .HasForeignKey(e => e.TipoInversion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_Traslado>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Traslado>()
                .Property(e => e.Tipo_presupuesto)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Traslado>()
                .Property(e => e.CentroCosto)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Traslado>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Traslado>()
                .Property(e => e.Respuesta)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Traslado>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_Traslado>()
                .HasMany(e => e.PRE_TrasladoFin)
                .WithRequired(e => e.PRE_Traslado)
                .HasForeignKey(e => e.Traslado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_Traslado>()
                .HasMany(e => e.PRE_TrasladoOrigen)
                .WithRequired(e => e.PRE_Traslado)
                .HasForeignKey(e => e.Traslado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_TrasladoFin>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_TrasladoOrigen>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Concepto>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Concepto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Concepto>()
                .HasMany(e => e.SER_MaestroContrato)
                .WithRequired(e => e.SER_Concepto)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_ConceptoRetencion>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ConceptoRetencion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Contratos>()
                .Property(e => e.NoContrato)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Contratos>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Contratos>()
                .Property(e => e.Supervisor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Contratos>()
                .Property(e => e.Interventor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Contratos>()
                .Property(e => e.Objeto)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Contratos>()
                .Property(e => e.IVA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SER_Contratos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Contratos>()
                .Property(e => e.Firma)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Contratos>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Contratos>()
                .Property(e => e.Clase)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Contratos>()
                .Property(e => e.NoActaCD)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Contratos>()
                .HasMany(e => e.SER_FuenteContrato)
                .WithRequired(e => e.SER_Contratos)
                .HasForeignKey(e => e.Contrato);

            modelBuilder.Entity<SER_Contratos>()
                .HasMany(e => e.SER_PlanPagos)
                .WithRequired(e => e.SER_Contratos)
                .HasForeignKey(e => e.Contratos);

            modelBuilder.Entity<SER_Contratos>()
                .HasMany(e => e.SER_ProrrateoContratos)
                .WithRequired(e => e.SER_Contratos)
                .HasForeignKey(e => e.Contrato);

            modelBuilder.Entity<SER_Contratos>()
                .HasMany(e => e.SER_Requerimientos)
                .WithRequired(e => e.SER_Contratos)
                .HasForeignKey(e => e.Contratos);

            modelBuilder.Entity<SER_Contratos>()
                .HasMany(e => e.SER_Retencion)
                .WithRequired(e => e.SER_Contratos)
                .HasForeignKey(e => e.Contrato);

            modelBuilder.Entity<SER_Contratos>()
                .HasMany(e => e.SER_Seguimiento)
                .WithRequired(e => e.SER_Contratos)
                .HasForeignKey(e => e.Contrato);

            modelBuilder.Entity<SER_Contratos>()
                .HasMany(e => e.SER_TipoAporteContrato)
                .WithRequired(e => e.SER_Contratos)
                .HasForeignKey(e => e.Contrato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_ContratoSuperCab>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperCab>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperCab>()
                .HasMany(e => e.SER_ContratoSuperDet)
                .WithRequired(e => e.SER_ContratoSuperCab)
                .HasForeignKey(e => e.ContratoSuperCab);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.NoContrato)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.CCosto)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.NoActaCD)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.NomSuscriptor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.CargoSuscriptor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.NomContratista)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.NIT)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.Modalidad)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.TipoContrato)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.Objeto)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.TipoAporteCoop)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.TipoAporteCCF)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.NomSupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.CargoSupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.AnticipoLegalizado)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContratoSuperDet>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Destino>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Destino>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Destino>()
                .HasMany(e => e.SER_Seguimiento)
                .WithRequired(e => e.SER_Destino)
                .HasForeignKey(e => e.Destino)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_Estados>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Estados>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Firma>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Firma>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Firma>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Firma>()
                .HasMany(e => e.SER_Contratos)
                .WithRequired(e => e.SER_Firma)
                .HasForeignKey(e => e.Firma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_FuenteContrato>()
                .Property(e => e.Fuente)
                .IsUnicode(false);

            modelBuilder.Entity<SER_FuenteContrato>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<SER_FuenteFinanciacion>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_FuenteFinanciacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SER_FuenteFinanciacion>()
                .HasMany(e => e.SER_FuenteContrato)
                .WithRequired(e => e.SER_FuenteFinanciacion)
                .HasForeignKey(e => e.Fuente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_MaestroContrato>()
                .Property(e => e.NoContrato)
                .IsUnicode(false);

            modelBuilder.Entity<SER_MaestroContrato>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_MaestroContrato>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<SER_MaestroContrato>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<SER_MaestroContrato>()
                .Property(e => e.Modalidad)
                .IsUnicode(false);

            modelBuilder.Entity<SER_MaestroContrato>()
                .Property(e => e.TipoContrato)
                .IsUnicode(false);

            modelBuilder.Entity<SER_MaestroContrato>()
                .Property(e => e.Clase)
                .IsFixedLength();

            modelBuilder.Entity<SER_Modalidad>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Modalidad>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Modalidad>()
                .HasMany(e => e.SER_MaestroContrato)
                .WithRequired(e => e.SER_Modalidad)
                .HasForeignKey(e => e.Modalidad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_PlanPagos>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<SER_PlanPagos>()
                .Property(e => e.Anticipo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_PlanPagos>()
                .Property(e => e.IVA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SER_PlanPagos>()
                .Property(e => e.Factura)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ProrrateoContratos>()
                .Property(e => e.Rubro)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ProrrateoContratos>()
                .Property(e => e.PlanCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ProrrateoContratos>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Requerimientos>()
                .Property(e => e.Requisitos)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Requerimientos>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Requerimientos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Requerimientos>()
                .Property(e => e.Scaner)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Requisitos>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Requisitos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Requisitos>()
                .HasMany(e => e.SER_Requerimientos)
                .WithRequired(e => e.SER_Requisitos)
                .HasForeignKey(e => e.Requisitos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_Seguimiento>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Seguimiento>()
                .Property(e => e.Destino)
                .IsUnicode(false);

            modelBuilder.Entity<SER_Seguimiento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SER_TipoAporte>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_TipoAporte>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SER_TipoAporte>()
                .HasMany(e => e.SER_TipoAporteContrato)
                .WithRequired(e => e.SER_TipoAporte)
                .HasForeignKey(e => e.TipoAportante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_TipoAporteContrato>()
                .Property(e => e.Responsable)
                .IsUnicode(false);

            modelBuilder.Entity<SER_TipoAporteContrato>()
                .Property(e => e.TipoAportante)
                .IsUnicode(false);

            modelBuilder.Entity<SER_TipoAporteContrato>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_TipoContratos>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_TipoContratos>()
                .Property(e => e.Cencepto)
                .IsUnicode(false);

            modelBuilder.Entity<SER_TipoContratos>()
                .HasMany(e => e.SER_ConceptoRetencion)
                .WithRequired(e => e.SER_TipoContratos)
                .HasForeignKey(e => e.Tipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_TipoContratos>()
                .HasMany(e => e.SER_MaestroContrato)
                .WithRequired(e => e.SER_TipoContratos)
                .HasForeignKey(e => e.TipoContrato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_actividad_economica>()
                .Property(e => e.Actividad_Economica)
                .IsUnicode(false);

            modelBuilder.Entity<TER_actividad_economica>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_actividad_economica>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_ClaseTercero>()
                .Property(e => e.Clase)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Cliente>()
                .Property(e => e.Nivel_Educativo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Cliente>()
                .Property(e => e.Estado_Civil)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Cliente>()
                .Property(e => e.Cabeza_Familia)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Cliente>()
                .Property(e => e.Tipo_Vivienda)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Cliente>()
                .Property(e => e.Nombre_Arrendador)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Cliente>()
                .Property(e => e.Telefono_Are)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Cliente>()
                .Property(e => e.Direccion_Are)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Cliente>()
                .Property(e => e.Lugar_Trabajo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Cliente>()
                .Property(e => e.Ciudad_LT)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Cliente>()
                .Property(e => e.Telefono_LT)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Cliente>()
                .Property(e => e.Direccion_LT)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Cliente>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Cliente>()
                .Property(e => e.TipoSangre)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Documento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Estado_Civil>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Estado_Civil>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Estado_Civil>()
                .HasMany(e => e.TER_Cliente)
                .WithRequired(e => e.TER_Estado_Civil)
                .HasForeignKey(e => e.Estado_Civil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Financiera>()
                .Property(e => e.Banco)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Financiera>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Financiera>()
                .Property(e => e.TipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<TER_General>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_General>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_gestion_calidad>()
                .Property(e => e.Norma_Version)
                .IsUnicode(false);

            modelBuilder.Entity<TER_gestion_calidad>()
                .Property(e => e.Alcance)
                .IsUnicode(false);

            modelBuilder.Entity<TER_gestion_calidad>()
                .Property(e => e.Entidad_Certificadora)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Nivel_Educativo>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Nivel_Educativo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Nivel_Educativo>()
                .HasMany(e => e.TER_Cliente)
                .WithRequired(e => e.TER_Nivel_Educativo)
                .HasForeignKey(e => e.Nivel_Educativo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Producto>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Producto>()
                .HasMany(e => e.TER_marca_tercero)
                .WithRequired(e => e.TER_Producto)
                .HasForeignKey(e => e.Productos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Proveedor>()
                .Property(e => e.Tipo_Descuento)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Proveedor>()
                .Property(e => e.Porc_Descuento)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TER_Regimen>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Regimen>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_representante>()
                .Property(e => e.Representante)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TER_representante>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_representante>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TER_representante>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_representante>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<TER_representante>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_representante>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Responsabilidades>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Responsabilidades>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Responsabilidades>()
                .HasMany(e => e.TER_ResponsabilidadesTercero)
                .WithRequired(e => e.TER_Responsabilidades)
                .HasForeignKey(e => e.Responsabilidades)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_ResponsabilidadesTercero>()
                .Property(e => e.Responsabilidades)
                .IsUnicode(false);

            modelBuilder.Entity<TER_ResponsabilidadesTercero>()
                .Property(e => e.Vigente)
                .IsUnicode(false);

            modelBuilder.Entity<TER_SeleccionProveedor>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TER_SeleccionProveedor>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TER_sucursales>()
                .Property(e => e.Vereda)
                .IsUnicode(false);

            modelBuilder.Entity<TER_sucursales>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_sucursales>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<TER_sucursales>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_sucursales>()
                .Property(e => e.Abreviatura)
                .IsUnicode(false);

            modelBuilder.Entity<TER_sucursales>()
                .Property(e => e.Dir_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<TER_sucursales>()
                .Property(e => e.Dir_nomenclatura)
                .IsUnicode(false);

            modelBuilder.Entity<TER_sucursales>()
                .Property(e => e.Dir_Edificio)
                .IsUnicode(false);

            modelBuilder.Entity<TER_sucursales>()
                .Property(e => e.Dir_Apartamento)
                .IsUnicode(false);

            modelBuilder.Entity<TER_sucursales>()
                .Property(e => e.Dir_Barrio)
                .IsUnicode(false);

            modelBuilder.Entity<TER_sucursales>()
                .Property(e => e.Principal)
                .IsUnicode(false);

            modelBuilder.Entity<TER_sucursales>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_sucursales>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.TipoContribuyente)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.Contribuyente)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.NombreI)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.NombreII)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.ApellidoI)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.ApellidoII)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.Categoria)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.idTransaccion)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.Actualizado)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.Otro_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TER_Tercero>()
                .Property(e => e.VoBo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.BYS_CotizacionServicio)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.BYS_Documento)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.BYS_Movimiento)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CAR_AjusteCreditoDet)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CAR_Cartera)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CNT_AsientoDetalleEPS)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CNT_AsientoDetalleEPSC)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CNT_AsientoDetalleNIIF)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CNT_AsientoDetalleNIIF_EPS)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CNT_AsientoDetalleNIIF_EPSC)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CNT_AsientoDetallePCGA)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CNT_Cesion)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.TerDestino)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CNT_Cesion1)
                .WithRequired(e => e.TER_Tercero1)
                .HasForeignKey(e => e.TerOrigen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CNT_Cruce)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CRE_Solicitud_Credito)
                .WithOptional(e => e.TER_Tercero)
                .HasForeignKey(e => e.Conyugue);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CRE_Solicitud_Credito1)
                .WithRequired(e => e.TER_Tercero1)
                .HasForeignKey(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CXC_Ventas)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.CXP_Compras)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.FAC_Factura)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.FAC_MedioRecaudoVenta)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.NOM_Contrato)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.ARL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.NOM_Contrato1)
                .WithRequired(e => e.TER_Tercero1)
                .HasForeignKey(e => e.Caja)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.NOM_Contrato2)
                .WithRequired(e => e.TER_Tercero2)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.NOM_Contrato3)
                .WithRequired(e => e.TER_Tercero3)
                .HasForeignKey(e => e.EPS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.NOM_Contrato4)
                .WithRequired(e => e.TER_Tercero4)
                .HasForeignKey(e => e.Pension)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.NOM_NominaDet)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.SER_MaestroContrato)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TER_actividad_economica)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TER_ClaseTercero)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero);

            modelBuilder.Entity<TER_Tercero>()
                .HasOptional(e => e.TER_Cliente)
                .WithRequired(e => e.TER_Tercero)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TER_Documento)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TER_Financiera)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TER_General)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TER_gestion_calidad)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TER_marca_tercero)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero);

            modelBuilder.Entity<TER_Tercero>()
                .HasOptional(e => e.TER_Proveedor)
                .WithRequired(e => e.TER_Tercero);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TER_representante)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TER_ResponsabilidadesTercero)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TER_SeleccionProveedor)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TER_sucursales)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TES_Egreso)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TES_Ingresos)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TES_IngresosBancoDet)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TES_NotasDetalle)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TER_TipoTercero)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TES_TrasladoDet)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tercero>()
                .HasMany(e => e.TES_TrasladosInternos)
                .WithRequired(e => e.TER_Tercero)
                .HasForeignKey(e => e.Tercero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tipo>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tipo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tipo>()
                .HasMany(e => e.TER_TipoTercero)
                .WithRequired(e => e.TER_Tipo)
                .HasForeignKey(e => e.Tipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TER_Tipo_Descuento>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tipo_Descuento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_Tipo_Descuento>()
                .HasMany(e => e.TER_Proveedor)
                .WithOptional(e => e.TER_Tipo_Descuento)
                .HasForeignKey(e => e.Tipo_Descuento);

            modelBuilder.Entity<TER_tipo_sociedad>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_tipo_sociedad>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TER_TipoTercero>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<TER_TipoTercero>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Bancos>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Bancos>()
                .Property(e => e.CodigoSector)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Bancos>()
                .Property(e => e.CodigoEntidad)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Bancos>()
                .Property(e => e.NombreBanco)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Bancos>()
                .HasMany(e => e.CRE_Solicitud_Credito)
                .WithRequired(e => e.TES_Bancos)
                .HasForeignKey(e => e.Banco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_Bancos>()
                .HasMany(e => e.TES_CuentasBancarias)
                .WithRequired(e => e.TES_Bancos)
                .HasForeignKey(e => e.Banco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_CajaUsuario>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TES_CajaUsuario>()
                .Property(e => e.Activo)
                .IsUnicode(false);

            modelBuilder.Entity<TES_ColegioIngresoDetalle>()
                .Property(e => e.Matricula)
                .IsUnicode(false);

            modelBuilder.Entity<TES_ColegioIngresoDetalle>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<TES_ColegioIngresos>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_ColegioIngresos>()
                .HasMany(e => e.TES_ColegioIngresoDetalle)
                .WithRequired(e => e.TES_ColegioIngresos)
                .HasForeignKey(e => e.ColegioIngresos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_Concepto>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Concepto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Concepto>()
                .Property(e => e.TipoConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Concepto>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Concepto>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Concepto>()
                .Property(e => e.Pendiente)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Concepto>()
                .Property(e => e.GrupoConceptos)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Concepto>()
                .Property(e => e.Visible)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Concepto>()
                .HasMany(e => e.CAR_Cartera)
                .WithRequired(e => e.TES_Concepto)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_Concepto>()
                .HasMany(e => e.TES_DetalleIngreso)
                .WithRequired(e => e.TES_Concepto)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_Concepto>()
                .HasMany(e => e.TES_IngresosBancoDet)
                .WithRequired(e => e.TES_Concepto)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_Concepto>()
                .HasMany(e => e.TES_NotasDetalle)
                .WithRequired(e => e.TES_Concepto)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_Concepto>()
                .HasMany(e => e.TES_TrasladoDet)
                .WithRequired(e => e.TES_Concepto)
                .HasForeignKey(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_Conciliacion>()
                .Property(e => e.ExtractoNumero)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Conciliacion>()
                .Property(e => e.SaldoFinal)
                .HasPrecision(20, 2);

            modelBuilder.Entity<TES_Conciliacion>()
                .HasMany(e => e.TES_EstractoBancario)
                .WithRequired(e => e.TES_Conciliacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_Control_Comprobante>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Control_Comprobante>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Control_Comprobante>()
                .Property(e => e.TipoComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Cuentas_CB>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Cuentas_CB>()
                .Property(e => e.Destinacion)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Cuentas_CB>()
                .HasMany(e => e.TES_CajaUsuario)
                .WithOptional(e => e.TES_Cuentas_CB)
                .HasForeignKey(e => e.Cuenta);

            modelBuilder.Entity<TES_Cuentas_CB>()
                .HasMany(e => e.TES_Ingresos)
                .WithRequired(e => e.TES_Cuentas_CB)
                .HasForeignKey(e => e.Caja)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .Property(e => e.Banco)
                .IsUnicode(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .Property(e => e.Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .Property(e => e.NoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .Property(e => e.Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .Property(e => e.TipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .Property(e => e.Destinacion)
                .IsUnicode(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .HasMany(e => e.CNT_Conciliacion)
                .WithRequired(e => e.TES_CuentasBancarias)
                .HasForeignKey(e => e.Cuenta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .HasMany(e => e.TES_Egreso)
                .WithRequired(e => e.TES_CuentasBancarias)
                .HasForeignKey(e => e.CuentaCB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .HasMany(e => e.TES_IngresosBancos)
                .WithRequired(e => e.TES_CuentasBancarias)
                .HasForeignKey(e => e.Banco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .HasMany(e => e.TES_Notas)
                .WithRequired(e => e.TES_CuentasBancarias)
                .HasForeignKey(e => e.CuentasCB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .HasMany(e => e.TES_Traslados)
                .WithRequired(e => e.TES_CuentasBancarias)
                .HasForeignKey(e => e.CuentaBancaria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_CuentasBancarias>()
                .HasMany(e => e.TES_TrasladosInternos)
                .WithRequired(e => e.TES_CuentasBancarias)
                .HasForeignKey(e => e.CuentaBancarias)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_DetalleEgreso>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<TES_DetalleEgreso>()
                .Property(e => e.Pendiente)
                .IsUnicode(false);

            modelBuilder.Entity<TES_DetalleIngreso>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<TES_DetalleIngreso>()
                .Property(e => e.Pendiente)
                .IsUnicode(false);

            modelBuilder.Entity<TES_DetalleIngreso>()
                .Property(e => e.FormaRecaudo)
                .IsUnicode(false);

            modelBuilder.Entity<TES_DetalleIngreso>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<TES_DetalleIngreso>()
                .Property(e => e.Banco)
                .IsUnicode(false);

            modelBuilder.Entity<TES_DetalleIngreso>()
                .Property(e => e.CtaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Egreso>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Egreso>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Egreso>()
                .Property(e => e.Prefijo)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Egreso>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Egreso>()
                .Property(e => e.ValorLetras)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Egreso>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Egreso>()
                .Property(e => e.CuentaDestino)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Egreso>()
                .Property(e => e.NoCtaDestino)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Egreso>()
                .HasMany(e => e.TES_DetalleEgreso)
                .WithRequired(e => e.TES_Egreso)
                .HasForeignKey(e => e.Egreso);

            modelBuilder.Entity<TES_EgresosPendiente>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EgresosPendiente>()
                .Property(e => e.idOrigne)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EgresosPendiente>()
                .Property(e => e.Tabla)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EgresosPendiente>()
                .Property(e => e.NoExterno)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EgresosPendiente>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EgresosPendiente>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EgresosPendiente>()
                .Property(e => e.NoInterno)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EgresosPendiente>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EgresosPendiente>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EgresosPendiente>()
                .HasMany(e => e.CNT_CesionDetalle)
                .WithRequired(e => e.TES_EgresosPendiente)
                .HasForeignKey(e => e.CxP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_EgresosPendiente>()
                .HasMany(e => e.CNT_CruceDetalle)
                .WithRequired(e => e.TES_EgresosPendiente)
                .HasForeignKey(e => e.CxP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_EgresosPendiente>()
                .HasMany(e => e.TES_DetalleEgreso)
                .WithOptional(e => e.TES_EgresosPendiente)
                .HasForeignKey(e => e.EgresosPendiente)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TES_EgresosPendiente>()
                .HasMany(e => e.TES_TrasladoDet)
                .WithRequired(e => e.TES_EgresosPendiente)
                .HasForeignKey(e => e.EgresoPendiente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_EgresosPendiente>()
                .HasMany(e => e.TES_EgresosPendienteDet)
                .WithRequired(e => e.TES_EgresosPendiente)
                .HasForeignKey(e => e.EgresoPendiente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_EgresosPendienteDet>()
                .Property(e => e.TipoMovimiento)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EgresosPendienteDet>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EstractoBancario>()
                .Property(e => e.TransaccionNro)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EstractoBancario>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EstractoBancario>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EstractoBancario>()
                .Property(e => e.DocumentoNumero)
                .IsUnicode(false);

            modelBuilder.Entity<TES_EstractoBancario>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_FormaPago>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TES_FormaPago>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TES_FormaPago>()
                .HasMany(e => e.TES_MedioRecaudo)
                .WithRequired(e => e.TES_FormaPago)
                .HasForeignKey(e => e.FormaRecaudo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_GrupoConceptos>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TES_GrupoConceptos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TES_GrupoConceptos>()
                .Property(e => e.CodArea)
                .IsUnicode(false);

            modelBuilder.Entity<TES_GrupoConceptos>()
                .HasMany(e => e.TES_Concepto)
                .WithRequired(e => e.TES_GrupoConceptos)
                .HasForeignKey(e => e.GrupoConceptos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TES_Ingresos>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Ingresos>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Ingresos>()
                .Property(e => e.ValorLetras)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Ingresos>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Ingresos>()
                .HasMany(e => e.TES_DetalleIngreso)
                .WithRequired(e => e.TES_Ingresos)
                .HasForeignKey(e => e.Ingresos);

            modelBuilder.Entity<TES_IngresosBancoDet>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancoDet>()
                .Property(e => e.Deposito)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancoDet>()
                .Property(e => e.Oservacion)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancoDet>()
                .Property(e => e.idExterno)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancoDet>()
                .Property(e => e.Pendiente)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancoDet>()
                .Property(e => e.FormaRecaudo)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancoDet>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancoDet>()
                .Property(e => e.Banco)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancoDet>()
                .Property(e => e.CtaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancoDet>()
                .HasMany(e => e.TES_IngresosBancoCar)
                .WithRequired(e => e.TES_IngresosBancoDet)
                .HasForeignKey(e => e.Detalle);

            modelBuilder.Entity<TES_IngresosBancos>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancos>()
                .Property(e => e.ValorLetras)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancos>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancos>()
                .Property(e => e.Automatico)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancos>()
                .Property(e => e.Proceso)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancos>()
                .Property(e => e.IdExterno)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancos>()
                .Property(e => e.Oigen)
                .IsUnicode(false);

            modelBuilder.Entity<TES_IngresosBancos>()
                .HasMany(e => e.TES_IngresosBancoDet)
                .WithRequired(e => e.TES_IngresosBancos)
                .HasForeignKey(e => e.IngresosBancarios);

            modelBuilder.Entity<TES_Inversiones>()
                .Property(e => e.TipoInversiones)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Inversiones>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TES_LibroAuxiliar>()
                .Property(e => e.CtaContable)
                .IsUnicode(false);

            modelBuilder.Entity<TES_LibroAuxiliar>()
                .Property(e => e.NomCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<TES_LibroAuxiliar>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<TES_LibroAuxiliar>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TES_LibroAuxiliar>()
                .HasMany(e => e.CNT_DetalleConciliacion)
                .WithOptional(e => e.TES_LibroAuxiliar)
                .HasForeignKey(e => e.LibroAuxiliar);

            modelBuilder.Entity<TES_MedioRecaudo>()
                .Property(e => e.FormaRecaudo)
                .IsUnicode(false);

            modelBuilder.Entity<TES_MedioRecaudo>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<TES_MedioRecaudo>()
                .Property(e => e.Banco)
                .IsUnicode(false);

            modelBuilder.Entity<TES_MedioRecaudo>()
                .Property(e => e.CtaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Notas>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Notas>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Notas>()
                .Property(e => e.ValorLetras)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Notas>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Notas>()
                .Property(e => e.TipoNota)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Notas>()
                .HasMany(e => e.TES_NotasDetalle)
                .WithRequired(e => e.TES_Notas)
                .HasForeignKey(e => e.Notas);

            modelBuilder.Entity<TES_NotasDetalle>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<TES_NotasDetalle>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<TES_PlanoColegio>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<TES_PlanoColegio>()
                .Property(e => e.Procesado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_PlanoColegio>()
                .HasMany(e => e.TES_PlanoColegioDet)
                .WithRequired(e => e.TES_PlanoColegio)
                .HasForeignKey(e => e.PlanoColegio);

            modelBuilder.Entity<TES_PlanoColegioDet>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<TES_PlanoColegioDet>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<TES_PlanoColegioDet>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<TES_PlanoColegioDet>()
                .Property(e => e.Factura)
                .IsUnicode(false);

            modelBuilder.Entity<TES_PlanoColegioDet>()
                .Property(e => e.CCosto)
                .IsUnicode(false);

            modelBuilder.Entity<TES_PlanoColegioDet>()
                .Property(e => e.FormaRecaudo)
                .IsUnicode(false);

            modelBuilder.Entity<TES_PlanoColegioDet>()
                .Property(e => e.Procesado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_TipoInversiones>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TES_TipoInversiones>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TES_TrasladoDet>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<TES_TrasladoDet>()
                .Property(e => e.Pendiente)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Traslados>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Traslados>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Traslados>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Traslados>()
                .Property(e => e.ValorLetras)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Traslados>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Traslados>()
                .Property(e => e.CuentaDestino)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Traslados>()
                .Property(e => e.NoCtaDestino)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Traslados>()
                .HasMany(e => e.TES_TrasladoDet)
                .WithRequired(e => e.TES_Traslados)
                .HasForeignKey(e => e.Traslado);

            modelBuilder.Entity<TES_TrasladosInternos>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TES_TrasladosInternos>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TES_TrasladosInternos>()
                .Property(e => e.NoAprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<TES_TrasladosInternos>()
                .Property(e => e.ValorLetras)
                .IsUnicode(false);

            modelBuilder.Entity<TES_TrasladosInternos>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<TES_TrasladosInternos>()
                .HasMany(e => e.TES_TrasladoInternoDet)
                .WithRequired(e => e.TES_TrasladosInternos)
                .HasForeignKey(e => e.TrasladosInternos);

            modelBuilder.Entity<XXX_Presupuesto>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<XXX_Presupuesto>()
                .Property(e => e.CCosto)
                .IsUnicode(false);

            modelBuilder.Entity<XXX_Presupuesto>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<XXX_Presupuesto>()
                .Property(e => e.Rubro)
                .IsUnicode(false);

            modelBuilder.Entity<XXX_Presupuesto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Auditoria>()
                .Property(e => e.Objeto)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Auditoria>()
                .Property(e => e.Accion)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Auditoria>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Auditoria>()
                .Property(e => e.Antes)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Auditoria>()
                .Property(e => e.Despues)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Diccionario>()
                .Property(e => e.PermiteNull)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Diccionario>()
                .Property(e => e.Autonumerico)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Entradas>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Version>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Version>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Version>()
                .Property(e => e.RutaRepositorio)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Version>()
                .Property(e => e.RutaCnt)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Version>()
                .Property(e => e.RutaCxp)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Version>()
                .Property(e => e.RutaCre)
                .IsUnicode(false);

            modelBuilder.Entity<ZYS_Version>()
                .Property(e => e.RutaContr)
                .IsUnicode(false);

            modelBuilder.Entity<dssw24>()
                .Property(e => e.LOG_OPERATORCODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dssw24>()
                .Property(e => e.LOG_MACHINENAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dssw24>()
                .Property(e => e.LOG_DESCRIPTION)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.ano_doc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.per_doc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.tip_doc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.num_doc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.reg_doc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<prueba>()
                .Property(e => e.trans)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.cod_pro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.ano_ref)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.per_ref)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.tip_ref)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.num_ref)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.val_fac)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.val_doc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.sal_doc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_iva)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.val_iva)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.ret_iva)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.sub_doc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_des)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.val_des)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.net_doc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_ret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.val_ret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.ant_doc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.doc_ant)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.val_ica)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_ica)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_riv)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.ano_ant)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.per_ant)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.tip_ant)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.cod_cl1)
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.cod_cl2)
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.cod_cl3)
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.cod_suc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.cod_cco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.ind_con)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.final)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.numche)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.ban_pos)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.num_che)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.may_val)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.men_val)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.reg_ref)
                .HasPrecision(5, 0);

            modelBuilder.Entity<prueba>()
                .Property(e => e.cod_cat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.ind_afe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_tim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.val_tim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.pre_fac)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.val_pag)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.tip_ret)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.val_imp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.num_impcue)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.ser_imp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.sub_tip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prueba>()
                .Property(e => e.bas_rti)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.bas_rii)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_sum1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.mon_sum1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_sum2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.mon_sum2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_sum3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.mon_sum3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_sum4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.mon_sum4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_res1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.mon_res1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_res2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.mon_res2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_res3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.mon_res3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.por_res4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prueba>()
                .Property(e => e.mon_res4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.NoContrato)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.NoVeSireci)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.ClaseContrato)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.OtraClase)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.Objeto)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.RecContrato)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.NITRecEntidad)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.DVRecEntidad)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.Naturaleza)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.TipoID)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.Cedula)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.NIT)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.DVProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.CCExtPRoveedor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.NomContratista)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.TipoSeguimiento)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.TipoIDProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.CCInterventor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.NITInterventor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.DVInterventor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.CCExtInterventor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.NomInterventor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.TipoIDSupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.CCSupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.NITSupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.DVSupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.CCExtSupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.NomSupervisor)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.Anticipo)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.TipoAdicion)
                .IsUnicode(false);

            modelBuilder.Entity<SER_ContraloriaDet>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Temporal_Comprobante_Egreso>()
                .Property(e => e.NoComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Temporal_Comprobante_Egreso>()
                .Property(e => e.NoCheque)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Temporal_Comprobante_Egreso>()
                .Property(e => e.Factura)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Temporal_Comprobante_Egreso>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Temporal_Traslados>()
                .Property(e => e.NoComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Temporal_Traslados>()
                .Property(e => e.NoAprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Temporal_Traslados>()
                .Property(e => e.CtaDestino)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Temporal_Traslados>()
                .Property(e => e.NoCtaDestino)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Temporal_Traslados>()
                .Property(e => e.Factura)
                .IsUnicode(false);

            modelBuilder.Entity<TES_Temporal_Traslados>()
                .Property(e => e.Concepto)
                .IsUnicode(false);
        }
    }
}
