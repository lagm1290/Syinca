namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_MedioRecaudo
    {
        public long id { get; set; }

        public long Ingreso { get; set; }

        [Required]
        [StringLength(50)]
        public string FormaRecaudo { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [StringLength(50)]
        public string Banco { get; set; }

        [StringLength(50)]
        public string CtaBancaria { get; set; }

        public virtual TES_FormaPago TES_FormaPago { get; set; }
    }
}
