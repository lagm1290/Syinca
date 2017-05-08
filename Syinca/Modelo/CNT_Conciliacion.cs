namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_Conciliacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNT_Conciliacion()
        {
            CNT_ResumenConciliacionExtracto = new HashSet<CNT_ResumenConciliacionExtracto>();
            CNT_DetalleConciliacion = new HashSet<CNT_DetalleConciliacion>();
            CNT_DetalleExtracto = new HashSet<CNT_DetalleExtracto>();
            CNT_ResumenConciliacionLibro = new HashSet<CNT_ResumenConciliacionLibro>();
        }

        public long id { get; set; }

        public int Numero { get; set; }

        public DateTime Fecha { get; set; }

        public int Periodo { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Banco { get; set; }

        public int Cuenta { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string CtaContable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_ResumenConciliacionExtracto> CNT_ResumenConciliacionExtracto { get; set; }

        public virtual TES_CuentasBancarias TES_CuentasBancarias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_DetalleConciliacion> CNT_DetalleConciliacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_DetalleExtracto> CNT_DetalleExtracto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNT_ResumenConciliacionLibro> CNT_ResumenConciliacionLibro { get; set; }
    }
}
