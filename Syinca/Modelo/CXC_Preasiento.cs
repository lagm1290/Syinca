namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CXC_Preasiento
    {
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Naturaleza { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorDB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorCR { get; set; }

        [Required]
        [StringLength(20)]
        public string CuentaContable { get; set; }

        [Required]
        [StringLength(150)]
        public string NombreCuenta { get; set; }

        public long Ventas { get; set; }

        [Required]
        [StringLength(50)]
        public string Origen { get; set; }

        [StringLength(250)]
        public string Observacion { get; set; }

        public virtual CXC_Ventas CXC_Ventas { get; set; }
    }
}
