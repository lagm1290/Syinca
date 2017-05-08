namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_Seguimiento
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public long Contrato { get; set; }

        [Required]
        [StringLength(50)]
        public string Destino { get; set; }

        public DateTime FeEnvio { get; set; }

        public DateTime FeFin { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        public virtual SER_Contratos SER_Contratos { get; set; }

        public virtual SER_Destino SER_Destino { get; set; }
    }
}
