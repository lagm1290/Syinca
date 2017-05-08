namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAC_TemporalFacturacion
    {
        public long id { get; set; }

        [StringLength(50)]
        public string NoItem { get; set; }

        [StringLength(50)]
        public string NoConsecutivo { get; set; }

        [StringLength(50)]
        public string NombreI { get; set; }

        [StringLength(50)]
        public string NombreII { get; set; }

        [StringLength(50)]
        public string ApellidoI { get; set; }

        [StringLength(50)]
        public string ApellidoII { get; set; }

        [StringLength(50)]
        public string Tipo { get; set; }

        [StringLength(50)]
        public string identificacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Valor { get; set; }

        [StringLength(50)]
        public string CentroCosto { get; set; }

        [StringLength(1500)]
        public string Radicado { get; set; }

        [StringLength(50)]
        public string Tercero { get; set; }
    }
}
