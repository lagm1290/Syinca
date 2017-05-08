namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_TipoAporteContrato
    {
        public long id { get; set; }

        public long Contrato { get; set; }

        [Required]
        [StringLength(50)]
        public string Responsable { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoAportante { get; set; }

        [Required]
        [StringLength(50)]
        public string Valor { get; set; }

        public virtual SER_Contratos SER_Contratos { get; set; }

        public virtual SER_TipoAporte SER_TipoAporte { get; set; }
    }
}
