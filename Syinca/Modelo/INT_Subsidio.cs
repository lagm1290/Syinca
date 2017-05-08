namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INT_Subsidio
    {
        [Key]
        public int idTabla { get; set; }

        public decimal id_beneficiario { get; set; }

        public decimal id { get; set; }

        public decimal id_Recibe { get; set; }

        public int Periodo_Liq { get; set; }

        public decimal valor_Abonar { get; set; }

        public decimal valor_liq { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(100)]
        public string Destino { get; set; }
    }
}
