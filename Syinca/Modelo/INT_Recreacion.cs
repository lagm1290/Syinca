namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INT_Recreacion
    {
        public long id { get; set; }

        public long NoDocumento { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string Servicio { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrTotal { get; set; }

        public int? CCostos { get; set; }

        public long? idTercero { get; set; }

        public int Tipoid { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string FormaRecaudo { get; set; }

        public long? NoFactura { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VrCreditoNat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VrEfectirvo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VrCreditoJur { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VrCreditoAfi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VrCreditoNom { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VrBienestar { get; set; }
    }
}
