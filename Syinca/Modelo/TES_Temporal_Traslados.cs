namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TES_Temporal_Traslados
    {
        [Key]
        [Column(Order = 0)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NoComprobante { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string NoAprobacion { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal VrCompobante { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime FeCreacion { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime FeDocumento { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CtaBancaria { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string CtaDestino { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string NoCtaDestino { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Tercero { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "numeric")]
        public decimal VrPendiente { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "numeric")]
        public decimal SaldoPendiente { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string Factura { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string Concepto { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime FeFactura { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Ccosto { get; set; }
    }
}
