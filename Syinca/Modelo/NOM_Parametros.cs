namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NOM_Parametros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Anio { get; set; }

        public DateTime FeInicio { get; set; }

        public DateTime FeFin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Salario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AuxTransporte { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaludEmpleado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaludEmpleador { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RiesgoProfecional { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FondoPensionesEmpleado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FondoPensionesEmpleador { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ICBF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SENA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CajaCompensacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Cesantia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IntCesantia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PrimaServicio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Vacaciones { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Esap { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EscuelasIndustriales { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UVT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FondoSolidaridad1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FondoSolidaridad2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FondoSolidaridad3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FondoSolidaridad4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FondoSolidaridad5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FondoSolidaridad6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal HED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal HEN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal HODF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal HEDDF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal HENDF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Retencion { get; set; }
    }
}
