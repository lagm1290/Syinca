namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAE_Subcentro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAE_Subcentro()
        {
            ALM_NotaEntrada = new HashSet<ALM_NotaEntrada>();
            ALM_NotaSalida = new HashSet<ALM_NotaSalida>();
            ALM_Remision = new HashSet<ALM_Remision>();
            AUX_jefe_centro_costo = new HashSet<AUX_jefe_centro_costo>();
            BYS_DistribucionSolicitud = new HashSet<BYS_DistribucionSolicitud>();
            BYS_Movimiento = new HashSet<BYS_Movimiento>();
            BYS_Solicitud = new HashSet<BYS_Solicitud>();
            BYS_SolicitudServicio = new HashSet<BYS_SolicitudServicio>();
            CAR_Cartera = new HashSet<CAR_Cartera>();
            CNT_AsientoDetalleEPS = new HashSet<CNT_AsientoDetalleEPS>();
            CNT_AsientoDetalleEPSC = new HashSet<CNT_AsientoDetalleEPSC>();
            CNT_AsientoDetalleNIIF = new HashSet<CNT_AsientoDetalleNIIF>();
            CNT_AsientoDetalleNIIF_EPS = new HashSet<CNT_AsientoDetalleNIIF_EPS>();
            CNT_AsientoDetalleNIIF_EPSC = new HashSet<CNT_AsientoDetalleNIIF_EPSC>();
            CNT_AsientoDetallePCGA = new HashSet<CNT_AsientoDetallePCGA>();
            CXC_Ventas = new HashSet<CXC_Ventas>();
            CXP_Prorrateo = new HashSet<CXP_Prorrateo>();
            FAC_Cierre = new HashSet<FAC_Cierre>();
            FAC_Factura = new HashSet<FAC_Factura>();
            FAC_Secuencia = new HashSet<FAC_Secuencia>();
            FAC_Servicio = new HashSet<FAC_Servicio>();
            NOM_DistribucionContrato = new HashSet<NOM_DistribucionContrato>();
            TES_NotasDetalle = new HashSet<TES_NotasDetalle>();
            TES_TrasladoDet = new HashSet<TES_TrasladoDet>();
            TES_TrasladosInternos = new HashSet<TES_TrasladosInternos>();
            MAE_Usuario_Centro_Costo = new HashSet<MAE_Usuario_Centro_Costo>();
            TES_IngresosBancoDet = new HashSet<TES_IngresosBancoDet>();
            PRE_Presupuesto = new HashSet<PRE_Presupuesto>();
            SER_ProrrateoContratos = new HashSet<SER_ProrrateoContratos>();
            PRE_SolicitudCDP = new HashSet<PRE_SolicitudCDP>();
        }

        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Pertenece { get; set; }

        [Required]
        [StringLength(50)]
        public string Empresa { get; set; }

        [Required]
        [StringLength(2)]
        public string UltimoNivel { get; set; }

        public int Nivel { get; set; }

        [StringLength(2)]
        public string CntPertenece { get; set; }

        [StringLength(150)]
        public string CntNombre { get; set; }

        [Required]
        [StringLength(50)]
        public string GastosCosto { get; set; }

        [StringLength(50)]
        public string Organigrama { get; set; }

        [StringLength(50)]
        public string CodigoOLD { get; set; }

        [Required]
        [StringLength(50)]
        public string CodigoNew { get; set; }

        [StringLength(50)]
        public string CodNova { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_NotaEntrada> ALM_NotaEntrada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_NotaSalida> ALM_NotaSalida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALM_Remision> ALM_Remision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUX_jefe_centro_costo> AUX_jefe_centro_costo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_DistribucionSolicitud> BYS_DistribucionSolicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_Movimiento> BYS_Movimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_Solicitud> BYS_Solicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BYS_SolicitudServicio> BYS_SolicitudServicio { get; set; }

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
        public virtual ICollection<CXC_Ventas> CXC_Ventas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXP_Prorrateo> CXP_Prorrateo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_Cierre> FAC_Cierre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_Factura> FAC_Factura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_Secuencia> FAC_Secuencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_Servicio> FAC_Servicio { get; set; }

        public virtual MAE_Empresa MAE_Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_DistribucionContrato> NOM_DistribucionContrato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_NotasDetalle> TES_NotasDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_TrasladoDet> TES_TrasladoDet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_TrasladosInternos> TES_TrasladosInternos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAE_Usuario_Centro_Costo> MAE_Usuario_Centro_Costo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TES_IngresosBancoDet> TES_IngresosBancoDet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_Presupuesto> PRE_Presupuesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_ProrrateoContratos> SER_ProrrateoContratos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_SolicitudCDP> PRE_SolicitudCDP { get; set; }
    }
}
