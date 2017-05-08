namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_DetalleFactura
    {
        public int id { get; set; }

        public long Factura { get; set; }

        public int Servicio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorUnitario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorDescuento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Descuento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TotalIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorTotal { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public virtual FAC_Factura FAC_Factura { get; set; }

        public virtual FAC_Servicio FAC_Servicio { get; set; }
    }
}
