namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZYS_Version
    {
        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string Version { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [Column(TypeName = "image")]
        public byte[] Archivo { get; set; }

        [StringLength(250)]
        public string RutaRepositorio { get; set; }

        [StringLength(250)]
        public string RutaCnt { get; set; }

        [StringLength(250)]
        public string RutaCxp { get; set; }

        [StringLength(250)]
        public string RutaCre { get; set; }

        [StringLength(250)]
        public string RutaContr { get; set; }
    }
}
