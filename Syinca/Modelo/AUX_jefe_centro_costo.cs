namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AUX_jefe_centro_costo
    {
        public int id { get; set; }

        public int Centro_Costo { get; set; }

        public int Jefe { get; set; }

        public DateTime Fe_Inicio { get; set; }

        public DateTime? Fe_Fin { get; set; }

        public bool Activo { get; set; }

        public virtual AUX_Jefe AUX_Jefe { get; set; }

        public virtual MAE_Subcentro MAE_Subcentro { get; set; }
    }
}
