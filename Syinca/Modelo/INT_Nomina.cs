namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INT_Nomina
    {
        public long id { get; set; }

        public long NoDocumento { get; set; }

        public DateTime Fecha { get; set; }

        public int Periodo { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string idConcepto { get; set; }

        [Required]
        [StringLength(150)]
        public string NomConcepto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public int CCostos { get; set; }

        [Required]
        [StringLength(50)]
        public string idTercero { get; set; }

        public int Tipoid { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        public long NoColilla { get; set; }

        [Required]
        [StringLength(50)]
        public string IdTerPatronal { get; set; }

        [Required]
        [StringLength(50)]
        public string IdenPatronal { get; set; }

        [Required]
        [StringLength(150)]
        public string NomPatronal { get; set; }

        [Required]
        [StringLength(2)]
        public string GastosCosto { get; set; }

        [Required]
        [StringLength(50)]
        public string Rubro { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorRetencion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseRetencion { get; set; }
    }
}
