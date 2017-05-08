namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INT_FacturaPrestadores
    {
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string NoFactura { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string CodServicio { get; set; }

        [Required]
        [StringLength(50)]
        public string Servicio { get; set; }

        [Required]
        [StringLength(250)]
        public string NomServicio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrIVA { get; set; }

        [Required]
        [StringLength(50)]
        public string idRetencion { get; set; }

        [Required]
        [StringLength(150)]
        public string NomRetencion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Base { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorRetencion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrRetencion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrTotal { get; set; }

        [Required]
        [StringLength(50)]
        public string CCostos { get; set; }

        public long idTercero { get; set; }

        public int Tipoid { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }
    }
}
