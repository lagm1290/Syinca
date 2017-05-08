namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_IngresosCaja
    {
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero { get; set; }

        public int CuentaCB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoGiro { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Caja { get; set; }

        public virtual BYS_Caja BYS_Caja { get; set; }
    }
}
