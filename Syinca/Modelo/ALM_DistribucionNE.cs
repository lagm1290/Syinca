namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_DistribucionNE
    {
        public long id { get; set; }

        public long NotaEntrada { get; set; }

        public int CentroCosto { get; set; }

        [Required]
        [StringLength(50)]
        public string CodCCosto { get; set; }

        [Required]
        [StringLength(250)]
        public string NomCCosto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorDistribucion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public virtual ALM_NotaEntrada ALM_NotaEntrada { get; set; }
    }
}
