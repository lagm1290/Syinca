namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_ConceptoRetencion
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        public int Retencion { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        public virtual SER_TipoContratos SER_TipoContratos { get; set; }
    }
}
