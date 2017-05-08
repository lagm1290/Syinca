namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BYS_CajaUsuario
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Caja { get; set; }

        [Required]
        [StringLength(12)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(2)]
        public string Activo { get; set; }

        [Required]
        [StringLength(50)]
        public string bys_caja_id { get; set; }

        [Required]
        [StringLength(12)]
        public string mae_usuario_id { get; set; }

        public virtual BYS_Caja BYS_Caja { get; set; }

        public virtual BYS_Caja BYS_Caja1 { get; set; }

        public virtual MAE_Usuario MAE_Usuario { get; set; }

        public virtual MAE_Usuario MAE_Usuario1 { get; set; }
    }
}
