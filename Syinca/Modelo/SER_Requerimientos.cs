namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_Requerimientos
    {
        public long id { get; set; }

        public long Contratos { get; set; }

        [Required]
        [StringLength(50)]
        public string Requisitos { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero { get; set; }

        public DateTime FeInicio { get; set; }

        public DateTime? FeFin { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(2)]
        public string Scaner { get; set; }

        public virtual SER_Contratos SER_Contratos { get; set; }

        public virtual SER_Requisitos SER_Requisitos { get; set; }
    }
}
