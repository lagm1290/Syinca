namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INT_Colegio
    {
        public long id { get; set; }

        public long NoDocumento { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string Servicio { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BaseIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrTotal { get; set; }

        [Required]
        [StringLength(50)]
        public string CCostos { get; set; }

        public long idTercero { get; set; }

        public int Tipoid { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string FormaRecaudo { get; set; }

        public long? NoVolante { get; set; }

        [Required]
        [StringLength(50)]
        public string Matricula { get; set; }

        [Required]
        [StringLength(50)]
        public string IdEstudiante { get; set; }

        [Required]
        [StringLength(250)]
        public string NomEstudiante { get; set; }

        [Required]
        [StringLength(10)]
        public string Categoria { get; set; }
    }
}
