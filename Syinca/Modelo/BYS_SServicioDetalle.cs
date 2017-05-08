namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_SServicioDetalle
    {
        public long id { get; set; }

        public long SolicitudServicio { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Total { get; set; }

        public virtual BYS_SolicitudServicio BYS_SolicitudServicio { get; set; }
    }
}
