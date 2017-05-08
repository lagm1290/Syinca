namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_Mivimiento
    {
        [Column(TypeName = "numeric")]
        public decimal id { get; set; }

        [Required]
        [StringLength(50)]
        public string bys_caja_id { get; set; }

        public int cierre { get; set; }

        [StringLength(250)]
        public string descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string estado { get; set; }

        public DateTime fe_creacion { get; set; }

        public DateTime fe_legalizacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal mae_subcentro_id { get; set; }

        [Required]
        [StringLength(50)]
        public string no_factura { get; set; }

        public int numero { get; set; }

        public int periodo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pre_presupuesto_id { get; set; }

        [Required]
        [StringLength(150)]
        public string recibe { get; set; }

        [Column(TypeName = "numeric")]
        public decimal subtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ter_tercero_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal total { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? total_adicion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? total_deduccion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal total_estimado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal total_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal total_retencion { get; set; }

        [Required]
        [StringLength(50)]
        public string usuario { get; set; }

        public virtual BYS_Caja BYS_Caja { get; set; }
    }
}
