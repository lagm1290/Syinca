namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZYS_Diccionario
    {
        public int Id { get; set; }

        public int object_id { get; set; }

        [Required]
        [StringLength(128)]
        public string Tabla { get; set; }

        [StringLength(128)]
        public string Columna { get; set; }

        [Required]
        [StringLength(128)]
        public string Tipo { get; set; }

        public int? Precision { get; set; }

        public int Tamano { get; set; }

        [Required]
        [StringLength(2)]
        public string PermiteNull { get; set; }

        [Required]
        [StringLength(2)]
        public string Autonumerico { get; set; }

        [StringLength(128)]
        public string LlaveForanea { get; set; }

        [StringLength(128)]
        public string NomTablaReferencia { get; set; }

        [StringLength(128)]
        public string NomColumnaReferencia { get; set; }
    }
}
