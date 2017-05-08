namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_Cierre
    {
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public int CentroCosto { get; set; }

        public int Numero { get; set; }

        public DateTime Fe_Registro { get; set; }

        public DateTime Fe_Cierre { get; set; }

        public int Anio { get; set; }

        public int Mes { get; set; }

        public int Dia { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TotalCredito { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TotalContado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Total { get; set; }

        [StringLength(150)]
        public string Descripción { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }
    }
}
