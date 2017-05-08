namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAE_Permisos
    {
        public int id { get; set; }

        [Required]
        [StringLength(12)]
        public string Usuario { get; set; }

        public int Menu { get; set; }

        [Required]
        [StringLength(2)]
        public string Permiso { get; set; }

        public virtual MAE_Menu MAE_Menu { get; set; }

        public virtual MAE_Usuario MAE_Usuario { get; set; }
    }
}
