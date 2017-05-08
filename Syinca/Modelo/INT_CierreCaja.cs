namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INT_CierreCaja
    {
        public long id { get; set; }

        public int Ndocumento { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        public int Ccosto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Total { get; set; }

        [Required]
        [StringLength(50)]
        public string Origen { get; set; }
    }
}
