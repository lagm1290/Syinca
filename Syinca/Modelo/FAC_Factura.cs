namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FAC_Factura()
        {
            FAC_AnticipoFactura = new HashSet<FAC_AnticipoFactura>();
            FAC_DetalleFactura = new HashSet<FAC_DetalleFactura>();
            FAC_MedioRecaudoVenta = new HashSet<FAC_MedioRecaudoVenta>();
            FAC_RetencionFactura = new HashSet<FAC_RetencionFactura>();
        }

        public long id { get; set; }

        public int CentroCosto { get; set; }

        [Required]
        [StringLength(50)]
        public string Prefijo { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public long Tercero { get; set; }

        public DateTime Fe_Creacion { get; set; }

        public DateTime Fe_Factura { get; set; }

        public DateTime Fe_Vencimiento { get; set; }

        [Required]
        [StringLength(50)]
        public string Categoria { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(1500)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string idOrigen { get; set; }

        [Required]
        [StringLength(250)]
        public string Tabla { get; set; }

        public int Periodo { get; set; }

        public long Cierre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(500)]
        public string ValorLetras { get; set; }

        [Required]
        [StringLength(50)]
        public string Impresion { get; set; }

        [StringLength(50)]
        public string Documento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_AnticipoFactura> FAC_AnticipoFactura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_DetalleFactura> FAC_DetalleFactura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_MedioRecaudoVenta> FAC_MedioRecaudoVenta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAC_RetencionFactura> FAC_RetencionFactura { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
