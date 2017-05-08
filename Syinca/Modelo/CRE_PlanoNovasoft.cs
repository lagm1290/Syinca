namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_PlanoNovasoft
    {
        public long id { get; set; }

        public DateTime Fecha { get; set; }

        public int Periodo { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(150)]
        public string Ruta { get; set; }

        public DateTime FeINI { get; set; }

        public DateTime FeFIN { get; set; }

        [StringLength(70)]
        public string Descripcion { get; set; }

        [StringLength(8)]
        public string Fecha_Dispersion { get; set; }

        [StringLength(1)]
        public string Tipo_Cta { get; set; }

        [StringLength(17)]
        public string Nro_Cta { get; set; }

        [StringLength(40)]
        public string Nombre_Empresa { get; set; }

        [StringLength(11)]
        public string Nit { get; set; }

        [StringLength(3)]
        public string Tipo_Movimiento { get; set; }

        [StringLength(4)]
        public string Codigo_Ciudad_Cta { get; set; }

        [StringLength(8)]
        public string Fecha_Aplica_Dispersion { get; set; }

        [StringLength(9)]
        public string Codigo_Oficina_Cta { get; set; }

        [StringLength(1)]
        public string Tipo_Id_Empresa { get; set; }

        [StringLength(1)]
        public string Indicador_Envio { get; set; }
    }
}
