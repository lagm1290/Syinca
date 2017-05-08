namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_RPT_Balance
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public int Periodo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoAnterior { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Debito { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Credito { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaldoNuevo { get; set; }

        public int Nivel { get; set; }

        [Required]
        [StringLength(50)]
        public string Naturaleza { get; set; }

        [Required]
        [StringLength(50)]
        public string Clase { get; set; }

        [Required]
        [StringLength(150)]
        public string NomClase { get; set; }

        [Required]
        [StringLength(50)]
        public string Grupo { get; set; }

        [Required]
        [StringLength(150)]
        public string NomGrupo { get; set; }

        [Required]
        [StringLength(50)]
        public string Cuenta { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Subcuenta { get; set; }

        [Required]
        [StringLength(150)]
        public string NomSubcuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Subcuenta2 { get; set; }

        [Required]
        [StringLength(150)]
        public string NomSubcuenta2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Auxiliar { get; set; }

        [Required]
        [StringLength(150)]
        public string Nomauxiliar { get; set; }
    }
}
