namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_Ejecucion
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public int Periodo { get; set; }

        public DateTime Fecha { get; set; }

        public int Presupuesto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Presupuestado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Ejecutado { get; set; }

        [Required]
        [StringLength(150)]
        public string Proveedor { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string idExterno { get; set; }

        [StringLength(150)]
        public string TablaExterna { get; set; }

        public long? idNotaSalida { get; set; }

        [StringLength(50)]
        public string id_externo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? id_nota_salida { get; set; }

        [StringLength(150)]
        public string tabla_externa { get; set; }

        public virtual PRE_Presupuesto PRE_Presupuesto { get; set; }
    }
}
