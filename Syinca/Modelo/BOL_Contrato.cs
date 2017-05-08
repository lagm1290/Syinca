namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BOL_Contrato
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string Bolsa { get; set; }

        [Required]
        [StringLength(50)]
        public string Persona { get; set; }

        [Required]
        [StringLength(50)]
        public string Cargo { get; set; }

        [Required]
        [StringLength(50)]
        public string Area { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Sueldo { get; set; }

        public DateTime FeInicio { get; set; }

        public DateTime FeFin { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(1)]
        public string Control { get; set; }

        public virtual BOL_Area BOL_Area { get; set; }

        public virtual BOL_Bolsa BOL_Bolsa { get; set; }

        public virtual BOL_Cargo BOL_Cargo { get; set; }

        public virtual BOL_Persona BOL_Persona { get; set; }
    }
}
