namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_Financiera
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(100)]
        public string Banco { get; set; }

        [Required]
        [StringLength(50)]
        public string Cuenta { get; set; }

        [Required]
        [StringLength(20)]
        public string TipoCuenta { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
