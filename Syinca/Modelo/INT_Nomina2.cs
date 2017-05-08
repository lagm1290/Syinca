namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INT_Nomina2
    {
        public long id { get; set; }

        [Required]
        [StringLength(4)]
        public string Anio { get; set; }

        [Required]
        [StringLength(2)]
        public string Mes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sal { get; set; }

        [Required]
        [StringLength(50)]
        public string Id_Transaccion { get; set; }

        [StringLength(50)]
        public string Tipo_Descuento { get; set; }

        [StringLength(50)]
        public string NRO_DOCUMENTO { get; set; }

        [Required]
        [StringLength(50)]
        public string IdTercero { get; set; }

        [StringLength(150)]
        public string ApellidosNombres { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sena { get; set; }

        [Required]
        [StringLength(50)]
        public string IdSena { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ICBF { get; set; }

        [Required]
        [StringLength(50)]
        public string IdICBF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CCF { get; set; }

        [Required]
        [StringLength(50)]
        public string IdCCF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ARL { get; set; }

        [Required]
        [StringLength(50)]
        public string IdARL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaludEmpresa { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SaludTrabajador { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PensionEmpresa { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PensionTrabajador { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Cesantias { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IntCesantias { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Vacaciones { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PrimaLegal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PrimaExtra { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PrimaVacaciones { get; set; }

        public int codigo { get; set; }

        public int Quincena { get; set; }

        public long NDocumento { get; set; }

        [Required]
        [StringLength(50)]
        public string idTerSalud { get; set; }

        [Required]
        [StringLength(50)]
        public string idTerPension { get; set; }

        public int Aprendiz { get; set; }
    }
}
