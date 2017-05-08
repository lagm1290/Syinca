namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_UsuariosPermisos
    {
        public int id { get; set; }

        [Required]
        [StringLength(12)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(100)]
        public string TipoDocumento { get; set; }

        public virtual CNT_TipoDocumento CNT_TipoDocumento { get; set; }

        public virtual MAE_Usuario MAE_Usuario { get; set; }
    }
}
