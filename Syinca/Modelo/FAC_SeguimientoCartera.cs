namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_SeguimientoCartera
    {
        public int id { get; set; }

        public long Cartera { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(150)]
        public string Accion { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [StringLength(150)]
        public string Conclusion { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public virtual FAC_Cartera FAC_Cartera { get; set; }
    }
}
