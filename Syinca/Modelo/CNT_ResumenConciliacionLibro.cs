namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_ResumenConciliacionLibro
    {
        public long Id { get; set; }

        public DateTime Fecha { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorDB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorCR { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(100)]
        public string TipoDocumento { get; set; }

        public long Conciliacion { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public int Partida { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; }

        public virtual CNT_Conciliacion CNT_Conciliacion { get; set; }
    }
}
