namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAA_CarteraIFC
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        [StringLength(50)]
        public string NombreI { get; set; }

        [StringLength(50)]
        public string nombreII { get; set; }

        [StringLength(50)]
        public string ApellidoI { get; set; }

        [StringLength(50)]
        public string ApellidoII { get; set; }

        [StringLength(50)]
        public string NombreIII { get; set; }

        [StringLength(200)]
        public string Nombre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(20)]
        public string CodContable { get; set; }

        [StringLength(150)]
        public string NomCuenta { get; set; }
    }
}
