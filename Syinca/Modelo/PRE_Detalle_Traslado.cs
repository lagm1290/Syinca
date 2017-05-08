namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_Detalle_Traslado
    {
        public int id { get; set; }

        public int Traslado { get; set; }

        public int Det_Presupuesto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor_Entrada { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor_Salida { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Disponible { get; set; }

        public virtual PRE_Detalle_Presupuesto PRE_Detalle_Presupuesto { get; set; }
    }
}
