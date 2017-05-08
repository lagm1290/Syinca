namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_RP
    {
        public int Id { get; set; }

        public int SolicitudCDP { get; set; }

        public decimal ValorCDP { get; set; }

        public decimal ValorRP { get; set; }

        public DateTime Fecha { get; set; }

        public int Usuario { get; set; }

        [StringLength(250)]
        public string Observarcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public virtual PRE_SolicitudCDP PRE_SolicitudCDP { get; set; }
    }
}
