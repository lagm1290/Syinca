namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_sucursales
    {
        public int id { get; set; }

        public long Tercero { get; set; }

        [Required]
        [StringLength(50)]
        public string Vereda { get; set; }

        [Required]
        [StringLength(210)]
        public string Direccion { get; set; }

        [StringLength(250)]
        public string Telefonos { get; set; }

        [StringLength(250)]
        public string Correo { get; set; }

        [Required]
        [StringLength(5)]
        public string Abreviatura { get; set; }

        [StringLength(10)]
        public string Dir_Numero { get; set; }

        [StringLength(50)]
        public string Dir_nomenclatura { get; set; }

        [StringLength(50)]
        public string Dir_Edificio { get; set; }

        [StringLength(50)]
        public string Dir_Apartamento { get; set; }

        [StringLength(50)]
        public string Dir_Barrio { get; set; }

        [Required]
        [StringLength(2)]
        public string Principal { get; set; }

        [StringLength(250)]
        public string Observacion { get; set; }

        [Required]
        [StringLength(10)]
        public string Domicilio { get; set; }

        public virtual MAE_Abreviaturas MAE_Abreviaturas { get; set; }

        public virtual MAE_Vereda MAE_Vereda { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
