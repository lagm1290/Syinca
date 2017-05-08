namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAE_Condiciones_Pago
    {
        [Key]
        [StringLength(50)]
        public string Codigo { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public int Dias { get; set; }
    }
}
