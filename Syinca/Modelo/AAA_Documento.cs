namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAA_Documento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Clase { get; set; }

        public DateTime Fe_CreacionCot { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public long Proveedor { get; set; }

        [StringLength(250)]
        public string Detalle { get; set; }

        public DateTime? Fe_Envio { get; set; }

        public DateTime? Fe_Recibo { get; set; }

        public int NoCotizacion { get; set; }

        public int NoOrden { get; set; }

        public DateTime? Fe_CreacionOr { get; set; }

        public DateTime? Fe_Inico_Compra { get; set; }

        public DateTime? Fe_Fin_Compra { get; set; }

        public int? Bodega { get; set; }

        [Required]
        [StringLength(50)]
        public string CodComparacion { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoDocumento { get; set; }

        [Required]
        [StringLength(2)]
        public string Visto { get; set; }

        [Required]
        [StringLength(2)]
        public string Recibido { get; set; }
    }
}
