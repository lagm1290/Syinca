namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_marca_tercero
    {
        public int id { get; set; }

        public long Tercero { get; set; }

        public int Productos { get; set; }

        public virtual TER_Producto TER_Producto { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
