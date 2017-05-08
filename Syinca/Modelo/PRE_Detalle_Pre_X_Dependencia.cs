namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_Detalle_Pre_X_Dependencia
    {
        public int id { get; set; }

        public int Subcentro { get; set; }

        [Required]
        [StringLength(40)]
        public string Periodicicad { get; set; }

        public int Anio { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo_Rubro { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre_Rubro { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo_Presupuesto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Periodo1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Periodo2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Periodo3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Periodo4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Periodo5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Periodo6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Periodo7 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Periodo8 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Periodo9 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Periodo10 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Periodo11 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Periodo12 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Total { get; set; }
    }
}
