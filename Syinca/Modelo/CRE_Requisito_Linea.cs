namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_Requisito_Linea
    {
        public int id { get; set; }

        public int Linea_Credito { get; set; }

        public int Requisitos { get; set; }

        public virtual CRE_Linea_Credito CRE_Linea_Credito { get; set; }

        public virtual CRE_Requisito CRE_Requisito { get; set; }
    }
}
