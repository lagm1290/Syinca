namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_actividad_economica
    {
        public int id { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Actividad_Economica { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public virtual MAE_AE_Actividad_Economica MAE_AE_Actividad_Economica { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
