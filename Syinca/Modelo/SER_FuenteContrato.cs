namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_FuenteContrato
    {
        public long id { get; set; }

        public long Contrato { get; set; }

        [Required]
        [StringLength(50)]
        public string Fuente { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Porcentaje { get; set; }

        [StringLength(150)]
        public string Observacion { get; set; }

        public virtual SER_Contratos SER_Contratos { get; set; }

        public virtual SER_FuenteFinanciacion SER_FuenteFinanciacion { get; set; }
    }
}
