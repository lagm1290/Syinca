namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_DBDetalle
    {
        public long id { get; set; }

        public long DeBaja { get; set; }

        public long Referencia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorUnitario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorTotal { get; set; }

        [Required]
        [StringLength(50)]
        public string Motivo { get; set; }

        public long Kardex { get; set; }

        public virtual ALM_DeBaja ALM_DeBaja { get; set; }

        public virtual ALM_MotivoDebaja ALM_MotivoDebaja { get; set; }
    }
}
