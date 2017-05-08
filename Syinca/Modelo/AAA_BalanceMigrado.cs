namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAA_BalanceMigrado
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO { get; set; }

        [Required]
        [StringLength(255)]
        public string DESCRIPCION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SALDOANTERIOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DEBITO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CREDITO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NUEVOSALDO { get; set; }
    }
}
