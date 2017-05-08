namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_CajaUsuario
    {
        public int id { get; set; }

        public int? Cuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(2)]
        public string Activo { get; set; }

        public virtual TES_Cuentas_CB TES_Cuentas_CB { get; set; }
    }
}
