namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAR_Movimiento
    {
        public long id { get; set; }

        public long Cartera { get; set; }

        [Required]
        [StringLength(50)]
        public string Concepto { get; set; }

        public DateTime Fecha { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrPendiente { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrRecaudado { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string idOrigen { get; set; }

        [Required]
        [StringLength(150)]
        public string Origen { get; set; }

        public virtual CAR_Cartera CAR_Cartera { get; set; }
    }
}
