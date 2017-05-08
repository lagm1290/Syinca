namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CXP_Item
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(20)]
        public string Rubro { get; set; }

        public int idIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Required]
        [StringLength(100)]
        public string Documento { get; set; }

        public virtual CNT_TipoDocumento CNT_TipoDocumento { get; set; }

        public virtual PRE_Rubro PRE_Rubro { get; set; }
    }
}
