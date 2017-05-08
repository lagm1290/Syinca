namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRE_CreditosSuperDet
    {
        public long id { get; set; }

        public long CreditosSuper { get; set; }

        public int Credito { get; set; }

        [Required]
        [StringLength(50)]
        public string Modalidad { get; set; }

        [Required]
        [StringLength(10)]
        public string Categoria { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TasaInteres { get; set; }

        [Required]
        [StringLength(10)]
        public string Genero { get; set; }

        public int Cantidad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VrMonto { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreI { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreII { get; set; }

        [Required]
        [StringLength(50)]
        public string ApellidoI { get; set; }

        [Required]
        [StringLength(50)]
        public string ApellidoII { get; set; }

        [Required]
        [StringLength(50)]
        public string MunCliente { get; set; }

        public DateTime FeNacimiento { get; set; }

        [Required]
        [StringLength(150)]
        public string NomEmpresa { get; set; }

        [Required]
        [StringLength(50)]
        public string NITEmpresa { get; set; }

        [Required]
        [StringLength(50)]
        public string MunEmpresa { get; set; }

        public virtual CRE_CreditosSuper CRE_CreditosSuper { get; set; }

        public virtual CRE_Solicitud_Credito CRE_Solicitud_Credito { get; set; }
    }
}
