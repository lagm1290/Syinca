namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_TrasladoInternoDet
    {
        public long id { get; set; }

        public long TrasladosInternos { get; set; }

        public int CtaBancaria { get; set; }

        public int CCosto { get; set; }

        public long Tercero { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public virtual TES_TrasladosInternos TES_TrasladosInternos { get; set; }
    }
}
