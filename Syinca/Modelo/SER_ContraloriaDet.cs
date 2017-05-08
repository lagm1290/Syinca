namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_ContraloriaDet
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NoContrato { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FeSuscripcion { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(12)]
        public string NoVeSireci { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ClaseContrato { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string OtraClase { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(250)]
        public string Objeto { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "numeric")]
        public decimal VrInicial { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(4)]
        public string RecContrato { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(9)]
        public string NITRecEntidad { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(6)]
        public string DVRecEntidad { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(18)]
        public string Naturaleza { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(22)]
        public string TipoID { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string Cedula { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string NIT { get; set; }

        [StringLength(6)]
        public string DVProveedor { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(1)]
        public string CCExtPRoveedor { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(250)]
        public string NomContratista { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(12)]
        public string TipoSeguimiento { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string TipoIDProveedor { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(1)]
        public string CCInterventor { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(1)]
        public string NITInterventor { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(1)]
        public string DVInterventor { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(1)]
        public string CCExtInterventor { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(1)]
        public string NomInterventor { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(22)]
        public string TipoIDSupervisor { get; set; }

        [StringLength(50)]
        public string CCSupervisor { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(1)]
        public string NITSupervisor { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(79)]
        public string DVSupervisor { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(1)]
        public string CCExtSupervisor { get; set; }

        [StringLength(150)]
        public string NomSupervisor { get; set; }

        [Key]
        [Column(Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Plazo { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(13)]
        public string Anticipo { get; set; }

        [Key]
        [Column(Order = 29, TypeName = "numeric")]
        public decimal VrAnticipo { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(45)]
        public string TipoAdicion { get; set; }

        [Key]
        [Column(Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VrAdiciones { get; set; }

        [Key]
        [Column(Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiasAdicion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FeInicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FeTerminacion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FeLiquidacion { get; set; }

        public int? AvanceFP { get; set; }

        public int? AvanceFR { get; set; }

        public int? AvancePP { get; set; }

        public int? AvancePR { get; set; }

        [StringLength(250)]
        public string Observacion { get; set; }
    }
}
