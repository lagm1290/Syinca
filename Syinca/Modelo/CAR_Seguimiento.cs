namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAR_Seguimiento
    {
        public int id { get; set; }

        public long Cartera { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(150)]
        public string Accion { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(150)]
        public string Conclusion { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public virtual CAR_Cartera CAR_Cartera { get; set; }
    }
}
