namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TER_Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public DateTime Fe_Nacimiento { get; set; }

        [Required]
        [StringLength(50)]
        public string Nivel_Educativo { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado_Civil { get; set; }

        [Required]
        [StringLength(2)]
        public string Cabeza_Familia { get; set; }

        public int Personas_Cargo { get; set; }

        public int Estrato { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo_Vivienda { get; set; }

        public int Grupo_Familiar { get; set; }

        [StringLength(150)]
        public string Nombre_Arrendador { get; set; }

        [StringLength(150)]
        public string Telefono_Are { get; set; }

        [StringLength(200)]
        public string Direccion_Are { get; set; }

        [StringLength(150)]
        public string Lugar_Trabajo { get; set; }

        [StringLength(70)]
        public string Ciudad_LT { get; set; }

        [StringLength(150)]
        public string Telefono_LT { get; set; }

        [StringLength(150)]
        public string Direccion_LT { get; set; }

        public int NoHijos { get; set; }

        [StringLength(50)]
        public string Sexo { get; set; }

        [StringLength(10)]
        public string TipoSangre { get; set; }

        public virtual TER_Estado_Civil TER_Estado_Civil { get; set; }

        public virtual TER_Nivel_Educativo TER_Nivel_Educativo { get; set; }

        public virtual TER_Tercero TER_Tercero { get; set; }
    }
}
