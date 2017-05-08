namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_AsientoDetalleNIIF_EPSC
    {
        public long id { get; set; }

        public long Asiento { get; set; }

        [Required]
        [StringLength(20)]
        public string CtaContable { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Naturaleza { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorDB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ValorCR { get; set; }

        public long Tercero { get; set; }

        public int CentoCosto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseRetencion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TasaRetencion { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        public virtual CNT_AsientoNIIF_EPSC CNT_AsientoNIIF_EPSC { get; set; }

        public virtual CNT_PUC_NIIF_EPSC CNT_PUC_NIIF_EPSC { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
