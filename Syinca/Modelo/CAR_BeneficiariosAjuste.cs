namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAR_BeneficiariosAjuste
    {
        public long id { get; set; }

        public long AjusteCreditoDet { get; set; }

        public decimal idTransaccion { get; set; }

        public decimal Documento { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorSubsidio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorDisponible { get; set; }

        [Required]
        [StringLength(30)]
        public string Parentesco { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrAjuste { get; set; }

        public virtual CAR_AjusteCreditoDet CAR_AjusteCreditoDet { get; set; }
    }
}
