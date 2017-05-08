namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Beneficiarios
    {
        public int id { get; set; }

        public int SolicituCredito { get; set; }

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

        public virtual CRE_Solicitud_Credito CRE_Solicitud_Credito { get; set; }
    }
}
