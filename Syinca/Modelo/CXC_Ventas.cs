namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CXC_Ventas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CXC_Ventas()
        {
            CXC_Preasiento = new HashSet<CXC_Preasiento>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public int CentroCosto { get; set; }

        public int Concepto { get; set; }

        [Required]
        [StringLength(50)]
        public string NoExterno { get; set; }

        public int Numero { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }

        public long Tercero { get; set; }

        public DateTime Fe_Creacion { get; set; }

        public DateTime Fe_Documento { get; set; }

        public DateTime Fe_Vencimiento { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string idOrigen { get; set; }

        [StringLength(100)]
        public string Tabla { get; set; }

        [StringLength(20)]
        public string CtaDebito { get; set; }

        [StringLength(150)]
        public string NomCuenta { get; set; }

        public virtual CXC_Concepto CXC_Concepto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXC_Preasiento> CXC_Preasiento { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
