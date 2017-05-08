namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALM_Bodega
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(150)]
        public string Direccion { get; set; }

        [StringLength(100)]
        public string Telefono { get; set; }

        [StringLength(150)]
        public string Responsable { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }
    }
}
