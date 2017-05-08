namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_Distribucion
    {
        public long id { get; set; }

        public long NotaEntrada { get; set; }

        public int Detalle { get; set; }

        public int CCosto { get; set; }

        public long Referencia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CantTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CantParcial { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PartParcial { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PartTotal { get; set; }

        public long Solicitud { get; set; }

        public long OCompra { get; set; }

        public long idCotSol { get; set; }
    }
}
