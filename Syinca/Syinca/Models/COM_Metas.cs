//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Syinca.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class COM_Metas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COM_Metas()
        {
            this.COM_DetalleMeta = new HashSet<COM_DetalleMeta>();
            this.COM_DetalleMetaPromocion = new HashSet<COM_DetalleMetaPromocion>();
        }
    
        public int Id { get; set; }
        public string Tipo { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> FechaInicial { get; set; }
        public Nullable<System.DateTime> FechaFinal { get; set; }
        public Nullable<int> NroAnualEmpresas { get; set; }
        public string Estado { get; set; }
        public Nullable<decimal> PorCumplimiento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COM_DetalleMeta> COM_DetalleMeta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COM_DetalleMetaPromocion> COM_DetalleMetaPromocion { get; set; }
    }
}
